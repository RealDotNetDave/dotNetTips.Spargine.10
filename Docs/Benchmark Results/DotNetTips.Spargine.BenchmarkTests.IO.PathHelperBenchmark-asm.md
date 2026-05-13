## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.CombinePathsParams()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,7FFC49676098
       mov       rcx,offset MT_System.String[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,20C41080760
       mov       [rdi+10],rcx
       mov       rcx,20C41080780
       mov       [rdi+18],rcx
       mov       rcx,20C410807A8
       mov       [rdi+20],rcx
       mov       rcx,20C410807D0
       mov       [rdi+28],rcx
       xor       ebp,ebp
M00_L00:
       movsxd    rcx,ebp
       cmp       rcx,4
       jge       near ptr M00_L04
       cmp       ebp,4
       jae       near ptr M00_L11
       mov       r14d,ebp
       mov       r15,[rdi+r14*8+10]
       test      r15,r15
       je        near ptr M00_L05
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L01:
       dec       r13d
       mov       ecx,r13d
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L08
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L02:
       mov       rdx,r15
M00_L03:
       lea       rcx,[rdi+r14*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       add       ebp,1
       jo        near ptr M00_L12
       jmp       near ptr M00_L00
M00_L04:
       add       rdi,10
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+28],rdi
       mov       dword ptr [rsp+30],4
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBEC66F750]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFBEC25FD50]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       cmove     rbp,rdi
       xor       ecx,ecx
       mov       [rsi+18],rcx
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+54],1
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edx,edx
       jmp       near ptr M00_L03
M00_L06:
       mov       rdx,20C41070008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFBEC6E5AA0]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFBEC6E5AA0]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFBEC6E7E40]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF74000
       call      qword ptr [7FFBEC2577B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC45DF50]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 543
```
```assembly
; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0C96DFE086E9D
       mov       [rbp+8],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       xor       edi,edi
       xor       r14d,r14d
       xor       ecx,ecx
       cmp       ecx,esi
       jge       near ptr M01_L05
M01_L00:
       mov       rdx,[rbx+rcx*8]
       test      rdx,rdx
       je        near ptr M01_L23
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L04
       mov       rax,rdx
       lea       r8,[rax+0C]
       mov       eax,[rax+8]
       mov       r10d,eax
       test      r10d,r10d
       jle       short M01_L01
       movzx     r9d,word ptr [r8]
       cmp       r9d,5C
       je        near ptr M01_L14
       cmp       r9d,2F
       je        near ptr M01_L14
M01_L01:
       cmp       r10d,2
       jl        near ptr M01_L22
       movzx     r9d,word ptr [r8]
       or        r9d,20
       add       r9d,0FFFFFF9F
       cmp       r9d,19
       ja        near ptr M01_L22
       cmp       word ptr [r8+2],3A
       sete      r9b
       movzx     r9d,r9b
M01_L02:
       test      r9d,r9d
       jne       near ptr M01_L15
       add       edi,[rdx+8]
M01_L03:
       lea       r8d,[rax-1]
       cmp       r8d,eax
       jae       near ptr M01_L32
       mov       eax,r8d
       movzx     edx,word ptr [rdx+rax*2+0C]
       cmp       edx,5C
       je        short M01_L04
       cmp       edx,2F
       je        short M01_L04
       inc       edi
M01_L04:
       inc       ecx
       cmp       ecx,esi
       jl        near ptr M01_L00
M01_L05:
       test      [rsp],esp
       sub       rsp,210
       lea       rdx,[rsp+20]
       xor       ecx,ecx
       mov       [rbp+20],rcx
       mov       [rbp+30],rdx
       mov       dword ptr [rbp+38],104
       mov       [rbp+28],ecx
       cmp       edi,[rbp+38]
       ja        near ptr M01_L24
M01_L06:
       mov       edi,r14d
       cmp       edi,esi
       jge       near ptr M01_L12
M01_L07:
       mov       r14,[rbx+rdi*8]
       cmp       dword ptr [r14+8],0
       je        near ptr M01_L11
       mov       r15d,[rbp+28]
       test      r15d,r15d
       je        near ptr M01_L16
       lea       ecx,[r15-1]
       cmp       ecx,[rbp+38]
       jae       near ptr M01_L32
       mov       rdx,[rbp+30]
       movzx     ecx,word ptr [rdx+rcx*2]
       cmp       ecx,5C
       je        short M01_L08
       cmp       ecx,2F
       je        short M01_L08
       mov       rcx,[rbp+30]
       mov       edx,[rbp+38]
       cmp       r15d,edx
       jae       near ptr M01_L27
       mov       edx,r15d
       mov       word ptr [rcx+rdx*2],5C
       inc       r15d
       mov       [rbp+28],r15d
M01_L08:
       mov       r14,[rbx+rdi*8]
       test      r14,r14
       je        short M01_L11
       mov       r15d,[rbp+28]
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L28
M01_L09:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L29
M01_L10:
       mov       r8d,[rbp+38]
       cmp       r15d,r8d
       ja        short M01_L13
       mov       rdx,[rbp+30]
       mov       ecx,r15d
       lea       rcx,[rdx+rcx*2]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L30
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC035818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
M01_L11:
       inc       edi
       cmp       edi,esi
       jl        near ptr M01_L07
M01_L12:
       mov       r15d,[rbp+28]
       mov       ecx,r15d
       cmp       ecx,[rbp+38]
       jbe       near ptr M01_L19
M01_L13:
       call      qword ptr [7FFBEC1A7198]
       int       3
M01_L14:
       mov       r9d,1
       jmp       near ptr M01_L02
M01_L15:
       mov       r14d,ecx
       mov       edi,[rdx+8]
       jmp       near ptr M01_L03
M01_L16:
       test      r14,r14
       je        short M01_L11
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L25
M01_L17:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L26
M01_L18:
       cmp       r15d,[rbp+38]
       ja        short M01_L13
       mov       r8,[rbp+30]
       mov       edx,r15d
       lea       rcx,[r8+rdx*2]
       mov       r8d,[rbp+38]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L30
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC035818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L19:
       mov       rax,[rbp+30]
       mov       [rbp+10],rax
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+20],ymm0
       test      rdx,rdx
       jne       near ptr M01_L31
M01_L20:
       mov       rax,rbx
       mov       r8,0C96DFE086E9D
       cmp       [rbp+8],r8
       je        short M01_L21
       call      CORINFO_HELP_FAIL_FAST
M01_L21:
       nop
       lea       rsp,[rbp+40]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L23:
       mov       ecx,1C4AC
       mov       rdx,7FFBEBF74000
       call      qword ptr [7FFBEC2577B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC45DF50]
       int       3
M01_L24:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC456E50]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L06
M01_L25:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L17
       cmp       edx,[rbp+38]
       jae       near ptr M01_L32
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L26:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC456E50]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L18
M01_L27:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFBEC6E5968]
       jmp       near ptr M01_L08
M01_L28:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L09
       cmp       edx,[rbp+38]
       jae       short M01_L32
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L29:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC456E50]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L30:
       call      qword ptr [7FFBEC534540]
       int       3
M01_L31:
       mov       rcx,1CBAC000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBEC3007A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L20
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 959
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L02
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC25FD68]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFBEC25FD98]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC25FDC8]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFBEC25FDE0]; System.IO.PathHelper.Normalize(System.String)
       jmp       short M02_L01
M02_L00:
       mov       rax,rbx
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF74000
       call      qword ptr [7FFBEC2577B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC45DF50]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6E7F30]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF74000
       call      qword ptr [7FFBEC2577B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC3B6F40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6E7F48]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF74000
       call      qword ptr [7FFBEC2577B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC3B6F40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.CombinePathsFour()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,7FFC49676098
       mov       rcx,offset MT_System.String[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,2686A4C0760
       mov       [rdi+10],rcx
       mov       rcx,2686A4C0780
       mov       [rdi+18],rcx
       mov       rcx,2686A4C07A8
       mov       [rdi+20],rcx
       mov       rcx,2686A4C07D0
       mov       [rdi+28],rcx
       xor       ebp,ebp
       jmp       short M00_L04
M00_L00:
       cmp       ebp,4
       jae       near ptr M00_L11
       mov       r14d,ebp
       mov       r15,[rdi+r14*8+10]
       test      r15,r15
       je        near ptr M00_L05
       mov       r13d,[r15+8]
       test      r13d,r13d
       je        near ptr M00_L06
       movzx     ecx,word ptr [r15+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L01:
       dec       r13d
       mov       ecx,r13d
       movzx     ecx,word ptr [r15+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L08
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L02:
       mov       rdx,r15
M00_L03:
       lea       rcx,[rdi+r14*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       add       ebp,1
       jo        near ptr M00_L12
M00_L04:
       movsxd    rcx,ebp
       cmp       rcx,4
       jl        near ptr M00_L00
       add       rdi,10
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+28],rdi
       mov       dword ptr [rsp+30],4
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBEC63D9C8]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFBEC23EFA0]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       cmove     rbp,rdi
       xor       ecx,ecx
       mov       [rsi+18],rcx
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+54],1
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edx,edx
       jmp       near ptr M00_L03
M00_L06:
       mov       rdx,2686A4B0008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFBEC6D4948]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFBEC6D4948]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFBEC6D4960]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF54000
       call      qword ptr [7FFBEC2377B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC6D4120]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 540
```
```assembly
; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,4D415E5E435F
       mov       [rbp+8],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       xor       edi,edi
       xor       r14d,r14d
       xor       ecx,ecx
       cmp       ecx,esi
       jge       near ptr M01_L05
M01_L00:
       mov       rdx,[rbx+rcx*8]
       test      rdx,rdx
       je        near ptr M01_L22
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L04
       mov       rax,rdx
       lea       r8,[rax+0C]
       mov       eax,[rax+8]
       mov       r10d,eax
       test      r10d,r10d
       jle       short M01_L01
       movzx     r9d,word ptr [r8]
       cmp       r9d,5C
       je        near ptr M01_L15
       cmp       r9d,2F
       je        near ptr M01_L15
M01_L01:
       cmp       r10d,2
       jl        near ptr M01_L21
       movzx     r9d,word ptr [r8]
       or        r9d,20
       add       r9d,0FFFFFF9F
       cmp       r9d,19
       ja        near ptr M01_L21
       cmp       word ptr [r8+2],3A
       sete      r9b
       movzx     r9d,r9b
M01_L02:
       test      r9d,r9d
       jne       near ptr M01_L16
       add       edi,[rdx+8]
M01_L03:
       lea       r8d,[rax-1]
       cmp       r8d,eax
       jae       near ptr M01_L31
       mov       eax,r8d
       movzx     edx,word ptr [rdx+rax*2+0C]
       cmp       edx,5C
       je        short M01_L04
       cmp       edx,2F
       je        short M01_L04
       inc       edi
M01_L04:
       inc       ecx
       cmp       ecx,esi
       jl        near ptr M01_L00
M01_L05:
       test      [rsp],esp
       sub       rsp,210
       lea       rdx,[rsp+20]
       xor       ecx,ecx
       mov       [rbp+20],rcx
       mov       [rbp+30],rdx
       mov       dword ptr [rbp+38],104
       mov       [rbp+28],ecx
       cmp       edi,[rbp+38]
       ja        near ptr M01_L23
M01_L06:
       mov       edi,r14d
       cmp       edi,esi
       jge       near ptr M01_L12
