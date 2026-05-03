## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF97672E2B0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF97672E778]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF97672E2B0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF97672E778]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L32
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L35
       test      r11d,r11d
       jl        near ptr M00_L35
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L35
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       je        near ptr M00_L17
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF9769F4480]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       edx,[rsi+8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L34
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L35
       test      r10d,r10d
       jl        near ptr M00_L35
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L35
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        short M00_L18
       shr       rdx,3
       call      qword ptr [7FF9769F4480]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r10
       call      qword ptr [7FF9763057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       call      qword ptr [7FF9763057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF97672E2B0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF97672E778]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF97672E2B0]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF97672E778]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L33
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L25
M00_L31:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FF97652CAE0]
       int       3
M00_L33:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L34:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M00_L15
M00_L35:
       call      qword ptr [7FF976B74DC8]
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF97672E2C8]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF97672E2B0]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       edx,[rbp-2C]
       add       edx,1
       jo        short M00_L51
       mov       [rbp-2C],edx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF97672E2C8]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF97672E2B0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M01_L01
M01_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M01_L00
M01_L01:
       cmp       rdx,4
       jb        short M01_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M01_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M01_L03:
       xor       eax,eax
       mov       [rcx],rax
M01_L04:
       ret
M01_L05:
       cmp       rdx,2
       jae       short M01_L02
       test      rdx,rdx
       jne       short M01_L03
       jmp       short M01_L04
; Total bytes of code 114
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L05
       cmp       rdx,40
       ja        short M02_L08
M02_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L04
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L02:
       pop       rbx
       ret
M02_L03:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L03
       jmp       short M02_L10
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L02
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M02_L02
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L02
       mov       word ptr [rbx-2],0
       jmp       short M02_L02
M02_L08:
       cmp       rdx,400
       ja        short M02_L11
       cmp       rdx,100
       jb        short M02_L09
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L09:
       mov       rax,rdx
       shr       rax,6
       jmp       near ptr M02_L03
M02_L10:
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L11:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF976944300]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 234
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C468]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B1D338]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C468]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B1D338]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L32
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L35
       test      r11d,r11d
       jl        near ptr M00_L35
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L35
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L17
       mov       rcx,r10
       call      qword ptr [7FF9763357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L34
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L35
       test      r10d,r10d
       jl        near ptr M00_L35
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L35
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L18
       mov       rcx,r10
       call      qword ptr [7FF9763357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97696E9B8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97696E9B8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C468]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF976B1D338]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C468]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FF976B1D338]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L33
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FF97655C240]
       int       3
M00_L33:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L34:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L35:
       call      qword ptr [7FF976B1E400]
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C570]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C468]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-2C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C570]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C468]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1255
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L04
       cmp       rdx,40
       ja        short M01_L07
M01_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M01_L03
M01_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L02:
       pop       rbx
       ret
M01_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L04:
       test      dl,18
       je        short M01_L05
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L02
M01_L05:
       test      dl,4
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L02
M01_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L02
       mov       word ptr [rbx-2],0
       jmp       short M01_L02
M01_L07:
       cmp       rdx,400
       ja        short M01_L10
       cmp       rdx,100
       jb        short M01_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L08:
       mov       rax,rdx
       shr       rax,6
M01_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L10:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF97696F348]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 227
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M02_L01
M02_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M02_L00
M02_L01:
       cmp       rdx,4
       jb        short M02_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M02_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M02_L03:
       xor       eax,eax
       mov       [rcx],rax
M02_L04:
       ret
M02_L05:
       cmp       rdx,2
       jae       short M02_L02
       test      rdx,rdx
       jne       short M02_L03
       jmp       short M02_L04
; Total bytes of code 114
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C468]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B2D338]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C468]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B2D338]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L32
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L35
       test      r11d,r11d
       jl        near ptr M00_L35
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L35
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       je        near ptr M00_L17
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97697E970]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       edx,[rsi+8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L34
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L35
       test      r10d,r10d
       jl        near ptr M00_L35
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L35
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        short M00_L18
       shr       rdx,3
       call      qword ptr [7FF97697E970]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r10
       call      qword ptr [7FF9763457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       call      qword ptr [7FF9763457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C468]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF976B2D338]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C468]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF976B2D338]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L33
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L25
M00_L31:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FF97656C240]
       int       3
M00_L33:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L34:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M00_L15
M00_L35:
       call      qword ptr [7FF976B2E418]
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B2C570]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C468]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       edx,[rbp-2C]
       add       edx,1
       jo        short M00_L51
       mov       [rbp-2C],edx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B2C570]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C468]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M01_L01
M01_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M01_L00
M01_L01:
       cmp       rdx,4
       jb        short M01_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M01_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M01_L03:
       xor       eax,eax
       mov       [rcx],rax
M01_L04:
       ret
M01_L05:
       cmp       rdx,2
       jae       short M01_L02
       test      rdx,rdx
       jne       short M01_L03
       jmp       short M01_L04
; Total bytes of code 114
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L04
       cmp       rdx,40
       ja        short M02_L07
M02_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L03
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L02:
       pop       rbx
       ret
M02_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L04:
       test      dl,18
       je        short M02_L05
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L02
M02_L05:
       test      dl,4
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L02
M02_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L02
       mov       word ptr [rbx-2],0
       jmp       short M02_L02
M02_L07:
       cmp       rdx,400
       ja        short M02_L10
       cmp       rdx,100
       jb        short M02_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L08:
       mov       rax,rdx
       shr       rax,6
M02_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L10:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF97697F300]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 227
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C4B0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B1D320]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C4B0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B1D320]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L32
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L35
       test      r11d,r11d
       jl        near ptr M00_L35
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L35
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L17
       mov       rcx,r10
       call      qword ptr [7FF9763357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L34
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L35
       test      r10d,r10d
       jl        near ptr M00_L35
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L35
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L18
       mov       rcx,r10
       call      qword ptr [7FF9763357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97696E9B8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97696E9B8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C4B0]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF976B1D320]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C4B0]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF976B1D320]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L33
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L25
M00_L31:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FF97655C240]
       int       3
M00_L33:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L34:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L35:
       call      qword ptr [7FF976B1E460]
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C5B8]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C4B0]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L51
       mov       [rbp-2C],ecx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C5B8]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C4B0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1255
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L04
       cmp       rdx,40
       ja        short M01_L07
M01_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M01_L03
M01_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L02:
       pop       rbx
       ret
M01_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L01
M01_L04:
       test      dl,18
       je        short M01_L05
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L02
M01_L05:
       test      dl,4
       je        short M01_L06
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L02
M01_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L02
       mov       word ptr [rbx-2],0
       jmp       short M01_L02
M01_L07:
       cmp       rdx,400
       ja        short M01_L10
       cmp       rdx,100
       jb        short M01_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L08:
       mov       rax,rdx
       shr       rax,6
M01_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L10:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF97696F348]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 227
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M02_L01
M02_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M02_L00
M02_L01:
       cmp       rdx,4
       jb        short M02_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M02_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M02_L03:
       xor       eax,eax
       mov       [rcx],rax
