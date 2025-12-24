## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04738]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA05DE8]
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
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04738]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA05DE8]
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
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       call      qword ptr [7FF91A0757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF91A0757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
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
       call      qword ptr [7FF91A844390]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L18:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A844390]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L20:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L24
M00_L21:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04738]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91AA05DE8]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L28
M00_L26:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L29
M00_L27:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04738]
       int       3
M00_L28:
       mov       rcx,r15
       call      qword ptr [7FF91AA05DE8]
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
       call      qword ptr [7FF91A2FC1C8]
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
       call      qword ptr [7FF91AA0E568]
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91AA05230]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04738]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA05230]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04738]
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
       jmp       qword ptr [7FF91A844D20]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 231
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
       jae       short M02_L05
       cmp       rdx,2
       jae       short M02_L04
       test      rdx,rdx
       je        short M02_L03
M02_L02:
       xor       eax,eax
       mov       [rcx],rax
M02_L03:
       ret
M02_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
       jmp       short M02_L02
M02_L05:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
       jmp       short M02_L04
; Total bytes of code 116
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L20
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L20
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34720]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA35DD0]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L19
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34720]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA35DD0]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L26
       mov       rcx,r10
       call      qword ptr [7FF91A0A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A874318]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L19:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L27
M00_L20:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L23
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L24
M00_L21:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L25
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34720]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FF91AA35DD0]
       jmp       short M00_L21
M00_L25:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L20
       jmp       near ptr M00_L05
M00_L26:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A874318]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L27:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L29
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L30
M00_L28:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L18
M00_L29:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34720]
       int       3
M00_L30:
       mov       rcx,r15
       call      qword ptr [7FF91AA35DD0]
       jmp       short M00_L28
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
       call      qword ptr [7FF91A32C1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AA3E568]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91AA35218]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34720]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA35218]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34720]
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
; Total bytes of code 1263
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        near ptr M01_L04
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       near ptr M01_L06
       cmp       rdx,40
       jbe       short M01_L02
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jb        short M01_L00
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L00:
       mov       rax,rdx
       shr       rax,6
       nop       dword ptr [rax]
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       jbe       short M01_L03
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L03
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M01_L05
M01_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L04:
       pop       rbx
       ret
M01_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
M01_L06:
       test      dl,18
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L04
M01_L07:
       test      dl,4
       je        short M01_L08
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L04
M01_L08:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L04
       mov       word ptr [rbx-2],0
       jmp       short M01_L04
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF91A874CA8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 234
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L18
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24720]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA25E48]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L29
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24720]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA25E48]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L30
       mov       rcx,r10
       call      qword ptr [7FF91A0957E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0957E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A864318]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L21
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L20
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24720]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF91AA25E48]
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L26
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24720]
       int       3
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FF91AA25E48]
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L29:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A864318]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
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
       call      qword ptr [7FF91A31C1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AA2E550]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91AA25218]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24720]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA25218]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24720]
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
; Total bytes of code 1256
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        near ptr M01_L04
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       near ptr M01_L06
       cmp       rdx,40
       jbe       short M01_L02
       cmp       rdx,400
       ja        near ptr M01_L09
       cmp       rdx,100
       jb        short M01_L00
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L00:
       mov       rax,rdx
       shr       rax,6
       nop       dword ptr [rax]
M01_L01:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L01
       and       rdx,3F
       cmp       rdx,10
       jbe       short M01_L03
M01_L02:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       short M01_L03
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       ja        short M01_L05
M01_L03:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
M01_L04:
       pop       rbx
       ret
M01_L05:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
M01_L06:
       test      dl,18
       je        short M01_L07
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L04
M01_L07:
       test      dl,4
       je        short M01_L08
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L04
M01_L08:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L04
       mov       word ptr [rbx-2],0
       jmp       short M01_L04
M01_L09:
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF91A864CA8]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 234
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L18
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA246A8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA25D58]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L29
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA246A8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA25D58]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L30
       mov       rcx,r10
       call      qword ptr [7FF91A0957E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0957E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8641F8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L21
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L20
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF91AA246A8]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF91AA25D58]
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L26
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF91AA246A8]
       int       3
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FF91AA25D58]
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L29:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8641F8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
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
       call      qword ptr [7FF91A31C1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AA2E4F0]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91AA251A0]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91AA246A8]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA251A0]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA246A8]
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
; Total bytes of code 1256
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L00
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L02
       cmp       rdx,40
       jbe       short M01_L01
       cmp       rdx,400
       jbe       short M01_L05
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF91A864B88]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
M01_L00:
       pop       rbx
       ret
M01_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       near ptr M01_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       near ptr M01_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L08
M01_L02:
       test      dl,18
       je        short M01_L03
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L00
M01_L03:
       test      dl,4
       je        short M01_L04
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L00
M01_L04:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L00
       mov       word ptr [rbx-2],0
       jmp       short M01_L00
M01_L05:
       cmp       rdx,100
       jb        short M01_L06
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L06:
       mov       rax,rdx
       shr       rax,6
M01_L07:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L07
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M01_L01
M01_L08:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
       jmp       near ptr M01_L00
; Total bytes of code 238
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L18
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA35D58]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L29
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA35D58]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L30
       mov       rcx,r10
       call      qword ptr [7FF91A0A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8741F8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L21
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L20
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF91AA35D58]
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L26
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
       int       3
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FF91AA35D58]
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L29:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8741F8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
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
       call      qword ptr [7FF91A32C1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AA3E4F0]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91AA351A0]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA351A0]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
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
; Total bytes of code 1256
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L00
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L02
       cmp       rdx,40
       jbe       short M01_L01
       cmp       rdx,400
       jbe       short M01_L05
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF91A874B88]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
M01_L00:
       pop       rbx
       ret
M01_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       near ptr M01_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       near ptr M01_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L08
M01_L02:
       test      dl,18
       je        short M01_L03
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L00
M01_L03:
       test      dl,4
       je        short M01_L04
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L00
M01_L04:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L00
       mov       word ptr [rbx-2],0
       jmp       short M01_L00
M01_L05:
       cmp       rdx,100
       jb        short M01_L06
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L06:
       mov       rax,rdx
       shr       rax,6
M01_L07:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L07
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M01_L01
M01_L08:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
       jmp       near ptr M01_L00
; Total bytes of code 238
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L18
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A935680]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91A93D3E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L29
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A935680]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91A93D3E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L30
       mov       rcx,r10
       call      qword ptr [7FF91A0757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0757E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A844330]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L21
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L20
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF91A935680]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF91A93D3E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L26
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF91A935680]
       int       3
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FF91A93D3E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L29:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A844330]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
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
       call      qword ptr [7FF91A2FC1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AA0E550]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91A935698]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91A935680]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91A935698]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91A935680]
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
; Total bytes of code 1256
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M02_L00
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M02_L02
       cmp       rdx,40
       jbe       short M02_L01
       cmp       rdx,400
       jbe       short M02_L05
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF91A844CC0]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
M02_L00:
       pop       rbx
       ret
M02_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       near ptr M02_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       near ptr M02_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L08
M02_L02:
       test      dl,18
       je        short M02_L03
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M02_L00
M02_L03:
       test      dl,4
       je        short M02_L04
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M02_L00
M02_L04:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M02_L00
       mov       word ptr [rbx-2],0
       jmp       short M02_L00
M02_L05:
       cmp       rdx,100
       jb        short M02_L06
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M02_L06:
       mov       rax,rdx
       shr       rax,6
M02_L07:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M02_L07
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M02_L01
M02_L08:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
       jmp       near ptr M02_L00
; Total bytes of code 238
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
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
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jb        short M03_L05
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L02:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L03:
       xor       eax,eax
       mov       [rcx],rax
M03_L04:
       ret
M03_L05:
       cmp       rdx,2
       jae       short M03_L02
       test      rdx,rdx
       jne       short M03_L03
       jmp       short M03_L04
; Total bytes of code 114
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L20
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L20
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A936610]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91A93EE80]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L19
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A936610]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91A93EE80]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L26
       mov       rcx,r10
       call      qword ptr [7FF91A0857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0857E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8541E0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L19:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L27
M00_L20:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L23
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L24
M00_L21:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L25
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A936610]
       int       3
M00_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L24:
       mov       rcx,r14
       call      qword ptr [7FF91A93EE80]
       jmp       short M00_L21
M00_L25:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L20
       jmp       near ptr M00_L05
M00_L26:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8541E0]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
M00_L27:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L29
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L30
M00_L28:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L18
M00_L29:
       xor       ecx,ecx
       call      qword ptr [7FF91A936610]
       int       3
M00_L30:
       mov       rcx,r15
       call      qword ptr [7FF91A93EE80]
       jmp       short M00_L28
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
       call      qword ptr [7FF91A30C1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AA1F9C0]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91A936628]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91A936610]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91A936628]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91A936610]
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
; Total bytes of code 1263
```
```assembly
; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       push      rbx
       test      rdx,rdx
       je        short M01_L00
       lea       rbx,[rcx+rdx]
       cmp       rdx,10
       jbe       short M01_L02
       cmp       rdx,40
       jbe       short M01_L01
       cmp       rdx,400
       jbe       short M01_L05
       cmp       [rcx],cl
       pop       rbx
       jmp       qword ptr [7FF91A854B70]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
M01_L00:
       pop       rbx
       ret
M01_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx],xmm0
       cmp       rdx,20
       jbe       near ptr M01_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+10],xmm0
       cmp       rdx,30
       jbe       near ptr M01_L08
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L08
M01_L02:
       test      dl,18
       je        short M01_L03
       xor       eax,eax
       mov       [rcx],rax
       mov       [rbx-8],rax
       jmp       short M01_L00
M01_L03:
       test      dl,4
       je        short M01_L04
       xor       eax,eax
       mov       [rcx],eax
       mov       [rbx-4],eax
       jmp       short M01_L00
M01_L04:
       mov       byte ptr [rcx],0
       test      dl,2
       je        short M01_L00
       mov       word ptr [rbx-2],0
       jmp       short M01_L00
M01_L05:
       cmp       rdx,100
       jb        short M01_L06
       mov       rax,rcx
       and       rax,3F
       neg       rax
       add       rax,40
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,rax
       sub       rdx,rax
M01_L06:
       mov       rax,rdx
       shr       rax,6
M01_L07:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       dec       rax
       jne       short M01_L07
       and       rdx,3F
       cmp       rdx,10
       ja        near ptr M01_L01
