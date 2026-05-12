## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,[rbx+150]
       test      rcx,rcx
       je        near ptr M00_L08
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M00_L00:
       test      edi,edi
       je        near ptr M00_L09
       xor       ebp,ebp
       xor       r14d,r14d
       jmp       short M00_L04
M00_L01:
       mov       rcx,r15
       call      qword ptr [7FFB2BB1F618]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        short M00_L05
       cmp       dword ptr [r15+28],0FFFFFFFF
       je        short M00_L10
M00_L02:
       cmp       dword ptr [r15+28],0
       jne       near ptr M00_L12
       test      byte ptr [r15+30],10
       jne       short M00_L11
       cmp       dword ptr [r15+28],0
       jne       near ptr M00_L12
       mov       ecx,[r15+4C]
       shl       rcx,20
       mov       eax,[r15+50]
       or        rcx,rax
M00_L03:
       add       rbp,rcx
       jo        near ptr M00_L13
       inc       r14d
       cmp       r14d,edi
       jge       short M00_L06
M00_L04:
       mov       r15,[rsi+r14*8]
       test      r15,r15
       jne       short M00_L01
M00_L05:
       xor       ecx,ecx
       jmp       short M00_L03
M00_L06:
       mov       rax,rbp
M00_L07:
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
M00_L08:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L00
M00_L09:
       xor       eax,eax
       jmp       short M00_L07
M00_L10:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [r15+30],ymm0
       vmovdqu   xmmword ptr [r15+44],xmm0
       mov       rcx,r15
       call      qword ptr [7FFB2BDDCE88]
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFB2BDDCEA0]
       mov       rcx,rax
       mov       rdx,[r15+8]
       call      qword ptr [7FFB2BCCEB08]
       mov       rdx,rax
       mov       r8,[r15+8]
       mov       rcx,rbp
       call      qword ptr [7FFB2BDDCEB8]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       mov       ecx,[r15+28]
       mov       rdx,[r15+8]
       xor       r8d,r8d
       call      qword ptr [7FFB2BDDC6D8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 308
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
       mov       rax,71FFFCFAE18F
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
       call      00007FFB2B728C90
       lea       rdx,[rbp-294]
       mov       ecx,1
       call      00007FFB2B728CA8
       mov       esi,eax
       call      00007FFB2B728CC0
       mov       ecx,eax
       call      00007FFB8B3B6D50
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
       call      qword ptr [7FFB2B9CFEB8]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
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
       call      00007FFB2B728C90
       mov       rcx,rsi
       mov       r8,r13
       xor       edx,edx
       call      00007FFB2B728CD8
       mov       esi,eax
       call      00007FFB2B728CC0
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFB8B3B6D50
       test      esi,esi
       jne       near ptr M01_L11
       call      00007FFB8B3B6D30
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFB2BD562C8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L11
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFB2BD56340]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L07:
       xor       esi,esi
       jmp       short M01_L05
M01_L08:
       lea       rcx,[rbp-288]
       mov       edx,250
       call      qword ptr [7FFB2B7357E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-288]
       mov       rcx,r15
       call      qword ptr [7FFB2BDDCF78]
       mov       [rbp-2D0],rax
       mov       rcx,[rbp-2D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2B8A7810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L09
       call      00007FFB8B3B6D30
       mov       r14d,eax
       jmp       short M01_L10
M01_L09:
       xor       r14d,r14d
       lea       rdx,[rbp-288]
       mov       rcx,rdi
       call      qword ptr [7FFB2BDDCF90]
       nop
M01_L10:
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFB2B73DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFB2B905590]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L11:
       cmp       byte ptr [rbp-2B4],0
       je        short M01_L12
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFB2B728C90
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFB2B728CA8
       call      00007FFB2B728CC0
       mov       ecx,eax
       call      00007FFB8B3B6D50
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
       call      qword ptr [7FFB2BD562F8]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r15d
       je        near ptr M01_L01
       mov       r8d,r13d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB2B9C7450]; System.String.Substring(Int32, Int32)
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L22:
       cmp       r14d,15
       jne       near ptr M01_L13
       jmp       short M01_L17
M01_L23:
       mov       eax,[rbp-28C]
       mov       r8,71FFFCFAE18F
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
       call      qword ptr [7FFB2B73DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFB2B905590]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFB2B728C90
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFB2B728CA8
       call      00007FFB2B728CC0
       mov       ecx,eax
       call      00007FFB8B3B6D50
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.FileHasInvalidChars()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,70
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rax,0CEE5F53E4118
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       rsi,[rbx+140]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L10
M00_L00:
       mov       r8,1A3890021D0
       mov       r8,[r8]
       cmp       [rax],al
       lea       rsi,[rax+0C]
       mov       edi,[rax+8]
       add       r8,10
       mov       edx,edi
       mov       rbp,r8
       cmp       edx,8
       jl        near ptr M00_L05
       cmp       edx,14
       jl        near ptr M00_L05
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+20],ymm0
       vmovdqu   ymmword ptr [rsp+40],ymm0
       xor       ecx,ecx
       mov       eax,29
M00_L01:
       movzx     r10d,word ptr [r8+rcx]
       cmp       r10d,7F
       jg        near ptr M00_L12
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
       jne       short M00_L01
       movzx     r8d,byte ptr [rsp+20]
       and       r8d,1
       vmovdqu   xmm0,xmmword ptr [rsp+20]
       vmovaps   ymm1,ymm0
       vinserti128 ymm0,ymm1,xmm0,1
       vmovups   [rsp+20],ymm0
       test      r8b,1
       jne       short M00_L04
       lea       r8,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FFB2B8EF300]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L02:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,0CEE5F53E4118
       cmp       [rsp+68],r8
       je        short M00_L03
       call      CORINFO_HELP_FAIL_FAST
M00_L03:
       nop
       vzeroupper
       add       rsp,70
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L04:
       lea       r8,[rsp+20]
       mov       rcx,rsi
       call      qword ptr [7FFB2BD3E970]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       jmp       short M00_L02
M00_L05:
       mov       edx,edi
       lea       rdi,[rsi+rdx*2]
       mov       r14,rsi
       cmp       rsi,rdi
       je        short M00_L07
M00_L06:
       movzx     edx,word ptr [r14]
       movsx     rdx,dx
       mov       rcx,rbp
       mov       r8d,29
       call      qword ptr [7FFB2B9AF048]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M00_L11
       add       r14,2
       cmp       r14,rdi
       jne       short M00_L06
M00_L07:
       mov       eax,0FFFFFFFF
M00_L08:
       jmp       near ptr M00_L02
M00_L09:
       call      qword ptr [7FFB2BCAF2B8]
       mov       ecx,77D
       mov       rdx,7FFB2BD8C9D8
       call      qword ptr [7FFB2B71F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB2BD8C9D8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB2BDE7C90]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB2BDE6C58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       rcx,[rsi+10]
       call      qword ptr [7FFB2BDE6760]
       mov       rdi,rax
       lea       rcx,[rsi+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
       jmp       near ptr M00_L00
M00_L11:
       mov       rax,r14
       sub       rax,rsi
       shr       rax,1
       jmp       near ptr M00_L08
M00_L12:
       mov       rcx,rsi
       mov       r9d,29
       call      qword ptr [7FFB2BDE6BC8]
       jmp       near ptr M00_L02
; Total bytes of code 607
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
       call      qword ptr [7FFB2B8EF558]
       mov       ecx,eax
       call      qword ptr [7FFB2B8EF570]
       test      eax,eax
       je        short M01_L02
       mov       rcx,7FFB2B97BD58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFB2B8EF588]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,7FFB2B97BD5C
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
       mov       rcx,7FFB2B97BD60
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB2B8EF5A0]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       call      qword ptr [7FFB2B8EF450]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M01_L09
       mov       rcx,7FFB2B97BD64
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2B8EF510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L08:
       mov       rcx,7FFB2B97BD68
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L15
M01_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M01_L11
       mov       rcx,7FFB2B97BD6C
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
       mov       rcx,7FFB2B97BD70
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L06
M01_L12:
       mov       rcx,7FFB2B97BD74
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
       call      qword ptr [7FFB2B8EF450]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M01_L14
       mov       rcx,7FFB2B97BD78
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2B8EF498]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L14:
       mov       rcx,7FFB2B97BD7C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB2B8EF5A0]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       mov       rcx,7FFB2B97BD80
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
       call      qword ptr [7FFB2B8EF3C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M01_L18
       mov       rcx,7FFB2B97BD84
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFB2B8EF408]
       mov       [rbp-23C],eax
       jmp       short M01_L19
M01_L18:
       mov       rcx,7FFB2B97BD88
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFB2B8EF5A0]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jl        short M02_L02
       cmp       edx,10
       jle       near ptr M02_L11
       vmovups   ymm0,[r8]
       cmp       edx,20
       jg        near ptr M02_L06