M02_L04:
       ret
M02_L05:
       cmp       rdx,2
       jae       short M02_L02
       test      rdx,rdx
       jne       short M02_L03
       jmp       short M02_L04
; Total bytes of code 114
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C498]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B2D368]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C498]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B2D368]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L33
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L32
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L31
       test      r11d,r11d
       jl        near ptr M00_L31
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L31
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       je        near ptr M00_L17
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97697E9A0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       edx,[rsi+8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L35
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L31
       test      r10d,r10d
       jl        near ptr M00_L31
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L31
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        short M00_L18
       shr       rdx,3
       call      qword ptr [7FF97697E9A0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r10
       call      qword ptr [7FF9763457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       call      qword ptr [7FF9763457E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C498]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF976B2D368]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C498]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF976B2D368]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L25
M00_L31:
       call      qword ptr [7FF976B2E430]
       int       3
M00_L32:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L33:
       mov       ecx,2
       call      qword ptr [7FF97656C240]
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M00_L15
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B2C5A0]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C498]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       edx,[rbp-2C]
       add       edx,1
       jo        short M00_L51
       mov       [rbp-2C],edx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B2C5A0]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C498]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M01_L01
M01_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M01_L00
M01_L01:
       cmp       rdx,4
       jb        short M01_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M01_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M01_L03:
       xor       eax,eax
       mov       [rcx],rax
M01_L04:
       ret
M01_L05:
       cmp       rdx,2
       jae       short M01_L02
       test      rdx,rdx
       jne       short M01_L03
       jmp       short M01_L04
; Total bytes of code 114
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L04
       cmp       rdx,40
       ja        short M02_L07
M02_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L03
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L02:
       pop       rbx
       ret
M02_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L04:
       test      dl,18
       je        short M02_L05
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L02
M02_L05:
       test      dl,4
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L02
M02_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L02
       mov       word ptr [rbx-2],0
       jmp       short M02_L02
M02_L07:
       cmp       rdx,400
       ja        short M02_L10
       cmp       rdx,100
       jb        short M02_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L08:
       mov       rax,rdx
       shr       rax,6
M02_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L10:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF97697F330]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 227
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L25
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L25
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC438]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976AFD308]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L24
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC438]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976AFD308]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L33
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L32
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L31
       test      r11d,r11d
       jl        near ptr M00_L31
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L31
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       je        near ptr M00_L17
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97694E970]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       edx,[rsi+8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L35
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L31
       test      r10d,r10d
       jl        near ptr M00_L31
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L31
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        short M00_L18
       shr       rdx,3
       call      qword ptr [7FF97694E970]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r10
       call      qword ptr [7FF9763157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       call      qword ptr [7FF9763157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L21
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L22
M00_L20:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L23
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC438]
       int       3
M00_L22:
       mov       rcx,r15
       call      qword ptr [7FF976AFD308]
       jmp       short M00_L20
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L24:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L19
M00_L25:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L28
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L27
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L29
M00_L26:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC438]
       int       3
M00_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L29:
       mov       rcx,r14
       call      qword ptr [7FF976AFD308]
       jmp       short M00_L26
M00_L30:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L34
       test      edi,edi
       jle       short M00_L25
       jmp       near ptr M00_L05
M00_L31:
       call      qword ptr [7FF976AFE3B8]
       int       3
M00_L32:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L33:
       mov       ecx,2
       call      qword ptr [7FF97653C240]
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M00_L15
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AFC540]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC438]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       edx,[rbp-2C]
       add       edx,1
       jo        short M00_L51
       mov       [rbp-2C],edx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AFC540]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC438]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M01_L01
M01_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M01_L00
M01_L01:
       cmp       rdx,4
       jb        short M01_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M01_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M01_L03:
       xor       eax,eax
       mov       [rcx],rax
M01_L04:
       ret
M01_L05:
       cmp       rdx,2
       jae       short M01_L02
       test      rdx,rdx
       jne       short M01_L03
       jmp       short M01_L04
; Total bytes of code 114
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L04
       cmp       rdx,40
       ja        short M02_L07
M02_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L03
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L02:
       pop       rbx
       ret
M02_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L04:
       test      dl,18
       je        short M02_L05
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L02
M02_L05:
       test      dl,4
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L02
M02_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L02
       mov       word ptr [rbx-2],0
       jmp       short M02_L02
M02_L07:
       cmp       rdx,400
       ja        short M02_L10
       cmp       rdx,100
       jb        short M02_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L08:
       mov       rax,rdx
       shr       rax,6
M02_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L10:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF97694F300]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 227
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4B8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B1D3F8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B1D3F8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L33
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L32
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L31
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L35
       test      r11d,r11d
       jl        near ptr M00_L35
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L35
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       je        near ptr M00_L17
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97696E9A0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       edx,[rsi+8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L34
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L35
       test      r10d,r10d
       jl        near ptr M00_L35
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L35
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        short M00_L18
       shr       rdx,3
       call      qword ptr [7FF97696E9A0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r10
       call      qword ptr [7FF9763357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       call      qword ptr [7FF9763357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4B8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF976B1D3F8]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L33
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L33
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4B8]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF976B1D3F8]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L33
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L33
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L25
M00_L31:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,2
       call      qword ptr [7FF97655C240]
       int       3
M00_L33:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L34:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M00_L15
M00_L35:
       call      qword ptr [7FF976B1F138]
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976A1D5D8]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4B8]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       edx,[rbp-2C]
       add       edx,1
       jo        short M00_L51
       mov       [rbp-2C],edx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976A1D5D8]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4B8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M01_L01
M01_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M01_L00
M01_L01:
       cmp       rdx,4
       jb        short M01_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M01_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M01_L03:
       xor       eax,eax
       mov       [rcx],rax
M01_L04:
       ret
M01_L05:
       cmp       rdx,2
       jae       short M01_L02
       test      rdx,rdx
       jne       short M01_L03
       jmp       short M01_L04
; Total bytes of code 114
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L02
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L04
       cmp       rdx,40
       ja        short M02_L07
M02_L00:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L01
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M02_L03
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L02:
       pop       rbx
       ret
M02_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L04:
       test      dl,18
       je        short M02_L05
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L02
M02_L05:
       test      dl,4
       je        short M02_L06
       xor       edx,edx
       mov       [rcx],edx
       mov       [rbx-4],edx
       jmp       short M02_L02
M02_L06:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L02
       mov       word ptr [rbx-2],0
       jmp       short M02_L02
M02_L07:
       cmp       rdx,400
       ja        short M02_L10
       cmp       rdx,100
       jb        short M02_L08
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L08:
       mov       rax,rdx
       shr       rax,6
M02_L09:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L09
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L10:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF97696FCC0]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 227
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Clear()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L19
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L19
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF9769F6448]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L30
M00_L06:
       xor       eax,eax
       mov       [rbp-34],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF9769F6448]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L34
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+10]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+18]
       mov       rax,[rsi+18]
       mov       eax,[rax+8]
       test      rdx,rdx
       je        near ptr M00_L33
       lea       r8,[rdx+10]
       xor       r10d,r10d
       mov       r9,[rdx]
       cmp       dword ptr [r9+4],18
       jne       near ptr M00_L32