M01_L08:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx-10],xmm0
       jmp       near ptr M01_L00
; Total bytes of code 238
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rcx+10]
       mov       rsi,[rax+18]
       xor       edi,edi
       test      rsi,rsi
       je        near ptr M00_L18
       cmp       dword ptr [rsi+8],0
       jle       near ptr M00_L18
M00_L00:
       xor       eax,eax
       mov       [rbp-30],eax
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L02
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A876C10]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91A984108]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbp-48]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       esi,[rax+8]
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
       mov       r14d,1
       cmp       esi,1
       jle       short M00_L12
       test      rdi,rdi
       je        short M00_L06
       cmp       [rdi+8],esi
       jge       near ptr M00_L29
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A876C10]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91A984108]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L35
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       mov       rcx,[rbp-48]
       mov       rsi,[rcx+10]
       mov       rdx,[rsi+18]
       mov       edi,[rdx+8]
       mov       rdx,[rsi+10]
       mov       rax,[rsi+10]
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
       jg        near ptr M00_L34
       test      r11d,r11d
       jl        near ptr M00_L34
       lea       r10d,[r11+rax]
       cmp       r10d,[rdx+8]
       ja        near ptr M00_L34
       movzx     edx,word ptr [r9]
       mov       r10d,r11d
       imul      r10,rdx
       add       r10,r8
       mov       eax,eax
       imul      rdx,rax
       test      dword ptr [r9],1000000
       jne       near ptr M00_L30
       mov       rcx,r10
       call      qword ptr [7FF91A0A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
M00_L14:
       mov       rsi,[rsi+8]
       mov       ecx,[rsi+8]
       lea       rdx,[rsi+10]
       xor       eax,eax
       mov       r8,[rsi]
       cmp       dword ptr [r8+4],18
       jne       near ptr M00_L33
M00_L15:
       mov       r10d,eax
       neg       r10d
       test      eax,eax
       jg        near ptr M00_L34
       test      r10d,r10d
       jl        near ptr M00_L34
       lea       eax,[r10+rcx]
       cmp       eax,[rsi+8]
       ja        near ptr M00_L34
       movzx     eax,word ptr [r8]
       imul      r10,rax
       add       r10,rdx
       mov       edx,ecx
       imul      rdx,rax
       test      dword ptr [r8],1000000
       jne       short M00_L16
       mov       rcx,r10
       call      qword ptr [7FF91A0A57E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       jmp       short M00_L17
M00_L16:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8741F8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
M00_L17:
       mov       eax,[rsi+8]
       xor       edx,edx
       div       edi
       mov       ecx,1
       cmp       eax,1
       cmovg     ecx,eax
       mov       rax,[rbp-48]
       mov       [rax+18],ecx
       jmp       near ptr M00_L36
M00_L18:
       xor       eax,eax
       mov       [rbp-30],eax
       cmp       edi,[rsi+8]
       jae       short M00_L21
       mov       eax,edi
       mov       r14,[rsi+rax*8+10]
       test      r14,r14
       je        short M00_L20
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L22
M00_L19:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L23
M00_L20:
       xor       ecx,ecx
       call      qword ptr [7FF91A876C10]
       int       3
M00_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF91A984108]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L19
M00_L23:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L35
       test      edi,edi
       jle       short M00_L18
       jmp       near ptr M00_L05
M00_L24:
       mov       eax,r14d
       mov       r15,[rdi+rax*8+10]
       test      r15,r15
       je        short M00_L26
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L27
M00_L25:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L28
M00_L26:
       xor       ecx,ecx
       call      qword ptr [7FF91A876C10]
       int       3
M00_L27:
       mov       rcx,r15
       call      qword ptr [7FF91A984108]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L25
M00_L28:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L35
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        short M00_L35
       cmp       r14d,esi
       jge       near ptr M00_L12
M00_L29:
       xor       eax,eax
       mov       [rbp-34],eax
       jmp       short M00_L24
M00_L30:
       shr       rdx,3
       mov       rcx,r10
       call      qword ptr [7FF91A8741F8]; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       jmp       near ptr M00_L14
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
       call      qword ptr [7FF91A32C1C8]
       int       3
M00_L33:
       mov       r10d,[r8+4]
       add       r10d,0FFFFFFE8
       shr       r10d,3
       movsxd    rax,r10d
       mov       eax,[rdx+rax*4]
       shl       r10d,3
       movsxd    r10,r10d
       add       rdx,r10
       jmp       near ptr M00_L15
M00_L34:
       call      qword ptr [7FF91AC14678]
       int       3
M00_L35:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L36:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L39
M00_L37:
       mov       rax,[rbp-48]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L42
       mov       edx,esi
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L41
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91A877750]
       jmp       short M00_L38
M00_L41:
       xor       ecx,ecx
       call      qword ptr [7FF91A876C10]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L55
       mov       edx,esi
       mov       rdi,[rax+rdx*8+10]
       test      rdi,rdi
       je        short M00_L54
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L53
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91A877750]
M00_L53:
       add       esi,1
       jo        short M00_L56
       cmp       esi,[rbp-2C]
       jl        short M00_L52
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91A876C10]
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
; Total bytes of code 1256
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
       jmp       qword ptr [7FF91A877E10]; System.Buffer.ZeroMemoryInternal(Byte ByRef, UIntPtr)
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.ClearWithReferences(IntPtr ByRef, UIntPtr)
       cmp       rdx,8
       jb        short M03_L01
M03_L00:
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
       jae       short M03_L00
M03_L01:
       cmp       rdx,4
       jae       short M03_L03
       cmp       rdx,2
       jae       short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L02:
       ret
M03_L03:
       xor       eax,eax
       mov       [rcx+10],rax
       mov       [rcx+18],rax
       mov       [rcx+rdx*8-18],rax
       mov       [rcx+rdx*8-10],rax
M03_L04:
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+rdx*8-8],rax
M03_L05:
       xor       eax,eax
       mov       [rcx],rax
       jmp       short M03_L02
; Total bytes of code 114
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1A96F400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,11F9A36B
       mov       r8d,0FFF4127
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A95CF30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FD10C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FD10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1FEF8C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0A62731DA
       mov       r8d,4A2875CC
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A93D098]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4B7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FC10C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FC10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1F14C800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,50DFEA7
       mov       r8d,3BF44C47
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A94D008]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4B7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FC10C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FC10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,141CB400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,19850B9E
       mov       r8d,60BD4D6B
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A93CF60]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4B7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FC10C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FC10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,17204C00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,23224CB4
       mov       r8d,0BC58203C
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A94D038]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FD10C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FD10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1C5F1400068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,6134762F
       mov       r8d,9B473EA9
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A93D0B0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4B7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FC10C8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FC10D0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,1568FC00068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0C334B57A
       mov       r8d,0D27F17D2
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91A92E148]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4B7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FC1310
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FC1318
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.Contains()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       rdi,[rbx+50]
       cmp       [rsi],sil
       test      rdi,rdi
       je        near ptr M00_L04
       mov       rcx,[rsi+8]
       test      rcx,rcx
       je        near ptr M00_L06
       mov       rdx,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rcx],rdx
       jne       near ptr M00_L14
       mov       rdx,[rdi+28]
       test      rdx,rdx
       je        near ptr M00_L07
       mov       rcx,11AFA800068
       mov       rcx,[rcx]
       mov       rax,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [rcx],rax
       jne       near ptr M00_L13
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       eax,0F99BBC4D
       mov       r8d,389878D7
       cmp       edx,8
       jb        near ptr M00_L08
       mov       r10d,edx
       shr       r10d,3
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
       jne       near ptr M00_L15
M00_L04:
       xor       esi,esi
M00_L05:
       mov       rax,[rbx+18]
       mov       [rax+4C],sil
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF91AA46970]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF91A4D7828]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       xor       ebp,ebp
       jmp       short M00_L03
M00_L08:
       cmp       edx,4
       jb        short M00_L10
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
       mov       r10d,80
       test      dl,1
       je        short M00_L11
       mov       r10d,edx
       and       r10,2
       movzx     r10d,byte ptr [rcx+r10]
       or        r10d,8000
M00_L11:
       test      dl,2
       je        short M00_L12
       shl       r10d,10
       movzx     ecx,word ptr [rcx]
       or        r10d,ecx
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L12:
       mov       ecx,r10d
       jmp       near ptr M00_L02
M00_L13:
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L14:
       mov       rdx,rdi
       mov       r11,7FF919FE1748
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       cmp       ebp,[r14+18]
       jne       short M00_L16
       mov       rcx,[rsi+8]
       mov       rdx,[r14+8]
       mov       r8,rdi
       mov       r11,7FF919FE1750
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L17
M00_L16:
       mov       r14,[r14+10]
       test      r14,r14
       jne       short M00_L15
       jmp       near ptr M00_L04
M00_L17:
       mov       esi,1
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 653
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rsi,[rbx+270]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91AA25F50]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91AA25F50]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r13
       call      qword ptr [7FF91AA25F50]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L25:
       mov       rcx,r12
       call      qword ptr [7FF91AA25F50]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L70
M00_L29:
       add       r14d,1
       jo        near ptr M00_L75
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
       jle       near ptr M00_L71
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L52
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L52
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF91AA25F50]
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+18]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L51
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91AA25F50]
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L64
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L65
       add       edx,1
       jo        near ptr M00_L65
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L65
       or        edx,ecx
       jl        near ptr M00_L62
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-60],rax
       xor       r8d,r8d
       jmp       short M00_L49
M00_L46:
       mov       r9d,edi
       mov       [rbp-68],r9
M00_L47:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L64
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L65
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-68]
       jne       short M00_L47
M00_L48:
       mov       r8,[rbp-70]
       add       r8d,1
       jo        near ptr M00_L65
       mov       rcx,r8
       mov       rax,[rbp-60]
M00_L49:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L66
       cmp       r8d,r12d
       jae       near ptr M00_L64
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L48
       jmp       near ptr M00_L46
M00_L50:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L51:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L58
M00_L52:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FF91AA25F50]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L52
       jmp       near ptr M00_L36
M00_L58:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L60
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L61
M00_L59:
       mov       dword ptr [rbp-50],1
       jmp       near ptr M00_L50
M00_L60:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L61:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91AA25F50]
       jmp       short M00_L59
M00_L62:
       call      qword ptr [7FF91A95D098]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L63
       call      qword ptr [7FF91AA2F2E8]
       mov       rbx,rax