M02_L00:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rdx,[rcx+rdx*2]
       cmp       rax,rdx
       cmova     rax,rdx
       vbroadcastss ymm1,dword ptr [7FFB2BE62F60]
       vpminuw   ymm2,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB2BE62F80]
       vbroadcastsd ymm2,qword ptr [7FFB2BE62FA0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       jne       near ptr M02_L09
M02_L01:
       mov       eax,0FFFFFFFF
       vzeroupper
       ret
M02_L02:
       movsxd    rdx,edx
       lea       rdx,[rax+rdx*2]
       cmp       rax,rdx
       je        short M02_L01
M02_L03:
       movzx     r10d,word ptr [rax]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       short M02_L04
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       setb      r10b
       movzx     r10d,r10b
       test      r10d,r10d
       jne       short M02_L05
M02_L04:
       add       rax,2
       cmp       rax,rdx
       jne       short M02_L03
       jmp       short M02_L01
M02_L05:
       sub       rax,rcx
       shr       rax,1
       jmp       near ptr M02_L13
M02_L06:
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M02_L07:
       vbroadcastss ymm1,dword ptr [7FFB2BE62F60]
       vpminuw   ymm2,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rax+20]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFB2BE62F80]
       vbroadcastsd ymm3,qword ptr [7FFB2BE62FA0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vptest    ymm1,ymm1
       jne       short M02_L08
       add       rax,40
       cmp       rax,r8
       jb        short M02_L07
       jmp       near ptr M02_L00
M02_L08:
       sub       rax,rcx
       shr       rax,1
       vpermq    ymm0,ymm1,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb ecx,ymm0
       not       ecx
       tzcnt     ecx,ecx
       add       eax,ecx
       jmp       near ptr M02_L13
M02_L09:
       vpermq    ymm0,ymm0,0D8
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vpmovmskb r8d,ymm0
       not       r8d
       tzcnt     r8d,r8d
       cmp       r8d,10
       jl        short M02_L10
       mov       rax,rdx
       add       r8d,0FFFFFFF0
M02_L10:
       sub       rax,rcx
       shr       rax,1
       add       eax,r8d
       jmp       near ptr M02_L13
M02_L11:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       movsxd    rdx,eax
       lea       rax,[rcx+rdx*2]
       cmp       rcx,rax
       mov       r8,rcx
       cmova     r8,rax
       vmovups   xmm1,[r8]
       vpminuw   xmm1,xmm1,[7FFB2BE62FB0]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FFB2BE62FB0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFB2BE62F80]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFB2BE62FA0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M02_L01
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vpmovmskb edx,xmm0
       not       edx
       tzcnt     edx,edx
       cmp       edx,8
       jl        short M02_L12
       mov       r8,rax
       add       edx,0FFFFFFF8
M02_L12:
       sub       r8,rcx
       shr       r8,1
       lea       eax,[r8+rdx]
M02_L13:
       vzeroupper
       ret
; Total bytes of code 536
```
```assembly
; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vmovaps   [rsp+30],xmm6
       vmovaps   [rsp+20],xmm7
       mov       rsi,rcx
       mov       edi,edx
       mov       ebx,r8d
       cmp       ebx,8
       jl        near ptr M03_L06
       cmp       ebx,10
       jl        near ptr M03_L04
       vmovd     xmm6,edi
       vpbroadcastw ymm6,xmm6
       lea       ecx,[rbx-10]
       lea       rdi,[rsi+rcx*2]
       vpcmpeqw  ymm0,ymm6,[rsi]
       vptest    ymm0,ymm0
       jne       near ptr M03_L25
M03_L00:
       add       rsi,20
       cmp       rsi,rdi
       ja        short M03_L01
       mov       rcx,7FFB2BE25108
       vextractf128 xmm7,ymm6,1
       call      CORINFO_HELP_COUNTPROFILE32
       vinsertf128 ymm6,ymm6,xmm7,1
       vpcmpeqw  ymm0,ymm6,[rsi]
       vptest    ymm0,ymm0
       jne       near ptr M03_L25
       jmp       short M03_L00
M03_L01:
       mov       ecx,ebx
       test      cl,0F
       je        short M03_L03
       vpcmpeqw  ymm0,ymm6,[rdi]
       vptest    ymm0,ymm0
       jne       near ptr M03_L26
       mov       rcx,7FFB2BE25100
       call      CORINFO_HELP_COUNTPROFILE32
M03_L02:
       mov       rcx,7FFB2BE25120
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       vzeroupper
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L03:
       mov       rcx,7FFB2BE25104
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L02
M03_L04:
       mov       rcx,7FFB2BE250F4
       call      CORINFO_HELP_COUNTPROFILE32
       vmovd     xmm6,edi
       vpbroadcastw xmm6,xmm6
       lea       ecx,[rbx-8]
       lea       rdi,[rsi+rcx*2]
       vpcmpeqw  xmm0,xmm6,[rsi]
       vptest    xmm0,xmm0
       jne       near ptr M03_L28
M03_L05:
       add       rsi,10
       cmp       rsi,rdi
       jbe       near ptr M03_L27
       mov       ecx,ebx
       test      cl,7
       je        near ptr M03_L30
       vpcmpeqw  xmm0,xmm6,[rdi]
       vptest    xmm0,xmm0
       jne       near ptr M03_L29
       mov       rcx,7FFB2BE25114
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L02
M03_L06:
       mov       rcx,7FFB2BE250B0
       call      CORINFO_HELP_COUNTPROFILE32
       xor       ebp,ebp
       cmp       ebx,8
       jge       near ptr M03_L14
M03_L07:
       cmp       ebx,4
       jl        near ptr M03_L12
       add       ebx,0FFFFFFFC
       movsx     rcx,word ptr [rsi+rbp*2]
       movsx     rax,di
       cmp       ecx,eax
       je        short M03_L08
       movsx     rcx,word ptr [rsi+rbp*2+2]
       movsx     rax,di
       cmp       ecx,eax
       je        short M03_L11
       movsx     rcx,word ptr [rsi+rbp*2+4]
       movsx     rax,di
       cmp       ecx,eax
       je        short M03_L10
       movsx     rcx,word ptr [rsi+rbp*2+6]
       movsx     rax,di
       cmp       ecx,eax
       jne       near ptr M03_L23
       mov       rcx,7FFB2BE250D8
       call      CORINFO_HELP_COUNTPROFILE32
M03_L08:
       mov       rcx,7FFB2BE250DC
       call      CORINFO_HELP_COUNTPROFILE32
M03_L09:
       mov       eax,1
       vzeroupper
       vmovaps   xmm6,[rsp+30]
       vmovaps   xmm7,[rsp+20]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L10:
       mov       rcx,7FFB2BE250E0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L08
M03_L11:
       mov       rcx,7FFB2BE250E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L08
M03_L12:
       test      ebx,ebx
       jle       near ptr M03_L02
       add       rbp,rbp
M03_L13:
       dec       ebx
       movsx     rcx,word ptr [rsi+rbp]
       movsx     rax,di
       cmp       ecx,eax
       je        near ptr M03_L24
       mov       rcx,7FFB2BE250F0
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbp,2
       test      ebx,ebx
       jg        short M03_L13
       jmp       near ptr M03_L02
M03_L14:
       add       ebx,0FFFFFFF8
       movsx     rcx,word ptr [rsi+rbp*2]
       movsx     rax,di
       cmp       ecx,eax
       je        near ptr M03_L16
       movsx     rcx,word ptr [rsi+rbp*2+2]
       movsx     rax,di
       cmp       ecx,eax
       je        near ptr M03_L22
       movsx     rcx,word ptr [rsi+rbp*2+4]
       movsx     rax,di
       cmp       ecx,eax
       je        near ptr M03_L21
       movsx     rcx,word ptr [rsi+rbp*2+6]
       movsx     rax,di
       cmp       ecx,eax
       je        near ptr M03_L20
       movsx     rcx,word ptr [rsi+rbp*2+8]
       movsx     rax,di
       cmp       ecx,eax
       je        near ptr M03_L19
       movsx     rcx,word ptr [rsi+rbp*2+0A]
       movsx     rax,di
       cmp       ecx,eax
       je        short M03_L18
       movsx     rcx,word ptr [rsi+rbp*2+0C]
       movsx     rax,di
       cmp       ecx,eax
       je        short M03_L17
       movsx     rcx,word ptr [rsi+rbp*2+0E]
       movsx     rax,di
       cmp       ecx,eax
       je        short M03_L15
       mov       rcx,7FFB2BE250D4
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbp,8
       cmp       ebx,8
       jge       near ptr M03_L14
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,7FFB2BE250B4
       call      CORINFO_HELP_COUNTPROFILE32
