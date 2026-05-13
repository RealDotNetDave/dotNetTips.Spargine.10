## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       je        near ptr M00_L06
       lea       rsi,[rcx+10]
       mov       edi,[rcx+8]
M00_L00:
       test      edi,edi
       je        near ptr M00_L07
       xor       ebp,ebp
       xor       r14d,r14d
M00_L01:
       mov       r15,[rsi+r14*8]
       test      r15,r15
       je        short M00_L05
       mov       rcx,r15
       call      qword ptr [7FFBEC4000B8]; System.IO.FileInfo.get_Exists()
       test      eax,eax
       je        short M00_L05
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
       xor       ecx,ecx
       jmp       short M00_L03
M00_L06:
       xor       esi,esi
       xor       edi,edi
       jmp       near ptr M00_L00
M00_L07:
       xor       eax,eax
       jmp       short M00_L04
M00_L08:
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [r15+30],ymm0
       vmovdqu   xmmword ptr [r15+44],xmm0
       mov       rcx,r15
       call      qword ptr [7FFBEC6ACFC0]
       jmp       near ptr M00_L02
M00_L09:
       mov       rcx,offset MT_System.IO.FileNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFBEC6ACFD8]
       mov       rcx,rax
       mov       rdx,[r15+8]
       call      qword ptr [7FFBEC59EB50]
       mov       rdx,rax
       mov       r8,[r15+8]
       mov       rcx,rbp
       call      qword ptr [7FFBEC6ACFF0]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,[r15+28]
       mov       rdx,[r15+8]
       xor       r8d,r8d
       call      qword ptr [7FFBEC6AC738]
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
       mov       rax,6F4B09A3AFEF
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
       call      00007FFBEBFF8C90
       lea       rdx,[rbp-294]
       mov       ecx,1
       call      00007FFBEBFF8CA8
       mov       esi,eax
       call      00007FFBEBFF8CC0
       mov       ecx,eax
       call      00007FFC4BCA6B40
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
       call      qword ptr [7FFBEC29FF18]; System.IO.PathInternal.EndsWithPeriodOrSpace(System.String)
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
       call      00007FFBEBFF8C90
       mov       rcx,rsi
       mov       r8,r13
       xor       edx,edx
       call      00007FFBEBFF8CD8
       mov       esi,eax
       call      00007FFBEBFF8CC0
       mov       ecx,eax
       xor       eax,eax
       mov       [rbp-2A8],rax
       mov       [rbp-2A0],rax
       call      00007FFC4BCA6B40
       test      esi,esi
       jne       near ptr M01_L11
       call      00007FFC4BCA6B20
       mov       r14d,eax
       mov       ecx,r14d
       call      qword ptr [7FFBEC6262F8]; System.IO.FileSystem.IsPathUnreachableError(Int32)
       test      eax,eax
       jne       near ptr M01_L11
       jmp       short M01_L08
M01_L06:
       mov       rcx,r15
       call      qword ptr [7FFBEC626370]; System.IO.PathInternal.EnsureExtendedPrefix(System.String)
       mov       rsi,rax
       jmp       short M01_L04
M01_L07:
       xor       esi,esi
       jmp       short M01_L05