M00_L63:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A435D88
       call      qword ptr [7FF91A317738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF91A4D78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L66:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L69
M00_L67:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L72
M00_L68:
       add       edi,1
       jo        near ptr M00_L75
       cmp       edi,[rbp-48]
       jl        short M00_L67
M00_L69:
       mov       [rbp-58],r14
       mov       rdi,[rbx+18]
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
M00_L70:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA25398]
       jmp       near ptr M00_L29
M00_L71:
       call      qword ptr [7FF91A95D110]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,26088686FB8
       mov       r8,26088686FB8
       call      qword ptr [7FF91A9544B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA25398]
       jmp       near ptr M00_L68
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L76
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L77
       mov       [rbp-3C],ecx
M00_L76:
       add       rsp,28
       ret
M00_L77:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L79
       mov       [rbp-3C],ecx
M00_L78:
       add       rsp,28
       ret
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L80
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L81
       mov       [rbp-3C],ecx
M00_L80:
       add       rsp,28
       ret
M00_L81:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L82
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L83
       mov       [rbp-3C],ecx
M00_L82:
       add       rsp,28
       ret
M00_L83:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L89
M00_L84:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L87
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L86
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L85
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA25398]
M00_L85:
       add       r14d,1
       jo        short M00_L88
       cmp       r14d,[rbp-3C]
       jl        short M00_L84
       jmp       short M00_L89
M00_L86:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L87:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L89:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L90
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-48],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L92
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-48],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L94
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L95
       mov       [rbp-48],ecx
M00_L94:
       add       rsp,28
       ret
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L96
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-48],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L103
M00_L98:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L101
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L100
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L99
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA25398]
M00_L99:
       add       edi,1
       jo        short M00_L102
       cmp       edi,[rbp-48]
       jl        short M00_L98
       jmp       short M00_L103
M00_L100:
       xor       ecx,ecx
       call      qword ptr [7FF91AA248A0]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L103:
       add       rsp,28
       ret
; Total bytes of code 2221
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rsi,[rbx+270]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91A9F5F80]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF91A9F5F80]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF979C76030
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
       mov       r15,[rcx+18]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L52
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L52
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]
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
       mov       rcx,[rcx+18]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+18]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L51
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91A9F5F80]
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
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L63
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
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
       mov       [rbp-60],rax
       xor       r8d,r8d
       jmp       near ptr M00_L59
M00_L46:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L48
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L49
M00_L47:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L50
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L49:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91A9F5F80]
       jmp       short M00_L47
M00_L50:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L64
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L51:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L46
M00_L52:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L55
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L56
M00_L53:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L57
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]
       jmp       short M00_L53
M00_L57:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L64
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L64
       test      r13d,r13d
       jle       short M00_L52
       jmp       near ptr M00_L36
M00_L58:
       mov       r8,[rbp-70]
       add       r8d,1
       jo        near ptr M00_L64
       mov       rcx,r8
       mov       rax,[rbp-60]
M00_L59:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L65
       cmp       r8d,r12d
       jae       near ptr M00_L63
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L58
       mov       r9d,edi
       mov       [rbp-68],r9
M00_L60:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L63
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        short M00_L64
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-68]
       jne       short M00_L60
       jmp       near ptr M00_L58
M00_L61:
       call      qword ptr [7FF91A93D050]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF91A9FE760]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A415D88
       call      qword ptr [7FF91A2F7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF91A4B78D0]
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
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L73
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L72
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       edi,1
       jo        near ptr M00_L74
       cmp       edi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],r14
       mov       rdi,[rbx+18]
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
       call      qword ptr [7FF91A9F5350]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF91A93D0C8]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,24E18EC6FB8
       mov       r8,24E18EC6FB8
       call      qword ptr [7FF91A934390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L86
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L85
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
M00_L84:
       add       r14d,1
       jo        short M00_L87
       cmp       r14d,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
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
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L100
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L99
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
M00_L98:
       add       edi,1
       jo        short M00_L101
       cmp       edi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
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
; Total bytes of code 2214
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rsi,[rbx+270]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L70
M00_L29:
       add       r14d,1
       jo        near ptr M00_L75
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
       jle       near ptr M00_L71
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L64
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L65
       add       edx,1
       jo        near ptr M00_L65
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L65
       or        edx,ecx
       jl        near ptr M00_L62
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-60],rax
       xor       r8d,r8d
       jmp       near ptr M00_L57
M00_L46:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L47:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       near ptr M00_L58
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L52
M00_L49:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       mov       rcx,r12
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L49
M00_L53:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L48
       jmp       near ptr M00_L36
M00_L54:
       mov       r9d,edi
       mov       [rbp-68],r9
M00_L55:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L64
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L65
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-68]
       jne       short M00_L55
M00_L56:
       mov       r8,[rbp-70]
       add       r8d,1
       jo        near ptr M00_L65
       mov       rcx,r8
       mov       rax,[rbp-60]
M00_L57:
       movsxd    rcx,r8d
       cmp       rax,rcx
       jle       near ptr M00_L66
       cmp       r8d,r12d
       jae       near ptr M00_L64
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L56
       jmp       near ptr M00_L54
M00_L58:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L60
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L61
M00_L59:
       mov       dword ptr [rbp-50],1
       jmp       near ptr M00_L46
M00_L60:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L61:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91A9F5F80]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L59
M00_L62:
       call      qword ptr [7FF91A94CF90]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L63
       call      qword ptr [7FF91A9FE760]
       mov       rbx,rax
M00_L63:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A415D88
       call      qword ptr [7FF91A2F7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF91A4B78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L66:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L69
M00_L67:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L72
M00_L68:
       add       edi,1
       jo        near ptr M00_L75
       cmp       edi,[rbp-48]
       jl        short M00_L67
M00_L69:
       mov       [rbp-58],r14
       mov       rdi,[rbx+18]
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
M00_L70:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
       jmp       near ptr M00_L29
M00_L71:
       call      qword ptr [7FF91A94D008]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,1B9B0DE6FB8
       mov       r8,1B9B0DE6FB8
       call      qword ptr [7FF91A944378]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
       jmp       near ptr M00_L68
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L76
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L77
       mov       [rbp-3C],ecx
M00_L76:
       add       rsp,28
       ret
M00_L77:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L79
       mov       [rbp-3C],ecx
M00_L78:
       add       rsp,28
       ret
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L80
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L81
       mov       [rbp-3C],ecx
M00_L80:
       add       rsp,28
       ret
M00_L81:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L82
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L83
       mov       [rbp-3C],ecx
M00_L82:
       add       rsp,28
       ret
M00_L83:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L89
M00_L84:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L87
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L86
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L85
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
M00_L85:
       add       r14d,1
       jo        short M00_L88
       cmp       r14d,[rbp-3C]
       jl        short M00_L84
       jmp       short M00_L89
M00_L86:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L87:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L89:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L90
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-48],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L92
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-48],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L94
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L95
       mov       [rbp-48],ecx
M00_L94:
       add       rsp,28
       ret
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L96
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-48],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L103
M00_L98:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L101
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L100
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L99
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91A9F5350]
M00_L99:
       add       edi,1
       jo        short M00_L102
       cmp       edi,[rbp-48]
       jl        short M00_L98
       jmp       short M00_L103
M00_L100:
       xor       ecx,ecx
       call      qword ptr [7FF91A9F4858]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L103:
       add       rsp,28
       ret
; Total bytes of code 2224
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rsi,[rbx+270]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91AA15F08]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F08]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF91AA15F08]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F08]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L70
M00_L29:
       add       r14d,1
       jo        near ptr M00_L75
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
       jle       near ptr M00_L71
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L46
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L46
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F08]
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+18]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L57
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91AA15F08]
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L64
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L65
       add       edx,1
       jo        near ptr M00_L65
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L65
       or        edx,ecx
       jl        near ptr M00_L62
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-60],rax
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       rax,rcx
       jg        near ptr M00_L61
       jmp       near ptr M00_L66
M00_L46:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L49
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L48
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F08]
       jmp       short M00_L47
M00_L51:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L46
       jmp       near ptr M00_L36
M00_L52:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L54
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L55:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91AA15F08]
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L57:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L52
M00_L58:
       mov       r9d,edi
       mov       [rbp-68],r9
M00_L59:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L64
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L65
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-68]
       jne       short M00_L59
M00_L60:
       mov       r8,[rbp-70]
       add       r8d,1
       jo        near ptr M00_L65
       mov       rcx,r8
       movsxd    rdx,ecx
       mov       rax,[rbp-60]
       cmp       rax,rdx
       mov       r8,rcx
       jle       short M00_L66
M00_L61:
       cmp       r8d,r12d
       jae       short M00_L64
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L60
       jmp       near ptr M00_L58
M00_L62:
       call      qword ptr [7FF91A94D188]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L63
       call      qword ptr [7FF91AA1E760]
       mov       rbx,rax
M00_L63:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A425D88
       call      qword ptr [7FF91A307738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF91A4C78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L66:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L69
M00_L67:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L72
M00_L68:
       add       edi,1
       jo        near ptr M00_L75
       cmp       edi,[rbp-48]
       jl        short M00_L67
M00_L69:
       mov       [rbp-58],r14
       mov       rdi,[rbx+18]
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
M00_L70:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA15350]
       jmp       near ptr M00_L29
M00_L71:
       call      qword ptr [7FF91A94D200]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,275697E6FB8
       mov       r8,275697E6FB8
       call      qword ptr [7FF91A9444E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA15350]
       jmp       near ptr M00_L68
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L76
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L77
       mov       [rbp-3C],ecx
M00_L76:
       add       rsp,28
       ret
M00_L77:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L79
       mov       [rbp-3C],ecx
M00_L78:
       add       rsp,28
       ret
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L80
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L81
       mov       [rbp-3C],ecx
M00_L80:
       add       rsp,28
       ret
M00_L81:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L82
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L83
       mov       [rbp-3C],ecx
M00_L82:
       add       rsp,28
       ret
M00_L83:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L89
M00_L84:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L87
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L86
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L85
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA15350]
M00_L85:
       add       r14d,1
       jo        short M00_L88
       cmp       r14d,[rbp-3C]
       jl        short M00_L84
       jmp       short M00_L89
M00_L86:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L87:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L89:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L90
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-48],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L92
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-48],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L94
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L95
       mov       [rbp-48],ecx
M00_L94:
       add       rsp,28
       ret
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L96
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-48],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L103
M00_L98:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L101
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L100
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L99
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA15350]
M00_L99:
       add       edi,1
       jo        short M00_L102
       cmp       edi,[rbp-48]
       jl        short M00_L98
       jmp       short M00_L103
