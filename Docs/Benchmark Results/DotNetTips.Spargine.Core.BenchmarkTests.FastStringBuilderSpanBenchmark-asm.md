## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.CombineSpan()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       r8,[rcx+198]
       test      r8,r8
       je        near ptr M00_L06
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
M00_L00:
       test      esi,esi
       je        near ptr M00_L33
       mov       r8,1BABC400188
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-40],r8
       cmp       qword ptr [rbp-40],0
       je        near ptr M00_L35
       lea       r8,[rdi+20]
       mov       rdx,[rbp-40]
       test      r8,r8
       je        near ptr M00_L34
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-40]
       jne       near ptr M00_L35
M00_L01:
       mov       rdi,[rbp-40]
M00_L02:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       ecx,esi
       xor       edx,edx
       xor       eax,eax
       nop       word ptr [rax+rax]
M00_L03:
       mov       r8,[rbx+rax*8]
       test      r8,r8
       je        short M00_L07
       mov       r8d,[r8+8]
M00_L04:
       add       edx,r8d
       jo        near ptr M00_L39
       inc       eax
       cmp       eax,ecx
       jl        short M00_L03
       mov       r14d,esi
       sub       r14d,1
       jo        near ptr M00_L39
       add       r14d,edx
       jo        near ptr M00_L39
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L37
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L38
M00_L05:
       mov       r8,[rdi+8]
       mov       r8d,[r8+8]
       mov       [rbp-50],rdi
       jmp       short M00_L08
M00_L06:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M00_L00
M00_L07:
       xor       r8d,r8d
       jmp       short M00_L04
M00_L08:
       xor       r14d,r14d
       inc       esi
       jmp       near ptr M00_L17
M00_L09:
       mov       edx,1F40
       jmp       near ptr M00_L20
M00_L10:
       mov       eax,edx
       jmp       near ptr M00_L21
M00_L11:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF8A81A7300]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       [rbp-68],rax
M00_L12:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-60],rax
       mov       ecx,[r13+18]
       mov       [rax+18],ecx
       mov       ecx,[r13+1C]
       mov       [rax+1C],ecx
       mov       rdx,[r13+8]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r13+10]
       mov       rax,[rbp-60]
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r13+20]
       mov       rax,[rbp-60]
       mov       [rax+20],ecx
       lea       rcx,[r13+10]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[r13+18]
       add       [r13+1C],ecx
       xor       ecx,ecx
       mov       [r13+18],ecx
       lea       rcx,[r13+8]
       mov       rdx,[rbp-68]
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,r12d
       lea       rdx,[rdi+r8*2]
       mov       r8,[r13+8]
       test      r8,r8
       je        near ptr M00_L25
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M00_L13:
       cmp       r15d,r8d
       ja        near ptr M00_L30
       mov       r8d,r15d
       add       r8,r8
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [r13+18],r15d
       jmp       short M00_L16
M00_L14:
       movsxd    r8,r12d
       lea       rcx,[rax+r8*2+10]
       cmp       r15d,2
       jle       near ptr M00_L22
       mov       r8d,r15d
       add       r8,r8
       mov       rdx,rdi
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L15:
       add       r12d,r15d
       mov       [r13+18],r12d
M00_L16:
       mov       r13,[rbp-50]
       add       r14,8
M00_L17:
       dec       esi
       je        near ptr M00_L23
       mov       r8,[rbx+r14]
       test      r8,r8
       je        short M00_L16
       lea       rdi,[r8+0C]
       mov       r15d,[r8+8]
       test      r15d,r15d
       je        short M00_L16
       mov       r13,[rbp-50]
       mov       r8,[r13+8]
       mov       rax,r8
       mov       ecx,[r13+18]
       mov       r12d,ecx
       lea       edx,[r12+r15]
       cmp       edx,[rax+8]
       jbe       short M00_L14
       mov       edx,ecx
       add       edx,[r13+1C]
       add       edx,r15d
       cmp       edx,[r13+20]
       jg        near ptr M00_L26
       cmp       edx,r15d
       jl        near ptr M00_L26
       mov       r12d,[r8+8]
       sub       r12d,ecx
       test      r12d,r12d
       jle       short M00_L19
       test      r8,r8
       je        near ptr M00_L24
       cmp       [r8+8],ecx
       jb        near ptr M00_L27
       mov       edx,ecx
       lea       rdx,[r8+rdx*2+10]
       mov       r8d,[r8+8]
       sub       r8d,ecx
M00_L18:
       cmp       r12d,r8d
       ja        near ptr M00_L30
       mov       r8d,r12d
       add       r8,r8
       mov       rcx,rdx
       mov       rdx,rdi
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       mov       [r13+18],ecx
M00_L19:
       sub       r15d,r12d
       mov       ecx,[r13+1C]
       lea       edx,[r15+rcx]
       mov       eax,[r13+18]
       add       edx,eax
       cmp       edx,[r13+20]
       jg        near ptr M00_L28
       cmp       edx,r15d
       jl        near ptr M00_L28
       add       ecx,eax
       mov       edx,ecx
       cmp       edx,1F40
       jg        near ptr M00_L09
M00_L20:
       cmp       r15d,edx
       jl        near ptr M00_L10
       mov       eax,r15d
M00_L21:
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M00_L29
       cmp       eax,400
       jge       near ptr M00_L11
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-68],rax
       jmp       near ptr M00_L12
M00_L22:
       movzx     eax,word ptr [rdi]
       mov       [rcx],ax
       cmp       r15d,2
       jne       near ptr M00_L15
       movzx     eax,word ptr [rdi+2]
       mov       [rcx+2],ax
       jmp       near ptr M00_L15
