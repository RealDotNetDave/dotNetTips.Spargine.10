## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.CalculateTotalFileSize()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       test      rcx,rcx
       je        near ptr M00_L05
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M00_L00:
       test      edi,edi
       je        near ptr M00_L06
       xor       ebp,ebp
       xor       r14d,r14d
M00_L01:
       mov       r15,[rsi+r14*8]
       test      r15,r15
       je        short M00_L07
       mov       rcx,r15
       call      qword ptr [7FFCDE4200B8]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        short M00_L07
       cmp       dword ptr [r15+28],0FFFFFFFF
       je        short M00_L08
M00_L02:
       cmp       dword ptr [r15+28],0
       jne       near ptr M00_L10
       test      byte ptr [r15+30],10
       jne       short M00_L09
       cmp       dword ptr [r15+28],0
       jne       near ptr M00_L10
       mov       ecx,[r15+4C]
       shl       rcx,20
       mov       eax,[r15+50]
       or        rcx,rax
M00_L03:
       add       rbp,rcx
       jo        near ptr M00_L11
       inc       r14d
       cmp       r14d,edi
       jl        short M00_L01
       mov       rax,rbp
M00_L04:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L00
M00_L06:
       xor       eax,eax
       jmp       short M00_L04
M00_L07:
       xor       ecx,ecx
       jmp       short M00_L03
M00_L08:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [r15+30],ymm0
       vmovdqu   xmmword ptr [r15+44],xmm0
       mov       rcx,r15
       call      qword ptr [7FFCDE6DCF00]
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFCDE6DCF18]
       mov       rcx,rax
       mov       rdx,[r15+8]
       call      qword ptr [7FFCDE5BE6E8]
       mov       rdx,rax
       mov       r8,[r15+8]
       mov       rcx,rbp
       call      qword ptr [7FFCDE6DCF30]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,[r15+28]
       mov       rdx,[r15+8]
       xor       r8d,r8d
       call      qword ptr [7FFCDE6DC750]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 306
```
```assembly
; System.IO.FileInfo.get_Exists()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,2C0
       vzeroupper
       lea       rbp,[rsp+2F0]
       xor       eax,eax
       mov       [rbp-2C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-2C0],ymm4
       mov       [rbp-2A0],rax
       mov       rax,3BBDC49CC573
       mov       [rbp-38],rax
       mov       rbx,rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       jne       near ptr M01_L15
       mov       rsi,[rbx+8]
       lea       rdi,[rbx+30]
       xor       r14d,r14d
       test      rsi,rsi
       je        short M01_L01
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        short M01_L01
       lea       r13d,[r15-1]
       mov       ecx,r13d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M01_L20
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       jne       near ptr M01_L21
M01_L01:
       mov       r15,rsi
M01_L02:
       xor       ecx,ecx
       mov       [rbp-298],rcx
       mov       [rbp-294],ecx
       call      00007FFCDE018C90
       lea       rdx,[rbp-294]
       mov       ecx,1
       call      00007FFCDE018CA8
       mov       esi,eax
       call      00007FFCDE018CC0
       mov       ecx,eax
       call      00007FFD3DCA6FE0
       test      esi,esi
       setne     cl
       movzx     ecx,cl
       mov       [rbp-298],cl
       movzx     ecx,byte ptr [rbp-298]
       mov       [rbp-2B4],cl
       mov       ecx,[rbp-294]
       mov       [rbp-2B8],ecx
       test      r15,r15
       je        short M01_L03
       cmp       dword ptr [r15+8],104
       jge       near ptr M01_L06
       mov       rcx,r15
       call      qword ptr [7FFCDE2BFD68]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
       test      eax,eax
       jne       short M01_L06
M01_L03:
       mov       rsi,r15
M01_L04:
       mov       [rbp-2A0],rdi
       mov       r13,rdi
       test      rsi,rsi
       je        short M01_L07
       add       rsi,0C
