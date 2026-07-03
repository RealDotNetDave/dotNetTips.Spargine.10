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
       mov       rsi,7FFA4BDB6098
       mov       rcx,offset MT_System.String[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,2E634790760
       mov       [rdi+10],rcx
       mov       rcx,2E634790780
       mov       [rdi+18],rcx
       mov       rcx,2E6347907A8
       mov       [rdi+20],rcx
       mov       rcx,2E6347907D0
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
       call      qword ptr [7FF9F125DDD0]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FF9F0E5FC78]; System.IO.Path.GetFullPath(System.String)
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
       mov       rdx,2E634780008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FF9F12E5770]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF9F12E5770]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F12E77B0]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B74000
       call      qword ptr [7FF9F0E577B0]
       mov       rcx,rax
       call      qword ptr [7FF9F11DE820]
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
       mov       rax,262EF032F96A
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
       call      qword ptr [7FF9F0C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,262EF032F96A
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
       call      qword ptr [7FF9F0C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,2A59F800C90
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F0F1D5A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FF9F0B74000
       call      qword ptr [7FF9F0E577B0]
       mov       rcx,rax
       call      qword ptr [7FF9F11DE820]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9F11DF4E0]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FF9F11DF4E0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FF9F12E7DC8]
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
       call      qword ptr [7FF9F11DF4E0]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FF9F106D920]
       int       3
M01_L30:
       call      qword ptr [7FF9F0DA7198]
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
       call      qword ptr [7FF9F0E5FC90]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF9F0E5FCC0]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9F0E5FCF0]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FF9F0E5FD08]; System.IO.PathHelper.Normalize(System.String)
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
       mov       rdx,7FF9F0B74000
       call      qword ptr [7FF9F0E577B0]
       mov       rcx,rax
       call      qword ptr [7FF9F11DE820]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F12E78B8]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B74000
       call      qword ptr [7FF9F0E577B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC6E68]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F12E78D0]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B74000
       call      qword ptr [7FF9F0E577B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FC6E68]
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
       mov       rsi,7FFA4BDB6098
       mov       rcx,offset MT_System.String[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,18442B60760
       mov       [rdi+10],rcx
       mov       rcx,18442B60780
       mov       [rdi+18],rcx
       mov       rcx,18442B607A8
       mov       [rdi+20],rcx
       mov       rcx,18442B607D0
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
       call      qword ptr [7FF9F124DA70]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FF9F0E4EFA0]; System.IO.Path.GetFullPath(System.String)
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
       mov       rdx,18442B50008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FF9F12D4468]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF9F12D4468]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FF9F12D4480]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B64000
       call      qword ptr [7FF9F0E477B0]
       mov       rcx,rax
       call      qword ptr [7FF9F124FC30]
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
       mov       rax,655036B80B40
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
       call      qword ptr [7FF9F0C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,655036B80B40
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
       call      qword ptr [7FF9F0C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,143ADC00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F0EF07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FF9F0B64000
       call      qword ptr [7FF9F0E477B0]
       mov       rcx,rax
       call      qword ptr [7FF9F124FC30]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9F11AF198]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FF9F11AF198]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FF9F12D4D50]
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
       call      qword ptr [7FF9F11AF198]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FF9F103CC48]
       int       3