M00_L100:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14858]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L103:
       add       rsp,28
       ret
; Total bytes of code 2225
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rsi,[rbx+270]
       mov       [rbp-78],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91AA15F68]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F68]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF91AA15F68]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F68]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L70
M00_L29:
       add       r14d,1
       jo        near ptr M00_L75
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
       jle       near ptr M00_L71
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
       xor       r13d,r13d
       test      r15,r15
       je        near ptr M00_L50
       cmp       dword ptr [r15+8],0
       jle       near ptr M00_L50
M00_L31:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L33
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L34:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F68]
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       mov       r15d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r13,[rcx+18]
       mov       r12d,1
       cmp       r15d,1
       jle       near ptr M00_L43
       test      r13,r13
       je        short M00_L37
       cmp       [r13+8],r15d
       jge       near ptr M00_L61
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91AA15F68]
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        near ptr M00_L65
       cmp       r12d,r15d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       cmp       dword ptr [rax+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       rax,[rsi+10]
       mov       rax,[rax+10]
       cmp       edx,[rax+8]
       jae       near ptr M00_L64
       add       ecx,[rax+rdx*4+10]
       jo        near ptr M00_L65
       add       edx,1
       jo        near ptr M00_L65
       mov       rax,[rsi+10]
       mov       rax,[rax+18]
       mov       eax,[rax+8]
       movsxd    r8,edx
       cmp       rax,r8
       jg        short M00_L44
M00_L45:
       mov       edx,edi
       sub       edx,ecx
       jo        near ptr M00_L65
       or        edx,ecx
       jl        near ptr M00_L62
       xor       r15d,r15d
       mov       rcx,[rsi+10]
       mov       r13,[rcx+8]
       mov       r12d,[r13+8]
       mov       eax,r12d
       mov       [rbp-60],rax
       xor       r8d,r8d
       movsxd    rcx,r8d
       cmp       rax,rcx
       jg        short M00_L49
       jmp       near ptr M00_L66
M00_L46:
       mov       r9d,edi
       mov       [rbp-68],r9
M00_L47:
       movsxd    rcx,r15d
       cmp       rcx,r9
       jae       near ptr M00_L64
       movsxd    rcx,r15d
       lea       rcx,[r14+rcx*8+10]
       mov       [rbp-88],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r15d,1
       jo        near ptr M00_L65
       mov       rcx,[rbp-88]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-68]
       jne       short M00_L47
M00_L48:
       mov       r8,[rbp-70]
       add       r8d,1
       jo        near ptr M00_L65
       mov       rcx,r8
       movsxd    rdx,ecx
       mov       rax,[rbp-60]
       cmp       rax,rdx
       mov       r8,rcx
       jle       near ptr M00_L66
M00_L49:
       cmp       r8d,r12d
       jae       near ptr M00_L64
       mov       [rbp-70],r8
       mov       r10,[r13+r8*8+10]
       test      r10,r10
       je        short M00_L48
       jmp       near ptr M00_L46
M00_L50:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       r13d,[r15+8]
       jae       short M00_L53
       mov       ecx,r13d
       mov       r12,[r15+rcx*8+10]
       test      r12,r12
       je        short M00_L52
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L54
M00_L51:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L55
M00_L52:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L54:
       mov       rcx,r12
       call      qword ptr [7FF91AA15F68]
       jmp       short M00_L51
M00_L55:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       test      r13d,r13d
       jle       short M00_L50
       jmp       near ptr M00_L36
M00_L56:
       mov       ecx,r12d
       mov       rax,[r13+rcx*8+10]
       test      rax,rax
       je        short M00_L58
       mov       [rbp-80],rax
       mov       rcx,rax
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L59
M00_L57:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L60
M00_L58:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L59:
       mov       rcx,[rbp-80]
       call      qword ptr [7FF91AA15F68]
       jmp       short M00_L57
M00_L60:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L65
       mov       [rbp-48],ecx
       add       r12d,1
       jo        short M00_L65
       cmp       r12d,r15d
       jge       near ptr M00_L43
M00_L61:
       xor       ecx,ecx
       mov       [rbp-50],ecx
       jmp       short M00_L56
M00_L62:
       call      qword ptr [7FF91A95D0C8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L63
       call      qword ptr [7FF91AA1E7A8]
       mov       rbx,rax
M00_L63:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A435D88
       call      qword ptr [7FF91A317738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF91A4D78D0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L66:
       xor       edi,edi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L69
M00_L67:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       near ptr M00_L74
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        near ptr M00_L73
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L72
M00_L68:
       add       edi,1
       jo        near ptr M00_L75
       cmp       edi,[rbp-48]
       jl        short M00_L67
M00_L69:
       mov       [rbp-58],r14
       mov       rdi,[rbx+18]
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
M00_L70:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA153B0]
       jmp       near ptr M00_L29
M00_L71:
       call      qword ptr [7FF91A95D140]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,2589DB06FB8
       mov       r8,2589DB06FB8
       call      qword ptr [7FF91A9543D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA153B0]
       jmp       near ptr M00_L68
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L76
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L77
       mov       [rbp-3C],ecx
M00_L76:
       add       rsp,28
       ret
M00_L77:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L79
       mov       [rbp-3C],ecx
M00_L78:
       add       rsp,28
       ret
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L80
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L81
       mov       [rbp-3C],ecx
M00_L80:
       add       rsp,28
       ret
M00_L81:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L82
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L83
       mov       [rbp-3C],ecx
M00_L82:
       add       rsp,28
       ret
M00_L83:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L89
M00_L84:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L87
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L86
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L85
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA153B0]
M00_L85:
       add       r14d,1
       jo        short M00_L88
       cmp       r14d,[rbp-3C]
       jl        short M00_L84
       jmp       short M00_L89
M00_L86:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L87:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L89:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L90
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-48],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L92
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-48],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L94
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L95
       mov       [rbp-48],ecx
M00_L94:
       add       rsp,28
       ret
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L96
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-48],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-48]
       jge       short M00_L103
M00_L98:
       mov       rsi,[rbp-78]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       edi,[rcx+8]
       jae       short M00_L101
       mov       eax,edi
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L100
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L99
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA153B0]
M00_L99:
       add       edi,1
       jo        short M00_L102
       cmp       edi,[rbp-48]
       jl        short M00_L98
       jmp       short M00_L103
M00_L100:
       xor       ecx,ecx
       call      qword ptr [7FF91AA148B8]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L103:
       add       rsp,28
       ret
; Total bytes of code 2221
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L74
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L73
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L70
M00_L29:
       add       edi,1
       jo        near ptr M00_L75
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
       jle       near ptr M00_L71
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L48
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L48
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L65
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+18]
       mov       r13d,1
       cmp       r14d,1
       jle       short M00_L43
       test      r15,r15
       je        short M00_L37
       cmp       [r15+8],r14d
       jge       near ptr M00_L59
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L64
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L65
       add       edx,1
       jo        near ptr M00_L65
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L65
       or        edx,ecx
       jl        short M00_L46
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       near ptr M00_L63
M00_L46:
       call      qword ptr [7FF91A93CFF0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L47
       call      qword ptr [7FF91A93F0C0]
       mov       rbx,rax
M00_L47:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A415D88
       call      qword ptr [7FF91A2F7738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91A4B78D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L48:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L51
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L50
       mov       rcx,r13
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L52
M00_L49:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       mov       rcx,r13
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L49
M00_L53:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L65
       test      r15d,r15d
       jle       short M00_L48
       jmp       near ptr M00_L36
M00_L54:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L56
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L57
M00_L55:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L58
M00_L56:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L57:
       mov       rcx,r12
       call      qword ptr [7FF91A93EF58]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L55
M00_L58:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L59:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L54
M00_L60:
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L61:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       short M00_L64
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        short M00_L65
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L61
M00_L62:
       mov       r8,[rbp-68]
       add       r8d,1
       jo        short M00_L65
       mov       rcx,r8
M00_L63:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       short M00_L66
       cmp       r8d,r13d
       jae       short M00_L64
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L62
       jmp       short M00_L60
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L66:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L69
M00_L67:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L74
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L73
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L72
M00_L68:
       add       esi,1
       jo        near ptr M00_L75
       cmp       esi,[rbp-48]
       jl        short M00_L67
M00_L69:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+18]
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
M00_L70:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A935578]
       jmp       near ptr M00_L29
M00_L71:
       call      qword ptr [7FF91A93D068]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,2206DDA6FB8
       mov       r8,2206DDA6FB8
       call      qword ptr [7FF91A9343A8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A935578]
       jmp       near ptr M00_L68
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L76
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L77
       mov       [rbp-3C],ecx
M00_L76:
       add       rsp,28
       ret
M00_L77:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L79
       mov       [rbp-3C],ecx
M00_L78:
       add       rsp,28
       ret
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L80
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L81
       mov       [rbp-3C],ecx
M00_L80:
       add       rsp,28
       ret
M00_L81:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L82
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L83
       mov       [rbp-3C],ecx
M00_L82:
       add       rsp,28
       ret
M00_L83:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L89
M00_L84:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L87
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L86
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L85
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A935578]
M00_L85:
       add       edi,1
       jo        short M00_L88
       cmp       edi,[rbp-3C]
       jl        short M00_L84
       jmp       short M00_L89
M00_L86:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L87:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L89:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L90
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-48],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L92
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-48],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L94
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L95
       mov       [rbp-48],ecx
M00_L94:
       add       rsp,28
       ret
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L96
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-48],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L103
M00_L98:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L101
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L100
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L99
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A935578]
M00_L99:
       add       esi,1
       jo        short M00_L102
       cmp       esi,[rbp-48]
       jl        short M00_L98
       jmp       short M00_L103
M00_L100:
       xor       ecx,ecx
       call      qword ptr [7FF91A935560]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L103:
       add       rsp,28
       ret