M01_L08:
       lea       rcx,[rbp-288]
       mov       edx,250
       call      qword ptr [7FFBEC0057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       lea       rdx,[rbp-288]
       mov       rcx,r15
       call      qword ptr [7FFBEC6AD038]
       mov       [rbp-2D0],rax
       mov       rcx,[rbp-2D0]
       cmp       [rcx],ecx
       call      qword ptr [7FFBEC177810]; Precode of Microsoft.Win32.SafeHandles.SafeHandleZeroOrMinusOneIsInvalid.get_IsInvalid()
       test      eax,eax
       je        short M01_L09
       call      00007FFC4BCA6B20
       mov       r14d,eax
       jmp       short M01_L10
M01_L09:
       xor       r14d,r14d
       lea       rdx,[rbp-288]
       mov       rcx,rdi
       call      qword ptr [7FFBEC6AD050]
       nop
M01_L10:
       mov       rcx,[rbp-2D0]
       mov       edx,1
       call      qword ptr [7FFBEC00DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFBEC1D5590]; System.GC.SuppressFinalize(System.Object)
       nop
M01_L11:
       cmp       byte ptr [rbp-2B4],0
       je        short M01_L12
       xor       ecx,ecx
       mov       [rbp-2B0],ecx
       call      00007FFBEBFF8C90
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFBEBFF8CA8
       call      00007FFBEBFF8CC0
       mov       ecx,eax
       call      00007FFC4BCA6B40
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
       call      qword ptr [7FFBEC626328]; System.IO.PathInternal.GetRootLength(System.ReadOnlySpan`1<Char>)
       cmp       eax,r15d
       je        near ptr M01_L01
       mov       r8d,r13d
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBEC297D20]; System.String.Substring(Int32, Int32)
       mov       r15,rax
       jmp       near ptr M01_L02
M01_L22:
       cmp       r14d,15
       jne       near ptr M01_L13
       jmp       short M01_L17
M01_L23:
       mov       eax,[rbp-28C]
       mov       r8,6F4B09A3AFEF
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
       call      qword ptr [7FFBEC00DE00]; System.Runtime.InteropServices.SafeHandle.InternalRelease(Boolean)
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFBEC1D5590]; System.GC.SuppressFinalize(System.Object)
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
       call      00007FFBEBFF8C90
       lea       rdx,[rbp-2B0]
       mov       ecx,[rbp-2B8]
       call      00007FFBEBFF8CA8
       call      00007FFBEBFF8CC0
       mov       ecx,eax
       call      00007FFC4BCA6B40
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,0D6EAF1E9400B
       mov       [rsp+68],rax
       mov       rbx,rcx
       mov       rcx,[rbx+140]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L13
       mov       rsi,[rcx+10]
       test      rsi,rsi
       je        near ptr M00_L09
       mov       rax,[rsi+18]
       test      rax,rax
       je        near ptr M00_L10
M00_L00:
       mov       r8,1BD12C021D0
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
       nop
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
       call      qword ptr [7FFBEC1EF300]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
M00_L02:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       rcx,[rbx+60]
       mov       [rcx+4C],al
       mov       r8,0D6EAF1E9400B
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
       call      qword ptr [7FFBEC63E910]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Int32, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Ssse3AndWasmHandleZeroInNeedle, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       call      qword ptr [7FFBEC2AEFE8]; System.SpanHelpers.NonPackedContainsValueType[[System.Int16, System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
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
       call      qword ptr [7FFBEC5AF270]
       mov       ecx,77D
       mov       rdx,7FFBEC68B200
       call      qword ptr [7FFBEC01F228]
       mov       rbx,rax
       mov       ecx,1948
       mov       rdx,7FFBEC2E4FD8
       call      qword ptr [7FFBEC01F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC01D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBEC68B200
       call      qword ptr [7FFBEC01F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBEC01D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBEC6E7C60]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBEC6E6C28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       rcx,[rsi+10]
       call      qword ptr [7FFBEC6E6730]
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
       call      qword ptr [7FFBEC6E6B98]
       jmp       near ptr M00_L02
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 628
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
       call      qword ptr [7FFBEC1EF558]
       mov       ecx,eax
       call      qword ptr [7FFBEC1EF570]
       test      eax,eax
       je        short M01_L02
       mov       rcx,7FFBEC27BD58
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBEC1EF588]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L02:
       mov       rcx,7FFBEC27BD5C
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
       mov       rcx,7FFBEC27BD60
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC1EF5A0]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       call      qword ptr [7FFBEC1EF450]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-0F0]
       vptest    ymm0,ymmword ptr [rbp-0F0]
       je        short M01_L09
       mov       rcx,7FFBEC27BD64
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-0F0]
       vmovups   [rbp-2D0],ymm0
       lea       r8,[rbp-2D0]
       mov       rdx,[rbp-40]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC1EF510]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].FirstIndex[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib]](Int16 ByRef, Int16 ByRef, System.Runtime.Intrinsics.Vector256`1<Byte>)
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L08:
       mov       rcx,7FFBEC27BD68
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L15
M01_L09:
       mov       rax,[rbp-40]
       add       rax,40
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       cmp       rax,[rbp-98]
       jb        short M01_L11
       mov       rcx,7FFBEC27BD6C
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
       mov       rcx,7FFBEC27BD70
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M01_L06
M01_L12:
       mov       rcx,7FFBEC27BD74
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
       call      qword ptr [7FFBEC1EF450]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Int16>, System.Runtime.Intrinsics.Vector256`1<Byte>)
       vmovups   ymm0,[rbp-150]
       vptest    ymm0,ymmword ptr [rbp-150]
       je        short M01_L14
       mov       rcx,7FFBEC27BD78
       call      CORINFO_HELP_COUNTPROFILE32
       vmovups   ymm0,[rbp-150]
       vmovups   [rbp-350],ymm0
       lea       r9,[rbp-350]
       mov       rdx,[rbp-100]
       mov       r8,[rbp-0F8]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC1EF498]
       mov       [rbp-23C],eax
       jmp       near ptr M01_L19
M01_L14:
       mov       rcx,7FFBEC27BD7C
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC1EF5A0]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       mov       rcx,7FFBEC27BD80
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
       call      qword ptr [7FFBEC1EF3C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyLookup[[System.Buffers.IndexOfAnyAsciiSearcher+DontNegate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]](System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Int16>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-1B0]
       vptest    xmm0,xmmword ptr [rbp-1B0]
       je        short M01_L18
       mov       rcx,7FFBEC27BD84
       call      CORINFO_HELP_COUNTPROFILE32
       vmovaps   xmm0,[rbp-1B0]
       vmovaps   [rbp-390],xmm0
       lea       r9,[rbp-390]
       mov       rdx,[rbp-190]
       mov       r8,[rbp-188]
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBEC1EF408]
       mov       [rbp-23C],eax
       jmp       short M01_L19
M01_L18:
       mov       rcx,7FFBEC27BD88
       call      CORINFO_HELP_COUNTPROFILE32
       call      qword ptr [7FFBEC1EF5A0]; System.Buffers.IndexOfAnyAsciiSearcher+IndexOfAnyResultMapper`1[[System.Int16, System.Private.CoreLib]].get_NotFound()
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
       vbroadcastss ymm1,dword ptr [7FFBEC762FA0]
       vpminuw   ymm2,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rdx]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFBEC762FC0]
       vbroadcastsd ymm2,qword ptr [7FFBEC762FE0]
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
       vbroadcastss ymm1,dword ptr [7FFBEC762FA0]
       vpminuw   ymm2,ymm1,[rax]
       vpminuw   ymm1,ymm1,[rax+20]
       vpackuswb ymm1,ymm2,ymm1
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFBEC762FC0]
       vbroadcastsd ymm3,qword ptr [7FFBEC762FE0]
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
       vpminuw   xmm1,xmm1,[7FFBEC762FF0]
       vmovups   xmm2,[rax]
       vpminuw   xmm2,xmm2,[7FFBEC762FF0]
       vpackuswb xmm1,xmm1,xmm2
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFBEC762FC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFBEC762FE0]
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
       mov       rcx,7FFBEC723620
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
       mov       rcx,7FFBEC723618
       call      CORINFO_HELP_COUNTPROFILE32