M01_L07:
       mov       r14,[rbx+rdi*8]
       cmp       dword ptr [r14+8],0
       je        near ptr M01_L11
       mov       r15d,[rbp+28]
       test      r15d,r15d
       je        near ptr M01_L17
       lea       ecx,[r15-1]
       cmp       ecx,[rbp+38]
       jae       near ptr M01_L31
       mov       rdx,[rbp+30]
       movzx     ecx,word ptr [rdx+rcx*2]
       cmp       ecx,5C
       je        short M01_L08
       cmp       ecx,2F
       je        short M01_L08
       mov       rcx,[rbp+30]
       mov       edx,[rbp+38]
       cmp       r15d,edx
       jae       near ptr M01_L26
       mov       edx,r15d
       mov       word ptr [rcx+rdx*2],5C
       inc       r15d
       mov       [rbp+28],r15d
M01_L08:
       mov       r14,[rbx+rdi*8]
       test      r14,r14
       je        short M01_L11
       mov       r15d,[rbp+28]
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L27
M01_L09:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L28
M01_L10:
       mov       r8d,[rbp+38]
       cmp       r15d,r8d
       ja        near ptr M01_L30
       mov       rdx,[rbp+30]
       mov       ecx,r15d
       lea       rcx,[rdx+rcx*2]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L29
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC015818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
M01_L11:
       inc       edi
       cmp       edi,esi
       jl        near ptr M01_L07
M01_L12:
       mov       r15d,[rbp+28]
       mov       ecx,r15d
       cmp       ecx,[rbp+38]
       ja        near ptr M01_L30
       mov       rax,[rbp+30]
       mov       [rbp+10],rax
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+20],ymm0
       test      rdx,rdx
       jne       near ptr M01_L20
M01_L13:
       mov       rax,rbx
       mov       r8,4D415E5E435F
       cmp       [rbp+8],r8
       je        short M01_L14
       call      CORINFO_HELP_FAIL_FAST
M01_L14:
       nop
       lea       rsp,[rbp+40]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       r9d,1
       jmp       near ptr M01_L02
M01_L16:
       mov       r14d,ecx
       mov       edi,[rdx+8]
       jmp       near ptr M01_L03
M01_L17:
       test      r14,r14
       je        near ptr M01_L11
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L24
M01_L18:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L25
M01_L19:
       cmp       r15d,[rbp+38]
       ja        near ptr M01_L30
       mov       r8,[rbp+30]
       mov       edx,r15d
       lea       rcx,[r8+rdx*2]
       mov       r8d,[rbp+38]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L29
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC015818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,227D5400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBEC2E07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FFBEBF54000
       call      qword ptr [7FFBEC2377B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC6D4120]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4260A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L06
M01_L24:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L18
       cmp       edx,[rbp+38]
       jae       near ptr M01_L31
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L25:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4260A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFBEC6D5230]
       jmp       near ptr M01_L08
M01_L27:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L09
       cmp       edx,[rbp+38]
       jae       short M01_L31
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L28:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4260A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FFBEC42D218]
       int       3
M01_L30:
       call      qword ptr [7FFBEC187198]
       int       3
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 971
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L02
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC23EFB8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFBEC23EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC23F018]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFBEC23F030]; System.IO.PathHelper.Normalize(System.String)
       jmp       short M02_L01
M02_L00:
       mov       rax,rbx
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF54000
       call      qword ptr [7FFBEC2377B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC6D4120]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6D4A80]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF54000
       call      qword ptr [7FFBEC2377B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC396190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6D4A98]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF54000
       call      qword ptr [7FFBEC2377B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC396190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.CombinePathsThree()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rsi,7FFC49676098
       mov       rcx,offset MT_System.String[]
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,27613970760
       mov       [rdi+10],rcx
       mov       rcx,27613970780
       mov       [rdi+18],rcx
       mov       rcx,276139707A8
       mov       [rdi+20],rcx
       xor       ebp,ebp
M00_L00:
       movsxd    rcx,ebp
       cmp       rcx,3
       jge       near ptr M00_L04
       cmp       ebp,3
       jae       near ptr M00_L11
       mov       r14,[rdi+rbp*8+10]
       test      r14,r14
       je        near ptr M00_L05
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        near ptr M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L01:
       dec       r15d
       mov       ecx,r15d
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L08
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L02:
       mov       rdx,r14
M00_L03:
       lea       rcx,[rdi+rbp*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       add       ebp,1
       jo        near ptr M00_L12
       jmp       near ptr M00_L00
M00_L04:
       add       rdi,10
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+20],rdi
       mov       dword ptr [rsp+28],3
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC62DAD0]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFBEC22EFA0]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       cmove     rbp,rdi
       xor       ecx,ecx
       mov       [rsi+18],rcx
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+54],1
       mov       [rsp+30],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L05:
       xor       edx,edx
       jmp       near ptr M00_L03
M00_L06:
       mov       rdx,27613960008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFBEC6C4990]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFBEC6C4990]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFBEC6C49A8]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC6C4168]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 522
```
```assembly
; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0CEC5B898A032
       mov       [rbp+8],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       xor       edi,edi
       xor       r14d,r14d
       xor       ecx,ecx
       cmp       ecx,esi
       jge       near ptr M01_L05
M01_L00:
       mov       rdx,[rbx+rcx*8]
       test      rdx,rdx
       je        near ptr M01_L22
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L04
       mov       rax,rdx
       lea       r8,[rax+0C]
       mov       eax,[rax+8]
       mov       r10d,eax
       test      r10d,r10d
       jle       short M01_L01
       movzx     r9d,word ptr [r8]
       cmp       r9d,5C
       je        near ptr M01_L15
       cmp       r9d,2F
       je        near ptr M01_L15
M01_L01:
       cmp       r10d,2
       jl        near ptr M01_L21
       movzx     r9d,word ptr [r8]
       or        r9d,20
       add       r9d,0FFFFFF9F
       cmp       r9d,19
       ja        near ptr M01_L21
       cmp       word ptr [r8+2],3A
       sete      r9b
       movzx     r9d,r9b
M01_L02:
       test      r9d,r9d
       jne       near ptr M01_L16
       add       edi,[rdx+8]
M01_L03:
       lea       r8d,[rax-1]
       cmp       r8d,eax
       jae       near ptr M01_L31
       mov       eax,r8d
       movzx     edx,word ptr [rdx+rax*2+0C]
       cmp       edx,5C
       je        short M01_L04
       cmp       edx,2F
       je        short M01_L04
       inc       edi
M01_L04:
       inc       ecx
       cmp       ecx,esi
       jl        near ptr M01_L00
M01_L05:
       test      [rsp],esp
       sub       rsp,210
       lea       rdx,[rsp+20]
       xor       ecx,ecx
       mov       [rbp+20],rcx
       mov       [rbp+30],rdx
       mov       dword ptr [rbp+38],104
       mov       [rbp+28],ecx
       cmp       edi,[rbp+38]
       ja        near ptr M01_L23
M01_L06:
       mov       edi,r14d
       cmp       edi,esi
       jge       near ptr M01_L12
M01_L07:
       mov       r14,[rbx+rdi*8]
       cmp       dword ptr [r14+8],0
       je        near ptr M01_L11
       mov       r15d,[rbp+28]
       test      r15d,r15d
       je        near ptr M01_L17
       lea       ecx,[r15-1]
       cmp       ecx,[rbp+38]
       jae       near ptr M01_L31
       mov       rdx,[rbp+30]
       movzx     ecx,word ptr [rdx+rcx*2]
       cmp       ecx,5C
       je        short M01_L08
       cmp       ecx,2F
       je        short M01_L08
       mov       rcx,[rbp+30]
       mov       edx,[rbp+38]
       cmp       r15d,edx
       jae       near ptr M01_L26
       mov       edx,r15d
       mov       word ptr [rcx+rdx*2],5C
       inc       r15d
       mov       [rbp+28],r15d
M01_L08:
       mov       r14,[rbx+rdi*8]
       test      r14,r14
       je        short M01_L11
       mov       r15d,[rbp+28]
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L27
M01_L09:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L28
M01_L10:
       mov       r8d,[rbp+38]
       cmp       r15d,r8d
       ja        near ptr M01_L30
       mov       rdx,[rbp+30]
       mov       ecx,r15d
       lea       rcx,[rdx+rcx*2]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L29
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
M01_L11:
       inc       edi
       cmp       edi,esi
       jl        near ptr M01_L07
M01_L12:
       mov       r15d,[rbp+28]
       mov       ecx,r15d
       cmp       ecx,[rbp+38]
       ja        near ptr M01_L30
       mov       rax,[rbp+30]
       mov       [rbp+10],rax
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+20],ymm0
       test      rdx,rdx
       jne       near ptr M01_L20
M01_L13:
       mov       rax,rbx
       mov       r8,0CEC5B898A032
       cmp       [rbp+8],r8
       je        short M01_L14
       call      CORINFO_HELP_FAIL_FAST
M01_L14:
       nop
       lea       rsp,[rbp+40]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       r9d,1
       jmp       near ptr M01_L02
M01_L16:
       mov       r14d,ecx
       mov       edi,[rdx+8]
       jmp       near ptr M01_L03
M01_L17:
       test      r14,r14
       je        near ptr M01_L11
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L24
M01_L18:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L25
M01_L19:
       cmp       r15d,[rbp+38]
       ja        near ptr M01_L30
       mov       r8,[rbp+30]
       mov       edx,r15d
       lea       rcx,[r8+rdx*2]
       mov       r8d,[rbp+38]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L29
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,2357E800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBEC2D07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC6C4168]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4160A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L06
M01_L24:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L18
       cmp       edx,[rbp+38]
       jae       near ptr M01_L31
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L25:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4160A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFBEC6C5260]
       jmp       near ptr M01_L08
M01_L27:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L09
       cmp       edx,[rbp+38]
       jae       short M01_L31
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L28:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4160A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FFBEC41D218]
       int       3
M01_L30:
       call      qword ptr [7FFBEC177198]
       int       3
M01_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 971
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L02
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC22EFB8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFBEC22EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC22F018]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFBEC22F030]; System.IO.PathHelper.Normalize(System.String)
       jmp       short M02_L01
M02_L00:
       mov       rax,rbx
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC6C4168]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6C4AC8]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6C4AE0]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.CombinePathsTwo()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rsi,7FFC49676098
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,21136480760
       mov       [rdi+10],rcx
       mov       rcx,21136480780
       mov       [rdi+18],rcx
       xor       ebp,ebp
M00_L00:
       movsxd    rcx,ebp
       cmp       rcx,2
       jge       near ptr M00_L04
       cmp       ebp,2
       jae       near ptr M00_L11
       mov       r14,[rdi+rbp*8+10]
       test      r14,r14
       je        near ptr M00_L05
       cmp       dword ptr [r14+8],0
       je        near ptr M00_L06
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L01:
       mov       ecx,[r14+8]
       dec       ecx
       cmp       ecx,[r14+8]
       jae       near ptr M00_L11
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L08
       test      byte ptr [rsi+rcx],80
       jne       near ptr M00_L09
M00_L02:
       mov       rdx,r14