M00_L13:
       mov       r11d,r10d
       neg       r11d
       test      r10d,r10d
       jg        near ptr M00_L31
       test      r11d,r11d
       jl        near ptr M00_L31
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L31
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       je        near ptr M00_L17
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF97694E9B8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       edx,[rsi+8]
       lea       rcx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L35
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L31
       test      r10d,r10d
       jl        near ptr M00_L31
       lea       eax,[r10+rdx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L31
       movzx     eax,word ptr [r8]
       mov       r10d,r10d
       imul      r10,rax
       add       rcx,r10
       mov       edx,edx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       je        short M00_L18
       shr       rdx,3
       call      qword ptr [7FF97694E9B8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L16:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L17:
       mov       rcx,r10
       call      qword ptr [7FF9763157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       call      qword ptr [7FF9763157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L16
M00_L19:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L22
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L21
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF9769F6448]
       jmp       short M00_L20
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L34
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L34
       test      edi,edi
       jle       short M00_L19
       jmp       near ptr M00_L05
M00_L25:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L27
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF9769F6448]
       jmp       short M00_L26
M00_L29:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L34
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L30:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L25
M00_L31:
       call      qword ptr [7FF976B3F540]
       int       3
M00_L32:
       mov       r11d,[r9+4]
       add       r11d,0FFFFFFE8
       shr       r11d,3
       movsxd    r10,r11d
       mov       r10d,[r8+r10*4]
       shl       r11d,3
       movsxd    r11,r11d
       add       r8,r11
       jmp       near ptr M00_L13
M00_L33:
       mov       ecx,2
       call      qword ptr [7FF97653C240]
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L35:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rcx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rcx,r10
       jmp       near ptr M00_L15
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L40
M00_L38:
       add       esi,1
       jo        short M00_L43
       cmp       esi,[rbp-2C]
       jl        short M00_L37
M00_L39:
       mov       rax,[rbp-48]
       mov       [rbp-40],rax
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L40:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF9769F5218]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L48
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L49
       mov       [rbp-2C],ecx
M00_L48:
       add       rsp,28
       ret
M00_L49:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L50
       mov       edx,[rbp-2C]
       add       edx,1
       jo        short M00_L51
       mov       [rbp-2C],edx
M00_L50:
       add       rsp,28
       ret
M00_L51:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-2C]
       jge       short M00_L57
M00_L52:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF9769F5218]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L57:
       add       rsp,28
       ret
; Total bytes of code 1249
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M01_L01
M01_L00:
       xor       eax,eax
       mov       [rcx+rdx*8-8],rax
       mov       [rcx+rdx*8-10],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-20],rax
       mov       [rcx+rdx*8-28],rax
       mov       [rcx+rdx*8-30],rax
       mov       [rcx+rdx*8-38],rax
       mov       [rcx+rdx*8-40],rax
       add       rdx,0FFFFFFFFFFFFFFF8
       cmp       rdx,8
       jae       short M01_L00
M01_L01:
       cmp       rdx,4
       jae       short M01_L03
       cmp       rdx,2
       jae       short M01_L04
       test      rdx,rdx
       jne       short M01_L05
M01_L02:
       ret
M01_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M01_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M01_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M01_L02
; Total bytes of code 114
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L03
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L05
       cmp       rdx,40
       jbe       short M02_L04
       cmp       rdx,400
       ja        near ptr M02_L09
       cmp       rdx,100
       jae       near ptr M02_L08
M02_L00:
       mov       rax,rdx
       shr       rax,6
M02_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L01
       and       rdx,3F
       cmp       rdx,10
       ja        short M02_L04
M02_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M02_L03:
       pop       rbx
       ret
M02_L04:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       short M02_L02
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M02_L02
M02_L05:
       test      dl,18
       je        short M02_L06
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L03
M02_L06:
       test      dl,4
       je        short M02_L07
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L03
M02_L07:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L03
       mov       word ptr [rbx-2],0
       jmp       short M02_L03
M02_L08:
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
       jmp       near ptr M02_L00
M02_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF9769F5D88]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 231
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,133C4C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C852C778
       mov       r8d,0AFD70B77
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF976260E68
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976260E70
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1378A400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A5CDAA42
       mov       r8d,88839230
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976280E78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,25CD6800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0B3285F1B
       mov       r8d,5D916B34
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF976260E68
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976260E70
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L11
       mov       rcx,221FC800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F324A297
       mov       r8d,0D73CB8A0
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L09
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       cmp       edx,4
       jb        short M00_L12
M00_L09:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L10:
       xor       eax,eax
       jmp       short M00_L07
M00_L11:
       xor       ebp,ebp
       jmp       near ptr M00_L03
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976280E78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 608
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1EBCE000068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,7B7E8C6B
       mov       r8d,0C58D442E
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF976260E68
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976260E70
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,258CE400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F194383A
       mov       r8d,0B6C42E1E
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF976250E70
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976250E78
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,1F840400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0CD08BF7B
       mov       r8d,0CA0BBE1C
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF9762510F8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF976251100
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       rdi,[rbx+48]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L08
       mov       rcx,[rsi+8]
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L16
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L09
       mov       rcx,16709800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L15
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,8FAB17F6
       mov       r8d,17C8385B
       cmp       edx,8
       jb        near ptr M00_L10
       mov       r10d,edx
       shr       r10d,3
       nop       dword ptr [rax]
M00_L00:
       add       eax,[rcx]
       mov       r9d,[rcx+4]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       add       r9d,eax
       mov       eax,r8d
       xor       eax,r9d
       rol       r9d,14
       add       r9d,eax
       rol       eax,9
       xor       eax,r9d
       rol       r9d,1B
       add       r9d,eax
       rol       eax,13
       mov       r8d,r9d
       add       rcx,8
       dec       r10d
       mov       r9d,eax
       mov       eax,r8d
       mov       r8d,r9d
       jne       short M00_L00
       test      dl,4
       jne       near ptr M00_L11
M00_L01:
       mov       r10d,edx
       and       r10,7
       mov       ecx,[rcx+r10-4]
       shr       ecx,8
       or        ecx,80000000
       not       edx
       shl       edx,3
       shrx      ecx,ecx,edx
M00_L02:
       add       ecx,eax
       mov       edx,r8d
       xor       edx,ecx
       rol       ecx,14
       add       ecx,edx
       rol       edx,9
       xor       edx,ecx
       rol       ecx,1B
       add       ecx,edx
       rol       edx,13
       xor       edx,ecx
       mov       ebp,ecx
       rol       ebp,14
       add       ebp,edx
       rol       edx,9
       xor       edx,ebp
       rol       ebp,1B
       add       ebp,edx
       mov       r14d,edx
       rol       r14d,13
       xor       ebp,r14d