M00_L23:
       mov       r13,[rbp-50]
       mov       rcx,r13
       call      qword ptr [7FF8A7EC5BD0]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       near ptr M00_L31
M00_L24:
       test      ecx,ecx
       jne       short M00_L27
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M00_L18
M00_L25:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M00_L13
M00_L26:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rsi,rax
       call      qword ptr [7FF8A823F288]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       call      qword ptr [7FF8A7DFF210]
       int       3
M00_L28:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rsi,rax
       call      qword ptr [7FF8A823EDF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L29:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A823F2A0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L30:
       call      qword ptr [7FF8A803CFC0]
       int       3
M00_L31:
       call      M00_L40
       nop
       mov       rbx,[rbp-58]
M00_L32:
       mov       [rbp-48],rbx
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
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
M00_L33:
       mov       rbx,1FB3B2B0008
       jmp       short M00_L32
M00_L34:
       call      qword ptr [7FF8A823ED78]
       int       3
M00_L35:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A81AD758]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L36
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L01
M00_L36:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L37:
       mov       ecx,13CC2
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A823ED90]
       int       3
M00_L38:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF8A82367F0]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M00_L05
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L40:
       sub       rsp,28
       mov       r13,[rbp-50]
       cmp       dword ptr [r13+20],0
       jge       short M00_L41
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rsi,rax
       call      qword ptr [7FF8A823EDF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L41:
       cmp       qword ptr [r13+10],0
       jne       short M00_L42
       xor       ecx,ecx
       mov       [r13+18],rcx
       jmp       near ptr M00_L49
M00_L42:
       mov       ecx,[r13+1C]
       add       ecx,[r13+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L43
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF8A823EE08]
       jmp       near ptr M00_L49
M00_L43:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF8A823EE20]
       mov       rbx,rax
       cmp       rbx,r13
       je        near ptr M00_L48
       mov       rax,[r13+8]
       mov       ecx,[rax+8]
       add       ecx,[r13+1C]
       mov       eax,[r13+1C]
       add       eax,[r13+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r13+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L46
       cmp       ecx,400
       jge       short M00_L44
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L45
M00_L44:
       xor       edx,edx
       call      qword ptr [7FF8A81A7300]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L45:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8A7C2F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r13+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L47
M00_L46:
       mov       rdx,[rbx+8]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L47:
       mov       rdx,[rbx+10]
       lea       rcx,[r13+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r13+1C],ecx
M00_L48:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r13+18],ecx
M00_L49:
       mov       rdx,1BABC400188
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r13
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L51
M00_L50:
       add       rsp,28
       ret
M00_L51:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L53
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L52
       call      qword ptr [7FF8A823ED78]
       int       3
M00_L52:
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L50
M00_L53:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L54
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FF8A823EF40]
       test      eax,eax
       jne       short M00_L50
       mov       rcx,rbx
       mov       rdx,r13
       call      qword ptr [7FF8A823EF58]
       jmp       short M00_L50
M00_L54:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L50
; Total bytes of code 1771
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M02_L07
       cmp       r8,40
       ja        short M02_L03
M02_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M02_L06
M02_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L02:
       vzeroupper
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L11
       cmp       r8,100
       jb        short M02_L04
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
M02_L04:
       mov       r9,r8
       shr       r9,6
M02_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L01
M02_L07:
       test      r8b,18
       je        short M02_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M02_L02
M02_L08:
       test      r8b,4
       je        short M02_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M02_L02
M02_L09:
       test      r8,r8
       je        near ptr M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M02_L02
M02_L10:
       cmp       rcx,rdx
       jne       short M02_L11
       cmp       [rdx],dl
       jmp       near ptr M02_L02
M02_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF8A7C266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 355
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M03_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rax,1FB3B2B0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rbx,rax
       call      qword ptr [7FF8A823EE68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M04_L01
       cmp       qword ptr [rdi+10],0
       je        short M04_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,edx
       test      ecx,ecx
       jl        short M05_L03
       cmp       ecx,[rbx+20]
       jg        short M05_L04
       mov       edx,[rbx+1C]
       mov       eax,edx
       add       eax,[rbx+18]
       cmp       eax,ecx
       jg        near ptr M05_L05
       mov       rax,[rbx+8]
       mov       r8d,edx
       add       r8d,[rax+8]
       cmp       r8d,ecx
       je        short M05_L02
       sub       ecx,edx
       cmp       ecx,400
       jl        short M05_L00
       xor       edx,edx
       call      qword ptr [7FF8D7580B38]; Precode of System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
       jmp       short M05_L01
M05_L00:
       movsxd    rcx,ecx
       call      qword ptr [7FF8D7566B28]
       mov       rsi,rax
M05_L01:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8D756A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FF8D7558FE8]; CORINFO_HELP_ASSIGN_REF
M05_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       call      qword ptr [7FF8D7581908]
       int       3
M05_L04:
       call      qword ptr [7FF8D7563560]
       mov       rbx,rax
       call      qword ptr [7FF8D756E538]
       mov       r8,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FF8D756C220]
       mov       rcx,rbx
       call      qword ptr [7FF8D7558FC0]; CORINFO_HELP_THROW
       int       3