M03_L16:
       mov       rcx,7FFB2BE250B8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L17:
       mov       rcx,7FFB2BE250BC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L18:
       mov       rcx,7FFB2BE250C0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L19:
       mov       rcx,7FFB2BE250C4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L20:
       mov       rcx,7FFB2BE250C8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L21:
       mov       rcx,7FFB2BE250CC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L22:
       mov       rcx,7FFB2BE250D0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L23:
       mov       rcx,7FFB2BE250E8
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbp,4
       jmp       near ptr M03_L12
M03_L24:
       mov       rcx,7FFB2BE250EC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L25:
       mov       rcx,7FFB2BE250F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L26:
       mov       rcx,7FFB2BE250FC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L27:
       mov       rcx,7FFB2BE2511C
       call      CORINFO_HELP_COUNTPROFILE32
       vpcmpeqw  xmm0,xmm6,[rsi]
       vptest    xmm0,xmm0
       je        near ptr M03_L05
M03_L28:
       mov       rcx,7FFB2BE2510C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L29:
       mov       rcx,7FFB2BE25110
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L30:
       mov       rcx,7FFB2BE25118
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L02
; Total bytes of code 1056
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
       je        near ptr M04_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M04_L01
       test      rsi,rsi
       je        short M04_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M04_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M04_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB8B3B9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M04_L00:
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
M04_L01:
       test      rsi,rsi
       je        short M04_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M04_L03
M04_L02:
       mov       rax,1E41DF70008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M04_L03:
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
M04_L04:
       call      qword ptr [7FFB2BDE5668]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.FileHelperBenchmark.MoveFile()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rcx,[rbx+138]
       mov       rsi,[rcx+8]
       mov       rdi,[rbx+140]
       mov       rbp,[rdi+18]
       test      rbp,rbp
       je        near ptr M00_L09
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L08
       test      rbp,rbp
       je        near ptr M00_L07
       mov       rcx,offset MT_System.IO.FileInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rbp
       call      qword ptr [7FFB2BD35DD0]; System.IO.Path.CombineInternal(System.String, System.String)
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2BD3E3D0]; System.IO.FileInfo..ctor(System.String)
       mov       rsi,[rbx+140]
       test      rsi,rsi
       je        near ptr M00_L10
       mov       rcx,rdi
       call      qword ptr [7FFB2BD3E418]; System.IO.FileInfo.get_Directory()
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2BD3E430]; DotNetTips.Spargine.IO.FileHelper.ValidateFileCreateDestinationDirectory(System.IO.FileInfo, System.IO.DirectoryInfo)
       xor       ebp,ebp
       jmp       short M00_L02
M00_L01:
       add       ebp,1
       jo        near ptr M00_L12
       imul      ecx,ebp,0A
       jo        near ptr M00_L12
       call      qword ptr [7FFB2B71F1B0]; System.Threading.Thread.Sleep(Int32)
       test      ebp,ebp
       jg        short M00_L03
M00_L02:
       mov       rcx,[rsi+8]
       mov       rdx,[rdi+8]
       mov       r8d,1
       call      qword ptr [7FFB2BD3E448]; DotNetTips.Spargine.IO.FileHelper.TryMoveFileOnce(System.String, System.String, Boolean)
       test      eax,eax
       je        short M00_L01
       mov       byte ptr [rdi+2C],0
       mov       rcx,[rdi+8]
       lea       rdx,[rdi+30]
       xor       r8d,r8d
       call      qword ptr [7FFB2B9AF0F0]; System.IO.FileSystem.FillAttributeInfo(System.String, WIN32_FILE_ATTRIBUTE_DATA ByRef, Boolean)
       mov       [rdi+28],eax
       mov       rcx,rdi
       call      qword ptr [7FFB2BB000B8]; System.IO.FileInfo.get_Exists()
M00_L03:
       mov       rbx,[rbx+140]
       test      rbx,rbx
       je        near ptr M00_L11
       mov       rcx,rbx
       call      qword ptr [7FFB2BD3E418]; System.IO.FileInfo.get_Directory()
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2BD3E430]; DotNetTips.Spargine.IO.FileHelper.ValidateFileCreateDestinationDirectory(System.IO.FileInfo, System.IO.DirectoryInfo)
       xor       esi,esi
       jmp       short M00_L05
M00_L04:
       add       esi,1
       jo        near ptr M00_L12
       imul      ecx,esi,0A
       jo        near ptr M00_L12
       call      qword ptr [7FFB2B71F1B0]; System.Threading.Thread.Sleep(Int32)
       test      esi,esi
       jg        short M00_L06
M00_L05:
       mov       rcx,[rdi+8]
       mov       rdx,[rbx+8]
       mov       r8d,1
       call      qword ptr [7FFB2BD3E448]; DotNetTips.Spargine.IO.FileHelper.TryMoveFileOnce(System.String, System.String, Boolean)
       test      eax,eax
       je        short M00_L04
       mov       byte ptr [rbx+2C],0
       mov       rcx,[rbx+8]
       lea       rdx,[rbx+30]
       xor       r8d,r8d
       call      qword ptr [7FFB2B9AF0F0]; System.IO.FileSystem.FillAttributeInfo(System.String, WIN32_FILE_ATTRIBUTE_DATA ByRef, Boolean)
       mov       [rbx+28],eax
       mov       rcx,rbx
       call      qword ptr [7FFB2BB000B8]; System.IO.FileInfo.get_Exists()
M00_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L07:
       mov       ecx,1C488
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       rcx,rax
       call      qword ptr [7FFB2BDB4DF8]
       int       3
M00_L08:
       mov       ecx,1C47C
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       rcx,rax
       call      qword ptr [7FFB2BDB4DF8]
       int       3