; Total bytes of code 2195
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L73
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF979C76030
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
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L63
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L64
       add       edx,1
       jo        near ptr M00_L64
       mov       r8,[rax+10]
       mov       r8,[r8+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L50
M00_L47:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L51
M00_L48:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L50:
       mov       rcx,r13
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L47
       xchg      ax,ax
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
       int       3
M00_L55:
       mov       rcx,r12
       call      qword ptr [7FF91A95ED30]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       r8,[rbp-68]
       add       r8d,1
       jo        near ptr M00_L64
       mov       rcx,r8
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
       movsxd    rcx,r14d
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
       call      qword ptr [7FF91A95E9A0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L62
       call      qword ptr [7FF91A95ED90]
       mov       rbx,rax
M00_L62:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A445D88
       call      qword ptr [7FF91A327738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91A4E78D0]
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
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L73
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L72
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L71
M00_L67:
       add       esi,1
       jo        near ptr M00_L74
       cmp       esi,[rbp-48]
       jl        short M00_L66
M00_L68:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+18]
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
       call      qword ptr [7FF91A956F28]
       jmp       near ptr M00_L29
M00_L70:
       call      qword ptr [7FF91A95EA18]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,1F525B56FB8
       mov       r8,1F525B56FB8
       call      qword ptr [7FF91A955458]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L71:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A956F28]
       jmp       near ptr M00_L67
M00_L72:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L86
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L85
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L84
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A956F28]
M00_L84:
       add       edi,1
       jo        short M00_L87
       cmp       edi,[rbp-3C]
       jl        short M00_L83
       jmp       short M00_L88
M00_L85:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
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
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L100
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L99
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L98
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A956F28]
M00_L98:
       add       esi,1
       jo        short M00_L101
       cmp       esi,[rbp-48]
       jl        short M00_L97
       jmp       short M00_L102
M00_L99:
       xor       ecx,ecx
       call      qword ptr [7FF91A956F10]
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
; Total bytes of code 2211
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-70],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       near ptr M00_L74
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L73
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L70
M00_L29:
       add       edi,1
       jo        near ptr M00_L75
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
       jle       near ptr M00_L71
       xor       ecx,ecx
       mov       [rbp-48],ecx
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
       xor       r15d,r15d
       test      r14,r14
       je        near ptr M00_L58
       cmp       dword ptr [r14+8],0
       jle       near ptr M00_L58
M00_L31:
       xor       eax,eax
       mov       [rbp-4C],eax
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L33
       mov       rcx,r13
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L34
M00_L32:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L35
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L34:
       mov       rcx,r13
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L32
M00_L35:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r15d,1
       jo        near ptr M00_L65
       test      r15d,r15d
       jle       short M00_L31
M00_L36:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       mov       r14d,[rax+8]
       mov       rax,[rcx+10]
       mov       r15,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L41
M00_L38:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L42
M00_L39:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L40:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L41:
       mov       rcx,r12
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L38
M00_L42:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        near ptr M00_L65
       cmp       r13d,r14d
       jl        short M00_L37
M00_L43:
       xor       ecx,ecx
       xor       edx,edx
       mov       rax,[rbp-70]
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       cmp       dword ptr [r8+8],0
       je        short M00_L45
M00_L44:
       test      ecx,ecx
       jl        short M00_L45
       mov       r8,[rax+10]
       mov       r8,[r8+10]
       cmp       edx,[r8+8]
       jae       near ptr M00_L64
       add       ecx,[r8+rdx*4+10]
       jo        near ptr M00_L65
       add       edx,1
       jo        near ptr M00_L65
       mov       r8,[rax+10]
       mov       r8,[r8+18]
       mov       r8d,[r8+8]
       movsxd    r10,edx
       cmp       r8,r10
       jg        short M00_L44
M00_L45:
       mov       edx,esi
       sub       edx,ecx
       jo        near ptr M00_L65
       or        edx,ecx
       jl        near ptr M00_L50
       xor       r14d,r14d
       mov       rcx,[rax+10]
       mov       r15,[rcx+8]
       mov       r13d,[r15+8]
       mov       r12d,r13d
       xor       r8d,r8d
       jmp       short M00_L49
       xchg      ax,ax
M00_L46:
       mov       r9d,esi
       mov       [rbp-60],r9
M00_L47:
       movsxd    rcx,r14d
       cmp       rcx,r9
       jae       near ptr M00_L64
       movsxd    rcx,r14d
       lea       rcx,[rdi+rcx*8+10]
       mov       [rbp-78],r10
       mov       rdx,[r10+8]
       call      CORINFO_HELP_ASSIGN_REF
       add       r14d,1
       jo        near ptr M00_L65
       mov       rcx,[rbp-78]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       mov       r10,rcx
       mov       r9,[rbp-60]
       jne       short M00_L47
M00_L48:
       mov       r8,[rbp-68]
       add       r8d,1
       jo        near ptr M00_L65
       mov       rcx,r8
M00_L49:
       movsxd    rcx,r8d
       cmp       r12,rcx
       jle       near ptr M00_L66
       cmp       r8d,r13d
       jae       near ptr M00_L64
       mov       [rbp-68],r8
       mov       r10,[r15+r8*8+10]
       test      r10,r10
       je        short M00_L48
       jmp       short M00_L46
M00_L50:
       call      qword ptr [7FF91AA36988]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L51
       call      qword ptr [7FF91AA37120]
       mov       rbx,rax
M00_L51:
       mov       rcx,offset MT_DotNetTips.Spargine.Core.ArgumentInvalidException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,4E75
       mov       rdx,7FF91A425D88
       call      qword ptr [7FF91A307738]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF91A4C78D0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L52:
       mov       eax,r13d
       mov       r12,[r15+rax*8+10]
       test      r12,r12
       je        short M00_L54
       mov       rcx,r12
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L55
M00_L53:
       mov       dword ptr [rbp-50],1
       jmp       short M00_L56
M00_L54:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L55:
       mov       rcx,r12
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L53
M00_L56:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        near ptr M00_L65
       mov       [rbp-48],ecx
       add       r13d,1
       jo        short M00_L65
       cmp       r13d,r14d
       jge       near ptr M00_L43
M00_L57:
       xor       eax,eax
       mov       [rbp-50],eax
       jmp       short M00_L52
M00_L58:
       xor       eax,eax
       mov       [rbp-4C],eax
       cmp       r15d,[r14+8]
       jae       short M00_L61
       mov       eax,r15d
       mov       r13,[r14+rax*8+10]
       test      r13,r13
       je        short M00_L60
       mov       rcx,r13
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L62
M00_L59:
       mov       dword ptr [rbp-4C],1
       jmp       short M00_L63
M00_L60:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L61:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L62:
       mov       rcx,r13
       call      qword ptr [7FF91A85C3F0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L59
M00_L63:
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L65
       mov       [rbp-48],ecx
       add       r15d,1
       jo        short M00_L65
       test      r15d,r15d
       jle       short M00_L58
       jmp       near ptr M00_L36
M00_L64:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L65:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L66:
       xor       esi,esi
       cmp       dword ptr [rbp-48],0
       jle       short M00_L69
M00_L67:
       mov       rax,[rbp-70]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L74
       mov       edx,esi
       mov       r14,[rcx+rdx*8+10]
       test      r14,r14
       je        near ptr M00_L73
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L72
M00_L68:
       add       esi,1
       jo        near ptr M00_L75
       cmp       esi,[rbp-48]
       jl        short M00_L67
M00_L69:
       mov       [rbp-58],rdi
       mov       rsi,[rbx+18]
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
M00_L70:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A857708]
       jmp       near ptr M00_L29
M00_L71:
       call      qword ptr [7FF91AA36A00]
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,22242756FB8
       mov       r8,22242756FB8
       call      qword ptr [7FF91A856B08]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L72:
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A857708]
       jmp       near ptr M00_L68
M00_L73:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L74:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L75:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L76
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L77
       mov       [rbp-3C],ecx
M00_L76:
       add       rsp,28
       ret
M00_L77:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L78
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L79
       mov       [rbp-3C],ecx
M00_L78:
       add       rsp,28
       ret
M00_L79:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L80
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L81
       mov       [rbp-3C],ecx
M00_L80:
       add       rsp,28
       ret
M00_L81:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L82
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L83
       mov       [rbp-3C],ecx
M00_L82:
       add       rsp,28
       ret
M00_L83:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       edi,edi
       cmp       edi,[rbp-3C]
       jge       short M00_L89
M00_L84:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L87
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L86
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L85
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A857708]
M00_L85:
       add       edi,1
       jo        short M00_L88
       cmp       edi,[rbp-3C]
       jl        short M00_L84
       jmp       short M00_L89
M00_L86:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L87:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L88:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L89:
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L90
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L91
       mov       [rbp-48],ecx
M00_L90:
       add       rsp,28
       ret
M00_L91:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L92
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L93
       mov       [rbp-48],ecx
M00_L92:
       add       rsp,28
       ret
M00_L93:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-4C],0
       je        short M00_L94
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L95
       mov       [rbp-48],ecx
M00_L94:
       add       rsp,28
       ret
M00_L95:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-50],0
       je        short M00_L96
       mov       ecx,[rbp-48]
       add       ecx,1
       jo        short M00_L97
       mov       [rbp-48],ecx
M00_L96:
       add       rsp,28
       ret
M00_L97:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       esi,esi
       cmp       esi,[rbp-48]
       jge       short M00_L103
M00_L98:
       mov       rcx,[rbp-70]
       mov       rax,[rcx+10]
       mov       rax,[rax+18]
       cmp       esi,[rax+8]
       jae       short M00_L101
       mov       edx,esi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L100
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L99
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A857708]
M00_L99:
       add       esi,1
       jo        short M00_L102
       cmp       esi,[rbp-48]
       jl        short M00_L98
       jmp       short M00_L103
M00_L100:
       xor       ecx,ecx
       call      qword ptr [7FF91A856BC8]
       int       3
M00_L101:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L102:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L103:
       add       rsp,28
       ret
; Total bytes of code 2200
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14600]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91AA15D28]
       jmp       short M00_L01
       nop       word ptr [rax+rax]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14600]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91AA15D28]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14600]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF91AA15D28]
       jmp       short M00_L15
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14600]
       int       3
M00_L23:
       mov       rcx,r12
       call      qword ptr [7FF91AA15D28]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L33
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L32
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
       mov       [rcx+38],edi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA150F8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14600]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L35
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-3C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L37
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-3C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L39
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-3C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L41
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-3C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L48
M00_L43:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L46
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L45
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA150F8]
M00_L44:
       add       r14d,1
       jo        short M00_L47
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14600]
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
; Total bytes of code 909
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91AA25C98]
       jmp       short M00_L01
       nop       word ptr [rax+rax]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91AA25C98]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r13
       call      qword ptr [7FF91AA25C98]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L25:
       mov       rcx,r12
       call      qword ptr [7FF91AA25C98]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L33
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L32
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
       mov       [rcx+38],edi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA250E0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L35
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-3C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L37
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-3C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L39
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-3C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L41
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-3C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L48
M00_L43:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L46
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L45
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA250E0]
M00_L44:
       add       r14d,1
       jo        short M00_L47
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
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
; Total bytes of code 916
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.CountPeople()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       mov       [rbp-50],rsi
       cmp       [rsi],sil
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       mov       rcx,[rsi+10]
       mov       r14,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04630]
       int       3