M00_L03:
       lea       rcx,[rdi+rbp*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       add       ebp,1
       jo        near ptr M00_L12
       jmp       near ptr M00_L00
M00_L04:
       add       rdi,10
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+28],rdi
       mov       dword ptr [rsp+30],2
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBEC615DE8]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFBEC22EFA0]; System.IO.Path.GetFullPath(System.String)
       mov       rbp,rax
       lea       rcx,[rsi+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbp,rbp
       cmove     rbp,rdi
       xor       ecx,ecx
       mov       [rsi+18],rcx
       lea       rcx,[rsi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+54],1
       mov       [rsp+38],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L05:
       xor       edx,edx
       jmp       near ptr M00_L03
M00_L06:
       mov       rdx,21136470008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFBEC61E2E0]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFBEC61E2E0]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFBEC61E2F8]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC61E0D0]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 512
```
```assembly
; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,60F5788A32D3
       mov       [rbp+8],rax
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       xor       edi,edi
       xor       r14d,r14d
       xor       ecx,ecx
       cmp       ecx,esi
       jge       near ptr M01_L05
M01_L00:
       mov       rdx,[rbx+rcx*8]
       test      rdx,rdx
       je        near ptr M01_L22
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L04
       mov       rax,rdx
       lea       r8,[rax+0C]
       mov       eax,[rax+8]
       mov       r10d,eax
       test      r10d,r10d
       jle       short M01_L01
       movzx     r9d,word ptr [r8]
       cmp       r9d,5C
       je        near ptr M01_L15
       cmp       r9d,2F
       je        near ptr M01_L15
M01_L01:
       cmp       r10d,2
       jl        near ptr M01_L21
       movzx     r9d,word ptr [r8]
       or        r9d,20
       add       r9d,0FFFFFF9F
       cmp       r9d,19
       ja        near ptr M01_L21
       cmp       word ptr [r8+2],3A
       sete      r9b
       movzx     r9d,r9b
M01_L02:
       test      r9d,r9d
       je        near ptr M01_L16
       mov       r14d,ecx
       mov       edi,[rdx+8]
M01_L03:
       lea       r8d,[rax-1]
       cmp       r8d,eax
       jae       near ptr M01_L32
       mov       eax,r8d
       movzx     edx,word ptr [rdx+rax*2+0C]
       cmp       edx,5C
       je        short M01_L04
       cmp       edx,2F
       je        short M01_L04
       inc       edi
M01_L04:
       inc       ecx
       cmp       ecx,esi
       jl        near ptr M01_L00
M01_L05:
       test      [rsp],esp
       sub       rsp,210
       lea       rdx,[rsp+20]
       xor       ecx,ecx
       mov       [rbp+20],rcx
       mov       [rbp+30],rdx
       mov       dword ptr [rbp+38],104
       mov       [rbp+28],ecx
       cmp       edi,[rbp+38]
       ja        near ptr M01_L23
M01_L06:
       mov       edi,r14d
       cmp       edi,esi
       jge       near ptr M01_L12
M01_L07:
       mov       r14,[rbx+rdi*8]
       cmp       dword ptr [r14+8],0
       je        near ptr M01_L11
       mov       r15d,[rbp+28]
       test      r15d,r15d
       je        near ptr M01_L17
       lea       ecx,[r15-1]
       cmp       ecx,[rbp+38]
       jae       near ptr M01_L32
       mov       rdx,[rbp+30]
       movzx     ecx,word ptr [rdx+rcx*2]
       cmp       ecx,5C
       je        short M01_L08
       cmp       ecx,2F
       jne       near ptr M01_L26
M01_L08:
       mov       r14,[rbx+rdi*8]
       test      r14,r14
       je        short M01_L11
       mov       edx,[rbp+28]
       mov       r15d,[r14+8]
       cmp       r15d,1
       je        near ptr M01_L28
M01_L09:
       mov       r13d,[rbp+28]
       mov       edx,[rbp+38]
       sub       edx,r15d
       cmp       edx,r13d
       jl        near ptr M01_L29
M01_L10:
       cmp       r13d,[rbp+38]
       ja        near ptr M01_L31
       mov       r8,[rbp+30]
       mov       edx,r13d
       lea       rcx,[r8+rdx*2]
       mov       r8d,[rbp+38]
       sub       r8d,r13d
       cmp       r15d,r8d
       ja        near ptr M01_L30
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rbp+28]
       mov       [rbp+28],r15d
M01_L11:
       inc       edi
       cmp       edi,esi
       jl        near ptr M01_L07
M01_L12:
       mov       r15d,[rbp+28]
       mov       ecx,r15d
       cmp       ecx,[rbp+38]
       ja        near ptr M01_L31
       mov       rax,[rbp+30]
       mov       [rbp+10],rax
       mov       [rbp+18],ecx
       lea       rcx,[rbp+10]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+20],ymm0
       test      rdx,rdx
       jne       near ptr M01_L20
M01_L13:
       mov       rax,rbx
       mov       r8,60F5788A32D3
       cmp       [rbp+8],r8
       je        short M01_L14
       call      CORINFO_HELP_FAIL_FAST
M01_L14:
       nop
       lea       rsp,[rbp+40]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       mov       r9d,1
       jmp       near ptr M01_L02
M01_L16:
       add       edi,[rdx+8]
       jmp       near ptr M01_L03
M01_L17:
       test      r14,r14
       je        near ptr M01_L11
       mov       edx,r15d
       mov       r13d,[r14+8]
       cmp       r13d,1
       je        near ptr M01_L24
M01_L18:
       mov       edx,[rbp+38]
       sub       edx,r13d
       cmp       edx,r15d
       jl        near ptr M01_L25
M01_L19:
       cmp       r15d,[rbp+38]
       ja        near ptr M01_L31
       mov       r8,[rbp+30]
       mov       edx,r15d
       lea       rcx,[r8+rdx*2]
       mov       r8d,[rbp+38]
       sub       r8d,r15d
       cmp       r13d,r8d
       ja        near ptr M01_L30
       mov       r8d,r13d
       add       r8,r8
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,1D0A1400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBEC2D07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC61E0D0]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4160A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L06
M01_L24:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L18
       cmp       edx,[rbp+38]
       jae       near ptr M01_L32
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L25:
       mov       edx,r13d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4160A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       mov       rcx,[rbp+30]
       mov       edx,[rbp+38]
       cmp       r15d,edx
       jae       short M01_L27
       mov       edx,r15d
       mov       word ptr [rcx+rdx*2],5C
       inc       r15d
       mov       [rbp+28],r15d
       jmp       near ptr M01_L08
M01_L27:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFBEC61E460]
       jmp       near ptr M01_L08
M01_L28:
       cmp       edx,[rbp+38]
       jae       near ptr M01_L09
       cmp       edx,[rbp+38]
       jae       short M01_L32
       mov       rcx,[rbp+30]
       mov       eax,edx
       movzx     r8d,word ptr [r14+0C]
       mov       [rcx+rax*2],r8w
       inc       edx
       mov       [rbp+28],edx
       jmp       near ptr M01_L11
M01_L29:
       mov       edx,r15d
       lea       rcx,[rbp+20]
       call      qword ptr [7FFBEC4160A0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L30:
       call      qword ptr [7FFBEC41D218]
       int       3
M01_L31:
       call      qword ptr [7FFBEC177198]
       int       3
M01_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 977
```
```assembly
; System.IO.Path.GetFullPath(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        short M02_L02
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC22EFB8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFBEC22EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFBEC22F018]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFBEC22F030]; System.IO.PathHelper.Normalize(System.String)
       jmp       short M02_L01
M02_L00:
       mov       rax,rbx
M02_L01:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       rcx,rax
       call      qword ptr [7FFBEC61E0D0]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC61E580]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC61E598]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.HasInvalidFilterCharsValid()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       mov       rax,0A45CCAB5BF56
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rdx,2501A000160
       mov       rsi,[rdx]
       mov       rdi,29098E4076C
       add       rsi,10
       lea       rbp,[rdi+22]
       mov       r14,rdi
       cmp       rdi,rbp
       je        short M00_L01
M00_L00:
       movzx     edx,word ptr [r14]
       movsx     rdx,dx
       mov       rcx,rsi
       mov       r8d,26
       call      qword ptr [7FFBEC25EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       short M00_L04
       add       r14,2
       cmp       r14,rbp
       jne       short M00_L00
M00_L01:
       mov       ecx,0FFFFFFFF
M00_L02:
       cmp       ecx,0FFFFFFFF
       setne     cl
       movzx     ecx,cl
       mov       [rsp+28],cl
       mov       rcx,[rbx+60]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC65E5B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       mov       r8,0A45CCAB5BF56
       cmp       [rsp+38],r8
       je        short M00_L03
       call      CORINFO_HELP_FAIL_FAST
M00_L03:
       nop
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       mov       rcx,r14
       sub       rcx,rdi
       shr       rcx,1
       jmp       short M00_L02
; Total bytes of code 183
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M01_L03
       cmp       r8d,10
       jl        near ptr M01_L09
       vmovd     xmm0,edx
       vpbroadcastw ymm0,xmm0
       lea       edx,[r8-10]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M01_L11
M01_L00:
       add       rcx,20
       cmp       rcx,rax
       jbe       short M01_L02
       mov       r8d,r8d
       test      r8b,0F
       je        short M01_L01
       vpcmpeqw  ymm0,ymm0,[rax]
       vptest    ymm0,ymm0
       jne       near ptr M01_L11
M01_L01:
       xor       eax,eax
       vzeroupper
       ret
M01_L02:
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M01_L11
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       cmp       r8d,8
       jl        near ptr M01_L05
M01_L04:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       add       rax,8
       cmp       r8d,8
       jge       near ptr M01_L04
M01_L05:
       cmp       r8d,4
       jl        short M01_L07
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M01_L11
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M01_L11
       add       rax,4
       jmp       short M01_L07
M01_L06:
       dec       r8d
       movsx     r10,word ptr [rcx+rax]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M01_L11
       add       rax,2
       jmp       short M01_L08
M01_L07:
       add       rax,rax
M01_L08:
       test      r8d,r8d
       jg        short M01_L06
       jmp       near ptr M01_L01
M01_L09:
       vmovd     xmm0,edx
       vpbroadcastw xmm0,xmm0
       lea       edx,[r8-8]
       mov       eax,edx
       lea       rax,[rcx+rax*2]
M01_L10:
       vpcmpeqw  xmm1,xmm0,[rcx]
       vptest    xmm1,xmm1
       jne       short M01_L11
       add       rcx,10
       cmp       rcx,rax
       jbe       short M01_L10
       mov       r8d,r8d
       test      r8b,7
       je        near ptr M01_L01
       vpcmpeqw  xmm0,xmm0,[rax]
       vptest    xmm0,xmm0
       je        near ptr M01_L01
M01_L11:
       mov       eax,1
       vzeroupper
       ret
; Total bytes of code 486
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathContainsWildcardNoWildcard()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+148]
       test      rsi,rsi
       je        near ptr M00_L03
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L03
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L05
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L01:
       lea       rdi,[rsi+0C]
       mov       rcx,rdi
       mov       esi,[rsi+8]
       mov       r8d,esi
       mov       edx,2A
       call      qword ptr [7FFBEC197798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       eax,0FFFFFFFF
       jne       near ptr M00_L08
       mov       rcx,rdi
       mov       r8d,esi
       mov       edx,3F
       call      qword ptr [7FFBEC197798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
M00_L02:
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      qword ptr [7FFBEC434420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBEC6E5998]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27D595C7DF8
       call      qword ptr [7FFBEC6E4BD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFBEC6E46A8]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFBEC6E46A8]
       test      eax,eax
       je        near ptr M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBEC6E46C0]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       eax,1
       jmp       near ptr M00_L02