M00_L09:
       mov       rcx,[rdi+10]
       call      qword ptr [7FFB2BDB6478]
       mov       rbp,rax
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7FFB2BCAF2B8]
       mov       ecx,77D
       mov       rdx,7FFB2BD8D008
       call      qword ptr [7FFB2B71F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB2BD8D008
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB2BDB6490]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB2BDB64A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L11:
       call      qword ptr [7FFB2BCAF2B8]
       mov       ecx,7B5
       mov       rdx,7FFB2BD8D008
       call      qword ptr [7FFB2B71F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB2BD8D008
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB2BDB6490]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB2BDB64A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 762
```
```assembly
; System.IO.Path.CombineInternal(System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       test      rcx,rcx
       je        near ptr M01_L09
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L09
       test      rdx,rdx
       je        near ptr M01_L08
       mov       ebx,[rdx+8]
       test      ebx,ebx
       je        near ptr M01_L08
       lea       rsi,[rdx+0C]
       mov       rax,rsi
       mov       r8d,ebx
       test      r8d,r8d
       jle       short M01_L00
       movzx     r10d,word ptr [rax]
       cmp       r10d,5C
       je        near ptr M01_L09
       cmp       r10d,2F
       je        near ptr M01_L09
M01_L00:
       cmp       r8d,2
       jl        short M01_L01
       movzx     r8d,word ptr [rax]
       or        r8d,20
       add       r8d,0FFFFFF9F
       cmp       r8d,19
       ja        short M01_L01
       cmp       word ptr [rax+2],3A
       je        near ptr M01_L09
M01_L01:
       lea       rdi,[rcx+0C]
       mov       ebp,[rcx+8]
       lea       edx,[rbp-1]
       cmp       edx,ebp
       jae       near ptr M01_L13
       movzx     edx,word ptr [rdi+rdx*2]
       cmp       edx,5C
       je        near ptr M01_L05
       cmp       edx,2F
       je        near ptr M01_L05
       test      ebx,ebx
       je        near ptr M01_L13
       movzx     edx,word ptr [rsi]
       cmp       edx,5C
       je        near ptr M01_L10
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
M01_L02:
       test      edx,edx
       jne       near ptr M01_L05
       mov       edx,ebp
       add       edx,1
       jo        near ptr M01_L14
       add       edx,ebx
       jo        near ptr M01_L14
       test      edx,edx
       je        short M01_L03
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB8B3B9F20
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        near ptr M01_L12
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r12,r15
       sub       r13d,ebp
       je        near ptr M01_L12
       mov       word ptr [r12],5C
       lea       rcx,[r12+2]
       dec       r13d
       cmp       ebx,r13d
       ja        near ptr M01_L12
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
       jmp       short M01_L04
M01_L03:
       mov       rax,2A2103F0008
M01_L04:
       jmp       short M01_L07
M01_L05:
       mov       edx,ebp
       add       edx,ebx
       jo        near ptr M01_L14
       test      edx,edx
       je        near ptr M01_L11
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB8B3B9F20
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        near ptr M01_L12
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       ebx,r13d
       ja        short M01_L12
       mov       r8d,ebx
       add       r8,r8
       mov       rdx,rsi
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L06:
       mov       rax,r14
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       mov       rax,rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       mov       edx,1
       jmp       near ptr M01_L02
M01_L11:
       mov       r14,2A2103F0008
       jmp       short M01_L06
M01_L12:
       call      qword ptr [7FFB2BB2D3B0]
       int       3
M01_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 561
```
```assembly
; System.IO.FileInfo..ctor(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        short M02_L00
       mov       dword ptr [rbx+28],0FFFFFFFF
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       call      qword ptr [7FFB2B9AF000]; System.IO.Path.GetFullPath(System.String)
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+18],rcx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1C424
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2BA959C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 130
```
```assembly
; System.IO.FileInfo.get_Directory()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M03_L31
       lea       rsi,[rbx+0C]
       mov       rcx,rsi
       mov       edi,[rbx+8]
       mov       eax,edi
       test      eax,eax
       je        near ptr M03_L31
       xor       edx,edx
M03_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M03_L30
       mov       rbp,rsi
       mov       r14d,edi
       mov       r15d,r14d
       xor       r13d,r13d
       cmp       r14d,4
       jl        short M03_L01
       cmp       word ptr [rbp],5C
       je        near ptr M03_L32
M03_L01:
       cmp       r14d,4
       jl        short M03_L05
M03_L02:
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        short M03_L03
       cmp       ecx,2F
       jne       short M03_L05
M03_L03:
       movzx     ecx,word ptr [rbp+2]
       cmp       ecx,5C
       je        short M03_L04
       cmp       ecx,2F
       jne       short M03_L05
M03_L04:
       movzx     ecx,word ptr [rbp+4]
       cmp       ecx,2E
       je        near ptr M03_L11
       cmp       ecx,3F
       je        near ptr M03_L11
M03_L05:
       xor       r12d,r12d
M03_L06:
       test      r12d,r12d
       jne       near ptr M03_L34
       xor       eax,eax
M03_L07:
       movzx     edx,al
       test      r12d,r12d
       sete      cl
       movzx     ecx,cl
       or        ecx,edx
       je        short M03_L08
       test      r15d,r15d
       jle       short M03_L08
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        near ptr M03_L14
       cmp       ecx,2F
       je        near ptr M03_L14
M03_L08:
       test      r12d,r12d
       jne       near ptr M03_L35
       cmp       r14d,2
       jl        short M03_L10
       cmp       r14d,1
       jbe       near ptr M03_L45
       cmp       word ptr [rbp+2],3A
       jne       short M03_L10
       movzx     edx,word ptr [rbp]
       or        edx,20
       add       edx,0FFFFFF9F
       cmp       edx,19
       ja        short M03_L10
       mov       r13d,2
       cmp       r14d,2
       jle       short M03_L10
       cmp       r14d,2
       jbe       near ptr M03_L45
       movzx     edx,word ptr [rbp+4]
       cmp       edx,5C
       je        short M03_L09
       cmp       edx,2F
       jne       short M03_L10
M03_L09:
       inc       r13d
M03_L10:
       mov       edx,r13d
       mov       ecx,r14d
       cmp       ecx,edx
       jg        near ptr M03_L22
       mov       r8d,0FFFFFFFF
       jmp       near ptr M03_L27
M03_L11:
       movzx     ecx,word ptr [rbp+6]
       cmp       ecx,5C
       je        short M03_L13
       cmp       ecx,2F
       sete      r12b
       movzx     r12d,r12b
M03_L12:
       jmp       near ptr M03_L06
M03_L13:
       mov       r12d,1
       jmp       short M03_L12
M03_L14:
       test      edx,edx
       jne       short M03_L17
       cmp       r15d,1
       jle       short M03_L16
       movzx     edx,word ptr [rbp+2]
       cmp       edx,5C
       je        short M03_L15
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M03_L16
M03_L15:
       mov       edx,2
       jmp       short M03_L18
M03_L16:
       mov       r13d,1
       jmp       short M03_L10
M03_L17:
       mov       edx,8
M03_L18:
       mov       r13d,edx
       mov       edx,2
       jmp       short M03_L21
M03_L19:
       dec       edx
       test      edx,edx
       jle       short M03_L10
M03_L20:
       inc       r13d
M03_L21:
       cmp       r13d,r14d
       jge       near ptr M03_L10
       mov       ecx,r13d
       movzx     ecx,word ptr [rbp+rcx*2]
       cmp       ecx,5C
       je        short M03_L19
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M03_L20
       jmp       short M03_L19
M03_L22:
       dec       ecx
       cmp       ecx,r14d
       jae       near ptr M03_L45
       mov       eax,ecx
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,5C
       je        short M03_L23
       cmp       eax,2F
       je        short M03_L23
       cmp       ecx,edx
       jg        short M03_L22
M03_L23:
       cmp       ecx,edx
       jle       short M03_L26
M03_L24:
       lea       eax,[rcx-1]
       cmp       eax,r14d
       jae       near ptr M03_L45
       lea       eax,[rcx-1]
       movzx     eax,word ptr [rbp+rax*2]
       cmp       eax,5C
       je        short M03_L25
       cmp       eax,2F
       jne       short M03_L26
M03_L25:
       dec       ecx
       cmp       ecx,edx
       jg        short M03_L24
M03_L26:
       mov       r8d,ecx
M03_L27:
       test      r8d,r8d
       jl        near ptr M03_L31
       cmp       edi,r8d
       jb        near ptr M03_L41
       test      r8d,r8d
       je        near ptr M03_L42
       cmp       edi,r8d
       je        near ptr M03_L43
       mov       ebx,r8d
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFB8B3B9F20
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       rdx,rsi
       lea       r8,[rbx+rbx]
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
M03_L28:
       call      qword ptr [7FFB2BD3E4A8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       rsi,rax
M03_L29:
       test      rsi,rsi
       je        near ptr M03_L44
       mov       rcx,offset MT_System.IO.DirectoryInfo
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+28],0FFFFFFFF
       mov       rcx,rsi
       call      qword ptr [7FFB2B9AF000]; System.IO.Path.GetFullPath(System.String)
       mov       rdi,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       cmove     rdi,rsi
       xor       ecx,ecx
       mov       [rbx+18],rcx
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+54],1
       mov       rax,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L30:
       inc       edx
       cmp       edx,eax
       jl        near ptr M03_L00
M03_L31:
       xor       esi,esi
       jmp       short M03_L29
M03_L32:
       cmp       word ptr [rbp+2],5C
       je        short M03_L33
       cmp       word ptr [rbp+2],3F
       jne       near ptr M03_L01
M03_L33:
       movzx     ecx,word ptr [rbp+4]
       cmp       ecx,3F
       jne       near ptr M03_L01
       cmp       word ptr [rbp+6],5C
       jne       near ptr M03_L02
       mov       r12d,1
       jmp       near ptr M03_L06
M03_L34:
       mov       [rsp+28],rbp
       mov       [rsp+30],r15d
       lea       rcx,[rsp+28]
       call      qword ptr [7FFB2BDB6100]
       jmp       near ptr M03_L07
M03_L35:
       mov       r13d,4
       jmp       short M03_L37
M03_L36:
       inc       r13d
M03_L37:
       cmp       r13d,r14d
       jge       near ptr M03_L10
       mov       edx,r13d
       movzx     edx,word ptr [rbp+rdx*2]
       cmp       edx,5C
       je        short M03_L38
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        short M03_L36
       jmp       short M03_L39
M03_L38:
       cmp       r13d,4
       jle       near ptr M03_L10
       jmp       short M03_L40
M03_L39:
       cmp       r13d,4
       jle       near ptr M03_L10
M03_L40:
       mov       edx,r13d
       movzx     edx,word ptr [rbp+rdx*2]
       cmp       edx,5C
       je        near ptr M03_L09
       cmp       edx,2F
       sete      dl
       movzx     edx,dl
       test      edx,edx
       je        near ptr M03_L10
       jmp       near ptr M03_L09
M03_L41:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB2BDB6058]
       int       3
M03_L42:
       mov       rcx,2A2103F0008
       jmp       near ptr M03_L28
M03_L43:
       mov       rcx,rbx
       jmp       near ptr M03_L28
M03_L44:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L45:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 999
```
```assembly
; DotNetTips.Spargine.IO.FileHelper.ValidateFileCreateDestinationDirectory(System.IO.FileInfo, System.IO.DirectoryInfo)
; 		file = file.ArgumentExists();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		destination = destination.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (file.Directory!.FullName.Equals(destination.FullName, StringComparison.OrdinalIgnoreCase))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ExceptionThrower.ThrowInvalidOperationException(Resources.TheDirectoryForTheFileCannotBeTheSameAsThe);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_ = destination.CheckExists(createDirectory: true);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       xor       eax,eax
       mov       [rsp+80],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M04_L16
       mov       rcx,rsi
       call      qword ptr [7FFB2BB000B8]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        near ptr M04_L17
       test      rbx,rbx
       je        near ptr M04_L19
       mov       rsi,[rsi+8]
       test      rsi,rsi
       je        near ptr M04_L21
       lea       rdi,[rsi+0C]
       mov       rcx,rdi
       mov       ebp,[rsi+8]
       mov       eax,ebp
       test      eax,eax
       je        near ptr M04_L21
       xor       edx,edx