M05_L05:
       call      qword ptr [7FF8D7563560]
       mov       rbx,rax
       call      qword ptr [7FF8D756E680]
       mov       r8,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FF8D756C220]
       mov       rcx,rbx
       call      qword ptr [7FF8D7558FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 236
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M06_L01
       xor       ebp,ebp
M06_L00:
       test      rbx,rbx
       jne       short M06_L03
       xor       eax,eax
       jmp       short M06_L04
M06_L01:
       test      rbx,rbx
       je        short M06_L02
       mov       r14,[rsi]
       cmp       r14,[rbx]
       jne       short M06_L02
       cmp       dword ptr [r14+4],18
       jne       short M06_L02
       cmp       edi,[rsi+8]
       ja        short M06_L02
       cmp       edi,[rbx+8]
       jbe       short M06_L06
M06_L02:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF8D756A390]; Precode of System.Array.GetLowerBound(Int32)
       mov       ebp,eax
       jmp       short M06_L00
M06_L03:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8D756A390]; Precode of System.Array.GetLowerBound(Int32)
M06_L04:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       mov       r9d,eax
       call      qword ptr [7FF8D756A328]; Precode of System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M06_L05:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M06_L06:
       mov       r8d,edi
       movzx     ecx,word ptr [r14]
       imul      r8,rcx
       lea       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       test      dword ptr [r14],1000000
       je        short M06_L08
       cmp       r8,4000
       ja        short M06_L07
       call      qword ptr [7FF8D756A630]
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       je        short M06_L05
       call      qword ptr [7FF8D7559040]; CORINFO_HELP_POLL_GC
       jmp       short M06_L05
M06_L07:
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       qword ptr [rax]
M06_L08:
       cmp       r8,19
       jne       short M06_L09
       movups    xmm0,[rdx]
       movups    xmm1,[rdx+9]
       movups    [rcx],xmm0
       movups    [rcx+9],xmm1
       jmp       short M06_L05
M06_L09:
       call      qword ptr [7FF8D756D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M06_L05
; Total bytes of code 243
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.CombineWithSpaceSpan()
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
       mov       r8,[rcx+198]
       test      r8,r8
       je        near ptr M00_L06
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
M00_L00:
       test      esi,esi
       je        near ptr M00_L25
       mov       r8,1AAF68021A8
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-30],r8
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L27
       lea       r8,[rdi+20]
       mov       rdx,[rbp-30]
       test      r8,r8
       je        near ptr M00_L26
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-30]
       jne       near ptr M00_L27
M00_L01:
       mov       rdi,[rbp-30]
M00_L02:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       xor       edx,edx
       nop       dword ptr [rax]
M00_L03:
       mov       rax,[rbx+rdx*8]
       test      rax,rax
       je        short M00_L07
       mov       eax,[rax+8]
M00_L04:
       add       ecx,eax
       jo        near ptr M00_L31
       inc       edx
       cmp       edx,esi
       jl        short M00_L03
       mov       r14d,esi
       sub       r14d,1
       jo        near ptr M00_L31
       add       r14d,ecx
       jo        near ptr M00_L31
       cmp       [rdi],dil
       test      r14d,r14d
       jl        near ptr M00_L29
       mov       rcx,[rdi+8]
       mov       ecx,[rcx+8]
       add       ecx,[rdi+1C]
       cmp       ecx,r14d
       jl        near ptr M00_L30
M00_L05:
       mov       r8,[rdi+8]
       mov       ecx,[r8+8]
       mov       [rbp-40],rdi
       jmp       short M00_L08
M00_L06:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M00_L00
M00_L07:
       xor       eax,eax
       jmp       short M00_L04
M00_L08:
       mov       rcx,[rbx]
       test      rcx,rcx
       je        short M00_L10
       lea       rdx,[rcx+0C]
       mov       r14d,[rcx+8]
       test      r14d,r14d
       je        short M00_L10
       mov       r15d,[rdi+18]
       lea       ecx,[r15+r14]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L18
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jle       near ptr M00_L17
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L09:
       add       r14d,r15d
       mov       [rdi+18],r14d
M00_L10:
       mov       edi,1
       cmp       edi,esi
       jge       short M00_L15
M00_L11:
       mov       r14,[rbp-40]
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L19
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [r14+18],ecx
M00_L12:
       mov       r8,[rbx+rdi*8]
       test      r8,r8
       je        short M00_L14
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L14
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L22
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L16
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L13:
       mov       [r14+18],r15d
M00_L14:
       add       edi,1
       jo        short M00_L21
       cmp       edi,esi
       jl        short M00_L11
M00_L15:
       mov       r14,[rbp-40]
       mov       rcx,r14
       call      qword ptr [7FF8A7EABCA8]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M00_L23
M00_L16:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L13
       jmp       short M00_L20
M00_L17:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       near ptr M00_L09
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M00_L09
M00_L18:
       mov       rcx,rdi
       mov       r8d,r14d
       call      qword ptr [7FF8A7E97A98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L10
M00_L19:
       mov       rcx,r14
       mov       edx,20
       call      qword ptr [7FF8A7E97C60]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L12
M00_L20:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L13
M00_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L22:
       mov       rcx,r14
       call      qword ptr [7FF8A7E97A98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L14
M00_L23:
       call      M00_L32
       nop
       mov       r14,[rbp-48]
M00_L24:
       mov       [rbp-38],r14
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
       mov       rdx,[rbp-38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L25:
       mov       r14,1EB8B600008
       jmp       short M00_L24
M00_L26:
       call      qword ptr [7FF8A82A53B0]
       int       3
M00_L27:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8214F78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L28
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L01
M00_L28:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L29:
       mov       ecx,13CC2
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7C0F210]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FF8A82A4B70]
       int       3
M00_L30:
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FF8A821DF98]; System.Text.StringBuilder.set_Capacity(Int32)
       jmp       near ptr M00_L05
