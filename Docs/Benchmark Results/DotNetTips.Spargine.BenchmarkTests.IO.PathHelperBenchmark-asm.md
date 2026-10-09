## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,7FFDD1CB6BF0
       mov       rcx,offset MT_System.String[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,1D973D30BC8
       mov       [rdi+10],rcx
       mov       rcx,1D973D30BE8
       mov       [rdi+18],rcx
       mov       rcx,1D973D30C10
       mov       [rdi+20],rcx
       mov       rcx,1D973D30C38
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
       call      qword ptr [7FFD97FBF060]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFD97BAFCC0]; System.IO.Path.GetFullPath(System.String)
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
       mov       rbx,[rbx+90]
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
       mov       rdx,1D973D20008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFD98046310]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFD98046310]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFD9804C990]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3E
       mov       rdx,7FFD978C4000
       call      qword ptr [7FFD97BA7798]
       mov       rcx,rax
       call      qword ptr [7FFD97F2EC28]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 546
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
       mov       rax,0C13EC7F7B0F2
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
       call      qword ptr [7FFD97985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,0C13EC7F7B0F2
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
       call      qword ptr [7FFD97985818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,198DEC00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD97C3FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AE
       mov       rdx,7FFD978C4000
       call      qword ptr [7FFD97BA7798]
       mov       rcx,rax
       call      qword ptr [7FFD97F2EC28]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD97F2FF00]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FFD97F2FF00]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFD9804CCF0]
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
       call      qword ptr [7FFD97F2FF00]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FFD97DBDCF8]
       int       3
M01_L30:
       call      qword ptr [7FFD97AF7198]
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
       call      qword ptr [7FFD97BAFCD8]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFD97BAFD08]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD97BAFD38]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFD97BAFD50]; System.IO.PathHelper.Normalize(System.String)
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
       mov       ecx,1AC3E
       mov       rdx,7FFD978C4000
       call      qword ptr [7FFD97BA7798]
       mov       rcx,rax
       call      qword ptr [7FFD97F2EC28]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD9804CA80]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978C4000
       call      qword ptr [7FFD97BA7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D06EB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD9804CA98]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978C4000
       call      qword ptr [7FFD97BA7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D06EB0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,7FFDD1CB6BF0
       mov       rcx,offset MT_System.String[]
       mov       edx,4
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,24A655D0BC8
       mov       [rdi+10],rcx
       mov       rcx,24A655D0BE8
       mov       [rdi+18],rcx
       mov       rcx,24A655D0C10
       mov       [rdi+20],rcx
       mov       rcx,24A655D0C38
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
       call      qword ptr [7FFD97FDE850]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFD97BCF120]; System.IO.Path.GetFullPath(System.String)
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
       mov       rbx,[rbx+90]
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
       mov       rdx,24A655C0008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFD980651E8]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFD980651E8]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r15
       mov       edx,3
       call      qword ptr [7FFD98065200]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       rcx,rax
       call      qword ptr [7FFD98064990]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 546
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
       mov       rax,809B1110FF73
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
       call      qword ptr [7FFD979A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,809B1110FF73
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
       call      qword ptr [7FFD979A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,209D0800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD97C5FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AE
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       rcx,rax
       call      qword ptr [7FFD98064990]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD97F4F738]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FFD97F4F738]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFD98065AB8]
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
       call      qword ptr [7FFD97F4F738]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FFD97DCD158]
       int       3
M01_L30:
       call      qword ptr [7FFD97B17198]
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
       call      qword ptr [7FFD97BCF138]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFD97BCF168]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD97BCF198]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFD97BCF1B0]; System.IO.PathHelper.Normalize(System.String)
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
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       rcx,rax
       call      qword ptr [7FFD98064990]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD98065428]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D26310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD98065440]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D26310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,7FFDD1CB6BF0
       mov       rcx,offset MT_System.String[]
       mov       edx,3
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,2343FEB0BC8
       mov       [rdi+10],rcx
       mov       rcx,2343FEB0BE8
       mov       [rdi+18],rcx
       mov       rcx,2343FEB0C10
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
       call      qword ptr [7FFD97FADEC0]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFD97BBF120]; System.IO.Path.GetFullPath(System.String)
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
       mov       rbx,[rbx+90]
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
       mov       rdx,2343FEA0008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFD980551D0]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFD980551D0]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFD980551E8]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3E
       mov       rdx,7FFD978D4000
       call      qword ptr [7FFD97BB7798]
       mov       rcx,rax
       call      qword ptr [7FFD98054978]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 525
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
       mov       rax,997231F7CA45
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
       call      qword ptr [7FFD97995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,997231F7CA45
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
       call      qword ptr [7FFD97995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,1F3AB000C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD97C4FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AE
       mov       rdx,7FFD978D4000
       call      qword ptr [7FFD97BB7798]
       mov       rcx,rax
       call      qword ptr [7FFD98054978]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD97F3EE08]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FFD97F3EE08]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L19
M01_L26:
       lea       rcx,[rbp+20]
       mov       edx,5C
       call      qword ptr [7FFD98055AA0]
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
       call      qword ptr [7FFD97F3EE08]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L29:
       call      qword ptr [7FFD97DBD158]
       int       3