M03_L02:
       mov       rcx,7FFBEC723638
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
       mov       rcx,7FFBEC72361C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L02
M03_L04:
       mov       rcx,7FFBEC72360C
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
       mov       rcx,7FFBEC72362C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L02
M03_L06:
       mov       rcx,7FFBEC7235C8
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
       mov       rcx,7FFBEC7235F0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L08:
       mov       rcx,7FFBEC7235F4
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
       mov       rcx,7FFBEC7235F8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L08
M03_L11:
       mov       rcx,7FFBEC7235FC
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
       mov       rcx,7FFBEC723608
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
       mov       rcx,7FFBEC7235EC
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbp,8
       cmp       ebx,8
       jge       near ptr M03_L14
       jmp       near ptr M03_L07
M03_L15:
       mov       rcx,7FFBEC7235CC
       call      CORINFO_HELP_COUNTPROFILE32
M03_L16:
       mov       rcx,7FFBEC7235D0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L17:
       mov       rcx,7FFBEC7235D4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L18:
       mov       rcx,7FFBEC7235D8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L19:
       mov       rcx,7FFBEC7235DC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L20:
       mov       rcx,7FFBEC7235E0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L21:
       mov       rcx,7FFBEC7235E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L22:
       mov       rcx,7FFBEC7235E8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L16
M03_L23:
       mov       rcx,7FFBEC723600
       call      CORINFO_HELP_COUNTPROFILE32
       add       rbp,4
       jmp       near ptr M03_L12
M03_L24:
       mov       rcx,7FFBEC723604
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L25:
       mov       rcx,7FFBEC723610
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L26:
       mov       rcx,7FFBEC723614
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L27:
       mov       rcx,7FFBEC723634
       call      CORINFO_HELP_COUNTPROFILE32
       vpcmpeqw  xmm0,xmm6,[rsi]
       vptest    xmm0,xmm0
       je        near ptr M03_L05
M03_L28:
       mov       rcx,7FFBEC723624
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L29:
       mov       rcx,7FFBEC723628
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M03_L09
M03_L30:
       mov       rcx,7FFBEC723630
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
       call      00007FFC4BCA9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBEC015818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBEC015818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FDA7AE0008
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
       call      qword ptr [7FFBEC6E55F0]
       int       3
; Total bytes of code 244
```