M01_L30:
       call      qword ptr [7FF9F0D97198]
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
       call      qword ptr [7FF9F0E4EFB8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF9F0E4EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9F0E4F018]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FF9F0E4F030]; System.IO.PathHelper.Normalize(System.String)
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
       mov       rdx,7FF9F0B64000
       call      qword ptr [7FF9F0E477B0]
       mov       rcx,rax
       call      qword ptr [7FF9F124FC30]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F12D46A8]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B64000
       call      qword ptr [7FF9F0E477B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FA6190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F12D46C0]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B64000
       call      qword ptr [7FF9F0E477B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FA6190]
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
       mov       rsi,7FFA4BDB6098
       mov       rcx,offset MT_System.String[]
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,23DCCA20760
       mov       [rdi+10],rcx
       mov       rcx,23DCCA20780
       mov       [rdi+18],rcx
       mov       rcx,23DCCA207A8
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
       call      qword ptr [7FF9F126D680]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FF9F0E7EFA0]; System.IO.Path.GetFullPath(System.String)
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
       mov       rdx,23DCCA10008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FF9F1304480]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF9F1304480]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F1304498]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B94000
       call      qword ptr [7FF9F0E777B0]
       mov       rcx,rax
       call      qword ptr [7FF9F126FC48]
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
       mov       rax,93F9CE2C2245
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
       call      qword ptr [7FF9F0C55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,93F9CE2C2245
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
       call      qword ptr [7FF9F0C55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,1FD37C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F0F207A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FF9F0B94000
       call      qword ptr [7FF9F0E777B0]
       mov       rcx,rax
       call      qword ptr [7FF9F126FC48]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9F11DED78]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FF9F11DED78]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FF9F1304D68]
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
       call      qword ptr [7FF9F11DED78]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FF9F106CC48]
       int       3
M01_L30:
       call      qword ptr [7FF9F0DC7198]
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
       call      qword ptr [7FF9F0E7EFB8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF9F0E7EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9F0E7F018]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FF9F0E7F030]; System.IO.PathHelper.Normalize(System.String)
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
       mov       rdx,7FF9F0B94000
       call      qword ptr [7FF9F0E777B0]
       mov       rcx,rax
       call      qword ptr [7FF9F126FC48]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F13046C0]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B94000
       call      qword ptr [7FF9F0E777B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FD6190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F13046D8]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B94000
       call      qword ptr [7FF9F0E777B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FD6190]
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
       mov       rsi,7FFA4BDB6098
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,24053350760
       mov       [rdi+10],rcx
       mov       rcx,24053350780
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
       call      qword ptr [7FF9F1225DE8]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FF9F0E3EFA0]; System.IO.Path.GetFullPath(System.String)
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
       mov       rdx,24053340008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FF9F122E250]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FF9F122E250]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF9F122E268]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B54000
       call      qword ptr [7FF9F0E377B0]
       mov       rcx,rax
       call      qword ptr [7FF9F122E4F0]
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
       mov       rax,4E3318CADF21
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
       call      qword ptr [7FF9F0C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,4E3318CADF21
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
       call      qword ptr [7FF9F0C15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,1FFBE400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF9F0EE07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AC
       mov       rdx,7FF9F0B54000
       call      qword ptr [7FF9F0E377B0]
       mov       rcx,rax
       call      qword ptr [7FF9F122E4F0]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FF9F1197558]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FF9F1197558]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FF9F122E508]
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
       call      qword ptr [7FF9F1197558]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L30:
       call      qword ptr [7FF9F102CC48]
       int       3
M01_L31:
       call      qword ptr [7FF9F0D87198]
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
       call      qword ptr [7FF9F0E3EFB8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FF9F0E3EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FF9F0E3F018]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FF9F0E3F030]; System.IO.PathHelper.Normalize(System.String)
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
       mov       rdx,7FF9F0B54000
       call      qword ptr [7FF9F0E377B0]
       mov       rcx,rax
       call      qword ptr [7FF9F122E4F0]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F122E658]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B54000
       call      qword ptr [7FF9F0E377B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0F96190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F122E670]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FF9F0B54000
       call      qword ptr [7FF9F0E377B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0F96190]
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
       mov       rax,1F7101A1E497
       mov       [rsp+38],rax
       mov       rbx,rcx
       mov       rdx,24ECC000158
       mov       rsi,[rdx]
       mov       rdi,28F4AF7076C
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
       call      qword ptr [7FF9F0E6EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F1256778]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       mov       r8,1F7101A1E497
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
       ja        short M01_L01
       vpcmpeqw  ymm1,ymm0,[rcx]
       vptest    ymm1,ymm1
       jne       near ptr M01_L11
       jmp       short M01_L00