M00_L03:
       mov       rcx,r13
       call      qword ptr [7FF91AA05CE0]
       jmp       short M00_L01
       nop       word ptr [rax+rax]
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
       mov       rcx,[rcx+18]
       mov       r14d,[rcx+8]
       mov       rcx,[rsi+10]
       mov       r15,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-44],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04630]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF91AA05CE0]
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
       mov       rcx,[rcx+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-40],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04630]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r13
       call      qword ptr [7FF91AA05CE0]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-44],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04630]
       int       3
M00_L25:
       mov       rcx,r12
       call      qword ptr [7FF91AA05CE0]
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
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L33
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L32
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       r14d,1
       jo        short M00_L34
       cmp       r14d,[rbp-3C]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
       mov       [rcx+38],edi
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L31:
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA05128]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04630]
       int       3
M00_L33:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L34:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L35
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L36
       mov       [rbp-3C],ecx
M00_L35:
       add       rsp,28
       ret
M00_L36:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L37
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L38
       mov       [rbp-3C],ecx
M00_L37:
       add       rsp,28
       ret
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-40],0
       je        short M00_L39
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-3C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-44],0
       je        short M00_L41
       mov       ecx,[rbp-3C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-3C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       xor       r14d,r14d
       cmp       r14d,[rbp-3C]
       jge       short M00_L48
M00_L43:
       mov       rsi,[rbp-50]
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+18]
       cmp       r14d,[rcx+8]
       jae       short M00_L46
       mov       eax,r14d
       mov       r15,[rcx+rax*8+10]
       test      r15,r15
       je        short M00_L45
       mov       rcx,r15
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r15
       call      qword ptr [7FF91AA05128]
M00_L44:
       add       r14d,1
       jo        short M00_L47
       cmp       r14d,[rbp-3C]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04630]
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
; Total bytes of code 916
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24600]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91AA25CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24600]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91AA25CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24600]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF91AA25CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24600]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF91AA25CB0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
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
       call      qword ptr [7FF91AA250F8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24600]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91AA250F8]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24600]
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A95D0C8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A95D0E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A95D0C8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A95D0E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A95D0C8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF91A95D0E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A95D0C8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF91A95D0E0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
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
       call      qword ptr [7FF91A95D0F8]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91A95D0C8]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A95D0F8]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91A95D0C8]
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A96D1A0]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A96D1B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A96D1A0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A96D1B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A96D1A0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF91A96D1B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A96D1A0]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF91A96D1B8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
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
       call      qword ptr [7FF91A96D1D0]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91A96D1A0]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A96D1D0]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91A96D1A0]
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A965578]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A96D218]
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A965578]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A96D218]
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91A965578]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r15
       call      qword ptr [7FF91A96D218]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-3C],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91A965578]
       int       3
M00_L25:
       mov       rcx,r13
       call      qword ptr [7FF91A96D218]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
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
       call      qword ptr [7FF91A965590]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91A965578]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A965590]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91A965578]
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rcx,[rbx+270]
       mov       [rbp-48],rcx
       cmp       [rcx],cl
       xor       esi,esi
       xor       eax,eax
       mov       [rbp-34],eax
       mov       rax,[rcx+10]
       mov       rdi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A866BF8]
       int       3
M00_L03:
       mov       rcx,r15
       call      qword ptr [7FF91A86C798]
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
       mov       rax,[rax+18]
       mov       edi,[rax+8]
       mov       rax,[rcx+10]
       mov       r14,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A866BF8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r13
       call      qword ptr [7FF91A86C798]
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
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-38],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A866BF8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,r15
       call      qword ptr [7FF91A86C798]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-3C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A866BF8]
       int       3
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FF91A86C798]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L33
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L32
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L31
M00_L29:
       add       edi,1
       jo        short M00_L34
       cmp       edi,[rbp-34]
       mov       rcx,[rbp-48]
       jl        short M00_L28
M00_L30:
       mov       rcx,[rbx+18]
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
       call      qword ptr [7FF91A867738]
       jmp       short M00_L29
M00_L32:
       xor       ecx,ecx
       call      qword ptr [7FF91A866BF8]
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
       mov       rax,[rax+18]
       cmp       edi,[rax+8]
       jae       short M00_L46
       mov       edx,edi
       mov       r14,[rax+rdx*8+10]
       test      r14,r14
       je        short M00_L45
       mov       rcx,r14
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L44
       mov       ecx,eax
       mov       rdx,r14
       call      qword ptr [7FF91A867738]
M00_L44:
       add       edi,1
       jo        short M00_L47
       cmp       edi,[rbp-34]
       jl        short M00_L43
       jmp       short M00_L48
M00_L45:
       xor       ecx,ecx
       call      qword ptr [7FF91A866BF8]
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04618]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA05CC8]
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
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04618]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA05CC8]
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
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L34
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04618]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF91AA05CC8]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04618]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF91AA05CC8]
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
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L38
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L36
       mov       rcx,rdi
       call      00007FF979C76030
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
       mov       rax,[rcx+18]
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
       call      qword ptr [7FF91AA05110]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04618]
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
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L52
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L51
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA05110]
M00_L50:
       add       esi,1
       jo        short M00_L53
       cmp       esi,[rbp-2C]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04618]
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       mov       rbx,[rcx+270]
       mov       [rbp-40],rbx
       cmp       [rbx],bl
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rax,[rbx+10]
       mov       rsi,[rax+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34618]
       int       3
M00_L03:
       mov       rcx,r14
       call      qword ptr [7FF91AA35CC8]
       jmp       short M00_L01
       nop       dword ptr [rax]
M00_L04:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       edi,1
       jo        near ptr M00_L27
       test      edi,edi
       jle       short M00_L00
M00_L05:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       mov       esi,[rcx+8]
       mov       rcx,[rbx+10]
       mov       rdi,[rcx+18]
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-34],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34618]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r15
       call      qword ptr [7FF91AA35CC8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L27
       cmp       r14d,esi
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       mov       eax,[rax+8]
       movsxd    rdx,ecx
       cmp       rax,rdx
       jle       near ptr M00_L33
       mov       rax,[rbx+10]
       mov       rax,[rax+10]
       cmp       ecx,[rax+8]
       jae       near ptr M00_L26
       cmp       dword ptr [rax+rcx*4+10],0
       jne       near ptr M00_L28
       add       ecx,1
       jo        near ptr M00_L27
       jmp       short M00_L13
M00_L14:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-2C],ecx
       add       r14d,1
       jo        near ptr M00_L27
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
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L20
M00_L17:
       mov       dword ptr [rbp-30],1
       jmp       short M00_L21
M00_L18:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34618]
       int       3
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF91AA35CC8]
       jmp       short M00_L17
M00_L21:
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-2C],ecx
       add       edi,1
       jo        short M00_L27
       test      edi,edi
       jle       short M00_L16
       jmp       near ptr M00_L05
M00_L22:
       mov       ecx,r14d
       mov       r15,[rdi+rcx*8+10]
       test      r15,r15
       je        short M00_L24
       mov       rcx,r15
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L25
M00_L23:
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L14
M00_L24:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34618]
       int       3
M00_L25:
       mov       rcx,r15
       call      qword ptr [7FF91AA35CC8]
       jmp       short M00_L23
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L31
M00_L29:
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L37
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L35
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L34
M00_L30:
       add       esi,1
       jo        short M00_L38
       cmp       esi,[rbp-2C]
       jl        short M00_L29
M00_L31:
       xor       edi,edi
M00_L32:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],dil
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L33:
       call      M00_L47
       jmp       short M00_L36
M00_L34:
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA35110]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34618]
       int       3
M00_L36:
       mov       edi,1
       jmp       short M00_L32
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L39
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-2C],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L41
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-2C],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L43
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-2C],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-34],0
       je        short M00_L45
       mov       ecx,[rbp-2C]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-2C],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L47:
       sub       rsp,28
       xor       esi,esi
       cmp       dword ptr [rbp-2C],0
       jle       short M00_L53
M00_L48:
       mov       rbx,[rbp-40]
       mov       rcx,[rbx+10]
       mov       rcx,[rcx+18]
       cmp       esi,[rcx+8]
       jae       short M00_L51
       mov       eax,esi
       mov       rdi,[rcx+rax*8+10]
       test      rdi,rdi
       je        short M00_L50
       mov       rcx,rdi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rdi
       call      qword ptr [7FF91AA35110]
M00_L49:
       add       esi,1
       jo        short M00_L52
       cmp       esi,[rbp-2C]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34618]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L53:
       add       rsp,28
       ret
; Total bytes of code 926
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF91AA25C98]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L27
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF91AA25C98]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L27
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L33
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L26
       cmp       dword ptr [rdx+rcx*4+10],0
       jne       near ptr M00_L28
       add       ecx,1
       jo        near ptr M00_L27
       jmp       short M00_L13
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FF91AA25C98]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L27
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91AA25C98]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L27
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L31
M00_L29:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L37
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L35
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L34
M00_L30:
       add       ebx,1
       jo        short M00_L38
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L29
M00_L31:
       xor       esi,esi
M00_L32:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L33:
       call      M00_L47
       jmp       short M00_L36
M00_L34:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91AA250E0]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L36:
       mov       esi,1
       jmp       short M00_L32
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L39
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-24],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L41
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-24],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L43
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-24],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L45
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-24],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L47:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L53
M00_L48:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L51
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L50
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91AA250E0]
M00_L49:
       add       ebx,1
       jo        short M00_L52
       cmp       ebx,[rbp-24]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF91AA245E8]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L53:
       add       rsp,28
       ret
; Total bytes of code 916
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91AA345E8]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF91AA35D10]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L27
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA345E8]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF91AA35D10]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L27
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L33
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L26
       cmp       dword ptr [rdx+rcx*4+10],0
       jne       near ptr M00_L28
       add       ecx,1
       jo        near ptr M00_L27
       jmp       short M00_L13
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91AA345E8]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FF91AA35D10]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L27
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91AA345E8]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91AA35D10]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L27
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L31
M00_L29:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L37
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L35
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L34
M00_L30:
       add       ebx,1
       jo        short M00_L38
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L29
M00_L31:
       xor       esi,esi