; Total bytes of code 321
```
```assembly
; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        near ptr M01_L04
       mov       rax,rcx
       cmp       r8d,10
       jle       near ptr M01_L16
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       cmp       r8d,20
       jle       short M01_L01
       lea       edx,[r8-20]
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       vmovups   ymm1,[rcx]
       vpackuswb ymm1,ymm1,[rcx+20]
       vpcmpeqb  ymm1,ymm1,ymm0
       vptest    ymm1,ymm1
       jne       near ptr M01_L13
M01_L00:
       add       rax,40
       cmp       rax,rdx
       jb        near ptr M01_L12
M01_L01:
       add       r8d,0FFFFFFF0
       movsxd    rdx,r8d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rdx]
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M01_L14
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       vzeroupper
       ret
M01_L04:
       xor       r10d,r10d
       cmp       r8d,4
       jl        short M01_L10
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     rax,dx
       cmp       r10d,eax
       jne       short M01_L05
       xor       eax,eax
       vzeroupper
       ret
M01_L05:
       movsx     rax,word ptr [rcx+2]
       movsx     r10,dx
       cmp       eax,r10d
       jne       short M01_L06
       mov       eax,1
       vzeroupper
       ret
M01_L06:
       movsx     rax,word ptr [rcx+4]
       movsx     r10,dx
       cmp       eax,r10d
       jne       short M01_L07
       mov       eax,2
       vzeroupper
       ret
M01_L07:
       movsx     rax,word ptr [rcx+6]
       movsx     r10,dx
       cmp       eax,r10d
       jne       short M01_L08
       mov       eax,3
       jmp       short M01_L03
M01_L08:
       mov       r10d,4
       test      r8d,r8d
       jle       short M01_L02
M01_L09:
       dec       r8d
       movsx     rax,word ptr [rcx+r10*2]
       movsx     r9,dx
       cmp       eax,r9d
       je        short M01_L11
       inc       r10
M01_L10:
       test      r8d,r8d
       jg        short M01_L09
       jmp       near ptr M01_L02
M01_L11:
       mov       eax,r10d
       jmp       near ptr M01_L03
M01_L12:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpcmpeqb  ymm1,ymm1,ymm0
       vptest    ymm1,ymm1
       je        near ptr M01_L00
M01_L13:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r8d,ymm0
       xor       ecx,ecx
       tzcnt     ecx,r8d
       add       eax,ecx
       jmp       near ptr M01_L03
M01_L14:
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M01_L15
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M01_L15:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M01_L03
M01_L16:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       lea       eax,[r8-8]
       movsxd    r8,eax
       lea       rax,[rcx+r8*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm1,[rdx]
       vpackuswb xmm1,xmm1,[rax]
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M01_L02
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M01_L17
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M01_L17:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       near ptr M01_L03
; Total bytes of code 470
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathHasInvalidCharsValid()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rax,7096F1D99A7A
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       rsi,[rbx+148]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L12
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L14
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L15
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L01:
       mov       r8,1D750800140
       mov       r8,[r8]
       cmp       [rsi],sil
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       add       r8,10
       mov       edx,esi
       mov       rbp,r8
       cmp       edx,8
       jl        near ptr M00_L07
       cmp       edx,14
       jl        near ptr M00_L06
M00_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       xor       ecx,ecx
       mov       eax,21
       nop       dword ptr [rax]
M00_L03:
       movzx     r10d,word ptr [r8+rcx]
       cmp       r10d,7F
       jg        near ptr M00_L18
       mov       r9d,r10d
       sar       r9d,4
       lea       r11,[rsp+20]
       and       r10d,0F
       add       r10,r11
       mov       r11d,1
       shlx      r9d,r11d,r9d
       movzx     r9d,r9b
       or        [r10],r9b
       add       rcx,2
       dec       eax
       jne       short M00_L03
       movzx     r8d,byte ptr [rsp+20]
       and       r8d,1
       vmovdqu   xmm0,xmmword ptr [rsp+20]
       vmovaps   ymm1,ymm0
       vinserti128 ymm0,ymm1,xmm0,1
       vmovups   [rsp+20],ymm0
       test      r8b,1
       jne       near ptr M00_L11
       lea       r8,[rsp+20]
       mov       rcx,rdi
       call      qword ptr [7FFBEC167270]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L04:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,7096F1D99A7A
       cmp       [rsp+68],r8
       je        short M00_L05
       call      CORINFO_HELP_FAIL_FAST
M00_L05:
       nop
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,10
       jge       near ptr M00_L02
M00_L07:
       mov       edx,esi
       lea       rsi,[rdi+rdx*2]
       mov       r14,rdi
       cmp       rdi,rsi
       je        short M00_L09
M00_L08:
       movzx     edx,word ptr [r14]
       movsx     rdx,dx
       mov       rcx,rbp
       mov       r8d,21
       call      qword ptr [7FFBEC21EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L17
       add       r14,2
       cmp       r14,rsi
       jne       short M00_L08
M00_L09:
       mov       eax,0FFFFFFFF
M00_L10:
       jmp       short M00_L04
M00_L11:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       call      qword ptr [7FFBEC5FDC98]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       near ptr M00_L04
M00_L12:
       call      qword ptr [7FFBEC404420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FFBEC6E6280]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,217CF867DF8
       call      qword ptr [7FFBEC6E53F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FFBEC6E4B10]
       test      eax,eax
       jne       short M00_L16
       jmp       near ptr M00_L00
M00_L15:
       call      qword ptr [7FFBEC6E4B10]
       test      eax,eax
       je        near ptr M00_L01
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBEC6E4B28]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L17:
       mov       rax,r14
       sub       rax,rdi
       shr       rax,1
       jmp       near ptr M00_L10
M00_L18:
       mov       rcx,rdi
       mov       r9d,21
       call      qword ptr [7FFBEC6E5368]
       jmp       near ptr M00_L04
; Total bytes of code 639
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       push      rbp
       sub       rsp,3B0
       lea       rbp,[rsp+3B0]
       xor       eax,eax
       mov       [rbp-1D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       dword ptr [rbp-238],3E8
       mov       rax,[rbp+10]
       mov       [rbp-40],rax
       cmp       dword ptr [rbp+18],8
       jge       near ptr M01_L05
       movsxd    rax,dword ptr [rbp+18]
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-58],rax
       jmp       short M01_L03
M01_L01:
       mov       rax,[rbp-40]
       movzx     eax,word ptr [rax]
       mov       [rbp-5C],eax
       mov       rax,[rbp+20]
       cmp       [rax],al
       mov       rax,[rbp+20]
       lea       rcx,[rax+20]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFBEC1674C8]
       mov       ecx,eax
       call      qword ptr [7FFBEC1674E0]
       test      eax,eax
       je        short M01_L02
       mov       rcx,7FFBEC1C73B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBEC1674F8]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,7FFBEC1C73B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       add       rax,2
       mov       [rbp-40],rax
M01_L03:
       mov       eax,[rbp-238]
       dec       eax
       mov       [rbp-238],eax
       cmp       dword ptr [rbp-238],0
       jg        short M01_L04
       lea       rcx,[rbp-238]
       mov       edx,47
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       rax,[rbp-40]
       cmp       rax,[rbp-58]
       jne       near ptr M01_L01
       mov       rcx,7FFBEC1C73B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC167510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L05:
       cmp       dword ptr [rbp+18],10
       jle       near ptr M01_L08
       mov       rax,[rbp+20]
       vmovups   ymm0,[rax]
       vmovups   [rbp-90],ymm0
       cmp       dword ptr [rbp+18],20
       jle       near ptr M01_L10
       mov       eax,[rbp+18]
       add       eax,0FFFFFFE0
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-98],rax
M01_L06:
       mov       eax,[rbp-238]
       dec       eax
       mov       [rbp-238],eax
       cmp       dword ptr [rbp-238],0
       jg        short M01_L07
       lea       rcx,[rbp-238]
       mov       edx,96
       call      CORINFO_HELP_PATCHPOINT
M01_L07:
       mov       rax,[rbp-40]
       vmovups   ymm0,[rax]
       vmovups   [rbp-230],ymm0
       mov       rax,[rbp-40]
       vmovups   ymm0,[rax+20]
       vmovups   [rbp-0D0],ymm0
       vmovups   ymm0,[rbp-230]
       vmovups   [rbp-270],ymm0
       vmovups   ymm0,[rbp-0D0]
       vmovups   [rbp-290],ymm0
       vmovups   ymm0,[rbp-90]
       vmovups   [rbp-2B0],ymm0
       lea       rdx,[rbp-270]
       lea       r8,[rbp-290]
       lea       r9,[rbp-2B0]
       lea       rcx,[rbp-0F0]
       call      qword ptr [7FFBEC1673C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M01_L09
       mov       rcx,7FFBEC1C73BC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC167480]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L08:
       mov       rcx,7FFBEC1C73C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L15
M01_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M01_L11
       mov       rcx,7FFBEC1C73C4
       call      CORINFO_HELP_COUNTPROFILE32
M01_L10:
       mov       eax,[rbp+18]
       add       eax,0FFFFFFF0
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-0F8]
       ja        short M01_L12
       mov       rax,[rbp-40]
       mov       [rbp-1D8],rax
       jmp       short M01_L13
M01_L11:
       mov       rcx,7FFBEC1C73C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L06
M01_L12:
       mov       rcx,7FFBEC1C73CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0F8]
       mov       [rbp-1D8],rax
M01_L13:
       mov       rax,[rbp-1D8]
       mov       [rbp-100],rax
       mov       rax,[rbp-100]
       vmovups   ymm0,[rax]
       vmovups   [rbp-210],ymm0
       mov       rax,[rbp-0F8]
       vmovups   ymm0,[rax]
       vmovups   [rbp-130],ymm0
       vmovups   ymm0,[rbp-210]
       vmovups   [rbp-2F0],ymm0
       vmovups   ymm0,[rbp-130]
       vmovups   [rbp-310],ymm0
       vmovups   ymm0,[rbp-90]
       vmovups   [rbp-330],ymm0
       lea       rdx,[rbp-2F0]
       lea       r8,[rbp-310]
       lea       r9,[rbp-330]
       lea       rcx,[rbp-150]
       call      qword ptr [7FFBEC1673C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M01_L14
       mov       rcx,7FFBEC1C73D0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC167408]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L14:
       mov       rcx,7FFBEC1C73D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC167510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L15:
       mov       rax,[rbp+20]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-50],xmm0
       mov       eax,[rbp+18]
       add       eax,0FFFFFFF8
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-188],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-188]
       ja        short M01_L16
       mov       rax,[rbp-40]
       mov       [rbp-1B8],rax
       jmp       short M01_L17
M01_L16:
       mov       rcx,7FFBEC1C73D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-188]
       mov       [rbp-1B8],rax