M01_L01:
       mov       r8d,r8d
       test      r8b,0F
       je        short M01_L02
       vpcmpeqw  ymm0,ymm0,[rax]
       vptest    ymm0,ymm0
       jne       near ptr M01_L11
M01_L02:
       xor       eax,eax
       vzeroupper
       ret
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
       jmp       near ptr M01_L02
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
       je        near ptr M01_L02
       vpcmpeqw  xmm0,xmm0,[rax]
       vptest    xmm0,xmm0
       je        near ptr M01_L02
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
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L01:
       lea       rdi,[rsi+0C]
       mov       rcx,rdi
       mov       esi,[rsi+8]
       mov       r8d,esi
       mov       edx,2A
       call      qword ptr [7FF9F0D97798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       cmp       eax,0FFFFFFFF
       jne       near ptr M00_L08
       mov       rcx,rdi
       mov       r8d,esi
       mov       edx,3F
       call      qword ptr [7FF9F0D97798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F1034420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FF9F123E778]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21CD4907DF8
       call      qword ptr [7FF9F123E790]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF9F123E088]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FF9F123E088]
       test      eax,eax
       je        near ptr M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF9F123E0A0]
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
       mov       rax,8E9374B96951
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
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L15
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L01:
       mov       r8,17496000160
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
       call      qword ptr [7FF9F0DA7270]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L04:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,8E9374B96951
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
       call      qword ptr [7FF9F0E5EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F1246778]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       near ptr M00_L04
M00_L12:
       call      qword ptr [7FF9F1044420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FF9F124F768]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,17401D37DF8
       call      qword ptr [7FF9F124F780]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FF9F124EB80]
       test      eax,eax
       jne       short M00_L16
       jmp       near ptr M00_L00
M00_L15:
       call      qword ptr [7FF9F124EB80]
       test      eax,eax
       je        near ptr M00_L01
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF9F124EB98]
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
       call      qword ptr [7FF9F124F258]
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
       call      qword ptr [7FF9F0DA74C8]
       mov       ecx,eax
       call      qword ptr [7FF9F0DA74E0]
       test      eax,eax
       je        short M01_L02
       mov       rcx,7FF9F0E073B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9F0DA74F8]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,7FF9F0E073B4
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
       mov       rcx,7FF9F0E073B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DA7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       call      qword ptr [7FF9F0DA73C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M01_L09
       mov       rcx,7FF9F0E073BC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DA7480]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L08:
       mov       rcx,7FF9F0E073C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L15
M01_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M01_L11
       mov       rcx,7FF9F0E073C4
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
       mov       rcx,7FF9F0E073C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L06
M01_L12:
       mov       rcx,7FF9F0E073CC
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
       call      qword ptr [7FF9F0DA73C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M01_L14
       mov       rcx,7FF9F0E073D0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DA7408]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L14:
       mov       rcx,7FF9F0E073D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DA7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       mov       rcx,7FF9F0E073D8
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
       call      qword ptr [7FF9F0DA7330]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M01_L18
       mov       rcx,7FF9F0E073DC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DA7378]
       mov       [rbp-23C],eax
       jmp       short M01_L19
M01_L18:
       mov       rcx,7FF9F0E073E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DA7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       vbroadcastss ymm1,dword ptr [7FF9F0CCE530]
       vbroadcastss ymm2,dword ptr [7FF9F0CCE534]
       vbroadcastsd ymm3,qword ptr [7FF9F0CCE538]
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
       vbroadcastss ymm1,dword ptr [7FF9F0CCE530]
       vpminuw   ymm3,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm3,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm2,dword ptr [7FF9F0CCE534]
       vpand     ymm1,ymm1,ymm2
       vbroadcastsd ymm3,qword ptr [7FF9F0CCE538]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M03_L08
M03_L02:
       mov       eax,0FFFFFFFF
       vzeroupper
       ret