M00_L03:
       mov       rax,[rsi+10]
       mov       [rsp+28],rax
       mov       eax,ebp
       and       eax,7FFFFFFF
       mov       rdx,[rsp+28]
       mov       rcx,[rdx+8]
       cdq
       idiv      dword ptr [rcx+8]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L18
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        short M00_L06
M00_L04:
       cmp       ebp,[r14+18]
       je        near ptr M00_L17
M00_L05:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L04
M00_L06:
       xor       eax,eax
M00_L07:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L08:
       xor       eax,eax
       jmp       short M00_L07
M00_L09:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L10:
       cmp       edx,4
       jb        short M00_L12
M00_L11:
       add       eax,[rcx]
       xor       r8d,eax
       rol       eax,14
       add       eax,r8d
       rol       r8d,9
       xor       r8d,eax
       rol       eax,1B
       add       eax,r8d
       rol       r8d,13
       jmp       near ptr M00_L01
M00_L12:
       mov       r10d,80
       test      dl,1
       je        short M00_L13
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L13:
       test      dl,2
       je        short M00_L14
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L14:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L15:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rdx,rdi
       mov       r11,7FF9762712C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF9762712D0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L05
       mov       eax,1
       jmp       near ptr M00_L07
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 605
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L14
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L17
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L16
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop       dword ptr [rax]
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L22
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        short M00_L26
       cmp       r13d,r14d
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L49
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L60
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L47:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       near ptr M00_L46
M00_L49:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L52
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L51
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r12
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L57
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L58:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976AFD5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        short M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L60:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF976AF55A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976AFF390]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,5243
       mov       rdx,7FF9765F5548
       call      qword ptr [7FF9765377B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF976697BE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AFC888]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976AF5650]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,28029756FB8
       mov       r8,28029756FB8
       call      qword ptr [7FF976AF7FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AFC888]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AFC888]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AFC888]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2203
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L14
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L17
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L16
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop       dword ptr [rax]
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L22
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        short M00_L26
       cmp       r13d,r14d
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L49
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L60
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L47:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       near ptr M00_L46
M00_L49:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L52
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L51
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r12
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L57
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L58:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976AED5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        short M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L60:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF976AE5530]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976AEF300]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,5243
       mov       rdx,7FF9765E5548
       call      qword ptr [7FF9765277B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF976687BE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC7F8]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976AE55D8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,31932D96FB8
       mov       r8,31932D96FB8
       call      qword ptr [7FF976AE7F90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC7F8]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC7F8]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC7F8]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC6F0]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2203
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF976348210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9D5FC31A0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9D6273A10],0
       je        short M01_L01
       call      qword ptr [7FF9D6261648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
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
; Total bytes of code 154
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L16
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L22
M00_L16:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L19
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L18
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r13
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L24
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L25:
       mov       rcx,r12
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L48
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L48
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L47
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       near ptr M00_L55
M00_L46:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L47:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       near ptr M00_L57
M00_L48:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L51
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L50
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L52
M00_L49:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       mov       rcx,r12
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L49
M00_L53:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L48
       jmp       near ptr M00_L36
M00_L54:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L55:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L54
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L56:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L56
       jmp       near ptr M00_L54
M00_L57:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L59
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L60
M00_L58:
       mov       dword ptr [rbp-50],1
       jmp       near ptr M00_L46
M00_L59:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L60:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976AED650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF976AE54D0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976AEF378]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,5243
       mov       rdx,7FF9765E5548
       call      qword ptr [7FF9765277B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF976687BE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC888]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976AE5578]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,27720376FB8
       mov       r8,27720376FB8
       call      qword ptr [7FF976AE7FA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC888]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC888]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976AEC888]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC780]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2223
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF976348210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9D5FC31A0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9D6273A10],0
       je        short M01_L01
       call      qword ptr [7FF9D6261648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
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
; Total bytes of code 154
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L16
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L02
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       test      r15d,r15d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L12
       test      r15,r15
       je        short M00_L06
       cmp       [r15+8],r14d
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L09
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L08
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jl        short M00_L06
M00_L12:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       eax,[rcx+8]
       xor       edx,edx
M00_L13:
       cmp       edx,eax
       jge       near ptr M00_L27
       add       edi,[rcx+rdx*4+10]
       jo        near ptr M00_L26
       add       edx,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r13d,1
       jo        near ptr M00_L26
       cmp       r13d,r14d
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-44],ecx
       jmp       short M00_L22
M00_L16:
       xor       ecx,ecx
       mov       [rbp-40],ecx
       cmp       r15d,[r14+8]
       jae       short M00_L19
       mov       ecx,r15d
       mov       r13,[r14+rcx*8+10]
       test      r13,r13
       je        short M00_L18
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r13
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       test      r15d,r15d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L24
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L25:
       mov       rcx,r12
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       r14d,r14d
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       r14d,1
       jo        near ptr M00_L74
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,edi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       mov       rcx,r14
       mov       edi,[rcx+8]
       mov       ecx,edi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+10]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L49
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+10]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L60
M00_L37:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       r12d,[r13+8]
       jae       short M00_L40
       mov       ecx,r12d
       mov       rcx,[r13+rcx*8+10]
       mov       rax,rcx
       test      rax,rax
       je        short M00_L39
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-68],rax
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-70]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
       mov       rax,[rbp-68]