M00_L31:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L32:
       sub       rsp,28
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],0
       jge       short M00_L33
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7C0F210]
       mov       rbx,rax
       call      qword ptr [7FF8A82A5500]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF8A7E9DA28]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       cmp       qword ptr [r14+10],0
       jne       short M00_L34
       xor       ecx,ecx
       mov       [r14+18],rcx
       jmp       near ptr M00_L41
M00_L34:
       mov       ecx,[r14+1C]
       add       ecx,[r14+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L35
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A82A5668]
       jmp       near ptr M00_L41
M00_L35:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A82A5680]
       mov       rbx,rax
       cmp       rbx,r14
       je        near ptr M00_L40
       mov       rax,[r14+8]
       mov       ecx,[rax+8]
       add       ecx,[r14+1C]
       mov       eax,[r14+1C]
       add       eax,[r14+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r14+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L38
       cmp       ecx,400
       jge       short M00_L36
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L37
M00_L36:
       xor       edx,edx
       call      qword ptr [7FF8A818EB38]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L37:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8A7C0F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L39
M00_L38:
       mov       rdx,[rbx+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L39:
       mov       rdx,[rbx+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r14+1C],ecx
M00_L40:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r14+18],ecx
M00_L41:
       mov       rdx,1AAF68021A8
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L43
M00_L42:
       add       rsp,28
       ret
M00_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L44
       call      qword ptr [7FF8A82A53B0]
       int       3
M00_L44:
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L42
M00_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L46
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82A5740]
       test      eax,eax
       jne       short M00_L42
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A82A5758]
       jmp       short M00_L42
M00_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L42
; Total bytes of code 1279
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M01_L07
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       vzeroupper
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L11
       cmp       r8,100
       jb        short M01_L04
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
M01_L04:
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L07:
       test      r8b,18
       je        short M01_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M01_L02
M01_L08:
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M01_L02
M01_L09:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       jne       short M01_L11
       cmp       [rdx],dl
       jmp       near ptr M01_L02
M01_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF8A7C066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 355
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,1EB8B600008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7C0F210]
       mov       rbx,rax
       call      qword ptr [7FF8A82A53C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7E9DA28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M03_L06
       cmp       eax,esi
       jl        near ptr M03_L06
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        short M03_L01
M03_L00:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M03_L09
       cmp       edx,esi
       jl        near ptr M03_L09
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M03_L10
       cmp       eax,400
       jge       short M03_L03
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M03_L04
M03_L01:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M03_L07
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M03_L08
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M03_L02:
       cmp       ebp,edx
       ja        near ptr M03_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       jmp       near ptr M03_L00
M03_L03:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF8A818EB38]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M03_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L11
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M03_L05:
       cmp       esi,r8d
       ja        near ptr M03_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7C0F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82A54B8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E9DA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L07:
       test      ecx,ecx
       jne       short M03_L08
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M03_L02
M03_L08:
       call      qword ptr [7FF8A7DDF210]
       int       3
M03_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B44000
       call      qword ptr [7FF8A7C0F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82A5500]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7E9DA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A82A5518]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M03_L05
M03_L12:
       call      qword ptr [7FF8A801CFC0]
       int       3
; Total bytes of code 626
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF8D75737D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M04_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8D7558FD8]
       int       3
; Total bytes of code 56
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M05_L01
       cmp       qword ptr [rdi+10],0
       je        short M05_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.Text.StringBuilder.set_Capacity(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,edx
       test      ecx,ecx
       jl        short M06_L03
       cmp       ecx,[rbx+20]
       jg        short M06_L04
       mov       edx,[rbx+1C]
       mov       eax,edx
       add       eax,[rbx+18]
       cmp       eax,ecx
       jg        near ptr M06_L05
       mov       rax,[rbx+8]
       mov       r8d,edx
       add       r8d,[rax+8]
       cmp       r8d,ecx
       je        short M06_L02
       sub       ecx,edx
       cmp       ecx,400
       jl        short M06_L00
       xor       edx,edx
       call      qword ptr [7FF8D7580B38]; Precode of System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
       jmp       short M06_L01
M06_L00:
       movsxd    rcx,ecx
       call      qword ptr [7FF8D7566B28]
       mov       rsi,rax
M06_L01:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8D756A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FF8D7558FE8]; CORINFO_HELP_ASSIGN_REF
M06_L02:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       call      qword ptr [7FF8D7581908]
       int       3
M06_L04:
       call      qword ptr [7FF8D7563560]
       mov       rbx,rax
       call      qword ptr [7FF8D756E538]
       mov       r8,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FF8D756C220]
       mov       rcx,rbx
       call      qword ptr [7FF8D7558FC0]; CORINFO_HELP_THROW
       int       3
M06_L05:
       call      qword ptr [7FF8D7563560]
       mov       rbx,rax
       call      qword ptr [7FF8D756E680]
       mov       r8,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FF8D756C220]
       mov       rcx,rbx
       call      qword ptr [7FF8D7558FC0]; CORINFO_HELP_THROW
       int       3
; Total bytes of code 236
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M08_L01
       xor       ebp,ebp
       xor       r14d,r14d
M08_L00:
       test      rbx,rbx
       jne       near ptr M08_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M08_L10
M08_L01:
       test      rbx,rbx
       jne       short M08_L04
       mov       rcx,7FF8A829EC14
       call      CORINFO_HELP_COUNTPROFILE32
M08_L02:
       mov       rcx,7FF8A829EC1C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M08_L08
       xor       r14d,r14d
M08_L03:
       mov       rbp,rsi
       jmp       short M08_L00