M04_L00:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M04_L20
       mov       r14,rdi
       mov       r15d,ebp
       mov       [rsp+20],r14
       mov       [rsp+28],r15d
       lea       rcx,[rsp+20]
       call      qword ptr [7FFB2BD35E78]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       mov       edx,r15d
       cmp       r15d,eax
       jle       short M04_L06
M04_L01:
       dec       edx
       cmp       edx,r15d
       jae       near ptr M04_L29
       mov       ecx,edx
       movzx     ecx,word ptr [r14+rcx*2]
       cmp       ecx,5C
       je        short M04_L02
       cmp       ecx,2F
       je        short M04_L02
       cmp       edx,eax
       jg        short M04_L01
M04_L02:
       cmp       edx,eax
       jle       short M04_L05
M04_L03:
       lea       ecx,[rdx-1]
       cmp       ecx,r15d
       jae       near ptr M04_L29
       lea       ecx,[rdx-1]
       movzx     ecx,word ptr [r14+rcx*2]
       cmp       ecx,5C
       je        short M04_L04
       cmp       ecx,2F
       jne       short M04_L05
M04_L04:
       dec       edx
       cmp       edx,eax
       jg        short M04_L03
M04_L05:
       mov       r8d,edx
       jmp       short M04_L07
M04_L06:
       mov       r8d,0FFFFFFFF
M04_L07:
       test      r8d,r8d
       jl        near ptr M04_L21
       cmp       ebp,r8d
       jb        near ptr M04_L22
       test      r8d,r8d
       je        near ptr M04_L23
       cmp       ebp,r8d
       je        near ptr M04_L24
       mov       esi,r8d
       mov       edx,r8d
       mov       rcx,offset MT_System.String
       call      00007FFB8B3B9F20
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       rdx,rdi
       lea       r8,[rsi+rsi]
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbp
M04_L08:
       call      qword ptr [7FFB2BD3E4A8]; System.IO.PathInternal.NormalizeDirectorySeparators(System.String)
       mov       rdi,rax
M04_L09:
       test      rdi,rdi
       je        near ptr M04_L25
       mov       rcx,offset MT_System.IO.DirectoryInfo
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+58],0FFFFFFFF
       mov       rcx,rdi
       call      qword ptr [7FFB2B9AF000]; System.IO.Path.GetFullPath(System.String)
       mov       [rsp+40],rdi
       test      rax,rax
       cmove     rax,rdi
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       [rsp+38],rax
       mov       byte ptr [rsp+84],1
       lea       rcx,[rsp+30]
M04_L10:
       mov       rcx,[rcx+8]
       mov       rdx,[rbx+8]
       cmp       [rcx],cl
       cmp       rcx,rdx
       je        near ptr M04_L26
       test      rdx,rdx
       je        short M04_L14
       mov       r8d,[rcx+8]
       cmp       r8d,[rdx+8]
       jne       short M04_L14
       add       rcx,0C
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       cmp       r8d,8
       jl        short M04_L12
       cmp       r8d,10
       jl        short M04_L11
       mov       rdx,rax
       call      qword ptr [7FFB2BDB5008]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector256`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       short M04_L13
M04_L11:
       mov       rdx,rax
       call      qword ptr [7FFB2BD3E5B0]; System.Globalization.Ordinal.EqualsIgnoreCase_Vector[[System.Runtime.Intrinsics.Vector128`1[[System.UInt16, System.Private.CoreLib]], System.Private.CoreLib]](Char ByRef, Char ByRef, Int32)
       jmp       short M04_L13
M04_L12:
       mov       rdx,rax
       call      qword ptr [7FFB2BDB5038]
M04_L13:
       test      eax,eax
       jne       near ptr M04_L26
M04_L14:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFB2BD3E5C8]; System.IO.Directory.Exists(System.String)
       test      eax,eax
       je        near ptr M04_L28
M04_L15:
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L16:
       call      qword ptr [7FFB2BCAF2B8]
       mov       ecx,1D2D
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,111F
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB2BDB6490]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB2BDB64A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L17:
       call      qword ptr [7FFB2BD3E550]
       mov       rcx,2A210400D70
       mov       rdx,2A2103F0390
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rcx,rax
       mov       rdx,2A2103F0008
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rsi,[rsi+8]
       test      rbx,rbx
       jne       short M04_L18
       call      qword ptr [7FFB2BD3E550]
       mov       rbx,rax
M04_L18:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FFB2BDB62E0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M04_L19:
       call      qword ptr [7FFB2BCAF2B8]
       mov       ecx,549
       mov       rdx,7FFB2BD8D008
       call      qword ptr [7FFB2B71F228]
       mov       rbx,rax
       mov       ecx,1BEB
       mov       rdx,7FFB2B9E54E8
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB2BD8D008
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2B71D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFB2BDB6490]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFB2BDB64A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L20:
       inc       edx
       cmp       edx,eax
       jl        near ptr M04_L00
M04_L21:
       xor       edi,edi
       jmp       near ptr M04_L09
M04_L22:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB2BDB6058]
       int       3
M04_L23:
       mov       rcx,2A2103F0008
       jmp       near ptr M04_L08
M04_L24:
       mov       rcx,rsi
       jmp       near ptr M04_L08
M04_L25:
       xor       ecx,ecx
       jmp       near ptr M04_L10
M04_L26:
       call      qword ptr [7FFB2BD3E508]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M04_L27
       call      qword ptr [7FFB2BDB64D8]
       mov       rbx,rax
M04_L27:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFB2BA96118]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L28:
       mov       rcx,rbx
       call      qword ptr [7FFB2BD3E5F8]
       mov       rcx,[rbx+8]
       call      qword ptr [7FFB2BD3E5C8]; System.IO.Directory.Exists(System.String)
       jmp       near ptr M04_L15
M04_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1119
```
```assembly
; System.Threading.Thread.Sleep(Int32)
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
       cmp       ecx,0FFFFFFFF
       jge       short M05_L00
       mov       r8,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       r8,[r8]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFB6759C8F8]
       int       3
M05_L00:
       mov       [rbp-94],ecx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB67574030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       ecx,[rbp-94]
       call      qword ptr [rax]
       lea       rcx,[rbp-90]
       call      qword ptr [7FFB67574038]; CORINFO_HELP_JIT_PINVOKE_END
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
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.IO.FileHelper.TryMoveFileOnce(System.String, System.String, Boolean)
; 		if (!replaceExisting && File.Exists(destinationPath))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			throw new IOException($"Cannot move '{sourcePath}' to '{destinationPath}': destination already exists and overwrite is disabled.");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		File.Move(sourcePath, destinationPath, replaceExisting);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return true;
; 		^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,368
       lea       rbp,[rsp+3A0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-360],xmm4
       vmovdqa   xmmword ptr [rbp-350],xmm4
       mov       rax,0FFFFFFFFFFFFFD00
M06_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M06_L00
       mov       rax,9A22B2E04DCD
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       lea       rcx,[rbp-348]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-330],rcx
       mov       rcx,rbp
       mov       [rbp-320],rcx
       test      bl,bl
       je        near ptr M06_L34
M06_L01:
       test      rsi,rsi
       je        near ptr M06_L33
       mov       r15d,[rsi+8]
       test      r15d,r15d
       je        near ptr M06_L33
       test      rdi,rdi
       je        near ptr M06_L32
       cmp       dword ptr [rdi+8],0
       je        near ptr M06_L32
       lea       r13,[rsi+0C]
       mov       rcx,r13
       mov       r8d,r15d
       xor       edx,edx
M06_L02:
       cmp       word ptr [rcx+rdx*2],20
       je        near ptr M06_L43
       mov       rcx,r13
       mov       r8d,r15d
       xor       edx,edx
       call      qword ptr [7FFB2B9AF048]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       test      eax,eax
       jne       near ptr M06_L44
       cmp       r15d,4
       jl        short M06_L03
       cmp       word ptr [r13],5C
       je        near ptr M06_L45
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFB2B9AF090]; System.IO.PathHelper.Normalize(System.String)
       mov       rsi,rax
M06_L04:
       mov       rcx,rdi
       call      qword ptr [7FFB2B9AF000]; System.IO.Path.GetFullPath(System.String)
       mov       [rbp-368],rax
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-2E0],ymm1
       vmovdqu   xmmword ptr [rbp-2CC],xmm1
       xor       r15d,r15d
       test      rsi,rsi
       je        short M06_L06
       mov       r13d,[rsi+8]
       test      r13d,r13d
       je        short M06_L06
       lea       r12d,[r13-1]
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M06_L47
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M06_L05:
       test      ecx,ecx
       jne       near ptr M06_L48