M00_L47:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,edi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       near ptr M00_L46
M00_L49:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L52
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L51
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r12
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L57
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L58:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        short M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L60:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF976B255A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976B2E898]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,5243
       mov       rdx,7FF976625548
       call      qword ptr [7FF9765677B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9766C7BE8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rdi+8],rax
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976B2C888]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976B25650]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,21E09366FB8
       mov       r8,21E09366FB8
       call      qword ptr [7FF976B2C1B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976B2C888]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976B2C888]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF976B2C888]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C780]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2206
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF976388210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9D5FC31A0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9D6273A10],0
       je        short M01_L01
       call      qword ptr [7FF9D6261648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
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
; Total bytes of code 154
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L46
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L46
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L57
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L46:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L49
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r13
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
       nop       dword ptr [rax]
M00_L51:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L46
       jmp       near ptr M00_L36
M00_L52:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L55:
       mov       rcx,r12
       call      qword ptr [7FF976B2D5F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L57:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L52
M00_L58:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
M00_L59:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L65
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L58
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L60:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L60
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF976B25560]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976B2E838]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,5243
       mov       rdx,7FF976625548
       call      qword ptr [7FF9765677B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9766C7BE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B2C828]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976B25608]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1C549B16FB8
       mov       r8,1C549B16FB8
       call      qword ptr [7FF976B2C1C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B2C828]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B2C828]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B2C828]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C720]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2208
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF976388210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9D5FC31A0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9D6273A10],0
       je        short M01_L01
       call      qword ptr [7FF9D6261648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
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
; Total bytes of code 154
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L49
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L49
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L60
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
M00_L47:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L65
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       short M00_L46
M00_L49:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L52
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L51
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L53
M00_L50:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       mov       rcx,r13
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L50
M00_L54:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L49
       jmp       near ptr M00_L36
M00_L55:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L57
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L58
M00_L56:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L59
M00_L57:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L58:
       mov       rcx,r12
       call      qword ptr [7FF976AFD650]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L56
M00_L59:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        short M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L60:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L55
M00_L61:
       call      qword ptr [7FF976AF55A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976AFE898]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,5243
       mov       rdx,7FF9765F5548
       call      qword ptr [7FF9765377B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF976697BE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AFC888]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976AF5650]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,28500996FB8
       mov       r8,28500996FB8
       call      qword ptr [7FF976AFC1B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AFC888]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AFC888]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AFC888]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC780]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2204
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF976358210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9D5FC31A0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9D6273A10],0
       je        short M01_L01
       call      qword ptr [7FF9D6261648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
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
; Total bytes of code 154
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L46
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L46
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L57
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L46:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L49
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L48
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r13
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
       nop       dword ptr [rax]
M00_L51:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L46
       jmp       near ptr M00_L36
M00_L52:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L55:
       mov       rcx,r12
       call      qword ptr [7FF976B1D740]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L57:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L52
M00_L58:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
M00_L59:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L65
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L58
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L60:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L60
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF976B179F0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976B1F5E8]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,5243
       mov       rdx,7FF976615548
       call      qword ptr [7FF9765577B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9766B7BE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A1D5F0]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976B17A98]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2165EA16FB8
       mov       r8,2165EA16FB8
       call      qword ptr [7FF976A1D410]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A1D5F0]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A1D5F0]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A1D5F0]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976A1D4D0]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2208
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
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       lea       rcx,[rbp+10]
       mov       rax,7FF976378210
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FF9D5FC31A0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FF9D6273A10],0
       je        short M01_L01
       call      qword ptr [7FF9D6261648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rax,[rbp-68]
       mov       [rbx+8],rax
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
; Total bytes of code 154
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CopyTo()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-40],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
       nop       dword ptr [rax+rax]
M00_L04:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-44],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-40],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
       nop
M00_L19:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-3C],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-44],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-3C],0
       jle       short M00_L30
M00_L28:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L69
M00_L29:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-3C]
       jl        short M00_L28
M00_L30:
       movsxd    rdx,esi
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       esi,[rcx+8]
       mov       ecx,esi
       test      ecx,ecx
       jle       near ptr M00_L70
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L51
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L51
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+10]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L50
M00_L37:
       xor       eax,eax
       mov       [rbp-50],eax
       cmp       r13d,[r15+8]
       jae       short M00_L40
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L39
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L64
       or        edx,ecx
       jl        near ptr M00_L61
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L47
M00_L46:
       mov       rcx,[rbp-68]
       add       ecx,1
       jo        near ptr M00_L64
       mov       r8,rcx
M00_L47:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L65
       cmp       r8d,r13d
       jae       near ptr M00_L63
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L46
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L48:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L63
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L64
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L48
       jmp       short M00_L46
M00_L49:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L50:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L57
M00_L51:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L54
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L53
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L55
M00_L52:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L56
M00_L53:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L55:
       mov       rcx,r13
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L52
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L64
       test      r15d,r15d
       jle       short M00_L51
       jmp       near ptr M00_L36
M00_L57:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L59
       mov       rcx,r12
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L60
M00_L58:
       mov       dword ptr [rbp-50],1
       jmp       near ptr M00_L49
M00_L59:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L60:
       mov       rcx,r12
       call      qword ptr [7FF976A16448]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L58
M00_L61:
       call      qword ptr [7FF976B6D920]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF976B6F9C0]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,5243
       mov       rdx,7FF976615548
       call      qword ptr [7FF9765577B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9766B7BE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L63:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L64:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L65:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L68
M00_L66:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+60]
       mov       rdx,[rbp-58]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L69:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A15218]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF976B6D9C8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2D9AA466FB8
       mov       r8,2D9AA466FB8
       call      qword ptr [7FF976A14930]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A15218]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L73:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L74:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L75
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L76
       mov       [rbp-3C],ecx
M00_L75:
       add       rsp,28
       ret
M00_L76:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L77
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L78
       mov       [rbp-3C],ecx
M00_L77:
       add       rsp,28
       ret
M00_L78:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L79
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L80
       mov       [rbp-3C],ecx
M00_L79:
       add       rsp,28
       ret
M00_L80:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L81
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L82
       mov       [rbp-3C],ecx
M00_L81:
       add       rsp,28
       ret
M00_L82:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L88
M00_L83:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A15218]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L89
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L90
       mov       [rbp-48],ecx
M00_L89:
       add       rsp,28
       ret
M00_L90:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L91
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L92
       mov       [rbp-48],ecx
M00_L91:
       add       rsp,28
       ret
M00_L92:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L93
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L94
       mov       [rbp-48],ecx
M00_L93:
       add       rsp,28
       ret
M00_L94:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L95
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L96
       mov       [rbp-48],ecx
M00_L95:
       add       rsp,28
       ret
M00_L96:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L102
M00_L97:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A15218]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L100:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L101:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L102:
       add       rsp,28
       ret
; Total bytes of code 2209
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AE67D8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976AE6820]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AE67D8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976AE6820]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AE67D8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976AE6820]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AE67D8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976AE6820]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AE67F0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976AE67D8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AE67F0]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976AE67D8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 903
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C378]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976B1D248]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C378]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976B1D248]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C378]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976B1D248]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C378]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976B1D248]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B1C480]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C378]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B1C480]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C378]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 903
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B06820]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976A0E088]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B06820]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976A0E088]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976B06820]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976A0E088]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976B06820]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976A0E088]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B06838]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976B06820]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B06838]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976B06820]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 903
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AE6808]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976AE6850]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AE6808]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976AE6850]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AE6808]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976AE6850]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AE6808]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976AE6850]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AE6820]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976AE6808]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AE6820]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976AE6808]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 903
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C390]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976B25D40]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C390]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976B25D40]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C390]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF976B25D40]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C390]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF976B25D40]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B2C498]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C390]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976B2C498]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C390]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 910
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AD6838]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976AD6850]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AD6838]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976AD6850]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AD6838]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976AD6850]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AD6838]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976AD6850]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AD6868]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976AD6838]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976AD6868]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976AD6838]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 903
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L14
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF9769FD4B8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976AFD380]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L25
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF9769FD4B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976AFD380]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L17
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L16
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF9769FD4B8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF976AFD380]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L22
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF9769FD4B8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF976AFD380]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        short M00_L26
       cmp       r15d,edi
       jge       near ptr M00_L12
M00_L25:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF9769FD5D8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF9769FD4B8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF9769FD5D8]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF9769FD4B8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 903
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+10]
       xor       r14d,r14d
       test      rdi,rdi
       je        near ptr M00_L16
       cmp       dword ptr [rdi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-38],eax
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L02
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF976A163E8]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        near ptr M00_L26
       test      r14d,r14d
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+10]
       mov       r15d,1
       cmp       edi,1
       jle       short M00_L12
       test      r14,r14
       je        short M00_L06
       cmp       [r14+8],edi
       jge       near ptr M00_L15