M00_L32:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L33:
       call      M00_L47
       jmp       short M00_L36
M00_L34:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91AA350E0]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FF91AA345E8]
       int       3
M00_L36:
       mov       esi,1
       jmp       short M00_L32
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L39
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-24],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L41
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-24],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L43
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-24],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L45
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-24],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L47:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L53
M00_L48:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L51
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L50
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91AA350E0]
M00_L49:
       add       ebx,1
       jo        short M00_L52
       cmp       ebx,[rbp-24]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF91AA345E8]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L53:
       add       rsp,28
       ret
; Total bytes of code 916
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A93CCC0]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF91A93CCD8]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L27
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A93CCC0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF91A93CCD8]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L27
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L27
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L33
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L26
       cmp       dword ptr [rdx+rcx*4+10],0
       jne       near ptr M00_L28
       add       ecx,1
       jo        near ptr M00_L27
       jmp       short M00_L13
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A93CCC0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FF91A93CCD8]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L27
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A93CCC0]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91A93CCD8]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L27
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L27
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       jmp       short M00_L20
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L31
M00_L29:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L37
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L35
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L34
M00_L30:
       add       ebx,1
       jo        short M00_L38
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L29
M00_L31:
       xor       esi,esi
M00_L32:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L33:
       call      M00_L47
       jmp       short M00_L36
M00_L34:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A93CCF0]
       jmp       short M00_L30
M00_L35:
       xor       ecx,ecx
       call      qword ptr [7FF91A93CCC0]
       int       3
M00_L36:
       mov       esi,1
       jmp       short M00_L32
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L39
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L40
       mov       [rbp-24],ecx
M00_L39:
       add       rsp,28
       ret
M00_L40:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L41
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L42
       mov       [rbp-24],ecx
M00_L41:
       add       rsp,28
       ret
M00_L42:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L43
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L44
       mov       [rbp-24],ecx
M00_L43:
       add       rsp,28
       ret
M00_L44:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L45
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L46
       mov       [rbp-24],ecx
M00_L45:
       add       rsp,28
       ret
M00_L46:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L47:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L53
M00_L48:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L51
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L50
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L49
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A93CCF0]
M00_L49:
       add       ebx,1
       jo        short M00_L52
       cmp       ebx,[rbp-24]
       jl        short M00_L48
       jmp       short M00_L53
M00_L50:
       xor       ecx,ecx
       call      qword ptr [7FF91A93CCC0]
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L52:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L53:
       add       rsp,28
       ret
; Total bytes of code 916
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A935590]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF91A93D230]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A935590]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF91A93D230]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A935590]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FF91A93D230]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A935590]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91A93D230]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
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
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A9355A8]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF91A935590]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A9355A8]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF91A935590]
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A926628]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF91A92ED48]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A926628]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF91A92ED48]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A926628]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FF91A92ED48]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A926628]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91A92ED48]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
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
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A926640]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF91A926628]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A926640]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF91A926628]
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Collections.Generic.Concurrent.ConcurrentHashSetCollectionBenchmark.IsEmpty()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       mov       [rbp+10],rcx
       mov       rax,[rcx+270]
       mov       [rbp-38],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp-24],edx
       mov       rdx,[rax+10]
       mov       rbx,[rdx+18]
       xor       esi,esi
       test      rbx,rbx
       je        near ptr M00_L14
       cmp       dword ptr [rbx+8],0
       jle       near ptr M00_L14
M00_L00:
       xor       edx,edx
       mov       [rbp-28],edx
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L02
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L03
M00_L01:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L04
M00_L02:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BE0]
       int       3
M00_L03:
       mov       rcx,rdi
       call      qword ptr [7FF91A87C450]
       jmp       short M00_L01
M00_L04:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        near ptr M00_L28
       test      esi,esi
       jle       short M00_L00
M00_L05:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       mov       ebx,[rcx+8]
       mov       rcx,[rax+10]
       mov       rsi,[rcx+18]
       mov       edi,1
       cmp       ebx,1
       jle       short M00_L12
       test      rsi,rsi
       je        short M00_L06
       cmp       [rsi+8],ebx
       jge       near ptr M00_L25
M00_L06:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       cmp       edi,[rsi+8]
       jae       short M00_L09
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L08
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L10
M00_L07:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L11
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BE0]
       int       3
M00_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF91A87C450]
       jmp       short M00_L07
M00_L11:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        near ptr M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        near ptr M00_L28
       cmp       edi,ebx
       jl        short M00_L06
M00_L12:
       xor       ecx,ecx
M00_L13:
       mov       rax,[rbp-38]
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       mov       edx,[rdx+8]
       movsxd    r8,ecx
       cmp       rdx,r8
       jle       near ptr M00_L34
       mov       rdx,[rax+10]
       mov       rdx,[rdx+10]
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L27
       cmp       dword ptr [rdx+rcx*4+10],0
       je        near ptr M00_L26
       jmp       near ptr M00_L29
M00_L14:
       xor       edx,edx
       mov       [rbp-28],edx
       cmp       esi,[rbx+8]
       jae       short M00_L17
       mov       edx,esi
       mov       rdi,[rbx+rdx*8+10]
       test      rdi,rdi
       je        short M00_L16
       mov       rcx,rdi
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L18
M00_L15:
       mov       dword ptr [rbp-28],1
       jmp       short M00_L19
M00_L16:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BE0]
       int       3
M00_L17:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L18:
       mov       rcx,rdi
       call      qword ptr [7FF91A87C450]
       jmp       short M00_L15
M00_L19:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       esi,1
       jo        short M00_L28
       test      esi,esi
       jle       short M00_L14
       jmp       near ptr M00_L05
M00_L20:
       mov       ecx,edi
       mov       r14,[rsi+rcx*8+10]
       test      r14,r14
       je        short M00_L22
       mov       rcx,r14
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L23
M00_L21:
       mov       dword ptr [rbp-2C],1
       jmp       short M00_L24
M00_L22:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BE0]
       int       3
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF91A87C450]
       jmp       short M00_L21
M00_L24:
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L28
       mov       [rbp-24],ecx
       add       edi,1
       jo        short M00_L28
       cmp       edi,ebx
       jge       near ptr M00_L12
M00_L25:
       xor       ecx,ecx
       mov       [rbp-2C],ecx
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
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L32
M00_L30:
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L38
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L36
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       jne       short M00_L35
M00_L31:
       add       ebx,1
       jo        short M00_L39
       cmp       ebx,[rbp-24]
       mov       rax,[rbp-38]
       jl        short M00_L30
M00_L32:
       xor       esi,esi
M00_L33:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],sil
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L34:
       call      M00_L48
       jmp       short M00_L37
M00_L35:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A877738]
       jmp       short M00_L31
M00_L36:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BE0]
       int       3
M00_L37:
       mov       esi,1
       jmp       short M00_L33
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L40
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L41
       mov       [rbp-24],ecx
M00_L40:
       add       rsp,28
       ret
M00_L41:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L42
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L43
       mov       [rbp-24],ecx
M00_L42:
       add       rsp,28
       ret
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-28],0
       je        short M00_L44
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L45
       mov       [rbp-24],ecx
M00_L44:
       add       rsp,28
       ret
M00_L45:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M00_L46
       mov       ecx,[rbp-24]
       add       ecx,1
       jo        short M00_L47
       mov       [rbp-24],ecx
M00_L46:
       add       rsp,28
       ret
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L48:
       sub       rsp,28
       xor       ebx,ebx
       cmp       dword ptr [rbp-24],0
       jle       short M00_L54
M00_L49:
       mov       rax,[rbp-38]
       mov       rcx,[rax+10]
       mov       rcx,[rcx+18]
       cmp       ebx,[rcx+8]
       jae       short M00_L52
       mov       edx,ebx
       mov       rsi,[rcx+rdx*8+10]
       test      rsi,rsi
       je        short M00_L51
       mov       rcx,rsi
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L50
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF91A877738]
M00_L50:
       add       ebx,1
       jo        short M00_L53
       cmp       ebx,[rbp-24]
       jl        short M00_L49
       jmp       short M00_L54
M00_L51:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BE0]
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

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,2BD8D400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0EE6E6F15
       mov       r11d,73F6AECE
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A97D9C8]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FF10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
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
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A97D140]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FF10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA351A0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA351A0]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91AA346A8]
       int       3
; Total bytes of code 1060
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA7BF28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA7BF20
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A97F540]
       int       3
M02_L01:
       mov       rcx,7FF91AA7BF24
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA36670]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,23C38000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0D654AE62
       mov       r11d,23E4C84C
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34648]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A97D890]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FF10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A97D008]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FF10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA35140]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA35140]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34648]
       int       3
; Total bytes of code 1060
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA7B280
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA7B278
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A97F510]
       int       3
M02_L01:
       mov       rcx,7FF91AA7B27C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA36610]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1D310400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0C5118EB0
       mov       r11d,4E3DB42
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14618]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A95D878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FD10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0857D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A95CF00]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FD10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA15110]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA15110]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14618]
       int       3
; Total bytes of code 1058
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA5A6C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA5A6B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A95F528]
       int       3
M02_L01:
       mov       rcx,7FF91AA5A6BC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA165E0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,23227800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0E5BA5C45
       mov       r11d,0D0430948
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14630]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91AA15D58]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FD10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0857D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A94D020]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FD10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA15128]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA15128]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91AA14630]
       int       3
; Total bytes of code 1058
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M01_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M01_L01
       mov       rcx,7FF91AA5AAF0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M01_L00:
       mov       rcx,7FF91AA5AAE8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A94F4F8]
       int       3
M01_L01:
       mov       rcx,7FF91AA5AAEC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA16610]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,15C83C00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,307B6ABC
       mov       r11d,0A936E3E7
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34648]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A96F378]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FF10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A96CF30]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FF10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA35140]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA35140]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34648]
       int       3
; Total bytes of code 1058
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA7AE78
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA7AE70
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A96F510]
       int       3
M02_L01:
       mov       rcx,7FF91AA7AE74
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA366A0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,222DFC00068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,3F8A8027
       mov       r11d,0A8331E84
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91A965548]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A96F3C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FE10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0957D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A96D050]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4D7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FE10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A965560]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A965560]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91A965548]
       int       3
; Total bytes of code 1058
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA6B150
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA6B148
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A96F540]
       int       3