M01_L17:
       mov       rax,[rbp-1B8]
       mov       [rbp-190],rax
       mov       rax,[rbp-190]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-1D0],xmm0
       mov       rax,[rbp-188]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-1A0],xmm0
       vmovaps   xmm0,[rbp-1D0]
       vmovaps   [rbp-360],xmm0
       vmovaps   xmm0,[rbp-1A0]
       vmovaps   [rbp-370],xmm0
       vmovaps   xmm0,[rbp-50]
       vmovaps   [rbp-380],xmm0
       lea       rdx,[rbp-360]
       lea       r8,[rbp-370]
       lea       r9,[rbp-380]
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC167330]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M01_L18
       mov       rcx,7FFBEC1C73DC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC167378]
       mov       [rbp-23C],eax
       jmp       short M01_L19
M01_L18:
       mov       rcx,7FFBEC1C73E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC167510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
M01_L19:
       mov       eax,[rbp-23C]
       vzeroupper
       add       rsp,3B0
       pop       rbp
       ret
; Total bytes of code 1398
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M02_L02
       movsx     rdx,dx
       movd      xmm0,edx
       punpcklwd xmm0,xmm0
       pshufd    xmm0,xmm0,0
       lea       eax,[r8-8]
       lea       rax,[rcx+rax*2]
       movups    xmm1,[rcx]
       pcmpeqw   xmm1,xmm0
       ptest     xmm1,xmm1
       jne       short M02_L04
M02_L00:
       add       rcx,10
       cmp       rcx,rax
       jbe       near ptr M02_L09
       mov       r8d,r8d
       test      r8b,7
       je        short M02_L01
       movups    xmm1,[rax]
       pcmpeqw   xmm0,xmm1
       ptest     xmm0,xmm0
       jne       short M02_L04
M02_L01:
       xor       eax,eax
       ret
M02_L02:
       xor       eax,eax
       cmp       r8d,8
       jge       short M02_L07
M02_L03:
       cmp       r8d,4
       jl        short M02_L05
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       jne       near ptr M02_L08
M02_L04:
       mov       eax,1
       ret
M02_L05:
       test      r8d,r8d
       jle       short M02_L01
       add       rax,rax
M02_L06:
       dec       r8d
       movsx     r10,word ptr [rcx+rax]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       add       rax,2
       test      r8d,r8d
       jg        short M02_L06
       jmp       short M02_L01
M02_L07:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L04
       movsx     r10,word ptr [rcx+rax*2+0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L04
       movsx     r10,word ptr [rcx+rax*2+0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L04
       add       rax,8
       cmp       r8d,8
       jge       near ptr M02_L07
       jmp       near ptr M02_L03
M02_L08:
       add       rax,4
       jmp       near ptr M02_L05
M02_L09:
       movups    xmm1,[rcx]
       pcmpeqw   xmm1,xmm0
       ptest     xmm1,xmm1
       jne       near ptr M02_L04
       jmp       near ptr M02_L00
; Total bytes of code 393
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jl        near ptr M03_L03
       cmp       edx,10
       jle       near ptr M03_L10
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M03_L01
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
       vbroadcastss ymm1,dword ptr [7FFBEC0A0DE0]
       vbroadcastss ymm2,dword ptr [7FFBEC0A0DE4]
       vbroadcastsd ymm3,qword ptr [7FFBEC0A0DE8]
M03_L00:
       vpminuw   ymm4,ymm1,[rax]
       vpminuw   ymm5,ymm1,[rax+20]
       vpackuswb ymm4,ymm4,ymm5
       vpshufb   ymm5,ymm0,ymm4
       vpsrld    ymm4,ymm4,4
       vpand     ymm4,ymm4,ymm2
       vpshufb   ymm4,ymm3,ymm4
       vpand     ymm4,ymm4,ymm5
       vptest    ymm4,ymm4
       jne       near ptr M03_L07
       add       rax,40
       cmp       rax,r8
       jb        short M03_L00
M03_L01:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vbroadcastss ymm1,dword ptr [7FFBEC0A0DE0]
       vpminuw   ymm3,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm3,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm2,dword ptr [7FFBEC0A0DE4]
       vpand     ymm1,ymm1,ymm2
       vbroadcastsd ymm3,qword ptr [7FFBEC0A0DE8]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       short M03_L08
M03_L02:
       mov       eax,0FFFFFFFF
       vzeroupper
       ret
M03_L03:
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       cmp       rcx,rdx
       je        short M03_L02
M03_L04:
       movzx     r10d,word ptr [rax]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       short M03_L05
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jb        short M03_L06
M03_L05:
       add       rax,2
       cmp       rax,rdx
       jne       short M03_L04
       jmp       short M03_L02
M03_L06:
       sub       rax,rcx
       shr       rax,1
       jmp       near ptr M03_L12
M03_L07:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm1,ymm4,0D8
       vxorps    ymm0,ymm0,ymm0
       vpcmpeqb  ymm2,ymm0,ymm1
       vpmovmskb edx,ymm2
       mov       ecx,edx
       not       ecx
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       near ptr M03_L12
M03_L08:
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r8d,ymm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M03_L09
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M03_L09:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M03_L12
M03_L10:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*2]
       cmp       rcx,rax
       mov       r8,rcx
       cmova     r8,rax
       vmovups   xmm1,[r8]
       vpminuw   xmm1,xmm1,[7FFBEC0A0DF0]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FFBEC0A0DF0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFBEC0A0E00]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFBEC0A0DE8]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M03_L02
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb edx,xmm0
       not       edx
       tzcnt     edx,edx
       cmp       edx,8
       jl        short M03_L11
       mov       r8,rax
       add       edx,0FFFFFFF8
M03_L11:
       sub       r8,rcx
       shr       r8,1
       lea       eax,[r8+rdx]
M03_L12:
       vzeroupper
       ret
; Total bytes of code 532
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathSeparators()
       push      rbx
       sub       rsp,10
       mov       rdx,25C9B000170
       mov       rdx,[rdx]
       mov       [rsp+8],rdx
       mov       rbx,[rcx+60]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 53
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.EnsureTrailingSlash()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+2C],eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rsi,[rbx+148]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L04
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L01:
       mov       rax,rsi
       mov       edi,[rax+8]
       mov       ebp,edi
       cmp       word ptr [rax+rbp*2+0A],5C
       je        short M00_L03
       add       rsi,0C
       mov       dword ptr [rsp+2C],5C
       mov       edx,edi
       add       edx,1
       jo        near ptr M00_L11
       test      edx,edx
       je        near ptr M00_L09
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       edi,r13d
       ja        near ptr M00_L10
       lea       r8,[rbp+rbp]
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFBEC005818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rax,[r15+rbp*2]
       sub       r13d,edi
       je        near ptr M00_L10
       lea       rcx,[rsp+2C]
       movzx     edx,word ptr [rcx]
       mov       [rax],dx
M00_L02:
       mov       rax,r14
M00_L03:
       mov       [rsp+20],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L04:
       call      qword ptr [7FFBEC414420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFBEC6C5878]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,228B40D7DF8
       call      qword ptr [7FFBEC6C4A68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFBEC6C4678]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFBEC6C4678]
       test      eax,eax
       je        near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBEC6C4690]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       r14,228B40D0008
       jmp       near ptr M00_L02
M00_L10:
       call      qword ptr [7FFBEC41D218]
       int       3
M00_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 456
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M01_L04
       cmp       r8,40
       jbe       near ptr M01_L05
       cmp       r8,800
       ja        near ptr M01_L10
       cmp       r8,100
       jae       near ptr M01_L08
M01_L00:
       mov       r9,r8
       shr       r9,6
M01_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L01
       and       r8,3F
       cmp       r8,10
       ja        short M01_L05
M01_L02:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L03:
       vzeroupper
       ret
M01_L04:
       test      r8b,18
       jne       short M01_L06
       test      r8b,4
       jne       short M01_L07
       test      r8,r8
       je        short M01_L03
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L03
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M01_L03
M01_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L02
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L02
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L02
M01_L06:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L03
M01_L07:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L03
M01_L08:
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
       jmp       near ptr M01_L00
M01_L09:
       cmp       rcx,rdx
       jne       short M01_L10
       cmp       [rdx],dl
       jmp       near ptr M01_L03
M01_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBEC0066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 325
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.HasInvalidFilterChars()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rax,0A5CA1B812FDD
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       xor       ecx,ecx
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.String
       mov       edx,1
       call      00007FFC4BCA9D30
       mov       rdi,rax
       mov       word ptr [rdi+0C],5C
       test      rsi,rsi
       je        near ptr M00_L13
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L13
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L14
       mov       r15d,ebp
       lea       edx,[r14+r15]
       test      edx,edx
       jl        near ptr M00_L15
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC4BCA9D30
       mov       r13,rax
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r15d
       lea       rcx,[r13+rcx*2+0C]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBEBFF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       esi,[r13+8]
       test      esi,esi
       je        near ptr M00_L16
       movzx     ecx,word ptr [r13+0C]
       cmp       ecx,100
       jge       near ptr M00_L18
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r13+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L19
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L02:
       mov       r8,2826A000160
       mov       r8,[r8]
       cmp       [r13],r13b
       lea       rsi,[r13+0C]
       mov       edi,[r13+8]
       add       r8,10
       mov       edx,edi
       mov       rbp,r8
       cmp       edx,8
       jl        near ptr M00_L08
       cmp       edx,14
       jl        near ptr M00_L07
M00_L03:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       xor       ecx,ecx
       mov       eax,26
M00_L04:
       movzx     r10d,word ptr [r8+rcx]
       cmp       r10d,7F
       jg        near ptr M00_L22
       mov       r9d,r10d
       sar       r9d,4
       lea       r11,[rsp+20]
       and       r10d,0F
       add       r10,r11
       mov       r11d,1
       shlx      r9d,r11d,r9d
       movzx     r9d,r9b
       or        [r10],r9b
       add       rcx,2
       dec       eax
       jne       short M00_L04
       movzx     r8d,byte ptr [rsp+20]
       and       r8d,1
       vmovdqu   xmm0,xmmword ptr [rsp+20]
       vmovaps   ymm1,ymm0
       vinserti128 ymm0,ymm1,xmm0,1
       vmovups   [rsp+20],ymm0
       test      r8b,1
       jne       near ptr M00_L12
       lea       r8,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FFBEC167270]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L05:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,0A5CA1B812FDD
       cmp       [rsp+68],r8
       je        short M00_L06
       call      CORINFO_HELP_FAIL_FAST
M00_L06:
       nop
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L07:
       cmp       edx,13
       jge       near ptr M00_L03
M00_L08:
       mov       edx,edi
       lea       rdi,[rsi+rdx*2]
       mov       r14,rsi
       cmp       rsi,rdi
       je        short M00_L10
M00_L09:
       movzx     edx,word ptr [r14]
       movsx     rdx,dx
       mov       rcx,rbp
       mov       r8d,26
       call      qword ptr [7FFBEC21EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L21
       add       r14,2
       cmp       r14,rdi
       jne       short M00_L09
M00_L10:
       mov       eax,0FFFFFFFF
M00_L11:
       jmp       short M00_L05
M00_L12:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FFBEC61E550]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       near ptr M00_L05
M00_L13:
       mov       r14d,[rdi+8]
       mov       rcx,2C2E8EF0008
       test      r14d,r14d
       mov       r13,rcx
       cmovne    r13,rdi
       jmp       near ptr M00_L00
M00_L14:
       mov       r13,rsi
       jmp       near ptr M00_L00
M00_L15:
       call      qword ptr [7FFBEC6D52F0]
       int       3