M00_L06:
       xor       eax,eax
       mov       [rbp-3C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L09
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L08
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF976A163E8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       edx,[rax+8]
       xor       r8d,r8d
M00_L13:
       cmp       r8d,edx
       jge       near ptr M00_L27
       add       esi,[rax+r8*4+10]
       jo        near ptr M00_L26
       add       r8d,1
       jo        near ptr M00_L26
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        near ptr M00_L26
       mov       [rbp-34],ecx
       add       r15d,1
       jo        near ptr M00_L26
       cmp       r15d,edi
       jge       short M00_L12
M00_L15:
       xor       eax,eax
       mov       [rbp-3C],eax
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-38],eax
       cmp       r14d,[rdi+8]
       jae       short M00_L19
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L18
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF976A163E8]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L26
       mov       [rbp-34],ecx
       add       r14d,1
       jo        short M00_L26
       test      r14d,r14d
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L24
       mov       rcx,r13
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF976A163E8]
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       xor       edi,edi
       cmp       dword ptr [rbp-34],0
       jle       short M00_L30
M00_L28:
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+60]
       mov       [rcx+38],esi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A15218]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L35
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-34],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L37
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-34],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-38],0
       je        short M00_L39
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-34],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-3C],0
       je        short M00_L41
       mov       ecx,[rbp-34]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-34],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-34]
       jge       short M00_L48
M00_L43:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+10]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF976A15218]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF976A150F8]
       int       3
M00_L46:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       add       rsp,28
       ret
; Total bytes of code 910
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3C0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B1D290]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3C0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B1D290]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3C0]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF976B1D290]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3C0]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF976B1D290]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C4C8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3C0]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C4C8]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3C0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B15D58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B15D58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF976B15D58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF976B15D58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C468]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C468]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976AFD218]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976AFD218]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF976AFD218]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF976AFD218]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AFC450]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AFC450]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976B171C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976B171C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF976B171C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF976B171C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C4E0]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976B1C4E0]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3C0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976AED230]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3C0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976AED230]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3C0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF976AED230]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3C0]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF976AED230]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AEC4C8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3C0]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AEC4C8]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3C0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC3C0]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976AFD290]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC3C0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976AFD290]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC3C0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF976AFD290]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC3C0]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF976AFD290]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AFC4C8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC3C0]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AFC4C8]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC3C0]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L16
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L16
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC378]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF976AED338]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC378]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF976AED338]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jge       short M00_L12
M00_L15:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L22
M00_L16:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L19
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L18
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC378]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF976AED338]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC378]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF976AED338]
       jmp       short M00_L23
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AEC480]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC378]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF976AEC480]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC378]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 927
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rbx,[rcx+278]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+10]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L14
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF9769E4AF8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF9769E5F80]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L28
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+10]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       cmp       r14d,[rdi+8]
       jae       short M00_L09
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L08
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF9769E4AF8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF9769E5F80]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L28
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+18]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rax+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L17
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L16
       mov       rcx,r14
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF9769E4AF8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FF9769E5F80]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L28
       test      edi,edi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L22
       mov       rcx,r15
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF9769E4AF8]
       int       3
M00_L23:
       mov       rcx,r15
       call      qword ptr [7FF9769E5F80]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L28
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-34],ecx
       jmp       short M00_L20
M00_L26:
       add       ecx,1
       jo        short M00_L28
       jmp       near ptr M00_L13
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L29:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       esi,1
       jo        short M00_L39
       cmp       esi,[rbp-2C]
       jl        short M00_L30
M00_L32:
       xor       edi,edi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF9769E5008]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF9769E4AF8]
       int       3
M00_L37:
       mov       edi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L40
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-2C],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L42
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-2C],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L44
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-2C],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L46
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-2C],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L54
M00_L49:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+10]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF9769E5008]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF9769E4AF8]
       int       3
M00_L52:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L53:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L54:
       add       rsp,28
       ret
; Total bytes of code 920
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,1C909800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0EF511D55
       mov       r11d,75A40616
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C390]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B15D88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976280E68
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C498]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C498]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C390]
       int       3
; Total bytes of code 936
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B171F8]
       int       3
M01_L01:
       call      qword ptr [7FF976B1E0D0]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,222B8C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,497FA023
       mov       r11d,0B0062EE1
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3F0]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976AE5D88]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976250E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976250E68
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976AEC4F8]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976AEC4F8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3F0]
       int       3
; Total bytes of code 936
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976AE71E0]
       int       3
M01_L01:
       call      qword ptr [7FF976AEE130]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,251CA000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,5CBE16BC
       mov       r11d,669A07D5
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B0C3F0]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B05D58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976270E78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976270E70
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B0C4F8]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B0C4F8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B0C3F0]
       int       3
; Total bytes of code 936
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B071E0]
       int       3
M01_L01:
       call      qword ptr [7FF976B0E130]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,14036400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,71AF2B59
       mov       r11d,0D7546242
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3F0]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976AED2C0]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976250E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976250E68
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976AEC4F8]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976AEC4F8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976AEC3F0]
       int       3
; Total bytes of code 936
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976AE6A30]
       int       3
M01_L01:
       call      qword ptr [7FF976AEE160]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,21FCD400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,4A585600
       mov       r11d,9C4EB39C
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B1D2A8]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976280E78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C4E0]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C4E0]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3D8]
       int       3
; Total bytes of code 936
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B171C8]
       int       3
M01_L01:
       call      qword ptr [7FF976B1E148]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,2E03D000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0C2A57DCD
       mov       r11d,0BFF3DCA8
       cmp       eax,8
       jb        near ptr M00_L16
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L17
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       ebx,eax
       rol       ebx,14
       add       ebx,r10d
       rol       r10d,9
       xor       r10d,ebx
       rol       ebx,1B
       add       ebx,r10d
       mov       esi,r10d
       rol       esi,13
       xor       ebx,esi
M00_L03:
       mov       [rbp-2C],ebx
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       esi,[rbp-2C]
       mov       eax,esi
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       r14d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r14d
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-48],0
       je        short M00_L09
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdi,rax
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L08
M00_L06:
       cmp       esi,[r15+18]
       je        short M00_L11
M00_L07:
       lea       rdi,[r15+10]
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B0C360]
       int       3
M00_L10:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF976B0D230]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-38]
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-40]
       mov       r11,7FF976270E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L12
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       cmp       eax,4
       jb        short M00_L19
M00_L17:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L18:
       xor       ebx,ebx
       jmp       near ptr M00_L03
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976270E68
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976B0C468]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       je        short M00_L30
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976B0C468]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B0C360]
       int       3
; Total bytes of code 932
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B07210]
       int       3
M01_L01:
       call      qword ptr [7FF976B0E0D0]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,1EE2E000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,4FDDA15D
       mov       r11d,576ECDD0
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       ebx,eax
       rol       ebx,14
       add       ebx,r10d
       rol       r10d,9
       xor       r10d,ebx
       rol       ebx,1B
       add       ebx,r10d
       mov       esi,r10d
       rol       esi,13
       xor       ebx,esi