M06_L06:
       mov       r13,rsi
       mov       [rbp-370],rsi
       mov       [rbp-380],r13
M06_L07:
       xor       ecx,ecx
       mov       [rbp-2F0],rcx
       mov       [rbp-2EC],ecx
       mov       rax,7FFC81585FF0
       vzeroupper
       call      rax
       lea       rdx,[rbp-2EC]
       mov       ecx,1
       mov       rax,7FFC8158BE20
       vzeroupper
       call      rax
       mov       esi,eax
       mov       rax,7FFC81585F30
       vzeroupper
       call      rax
       mov       ecx,eax
       call      00007FFB8B3B6D50
       test      esi,esi
       setne     al
       movzx     eax,al
       mov       [rbp-2F0],al
       movzx     eax,byte ptr [rbp-2F0]
       mov       [rbp-34C],al
       mov       eax,[rbp-2EC]
       mov       [rbp-350],eax
       cmp       dword ptr [7FFB8B673A10],0
       jne       near ptr M06_L49
M06_L08:
       mov       r13,[rbp-380]
       test      r13,r13
       je        short M06_L09
       mov       ecx,[r13+8]
       cmp       ecx,104
       jge       near ptr M06_L15
       test      ecx,ecx
       je        short M06_L09
       dec       ecx
       movzx     ecx,word ptr [r13+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L15
       cmp       ecx,2E
       je        near ptr M06_L15
M06_L09:
       mov       [rbp-380],r13
       mov       rax,r13
M06_L10:
       test      rax,rax
       je        near ptr M06_L14
       add       rax,0C
       mov       rsi,rax
M06_L11:
       mov       [rbp-2F8],rsi
       xor       ecx,ecx
       mov       rax,7FFC81585FF0
       vzeroupper
       call      rax
       lea       r8,[rbp-2E0]
       mov       rcx,rsi
       xor       edx,edx
       mov       rax,7FFB2B88EDE8
       mov       [rbp-338],rax
       lea       rax,[M06_L12]
       mov       [rbp-328],rax
       lea       rax,[rbp-348]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC81595090
       vzeroupper
       call      rax
M06_L12:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFB8B673A10],0
       je        short M06_L13
       call      qword ptr [7FFB8B661648]; CORINFO_HELP_STOP_FOR_GC
M06_L13:
       mov       rcx,[rbp-340]
       mov       [r14+8],rcx
       mov       esi,eax
       mov       rax,7FFC81585F30
       vzeroupper
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2F8],rax
       call      00007FFB8B3B6D50
       test      esi,esi
       jne       near ptr M06_L19
       jmp       short M06_L16
M06_L14:
       xor       esi,esi
       jmp       near ptr M06_L11
M06_L15:
       mov       rcx,r13
       call      qword ptr [7FFB2BD35EC0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-380],r13
       jmp       near ptr M06_L10
M06_L16:
       call      00007FFB8B3B6D30
       mov       r15d,eax
       mov       ecx,r15d
       call      qword ptr [7FFB2BD35E48]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M06_L19
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FFB2B7157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-380]
       call      qword ptr [7FFB2BDB6070]
       mov       [rbp-378],rax
       mov       rcx,[rbp-378]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2B887810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M06_L17
       call      00007FFB8B3B6D30
       mov       r15d,eax
       jmp       short M06_L18
M06_L17:
       xor       r15d,r15d
       lea       rcx,[rbp-2E0]
       lea       rdx,[rbp-290]
       call      qword ptr [7FFB2BDB6088]
       nop
M06_L18:
       mov       rcx,[rbp-378]
       mov       edx,1
       call      qword ptr [7FFB2B71DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-378]
       call      qword ptr [7FFB2B8E5590]; System.GC.SuppressFinalize(System.Object)
       nop
M06_L19:
       cmp       byte ptr [rbp-34C],0
       je        short M06_L20
       xor       ecx,ecx
       mov       [rbp-300],ecx
       vzeroupper
       call      00007FFB2B708C00
       lea       rdx,[rbp-300]
       mov       ecx,[rbp-350]
       vzeroupper
       call      00007FFB2B708C18
       vzeroupper
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
M06_L20:
       test      r15d,r15d
       jne       near ptr M06_L50
       cmp       dword ptr [rbp-2E0],0FFFFFFFF
       je        near ptr M06_L50
       test      byte ptr [rbp-2E0],10
       jne       near ptr M06_L50
       mov       rsi,[rbp-370]
       test      rsi,rsi
       je        short M06_L21
       mov       r13d,[rsi+8]
       cmp       r13d,104
       jge       near ptr M06_L51
       test      r13d,r13d
       je        short M06_L21
       lea       r12d,[r13-1]
       cmp       r12d,r13d
       jae       near ptr M06_L54
       mov       ecx,r12d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L51
       cmp       ecx,2E
       je        near ptr M06_L51
M06_L21:
       mov       rdi,rsi
M06_L22:
       mov       rsi,[rbp-368]
       test      rsi,rsi
       je        short M06_L23
       mov       ecx,[rsi+8]
       cmp       ecx,104
       jge       near ptr M06_L52
       test      ecx,ecx
       je        short M06_L23
       lea       eax,[rcx-1]
       cmp       eax,ecx
       jae       near ptr M06_L54
       mov       ecx,eax
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M06_L52
       cmp       ecx,2E
       je        near ptr M06_L52
M06_L23:
       mov       rax,rsi
M06_L24:
       mov       esi,2
       mov       ecx,3
       test      bl,bl
       cmovne    esi,ecx
       test      rax,rax
       je        near ptr M06_L30
       add       rax,0C
       mov       rbx,rax
M06_L25:
       mov       [rbp-308],rbx
       test      rdi,rdi
       je        near ptr M06_L31
       add       rdi,0C
M06_L26:
       mov       [rbp-310],rdi
       xor       ecx,ecx
       mov       rax,7FFC81585FF0
       vzeroupper
       call      rax
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8d,esi
       mov       rax,7FFB2B88F280
       mov       [rbp-338],rax
       lea       rax,[M06_L27]
       mov       [rbp-328],rax
       lea       rax,[rbp-348]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC81590FD0
       vzeroupper
       call      rax
M06_L27:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFB8B673A10],0
       je        short M06_L28
       call      qword ptr [7FFB8B661648]; CORINFO_HELP_STOP_FOR_GC
M06_L28:
       mov       rcx,[rbp-340]
       mov       [r14+8],rcx
       mov       ebx,eax
       mov       rax,7FFC81585F30
       vzeroupper
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-310],rax
       mov       [rbp-308],rax
       call      00007FFB8B3B6D50
       test      ebx,ebx
       je        near ptr M06_L53
       mov       eax,1
       mov       r8,9A22B2E04DCD
       cmp       [rbp-40],r8
       je        short M06_L29
       call      CORINFO_HELP_FAIL_FAST
M06_L29:
       nop
       vzeroupper
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
M06_L30:
       xor       ebx,ebx
       jmp       near ptr M06_L25
M06_L31:
       xor       edi,edi
       jmp       near ptr M06_L26
M06_L32:
       mov       ecx,1C3BA
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2BDB62B0]
       int       3
M06_L33:
       mov       ecx,1C39C
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2BDB62B0]
       int       3
M06_L34:
       mov       rcx,rdi
       call      qword ptr [7FFB2B9AEFE8]; System.IO.File.Exists(System.String)
       test      eax,eax
       je        near ptr M06_L01
       lea       rcx,[rbp-2B8]
       mov       edx,4B
       mov       r8d,2
       call      qword ptr [7FFB2B71C270]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rbp-2A8]
       cmp       ecx,[rbp-298]
       ja        near ptr M06_L39
       mov       rdx,[rbp-2A0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-298]
       sub       eax,ecx
       cmp       eax,0D
       jb        short M06_L35
       vmovups   xmm0,[7FFB2BE25DE0]
       vmovups   [rdx],xmm0
       mov       rcx,2000650076006F
       mov       [rdx+10],rcx
       mov       word ptr [rdx+18],27
       mov       ecx,[rbp-2A8]
       add       ecx,0D
       mov       [rbp-2A8],ecx
       jmp       short M06_L36
M06_L35:
       lea       rcx,[rbp-2B8]
       mov       rdx,2A210400EB8
       call      qword ptr [7FFB2BD37D08]
M06_L36:
       lea       rcx,[rbp-2B8]
       mov       rdx,rsi
       call      qword ptr [7FFB2B9AE370]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-2A8]
       cmp       ecx,[rbp-298]
       ja        short M06_L39
       mov       rdx,[rbp-2A0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-298]
       sub       eax,ecx
       cmp       eax,6
       jb        short M06_L37
       mov       rcx,6F007400200027
       mov       [rdx],rcx
       mov       dword ptr [rdx+8],270020
       mov       ecx,[rbp-2A8]
       add       ecx,6
       mov       [rbp-2A8],ecx
       jmp       short M06_L38