M00_L16:
       call      qword ptr [7FFBEC404420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L17
       call      qword ptr [7FFBEC6D6B50]
       mov       rbx,rax
M00_L17:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C2E8F00760
       call      qword ptr [7FFBEC6D5E78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       call      qword ptr [7FFBEC6D5608]
       test      eax,eax
       jne       short M00_L20
       jmp       near ptr M00_L01
M00_L19:
       call      qword ptr [7FFBEC6D5608]
       test      eax,eax
       je        near ptr M00_L02
M00_L20:
       mov       rcx,r13
       mov       edx,3
       call      qword ptr [7FFBEC6D5620]
       mov       r13,rax
       jmp       near ptr M00_L02
M00_L21:
       mov       rax,r14
       sub       rax,rsi
       shr       rax,1
       jmp       near ptr M00_L11
M00_L22:
       mov       rcx,rsi
       mov       r9d,26
       call      qword ptr [7FFBEC6D5D70]
       jmp       near ptr M00_L05
; Total bytes of code 836
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L08
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L08
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M01_L01
       test      r8b,18
       jne       near ptr M01_L06
       test      r8b,4
       jne       near ptr M01_L07
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
M01_L00:
       vzeroupper
       ret
M01_L01:
       cmp       r8,40
       jbe       short M01_L04
       nop       dword ptr [rax]
       cmp       r8,800
       ja        near ptr M01_L09
       cmp       r8,100
       jb        short M01_L02
       mov       r9,rcx
       and       r9,3F
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rdx,r9
       add       rcx,r9
       sub       r8,r9
M01_L02:
       mov       r9,r8
       shr       r9,6
       xchg      ax,ax
M01_L03:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L03
       and       r8,3F
       cmp       r8,10
       jbe       short M01_L05
M01_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L05
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M01_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M01_L00
M01_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M01_L00
M01_L07:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M01_L00
M01_L08:
       cmp       rcx,rdx
       jne       short M01_L09
       cmp       [rdx],dl
       jmp       near ptr M01_L00
M01_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBEBFF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 333
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       push      rbp
       sub       rsp,3B0
       lea       rbp,[rsp+3B0]
       xor       eax,eax
       mov       [rbp-1D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       dword ptr [rbp-238],3E8
       mov       rax,[rbp+10]
       mov       [rbp-40],rax
       cmp       dword ptr [rbp+18],8
       jge       near ptr M02_L05
       movsxd    rax,dword ptr [rbp+18]
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-58],rax
       jmp       short M02_L03
M02_L01:
       mov       rax,[rbp-40]
       movzx     eax,word ptr [rax]
       mov       [rbp-5C],eax
       mov       rax,[rbp+20]
       cmp       [rax],al
       mov       rax,[rbp+20]
       lea       rcx,[rax+20]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFBEC1674C8]
       mov       ecx,eax
       call      qword ptr [7FFBEC1674E0]
       test      eax,eax
       je        short M02_L02
       mov       rcx,7FFBEC1C73B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBEC1674F8]
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L02:
       mov       rcx,7FFBEC1C73B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       add       rax,2
       mov       [rbp-40],rax
M02_L03:
       mov       eax,[rbp-238]
       dec       eax
       mov       [rbp-238],eax
       cmp       dword ptr [rbp-238],0
       jg        short M02_L04
       lea       rcx,[rbp-238]
       mov       edx,47
       call      CORINFO_HELP_PATCHPOINT
M02_L04:
       mov       rax,[rbp-40]
       cmp       rax,[rbp-58]
       jne       near ptr M02_L01
       mov       rcx,7FFBEC1C73B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC167510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L05:
       cmp       dword ptr [rbp+18],10
       jle       near ptr M02_L08
       mov       rax,[rbp+20]
       vmovups   ymm0,[rax]
       vmovups   [rbp-90],ymm0
       cmp       dword ptr [rbp+18],20
       jle       near ptr M02_L10
       mov       eax,[rbp+18]
       add       eax,0FFFFFFE0
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-98],rax
M02_L06:
       mov       eax,[rbp-238]
       dec       eax
       mov       [rbp-238],eax
       cmp       dword ptr [rbp-238],0
       jg        short M02_L07
       lea       rcx,[rbp-238]
       mov       edx,96
       call      CORINFO_HELP_PATCHPOINT
M02_L07:
       mov       rax,[rbp-40]
       vmovups   ymm0,[rax]
       vmovups   [rbp-230],ymm0
       mov       rax,[rbp-40]
       vmovups   ymm0,[rax+20]
       vmovups   [rbp-0D0],ymm0
       vmovups   ymm0,[rbp-230]
       vmovups   [rbp-270],ymm0
       vmovups   ymm0,[rbp-0D0]
       vmovups   [rbp-290],ymm0
       vmovups   ymm0,[rbp-90]
       vmovups   [rbp-2B0],ymm0
       lea       rdx,[rbp-270]
       lea       r8,[rbp-290]
       lea       r9,[rbp-2B0]
       lea       rcx,[rbp-0F0]
       call      qword ptr [7FFBEC1673C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M02_L09
       mov       rcx,7FFBEC1C73BC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC167480]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L08:
       mov       rcx,7FFBEC1C73C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L15
M02_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M02_L11
       mov       rcx,7FFBEC1C73C4
       call      CORINFO_HELP_COUNTPROFILE32
M02_L10:
       mov       eax,[rbp+18]
       add       eax,0FFFFFFF0
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-0F8]
       ja        short M02_L12
       mov       rax,[rbp-40]
       mov       [rbp-1D8],rax
       jmp       short M02_L13
M02_L11:
       mov       rcx,7FFBEC1C73C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L06
M02_L12:
       mov       rcx,7FFBEC1C73CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0F8]
       mov       [rbp-1D8],rax
M02_L13:
       mov       rax,[rbp-1D8]
       mov       [rbp-100],rax
       mov       rax,[rbp-100]
       vmovups   ymm0,[rax]
       vmovups   [rbp-210],ymm0
       mov       rax,[rbp-0F8]
       vmovups   ymm0,[rax]
       vmovups   [rbp-130],ymm0
       vmovups   ymm0,[rbp-210]
       vmovups   [rbp-2F0],ymm0
       vmovups   ymm0,[rbp-130]
       vmovups   [rbp-310],ymm0
       vmovups   ymm0,[rbp-90]
       vmovups   [rbp-330],ymm0
       lea       rdx,[rbp-2F0]
       lea       r8,[rbp-310]
       lea       r9,[rbp-330]
       lea       rcx,[rbp-150]
       call      qword ptr [7FFBEC1673C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M02_L14
       mov       rcx,7FFBEC1C73D0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC167408]
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L14:
       mov       rcx,7FFBEC1C73D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC167510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L15:
       mov       rax,[rbp+20]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-50],xmm0
       mov       eax,[rbp+18]
       add       eax,0FFFFFFF8
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-188],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-188]
       ja        short M02_L16
       mov       rax,[rbp-40]
       mov       [rbp-1B8],rax
       jmp       short M02_L17
M02_L16:
       mov       rcx,7FFBEC1C73D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-188]
       mov       [rbp-1B8],rax
M02_L17:
       mov       rax,[rbp-1B8]
       mov       [rbp-190],rax
       mov       rax,[rbp-190]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-1D0],xmm0
       mov       rax,[rbp-188]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-1A0],xmm0
       vmovaps   xmm0,[rbp-1D0]
       vmovaps   [rbp-360],xmm0
       vmovaps   xmm0,[rbp-1A0]
       vmovaps   [rbp-370],xmm0
       vmovaps   xmm0,[rbp-50]
       vmovaps   [rbp-380],xmm0
       lea       rdx,[rbp-360]
       lea       r8,[rbp-370]
       lea       r9,[rbp-380]
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC167330]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M02_L18
       mov       rcx,7FFBEC1C73DC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC167378]
       mov       [rbp-23C],eax
       jmp       short M02_L19
M02_L18:
       mov       rcx,7FFBEC1C73E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC167510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
M02_L19:
       mov       eax,[rbp-23C]
       vzeroupper
       add       rsp,3B0
       pop       rbp
       ret
; Total bytes of code 1398
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M03_L02
       movsx     rdx,dx
       movd      xmm0,edx
       punpcklwd xmm0,xmm0
       pshufd    xmm0,xmm0,0
       lea       eax,[r8-8]
       lea       rax,[rcx+rax*2]
       movups    xmm1,[rcx]
       pcmpeqw   xmm1,xmm0
       ptest     xmm1,xmm1
       jne       short M03_L04
M03_L00:
       add       rcx,10
       cmp       rcx,rax
       jbe       near ptr M03_L09
       mov       r8d,r8d
       test      r8b,7
       je        short M03_L01
       movups    xmm1,[rax]
       pcmpeqw   xmm0,xmm1
       ptest     xmm0,xmm0
       jne       short M03_L04
M03_L01:
       xor       eax,eax
       ret
M03_L02:
       xor       eax,eax
       cmp       r8d,8
       jge       short M03_L07
M03_L03:
       cmp       r8d,4
       jl        short M03_L05
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       jne       near ptr M03_L08
M03_L04:
       mov       eax,1
       ret
M03_L05:
       test      r8d,r8d
       jle       short M03_L01
       add       rax,rax
M03_L06:
       dec       r8d
       movsx     r10,word ptr [rcx+rax]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       add       rax,2
       test      r8d,r8d
       jg        short M03_L06
       jmp       short M03_L01