M00_L03:
       mov       [rbp-2C],ebx
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       esi,[rbp-2C]
       mov       eax,esi
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       r14d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r14d
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-48],0
       je        short M00_L09
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdi,rax
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L08
M00_L06:
       cmp       esi,[r15+18]
       je        short M00_L11
M00_L07:
       lea       rdi,[r15+10]
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976ABC900]
       int       3
M00_L10:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF976AB6B50]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-38]
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-40]
       mov       r11,7FF976250F78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L12
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF976250F70
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976ABC0A8]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       je        short M00_L30
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976ABC0A8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976ABC900]
       int       3
; Total bytes of code 932
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976AB7030]
       int       3
M01_L01:
       call      qword ptr [7FF976ABDDA0]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Remove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L26
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L23
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L16
       mov       r10,25079000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L22
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0F2FA0517
       mov       r11d,0E28AA44E
       cmp       eax,8
       jb        near ptr M00_L17
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L18
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       ebx,eax
       rol       ebx,14
       add       ebx,r10d
       rol       r10d,9
       xor       r10d,ebx
       rol       ebx,1B
       add       ebx,r10d
       mov       esi,r10d
       rol       esi,13
       xor       ebx,esi
M00_L03:
       mov       [rbp-2C],ebx
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       esi,[rbp-2C]
       mov       eax,esi
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       r14d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r14d
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-48],0
       je        short M00_L09
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L25
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdi,rax
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L08
M00_L06:
       cmp       esi,[r15+18]
       je        short M00_L11
M00_L07:
       lea       rdi,[r15+10]
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
M00_L10:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF9769F6448]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-38]
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-40]
       mov       r11,7FF9762612C8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L12
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L24
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       near ptr M00_L03
M00_L17:
       cmp       eax,4
       jb        short M00_L19
M00_L18:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L19:
       mov       ebx,80
       test      al,1
       je        short M00_L20
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L20:
       test      al,2
       je        short M00_L21
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L21:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L23:
       mov       rcx,rax
       mov       r11,7FF9762612C0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF9769F5218]
       jmp       near ptr M00_L15
M00_L25:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L26:
       xor       ebx,ebx
       jmp       near ptr M00_L15
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       je        short M00_L30
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF9769F5218]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF9769F50F8]
       int       3
; Total bytes of code 932
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF97694FAB0]
       int       3
M01_L01:
       call      qword ptr [7FF976B3F360]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L17
       mov       r10,15AF3C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0A87EA33D
       mov       r11d,0D867E3EF
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L07
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L08
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       jne       short M00_L09
M00_L06:
       xor       ebx,ebx
       jmp       near ptr M00_L14
M00_L07:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3A8]
       int       3
M00_L08:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B15D40]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L09:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       jne       short M00_L10
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L11
M00_L10:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L09
       jmp       short M00_L06
M00_L11:
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L17:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L18:
       cmp       eax,4
       jb        short M00_L20
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976280E68
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C4B0]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C4B0]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C3A8]
       int       3
; Total bytes of code 938
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B17198]
       int       3
M01_L01:
       call      qword ptr [7FF976B1E0E8]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L17
       mov       r10,28D12000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0C28D68EC
       mov       r11d,0C16A81DF
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C348]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B15D70]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L17:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L18:
       cmp       eax,4
       jb        short M00_L20
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976280E68
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C4F8]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C4F8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C348]
       int       3
; Total bytes of code 933
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B171F8]
       int       3
M01_L01:
       call      qword ptr [7FF976B1E0A0]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L18
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,21A80000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0B4F98B74
       mov       r11d,0EAD80B94
       cmp       eax,8
       jb        near ptr M00_L16
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L17
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B15D28]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976280E78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       cmp       eax,4
       jb        short M00_L20
M00_L17:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L18:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976280E70
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C468]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B1C468]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B1C360]
       int       3
; Total bytes of code 933
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B171C8]
       int       3
M01_L01:
       call      qword ptr [7FF976B1E0A0]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L17
       mov       r10,1382E400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0A4D5BB12
       mov       r11d,0C995C19F
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976AF7060]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976260E78
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L17:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L18:
       cmp       eax,4
       jb        short M00_L20
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976260E70
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976AFC450]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976AFC450]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976AFC348]
       int       3
; Total bytes of code 933
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976AF71B0]
       int       3
M01_L01:
       call      qword ptr [7FF976AFE0A0]
       int       3
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
       call      qword ptr [7FF9C3974030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9C3974038]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-30],r8
       mov       rdx,[rcx+48]
       mov       [rbp-38],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L17
       mov       r10,17284000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0E94B7FC3
       mov       r11d,2F648BD6
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       r9d,eax
       rol       r9d,14
       add       r9d,r10d
       rol       r10d,9
       xor       r10d,r9d
       rol       r9d,1B
       add       r9d,r10d
       rol       r10d,13
       xor       r10d,r9d
M00_L03:
       mov       [rbp-24],r10d
M00_L04:
       mov       r8,[rbp-30]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-24]
       mov       eax,r11d
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       esi,edx
       mov       eax,esi
       cdq
       idiv      r9d
       mov       edi,edx
       cmp       edi,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-28],ecx
       cmp       qword ptr [rbp-40],0
       je        short M00_L09
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-28],1
       mov       r8,[rbp-30]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rsi,rax
       mov       r14,[rsi]
       test      r14,r14
       je        short M00_L08
M00_L06:
       mov       r11d,[rbp-24]
       cmp       r11d,[r14+18]
       je        short M00_L11
M00_L07:
       lea       rsi,[r14+10]
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C3C0]
       int       3
M00_L10:
       mov       rcx,[rbp-40]
       call      qword ptr [7FF976B2D290]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-30]
       mov       rcx,[r8+8]
       mov       rdx,[r14+8]
       mov       r8,[rbp-38]
       mov       r11,7FF976290E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r14+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L12
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L17:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L18:
       cmp       eax,4
       jb        short M00_L20
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976290E68
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B2C4C8]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L29
       cmp       qword ptr [rbp-40],0
       je        short M00_L30
       mov       rcx,[rbp-40]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-40]
       call      qword ptr [7FF976B2C4C8]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C3C0]
       int       3
; Total bytes of code 933
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B271F8]
       int       3
M01_L01:
       call      qword ptr [7FF976B2E130]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L18
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1D585000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,22A9E960
       mov       r11d,0BB549A9
       cmp       eax,8
       jb        near ptr M00_L16
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L17
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       ebx,eax
       rol       ebx,14
       add       ebx,r10d
       rol       r10d,9
       xor       r10d,ebx
       rol       ebx,1B
       add       ebx,r10d
       mov       esi,r10d
       rol       esi,13
       xor       ebx,esi
M00_L03:
       mov       [rbp-2C],ebx
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       esi,[rbp-2C]
       mov       eax,esi
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       r14d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r14d
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-48],0
       je        short M00_L09
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdi,rax
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L08
M00_L06:
       cmp       esi,[r15+18]
       je        short M00_L11