M03_L03:
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       cmp       rax,rdx
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
       setb      r10b
       movzx     r10d,r10b
       test      r10d,r10d
       jne       short M03_L06
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
       vpminuw   xmm1,xmm1,[7FF9F0CCE540]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FF9F0CCE540]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9F0CCE550]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9F0CCE538]
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
; Total bytes of code 547
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathSeparators()
       push      rbx
       sub       rsp,10
       mov       rdx,1D8DF400168
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
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L01:
       mov       rax,rsi
       mov       edi,[rax+8]
       cmp       word ptr [rax+rdi*2+0A],5C
       je        short M00_L03
       lea       rbp,[rsi+0C]
       mov       esi,[rsi+8]
       mov       dword ptr [rsp+2C],5C
       mov       edx,esi
       add       edx,1
       jo        near ptr M00_L11
       test      edx,edx
       je        near ptr M00_L09
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA508C9D30
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       esi,r13d
       ja        near ptr M00_L10
       lea       r8,[rdi+rdi]
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF9F0C45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rax,[r15+rdi*2]
       sub       r13d,esi
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
       call      qword ptr [7FF9F1054420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FF9F1305410]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C13C8D7DF8
       call      qword ptr [7FF9F1304708]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FF9F13041E0]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FF9F13041E0]
       test      eax,eax
       je        near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF9F13041F8]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       r14,1C13C8D0008
       jmp       near ptr M00_L02