M08_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M08_L05
       mov       rcx,7FF8A829EC10
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L05:
       cmp       dword ptr [r15+4],18
       je        short M08_L06
       mov       rcx,7FF8A829EC0C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L06:
       cmp       edi,[rsi+8]
       jbe       short M08_L07
       mov       rcx,7FF8A829EC08
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M08_L13
       mov       rcx,7FF8A829EC04
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L02
M08_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M08_L03
M08_L09:
       mov       rcx,7FF8A829EC20
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M08_L12
       xor       r15d,r15d
M08_L10:
       mov       rcx,7FF8A829EC24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF8A82160B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M08_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M08_L10
M08_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M08_L15
       mov       rcx,7FF8A829EC00
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M08_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       je        short M08_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L11
M08_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8A818E8C8]
M08_L15:
       mov       rcx,7FF8A829EC18
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M08_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M08_L11
M08_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF8A7C05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L11
; Total bytes of code 488
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.ConcatSpan()
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
       mov       r8,[rcx+198]
       test      r8,r8
       je        near ptr M00_L14
       lea       rbx,[r8+10]
       mov       esi,[r8+8]
M00_L00:
       test      esi,esi
       je        near ptr M00_L15
       mov       r8,1DC688001B0
       mov       rdi,[r8]
       mov       r8,[rdi+20]
       mov       [rbp-30],r8
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L17
       lea       r8,[rdi+20]
       mov       rdx,[rbp-30]
       test      r8,r8
       je        near ptr M00_L16
       mov       rcx,r8
       mov       r8,rdx
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-30]
       jne       near ptr M00_L17
M00_L01:
       mov       rdi,[rbp-30]
M00_L02:
       xor       r8d,r8d
       mov       [rbp-30],r8
       mov       [rbp-40],rdi
       xor       edi,edi
       cmp       edi,esi
       jge       near ptr M00_L07
M00_L03:
       mov       r8,[rbx+rdi*8]
       mov       r14,[rbp-40]
       cmp       [r14],r14b
       test      r8,r8
       je        short M00_L05
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L05
       mov       rcx,[r14+8]
       mov       eax,[r14+18]
       lea       r15d,[rax+r8]
       cmp       r15d,[rcx+8]
       ja        near ptr M00_L10
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L08
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       mov       [r14+18],r15d
M00_L05:
       mov       ecx,esi
       sub       ecx,1
       jo        short M00_L09
       cmp       edi,ecx
       jge       short M00_L06
       mov       ecx,[r14+18]
       mov       edx,ecx
       mov       rax,[r14+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M00_L11
       mov       word ptr [rax+rdx*2+10],2C
       inc       ecx
       mov       [r14+18],ecx
M00_L06:
       add       edi,1
       jo        short M00_L09
       cmp       edi,esi
       jl        near ptr M00_L03
M00_L07:
       mov       r14,[rbp-40]
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7ECBCA8]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       short M00_L12
M00_L08:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L04
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L04
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L10:
       mov       rcx,r14
       call      qword ptr [7FF8A7EB7A98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M00_L05
M00_L11:
       mov       rcx,r14
       mov       edx,2C
       call      qword ptr [7FF8A7EB7C60]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M00_L06
M00_L12:
       call      M00_L19
       nop
       mov       r14,[rbp-48]
M00_L13:
       mov       [rbp-38],r14
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+88]
       mov       rdx,[rbp-38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L14:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M00_L00
M00_L15:
       mov       r14,21CE7880008
       jmp       short M00_L13
M00_L16:
       call      qword ptr [7FF8A82C51A0]
       int       3
M00_L17:
       mov       rcx,[rdi+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8234F78]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L18
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L01
M00_L18:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdi,rax
       jmp       near ptr M00_L02
M00_L19:
       sub       rsp,28
       mov       r14,[rbp-40]
       cmp       dword ptr [r14+20],0
       jge       short M00_L20
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rbx,rax
       call      qword ptr [7FF8A82C54E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r14
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       cmp       qword ptr [r14+10],0
       jne       short M00_L21
       xor       ecx,ecx
       mov       [r14+18],rcx
       jmp       near ptr M00_L28
M00_L21:
       mov       ecx,[r14+1C]
       add       ecx,[r14+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L22
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A82C5650]
       jmp       near ptr M00_L28
M00_L22:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FF8A82C5668]
       mov       rbx,rax
       cmp       rbx,r14
       je        near ptr M00_L27
       mov       rax,[r14+8]
       mov       ecx,[rax+8]
       add       ecx,[r14+1C]
       mov       eax,[r14+1C]
       add       eax,[r14+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r14+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L25
       cmp       ecx,400
       jge       short M00_L23
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L24
M00_L23:
       xor       edx,edx
       call      qword ptr [7FF8A81AEB38]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L24:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8A7C2F588]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L26
M00_L25:
       mov       rdx,[rbx+8]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L26:
       mov       rdx,[rbx+10]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r14+1C],ecx
M00_L27:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r14+18],ecx
M00_L28:
       mov       rdx,1DC688001B0
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L30
M00_L29:
       add       rsp,28
       ret
M00_L30:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L32
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L31
       call      qword ptr [7FF8A82C51A0]
       int       3
M00_L31:
       mov       rdx,r14
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L29
M00_L32:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L33
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82C5728]
       test      eax,eax
       jne       short M00_L29
       mov       rcx,rbx
       mov       rdx,r14
       call      qword ptr [7FF8A82C5740]
       jmp       short M00_L29
M00_L33:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L29
; Total bytes of code 1009
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M01_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M01_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M01_L07
       cmp       r8,40
       ja        short M01_L03
M01_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M01_L06
M01_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M01_L02:
       vzeroupper
       ret
M01_L03:
       cmp       r8,800
       ja        near ptr M01_L11
       cmp       r8,100
       jb        short M01_L04
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
M01_L04:
       mov       r9,r8
       shr       r9,6