M02_L01:
       mov       rcx,7FF91AA6B14C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA26688]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1F50B400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,8E9BFADF
       mov       r11d,0D776305C
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91A9468E0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A94F900]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FD1378
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0857D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A94E310]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FD1370
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A9468F8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A9468F8]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91A9468E0]
       int       3
; Total bytes of code 1058
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA77D90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA77D88
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A85E8F8]
       int       3
M02_L01:
       mov       rcx,7FF91AA77D8C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA16CD0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L30
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,21259000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0F6483C21
       mov       r11d,270A70D1
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L31
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BF8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A87C408]
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FF1750
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91AA567A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FF1748
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A877738]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L32
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L32
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       xor       ebx,ebx
       jmp       near ptr M00_L17
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L32:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L33
       cmp       qword ptr [rbp-50],0
       je        short M00_L34
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L33
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A877738]
M00_L33:
       nop
       add       rsp,28
       ret
M00_L34:
       xor       ecx,ecx
       call      qword ptr [7FF91A876BF8]
       int       3
; Total bytes of code 1057
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
       call      qword ptr [7FF91A875668]
       int       3
M01_L01:
       call      qword ptr [7FF91A99E6A0]
       int       3
; Total bytes of code 45
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1F150000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,91ED6E7F
       mov       r11d,6D7255D7
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34648]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A97D980]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FF10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A97D0C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FF10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA35140]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA35140]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34648]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA7B1E0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA7B1D8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A97F498]
       int       3
M02_L01:
       mov       rcx,7FF91AA7B1DC
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA36628]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1F3F5400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,6F6B0053
       mov       r11d,3851FEC3
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA141F8]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A95D5C0]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FD10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0857D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A95CC60]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FD10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA14CF0]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA14CF0]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA141F8]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA53878
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA53870
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A95F4C8]
       int       3
M02_L01:
       mov       rcx,7FF91AA53874
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA161D8]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1B7D3800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0B948CB93
       mov       r11d,0D6654876
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24618]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A96F348]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FE10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0957D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A96CF18]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4D7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FE10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA25110]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA25110]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA24618]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA6A3E8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA6A3E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A96F4E0]
       int       3
M02_L01:
       mov       rcx,7FF91AA6A3E4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA265E0]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,23A26400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,8C7EF63A
       mov       r11d,0BA3DDF7E
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34600]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A97D878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FF10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0A57D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
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
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A97CFC0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4E7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FF10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA350F8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA350F8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA34600]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA7B2D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA7B2D0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A97F4C8]
       int       3
M02_L01:
       mov       rcx,7FF91AA7B2D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA365C8]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,227C9800068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,0F1347E42
       mov       r11d,57DA2A1F
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04600]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A94D878]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FC10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0757D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A94CFF0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4B7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FC10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA050F8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91AA050F8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91AA04600]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA4AE90
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA4AE88
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A94F510]
       int       3
M02_L01:
       mov       rcx,7FF91AA4AE8C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA06658]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,28DE9400068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,825B0DB1
       mov       r11d,73D043F9
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91A955548]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A95F390]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FE10D0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0957D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
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
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A95D020]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4D7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FE10C8
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A955560]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A955560]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A955548]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA6B020
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA6B018
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A95F510]
       int       3
M02_L01:
       mov       rcx,7FF91AA6B01C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA26658]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L20
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L21
       mov       r10,17D9F000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,2427F31B
       mov       r11d,0D378728F
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L06
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L07
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       jne       short M00_L08
       jmp       near ptr M00_L15
M00_L06:
       xor       ecx,ecx
       call      qword ptr [7FF91A9472A0]
       int       3
M00_L07:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91AA14120]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L08:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       jne       short M00_L09
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FD13A8
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       jne       short M00_L10
M00_L09:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L08
       jmp       short M00_L15
M00_L10:
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      qword ptr [7FF91A0857D0]; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       cmp       eax,4
       jb        short M00_L22
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
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91A94ECB8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FD13A0
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A9472B8]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A9472B8]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A9472A0]
       int       3
; Total bytes of code 1051
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       push      rbx
       sub       rsp,20
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rbx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       mov       rcx,7FF91AA79040
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
M02_L00:
       mov       rcx,7FF91AA79038
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91A85DB00]
       int       3
M02_L01:
       mov       rcx,7FF91AA7903C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF91AA16D18]
       int       3
; Total bytes of code 95
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3
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
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-30],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+270]
       mov       [rbp-40],r8
       mov       rdx,[rcx+50]
       mov       [rbp-48],rdx
       cmp       [r8],r8b
       test      rdx,rdx
       je        near ptr M00_L16
       mov       rax,[r8+8]
       test      rax,rax
       je        near ptr M00_L18
       mov       r10,offset MT_System.Collections.Generic.GenericEqualityComparer<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rax],r10
       jne       near ptr M00_L26
       mov       rax,[rdx+28]
       test      rax,rax
       je        near ptr M00_L19
       mov       r10,1748F000068
       mov       r10,[r10]
       mov       r9,offset MT_System.OrdinalCaseSensitiveComparer
       cmp       [r10],r9
       jne       near ptr M00_L25
       lea       r10,[rax+0C]
       mov       eax,[rax+8]
       add       eax,eax
       mov       r9d,811B0408
       mov       r11d,87B434DE
       cmp       eax,8
       jb        near ptr M00_L20
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
       jne       near ptr M00_L21
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
       mov       [rbp-2C],r10d
M00_L04:
       mov       r8,[rbp-40]
       mov       rbx,[r8+10]
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       mov       r10,[rbx+18]
       mov       r9d,[r10+8]
       mov       r11d,[rbp-2C]
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
       jae       near ptr M00_L30
       mov       ecx,edi
       mov       rcx,[r10+rcx*8+10]
       mov       [rbp-50],rcx
       xor       ecx,ecx
       mov       [rbp-30],ecx
       cmp       qword ptr [rbp-50],0
       je        short M00_L08
       mov       rcx,[rbp-50]
       call      00007FF979BB9E20
       test      eax,eax
       je        short M00_L09
M00_L05:
       mov       dword ptr [rbp-30],1
       mov       r8,[rbp-40]
       cmp       rbx,[r8+10]
       jne       near ptr M00_L28
       xor       r14d,r14d
       mov       rcx,[rbx+8]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L13
       mov       edx,esi
       mov       r15,[rcx+rdx*8+10]
       test      r15,r15
       je        near ptr M00_L15
M00_L06:
       mov       r11d,[rbp-2C]
       cmp       r11d,[r15+18]
       je        short M00_L10
M00_L07:
       mov       r14,r15
       mov       r15,[r14+10]
       test      r15,r15
       jne       short M00_L06
       jmp       near ptr M00_L15
M00_L08:
       xor       ecx,ecx
       call      qword ptr [7FF91A856C28]
       int       3
M00_L09:
       mov       rcx,[rbp-50]
       call      qword ptr [7FF91A85C438]; System.Threading.Monitor.Enter_Slowpath(System.Object)
       jmp       short M00_L05
M00_L10:
       mov       rcx,[r8+8]
       mov       rdx,[r15+8]
       mov       r8,[rbp-48]
       mov       r11,7FF919FD1750
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-40]
       je        short M00_L07
       test      r14,r14
       jne       short M00_L11
       mov       rcx,[rbx+8]
       mov       edx,esi
       mov       r8,offset MT_DotNetTips.Spargine.Core.Collections.Generic.Concurrent.ConcurrentHashSet<DotNetTips.Spargine.Tester.Models.RefTypes.Person>+Node
       call      System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       mov       rdx,[r15+10]
       mov       rcx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M00_L12
M00_L11:
       mov       rdx,[r15+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L12:
       mov       rcx,[rbx+10]
       cmp       edi,[rcx+8]
       jae       short M00_L13
       mov       eax,edi
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       sub       eax,1
       jo        short M00_L14
       mov       [rcx],eax
       mov       dword ptr [rbp-34],1
       jmp       near ptr M00_L29
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L15:
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       jne       near ptr M00_L27
M00_L16:
       xor       ebx,ebx
M00_L17:
       mov       rcx,[rbp+10]
       mov       rax,[rcx+18]
       mov       [rax+4C],bl
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L18:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF91AA36748]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF91A4C7828]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       xor       r10d,r10d
       jmp       near ptr M00_L03
M00_L20:
       cmp       eax,4
       jb        short M00_L22
M00_L21:
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
M00_L22:
       mov       ebx,80
       test      al,1
       je        short M00_L23
       mov       ebx,eax
       and       rbx,2
       movzx     ebx,byte ptr [r10+rbx]
       or        ebx,8000
M00_L23:
       test      al,2
       je        short M00_L24
       shl       ebx,10
       movzx     eax,word ptr [r10]
       or        ebx,eax
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L24:
       mov       eax,ebx
       jmp       near ptr M00_L02
M00_L25:
       mov       rcx,r10
       mov       rdx,rax
       mov       rax,[r10]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L26:
       mov       rcx,rax
       mov       r11,7FF919FD1748
       call      qword ptr [r11]
       mov       r10d,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A857768]
       jmp       near ptr M00_L16
M00_L28:
       call      M00_L31
       jmp       near ptr M00_L04
M00_L29:
       call      M00_L31
       nop
       mov       ebx,[rbp-34]
       jmp       near ptr M00_L17
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L31:
       sub       rsp,28
       cmp       dword ptr [rbp-30],0
       je        short M00_L32
       cmp       qword ptr [rbp-50],0
       je        short M00_L33
       mov       rcx,[rbp-50]
       call      00007FF979C76030
       test      eax,eax
       je        short M00_L32
       mov       ecx,eax
       mov       rdx,[rbp-50]
       call      qword ptr [7FF91A857768]
M00_L32:
       nop
       add       rsp,28
       ret
M00_L33:
       xor       ecx,ecx
       call      qword ptr [7FF91A856C28]
       int       3
; Total bytes of code 1052
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
       call      qword ptr [7FF9465E8018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FF9465E8020]; CORINFO_HELP_JIT_PINVOKE_END
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
; System.Runtime.CompilerServices.CastHelpers.LdelemaRef(System.Object[], IntPtr, Void*)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       cmp       [rcx+30],r8
       jne       short M02_L01
       add       rsp,28
       ret
M02_L00:
       call      qword ptr [7FF91A855698]
       int       3
M02_L01:
       call      qword ptr [7FF91A96E6E8]
       int       3
; Total bytes of code 45
```