M01_L05:
       mov       [rbp-2A8],rsi
       xor       ecx,ecx
       call      00007FFCDE018C90
       mov       rcx,rsi
       mov       r8,r13
       xor       edx,edx
       call      00007FFCDE018CD8
       mov       esi,eax
       call      00007FFCDE018CC0
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFD3DCA6FE0
       test      esi,esi
       jne       near ptr M01_L11
       call      00007FFD3DCA6FC0
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFCDE6567A8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L11
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFCDE656820]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L07:
       xor       esi,esi
       jmp       short M01_L05
M01_L08:
       lea       rcx,[rbp-288]
       mov       edx,250
       call      qword ptr [7FFCDE0257E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-288]
       mov       rcx,r15
       call      qword ptr [7FFCDE6DDB30]
       mov       [rbp-2D0],rax
       mov       rcx,[rbp-2D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFCDE197810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L09
       call      00007FFD3DCA6FC0
       mov       r14d,eax
       jmp       short M01_L10
M01_L09:
       xor       r14d,r14d
       lea       rdx,[rbp-288]
       mov       rcx,rdi
       call      qword ptr [7FFCDE6DDB48]
       nop
M01_L10:
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFCDE02DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFCDE1F5590]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L11:
       cmp       byte ptr [rbp-2B4],0
       je        short M01_L12
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFCDE018C90
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFCDE018CA8
       call      00007FFCDE018CC0
       mov       ecx,eax
       call      00007FFD3DCA6FE0
M01_L12:
       test      r14d,r14d
       jne       short M01_L16
M01_L13:
       mov       eax,r14d
M01_L14:
       mov       [rbx+28],eax
M01_L15:
       cmp       dword ptr [rbx+28],0
       jne       short M01_L18
       cmp       dword ptr [rbx+30],0FFFFFFFF
       je        short M01_L18
       test      byte ptr [rbx+30],10
       sete      al
       movzx     eax,al
       jmp       short M01_L19
M01_L16:
       lea       eax,[r14-2]
       cmp       eax,1
       ja        short M01_L22
M01_L17:
       mov       dword ptr [rdi],0FFFFFFFF
       xor       eax,eax
       jmp       short M01_L14
M01_L18:
       xor       eax,eax
M01_L19:
       mov       [rbp-28C],eax
       jmp       short M01_L23
M01_L20:
       mov       ecx,1
       jmp       near ptr M01_L00
M01_L21:
       lea       rcx,[rsi+0C]
       mov       [rbp-2C8],rcx
       mov       [rbp-2C0],r15d
       lea       rcx,[rbp-2C8]
       call      qword ptr [7FFCDE6567D8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r15d
       je        near ptr M01_L01
       mov       r8d,r13d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFCDE2B7450]; System.String.Substring(Int32, Int32)
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L22:
       cmp       r14d,15
       jne       near ptr M01_L13
       jmp       short M01_L17
M01_L23:
       mov       eax,[rbp-28C]
       mov       r8,3BBDC49CC573
       cmp       [rbp-38],r8
       je        short M01_L24
       call      CORINFO_HELP_FAIL_FAST
M01_L24:
       nop
       add       rsp,2C0
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-2D0],0
       je        short M01_L25
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFCDE02DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFCDE1F5590]; System.GC.SuppressFinalize(System.Object)
M01_L25:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2B4],0
       je        short M01_L26
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFCDE018C90
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFCDE018CA8
       call      00007FFCDE018CC0
       mov       ecx,eax
       call      00007FFD3DCA6FE0
M01_L26:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       mov       [rbp-28C],eax
       lea       rax,[M01_L23]
       add       rsp,28
       ret