M01_L30:
       call      qword ptr [7FFD97B07198]
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
       call      qword ptr [7FFD97BBF138]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFD97BBF168]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD97BBF198]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFD97BBF1B0]; System.IO.PathHelper.Normalize(System.String)
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
       mov       ecx,1AC3E
       mov       rdx,7FFD978D4000
       call      qword ptr [7FFD97BB7798]
       mov       rcx,rax
       call      qword ptr [7FFD98054978]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD98055410]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978D4000
       call      qword ptr [7FFD97BB7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D16310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD98055428]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978D4000
       call      qword ptr [7FFD97BB7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D16310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.CombinePathsTwo()
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
       mov       rsi,7FFDD1CB6BF0
       mov       rcx,offset MT_System.String[]
       mov       edx,2
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,17821C60BC8
       mov       [rdi+10],rcx
       mov       rcx,17821C60BE8
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
       mov       dword ptr [rsp+28],2
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD97FBDEC0]; System.IO.Path.Combine(System.ReadOnlySpan`1<System.String>)
       mov       rdi,rax
       mov       dword ptr [rsi+28],0FFFFFFFF
       test      rdi,rdi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFD97BCF120]; System.IO.Path.GetFullPath(System.String)
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
       mov       rbx,[rbx+90]
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
       mov       rdx,17821C50008
       jmp       near ptr M00_L03
M00_L07:
       call      qword ptr [7FFD980650E0]
       test      eax,eax
       jne       short M00_L09
       jmp       near ptr M00_L01
M00_L08:
       call      qword ptr [7FFD980650E0]
       test      eax,eax
       je        near ptr M00_L02
M00_L09:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFD980650F8]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L10:
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       rcx,rax
       call      qword ptr [7FFD98064888]
       int       3
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 511
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
       mov       rax,81F7417676DC
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
       call      qword ptr [7FFD979A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       r8,81F7417676DC
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
       call      qword ptr [7FFD979A5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r13d,[rbp+28]
       mov       [rbp+28],r13d
       jmp       near ptr M01_L11
M01_L20:
       mov       rcx,1378CC00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFD97C5FB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       jmp       near ptr M01_L13
M01_L21:
       xor       r9d,r9d
       jmp       near ptr M01_L02
M01_L22:
       mov       ecx,1C4AE
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       rcx,rax
       call      qword ptr [7FFD98064888]
       int       3
M01_L23:
       mov       edx,edi
       sub       edx,[rbp+28]
       lea       rcx,[rbp+20]
       call      qword ptr [7FFD97F4EE20]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FFD97F4EE20]; System.Text.ValueStringBuilder.Grow(Int32)
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
       call      qword ptr [7FFD980659B0]
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
       call      qword ptr [7FFD97F4EE20]; System.Text.ValueStringBuilder.Grow(Int32)
       jmp       near ptr M01_L10
M01_L30:
       call      qword ptr [7FFD97DCD158]
       int       3
M01_L31:
       call      qword ptr [7FFD97B17198]
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
       call      qword ptr [7FFD97BCF138]; System.IO.PathInternal.IsEffectivelyEmpty(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L03
       mov       rcx,rsi
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFD97BCF168]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M02_L04
       mov       [rsp+20],rsi
       mov       [rsp+28],edi
       lea       rcx,[rsp+20]
       call      qword ptr [7FFD97BCF198]; System.IO.PathInternal.IsExtended(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       short M02_L00
       mov       rcx,rbx
       call      qword ptr [7FFD97BCF1B0]; System.IO.PathHelper.Normalize(System.String)
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
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       rcx,rax
       call      qword ptr [7FFD98064888]
       int       3
M02_L03:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD98065320]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D26310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD98065338]
       mov       rsi,rax
       mov       ecx,1AC3E
       mov       rdx,7FFD978E4000
       call      qword ptr [7FFD97BC7798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFD97D26310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 301
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.HasInvalidFilterCharsValid()
       sub       rsp,28
       mov       rdx,1D3B6500BD4
       mov       rax,193374001A0
       mov       rax,[rax]
       add       rax,8
       mov       r8,rdx
       vmovups   ymm0,[rax]
       lea       rax,[rdx+2]
       cmp       r8,rax
       cmova     r8,rax
       vbroadcastss ymm1,dword ptr [7FFD97A77CC0]
       vpminuw   ymm2,ymm1,[r8]
       vpminuw   ymm1,ymm1,[7FFD97A77CE0]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFD97A77D00]
       vbroadcastsd ymm2,qword ptr [7FFD97A77D20]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       short M00_L01
       mov       r10d,0FFFFFFFF
M00_L00:
       mov       edx,r10d
       not       edx
       shr       edx,1F
       mov       [rsp+20],dl
       mov       rcx,[rcx+90]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD97FEEB80]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       vzeroupper
       add       rsp,28
       ret
M00_L01:
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r10d,ymm0
       not       r10d
       tzcnt     r10d,r10d
       cmp       r10d,10
       jl        short M00_L02
       mov       r8,rax
       add       r10d,0FFFFFFF0
M00_L02:
       sub       r8,rdx
       shr       r8,1
       add       r10d,r8d
       jmp       short M00_L00
; Total bytes of code 216
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathContainsWildcardNoWildcard()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+1B8]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L04
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L01:
       test      rsi,rsi
       jne       short M00_L03
       xor       ecx,ecx
       xor       r9d,r9d
M00_L02:
       mov       r8,1B116000198
       mov       rdx,[r8]
       movsx     r8,word ptr [rdx+0A]
       movsx     rdx,word ptr [rdx+8]
       call      qword ptr [7FFD97BCC630]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       lea       rcx,[rsi+0C]
       mov       r9d,[rsi+8]
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFD97DC49A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFD97FBF9D8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1B081E77DF8
       call      qword ptr [7FFD97FBF9F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFD97FBF840]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFD97FBF840]
       test      eax,eax
       je        near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFD97FBF858]
       mov       rsi,rax
       jmp       near ptr M00_L01
; Total bytes of code 309
```
```assembly
; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       cmp       r9d,8
       jl        near ptr M01_L04
       mov       rax,rcx
       cmp       r9d,10
       jle       near ptr M01_L20
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb ymm1,xmm1
       cmp       r9d,20
       jle       short M01_L01
       lea       edx,[r9-20]
       movsxd    r8,edx
       lea       rdx,[rax+r8*2]
M01_L00:
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rax+20]
       vpcmpeqb  ymm3,ymm0,ymm2
       vpcmpeqb  ymm2,ymm1,ymm2
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       near ptr M01_L17
       add       rax,40
       cmp       rax,rdx
       jb        short M01_L00
M01_L01:
       add       r9d,0FFFFFFF0
       movsxd    rdx,r9d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rdx]
       vpcmpeqb  ymm0,ymm2,ymm0
       vpcmpeqb  ymm1,ymm2,ymm1
       vpor      ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M01_L18
M01_L02:
       mov       eax,0FFFFFFFF
M01_L03:
       vzeroupper
       ret
M01_L04:
       xor       r10d,r10d
       cmp       r9d,4
       jl        near ptr M01_L16
       add       r9d,0FFFFFFFC
       movsx     rax,word ptr [rcx]
       movsx     r10,dx
       cmp       eax,r10d
       je        short M01_L05
       movsx     r10,r8w
       cmp       eax,r10d
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L06
M01_L05:
       xor       eax,eax
       vzeroupper
       ret
M01_L06:
       movsx     rax,word ptr [rcx+2]
       movsx     r10,dx
       cmp       eax,r10d
       je        short M01_L07
       movsx     r10,r8w
       cmp       eax,r10d
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L08
M01_L07:
       mov       eax,1
       vzeroupper
       ret
M01_L08:
       movsx     rax,word ptr [rcx+4]
       movsx     r10,dx
       cmp       eax,r10d
       je        short M01_L09
       movsx     r10,r8w
       cmp       eax,r10d
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L10
M01_L09:
       mov       eax,2
       vzeroupper
       ret
M01_L10:
       movsx     rax,word ptr [rcx+6]
       movsx     r10,dx
       cmp       eax,r10d
       je        short M01_L11
       movsx     r10,r8w
       cmp       eax,r10d
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L12
M01_L11:
       mov       eax,3
       jmp       near ptr M01_L03
M01_L12:
       mov       r10d,4
       test      r9d,r9d
       jle       near ptr M01_L02
M01_L13:
       dec       r9d
       movsx     rax,word ptr [rcx+r10*2]
       movsx     r11,dx
       cmp       eax,r11d
       je        short M01_L14
       movsx     r11,r8w
       cmp       eax,r11d
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L15
M01_L14:
       mov       eax,r10d
       jmp       near ptr M01_L03
M01_L15:
       inc       r10
M01_L16:
       test      r9d,r9d
       jg        short M01_L13
       jmp       near ptr M01_L02
M01_L17:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm2,0D8
       vpmovmskb r9d,ymm0
       xor       ecx,ecx
       tzcnt     ecx,r9d
       add       eax,ecx
       jmp       near ptr M01_L03
M01_L18:
       vpermq    ymm0,ymm0,0D8
       vpmovmskb r8d,ymm0
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M01_L19
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M01_L19:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M01_L03
M01_L20:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb xmm1,xmm1
       lea       eax,[r9-8]
       movsxd    r9,eax
       lea       rax,[rcx+r9*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm2,[rdx]
       vpackuswb xmm2,xmm2,[rax]
       vpcmpeqb  xmm0,xmm0,xmm2
       vpcmpeqb  xmm1,xmm1,xmm2
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M01_L02
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M01_L21
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M01_L21:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       near ptr M01_L03
; Total bytes of code 582
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathHasInvalidCharsValid()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+1B8]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L08
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L10
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L01:
       test      rsi,rsi
       jne       near ptr M00_L07
       xor       eax,eax
       xor       ecx,ecx
M00_L02:
       mov       rdx,261E18001C0
       mov       rdx,[rdx]
       mov       r8,rax
       mov       r10d,ecx
       add       rdx,8
       mov       r9,r8
       cmp       r10d,8
       jl        near ptr M00_L13
       cmp       r10d,10
       jle       near ptr M00_L20
       vmovups   ymm0,[rdx]
       cmp       r10d,20
       jle       short M00_L04
       lea       edx,[r10-20]
       movsxd    rcx,edx
       lea       rax,[r8+rcx*2]
       vbroadcastss ymm1,dword ptr [7FFD980D4000]
M00_L03:
       vpminuw   ymm2,ymm1,[r9]
       vpminuw   ymm3,ymm1,[r9+20]
       vpackuswb ymm2,ymm2,ymm3
       vpshufb   ymm3,ymm0,ymm2
       vpsrld    ymm2,ymm2,4
       vpand     ymm2,ymm2,[7FFD980D4020]
       vbroadcastsd ymm4,qword ptr [7FFD980D4040]
       vpshufb   ymm2,ymm4,ymm2
       vpand     ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       near ptr M00_L17
       add       r9,40
       cmp       r9,rax
       jb        short M00_L03
M00_L04:
       add       r10d,0FFFFFFF0
       movsxd    rax,r10d
       lea       rax,[r8+rax*2]
       cmp       r9,rax
       cmova     r9,rax
       vbroadcastss ymm1,dword ptr [7FFD980D4000]
       vpminuw   ymm2,ymm1,[r9]
       vpminuw   ymm1,ymm1,[rax]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFD980D4020]
       vbroadcastsd ymm2,qword ptr [7FFD980D4040]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M00_L18
M00_L05:
       mov       eax,0FFFFFFFF
M00_L06:
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L07:
       lea       rax,[rsi+0C]
       mov       ecx,[rsi+8]
       jmp       near ptr M00_L02
M00_L08:
       call      qword ptr [7FFD97DB5548]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFD9806DCF8]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2A260837DF8
       call      qword ptr [7FFD98064288]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      qword ptr [7FFD98066C70]
       test      eax,eax
       jne       short M00_L12
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFD98066C70]
       test      eax,eax
       je        near ptr M00_L01
M00_L12:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFD9806CD80]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L13:
       mov       eax,ecx
       lea       rax,[r8+rax*2]
       cmp       r8,rax
       je        near ptr M00_L05
M00_L14:
       movzx     ecx,word ptr [r9]
       cmp       [rdx],dl
       lea       r10,[rdx+20]
       cmp       ecx,100
       jge       short M00_L15
       cmp       [r10],r10b
       mov       r11d,ecx
       sar       r11d,5
       mov       r10d,[r10+r11*4]
       bt        r10d,ecx
       jb        short M00_L16
M00_L15:
       add       r9,2
       cmp       r9,rax
       jne       short M00_L14
       jmp       near ptr M00_L05
M00_L16:
       mov       rax,r9
       sub       rax,r8
       shr       rax,1
       jmp       near ptr M00_L06
M00_L17:
       mov       rax,r9
       sub       rax,r8
       shr       rax,1
       vpermq    ymm1,ymm2,0D8
       vxorps    ymm0,ymm0,ymm0
       vpcmpeqb  ymm0,ymm0,ymm1
       vpmovmskb r10d,ymm0
       mov       r8d,r10d
       not       r8d
       xor       ecx,ecx
       tzcnt     ecx,r8d
       add       eax,ecx
       jmp       near ptr M00_L06
M00_L18:
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb ecx,ymm0
       not       ecx
       tzcnt     ecx,ecx
       cmp       ecx,10
       jl        short M00_L19
       mov       r9,rax
       add       ecx,0FFFFFFF0
M00_L19:
       sub       r9,r8
       shr       r9,1
       lea       eax,[r9+rcx]
       jmp       near ptr M00_L06
M00_L20:
       vmovups   xmm0,[rdx]
       add       ecx,0FFFFFFF8
       movsxd    r8,ecx
       lea       rdx,[rax+r8*2]
       cmp       rax,rdx
       mov       rcx,rax
       cmova     rcx,rdx
       vmovups   xmm1,[rcx]
       vpminuw   xmm1,xmm1,[7FFD980D4050]
       vmovups   xmm2,[rdx]
       vpminuw   xmm2,xmm2,[7FFD980D4050]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFD980D4020]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFD980D4040]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M00_L05
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb r8d,xmm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M00_L21
       mov       rcx,rdx
       add       r8d,0FFFFFFF8
M00_L21:
       sub       rcx,rax
       shr       rcx,1
       lea       eax,[rcx+r8]
       jmp       near ptr M00_L06
; Total bytes of code 854
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathSeparators()
       push      rbx
       sub       rsp,10
       mov       rdx,1D941C001A0
       mov       rdx,[rdx]
       mov       [rsp+8],rdx
       mov       rbx,[rcx+90]
       mov       rdx,[rsp+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 56
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+1B8]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L04
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       mov       rax,7FFDD1CB6BF0
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
       call      00007FFDF76352E0
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       edi,r13d
       ja        near ptr M00_L10
       lea       r8,[rbp+rbp]
       mov       rcx,r15
       mov       rdx,rsi
       call      qword ptr [7FFD97995818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFD97DB49A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFD980660D0]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,25E7BC17DF8
       call      qword ptr [7FFD98065248]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFD98064EA0]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFD98064EA0]
       test      eax,eax
       je        near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFD98064EB8]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L09:
       mov       r14,25E7BC10008
       jmp       near ptr M00_L02
M00_L10:
       call      qword ptr [7FFD97DBD158]
       int       3
M00_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 459
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
       jbe       short M01_L05
       cmp       r8,800
       ja        near ptr M01_L10
       cmp       r8,100
       jae       near ptr M01_L08
M01_L02:
       mov       r9,r8
       shr       r9,6
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
       ja        short M01_L05
M01_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L05:
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
       jmp       short M01_L04
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
       jmp       near ptr M01_L02
M01_L09:
       cmp       rcx,rdx
       jne       short M01_L10
       cmp       [rdx],dl
       jmp       near ptr M01_L00
M01_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFD979966E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 335
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.HasInvalidFilterChars()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+38]
       xor       ecx,ecx
       test      rsi,rsi
       cmove     rsi,rcx
       mov       rdi,offset MT_System.String
       mov       rcx,rdi
       mov       edx,1
       call      00007FFDF76352E0
       mov       rbp,rax
       mov       word ptr [rbp+0C],5C
       test      rsi,rsi
       je        near ptr M00_L08
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M00_L08
       mov       r15d,[rbp+8]
       test      r15d,r15d
       je        near ptr M00_L09
       mov       r13d,r14d
       lea       edx,[r15+r13]
       test      edx,edx
       jl        near ptr M00_L10
       movsxd    rdx,edx
       mov       rcx,rdi
       call      00007FFDF76352E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFD979B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r13d
       lea       rcx,[rdi+rcx*2+0C]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FFD979B5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L00:
       mov       esi,[rdi+8]
       test      esi,esi
       je        near ptr M00_L11
       movzx     ecx,word ptr [rdi+0C]
       cmp       ecx,100
       jge       near ptr M00_L13
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L15
M00_L01:
       dec       esi
       mov       ecx,esi
       movzx     ecx,word ptr [rdi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L14
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L15
M00_L02:
       test      rdi,rdi
       jne       near ptr M00_L05
       xor       eax,eax
       xor       ecx,ecx
M00_L03:
       mov       rdx,243784021A0
       mov       rdx,[rdx]
       mov       r8,rax
       mov       r10d,ecx
       add       rdx,8
       mov       r9,r8
       cmp       r10d,8
       jl        near ptr M00_L16
       cmp       r10d,10
       jle       near ptr M00_L23
       vmovups   ymm0,[rdx]
       cmp       r10d,20
       jle       near ptr M00_L20
       lea       edx,[r10-20]
       movsxd    rcx,edx
       lea       rax,[r8+rcx*2]
       vbroadcastss ymm1,dword ptr [7FFD97A68290]
       vbroadcastss ymm2,dword ptr [7FFD97A68294]
       vbroadcastsd ymm3,qword ptr [7FFD97A68298]
M00_L04:
       vpminuw   ymm4,ymm1,[r9]
       vpminuw   ymm5,ymm1,[r9+20]
       vpackuswb ymm4,ymm4,ymm5
       vpshufb   ymm5,ymm0,ymm4
       vpsrld    ymm4,ymm4,4
       vpand     ymm4,ymm4,ymm2
       vpshufb   ymm4,ymm3,ymm4
       vpand     ymm4,ymm4,ymm5
       vptest    ymm4,ymm4
       jne       short M00_L06
       add       r9,40
       cmp       r9,rax
       jb        short M00_L04
       jmp       near ptr M00_L20
M00_L05:
       lea       rax,[rdi+0C]
       mov       ecx,[rdi+8]
       jmp       near ptr M00_L03
M00_L06:
       mov       rax,r9
       sub       rax,r8
       shr       rax,1
       vpermq    ymm1,ymm4,0D8
       vxorps    ymm0,ymm0,ymm0
       vpcmpeqb  ymm2,ymm0,ymm1
       vpmovmskb r10d,ymm2
       mov       r8d,r10d
       not       r8d
       xor       ecx,ecx
       tzcnt     ecx,r8d
       add       eax,ecx
M00_L07:
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       mov       r15d,[rbp+8]
       mov       rcx,2840D370008
       test      r15d,r15d
       mov       rdi,rcx
       cmovne    rdi,rbp
       jmp       near ptr M00_L00
M00_L09:
       mov       rdi,rsi
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7FFD98095998]
       int       3
M00_L11:
       call      qword ptr [7FFD97DD49A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L12
       call      qword ptr [7FFD98096E50]
       mov       rbx,rax
M00_L12:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2840D380BC8
       call      qword ptr [7FFD98095FE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      qword ptr [7FFD98095CF8]
       test      eax,eax
       jne       short M00_L15
       jmp       near ptr M00_L01
M00_L14:
       call      qword ptr [7FFD98095CF8]
       test      eax,eax
       je        near ptr M00_L02
M00_L15:
       mov       rcx,rdi
       mov       edx,3
       call      qword ptr [7FFD98095D10]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L16:
       mov       eax,ecx
       lea       rax,[r8+rax*2]
       cmp       r9,rax
       je        near ptr M00_L22
M00_L17:
       movzx     ecx,word ptr [r9]
       cmp       [rdx],dl
       lea       r10,[rdx+20]
       cmp       ecx,100
       jge       short M00_L18
       cmp       [r10],r10b
       mov       r11d,ecx
       sar       r11d,5
       mov       r10d,[r10+r11*4]
       bt        r10d,ecx
       setb      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M00_L19
M00_L18:
       add       r9,2
       cmp       r9,rax
       jne       short M00_L17
       jmp       near ptr M00_L22
M00_L19:
       mov       rax,r9
       sub       rax,r8
       shr       rax,1
       jmp       near ptr M00_L07
M00_L20:
       add       r10d,0FFFFFFF0
       movsxd    rax,r10d
       lea       rax,[r8+rax*2]
       cmp       r9,rax
       cmova     r9,rax
       vbroadcastss ymm1,dword ptr [7FFD97A68290]
       vpminuw   ymm3,ymm1,[r9]
       vpminuw   ymm1,ymm1,[rax]
       vpackuswb ymm1,ymm3,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm2,dword ptr [7FFD97A68294]
       vpand     ymm1,ymm1,ymm2
       vbroadcastsd ymm3,qword ptr [7FFD97A68298]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        short M00_L22
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb ecx,ymm0
       not       ecx
       tzcnt     ecx,ecx
       cmp       ecx,10
       jl        short M00_L21
       mov       r9,rax
       add       ecx,0FFFFFFF0
M00_L21:
       sub       r9,r8
       shr       r9,1
       lea       eax,[r9+rcx]
       jmp       near ptr M00_L07
M00_L22:
       mov       eax,0FFFFFFFF
       jmp       near ptr M00_L07
M00_L23:
       vmovups   xmm0,[rdx]
       add       ecx,0FFFFFFF8
       movsxd    r8,ecx
       lea       rdx,[rax+r8*2]
       cmp       rax,rdx
       mov       rcx,rax
       cmova     rcx,rdx
       vmovups   xmm1,[rcx]
       vpminuw   xmm1,xmm1,[7FFD97A682A0]
       vmovups   xmm2,[rdx]
       vpminuw   xmm2,xmm2,[7FFD97A682A0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFD97A682B0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFD97A68298]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M00_L22
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb r8d,xmm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M00_L24
       mov       rcx,rdx
       add       r8d,0FFFFFFF8
M00_L24:
       sub       rcx,rax
       shr       rcx,1
       lea       eax,[rcx+r8]
       jmp       near ptr M00_L07
; Total bytes of code 1067
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
       jmp       qword ptr [7FFD979B66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 333
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,189AD400178
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 95
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,19821402188
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+20],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+20]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 95
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathContainsWildcard()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+1B0]
       test      rsi,rsi
       je        near ptr M00_L04
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L04
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L06
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L07
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L08
M00_L01:
       test      rsi,rsi
       jne       short M00_L03
       xor       ecx,ecx
       xor       r9d,r9d
M00_L02:
       mov       r8,1FEFF802190
       mov       rdx,[r8]
       movsx     r8,word ptr [rdx+0A]
       movsx     rdx,word ptr [rdx+8]
       call      qword ptr [7FFD97BEC630]; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       lea       rcx,[rsi+0C]
       mov       r9d,[rsi+8]
       jmp       short M00_L02
M00_L04:
       call      qword ptr [7FFD97DE49A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L05
       call      qword ptr [7FFD980B70D8]
       mov       rbx,rax
M00_L05:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,23F94867DF8
       call      qword ptr [7FFD980B5FF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       call      qword ptr [7FFD980B5D10]
       test      eax,eax
       jne       short M00_L08
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFD980B5D10]
       test      eax,eax
       je        near ptr M00_L01
M00_L08:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFD980B5D28]
       mov       rsi,rax
       jmp       near ptr M00_L01
; Total bytes of code 309
```
```assembly
; System.PackedSpanHelpers.IndexOfAny[[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib],[System.PackedSpanHelpers+NopTransform, System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int32)
       push      rbx
       cmp       r9d,8
       jl        near ptr M01_L05
       mov       rax,rcx
       cmp       r9d,10
       jle       near ptr M01_L21
       vmovd     xmm0,edx
       vpbroadcastb ymm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb ymm1,xmm1
       cmp       r9d,20
       jle       short M01_L01
       lea       edx,[r9-20]
       movsxd    r8,edx
       lea       rdx,[rax+r8*2]
       vmovups   ymm2,[rcx]
       vpackuswb ymm2,ymm2,[rcx+20]
       vpcmpeqb  ymm3,ymm2,ymm0
       vpcmpeqb  ymm2,ymm2,ymm1
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       near ptr M01_L20
       nop       dword ptr [rax]
M01_L00:
       add       rax,40
       cmp       rax,rdx
       jae       short M01_L01
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rax+20]
       vpcmpeqb  ymm3,ymm2,ymm0
       vpcmpeqb  ymm2,ymm2,ymm1
       vpor      ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       je        short M01_L00
       jmp       near ptr M01_L20
M01_L01:
       add       r9d,0FFFFFFF0
       movsxd    rdx,r9d
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vmovups   ymm2,[rax]
       vpackuswb ymm2,ymm2,[rdx]
       vpcmpeqb  ymm0,ymm0,ymm2
       vpcmpeqb  ymm1,ymm1,ymm2
       vpor      ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M01_L19
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
       pop       rbx
       ret
M01_L04:
       mov       rax,rdx
       add       r8d,0FFFFFFF0
       jmp       short M01_L02
M01_L05:
       xor       eax,eax
       cmp       r9d,4
       jl        near ptr M01_L17
       add       r9d,0FFFFFFFC
       movsx     r10,word ptr [rcx]
       movsx     r11,dx
       cmp       r10d,r11d
       je        short M01_L06
       movsx     rbx,r8w
       cmp       r10d,ebx
       jne       short M01_L07
M01_L06:
       xor       eax,eax
       vzeroupper
       pop       rbx
       ret
M01_L07:
       movsx     r10,word ptr [rcx+2]
       cmp       r10d,r11d
       je        short M01_L08
       cmp       r10d,ebx
       jne       short M01_L09
M01_L08:
       mov       eax,1
       vzeroupper
       pop       rbx
       ret
M01_L09:
       movsx     r10,word ptr [rcx+4]
       cmp       r10d,r11d
       je        short M01_L10
       cmp       r10d,ebx
       jne       short M01_L11
M01_L10:
       mov       eax,2
       vzeroupper
       pop       rbx
       ret
M01_L11:
       movsx     r10,word ptr [rcx+6]
       cmp       r10d,r11d
       je        short M01_L12
       cmp       r10d,ebx
       jne       short M01_L13
M01_L12:
       mov       eax,3
       jmp       near ptr M01_L03
M01_L13:
       mov       eax,4
       jmp       short M01_L17
M01_L14:
       movsx     rbx,r8w
       cmp       r10d,ebx
       jne       short M01_L16
M01_L15:
       jmp       near ptr M01_L03
M01_L16:
       inc       rax
       test      r9d,r9d
       jg        short M01_L18
       jmp       short M01_L19
M01_L17:
       test      r9d,r9d
       jle       short M01_L19
M01_L18:
       dec       r9d
       movsx     r10,word ptr [rcx+rax*2]
       movsx     r11,dx
       cmp       r10d,r11d
       je        short M01_L15
       jmp       short M01_L14
M01_L19:
       mov       eax,0FFFFFFFF
       jmp       near ptr M01_L03
M01_L20:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm2,0D8
       vpmovmskb r9d,ymm0
       xor       ecx,ecx
       tzcnt     ecx,r9d
       add       eax,ecx
       jmp       near ptr M01_L03
M01_L21:
       vmovd     xmm0,edx
       vpbroadcastb xmm0,xmm0
       vmovd     xmm1,r8d
       vpbroadcastb xmm1,xmm1
       lea       eax,[r9-8]
       movsxd    r9,eax
       lea       rax,[rcx+r9*2]
       cmp       rcx,rax
       mov       rdx,rcx
       cmova     rdx,rax
       vmovups   xmm2,[rdx]
       vpackuswb xmm2,xmm2,[rax]
       vpcmpeqb  xmm0,xmm0,xmm2
       vpcmpeqb  xmm1,xmm1,xmm2
       vpor      xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M01_L19
       vpmovmskb r8d,xmm0
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M01_L22
       mov       rdx,rax
       add       r8d,0FFFFFFF8
M01_L22:
       sub       rdx,rcx
       shr       rdx,1
       lea       eax,[rdx+r8]
       jmp       near ptr M01_L03
; Total bytes of code 550
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathHasInvalidChars()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,[rbx+1A8]
       test      rsi,rsi
       je        near ptr M00_L08
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L08
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L10
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L00:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L11
       mov       rax,7FFDD1CB6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L12
M00_L01:
       test      rsi,rsi
       jne       near ptr M00_L04
       xor       eax,eax
       xor       ecx,ecx
M00_L02:
       mov       rdx,22A5FC021B0
       mov       rdx,[rdx]
       mov       r8,rax
       mov       r10d,ecx
       add       rdx,8
       mov       r9,r8
       cmp       r10d,8
       jl        near ptr M00_L13
       cmp       r10d,10
       jle       near ptr M00_L20
       vmovups   ymm0,[rdx]
       cmp       r10d,20
       jle       near ptr M00_L05
       lea       edx,[r10-20]
       movsxd    rcx,edx
       lea       rax,[r8+rcx*2]
       vbroadcastss ymm1,dword ptr [7FFD97A67960]
       vpminuw   ymm2,ymm1,[r8]
       vpminuw   ymm3,ymm1,[r8+20]
       vpackuswb ymm2,ymm2,ymm3
       vpshufb   ymm3,ymm0,ymm2
       vpsrld    ymm2,ymm2,4
       vbroadcastss ymm4,dword ptr [7FFD97A67964]
       vpand     ymm2,ymm2,ymm4
       vbroadcastsd ymm5,qword ptr [7FFD97A67968]
       vpshufb   ymm2,ymm5,ymm2
       vpand     ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       jne       near ptr M00_L17
M00_L03:
       add       r9,40
       cmp       r9,rax
       jae       short M00_L05
       vpminuw   ymm2,ymm1,[r9]
       vpminuw   ymm3,ymm1,[r9+20]
       vpackuswb ymm2,ymm2,ymm3
       vpshufb   ymm3,ymm0,ymm2
       vpsrld    ymm2,ymm2,4
       vpand     ymm2,ymm2,ymm4
       vpshufb   ymm2,ymm5,ymm2
       vpand     ymm2,ymm2,ymm3
       vptest    ymm2,ymm2
       je        short M00_L03
       jmp       near ptr M00_L17
M00_L04:
       lea       rax,[rsi+0C]
       mov       ecx,[rsi+8]
       jmp       near ptr M00_L02
M00_L05:
       add       r10d,0FFFFFFF0
       movsxd    rax,r10d
       lea       rax,[r8+rax*2]
       cmp       r9,rax
       cmova     r9,rax
       vbroadcastss ymm1,dword ptr [7FFD97A67960]
       vpminuw   ymm5,ymm1,[r9]
       vpminuw   ymm1,ymm1,[rax]
       vpackuswb ymm1,ymm5,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vbroadcastss ymm4,dword ptr [7FFD97A67964]
       vpand     ymm1,ymm1,ymm4
       vbroadcastsd ymm5,qword ptr [7FFD97A67968]
       vpshufb   ymm1,ymm5,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M00_L19
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb ecx,ymm0
       not       ecx
       tzcnt     ecx,ecx
       cmp       ecx,10
       jge       near ptr M00_L18
M00_L06:
       sub       r9,r8
       shr       r9,1
       lea       eax,[r9+rcx]
M00_L07:
       not       eax
       shr       eax,1F
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       vzeroupper
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L08:
       call      qword ptr [7FFD97DD49A8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L09
       call      qword ptr [7FFD98096D00]
       mov       rbx,rax
M00_L09:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26AF4A27DF8
       call      qword ptr [7FFD98095FB0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       call      qword ptr [7FFD98095CC8]
       test      eax,eax
       jne       short M00_L12
       jmp       near ptr M00_L00
M00_L11:
       call      qword ptr [7FFD98095CC8]
       test      eax,eax
       je        near ptr M00_L01
M00_L12:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FFD98095CE0]
       mov       rsi,rax
       jmp       near ptr M00_L01
M00_L13:
       mov       eax,ecx
       lea       rax,[r8+rax*2]
       cmp       r8,rax
       je        short M00_L19
M00_L14:
       movzx     ecx,word ptr [r9]
       cmp       [rdx],dl
       lea       r10,[rdx+20]
       cmp       ecx,100
       jge       short M00_L15
       cmp       [r10],r10b
       mov       r11d,ecx
       sar       r11d,5
       mov       r10d,[r10+r11*4]
       bt        r10d,ecx
       jb        short M00_L16
M00_L15:
       add       r9,2
       cmp       r9,rax
       jne       short M00_L14
       jmp       short M00_L19
M00_L16:
       mov       rax,r9
       sub       rax,r8
       shr       rax,1
       jmp       near ptr M00_L07
M00_L17:
       mov       rax,r9
       sub       rax,r8
       shr       rax,1
       vpermq    ymm1,ymm2,0D8
       vxorps    ymm0,ymm0,ymm0
       vpcmpeqb  ymm4,ymm0,ymm1
       vpmovmskb r10d,ymm4
       mov       r8d,r10d
       not       r8d
       xor       ecx,ecx
       tzcnt     ecx,r8d
       add       eax,ecx
       jmp       near ptr M00_L07
M00_L18:
       mov       r9,rax
       add       ecx,0FFFFFFF0
       jmp       near ptr M00_L06
M00_L19:
       mov       eax,0FFFFFFFF
       jmp       near ptr M00_L07
M00_L20:
       vmovups   xmm0,[rdx]
       add       ecx,0FFFFFFF8
       movsxd    r8,ecx
       lea       rdx,[rax+r8*2]
       cmp       rax,rdx
       mov       rcx,rax
       cmova     rcx,rdx
       vmovups   xmm1,[rcx]
       vpminuw   xmm1,xmm1,[7FFD97A67970]
       vmovups   xmm2,[rdx]
       vpminuw   xmm2,xmm2,[7FFD97A67970]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFD97A67980]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFD97A67968]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        short M00_L19
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb r8d,xmm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,8
       jl        short M00_L21
       mov       rcx,rdx
       add       r8d,0FFFFFFF8
M00_L21:
       sub       rcx,rax
       shr       rcx,1
       lea       eax,[rcx+r8]
       jmp       near ptr M00_L07
; Total bytes of code 916
```