M00_L07:
       lea       rdi,[r15+10]
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C3A8]
       int       3
M00_L10:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF976B2D290]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-38]
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-40]
       mov       r11,7FF976290E70
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L12
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       cmp       eax,4
       jb        short M00_L20
M00_L17:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L18:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L19:
       xor       ebx,ebx
       jmp       near ptr M00_L03
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976290E68
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976B2C4B0]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       je        short M00_L30
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976B2C4B0]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B2C3A8]
       int       3
; Total bytes of code 929
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF976B26928]
       int       3
M01_L01:
       call      qword ptr [7FF976B2E118]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L17
       mov       r10,256B0C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,2806D348
       mov       r11d,9041CA
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       ebx,eax
       rol       ebx,14
       add       ebx,r10d
       rol       r10d,9
       xor       r10d,ebx
       rol       ebx,1B
       add       ebx,r10d
       mov       esi,r10d
       rol       esi,13
       xor       ebx,esi
M00_L03:
       mov       [rbp-2C],ebx
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       esi,[rbp-2C]
       mov       eax,esi
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       r14d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r14d
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-48],0
       je        short M00_L09
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdi,rax
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L08
M00_L06:
       cmp       esi,[r15+18]
       je        short M00_L11
M00_L07:
       lea       rdi,[r15+10]
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976B0C9D8]
       int       3
M00_L10:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF976B07FD8]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-38]
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-40]
       mov       r11,7FF976280FD8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L12
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L17:
       xor       ebx,ebx
       jmp       near ptr M00_L03
M00_L18:
       cmp       eax,4
       jb        short M00_L20
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF976280FD0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976B0C000]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       je        short M00_L30
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976B0C000]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976B0C9D8]
       int       3
; Total bytes of code 929
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF9769F7B10]
       int       3
M01_L01:
       call      qword ptr [7FF976B0E610]
       int       3
; Total bytes of code 45
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.TryRemove()
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+278]
       mov       [rbp-38],r8
       mov       rdx,[rcx+48]
       mov       [rbp-40],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L24
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L17
       mov       r10,159D3C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L23
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0FC018CEC
       mov       r11d,5A2F7762
       cmp       eax,8
       jb        near ptr M00_L18
       mov       ebx,eax
       shr       ebx,3
M00_L00:
       add       r9d,[r10]
       mov       esi,[r10+4]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       add       esi,r9d
       mov       r9d,r11d
       xor       r9d,esi
       rol       esi,14
       add       esi,r9d
       rol       r9d,9
       xor       r9d,esi
       rol       esi,1B
       add       esi,r9d
       rol       r9d,13
       mov       r11d,esi
       add       r10,8
       dec       ebx
       mov       ecx,r9d
       mov       r9d,r11d
       mov       r11d,ecx
       jne       short M00_L00
       test      al,4
       jne       near ptr M00_L19
M00_L01:
       mov       ebx,eax
       and       rbx,7
       mov       r10d,[r10+rbx-4]
       shr       r10d,8
       or        r10d,80000000
       not       eax
       shl       eax,3
       shrx      eax,r10d,eax
M00_L02:
       add       eax,r9d
       mov       r10d,r11d
       xor       r10d,eax
       rol       eax,14
       add       eax,r10d
       rol       r10d,9
       xor       r10d,eax
       rol       eax,1B
       add       eax,r10d
       rol       r10d,13
       xor       r10d,eax
       mov       ebx,eax
       rol       ebx,14
       add       ebx,r10d
       rol       r10d,9
       xor       r10d,ebx
       rol       ebx,1B
       add       ebx,r10d
       mov       esi,r10d
       rol       esi,13
       xor       ebx,esi
M00_L03:
       mov       [rbp-2C],ebx
M00_L04:
       mov       r8,[rbp-38]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+10]
       mov       r9d,[r10+8]
       mov       esi,[rbp-2C]
       mov       eax,esi
       and       eax,7FFFFFFF
       cdq
       idiv      ecx
       mov       edi,edx
       mov       eax,edi
       cdq
       idiv      r9d
       mov       r14d,edx
       cmp       r14d,[r10+8]
       jae       near ptr M00_L27
       mov       ecx,r14d
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-48],0
       je        short M00_L09
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2D60
       test      eax,eax
       je        short M00_L10
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-38]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L26
       mov       rcx,[rbx+8]
       movsxd    rdx,edi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdi,rax
       mov       r15,[rdi]
       test      r15,r15
       je        short M00_L08
M00_L06:
       cmp       esi,[r15+18]
       je        short M00_L11
M00_L07:
       lea       rdi,[r15+10]
       mov       r15,[r15+10]
       test      r15,r15
       jne       short M00_L06
M00_L08:
       xor       ebx,ebx
       jmp       short M00_L14
M00_L09:
       xor       ecx,ecx
       call      qword ptr [7FF976A05428]
       int       3
M00_L10:
       mov       rcx,[rbp-48]
       call      qword ptr [7FF976A04708]
       jmp       short M00_L05
M00_L11:
       mov       r8,[rbp-38]
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-40]
       mov       r11,7FF9762812A8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       mov       rdx,[r15+10]
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rbx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L12
       mov       eax,r14d
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L13
       mov       [rcx],eax
       mov       ebx,1
       jmp       short M00_L14
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L14:
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       jne       near ptr M00_L25
M00_L15:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+60]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L16:
       xor       ebx,ebx
       jmp       short M00_L15
M00_L17:
       xor       ebx,ebx
       jmp       near ptr M00_L03
M00_L18:
       cmp       eax,4
       jb        short M00_L20
M00_L19:
       add       r9d,[r10]
       xor       r11d,r9d
       rol       r9d,14
       add       r9d,r11d
       rol       r11d,9
       xor       r11d,r9d
       rol       r9d,1B
       add       r9d,r11d
       rol       r11d,13
       jmp       near ptr M00_L01
M00_L20:
       mov       ebx,80
       test      al,1
       je        short M00_L21
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L21:
       test      al,2
       je        short M00_L22
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L22:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L23:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,rax
       mov       r11,7FF9762812A0
       call      qword ptr [r11]
       mov       ebx,eax
       jmp       near ptr M00_L03
M00_L25:
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976A04720]
       jmp       near ptr M00_L15
M00_L26:
       call      M00_L28
       jmp       near ptr M00_L04
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L28:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L29
       cmp       qword ptr [rbp-48],0
       je        short M00_L30
       mov       rcx,[rbp-48]
       call      00007FF9D5FC2C80
       test      eax,eax
       je        short M00_L29
       mov       ecx,eax
       mov       rdx,[rbp-48]
       call      qword ptr [7FF976A04720]
M00_L29:
       nop
       add       rsp,28
       ret
M00_L30:
       xor       ecx,ecx
       call      qword ptr [7FF976A05428]
       int       3
; Total bytes of code 929
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       add       rsp,28
       ret
M01_L00:
       call      qword ptr [7FF97698F318]
       int       3
M01_L01:
       call      qword ptr [7FF976B5E910]
       int       3
; Total bytes of code 45
```