M06_L37:
       lea       rcx,[rbp-2B8]
       mov       rdx,2A210400EE8
       call      qword ptr [7FFB2BD37D08]
M06_L38:
       lea       rcx,[rbp-2B8]
       mov       rdx,rdi
       call      qword ptr [7FFB2B9AE370]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       mov       ecx,[rbp-2A8]
       cmp       ecx,[rbp-298]
       jbe       short M06_L40
M06_L39:
       call      qword ptr [7FFB2B8EF870]
       int       3
M06_L40:
       mov       rdx,[rbp-2A0]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-298]
       sub       eax,ecx
       cmp       eax,38
       jb        short M06_L41
       vmovups   ymm0,[7FFB2BE25E00]
       vmovups   [rdx],ymm0
       vmovups   ymm0,[7FFB2BE25E20]
       vmovups   [rdx+20],ymm0
       vmovups   ymm0,[7FFB2BE25E40]
       vmovups   [rdx+40],ymm0
       vmovups   xmm0,[7FFB2BE25E60]
       vmovups   [rdx+60],xmm0
       mov       ecx,[rbp-2A8]
       add       ecx,38
       mov       [rbp-2A8],ecx
       jmp       short M06_L42
M06_L41:
       lea       rcx,[rbp-2B8]
       mov       rdx,2A210400F10
       call      qword ptr [7FFB2BD37D08]
M06_L42:
       mov       rcx,offset MT_System.IO.IOException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbp-2B8]
       call      qword ptr [7FFB2B71C2A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2BD3E610]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L43:
       inc       edx
       cmp       edx,r8d
       jl        near ptr M06_L02
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2BDB5638]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2BA961C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L44:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2BDB5650]
       mov       rsi,rax
       mov       ecx,1AC3C
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2BA961C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L45:
       cmp       word ptr [r13+2],5C
       je        short M06_L46
       cmp       word ptr [r13+2],3F
       jne       near ptr M06_L03
M06_L46:
       cmp       word ptr [r13+4],3F
       jne       near ptr M06_L03
       cmp       word ptr [r13+6],5C
       jne       near ptr M06_L03
       jmp       near ptr M06_L04
M06_L47:
       mov       ecx,1
       jmp       near ptr M06_L05
M06_L48:
       lea       rcx,[rsi+0C]
       mov       [rbp-360],rcx
       mov       [rbp-358],r13d
       lea       rcx,[rbp-360]
       call      qword ptr [7FFB2BD35E78]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M06_L06
       mov       r8d,r12d
       mov       [rbp-370],rsi
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB2B9A7D20]; System.String.Substring(Int32, Int32)
       mov       [rbp-380],rax
       jmp       near ptr M06_L07
M06_L49:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L08
M06_L50:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2BDB62C8]
       mov       rcx,rax
       mov       rdx,[rbp-370]
       call      qword ptr [7FFB2BDB5B48]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,[rbp-370]
       call      qword ptr [7FFB2BDB62E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L51:
       mov       rcx,rsi
       call      qword ptr [7FFB2BD35EC0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rdi,rax
       jmp       near ptr M06_L22
M06_L52:
       mov       rcx,rsi
       call      qword ptr [7FFB2BD35EC0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       near ptr M06_L24
M06_L53:
       mov       ecx,91
       mov       rdx,7FFB2B654000
       call      qword ptr [7FFB2B71F228]
       mov       rcx,rax
       call      qword ptr [7FFB2BDB62F8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L54:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-378],0
       je        short M06_L55
       mov       rcx,[rbp-378]
       mov       edx,1
       call      qword ptr [7FFB2B71DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-378]
       call      qword ptr [7FFB2B8E5590]; System.GC.SuppressFinalize(System.Object)
M06_L55:
       nop
       vzeroupper
       add       rsp,28
       ret
       sub       rsp,28
       cmp       byte ptr [rbp-34C],0
       je        short M06_L56
       xor       ecx,ecx
       mov       [rbp-300],ecx
       vzeroupper
       call      00007FFB2B708C00
       lea       rdx,[rbp-300]
       mov       ecx,[rbp-350]
       vzeroupper
       call      00007FFB2B708C18
       vzeroupper
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
M06_L56:
       nop
       vzeroupper
       add       rsp,28
       ret
; Total bytes of code 2590
```
```assembly
; System.IO.FileSystem.FillAttributeInfo(System.String, WIN32_FILE_ATTRIBUTE_DATA ByRef, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,308
       vzeroupper
       lea       rbp,[rsp+340]
       xor       eax,eax
       mov       [rbp-308],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-300],ymm4
       vmovdqu   ymmword ptr [rbp-2E0],ymm4
       vmovdqu   ymmword ptr [rbp-2C0],ymm4
       mov       rax,9A22B2E04DCD
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,r8d
       lea       rcx,[rbp-2F0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp-2D8],rcx
       mov       rcx,rbp
       mov       [rbp-2C8],rcx
       mov       [rbp-320],rsi
       xor       r15d,r15d
       test      rbx,rbx
       je        short M07_L01
       cmp       dword ptr [rbx+8],0
       je        short M07_L01
       mov       r13d,[rbx+8]
       dec       r13d
       cmp       r13d,[rbx+8]
       jae       near ptr M07_L24
       mov       ecx,r13d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M07_L19
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M07_L00:
       test      ecx,ecx
       jne       near ptr M07_L20
M07_L01:
       mov       [rbp-318],rbx
M07_L02:
       xor       ecx,ecx
       mov       [rbp-2A0],rcx
       mov       [rbp-29C],ecx
       mov       rax,7FFC81585FF0
       call      rax
       lea       rdx,[rbp-29C]
       mov       ecx,1
       mov       rax,7FFC8158BE20
       call      rax
       mov       ebx,eax
       mov       rax,7FFC81585F30
       call      rax
       mov       ecx,eax
       call      00007FFB8B3B6D50
       test      ebx,ebx
       setne     al
       movzx     eax,al
       mov       [rbp-2A0],al
       movzx     eax,byte ptr [rbp-2A0]
       mov       [rbp-2F4],al
       mov       eax,[rbp-29C]
       mov       [rbp-2F8],eax
       cmp       dword ptr [7FFB8B673A10],0
       jne       near ptr M07_L21
M07_L03:
       mov       rbx,[rbp-318]
       test      rbx,rbx
       je        short M07_L04
       mov       ecx,[rbx+8]
       cmp       ecx,104
       jge       near ptr M07_L10
       test      ecx,ecx
       je        short M07_L04
       dec       ecx
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,20
       je        near ptr M07_L10
       cmp       ecx,2E
       je        near ptr M07_L10
M07_L04:
       mov       [rbp-318],rbx
       mov       rax,rbx
M07_L05:
       mov       rsi,[rbp-320]
       mov       [rbp-2A8],rsi
       mov       r13,rsi
       test      rax,rax
       je        near ptr M07_L09
       add       rax,0C
       mov       r12,rax
M07_L06:
       mov       [rbp-2B0],r12
       xor       ecx,ecx
       mov       rax,7FFC81585FF0
       call      rax
       mov       rcx,r12
       mov       r8,r13
       xor       edx,edx
       mov       rax,7FFB2B88EDE8
       mov       [rbp-2E0],rax
       lea       rax,[M07_L07]
       mov       [rbp-2D0],rax
       lea       rax,[rbp-2F0]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC81595090
       call      rax
M07_L07:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFB8B673A10],0
       je        short M07_L08
       call      qword ptr [7FFB8B661648]; CORINFO_HELP_STOP_FOR_GC
M07_L08:
       mov       rcx,[rbp-2E8]
       mov       [r14+8],rcx
       mov       ebx,eax
       mov       rax,7FFC81585F30
       call      rax
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2B0],rax
       mov       [rbp-2A8],rax
       call      00007FFB8B3B6D50
       test      ebx,ebx
       jne       near ptr M07_L14
       jmp       short M07_L11
M07_L09:
       xor       r12d,r12d
       jmp       near ptr M07_L06
M07_L10:
       mov       rcx,rbx
       call      qword ptr [7FFB2BD35EC0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       [rbp-318],rbx
       jmp       near ptr M07_L05
M07_L11:
       call      00007FFB8B3B6D30
       mov       r15d,eax
       mov       ecx,r15d
       call      qword ptr [7FFB2BD35E48]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M07_L14
       lea       rcx,[rbp-290]
       mov       edx,250
       call      qword ptr [7FFB2B7157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-318]
       call      qword ptr [7FFB2BDB6070]
       mov       [rbp-310],rax
       mov       rcx,[rbp-310]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2B887810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M07_L12
       call      00007FFB8B3B6D30
       mov       r15d,eax
       jmp       short M07_L13
M07_L12:
       xor       r15d,r15d
       lea       rdx,[rbp-290]
       mov       rcx,[rbp-320]
       call      qword ptr [7FFB2BDB6088]
       nop
M07_L13:
       mov       rcx,[rbp-310]
       mov       edx,1
       call      qword ptr [7FFB2B71DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-310]
       call      qword ptr [7FFB2B8E5590]; System.GC.SuppressFinalize(System.Object)
       nop
M07_L14:
       cmp       byte ptr [rbp-2F4],0
       je        short M07_L15
       xor       ecx,ecx
       mov       [rbp-2B8],ecx
       call      00007FFB2B708C00
       lea       rdx,[rbp-2B8]
       mov       ecx,[rbp-2F8]
       call      00007FFB2B708C18
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
M07_L15:
       test      r15d,r15d
       jne       near ptr M07_L22
M07_L16:
       mov       eax,r15d
M07_L17:
       mov       r8,9A22B2E04DCD
       cmp       [rbp-40],r8
       je        short M07_L18
       call      CORINFO_HELP_FAIL_FAST
M07_L18:
       nop
       add       rsp,308
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M07_L19:
       mov       ecx,1
       jmp       near ptr M07_L00
M07_L20:
       lea       rcx,[rbx+0C]
       mov       r12d,[rbx+8]
       mov       [rbp-308],rcx
       mov       [rbp-300],r12d
       lea       rcx,[rbp-308]
       call      qword ptr [7FFB2BD35E78]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r12d
       je        near ptr M07_L01
       mov       r8d,r13d
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFB2B9A7D20]; System.String.Substring(Int32, Int32)
       mov       [rbp-318],rax
       jmp       near ptr M07_L02
M07_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M07_L03
M07_L22:
       test      dil,dil
       jne       near ptr M07_L16
       lea       eax,[r15-2]
       cmp       eax,1
       jbe       short M07_L23
       cmp       r15d,15
       jne       near ptr M07_L16
M07_L23:
       mov       rsi,[rbp-320]
       mov       dword ptr [rsi],0FFFFFFFF
       xor       eax,eax
       jmp       near ptr M07_L17
M07_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       cmp       qword ptr [rbp-310],0
       je        short M07_L25
       mov       rcx,[rbp-310]
       mov       edx,1
       call      qword ptr [7FFB2B71DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-310]
       call      qword ptr [7FFB2B8E5590]; System.GC.SuppressFinalize(System.Object)
M07_L25:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2F4],0
       je        short M07_L26
       xor       ecx,ecx
       mov       [rbp-2B8],ecx
       call      00007FFB2B708C00
       lea       rdx,[rbp-2B8]
       mov       ecx,[rbp-2F8]
       call      00007FFB2B708C18
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
M07_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 1146
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
       mov       rax,9A22B2E04DCD
       mov       [rbp-38],rax
       mov       rbx,rcx
       cmp       dword ptr [rbx+28],0FFFFFFFF
       jne       near ptr M08_L13
       mov       rsi,[rbx+8]
       lea       rdi,[rbx+30]
       xor       r14d,r14d
       test      rsi,rsi
       je        short M08_L01
       cmp       dword ptr [rsi+8],0
       je        short M08_L01
       mov       r15d,[rsi+8]
       dec       r15d
       cmp       r15d,[rsi+8]
       jae       near ptr M08_L21
       mov       ecx,r15d
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,5C
       je        near ptr M08_L17
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M08_L00:
       test      ecx,ecx
       jne       near ptr M08_L18