; Total bytes of code 917
```

## .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.FileHasInvalidChars()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L19
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M00_L06
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L07
M00_L00:
       test      rax,rax
       jne       near ptr M00_L05
       xor       ecx,ecx
       xor       edx,edx
M00_L01:
       mov       rax,1BA608021F8
       mov       rax,[rax]
       mov       r8,rcx
       mov       r10d,edx
       add       rax,8
       mov       r9,r8
       cmp       r10d,8
       jl        near ptr M00_L08
       cmp       r10d,10
       jle       near ptr M00_L17
       vmovups   ymm0,[rax]
       cmp       r10d,20
       jg        near ptr M00_L12
M00_L02:
       add       r10d,0FFFFFFF0
       movsxd    rax,r10d
       lea       rax,[r8+rax*2]
       cmp       r9,rax
       mov       rcx,r9
       cmova     rcx,rax
       vbroadcastss ymm1,dword ptr [7FFCDE0D9260]
       vpminuw   ymm2,ymm1,[rcx]
       vpminuw   ymm1,ymm1,[rax]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFCDE0D9280]
       vbroadcastsd ymm2,qword ptr [7FFCDE0D92A0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M00_L15
M00_L03:
       mov       ecx,0FFFFFFFF
M00_L04:
       mov       eax,ecx
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L05:
       lea       rcx,[rax+0C]
       mov       edx,[rax+8]
       jmp       near ptr M00_L01
M00_L06:
       call      qword ptr [7FFCDE5AE868]
       mov       ecx,0A39
       mov       rdx,7FFCDE68A890
       call      qword ptr [7FFCDE2477B0]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFCDE2F5548
       call      qword ptr [7FFCDE2477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE027840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFCDE68A890
       call      qword ptr [7FFCDE2477B0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFCDE027840]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFCDE7073C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFCDE706340]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       mov       rcx,[rsi+10]
       call      qword ptr [7FFCDE706250]
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L00
M00_L08:
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       cmp       r9,rcx
       je        near ptr M00_L03
M00_L09:
       movzx     edx,word ptr [r9]
       cmp       [rax],al
       lea       r10,[rax+20]
       cmp       edx,100
       jge       short M00_L10
       cmp       [r10],r10b
       mov       r11d,edx
       sar       r11d,5
       mov       r10d,[r10+r11*4]
       bt        r10d,edx
       setb      dl
       movzx     edx,dl
       test      edx,edx
       jne       short M00_L11
M00_L10:
       add       r9,2
       cmp       r9,rcx
       jne       short M00_L09
       jmp       near ptr M00_L03
M00_L11:
       mov       rcx,r9
       sub       rcx,r8
       shr       rcx,1
       jmp       near ptr M00_L04
M00_L12:
       lea       eax,[r10-20]
       movsxd    rdx,eax
       lea       rcx,[r8+rdx*2]
M00_L13:
       vbroadcastss ymm1,dword ptr [7FFCDE0D9260]
       vpminuw   ymm2,ymm1,[r9]
       vpminuw   ymm1,ymm1,[r9+20]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFCDE0D9280]
       vbroadcastsd ymm3,qword ptr [7FFCDE0D92A0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vptest    ymm1,ymm1
       jne       short M00_L14
       add       r9,40
       cmp       r9,rcx
       jb        short M00_L13
       jmp       near ptr M00_L02
M00_L14:
       mov       rcx,r9
       sub       rcx,r8
       shr       rcx,1
       vpermq    ymm0,ymm1,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r8d,ymm0
       mov       r9d,r8d
       not       r9d
       xor       eax,eax
       tzcnt     eax,r9d
       add       ecx,eax
       jmp       near ptr M00_L04
M00_L15:
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r9d,ymm0
       mov       edx,r9d
       not       edx
       tzcnt     edx,edx
       cmp       edx,10
       jl        short M00_L16
       mov       rcx,rax
       add       edx,0FFFFFFF0
M00_L16:
       sub       rcx,r8
       shr       rcx,1
       add       ecx,edx
       jmp       near ptr M00_L04
M00_L17:
       vmovups   xmm0,[rax]
       add       edx,0FFFFFFF8
       movsxd    rax,edx
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm1,[rdx]
       vpminuw   xmm1,xmm1,[7FFCDE0D92B0]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FFCDE0D92B0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFCDE0D9280]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFCDE0D92A0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M00_L03
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb r8d,xmm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M00_L18
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M00_L18:
       sub       rdx,rcx
       shr       rdx,1
       lea       ecx,[rdx+r8]
       jmp       near ptr M00_L04
M00_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 875
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M01_L01
       test      rsi,rsi
       je        short M01_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M01_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFD3DCAA1D0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFCDE025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFCDE025818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L00:
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L01:
       test      rsi,rsi
       je        short M01_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L03
M01_L02:
       mov       rax,1FAF5700008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFCDE7051A0]
       int       3
; Total bytes of code 244
```