M00_L10:
       call      qword ptr [7FF9F105CC48]
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
       jmp       qword ptr [7FF9F0C466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,0D1E57C334D5C
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       rsi,[rbx+30]
       xor       ecx,ecx
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rcx,offset MT_System.String
       mov       edx,1
       call      00007FFA508C9D30
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
       call      00007FFA508C9D30
       mov       r13,rax
       cmp       [r13],r13b
       lea       rcx,[r13+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F0C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r15d
       lea       rcx,[r13+rcx*2+0C]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F0C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       esi,[r13+8]
       test      esi,esi
       je        near ptr M00_L16
       movzx     ecx,word ptr [r13+0C]
       cmp       ecx,100
       jge       near ptr M00_L18
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [r13+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L19
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L20
M00_L02:
       mov       r8,23D6B000158
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
       call      qword ptr [7FF9F0DA7270]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L05:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,0D1E57C334D5C
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
       call      qword ptr [7FF9F0E5EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F1246778]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       near ptr M00_L05
M00_L13:
       mov       r14d,[rdi+8]
       mov       rcx,27DE9E30008
       test      r14d,r14d
       mov       r13,rcx
       cmovne    r13,rdi
       jmp       near ptr M00_L00
M00_L14:
       mov       r13,rsi
       jmp       near ptr M00_L00
M00_L15:
       call      qword ptr [7FF9F124ECA0]
       int       3
M00_L16:
       call      qword ptr [7FF9F1044420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L17
       call      qword ptr [7FF9F124F7B0]
       mov       rbx,rax
M00_L17:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27DE9E40760
       call      qword ptr [7FF9F124F7C8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L18:
       call      qword ptr [7FF9F124ED18]
       test      eax,eax
       jne       short M00_L20
       jmp       near ptr M00_L01
M00_L19:
       call      qword ptr [7FF9F124ED18]
       test      eax,eax
       je        near ptr M00_L02
M00_L20:
       mov       rcx,r13
       mov       edx,3
       call      qword ptr [7FF9F124ED30]
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
       call      qword ptr [7FF9F124F3D8]
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
       ja        short M01_L00
       test      r8b,18
       jne       near ptr M01_L06
       test      r8b,4
       jne       near ptr M01_L07
       test      r8,r8
       je        near ptr M01_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M01_L05
       nop       dword ptr [rax+rax]
       nop       dword ptr [rax+rax]
M01_L00:
       cmp       r8,40
       jbe       short M01_L03
       cmp       r8,800
       ja        near ptr M01_L09
       cmp       r8,100
       jb        short M01_L01
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
M01_L01:
       mov       r9,r8
       shr       r9,6
M01_L02:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L02
       and       r8,3F
       cmp       r8,10
       jbe       short M01_L04
M01_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M01_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M01_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L05:
       vzeroupper
       ret
M01_L06:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M01_L05
M01_L07:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M01_L05
M01_L08:
       cmp       rcx,rdx
       jne       short M01_L09
       cmp       [rdx],dl
       jmp       short M01_L05
M01_L09:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F0C366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 339
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
       call      qword ptr [7FF9F0DA74C8]
       mov       ecx,eax
       call      qword ptr [7FF9F0DA74E0]
       test      eax,eax
       je        short M02_L02
       mov       rcx,7FF9F0E073B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9F0DA74F8]
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L02:
       mov       rcx,7FF9F0E073B4
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
       mov       rcx,7FF9F0E073B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DA7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       call      qword ptr [7FF9F0DA73C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M02_L09
       mov       rcx,7FF9F0E073BC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DA7480]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L08:
       mov       rcx,7FF9F0E073C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L15
M02_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M02_L11
       mov       rcx,7FF9F0E073C4
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
       mov       rcx,7FF9F0E073C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M02_L06
M02_L12:
       mov       rcx,7FF9F0E073CC
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
       call      qword ptr [7FF9F0DA73C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M02_L14
       mov       rcx,7FF9F0E073D0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DA7408]
       mov       [rbp-23C],eax
       jmp       near ptr M02_L19
M02_L14:
       mov       rcx,7FF9F0E073D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DA7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       mov       rcx,7FF9F0E073D8
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
       call      qword ptr [7FF9F0DA7330]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M02_L18
       mov       rcx,7FF9F0E073DC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DA7378]
       mov       [rbp-23C],eax
       jmp       short M02_L19
M02_L18:
       mov       rcx,7FF9F0E073E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DA7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       vbroadcastss ymm1,dword ptr [7FF9F0CCE8F0]
       vbroadcastss ymm2,dword ptr [7FF9F0CCE8F4]
       vbroadcastsd ymm3,qword ptr [7FF9F0CCE8F8]
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
       vbroadcastss ymm1,dword ptr [7FF9F0CCE8F0]
       vpminuw   ymm3,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm3,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm2,dword ptr [7FF9F0CCE8F4]
       vpand     ymm1,ymm1,ymm2
       vbroadcastsd ymm3,qword ptr [7FF9F0CCE8F8]
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
       vpminuw   xmm1,xmm1,[7FF9F0CCE900]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FF9F0CCE900]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9F0CCE910]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9F0CCE8F8]
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
; Total bytes of code 549
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
       mov       rcx,20FD7000158
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
       mov       rcx,13C4F800160
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
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L07
M00_L01:
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       edx,2A
       call      qword ptr [7FF9F0D97798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F1034420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L04
       call      qword ptr [7FF9F12E5500]
       mov       rbx,rax
M00_L04:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1A84B677DF8
       call      qword ptr [7FF9F12E47F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FF9F12E41F8]
       test      eax,eax
       jne       short M00_L07
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FF9F12E41F8]
       test      eax,eax
       je        near ptr M00_L01