M08_L01:
       xor       ecx,ecx
       mov       [rbp-298],rcx
       mov       [rbp-294],ecx
       call      00007FFB2B708C00
       lea       rdx,[rbp-294]
       mov       ecx,1
       call      00007FFB2B708C18
       mov       r15d,eax
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
       test      r15d,r15d
       setne     cl
       movzx     ecx,cl
       mov       [rbp-298],cl
       movzx     ecx,byte ptr [rbp-298]
       mov       [rbp-2B4],cl
       mov       ecx,[rbp-294]
       mov       [rbp-2B8],ecx
       test      rsi,rsi
       je        short M08_L02
       mov       ecx,[rsi+8]
       cmp       ecx,104
       jge       short M08_L06
       test      ecx,ecx
       je        short M08_L02
       dec       ecx
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,20
       je        short M08_L06
       cmp       ecx,2E
       je        short M08_L06
M08_L02:
       mov       rax,rsi
M08_L03:
       mov       [rbp-2A0],rdi
       mov       r15,rdi
       test      rax,rax
       je        short M08_L05
       add       rax,0C
       mov       r13,rax
M08_L04:
       mov       [rbp-2A8],r13
       xor       ecx,ecx
       call      00007FFB2B708C00
       mov       rcx,r13
       mov       r8,r15
       xor       edx,edx
       call      00007FFB2B708C48
       mov       r15d,eax
       call      00007FFB2B708C30
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFB8B3B6D50
       test      r15d,r15d
       jne       near ptr M08_L10
       jmp       short M08_L07
M08_L05:
       xor       r13d,r13d
       jmp       short M08_L04
M08_L06:
       mov       rcx,rsi
       call      qword ptr [7FFB2BD35EC0]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       jmp       short M08_L03
M08_L07:
       call      00007FFB8B3B6D30
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFB2BD35E48]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       short M08_L10
       lea       rcx,[rbp-288]
       mov       edx,250
       call      qword ptr [7FFB2B7157E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-288]
       mov       rcx,rsi
       call      qword ptr [7FFB2BDB6070]
       mov       [rbp-2D0],rax
       mov       rcx,[rbp-2D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFB2B887810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M08_L08
       call      00007FFB8B3B6D30
       mov       r14d,eax
       jmp       short M08_L09
M08_L08:
       xor       r14d,r14d
       lea       rdx,[rbp-288]
       mov       rcx,rdi
       call      qword ptr [7FFB2BDB6088]
       nop
M08_L09:
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFB2B71DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFB2B8E5590]; System.GC.SuppressFinalize(System.Object)
       nop
M08_L10:
       cmp       byte ptr [rbp-2B4],0
       je        short M08_L11
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFB2B708C00
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFB2B708C18
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
M08_L11:
       test      r14d,r14d
       jne       short M08_L19
M08_L12:
       mov       [rbx+28],r14d
M08_L13:
       cmp       dword ptr [rbx+28],0
       jne       short M08_L14
       cmp       dword ptr [rbx+30],0FFFFFFFF
       jne       short M08_L16
M08_L14:
       xor       eax,eax
M08_L15:
       mov       [rbp-28C],eax
       jmp       near ptr M08_L22
M08_L16:
       test      byte ptr [rbx+30],10
       sete      al
       movzx     eax,al
       jmp       short M08_L15
M08_L17:
       mov       ecx,1
       jmp       near ptr M08_L00
M08_L18:
       lea       rcx,[rsi+0C]
       mov       r13d,[rsi+8]
       mov       [rbp-2C8],rcx
       mov       [rbp-2C0],r13d
       lea       rcx,[rbp-2C8]
       call      qword ptr [7FFB2BD35E78]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r13d
       je        near ptr M08_L01
       mov       r8d,r15d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFB2B9A7D20]; System.String.Substring(Int32, Int32)
       mov       rsi,rax
       jmp       near ptr M08_L01
M08_L19:
       lea       eax,[r14-2]
       cmp       eax,1
       jbe       short M08_L20
       cmp       r14d,15
       jne       near ptr M08_L12
M08_L20:
       mov       dword ptr [rdi],0FFFFFFFF
       xor       r14d,r14d
       jmp       near ptr M08_L12
M08_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M08_L22:
       mov       eax,[rbp-28C]
       mov       r8,9A22B2E04DCD
       cmp       [rbp-38],r8
       je        short M08_L23
       call      CORINFO_HELP_FAIL_FAST
M08_L23:
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
       je        short M08_L24
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFB2B71DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFB2B8E5590]; System.GC.SuppressFinalize(System.Object)
M08_L24:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       cmp       byte ptr [rbp-2B4],0
       je        short M08_L25
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFB2B708C00
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFB2B708C18
       call      00007FFB2B708C30
       mov       ecx,eax
       call      00007FFB8B3B6D50
M08_L25:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       vzeroupper
       xor       eax,eax
       mov       [rbp-28C],eax
       lea       rax,[M08_L22]
       add       rsp,28
       ret
; Total bytes of code 943
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
       je        near ptr M09_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M09_L01
       test      rsi,rsi
       je        short M09_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M09_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M09_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFB8B3B9F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFB2B715818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M09_L00:
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
M09_L01:
       test      rsi,rsi
       je        short M09_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M09_L03
M09_L02:
       mov       rax,2A2103F0008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L03:
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
M09_L04:
       call      qword ptr [7FFB2BDB51E8]
       int       3
; Total bytes of code 244
```