M03_L07:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M03_L04
       movsx     r10,word ptr [rcx+rax*2+0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L04
       movsx     r10,word ptr [rcx+rax*2+0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L04
       movsx     r10,word ptr [rcx+rax*2+0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M03_L04
       add       rax,8
       cmp       r8d,8
       jge       near ptr M03_L07
       jmp       near ptr M03_L03
M03_L08:
       add       rax,4
       jmp       near ptr M03_L05
M03_L09:
       movups    xmm1,[rcx]
       pcmpeqw   xmm1,xmm0
       ptest     xmm1,xmm1
       jne       near ptr M03_L04
       jmp       near ptr M03_L00
; Total bytes of code 393
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jl        near ptr M04_L03
       cmp       edx,10
       jle       near ptr M04_L09
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       near ptr M04_L07
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
       vbroadcastss ymm1,dword ptr [7FFBEC0AA0B0]
       vbroadcastss ymm2,dword ptr [7FFBEC0AA0B4]
       vbroadcastsd ymm3,qword ptr [7FFBEC0AA0B8]
       nop       dword ptr [rax]
M04_L00:
       vpminuw   ymm4,ymm1,[rax]
       vpminuw   ymm5,ymm1,[rax+20]
       vpackuswb ymm4,ymm4,ymm5
       vpshufb   ymm5,ymm0,ymm4
       vpsrld    ymm4,ymm4,4
       vpand     ymm4,ymm4,ymm2
       vpshufb   ymm4,ymm3,ymm4
       vpand     ymm4,ymm4,ymm5
       vptest    ymm4,ymm4
       jne       short M04_L01
       add       rax,40
       cmp       rax,r8
       jb        short M04_L00
       jmp       short M04_L07
M04_L01:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm1,ymm4,0D8
       vxorps    ymm0,ymm0,ymm0
       vpcmpeqb  ymm2,ymm0,ymm1
       vpmovmskb edx,ymm2
       mov       ecx,edx
       not       ecx
       tzcnt     ecx,ecx
       add       eax,ecx
M04_L02:
       vzeroupper
       ret
M04_L03:
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       cmp       rax,rdx
       je        near ptr M04_L11
M04_L04:
       movzx     r10d,word ptr [rax]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       short M04_L05
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       setb      r10b
       movzx     r10d,r10b
       test      r10d,r10d
       jne       short M04_L06
M04_L05:
       add       rax,2
       cmp       rax,rdx
       jne       short M04_L04
       jmp       near ptr M04_L11
M04_L06:
       sub       rax,rcx
       shr       rax,1
       jmp       short M04_L02
M04_L07:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vbroadcastss ymm1,dword ptr [7FFBEC0AA0B0]
       vpminuw   ymm3,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm3,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm2,dword ptr [7FFBEC0AA0B4]
       vpand     ymm1,ymm1,ymm2
       vbroadcastsd ymm3,qword ptr [7FFBEC0AA0B8]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M04_L11
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r8d,ymm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M04_L08
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M04_L08:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M04_L02
M04_L09:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*2]
       cmp       rcx,rax
       mov       r8,rcx
       cmova     r8,rax
       vmovups   xmm1,[r8]
       vpminuw   xmm1,xmm1,[7FFBEC0AA0C0]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FFBEC0AA0C0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFBEC0AA0D0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFBEC0AA0B8]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M04_L11
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb edx,xmm0
       not       edx
       tzcnt     edx,edx
       cmp       edx,8
       jl        short M04_L10
       mov       r8,rax
       add       edx,0FFFFFFF8
M04_L10:
       sub       r8,rcx
       shr       r8,1
       lea       eax,[r8+rdx]
       jmp       near ptr M04_L02
M04_L11:
       mov       eax,0FFFFFFFF
       vzeroupper
       ret
; Total bytes of code 556
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.InvalidFilterChars()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Char>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,20305800138
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
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
; Total bytes of code 92
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.InvalidPathNameChars()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Char>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1A264C00168
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
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
; Total bytes of code 92
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathContainsWildcard()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+140]
       test      rsi,rsi
       je        near ptr M00_L03
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L03
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L05
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,2A
       call      qword ptr [7FFBEC177798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       eax,0FFFFFFFF
       je        near ptr M00_L08
       mov       edi,1
M00_L02:
       mov       rax,[rbx+60]
       mov       [rax+4C],dil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       call      qword ptr [7FFBEC414420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FFBEC6C59F8]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,252A9987DF8
       call      qword ptr [7FFBEC6C4D08]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFBEC6C4720]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FFBEC6C4720]
       test      eax,eax
       je        near ptr M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBEC6C4738]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3F
       mov       r8d,4
       call      qword ptr [7FFBEC62D818]; System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     dil
       movzx     edi,dil
       jmp       near ptr M00_L02
; Total bytes of code 322
```
```assembly
; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        near ptr M01_L05
       mov       rax,rcx
       cmp       r8d,10
       jle       near ptr M01_L15
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       cmp       r8d,20
       jle       short M01_L01
       lea       edx,[r8-20]
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       vmovups   ymm1,[rcx]
       vpackuswb ymm1,ymm1,[rcx+20]
       vpcmpeqb  ymm1,ymm1,ymm0
       vptest    ymm1,ymm1
       jne       near ptr M01_L14
M01_L00:
       add       rax,40
       cmp       rax,rdx
       jae       short M01_L01
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpcmpeqb  ymm1,ymm1,ymm0
       vptest    ymm1,ymm1
       je        short M01_L00
       jmp       near ptr M01_L14
M01_L01:
       add       r8d,0FFFFFFF0
       movsxd    rdx,r8d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rdx]
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M01_L13
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jge       short M01_L04
M01_L02:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
M01_L03:
       vzeroupper
       ret
M01_L04:
       mov       rax,rdx
       add       r8d,0FFFFFFF0
       jmp       short M01_L02
M01_L05:
       xor       r10d,r10d
       cmp       r8d,4
       jl        short M01_L11
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     rax,dx
       cmp       r10d,eax
       jne       short M01_L06
       xor       eax,eax
       vzeroupper
       ret
M01_L06:
       movsx     rax,word ptr [rcx+2]
       movsx     r10,dx
       cmp       eax,r10d
       jne       short M01_L07
       mov       eax,1
       vzeroupper
       ret
M01_L07:
       movsx     rax,word ptr [rcx+4]
       movsx     r10,dx
       cmp       eax,r10d
       jne       short M01_L08
       mov       eax,2
       vzeroupper
       ret
M01_L08:
       movsx     rax,word ptr [rcx+6]
       movsx     r10,dx
       cmp       eax,r10d
       jne       short M01_L09
       mov       eax,3
       jmp       short M01_L03
M01_L09:
       mov       r10d,4
       test      r8d,r8d
       jle       short M01_L13
M01_L10:
       dec       r8d
       movsx     rax,word ptr [rcx+r10*2]
       movsx     r9,dx
       cmp       eax,r9d
       je        short M01_L12
       inc       r10
M01_L11:
       test      r8d,r8d
       jg        short M01_L10
       jmp       short M01_L13
M01_L12:
       mov       eax,r10d
       jmp       near ptr M01_L03
M01_L13:
       mov       eax,0FFFFFFFF
       jmp       near ptr M01_L03
M01_L14:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm1,0D8
       vpmovmskb r8d,ymm0
       xor       ecx,ecx
       tzcnt     ecx,r8d
       add       eax,ecx
       jmp       near ptr M01_L03
M01_L15:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       lea       eax,[r8-8]
       movsxd    r8,eax
       lea       rax,[rcx+r8*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm1,[rdx]
       vpackuswb xmm1,xmm1,[rax]
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M01_L13
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M01_L16
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M01_L16:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       near ptr M01_L03
; Total bytes of code 462
```
```assembly
; System.String.IndexOf(Char, System.StringComparison)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       edi,edx
       mov       esi,r8d
M02_L00:
       cmp       esi,4
       jne       short M02_L02
       lea       rcx,[rbx+0C]
       mov       r8d,[rbx+8]
       movsx     rdx,di
       movzx     eax,dx
       dec       eax
       cmp       eax,0FE
       jae       near ptr M02_L04
       movsx     rdx,dx
       call      qword ptr [7FFBEC177798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
M02_L01:
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       cmp       esi,5
       ja        short M02_L03
       mov       edx,esi
       lea       rcx,[7FFBEC0B7760]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M02_L00]
       add       rcx,rax
       jmp       rcx
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBEC6C4AF8]
       mov       rsi,rax
       mov       ecx,0B55
       mov       rdx,7FFBEBF44000
       call      qword ptr [7FFBEC2277B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBEC386190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       call      qword ptr [7FFBEC225DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rcx,rax
       mov       r9d,esi
       and       r9d,1
       movzx     r8d,di
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6C5A28]
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      qword ptr [7FFBEC005728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2122A800188
       mov       rcx,[rcx]
       mov       r9d,esi
       and       r9d,1
       movzx     r8d,di
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC6C5A28]
       jmp       near ptr M02_L01
M02_L04:
       call      qword ptr [7FFBEC224B10]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       near ptr M02_L01
       movzx     edx,di
       mov       rcx,rbx
       call      qword ptr [7FFBEC6C4B28]
       jmp       near ptr M02_L01
; Total bytes of code 301
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathHasInvalidChars()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rax,7C150798CBC4
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       rsi,[rbx+138]
       test      rsi,rsi
       je        near ptr M00_L12
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L12
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L14
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L15
       mov       rax,7FFC49676098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L01:
       mov       r8,16BA4800168
       mov       r8,[r8]
       cmp       [rsi],sil
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       add       r8,10
       mov       edx,esi
       mov       rbp,r8
       cmp       edx,8
       jl        near ptr M00_L07
       cmp       edx,14
       jl        near ptr M00_L06
M00_L02:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       xor       ecx,ecx
       mov       eax,21
       nop       dword ptr [rax]
M00_L03:
       movzx     r10d,word ptr [r8+rcx]
       cmp       r10d,7F
       jg        near ptr M00_L18
       mov       r9d,r10d
       sar       r9d,4
       lea       r11,[rsp+20]
       and       r10d,0F
       add       r10,r11
       mov       r11d,1
       shlx      r9d,r11d,r9d
       movzx     r9d,r9b
       or        [r10],r9b
       add       rcx,2
       dec       eax
       jne       short M00_L03
       movzx     r8d,byte ptr [rsp+20]
       and       r8d,1
       vmovdqu   xmm0,xmmword ptr [rsp+20]
       vmovaps   ymm1,ymm0
       vinserti128 ymm0,ymm1,xmm0,1
       vmovups   [rsp+20],ymm0
       test      r8b,1
       jne       near ptr M00_L11
       lea       r8,[rsp+20]
       mov       rcx,rdi
       call      qword ptr [7FFBEC197270]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L04:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,7C150798CBC4
       cmp       [rsp+68],r8
       je        short M00_L05
       call      CORINFO_HELP_FAIL_FAST
M00_L05:
       nop
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L06:
       cmp       edx,10
       jge       near ptr M00_L02
M00_L07:
       mov       edx,esi
       lea       rsi,[rdi+rdx*2]
       mov       r14,rdi
       cmp       rdi,rsi
       je        short M00_L09
M00_L08:
       movzx     edx,word ptr [r14]
       movsx     rdx,dx
       mov       rcx,rbp
       mov       r8d,21
       call      qword ptr [7FFBEC24EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L17
       add       r14,2
       cmp       r14,rsi
       jne       short M00_L08
M00_L09:
       mov       eax,0FFFFFFFF
M00_L10:
       jmp       short M00_L04
M00_L11:
       lea       r8,[rsp+20]
       mov       rcx,rdi
       call      qword ptr [7FFBEC64E5F8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       near ptr M00_L04
M00_L12:
       call      qword ptr [7FFBEC434420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FFBEC716C40]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1AC23767DF8
       call      qword ptr [7FFBEC715ED8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FFBEC7155F0]
       test      eax,eax
       jne       short M00_L16
       jmp       near ptr M00_L00
M00_L15:
       call      qword ptr [7FFBEC7155F0]
       test      eax,eax
       je        near ptr M00_L01
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFBEC715608]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L17:
       mov       rax,r14
       sub       rax,rdi
       shr       rax,1
       jmp       near ptr M00_L10
M00_L18:
       mov       rcx,rdi
       mov       r9d,21
       call      qword ptr [7FFBEC715D28]
       jmp       near ptr M00_L04
; Total bytes of code 639
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       push      rbp
       sub       rsp,3B0
       lea       rbp,[rsp+3B0]
       xor       eax,eax
       mov       [rbp-1D8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1D0],xmm4
       mov       rax,0FFFFFFFFFFFFFE80
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8
       mov       dword ptr [rbp-238],3E8
       mov       rax,[rbp+10]
       mov       [rbp-40],rax
       cmp       dword ptr [rbp+18],8
       jge       near ptr M01_L05
       movsxd    rax,dword ptr [rbp+18]
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-58],rax
       jmp       short M01_L03
M01_L01:
       mov       rax,[rbp-40]
       movzx     eax,word ptr [rax]
       mov       [rbp-5C],eax
       mov       rax,[rbp+20]
       cmp       [rax],al
       mov       rax,[rbp+20]
       lea       rcx,[rax+20]
       mov       edx,[rbp-5C]
       call      qword ptr [7FFBEC1974C8]
       mov       ecx,eax
       call      qword ptr [7FFBEC1974E0]
       test      eax,eax
       je        short M01_L02
       mov       rcx,7FFBEC1F73B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBEC1974F8]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,7FFBEC1F73B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-40]
       add       rax,2
       mov       [rbp-40],rax