M01_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L00
       jmp       near ptr M01_L01
M01_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M01_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M01_L01
M01_L07:
       test      r8b,18
       je        short M01_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M01_L02
M01_L08:
       test      r8b,4
       je        short M01_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M01_L02
M01_L09:
       test      r8,r8
       je        near ptr M01_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M01_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M01_L02
M01_L10:
       cmp       rcx,rdx
       jne       short M01_L11
       cmp       [rdx],dl
       jmp       near ptr M01_L02
M01_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF8A7C266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 355
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M02_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M02_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rax,21CE7880008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rbx,rax
       call      qword ptr [7FF8A82C53B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M03_L06
       cmp       eax,esi
       jl        near ptr M03_L06
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        short M03_L01
M03_L00:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M03_L09
       cmp       edx,esi
       jl        near ptr M03_L09
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M03_L10
       cmp       eax,400
       jge       short M03_L03
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M03_L04
M03_L01:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M03_L07
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M03_L08
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M03_L02:
       cmp       ebp,edx
       ja        near ptr M03_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       jmp       near ptr M03_L00
M03_L03:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF8A81AEB38]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M03_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M03_L11
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M03_L05:
       cmp       esi,r8d
       ja        near ptr M03_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82C54A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L07:
       test      ecx,ecx
       jne       short M03_L08
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M03_L02
M03_L08:
       call      qword ptr [7FF8A7DFF210]
       int       3
M03_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B64000
       call      qword ptr [7FF8A7C2F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82C54E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7EBDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A82C5500]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M03_L05
M03_L12:
       call      qword ptr [7FF8A803CFC0]
       int       3
; Total bytes of code 626
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF8D75737D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M04_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8D7558FD8]
       int       3
; Total bytes of code 56
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M05_L01
       cmp       qword ptr [rdi+10],0
       je        short M05_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M05_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M07_L01
       xor       ebp,ebp
       xor       r14d,r14d
M07_L00:
       test      rbx,rbx
       jne       near ptr M07_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M07_L10
M07_L01:
       test      rbx,rbx
       jne       short M07_L04
       mov       rcx,7FF8A82D22AC
       call      CORINFO_HELP_COUNTPROFILE32
M07_L02:
       mov       rcx,7FF8A82D22B4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M07_L08
       xor       r14d,r14d
M07_L03:
       mov       rbp,rsi
       jmp       short M07_L00
M07_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M07_L05
       mov       rcx,7FF8A82D22A8
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L02
M07_L05:
       cmp       dword ptr [r15+4],18
       je        short M07_L06
       mov       rcx,7FF8A82D22A4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L02
M07_L06:
       cmp       edi,[rsi+8]
       jbe       short M07_L07
       mov       rcx,7FF8A82D22A0
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M07_L02
M07_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M07_L13
       mov       rcx,7FF8A82D229C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M07_L02
M07_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M07_L03
M07_L09:
       mov       rcx,7FF8A82D22B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M07_L12
       xor       r15d,r15d
M07_L10:
       mov       rcx,7FF8A82D22BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF8A82360D0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M07_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M07_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M07_L10