M00_L07:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF9F12E4210]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3F
       mov       r8d,4
       call      qword ptr [7FF9F124D800]; System.String.IndexOf(Char, System.StringComparison)
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
       call      qword ptr [7FF9F0D97798]; System.PackedSpanHelpers.IndexOf[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       lea       rcx,[7FF9F0CD2C20]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M02_L00]
       add       rcx,rax
       jmp       rcx
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F12E45E8]
       mov       rsi,rax
       mov       ecx,0B55
       mov       rdx,7FF9F0B64000
       call      qword ptr [7FF9F0E477B0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F0FA6190]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
       call      qword ptr [7FF9F0E45DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
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
       call      qword ptr [7FF9F12E5530]
       jmp       near ptr M02_L01
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      qword ptr [7FF9F0C25728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,167B68021A0
       mov       rcx,[rcx]
       mov       r9d,esi
       and       r9d,1
       movzx     r8d,di
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F12E5530]
       jmp       near ptr M02_L01
M02_L04:
       call      qword ptr [7FF9F0E44B10]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       near ptr M02_L01
       movzx     edx,di
       mov       rcx,rbx
       call      qword ptr [7FF9F12E4618]
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
       mov       rax,0F2C8FAFDBFE
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
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L15
       mov       rax,7FFA4BDB6098
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L16
M00_L01:
       mov       r8,19729800160
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
       call      qword ptr [7FF9F0DC7270]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L04:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,0F2C8FAFDBFE
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
       call      qword ptr [7FF9F0E7EFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FF9F1266790]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       near ptr M00_L04
M00_L12:
       call      qword ptr [7FF9F1064420]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L13
       call      qword ptr [7FF9F126F378]
       mov       rbx,rax
M00_L13:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1D7A89A7DF8
       call      qword ptr [7FF9F126F390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L14:
       call      qword ptr [7FF9F126EB20]
       test      eax,eax
       jne       short M00_L16
       jmp       near ptr M00_L00
M00_L15:
       call      qword ptr [7FF9F126EB20]
       test      eax,eax
       je        near ptr M00_L01
M00_L16:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF9F126EB38]
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
       call      qword ptr [7FF9F126F258]
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
       call      qword ptr [7FF9F0DC74C8]
       mov       ecx,eax
       call      qword ptr [7FF9F0DC74E0]
       test      eax,eax
       je        short M01_L02
       mov       rcx,7FF9F0E273B0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9F0DC74F8]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,7FF9F0E273B4
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
       mov       rcx,7FF9F0E273B8
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DC7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       call      qword ptr [7FF9F0DC73C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M01_L09
       mov       rcx,7FF9F0E273BC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DC7480]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L08:
       mov       rcx,7FF9F0E273C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L15
M01_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M01_L11
       mov       rcx,7FF9F0E273C4
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
       mov       rcx,7FF9F0E273C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L06
M01_L12:
       mov       rcx,7FF9F0E273CC
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
       call      qword ptr [7FF9F0DC73C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M01_L14
       mov       rcx,7FF9F0E273D0
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DC7408]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndexOverlapped[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L14:
       mov       rcx,7FF9F0E273D4
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DC7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       mov       rcx,7FF9F0E273D8
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
       call      qword ptr [7FF9F0DC7330]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M01_L18
       mov       rcx,7FF9F0E273DC
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F0DC7378]
       mov       [rbp-23C],eax
       jmp       short M01_L19
M01_L18:
       mov       rcx,7FF9F0E273E0
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FF9F0DC7510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       vbroadcastss ymm1,dword ptr [7FF9F0CEDEC0]
       vpminuw   ymm2,ymm1,[rcx]
       vpminuw   ymm3,ymm1,[rcx+20]
       vpackuswb ymm2,ymm2,ymm3
       vpshufb   ymm3,ymm0,ymm2
       vpsrld    ymm2,ymm2,4
       vbroadcastss ymm4,dword ptr [7FF9F0CEDEC4]
       vpand     ymm2,ymm2,ymm4
       vbroadcastsd ymm5,qword ptr [7FF9F0CEDEC8]
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
       vbroadcastss ymm1,dword ptr [7FF9F0CEDEC0]
       vpminuw   ymm5,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm5,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm4,dword ptr [7FF9F0CEDEC4]
       vpand     ymm1,ymm1,ymm4
       vbroadcastsd ymm5,qword ptr [7FF9F0CEDEC8]
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
       vpminuw   xmm1,xmm1,[7FF9F0CEDED0]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FF9F0CEDED0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FF9F0CEDEE0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9F0CEDEC8]
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