M01_L03:
       mov       eax,[rbp-238]
       dec       eax
       mov       [rbp-238],eax
       cmp       dword ptr [rbp-238],0
       jg        short M01_L04
       lea       rcx,[rbp-238]
       mov       edx,47
       call      CORINFO_HELP_PATCHPOINT
M01_L04:
       mov       rax,[rbp-40]
       cmp       rax,[rbp-58]
       jne       near ptr M01_L01
       mov       rcx,7FFBEC1F73B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC197510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L05:
       cmp       dword ptr [rbp+18],10
       jle       near ptr M01_L08
       mov       rax,[rbp+20]
       vmovups   ymm0,[rax]
       vmovups   [rbp-90],ymm0
       cmp       dword ptr [rbp+18],20
       jle       near ptr M01_L10
       mov       eax,[rbp+18]
       add       eax,0FFFFFFE0
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-98],rax
M01_L06:
       mov       eax,[rbp-238]
       dec       eax
       mov       [rbp-238],eax
       cmp       dword ptr [rbp-238],0
       jg        short M01_L07
       lea       rcx,[rbp-238]
       mov       edx,96
       call      CORINFO_HELP_PATCHPOINT
M01_L07:
       mov       rax,[rbp-40]
       vmovups   ymm0,[rax]
       vmovups   [rbp-230],ymm0
       mov       rax,[rbp-40]
       vmovups   ymm0,[rax+20]
       vmovups   [rbp-0D0],ymm0
       vmovups   ymm0,[rbp-230]
       vmovups   [rbp-270],ymm0
       vmovups   ymm0,[rbp-0D0]
       vmovups   [rbp-290],ymm0
       vmovups   ymm0,[rbp-90]
       vmovups   [rbp-2B0],ymm0
       lea       rdx,[rbp-270]
       lea       r8,[rbp-290]
       lea       r9,[rbp-2B0]
       lea       rcx,[rbp-0F0]
       call      qword ptr [7FFBEC1973C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M01_L09
       mov       rcx,7FFBEC1F73BC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC197480]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L08:
       mov       rcx,7FFBEC1F73C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L15
M01_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M01_L11
       mov       rcx,7FFBEC1F73C4
       call      CORINFO_HELP_COUNTPROFILE32
M01_L10:
       mov       eax,[rbp+18]
       add       eax,0FFFFFFF0
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-0F8],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-0F8]
       ja        short M01_L12
       mov       rax,[rbp-40]
       mov       [rbp-1D8],rax
       jmp       short M01_L13
M01_L11:
       mov       rcx,7FFBEC1F73C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L06
M01_L12:
       mov       rcx,7FFBEC1F73CC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-0F8]
       mov       [rbp-1D8],rax
M01_L13:
       mov       rax,[rbp-1D8]
       mov       [rbp-100],rax
       mov       rax,[rbp-100]
       vmovups   ymm0,[rax]
       vmovups   [rbp-210],ymm0
       mov       rax,[rbp-0F8]
       vmovups   ymm0,[rax]
       vmovups   [rbp-130],ymm0
       vmovups   ymm0,[rbp-210]
       vmovups   [rbp-2F0],ymm0
       vmovups   ymm0,[rbp-130]
       vmovups   [rbp-310],ymm0
       vmovups   ymm0,[rbp-90]
       vmovups   [rbp-330],ymm0
       lea       rdx,[rbp-2F0]
       lea       r8,[rbp-310]
       lea       r9,[rbp-330]
       lea       rcx,[rbp-150]
       call      qword ptr [7FFBEC1973C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M01_L14
       mov       rcx,7FFBEC1F73D0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC197408]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndexOverlapped[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L14:
       mov       rcx,7FFBEC1F73D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC197510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L15:
       mov       rax,[rbp+20]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-50],xmm0
       mov       eax,[rbp+18]
       add       eax,0FFFFFFF8
       cdqe
       mov       rcx,[rbp+10]
       lea       rax,[rcx+rax*2]
       mov       [rbp-188],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-188]
       ja        short M01_L16
       mov       rax,[rbp-40]
       mov       [rbp-1B8],rax
       jmp       short M01_L17
M01_L16:
       mov       rcx,7FFBEC1F73D8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rbp-188]
       mov       [rbp-1B8],rax
M01_L17:
       mov       rax,[rbp-1B8]
       mov       [rbp-190],rax
       mov       rax,[rbp-190]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-1D0],xmm0
       mov       rax,[rbp-188]
       vmovups   xmm0,[rax]
       vmovaps   [rbp-1A0],xmm0
       vmovaps   xmm0,[rbp-1D0]
       vmovaps   [rbp-360],xmm0
       vmovaps   xmm0,[rbp-1A0]
       vmovaps   [rbp-370],xmm0
       vmovaps   xmm0,[rbp-50]
       vmovaps   [rbp-380],xmm0
       lea       rdx,[rbp-360]
       lea       r8,[rbp-370]
       lea       r9,[rbp-380]
       lea       rcx,[rbp-1B0]
       call      qword ptr [7FFBEC197330]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M01_L18
       mov       rcx,7FFBEC1F73DC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC197378]
       mov       [rbp-23C],eax
       jmp       short M01_L19
M01_L18:
       mov       rcx,7FFBEC1F73E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC197510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
       mov       [rbp-23C],eax
M01_L19:
       mov       eax,[rbp-23C]
       vzeroupper
       add       rsp,3B0
       pop       rbp
       ret
; Total bytes of code 1398
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       r8d,8
       jl        short M02_L02
       movsx     rdx,dx
       movd      xmm0,edx
       punpcklwd xmm0,xmm0
       pshufd    xmm0,xmm0,0
       lea       eax,[r8-8]
       lea       rax,[rcx+rax*2]
       movups    xmm1,[rcx]
       pcmpeqw   xmm1,xmm0
       ptest     xmm1,xmm1
       jne       short M02_L04
M02_L00:
       add       rcx,10
       cmp       rcx,rax
       jbe       near ptr M02_L09
       mov       r8d,r8d
       test      r8b,7
       je        short M02_L01
       movups    xmm1,[rax]
       pcmpeqw   xmm0,xmm1
       ptest     xmm0,xmm0
       jne       short M02_L04
M02_L01:
       xor       eax,eax
       ret
M02_L02:
       xor       eax,eax
       cmp       r8d,8
       jge       short M02_L07
M02_L03:
       cmp       r8d,4
       jl        short M02_L05
       add       r8d,0FFFFFFFC
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       jne       near ptr M02_L08
M02_L04:
       mov       eax,1
       ret
M02_L05:
       test      r8d,r8d
       jle       short M02_L01
       add       rax,rax
M02_L06:
       dec       r8d
       movsx     r10,word ptr [rcx+rax]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       add       rax,2
       test      r8d,r8d
       jg        short M02_L06
       jmp       short M02_L01
M02_L07:
       add       r8d,0FFFFFFF8
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+2]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+4]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+6]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+8]
       movsx     r9,dx
       cmp       r10d,r9d
       je        short M02_L04
       movsx     r10,word ptr [rcx+rax*2+0A]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L04
       movsx     r10,word ptr [rcx+rax*2+0C]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L04
       movsx     r10,word ptr [rcx+rax*2+0E]
       movsx     r9,dx
       cmp       r10d,r9d
       je        near ptr M02_L04
       add       rax,8
       cmp       r8d,8
       jge       near ptr M02_L07
       jmp       near ptr M02_L03
M02_L08:
       add       rax,4
       jmp       near ptr M02_L05
M02_L09:
       movups    xmm1,[rcx]
       pcmpeqw   xmm1,xmm0
       ptest     xmm1,xmm1
       jne       near ptr M02_L04
       jmp       near ptr M02_L00
; Total bytes of code 393
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jl        near ptr M03_L04
       cmp       edx,10
       jle       near ptr M03_L10
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       near ptr M03_L01
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
       vbroadcastss ymm1,dword ptr [7FFBEC0D9700]
       vpminuw   ymm2,ymm1,[rcx]
       vpminuw   ymm3,ymm1,[rcx+20]
       vpackuswb ymm2,ymm2,ymm3
       vpshufb   ymm3,ymm0,ymm2
       vpsrld    ymm2,ymm2,4
       vbroadcastss ymm4,dword ptr [7FFBEC0D9704]
       vpand     ymm2,ymm2,ymm4
       vbroadcastsd ymm5,qword ptr [7FFBEC0D9708]
       vpshufb   ymm2,ymm5,ymm2
       vpand     ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       near ptr M03_L08
       nop       word ptr [rax+rax]
M03_L00:
       add       rax,40
       cmp       rax,r8
       jae       short M03_L01
       vpminuw   ymm2,ymm1,[rax]
       vpminuw   ymm3,ymm1,[rax+20]
       vpackuswb ymm2,ymm2,ymm3
       vpshufb   ymm3,ymm0,ymm2
       vpsrld    ymm2,ymm2,4
       vpand     ymm2,ymm2,ymm4
       vpshufb   ymm2,ymm5,ymm2
       vpand     ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       je        short M03_L00
       jmp       near ptr M03_L08
M03_L01:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vbroadcastss ymm1,dword ptr [7FFBEC0D9700]
       vpminuw   ymm5,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm5,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm4,dword ptr [7FFBEC0D9704]
       vpand     ymm1,ymm1,ymm4
       vbroadcastsd ymm5,qword ptr [7FFBEC0D9708]
       vpshufb   ymm1,ymm5,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M03_L12
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r8d,ymm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,10
       jge       near ptr M03_L09
M03_L02:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
M03_L03:
       vzeroupper
       ret
M03_L04:
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       cmp       rcx,rdx
       je        near ptr M03_L12
M03_L05:
       movzx     r10d,word ptr [rax]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       short M03_L06
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jb        short M03_L07
M03_L06:
       add       rax,2
       cmp       rax,rdx
       jne       short M03_L05
       jmp       near ptr M03_L12
M03_L07:
       sub       rax,rcx
       shr       rax,1
       jmp       short M03_L03
M03_L08:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm1,ymm2,0D8
       vxorps    ymm0,ymm0,ymm0
       vpcmpeqb  ymm4,ymm0,ymm1
       vpmovmskb edx,ymm4
       mov       ecx,edx
       not       ecx
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       short M03_L03
M03_L09:
       mov       rax,rdx
       add       r8d,0FFFFFFF0
       jmp       near ptr M03_L02
M03_L10:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*2]
       cmp       rcx,rax
       mov       r8,rcx
       cmova     r8,rax
       vmovups   xmm1,[r8]
       vpminuw   xmm1,xmm1,[7FFBEC0D9710]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FFBEC0D9710]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFBEC0D9720]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFBEC0D9708]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M03_L12
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb edx,xmm0
       not       edx
       tzcnt     edx,edx
       cmp       edx,8
       jl        short M03_L11
       mov       r8,rax
       add       edx,0FFFFFFF8
M03_L11:
       sub       r8,rcx
       shr       r8,1
       lea       eax,[r8+rdx]
       jmp       near ptr M03_L03
M03_L12:
       mov       eax,0FFFFFFFF
       vzeroupper
       ret
; Total bytes of code 602
```