M07_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M07_L15
       mov       rcx,7FF8A82D2298
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M07_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       je        short M07_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L11
M07_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8A81AE8C8]
M07_L15:
       mov       rcx,7FF8A82D22B0
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M07_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M07_L11
M07_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF8A7C25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L11
; Total bytes of code 488
```

## .NET 10.0.10 (10.0.10, 10.0.1026.32716), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.PerformActionSpan()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-20],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.Action<System.Text.StringBuilder>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       cmp       qword ptr [rbp+10],0
       je        near ptr M00_L14
       lea       rcx,[rbx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.<PerformActionSpan>b__4_0(System.Text.StringBuilder)
       mov       [rbx+18],rcx
       mov       rcx,205F18001B0
       mov       rsi,[rcx]
       mov       rcx,[rsi+20]
       mov       [rbp-20],rcx
       cmp       qword ptr [rbp-20],0
       je        near ptr M00_L16
       lea       rcx,[rsi+20]
       mov       r8,[rbp-20]
       test      rcx,rcx
       je        near ptr M00_L15
       xor       edx,edx
       call      00007FF907846040
       cmp       rax,[rbp-20]
       jne       near ptr M00_L16
M00_L00:
       mov       rdx,[rbp-20]
M00_L01:
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       [rbp-30],rdx
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.<PerformActionSpan>b__4_0(System.Text.StringBuilder)
       cmp       [rbx+18],r8
       jne       near ptr M00_L11
       mov       rbx,[rbx+8]
       xor       esi,esi
M00_L02:
       mov       r8,[rbx+198]
       cmp       [r8+8],esi
       jle       near ptr M00_L07
       cmp       esi,[r8+8]
       jae       near ptr M00_L12
       mov       r8,[r8+rsi*8+10]
       mov       rdx,[rbp-30]
       cmp       [rdx],dl
       test      r8,r8
       je        short M00_L04
       lea       rax,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M00_L04
       mov       rcx,[rdx+8]
       mov       r10d,[rdx+18]
       lea       edi,[r10+r8]
       cmp       edi,[rcx+8]
       ja        near ptr M00_L09
       movsxd    r10,r10d
       lea       rcx,[rcx+r10*2+10]
       cmp       r8d,2
       jle       short M00_L06
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L03:
       mov       rdx,[rbp-30]
       mov       [rdx+18],edi
M00_L04:
       mov       rcx,[rbx+198]
       mov       ecx,[rcx+8]
       dec       ecx
       cmp       ecx,esi
       jle       short M00_L05
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       short M00_L10
       mov       word ptr [r8+rax*2+10],20
       inc       ecx
       mov       [rdx+18],ecx
M00_L05:
       inc       esi
       jmp       near ptr M00_L02
M00_L06:
       movzx     r10d,word ptr [rax]
       mov       [rcx],r10w
       cmp       r8d,2
       jne       short M00_L03
       jmp       short M00_L08
M00_L07:
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A7EDB9A0]; System.Text.StringBuilder.ToString()
       mov       [rbp-38],rax
       jmp       short M00_L13
M00_L08:
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M00_L03
M00_L09:
       mov       rdx,[rbp-30]
       mov       rcx,rdx
       mov       rdx,rax
       call      qword ptr [7FF8A7EC7A98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rdx,[rbp-30]
       jmp       short M00_L04
M00_L10:
       mov       rcx,rdx
       mov       edx,20
       call      qword ptr [7FF8A7EC7C60]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-30]
       jmp       short M00_L05
M00_L11:
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       short M00_L07
M00_L12:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L13:
       call      M00_L18
       nop
       mov       r8,[rbp-38]
       mov       [rbp-28],r8
       mov       rdx,[rbp+10]
       mov       rbx,[rdx+88]
       mov       rdx,[rbp-28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L14:
       call      qword ptr [7FF8A82D4F90]
       int       3
M00_L15:
       call      qword ptr [7FF8A82D5398]
       int       3
M00_L16:
       mov       rcx,[rsi+18]
       lea       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A8244F60]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L17
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M00_L00
M00_L17:
       mov       rax,[rsi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L18:
       sub       rsp,28
       mov       rcx,[rbp-30]
       cmp       dword ptr [rcx+20],0
       jge       short M00_L19
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF8A7B74000
       call      qword ptr [7FF8A7C3F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82D54E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7ECDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       cmp       qword ptr [rcx+10],0
       jne       short M00_L20
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M00_L27
M00_L20:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L21
       xor       edx,edx
       call      qword ptr [7FF8A82D5650]
       mov       rcx,[rbp-30]
       jmp       near ptr M00_L27
M00_L21:
       xor       edx,edx
       call      qword ptr [7FF8A82D5668]
       mov       rbx,rax
       mov       rcx,[rbp-30]
       cmp       rbx,rcx
       je        near ptr M00_L26
       mov       rax,[rcx+8]
       mov       r8d,[rax+8]
       add       r8d,[rcx+1C]
       mov       eax,[rcx+1C]
       add       eax,[rcx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r10d,66666667
       mov       eax,r10d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rcx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       r8d,edx
       cmovg     r8d,edx
       sub       r8d,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],r8d
       jge       short M00_L24
       cmp       r8d,400
       jge       short M00_L22
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L23
M00_L22:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FF8A81BEB20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L23:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF8A7C3F588]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-30]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L25
M00_L24:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-30]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L25:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-30]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rsi,[rbp-30]
       mov       [rsi+1C],ecx
       mov       rcx,rsi
M00_L26:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M00_L27:
       mov       rdx,205F18001B0
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L29
M00_L28:
       add       rsp,28
       ret
M00_L29:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L31
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L30
       call      qword ptr [7FF8A82D5398]
       int       3
M00_L30:
       mov       rdx,[rbp-30]
       xor       r8d,r8d
       call      00007FF907846040
       test      rax,rax
       je        short M00_L28
M00_L31:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L32
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF8A82D5710]
       test      eax,eax
       jne       short M00_L28
       mov       rcx,rbx
       mov       rdx,[rbp-30]
       call      qword ptr [7FF8A82D5728]
       jmp       short M00_L28
M00_L32:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L28
; Total bytes of code 1106
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.FastStringBuilderSpanBenchmark.<PerformActionSpan>b__4_0(System.Text.StringBuilder)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       xor       edi,edi
M01_L00:
       mov       r8,[rsi+198]
       cmp       [r8+8],edi
       jle       near ptr M01_L05
       cmp       edi,[r8+8]
       jae       near ptr M01_L09
       mov       r8,[r8+rdi*8+10]
       cmp       [rbx],bl
       test      r8,r8
       je        short M01_L02
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       test      r8d,r8d
       je        short M01_L02
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       ebp,[rax+r8]
       cmp       ebp,[rcx+8]
       ja        short M01_L07
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M01_L04
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       [rbx+18],ebp
M01_L02:
       mov       rcx,[rsi+198]
       mov       ecx,[rcx+8]
       dec       ecx
       cmp       ecx,edi
       jle       short M01_L03
       mov       ecx,[rbx+18]
       mov       edx,ecx
       mov       rax,[rbx+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       short M01_L08
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rbx+18],ecx
M01_L03:
       inc       edi
       jmp       near ptr M01_L00
M01_L04:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M01_L01
       jmp       short M01_L06
M01_L05:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M01_L06:
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M01_L01
M01_L07:
       mov       rcx,rbx
       call      qword ptr [7FF8A7EC7A98]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M01_L02
M01_L08:
       mov       rcx,rbx
       mov       edx,20
       call      qword ptr [7FF8A7EC7C60]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       short M01_L03
M01_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M02_L07
       cmp       r8,40
       ja        short M02_L03
M02_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        near ptr M02_L06
M02_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L02:
       vzeroupper
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L11
       cmp       r8,100
       jb        short M02_L04
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
M02_L04:
       mov       r9,r8
       shr       r9,6
M02_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M02_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M02_L00
       jmp       near ptr M02_L01
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       near ptr M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M02_L01
M02_L07:
       test      r8b,18
       je        short M02_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M02_L02
M02_L08:
       test      r8b,4
       je        short M02_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       near ptr M02_L02
M02_L09:
       test      r8,r8
       je        near ptr M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M02_L02
M02_L10:
       cmp       rcx,rdx
       jne       short M02_L11
       cmp       [rdx],dl
       jmp       near ptr M02_L02
M02_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF8A7C366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 355
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M03_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF9078A50F0
       mov       rsi,rax
M03_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M03_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M03_L03
       cmp       [rdx+8],r8d
       jb        short M03_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M03_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rax,246705F0008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF8A7B74000
       call      qword ptr [7FF8A7C3F210]
       mov       rbx,rax
       call      qword ptr [7FF8A82D53B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8A7ECDA28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rdi,rdx
       mov       esi,r8d
       mov       eax,[rbx+1C]
       mov       ecx,[rbx+18]
       add       eax,ecx
       add       eax,esi
       cmp       eax,[rbx+20]
       jg        near ptr M04_L06
       cmp       eax,esi
       jl        near ptr M04_L06
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jg        short M04_L01
M04_L00:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M04_L09
       cmp       edx,esi
       jl        near ptr M04_L09
       add       ecx,eax
       mov       edx,ecx
       mov       eax,1F40
       cmp       edx,1F40
       cmovg     edx,eax
       cmp       esi,edx
       mov       eax,edx
       cmovge    eax,esi
       add       ecx,eax
       cmp       ecx,eax
       jl        near ptr M04_L10
       cmp       eax,400
       jge       short M04_L03
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M04_L04
M04_L01:
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M04_L07
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M04_L08
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M04_L02:
       cmp       ebp,edx
       ja        near ptr M04_L12
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
       jmp       near ptr M04_L00
M04_L03:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF8A81BEB20]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M04_L04:
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       ecx,[rbx+18]
       mov       [r15+18],ecx
       mov       ecx,[rbx+1C]
       mov       [r15+1C],ecx
       mov       rdx,[rbx+8]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbx+10]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+20]
       mov       [r15+20],ecx
       lea       rcx,[rbx+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+18]
       add       [rbx+1C],ecx
       xor       ecx,ecx
       mov       [rbx+18],ecx
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       movsxd    r8,ebp
       lea       rdx,[rdi+r8*2]
       mov       r8,[rbx+8]
       test      r8,r8
       je        near ptr M04_L11
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M04_L05:
       cmp       esi,r8d
       ja        near ptr M04_L12
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M04_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF8A7B74000
       call      qword ptr [7FF8A7C3F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82D54A0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7ECDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L07:
       test      ecx,ecx
       jne       short M04_L08
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M04_L02
M04_L08:
       call      qword ptr [7FF8A7E0F210]
       int       3
M04_L09:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF8A7B74000
       call      qword ptr [7FF8A7C3F210]
       mov       rsi,rax
       call      qword ptr [7FF8A82D54E8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF8A7ECDA28]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF8A82D5500]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L11:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M04_L05
M04_L12:
       call      qword ptr [7FF8A804CFC0]
       int       3
; Total bytes of code 626
```
```assembly
; System.Text.StringBuilder.AppendWithExpansion(Char)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FF8D75737D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M05_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF8D7558FD8]
       int       3
; Total bytes of code 56
```
```assembly
; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+18]
       mov       rcx,rdi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF8D757EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M06_L01
       cmp       qword ptr [rdi+10],0
       je        short M06_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M06_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M06_L01:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       lea       rbp,[rsp+0E0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       r8d,ecx
       mov       ecx,10
       mov       r9d,50
       test      dl,dl
       cmovne    ecx,r9d
       mov       [rbp-3C],ecx
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       [rbp-0B0],rcx
       mov       edx,r8d
       mov       [rbp-0A4],edx
       mov       r8d,[rbp-3C]
       mov       [rbp-0A8],r8d
       lea       r9,[rbp-48]
       mov       [rbp-0B8],r9
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8D7559038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-48]
       add       rsp,0A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 193
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       jne       short M08_L01
       xor       ebp,ebp
       xor       r14d,r14d
M08_L00:
       test      rbx,rbx
       jne       near ptr M08_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M08_L10
M08_L01:
       test      rbx,rbx
       jne       short M08_L04
       mov       rcx,7FF8A82CE25C
       call      CORINFO_HELP_COUNTPROFILE32
M08_L02:
       mov       rcx,7FF8A82CE264
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M08_L08
       xor       r14d,r14d
M08_L03:
       mov       rbp,rsi
       jmp       short M08_L00
M08_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M08_L05
       mov       rcx,7FF8A82CE258
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L05:
       cmp       dword ptr [r15+4],18
       je        short M08_L06
       mov       rcx,7FF8A82CE254
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L06:
       cmp       edi,[rsi+8]
       jbe       short M08_L07
       mov       rcx,7FF8A82CE250
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M08_L02
M08_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M08_L13
       mov       rcx,7FF8A82CE24C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M08_L02
M08_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M08_L03
M08_L09:
       mov       rcx,7FF8A82CE268
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M08_L12
       xor       r15d,r15d
M08_L10:
       mov       rcx,7FF8A82CE26C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF8A82460B8]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M08_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M08_L10
M08_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M08_L15
       mov       rcx,7FF8A82CE248
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M08_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF90782A2B0
       cmp       dword ptr [7FF907B64A90],0
       je        short M08_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L11
M08_L14:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       jmp       qword ptr [7FF8A81BE910]
M08_L15:
       mov       rcx,7FF8A82CE260
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M08_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M08_L11
M08_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF8A7C35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M08_L11
; Total bytes of code 488
```

