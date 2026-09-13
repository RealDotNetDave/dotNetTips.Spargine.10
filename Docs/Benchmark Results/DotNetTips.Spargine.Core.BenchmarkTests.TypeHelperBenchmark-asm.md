## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypeNames_NoCache_ForComparison()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF86C337060]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypeNamesNoCache()
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypeNamesNoCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,4F8
       vzeroupper
       lea       rbp,[rsp+530]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFBE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,20A0A801070
       mov       rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-450],rbx
       mov       rcx,offset MT_System.Type[]
       mov       [rbp-2A8],rcx
       lea       rcx,[rbp-2A8]
       mov       dword ptr [rcx+8],0D
       lea       rcx,[rbp-2A8]
       mov       r8,24A9F9A5368
       mov       [rcx+10],r8
       mov       r8,24A9F9A2ED0
       mov       [rcx+18],r8
       mov       r8,24A9F9A5390
       mov       [rcx+20],r8
       mov       r8,24A9F9A62E0
       mov       [rcx+28],r8
       mov       r8,24A9F9A5458
       mov       [rcx+30],r8
       mov       r8,24A9F9A5430
       mov       [rcx+38],r8
       mov       r8,24A9F9A3120
       mov       [rcx+40],r8
       mov       r8,24A9F9A5408
       mov       [rcx+48],r8
       mov       r8,24A9F9A53B8
       mov       [rcx+50],r8
       mov       r8,24A9F9A53E0
       mov       [rcx+58],r8
       mov       r8,24A9F9A2E58
       mov       [rcx+60],r8
       mov       r8,24A9F9A2C50
       mov       [rcx+68],r8
       mov       r8,24A9F9A3070
       mov       [rcx+70],r8
       mov       byte ptr [rbp-3F],1
       mov       byte ptr [rbp-3E],1
       mov       word ptr [rbp-3C],2B
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],0D
       jl        near ptr M01_L37
M01_L01:
       mov       rdi,[rbp-450]
       mov       rcx,offset MT_System.Type[]
       mov       [rbp-428],rcx
       lea       rcx,[rbp-428]
       mov       dword ptr [rcx+8],2E
       lea       rcx,[rbp-428]
       mov       rdx,24A9F9A0020
       mov       [rcx+10],rdx
       mov       rdx,24A9F9A19B8
       mov       [rcx+18],rdx
       mov       rdx,24A9F9A2AC8
       mov       [rcx+20],rdx
       mov       rdx,24A9F9ABC68
       mov       [rcx+28],rdx
       mov       rdx,24A9F9AC7B0
       mov       [rcx+30],rdx
       mov       rdx,24A9F9A2E80
       mov       [rcx+38],rdx
       mov       rdx,24A9F9AC918
       mov       [rcx+40],rdx
       mov       rdx,24A9F9B1CB8
       mov       [rcx+48],rdx
       mov       rdx,24A9F9AC490
       mov       [rcx+50],rdx
       mov       rdx,24A9F9A3048
       mov       [rcx+58],rdx
       mov       rdx,24A9F9A5480
       mov       [rcx+60],rdx
       mov       rdx,24A9F9B1CE0
       mov       [rcx+68],rdx
       mov       rdx,24A9F9AE440
       mov       [rcx+70],rdx
       mov       rdx,24A9F9B1D08
       mov       [rcx+78],rdx
       mov       rdx,24A9F9B1D30
       mov       [rcx+80],rdx
       mov       rdx,24A9F9A3568
       mov       [rcx+88],rdx
       mov       rdx,24A9F9B1D58
       mov       [rcx+90],rdx
       mov       rdx,24A9F9B1D80
       mov       [rcx+98],rdx
       mov       rdx,24A9F9B1DA8
       mov       [rcx+0A0],rdx
       mov       rdx,24A9F9B1DD0
       mov       [rcx+0A8],rdx
       mov       rdx,24A9F9B1290
       mov       [rcx+0B0],rdx
       mov       rdx,24A9F9AE590
       mov       [rcx+0B8],rdx
       mov       rdx,24A9F9AE5B8
       mov       [rcx+0C0],rdx
       mov       rdx,24A9F9B1DF8
       mov       [rcx+0C8],rdx
       mov       rdx,24A9F9B1E20
       mov       [rcx+0D0],rdx
       mov       rdx,24A9F9B1E48
       mov       [rcx+0D8],rdx
       mov       rdx,24A9F9B1E70
       mov       [rcx+0E0],rdx
       mov       rdx,24A9F9B1E98
       mov       [rcx+0E8],rdx
       mov       rdx,24A9F9B1EC0
       mov       [rcx+0F0],rdx
       mov       rdx,24A9F9B1EE8
       mov       [rcx+0F8],rdx
       mov       rdx,24A9F9B1F10
       mov       [rcx+100],rdx
       mov       rdx,24A9F9B1F38
       mov       [rcx+108],rdx
       mov       rdx,24A9F9B1F60
       mov       [rcx+110],rdx
       mov       rdx,24A9F9B1F88
       mov       [rcx+118],rdx
       mov       rdx,24A9F9B1FB0
       mov       [rcx+120],rdx
       mov       rdx,24A9F9B1FD8
       mov       [rcx+128],rdx
       mov       rdx,24A9F9B2000
       mov       [rcx+130],rdx
       mov       rdx,24A9F9B2028
       mov       [rcx+138],rdx
       mov       rdx,24A9F9B2050
       mov       [rcx+140],rdx
       mov       rdx,24A9F9B2078
       mov       [rcx+148],rdx
       mov       rdx,24A9F9B20A0
       mov       [rcx+150],rdx
       mov       rdx,24A9F9B20C8
       mov       [rcx+158],rdx
       mov       rdx,24A9F9B20F0
       mov       [rcx+160],rdx
       mov       rdx,24A9F9B2118
       mov       [rcx+168],rdx
       mov       rdx,24A9F9B2140
       mov       [rcx+170],rdx
       mov       rdx,24A9F9B2168
       mov       [rcx+178],rdx
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],2E
       jl        near ptr M01_L75
M01_L02:
       mov       rcx,24A9F9A3120
       call      00007FF8CB8461E0
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L163
M01_L03:
       test      rcx,rcx
       je        near ptr M01_L164
       mov       rax,offset MT_System.Reflection.RuntimeModule
       cmp       [rcx],rax
       jne       near ptr M01_L165
       mov       rcx,[rcx+10]
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L166
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M01_L167
       call      qword ptr [7FF86BD60218]; System.Reflection.Assembly.GetTypes()
       mov       rbx,rax
M01_L05:
       mov       rcx,20A20800308
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M01_L168
M01_L06:
       test      rbx,rbx
       je        near ptr M01_L173
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L169
       mov       r14,rbx
       test      r14,r14
       je        near ptr M01_L171
       cmp       dword ptr [r14+8],0
       je        near ptr M01_L170
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+10],eax
       lea       rcx,[r15+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+20]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       test      r15,r15
       je        near ptr M01_L173
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L184
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Type>
       cmp       [rax],rdx
       jne       near ptr M01_L183
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M01_L96
       lea       r15,[rdx+10]
       mov       ebx,[rdx+8]
M01_L08:
       mov       rsi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0E0],ymm0
       vmovdqu   ymmword ptr [rbp-0C0],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1D8],ymm0
       vmovdqu   ymmword ptr [rbp-1B8],ymm0
       vmovdqu   ymmword ptr [rbp-198],ymm0
       vmovdqu   ymmword ptr [rbp-178],ymm0
       vmovdqu   ymmword ptr [rbp-158],ymm0
       vmovdqu   ymmword ptr [rbp-138],ymm0
       vmovdqu   ymmword ptr [rbp-120],ymm0
       xor       edx,edx
       mov       [rbp-1E8],edx
       mov       [rbp-1E4],edx
       mov       [rbp-1E0],edx
       lea       rdx,[rbp-0E0]
       mov       [rbp-100],rdx
       mov       dword ptr [rbp-0F8],8
       lea       rdx,[rbp-0E0]
       mov       [rbp-0F0],rdx
       mov       dword ptr [rbp-0E8],8
       test      ebx,ebx
       jle       short M01_L11
       xor       r14d,r14d
M01_L09:
       mov       r13,[r15+r14]
       mov       rdx,r13
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       test      eax,eax
       je        short M01_L10
       mov       rcx,[rbp-0F0]
       mov       edx,[rbp-0E8]
       mov       eax,[rbp-1E0]
       cmp       eax,edx
       jae       near ptr M01_L174
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rbp-1E0]
       inc       ecx
       mov       [rbp-1E0],ecx
M01_L10:
       add       r14,8
       dec       ebx
       jne       short M01_L09
M01_L11:
       mov       ebx,[rbp-1E4]
       add       ebx,[rbp-1E0]
       jo        near ptr M01_L206
       test      ebx,ebx
       je        near ptr M01_L97
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      ebx,ebx
       jl        near ptr M01_L175
       mov       edx,ebx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       r8,[rsi+8]
       cmp       [r8+8],ebx
       jge       near ptr M01_L128
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M01_L129
       mov       edx,4
M01_L12:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,ebx
       cmovl     edx,ebx
       mov       rcx,rsi
       call      qword ptr [7FF86BD9E3E8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L13:
       mov       [rsi+10],ebx
       mov       ebx,[rsi+10]
       mov       r14,[rsi+8]
       cmp       [r14+8],ebx
       jae       near ptr M01_L130
M01_L14:
       call      qword ptr [7FF86BE4C2A0]
       int       3
M01_L15:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86BC25A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L26
M01_L16:
       mov       rcx,r13
       call      qword ptr [7FF86BC2E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L28
M01_L17:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       r9,[r14+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L141
       test      r9,r9
       je        near ptr M01_L32
       mov       rcx,r9
       mov       rdx,rsi
       mov       r8,[r9]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       test      eax,eax
       je        near ptr M01_L32
M01_L18:
       mov       r10,[rbp-4F8]
       lea       rcx,[r10+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L36
M01_L19:
       mov       ecx,[rdi+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L142
M01_L20:
       mov       ecx,eax
       call      qword ptr [7FF86BC25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r8d,eax
M01_L21:
       mov       rcx,rdi
       mov       edx,r8d
       xor       r8d,r8d
       call      qword ptr [7FF86BD9F3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,[rdi+8]
       mov       edx,r13d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M01_L205
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       r14,rax
       mov       [rbp-470],r14
       jmp       near ptr M01_L34
M01_L22:
       mov       ecx,[rdi+3C]
       mov       r8d,ecx
       cmp       ecx,[r14+8]
       jae       near ptr M01_L205
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+3C],ecx
       dec       dword ptr [rdi+40]
       mov       eax,r8d
       mov       r8,r14
       mov       r14d,eax
       jmp       near ptr M01_L35
M01_L23:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86BC25A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L76
M01_L24:
       mov       rcx,r13
       call      qword ptr [7FF86BC2E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L78
M01_L25:
       call      M01_L207
       nop
       mov       rbx,[rbp-460]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rsi,[rbp-458]
       mov       rdi,[rbp-450]
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L15
M01_L26:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L140
       mov       rcx,[rbp-458]
       mov       [rbp-78],rcx
       xor       ecx,ecx
       mov       [rbp-80],rcx
       lea       rcx,[rbp-78]
       cmp       qword ptr [rbp-80],0
       jne       short M01_L27
       mov       rcx,[rbp-78]
       mov       [rbp-80],rcx
       lea       rcx,[rbp-80]
       cmp       qword ptr [rbp-80],0
       je        near ptr M01_L138
M01_L27:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L139
       mov       rcx,r13
       call      00007FF8CB813FE0
       test      eax,eax
       je        near ptr M01_L16
M01_L28:
       mov       r13d,eax
M01_L29:
       xor       ecx,ecx
       mov       [rbp-80],rcx
M01_L30:
       xor       r12d,r12d
       mov       rcx,[rdi+8]
       mov       edx,r13d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L205
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rbp-470],rax
       mov       r8d,[rax]
       dec       r8d
       cmp       [r14+8],r8d
       jbe       short M01_L33
M01_L31:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r10,[r14+rcx*8+10]
       mov       [rbp-4F8],r10
       cmp       [r10+10],r13d
       je        near ptr M01_L17
M01_L32:
       mov       r10,[rbp-4F8]
       mov       r8d,[r10+14]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M01_L14
       cmp       [r14+8],r8d
       ja        short M01_L31
M01_L33:
       cmp       dword ptr [rdi+40],0
       jg        near ptr M01_L22
       mov       edx,[rdi+38]
       mov       [rbp-6C],edx
       cmp       [r14+8],edx
       je        near ptr M01_L19
M01_L34:
       mov       edx,[rbp-6C]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rdi+38],ecx
       mov       rcx,[rdi+10]
       mov       r8,rcx
M01_L35:
       cmp       r14d,[r8+8]
       jae       near ptr M01_L205
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-468],r8
       lea       r10,[r8+rcx*8+10]
       mov       [rbp-478],r10
       mov       [r10+10],r13d
       mov       rax,[rbp-470]
       mov       ecx,[rax]
       dec       ecx
       mov       [r10+14],ecx
       mov       rcx,r10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-478]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rbx,[rbp-470]
       mov       [rbx],r14d
       inc       dword ptr [rdi+44]
       cmp       r12d,64
       ja        near ptr M01_L143
M01_L36:
       mov       eax,[rbp-4C]
       inc       eax
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0D
       jge       near ptr M01_L01
M01_L37:
       mov       rcx,[rbp-48]
       mov       r8d,[rbp-4C]
       mov       rcx,[rcx+r8*8+10]
       mov       [rbp-458],rcx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-460],rcx
       cmp       qword ptr [rbp-458],0
       je        near ptr M01_L144
       mov       rcx,20A20800338
       mov       rbx,[rcx]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,[rbx+20]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        near ptr M01_L136
       lea       rcx,[rbx+20]
       mov       r8,[rbp-60]
       test      rcx,rcx
       je        near ptr M01_L145
       xor       edx,edx
       call      00007FF8CB8421C0
       cmp       rax,[rbp-60]
       jne       near ptr M01_L136
M01_L38:
       mov       rbx,[rbp-60]
M01_L39:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-58],rbx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-458]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L55
       mov       rcx,[rbp-458]
       mov       rcx,[rcx+18]
       test      cl,2
       jne       near ptr M01_L54
       test      dword ptr [rcx],80000000
       je        short M01_L42
       xor       eax,eax
       jmp       short M01_L43
M01_L40:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FF86BD94B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
       jmp       near ptr M01_L50
M01_L41:
       cmp       byte ptr [rbp-3F],0
       je        near ptr M01_L53
       jmp       near ptr M01_L62
M01_L42:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M01_L43:
       movzx     ebx,al
M01_L44:
       test      ebx,ebx
       jne       near ptr M01_L56
       mov       rcx,[rbp-458]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L59
       mov       rcx,[rbp-458]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L57
M01_L45:
       cmp       ebx,14
       je        near ptr M01_L58
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M01_L46:
       test      eax,eax
       jne       near ptr M01_L60
       mov       rcx,[rbp-458]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L61
       mov       rcx,[rbp-458]
       call      00007FF8CB848F60
M01_L47:
       test      eax,eax
       jne       near ptr M01_L41
       mov       rbx,[rbp-58]
       movzx     ecx,byte ptr [rbp-40]
       movzx     esi,word ptr [rbp-3C]
       test      cl,cl
       jne       near ptr M01_L63
M01_L48:
       mov       rcx,[rbp-458]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L65
       mov       rcx,[rbp-458]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L64
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L64
M01_L49:
       mov       rdi,[rcx+18]
       test      rdi,rdi
       je        near ptr M01_L40
M01_L50:
       cmp       [rbx],bl
       test      rdi,rdi
       je        short M01_L52
       lea       rdx,[rdi+0C]
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        short M01_L52
       mov       r8,[rbx+8]
       mov       r15d,[rbx+18]
       lea       ecx,[r15+r14]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L69
       movsxd    rcx,r15d
       lea       rcx,[r8+rcx*2+10]
       cmp       r14d,2
       jle       near ptr M01_L67
       mov       r8d,r14d
       add       r8,r8
       call      qword ptr [7FF86BC25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L51:
       add       r14d,r15d
       mov       [rbx+18],r14d
M01_L52:
       movzx     r9d,si
       cmp       r9d,2B
       jne       near ptr M01_L70
M01_L53:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BE12200]; System.Text.StringBuilder.ToString()
       mov       [rbp-460],rax
       jmp       near ptr M01_L25
M01_L54:
       xor       eax,eax
       jmp       near ptr M01_L43
M01_L55:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       ebx,eax
       jmp       near ptr M01_L44
M01_L56:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rcx,[rbp-58]
       mov       r9d,[rax+8]
       mov       edx,[rbp-40]
       mov       [rbp-438],edx
       mov       dx,[rbp-3C]
       mov       [rbp-434],dx
       lea       rdx,[rbp-438]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-458]
       mov       r8,rax
       call      qword ptr [7FF86C337BB8]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       jmp       near ptr M01_L53
M01_L57:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L45
M01_L58:
       mov       eax,1
       jmp       near ptr M01_L46
M01_L59:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L46
M01_L60:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       lea       rcx,[rbp-58]
       lea       rdx,[rbp-68]
       lea       r8,[rbp-40]
       call      qword ptr [7FF86C3374F8]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-58]
       mov       rdx,24A9F9B2500
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD9F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L53
M01_L61:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L47
M01_L62:
       mov       rbx,[rbp-58]
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD9F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L53
M01_L63:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       test      rax,rax
       jne       short M01_L66
       jmp       near ptr M01_L48
M01_L64:
       mov       rcx,[rbp-458]
       call      qword ptr [7FF86BC27C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L49
M01_L65:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M01_L50
M01_L66:
       mov       rcx,[rbp-458]
       mov       rax,[rbp-458]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L50
M01_L67:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r14d,2
       jne       near ptr M01_L51
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L51
M01_L68:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L69:
       mov       rcx,rbx
       mov       r8d,r14d
       call      qword ptr [7FF86BD9F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L52
M01_L70:
       mov       r9d,[rbx+1C]
       add       r9d,[rbx+18]
       sub       r9d,[rdi+8]
       jo        short M01_L68
       mov       r8d,[rdi+8]
       mov       [rsp+20],r8d
       movzx     r8d,si
       mov       rcx,rbx
       mov       edx,2B
       call      qword ptr [7FF86C337C48]; System.Text.StringBuilder.Replace(Char, Char, Int32, Int32)
       jmp       near ptr M01_L53
M01_L71:
       cmp       dword ptr [rdi+40],0
       jg        near ptr M01_L95
       mov       edx,[rdi+38]
       mov       [rbp-84],edx
       cmp       [r14+8],edx
       je        near ptr M01_L85
M01_L72:
       mov       edx,[rbp-84]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rdi+38],ecx
       mov       rcx,[rdi+10]
       mov       r8,rcx
M01_L73:
       cmp       r14d,[r8+8]
       jae       near ptr M01_L205
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-480],r8
       lea       r10,[r8+rcx*8+10]
       mov       [rbp-490],r10
       mov       [r10+10],r13d
       mov       rax,[rbp-488]
       mov       ecx,[rax]
       dec       ecx
       mov       [r10+14],ecx
       mov       rcx,r10
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-490]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rbx,[rbp-488]
       mov       [rbx],r14d
       inc       dword ptr [rdi+44]
       cmp       r12d,64
       ja        near ptr M01_L162
M01_L74:
       mov       ecx,[rbp-4C]
       inc       ecx
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],2E
       jge       near ptr M01_L02
M01_L75:
       mov       rcx,[rbp-48]
       mov       edx,[rbp-4C]
       mov       rbx,[rcx+rdx*8+10]
       mov       dword ptr [rsp+20],2E
       mov       rcx,rbx
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF86C3374B0]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M01_L185
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L23
M01_L76:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L148
       mov       [rbp-90],rbx
       xor       ecx,ecx
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       cmp       qword ptr [rbp-98],0
       jne       short M01_L77
       mov       rcx,[rbp-90]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-98]
       cmp       qword ptr [rbp-98],0
       je        near ptr M01_L146
M01_L77:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L147
       mov       rcx,r13
       call      00007FF8CB813FE0
       test      eax,eax
       je        near ptr M01_L24
M01_L78:
       mov       r13d,eax
M01_L79:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M01_L80:
       xor       r12d,r12d
       mov       rcx,[rdi+8]
       mov       edx,r13d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L205
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rbp-488],rax
       mov       r8d,[rax]
       dec       r8d
       cmp       [r14+8],r8d
       jbe       near ptr M01_L71
M01_L81:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       r10,[r14+rcx*8+10]
       mov       [rbp-4F0],r10
       cmp       [r10+10],r13d
       je        short M01_L83
M01_L82:
       mov       r10,[rbp-4F0]
       mov       r8d,[r10+14]
       inc       r12d
       cmp       [r14+8],r12d
       jb        near ptr M01_L14
       cmp       [r14+8],r8d
       ja        short M01_L81
       jmp       near ptr M01_L71
M01_L83:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       r9,[r14+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L149
       test      r9,r9
       je        short M01_L82
       mov       rcx,r9
       mov       rdx,rbx
       mov       r8,[r9]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       test      eax,eax
       je        short M01_L82
M01_L84:
       mov       r10,[rbp-4F0]
       lea       rcx,[r10+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L74
M01_L85:
       mov       ecx,[rdi+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L150
M01_L86:
       mov       ecx,eax
       call      qword ptr [7FF86BC25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r14d,eax
M01_L87:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-498],rax
       mov       r10d,[rdi+38]
       mov       [rbp-9C],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-4A0],rdx
       test      rdx,rdx
       je        near ptr M01_L158
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M01_L155
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L154
       cmp       r10d,[rdx+8]
       ja        near ptr M01_L153
       cmp       r10d,[rax+8]
       ja        near ptr M01_L152
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L157
       mov       rax,[rbp-498]
       cmp       r8,4000
       ja        near ptr M01_L156
       mov       rcx,r9
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L151
M01_L88:
       movsxd    rdx,r14d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r14d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+30],rax
       xor       ecx,ecx
       mov       r14d,[rbp-9C]
       test      r14d,r14d
       jle       near ptr M01_L94
       mov       r8,[rbp-498]
       cmp       [r8+8],r14d
       jl        near ptr M01_L161
M01_L89:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [r8+rdx*8+24],0FFFFFFFF
       jl        short M01_L90
       mov       eax,[r8+rdx*8+20]
       mov       r10,[rdi+8]
       mov       r9d,eax
       imul      r9,[rdi+30]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       imul      r9,r11
       shr       r9,20
       cmp       r9d,[r10+8]
       jae       near ptr M01_L205
       mov       eax,r9d
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [r8+rdx*8+24],r10d
       lea       r9d,[rcx+1]
       mov       [rax],r9d
M01_L90:
       inc       ecx
       cmp       ecx,r14d
       jl        short M01_L89
M01_L91:
       lea       rcx,[rdi+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       edx,r13d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L205
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       r14,rax
       mov       [rbp-488],r14
       jmp       near ptr M01_L72
M01_L92:
       cmp       ecx,[r8+8]
       jae       near ptr M01_L205
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       lea       rdx,[r8+rdx*8+10]
       cmp       dword ptr [rdx+14],0FFFFFFFF
       jl        short M01_L93
       mov       eax,[rdx+10]
       mov       r10,[rdi+8]
       mov       r9d,eax
       imul      r9,[rdi+30]
       shr       r9,20
       inc       r9
       mov       eax,[r10+8]
       imul      r9,rax
       shr       r9,20
       cmp       r9d,[r10+8]
       jae       near ptr M01_L205
       mov       eax,r9d
       lea       rax,[r10+rax*4+10]
       mov       r10d,[rax]
       dec       r10d
       mov       [rdx+14],r10d
       lea       edx,[rcx+1]
       mov       [rax],edx
M01_L93:
       inc       ecx
       cmp       ecx,r14d
       jl        short M01_L92
       jmp       near ptr M01_L91
M01_L94:
       mov       r8,[rbp-498]
       jmp       near ptr M01_L91
M01_L95:
       mov       ecx,[rdi+3C]
       mov       r8d,ecx
       cmp       ecx,[r14+8]
       jae       near ptr M01_L205
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+3C],ecx
       dec       dword ptr [rdi+40]
       mov       eax,r8d
       mov       r8,r14
       mov       r14d,eax
       jmp       near ptr M01_L73
M01_L96:
       xor       r15d,r15d
       xor       ebx,ebx
       jmp       near ptr M01_L08
M01_L97:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,20A0A801B60
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L98:
       mov       r8d,[rbp-1E8]
       test      r8d,r8d
       jne       near ptr M01_L182
M01_L99:
       mov       ebx,[rsi+14]
       xor       r14d,r14d
       jmp       near ptr M01_L103
M01_L100:
       cmp       dword ptr [rdi+40],0
       jg        near ptr M01_L126
       mov       edx,[rdi+38]
       mov       [rbp-218],edx
       cmp       [r12+8],edx
       je        near ptr M01_L115
M01_L101:
       mov       edx,[rbp-218]
       mov       r12d,edx
       lea       ecx,[r12+1]
       mov       [rdi+38],ecx
       mov       rcx,[rdi+10]
       mov       r9,rcx
M01_L102:
       cmp       r12d,[r9+8]
       jae       near ptr M01_L205
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-4A8],r9
       lea       r11,[r9+rcx*8+10]
       mov       [rbp-4C0],r11
       mov       [r11+10],eax
       mov       r10,[rbp-4B8]
       mov       ecx,[r10]
       dec       ecx
       mov       [r11+14],ecx
       mov       rcx,r11
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rbp-4C0]
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       r15,[rbp-4B8]
       mov       [r15],r12d
       inc       dword ptr [rdi+44]
       cmp       dword ptr [rbp-210],64
       ja        near ptr M01_L203
M01_L103:
       cmp       ebx,[rsi+14]
       jne       near ptr M01_L204
       cmp       r14d,[rsi+10]
       jae       near ptr M01_L127
       mov       rcx,[rsi+8]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L205
       mov       r15,[rcx+r14*8+10]
       inc       r14d
       mov       dword ptr [rsp+20],2E
       mov       rcx,r15
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF86C3374B0]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
       mov       r13,rax
       test      r15,r15
       je        near ptr M01_L185
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L134
M01_L104:
       mov       r12,[rdi+10]
       mov       rax,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       mov       [rbp-4B0],rax
       cmp       [rax],rcx
       jne       near ptr M01_L188
       mov       rax,[rbp-4B0]
       mov       [rbp-220],r15
       xor       ecx,ecx
       mov       [rbp-228],rcx
       lea       rcx,[rbp-220]
       cmp       qword ptr [rbp-228],0
       jne       short M01_L105
       mov       rcx,[rbp-220]
       mov       [rbp-228],rcx
       lea       rcx,[rbp-228]
       cmp       qword ptr [rbp-228],0
       je        near ptr M01_L186
M01_L105:
       mov       rdx,[rcx]
       mov       [rbp-4D8],rdx
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdx],rcx
       jne       near ptr M01_L187
       mov       [rbp-4B0],rax
       mov       rcx,rdx
       call      00007FF8CB813FE0
       test      eax,eax
       je        near ptr M01_L135
M01_L106:
       mov       edx,eax
M01_L107:
       mov       eax,edx
M01_L108:
       xor       ecx,ecx
       mov       [rbp-228],rcx
M01_L109:
       mov       [rbp-20C],eax
       xor       r8d,r8d
       mov       [rbp-210],r8d
       mov       rcx,[rdi+8]
       mov       edx,eax
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L205
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rbp-4B8],r10
       mov       r9d,[r10]
       dec       r9d
       cmp       [r12+8],r9d
       jbe       near ptr M01_L100
M01_L110:
       mov       ecx,r9d
       lea       rcx,[rcx+rcx*2]
       cmp       [r12+rcx*8+20],eax
       je        short M01_L112
M01_L111:
       mov       r9d,r9d
       lea       rcx,[r9+r9*2]
       mov       r9d,[r12+rcx*8+24]
       mov       ecx,r9d
       mov       r8d,[rbp-210]
       inc       r8d
       mov       [rbp-210],r8d
       cmp       [r12+8],r8d
       jb        near ptr M01_L14
       cmp       [r12+8],ecx
       mov       r9d,ecx
       mov       eax,[rbp-20C]
       ja        short M01_L110
       jmp       near ptr M01_L100
M01_L112:
       mov       [rbp-214],r9d
       mov       ecx,r9d
       lea       rcx,[rcx+rcx*2]
       mov       r11,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       mov       rdx,[rbp-4B0]
       cmp       [rdx],rcx
       jne       near ptr M01_L190
       mov       rdx,[rbp-4B0]
       test      r11,r11
       mov       [rbp-4B0],rdx
       jne       short M01_L113
       mov       r9d,[rbp-214]
       jmp       near ptr M01_L111
M01_L113:
       mov       rcx,r11
       mov       rdx,r15
       mov       r11,[r11]
       mov       r11,[r11+40]
       call      qword ptr [r11+10]
       test      eax,eax
       je        near ptr M01_L189
M01_L114:
       mov       ecx,[rbp-214]
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r12+rcx*8+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L103
M01_L115:
       mov       ecx,[rdi+38]
       lea       r10d,[rcx+rcx]
       cmp       r10d,7FFFFFC3
       ja        near ptr M01_L191
M01_L116:
       mov       ecx,r10d
       call      qword ptr [7FF86BC25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
M01_L117:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4E0],rax
       mov       r10d,[rdi+38]
       mov       [rbp-22C],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-4E8],rdx
       test      rdx,rdx
       je        near ptr M01_L200
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M01_L197
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L196
       cmp       r10d,[rdx+8]
       ja        near ptr M01_L195
       cmp       r10d,[rax+8]
       ja        near ptr M01_L194
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L199
       mov       rax,[rbp-4E0]
       cmp       r8,4000
       ja        near ptr M01_L198
       mov       rcx,r9
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L193
M01_L118:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r12d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+30],rax
       xor       ecx,ecx
       mov       r12d,[rbp-22C]
       test      r12d,r12d
       jle       near ptr M01_L125
       mov       r8,[rbp-4E0]
       cmp       [r8+8],r12d
       jl        near ptr M01_L122
M01_L119:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [r8+rdx*8+24],0FFFFFFFF
       jl        short M01_L120
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r8+rdx*8+20]
       mov       rax,[rdi+8]
       mov       r10d,edx
       imul      r10,[rdi+30]
       shr       r10,20
       inc       r10
       mov       r9d,[rax+8]
       imul      r10,r9
       shr       r10,20
       cmp       r10d,[rax+8]
       jae       near ptr M01_L205
       mov       edx,r10d
       lea       rdx,[rax+rdx*4+10]
       mov       eax,ecx
       lea       r10,[rax+rax*2]
       mov       eax,[rdx]
       dec       eax
       mov       [r8+r10*8+24],eax
       lea       eax,[rcx+1]
       mov       [rdx],eax
M01_L120:
       inc       ecx
       cmp       ecx,r12d
       jl        short M01_L119
M01_L121:
       lea       rcx,[rdi+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r12d,[rbp-20C]
       mov       edx,r12d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L205
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-4B8],rax
       mov       eax,r12d
       jmp       near ptr M01_L101
M01_L122:
       mov       edx,[r8+8]
M01_L123:
       cmp       ecx,[r8+8]
       jae       near ptr M01_L205
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [r8+rdx*8+24],0FFFFFFFF
       jl        short M01_L124
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       mov       edx,[r8+rdx*8+20]
       mov       rax,[rdi+8]
       mov       r10d,edx
       imul      r10,[rdi+30]
       shr       r10,20
       inc       r10
       mov       edx,[rax+8]
       imul      r10,rdx
       shr       r10,20
       cmp       r10d,[rax+8]
       jae       near ptr M01_L205
       mov       edx,r10d
       lea       rdx,[rax+rdx*4+10]
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       mov       r10d,[rdx]
       dec       r10d
       mov       [r8+rax*8+24],r10d
       lea       eax,[rcx+1]
       mov       [rdx],eax
M01_L124:
       inc       ecx
       cmp       ecx,r12d
       jl        short M01_L123
       jmp       near ptr M01_L121
M01_L125:
       mov       r8,[rbp-4E0]
       jmp       near ptr M01_L121
M01_L126:
       mov       ecx,[rdi+3C]
       mov       r9d,ecx
       mov       ecx,[rdi+3C]
       cmp       ecx,[r12+8]
       jae       near ptr M01_L205
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r12+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+3C],ecx
       dec       dword ptr [rdi+40]
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M01_L102
M01_L127:
       mov       rax,rdi
       add       rsp,4F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L128:
       cmp       ebx,[rsi+10]
       jge       near ptr M01_L13
       mov       r8d,[rsi+10]
       sub       r8d,ebx
       mov       rcx,[rsi+8]
       mov       edx,ebx
       call      qword ptr [7FF86C555128]; System.Array.Clear(System.Array, Int32, Int32)
       jmp       near ptr M01_L13
M01_L129:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M01_L12
M01_L130:
       add       r14,10
       mov       r15,r14
       mov       r13d,ebx
       mov       r12d,[rbp-1E8]
       test      r12d,r12d
       jne       near ptr M01_L176
M01_L131:
       mov       ecx,[rbp-1E0]
       cmp       ecx,[rbp-0E8]
       ja        short M01_L132
       mov       rdx,[rbp-0F0]
       cmp       ecx,r13d
       ja        short M01_L133
       mov       r8d,ecx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L181
       mov       rcx,r15
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       je        near ptr M01_L98
       jmp       near ptr M01_L180
M01_L132:
       call      qword ptr [7FF86BD97198]
       int       3
M01_L133:
       call      qword ptr [7FF86C07DA70]
       int       3
M01_L134:
       xor       ecx,ecx
       call      qword ptr [7FF86BC25A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4C8],rax
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4D0],rax
       mov       dword ptr [rdi+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r12d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+30],rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-4C8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-4D0]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L104
M01_L135:
       mov       rcx,[rbp-4D8]
       call      qword ptr [7FF86BC2E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L106
M01_L136:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C2659F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L137
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L38
M01_L137:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L39
M01_L138:
       xor       r13d,r13d
       jmp       near ptr M01_L29
M01_L139:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L29
M01_L140:
       mov       rcx,r15
       mov       rdx,[rbp-458]
       mov       r11,7FF86BB70DE8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L30
M01_L141:
       mov       rcx,r15
       mov       r8,rsi
       mov       rdx,r9
       mov       r11,7FF86BB70DF0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L32
       jmp       near ptr M01_L18
M01_L142:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L20
       mov       r8d,7FFFFFC3
       jmp       near ptr M01_L21
M01_L143:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L36
       mov       r14,[rbp-468]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF86BD9F3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L36
M01_L144:
       call      qword ptr [7FF86C1DF540]
       mov       ecx,2643
       mov       rdx,7FF86BF14F20
       call      qword ptr [7FF86BE4C030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BF14F20
       call      qword ptr [7FF86BE4C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BF14F20
       call      qword ptr [7FF86BE4C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C695F08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C1DF240]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L145:
       call      qword ptr [7FF86C55E430]
       int       3
M01_L146:
       xor       r13d,r13d
       jmp       near ptr M01_L79
M01_L147:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L79
M01_L148:
       mov       rcx,r15
       mov       rdx,rbx
       mov       r11,7FF86BB70DF8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L80
M01_L149:
       mov       rcx,r15
       mov       r8,rbx
       mov       rdx,r9
       mov       r11,7FF86BB70E00
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M01_L82
       jmp       near ptr M01_L84
M01_L150:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L86
       mov       r14d,7FFFFFC3
       jmp       near ptr M01_L87
M01_L151:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L88
M01_L152:
       jmp       short M01_L159
M01_L153:
       jmp       short M01_L159
M01_L154:
       jmp       short M01_L159
M01_L155:
       jmp       short M01_L159
M01_L156:
       mov       rcx,r9
       call      qword ptr [7FF86C556C10]
       jmp       near ptr M01_L88
M01_L157:
       mov       rcx,r9
       call      qword ptr [7FF86BC25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L88
M01_L158:
       xor       ecx,ecx
       mov       [rbp-0A0],ecx
       jmp       short M01_L160
M01_L159:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF86C266B50]; System.Array.GetLowerBound(Int32)
       mov       [rbp-0A0],eax
       mov       rax,[rbp-498]
M01_L160:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF86C266B50]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-9C]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-4A0]
       mov       edx,[rbp-0A0]
       mov       r8,[rbp-498]
       call      qword ptr [7FF86C266B68]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L88
M01_L161:
       mov       eax,[r8+8]
       jmp       near ptr M01_L92
M01_L162:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L74
       mov       r14,[rbp-480]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF86BD9F3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L74
M01_L163:
       mov       rcx,24A9F9A3120
       call      qword ptr [7FF86BC27C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L164:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L165:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L166:
       xor       esi,esi
       jmp       near ptr M01_L99
M01_L167:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L168:
       mov       rcx,offset MT_System.Func<System.Type, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20A20800300
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c.<BuiltInTypeNamesNoCache>b__62_0(System.Type)
       call      qword ptr [7FF86BC26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20A20800308
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L06
M01_L169:
       mov       rcx,rax
       mov       rdx,rsi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M01_L07
M01_L170:
       mov       rdx,20A0A800208
       mov       r15,[rdx]
       jmp       near ptr M01_L07
M01_L171:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L172
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FF86C696220]
       mov       r15,rbx
       jmp       near ptr M01_L07
M01_L172:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbx
       mov       r8,rsi
       call      qword ptr [7FF86C696238]
       jmp       near ptr M01_L07
M01_L173:
       mov       ecx,11
       call      qword ptr [7FF86BE4C6F0]
       int       3
M01_L174:
       lea       rcx,[rbp-1E8]
       mov       r8,r13
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Type>
       call      qword ptr [7FF86C554D38]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M01_L10
M01_L175:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF86C1D6FB8]
       int       3
M01_L176:
       vmovdqu   xmm0,xmmword ptr [rbp-100]
       vmovdqu   xmmword ptr [rbp-448],xmm0
       lea       r8,[rbp-448]
       lea       rcx,[rbp-1F8]
       mov       rdx,offset MT_System.Span<System.Type>
       call      qword ptr [7FF86C554F18]; System.Span`1[[System.__Canon, System.Private.CoreLib]].op_Implicit(System.Span`1<System.__Canon>)
       mov       r15d,[rbp-1F0]
       cmp       r15d,ebx
       ja        near ptr M01_L133
       mov       r8d,r15d
       shl       r8,3
       mov       rcx,r14
       mov       rdx,[rbp-1F8]
       call      qword ptr [7FF86BC257A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8]
       sub       ebx,r15d
       mov       r13d,ebx
       mov       r15,rcx
       dec       r12d
       je        near ptr M01_L131
       lea       rcx,[rbp-208]
       lea       r8,[rbp-1D8]
       mov       rdx,7FF86C564AC0
       mov       r9d,1B
       call      qword ptr [7FF86C554F60]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       cmp       r12d,[rbp-200]
       ja        near ptr M01_L132
       mov       rbx,[rbp-208]
       mov       r14d,r12d
       xor       r12d,r12d
M01_L177:
       mov       r8,[rbx+r12*8]
       test      r8,r8
       jne       short M01_L178
       xor       edx,edx
       xor       eax,eax
       jmp       short M01_L179
M01_L178:
       lea       rdx,[r8+10]
       mov       eax,[r8+8]
M01_L179:
       cmp       eax,r13d
       jg        near ptr M01_L133
       mov       [rbp-42C],eax
       mov       r8d,eax
       shl       r8,3
       mov       rcx,r15
       call      qword ptr [7FF86BC257A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-42C]
       mov       edx,ecx
       lea       r15,[r15+rdx*8]
       sub       r13d,ecx
       inc       r12d
       cmp       r12d,r14d
       jl        short M01_L177
       jmp       near ptr M01_L131
M01_L180:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L98
M01_L181:
       mov       rcx,r15
       call      qword ptr [7FF86C556C10]
       jmp       near ptr M01_L98
M01_L182:
       lea       rcx,[rbp-1E8]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Type>
       call      qword ptr [7FF86C555080]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       near ptr M01_L99
M01_L183:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M01_L99
M01_L184:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FF86C26F420]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L99
M01_L185:
       mov       ecx,4
       call      qword ptr [7FF86BE4CAB0]
       int       3
M01_L186:
       xor       edx,edx
       mov       [rbp-4B0],rax
       mov       eax,edx
       jmp       near ptr M01_L108
M01_L187:
       mov       [rbp-4B0],rax
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       edx,eax
       jmp       near ptr M01_L107
M01_L188:
       mov       rax,[rbp-4B0]
       mov       [rbp-4B0],rax
       mov       rcx,rax
       mov       rdx,r15
       mov       r11,7FF86BB70E08
       call      qword ptr [r11]
       jmp       near ptr M01_L109
M01_L189:
       mov       r9d,[rbp-214]
       jmp       near ptr M01_L111
M01_L190:
       mov       rdx,[rbp-4B0]
       mov       [rbp-4B0],rdx
       mov       rcx,rdx
       mov       r8,r15
       mov       rdx,r11
       mov       r11,7FF86BB70E10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L114
       mov       r9d,[rbp-214]
       jmp       near ptr M01_L111
M01_L191:
       cmp       ecx,7FFFFFC3
       jge       short M01_L192
       mov       r12d,7FFFFFC3
       jmp       near ptr M01_L117
M01_L192:
       jmp       near ptr M01_L116
M01_L193:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L118
M01_L194:
       jmp       short M01_L201
M01_L195:
       jmp       short M01_L201
M01_L196:
       jmp       short M01_L201
M01_L197:
       jmp       short M01_L201
M01_L198:
       mov       rcx,r9
       call      qword ptr [7FF86C556C10]
       jmp       near ptr M01_L118
M01_L199:
       mov       rcx,r9
       call      qword ptr [7FF86BC25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L118
M01_L200:
       xor       ecx,ecx
       mov       [rbp-230],ecx
       jmp       short M01_L202
M01_L201:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF86C266B50]; System.Array.GetLowerBound(Int32)
       mov       [rbp-230],eax
       mov       rax,[rbp-4E0]
M01_L202:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FF86C266B50]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-22C]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-4E8]
       mov       edx,[rbp-230]
       mov       r8,[rbp-4E0]
       call      qword ptr [7FF86C266B68]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L118
M01_L203:
       mov       r12,[rbp-4A8]
       mov       r15,[rbp-4B0]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L103
       mov       edx,[r12+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FF86BD9F3F0]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L103
M01_L204:
       call      qword ptr [7FF86BE4C9C0]
       int       3
M01_L205:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L206:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L207:
       sub       rsp,38
       vzeroupper
       mov       rbx,[rbp-58]
       cmp       dword ptr [rbx+20],0
       jge       short M01_L208
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF86BB64000
       call      qword ptr [7FF86BE4C030]
       mov       rbx,rax
       call      qword ptr [7FF86C694180]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF86BE4E358]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L208:
       cmp       qword ptr [rbx+10],0
       jne       short M01_L209
       xor       ecx,ecx
       mov       [rbx+18],rcx
       jmp       near ptr M01_L218
M01_L209:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L210
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C6943C0]
       jmp       near ptr M01_L218
M01_L210:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C6943D8]
       mov       rsi,rax
       cmp       rsi,rbx
       je        near ptr M01_L217
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       jge       short M01_L211
       mov       edx,eax
M01_L211:
       cmp       ecx,edx
       jle       short M01_L212
       mov       ecx,edx
M01_L212:
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M01_L215
       cmp       ecx,400
       jge       short M01_L213
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M01_L214
M01_L213:
       xor       edx,edx
       call      qword ptr [7FF86C1DF648]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M01_L214:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF86BC27048]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L216
M01_L215:
       mov       rdx,[rsi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L216:
       mov       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+1C]
       mov       [rbx+1C],ecx
M01_L217:
       mov       ecx,[rsi+1C]
       neg       ecx
       mov       [rbx+18],ecx
M01_L218:
       mov       rdx,20A20800338
       mov       rsi,[rdx]
       mov       rax,[rsi+10]
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M01_L220
M01_L219:
       add       rsp,38
       ret
M01_L220:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L223
       lea       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M01_L222
       call      qword ptr [7FF86C55E430]
       int       3
M01_L221:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L222:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF8CB8421C0
       test      rax,rax
       je        short M01_L219
M01_L223:
       lea       rax,[rsi+2C]
       mov       ecx,1
       lock xadd [rax],ecx
       inc       ecx
       cmp       ecx,[rsi+28]
       jg        short M01_L228
       mov       rcx,[rsi+18]
       mov       rdx,[rcx+10]
       mov       r8,[rdx+8]
M01_L224:
       mov       esi,[rdx+0A0]
       mov       eax,esi
       and       eax,[rdx+18]
       cmp       eax,[r8+8]
       jae       short M01_L221
       shl       rax,4
       lea       rdi,[r8+rax+10]
       mov       r10d,[rdi+8]
       sub       r10d,esi
       jne       short M01_L225
       lea       r10,[rdx+0A0]
       lea       r9d,[rsi+1]
       mov       eax,esi
       lock cmpxchg [r10],r9d
       cmp       eax,esi
       jne       short M01_L224
       jmp       short M01_L226
M01_L225:
       test      r10d,r10d
       jge       short M01_L224
       jmp       short M01_L227
M01_L226:
       mov       rcx,rdi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       esi
       mov       [rdi+8],esi
       jmp       near ptr M01_L219
M01_L227:
       mov       rdx,rbx
       call      qword ptr [7FF86C694498]
       jmp       near ptr M01_L219
M01_L228:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       near ptr M01_L219
; Total bytes of code 9262
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypes_ForComparison()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF86C316D00]; System.AppDomain.get_CurrentDomain()
       mov       rcx,rax
       mov       rdx,1F6B4BC1CB8
       mov       r8d,1
       call      qword ptr [7FF86C316D18]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypesNoCache(System.AppDomain, System.Type, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 84
```
```assembly
; System.AppDomain.get_CurrentDomain()
       push      rbx
       sub       rsp,20
       mov       rbx,1B61FC022E0
       cmp       qword ptr [rbx],0
       je        short M01_L01
M01_L00:
       mov       rax,[rbx]
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       mov       rcx,offset MT_System.AppDomain
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+28],1
       mov       rdx,rax
       mov       rcx,1B61FC022E0
       xor       r8d,r8d
       call      00007FF8CB8421C0
       jmp       short M01_L00
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypesNoCache(System.AppDomain, System.Type, Boolean)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-58],xmm4
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       rbx,rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       test      rbx,rbx
       je        near ptr M02_L18
       cmp       qword ptr [rbp+18],0
       je        near ptr M02_L19
       mov       rcx,[rbp+18]
       mov       [rbp+18],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       rax,7FF86BE1D510
       mov       [rbp-80],rax
       lea       rax,[M02_L00]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB9C60E0
       call      rax
M02_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M02_L01
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1B61FC01B60
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-0A8],rsi
       mov       [rbp-0B0],rbx
       xor       ecx,ecx
       mov       [rbp-3C],ecx
       jmp       short M02_L03
M02_L02:
       mov       edx,[rbp-3C]
       inc       edx
       mov       [rbp-3C],edx
       mov       rbx,[rbp-0B0]
M02_L03:
       mov       ecx,[rbx+8]
       cmp       ecx,[rbp-3C]
       jle       near ptr M02_L15
       mov       ecx,[rbp-3C]
       mov       rsi,[rbx+rcx*8+10]
       mov       rcx,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rsi],rcx
       jne       near ptr M02_L12
       mov       rcx,rsi
       call      00007FF8CB8679F0
       test      rax,rax
       je        near ptr M02_L11
M02_L04:
       cmp       [rax],al
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-58]
       mov       [rbp-0A0],rdx
       mov       [rbp-98],rcx
       lea       rcx,[rbp-0A0]
       lea       rdx,[rbp-50]
       call      00007FF86D7413B0
       mov       rdi,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
M02_L05:
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__74
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+38],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+3C],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     edi,byte ptr [rbp+20]
       mov       [r14+41],dil
       cmp       dword ptr [r14+38],0FFFFFFFE
       jne       near ptr M02_L13
       mov       r15d,[r14+3C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r15d,eax
       jne       near ptr M02_L13
       xor       ecx,ecx
       mov       [r14+38],ecx
       mov       r15,r14
M02_L06:
       mov       rdx,[r14+18]
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[r14+28]
       lea       rcx,[r15+20]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     ecx,byte ptr [r14+41]
       mov       [r15+40],cl
       mov       [rbp-0B8],r15
M02_L07:
       mov       rcx,[rbp-0B8]
       call      qword ptr [7FF86C4E92D8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__74.MoveNext()
       test      eax,eax
       je        short M02_L09
       mov       rcx,[rbp-0B8]
       mov       r8,[rcx+8]
       mov       rsi,[rbp-0A8]
       inc       dword ptr [rsi+14]
       mov       rcx,[rsi+8]
       mov       r14d,[rsi+10]
       cmp       [rcx+8],r14d
       ja        short M02_L08
       mov       rcx,rsi
       mov       rdx,r8
       call      qword ptr [7FF86BD7E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M02_L07
M02_L08:
       lea       edx,[r14+1]
       mov       [rsi+10],edx
       mov       edx,r14d
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M02_L07
M02_L09:
       mov       rcx,[rbp-0B8]
       mov       ecx,[rcx+38]
       cmp       ecx,0FFFFFFFD
       je        short M02_L14
       dec       ecx
       cmp       ecx,1
       jbe       short M02_L14
M02_L10:
       mov       rcx,[rbp-0B8]
       xor       edx,edx
       mov       [rcx+30],rdx
       mov       rcx,[rbp-0B8]
       mov       dword ptr [rcx+38],0FFFFFFFE
       jmp       near ptr M02_L02
M02_L11:
       mov       rcx,rsi
       call      qword ptr [7FF86C40F948]; System.Reflection.RuntimeAssembly.<GetManifestModule>g__GetManifestModuleWorker|93_0(System.Reflection.RuntimeAssembly)
       jmp       near ptr M02_L04
M02_L12:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M02_L05
M02_L13:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       xor       eax,eax
       mov       [r15+38],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r15+3C],eax
       jmp       near ptr M02_L06
M02_L14:
       mov       rcx,[rbp-0B8]
       call      qword ptr [7FF86C40F8E8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__74.<>m__Finally1()
       jmp       short M02_L10
M02_L15:
       mov       rsi,[rbp-0A8]
       mov       ebx,[rsi+10]
       test      ebx,ebx
       je        near ptr M02_L20
       movsxd    rdx,ebx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rsi,[rsi+8]
       test      rsi,rsi
       je        near ptr M02_L24
       mov       rcx,[rsi]
       cmp       rcx,[rdi]
       jne       near ptr M02_L25
       cmp       dword ptr [rcx+4],18
       jne       near ptr M02_L25
       cmp       ebx,[rsi+8]
       ja        near ptr M02_L25
       cmp       ebx,[rdi+8]
       ja        near ptr M02_L25
       mov       r8d,ebx
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        near ptr M02_L23
       cmp       r8,4000
       ja        near ptr M02_L22
       mov       rcx,rax
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L21
M02_L16:
       cmp       dword ptr [rdi+8],0
       je        near ptr M02_L27
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M02_L17:
       mov       rax,rbx
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L18:
       call      qword ptr [7FF86C1BF180]
       mov       ecx,235
       mov       rdx,7FF86BEE2E38
       call      qword ptr [7FF86BE27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEE4F20
       call      qword ptr [7FF86BE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FF86BEE2E38
       call      qword ptr [7FF86BE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86DA15F08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C53CA98]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       call      qword ptr [7FF86C1BF180]
       mov       ecx,251
       mov       rdx,7FF86BEE2E38
       call      qword ptr [7FF86BE27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEE4F20
       call      qword ptr [7FF86BE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FF86BEE2E38
       call      qword ptr [7FF86BE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86DA15F08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C53CA98]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L20:
       mov       rcx,1B61FC01B60
       mov       rdi,[rcx]
       jmp       near ptr M02_L16
M02_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L16
M02_L22:
       mov       rcx,rax
       call      qword ptr [7FF86C1BEFD0]
       jmp       near ptr M02_L16
M02_L23:
       mov       rcx,rax
       call      qword ptr [7FF86BC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L16
M02_L24:
       xor       r14d,r14d
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86C246748]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M02_L26:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C246748]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8,rdi
       call      qword ptr [7FF86C246760]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L16
M02_L27:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1B61FC02840
       mov       rbx,[rax]
       jmp       near ptr M02_L17
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp-0B8]
       mov       ebx,[rcx+38]
       cmp       ebx,0FFFFFFFD
       je        short M02_L28
       dec       ebx
       cmp       ebx,1
       ja        short M02_L29
M02_L28:
       mov       rcx,[rbp-0B8]
       call      qword ptr [7FF86C40F8E8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__74.<>m__Finally1()
M02_L29:
       mov       rcx,[rbp-0B8]
       xor       eax,eax
       mov       [rcx+30],rax
       mov       rcx,[rbp-0B8]
       mov       dword ptr [rcx+38],0FFFFFFFE
       add       rsp,38
       ret
       sub       rsp,38
       vzeroupper
       mov       edx,2C
       call      qword ptr [7FF86C316DF0]
       mov       rcx,rax
       call      qword ptr [7FF86C316E08]
       lea       rax,[M02_L02]
       add       rsp,38
       ret
; Total bytes of code 1569
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FromJsonTypeInfo()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,[rbx+1B0]
       mov       rcx,26F0FC02368
       mov       rdi,[rcx]
       mov       rbp,[rdi+18]
       test      rbp,rbp
       je        near ptr M00_L05
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L06
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L06
       movzx     ecx,word ptr [rsi+0C]
       cmp       ecx,100
       jge       near ptr M00_L08
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L10
M00_L01:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rsi+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L09
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L10
M00_L02:
       test      rbp,rbp
       je        near ptr M00_L11
       test      rsi,rsi
       je        near ptr M00_L12
       cmp       byte ptr [rbp+119],2
       jne       short M00_L04
M00_L03:
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+28]
       mov       r8,rbp
       mov       rcx,7FF86C35A450
       call      qword ptr [7FF86C31D128]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       test      rax,rax
       je        near ptr M00_L13
       mov       [rsp+38],rax
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+38]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       vzeroupper
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L04:
       mov       rcx,rbp
       call      qword ptr [7FF86C137378]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       jmp       short M00_L03
M00_L05:
       mov       rcx,rdi
       call      qword ptr [7FF86C316F70]; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       mov       rcx,rax
       mov       rdx,2AFA4CBB690
       cmp       [rcx],ecx
       call      qword ptr [7FF86C316F88]; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       mov       rdx,rax
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbp,rax
       lea       rcx,[rdi+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L06:
       call      qword ptr [7FF86C044A38]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L07
       call      qword ptr [7FF86C394930]
       mov       rbx,rax
M00_L07:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2AFA4CC2188
       call      qword ptr [7FF86C394948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       call      qword ptr [7FF86C396F40]
       test      eax,eax
       jne       short M00_L10
       jmp       near ptr M00_L01
M00_L09:
       call      qword ptr [7FF86C396F40]
       test      eax,eax
       je        near ptr M00_L02
M00_L10:
       mov       rcx,rsi
       mov       edx,3
       call      qword ptr [7FF86C39E040]
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L11:
       call      qword ptr [7FF86C1BF180]
       mov       ecx,2BD1
       mov       rdx,7FF86BEE4F20
       call      qword ptr [7FF86BE27798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEE4F20
       call      qword ptr [7FF86BE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BEE4F20
       call      qword ptr [7FF86BE27798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C394930]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C394948]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       mov       ecx,3888
       mov       rdx,7FF86C05DB60
       call      qword ptr [7FF86BE27798]
       mov       rcx,rax
       call      qword ptr [7FF86C394FF0]
       int       3
M00_L13:
       lea       rcx,[rsp+40]
       mov       edx,1F
       mov       r8d,1
       call      qword ptr [7FF86BE24E70]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M00_L16
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       cmp       eax,1E
       jb        short M00_L14
       vmovups   ymm0,[7FF86C407F20]
       vmovups   [rdx],ymm0
       vmovups   xmm0,[7FF86C407F40]
       vmovups   [rdx+20],xmm0
       mov       rcx,740020004E004F
       mov       [rdx+30],rcx
       mov       dword ptr [rdx+38],20006F
       mov       ecx,[rsp+50]
       add       ecx,1E
       mov       [rsp+50],ecx
       jmp       short M00_L15
M00_L14:
       lea       rcx,[rsp+40]
       mov       rdx,2AFA4CC2480
       call      qword ptr [7FF86C314780]
M00_L15:
       lea       rcx,[rsp+40]
       mov       rdx,7FF86C35A218
       mov       r8,2AFA4CBB690
       call      qword ptr [7FF86BE2E430]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       jbe       short M00_L17
M00_L16:
       call      qword ptr [7FF86BD77198]
       int       3
M00_L17:
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        short M00_L18
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
       jmp       short M00_L19
M00_L18:
       lea       rcx,[rsp+40]
       mov       rdx,2AFA4CB0658
       call      qword ptr [7FF86C314780]
M00_L19:
       mov       rcx,offset MT_System.Text.Json.JsonException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF86BE24EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86C31D0E0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 967
```
```assembly
; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,268
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+220],xmm4
       vmovdqa   xmmword ptr [rbp+rax+230],xmm4
       vmovdqa   xmmword ptr [rbp+rax+240],xmm4
       add       rax,30
       jne       short M01_L00
       mov       rax,0DC22F0E8DB82
       mov       [rbp],rax
       mov       rbx,r8
       mov       rsi,[rdx]
       mov       edi,[rdx+8]
       xor       ecx,ecx
       mov       [rbp+38],rcx
       cmp       edi,55
       jle       near ptr M01_L15
       cmp       edi,15555555
       jg        near ptr M01_L16
       mov       rcx,26F0FC01E50
       mov       r14,[rcx]
       mov       r15,r14
       lea       r13d,[rdi+rdi*2]
       mov       rcx,26F0FC00C90
       mov       r12,[rcx]
       lea       ecx,[r13-1]
       or        ecx,0F
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       add       eax,0FFFFFFFD
       mov       [rbp+234],eax
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       near ptr M01_L17
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+50]
       test      rdx,rdx
       je        near ptr M01_L17
M01_L01:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       je        near ptr M01_L20
       mov       edx,[rcx+8]
       mov       eax,[rbp+234]
       cmp       edx,eax
       jbe       near ptr M01_L21
       mov       edx,eax
       shl       rdx,4
       mov       r8,[rcx+rdx+10]
       test      r8,r8
       je        near ptr M01_L19
       xor       r10d,r10d
       mov       [rcx+rdx+10],r10
       cmp       byte ptr [r12+9D],0
       jne       near ptr M01_L18
M01_L02:
       mov       [rbp+38],r8
M01_L03:
       test      r8,r8
       je        near ptr M01_L36
       lea       r14,[r8+10]
       mov       r15d,[r8+8]
M01_L04:
       mov       [rbp+8],r14
       mov       [rbp+74],r15d
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       mov       [rbp+50],r14
       mov       [rbp+58],r15d
       lea       rcx,[rbp+60]
       lea       rdx,[rbp+50]
       call      qword ptr [7FF86C04CB58]; System.Text.Json.JsonReaderHelper.GetUtf8FromText(System.ReadOnlySpan`1<Char>, System.Span`1<Byte>)
       cmp       eax,r15d
       ja        near ptr M01_L07
       mov       [rbp+8],r14
       mov       [rbp+74],eax
       mov       rdx,[rbx+0B8]
       movzx     ecx,byte ptr [rdx+94]
       movzx     r9d,byte ptr [rdx+92]
       cmp       r9d,2
       jg        near ptr M01_L08
       mov       edx,[rdx+88]
       test      edx,edx
       jl        near ptr M01_L09
       xor       r8d,r8d
       mov       [rbp+1E8],r8
       mov       [rbp+1F0],r8
       mov       byte ptr [rbp+1F8],0
       mov       byte ptr [rbp+1F9],0
       mov       byte ptr [rbp+1FA],0
       mov       byte ptr [rbp+1FB],0
       mov       byte ptr [rbp+1FC],0
       mov       byte ptr [rbp+1FD],0
       mov       [rbp+200],edx
       mov       [rbp+204],r9b
       mov       [rbp+205],cl
       mov       byte ptr [rbp+206],0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp+208],xmm0
       vmovdqu   xmmword ptr [rbp+210],xmm0
       mov       [rbp+40],r14
       mov       [rbp+48],eax
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+128]
       lea       r9,[rbp+1E8]
       mov       r8d,1
       call      qword ptr [7FF86C1B5F80]; System.Text.Json.Utf8JsonReader..ctor(System.ReadOnlySpan`1<Byte>, Boolean, System.Text.Json.JsonReaderState)
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp+88],ymm0
       vmovdqu   ymmword ptr [rbp+0A8],ymm0
       vmovdqu   ymmword ptr [rbp+0C8],ymm0
       vmovdqu   ymmword ptr [rbp+0E8],ymm0
       vmovdqu   ymmword ptr [rbp+108],ymm0
       mov       rcx,[rbx+0B8]
       cmp       dword ptr [rcx+8C],1
       je        near ptr M01_L10
M01_L05:
       mov       [rbp+0E0],rbx
       mov       rcx,[rbx+0D0]
       mov       [rbp+0B8],rcx
       mov       rcx,[rbp+0B8]
       mov       rcx,[rcx+0C8]
       mov       [rbp+11C],rcx
       cmp       byte ptr [rbp+0B1],0
       jne       near ptr M01_L12
       mov       rcx,[rbx+0A0]
       test      rcx,rcx
       jne       near ptr M01_L11
       xor       r9d,r9d
M01_L06:
       mov       [rbp+113],r9b
       mov       byte ptr [rbp+0B0],0
       lea       rcx,[rbp+88]
       mov       [rsp+20],rcx
       mov       rcx,[rbx+158]
       mov       r9,[rbx+0B8]
       lea       r8,[rbp+80]
       lea       rdx,[rbp+128]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C1B6010]; System.Text.Json.Serialization.JsonConverter`1[[System.__Canon, System.Private.CoreLib]].ReadCore(System.Text.Json.Utf8JsonReader ByRef, System.__Canon ByRef, System.Text.Json.JsonSerializerOptions, System.Text.Json.ReadStack ByRef)
       mov       rax,[rbp+80]
       xor       ecx,ecx
       mov       [rbp+80],rcx
       mov       [rbp+30],rax
       jmp       near ptr M01_L13
M01_L07:
       call      qword ptr [7FF86BD77198]
       int       3
M01_L08:
       mov       ecx,38A0
       mov       rdx,7FF86C05DB60
       call      qword ptr [7FF86BE27798]
       mov       rcx,rax
       call      qword ptr [7FF86C39E310]
       int       3
M01_L09:
       mov       ecx,38A0
       mov       rdx,7FF86C05DB60
       call      qword ptr [7FF86BE27798]
       mov       rcx,rax
       call      qword ptr [7FF86C39E328]
       int       3
M01_L10:
       mov       rcx,[rcx+38]
       xor       edx,edx
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       [rbp+90],rax
       mov       byte ptr [rbp+0B1],1
       jmp       near ptr M01_L05
M01_L11:
       movzx     r9d,byte ptr [rcx+34]
       jmp       near ptr M01_L06
M01_L12:
       mov       r9d,1
       jmp       near ptr M01_L06
M01_L13:
       call      M01_L39
       nop
       mov       rax,[rbp+30]
       mov       r8,0DC22F0E8DB82
       cmp       [rbp],r8
       je        short M01_L14
       call      CORINFO_HELP_FAIL_FAST
M01_L14:
       nop
       lea       rsp,[rbp+238]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L15:
       test      [rsp],esp
       sub       rsp,100
       lea       r14,[rsp+30]
       mov       r15d,100
       jmp       near ptr M01_L04
M01_L16:
       mov       [rbp+60],rsi
       mov       [rbp+68],edi
       lea       rcx,[rbp+60]
       call      qword ptr [7FF86C047FA8]; System.Text.Json.JsonReaderHelper.GetUtf8ByteCount(System.ReadOnlySpan`1<Char>)
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r8,rax
       jmp       near ptr M01_L03
M01_L17:
       mov       ecx,0A
       call      qword ptr [7FF86C395290]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L18:
       mov       [rbp+28],r8
       mov       rcx,r8
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13,[rbp+28]
       mov       eax,[r13+8]
       mov       [rbp+224],eax
       mov       rcx,r14
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r14d,[rbp+234]
       mov       [rsp+20],r14d
       mov       edx,r15d
       mov       r8d,[rbp+224]
       mov       rcx,r12
       call      qword ptr [7FF86C31D6E0]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L19:
       mov       eax,[rbp+234]
       jmp       short M01_L21
M01_L20:
       mov       eax,[rbp+234]
M01_L21:
       mov       rcx,[r15+10]
       cmp       [rcx+8],eax
       jbe       near ptr M01_L31
       mov       edx,eax
       mov       rcx,[rcx+rdx*8+10]
       test      rcx,rcx
       je        near ptr M01_L30
       mov       r13,[rcx+8]
       call      qword ptr [7FF86C31DF38]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r14d,eax
       sub       r14d,ecx
       xor       eax,eax
       jmp       short M01_L25
M01_L22:
       cmp       r14d,[r13+8]
       jae       near ptr M01_L38
       mov       ecx,r14d
       mov       rdx,[r13+rcx*8+10]
       mov       [rbp+18],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rbp+20],r8
       mov       rcx,rdx
       call      qword ptr [7FF86C13E418]; System.Threading.Monitor.Enter(System.Object)
       mov       rdx,[rbp+18]
       mov       rcx,[rdx+8]
       mov       eax,[rdx+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M01_L23
       mov       r8d,eax
       mov       r8,[rcx+r8*8+10]
       mov       [rbp+20],r8
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [rdx+10],eax
M01_L23:
       mov       rcx,rdx
       call      qword ptr [7FF86BC06820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp+20]
       test      rcx,rcx
       jne       short M01_L26
       inc       r14d
       cmp       [r13+8],r14d
       jne       short M01_L24
       xor       r14d,r14d
M01_L24:
       mov       eax,[rbp+220]
       inc       eax
M01_L25:
       mov       [rbp+220],eax
       cmp       [r13+8],eax
       jg        near ptr M01_L22
       jmp       short M01_L27
M01_L26:
       mov       r13,rcx
       jmp       short M01_L28
M01_L27:
       xor       r13d,r13d
M01_L28:
       test      r13,r13
       je        short M01_L30
       cmp       byte ptr [r12+9D],0
       je        short M01_L29
       mov       rcx,r13
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+228],eax
       mov       rcx,r15
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       r15d,[rbp+234]
       mov       [rsp+20],r15d
       mov       edx,r14d
       mov       r8d,[rbp+228]
       mov       rcx,r12
       call      qword ptr [7FF86C31D6E0]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L29:
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L30:
       mov       ecx,10
       mov       eax,[rbp+234]
       shlx      r13d,ecx,eax
       jmp       short M01_L33
M01_L31:
       test      r13d,r13d
       jne       short M01_L32
       mov       r8,2AFA4CB62A0
       jmp       near ptr M01_L02
M01_L32:
       mov       ecx,r13d
       mov       rdx,2AFA4CB6F28
       call      qword ptr [7FF86BE2DAA0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
M01_L33:
       cmp       r13d,800
       jge       short M01_L34
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r13,rax
       jmp       short M01_L35
M01_L34:
       mov       ecx,r13d
       xor       edx,edx
       call      qword ptr [7FF86C246FD0]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Byte, System.Private.CoreLib]](Int32, Boolean)
       mov       r13,rax
M01_L35:
       cmp       byte ptr [r12+9D],0
       je        near ptr M01_L37
       cmp       [r13],r13b
       mov       rcx,r13
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       eax,[r13+8]
       mov       [rbp+230],eax
       mov       rcx,r15
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,[rbp+230]
       mov       rcx,r12
       call      qword ptr [7FF86C31D6E0]
       mov       eax,[r13+8]
       mov       [rbp+22C],eax
       mov       rcx,r15
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       mov       r15d,[rbp+234]
       cmp       [rcx+8],r15d
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r12
       mov       edx,r14d
       mov       r8d,[rbp+22C]
       call      qword ptr [7FF86C31D728]
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L36:
       xor       r14d,r14d
       xor       r15d,r15d
       jmp       near ptr M01_L04
M01_L37:
       mov       r8,r13
       jmp       near ptr M01_L02
M01_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L39:
       sub       rsp,38
       cmp       qword ptr [rbp+38],0
       je        near ptr M01_L58
       mov       edx,[rbp+74]
       mov       rcx,[rbp+8]
       call      qword ptr [7FF86BC057E8]; System.SpanHelpers.ClearWithoutReferences(Byte ByRef, UIntPtr)
       mov       rcx,26F0FC01E50
       mov       rbx,[rcx]
       mov       rcx,[rbp+38]
       mov       ecx,[rcx+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],0A
       jle       short M01_L40
       mov       rcx,[rcx+240]
       mov       rax,[rcx+50]
       test      rax,rax
       jne       short M01_L41
M01_L40:
       mov       ecx,0A
       call      qword ptr [7FF86C395290]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
M01_L41:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M01_L42
       mov       rcx,rbx
       call      qword ptr [7FF86C24EEF8]; System.Buffers.SharedArrayPool`1[[System.Byte, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M01_L42:
       xor       edi,edi
       mov       r14d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M01_L54
       mov       edi,1
       mov       rcx,[rbp+38]
       mov       edx,10
       shlx      edx,edx,esi
       cmp       [rcx+8],edx
       je        short M01_L43
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C31DB00]
       mov       rdi,rax
       mov       ecx,29B
       mov       rdx,7FF86BB44000
       call      qword ptr [7FF86BE27798]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF86BF96310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       ecx,esi
       shl       rcx,4
       lea       r15,[rax+rcx+10]
       mov       r13,[r15]
       mov       rdx,[rbp+38]
       mov       rcx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+8],ecx
       test      r13,r13
       je        near ptr M01_L54
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M01_L55
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M01_L44
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF86C39EAC0]
M01_L44:
       mov       r14,[rax+8]
       call      qword ptr [7FF86C31DF38]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r15d,eax
       sub       r15d,ecx
       xor       r12d,r12d
       jmp       near ptr M01_L51
M01_L45:
       cmp       r15d,[r14+8]
       jae       near ptr M01_L55
       mov       ecx,r15d
       mov       rax,[r14+rcx*8+10]
       mov       [rbp+10],rax
       cmp       [rax],al
       xor       edx,edx
       mov       [rbp+7C],edx
       mov       rcx,rax
       call      qword ptr [7FF86C13E418]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rbp+10]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rbp+78],r8d
       cmp       [rcx+8],r8d
       jbe       short M01_L47
       test      r8d,r8d
       jne       short M01_L48
       xor       edx,edx
       mov       [rax+14],edx
M01_L46:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp+78]
       inc       ecx
       mov       rax,[rbp+10]
       mov       [rax+10],ecx
       mov       dword ptr [rbp+7C],1
M01_L47:
       mov       rcx,rax
       call      qword ptr [7FF86BC06820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rbp+7C],0
       je        short M01_L49
       jmp       short M01_L52
M01_L48:
       jmp       short M01_L46
M01_L49:
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M01_L50
       xor       r15d,r15d
M01_L50:
       inc       r12d
M01_L51:
       cmp       [r14+8],r12d
       jg        near ptr M01_L45
       jmp       short M01_L53
M01_L52:
       mov       r14d,1
       jmp       short M01_L54
M01_L53:
       xor       r14d,r14d
M01_L54:
       mov       rcx,26F0FC00C90
       mov       r15,[rcx]
       cmp       byte ptr [r15+9D],0
       je        near ptr M01_L58
       mov       rcx,[rbp+38]
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r13d,eax
       mov       rcx,[rbp+38]
       mov       r12d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r15
       mov       r8d,r13d
       mov       r9d,r12d
       mov       edx,3
       call      qword ptr [7FF86C39D9E0]
       test      r14d,edi
       jne       short M01_L58
       mov       rcx,[rbp+38]
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,[rbp+38]
       mov       r13d,[rcx+8]
       mov       rcx,rbx
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      edi,edi
       jne       short M01_L56
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M01_L57
M01_L55:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L56:
       mov       ecx,esi
       xor       edx,edx
M01_L57:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,r14d
       mov       r8d,r13d
       call      qword ptr [7FF86C31DB78]
M01_L58:
       nop
       add       rsp,38
       ret
; Total bytes of code 2477
```
```assembly
; System.Text.Json.Serialization.Metadata.JsonTypeInfo.<EnsureConfigured>g__ConfigureSynchronized|174_0()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       [rbp+10],rcx
       mov       rax,[rcx+0B8]
       cmp       qword ptr [rax+20],0
       je        near ptr M02_L06
       mov       byte ptr [rax+9E],1
       mov       byte ptr [rcx+114],1
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       near ptr M02_L07
       mov       rbx,[rcx+0B8]
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M02_L08
M02_L00:
       mov       [rbp-20],rsi
       xor       eax,eax
       mov       [rbp-14],eax
       test      rsi,rsi
       je        short M02_L02
       mov       rcx,rsi
       call      00007FF8CB89E120
       test      eax,eax
       jne       short M02_L01
       mov       rcx,rsi
       call      qword ptr [7FF86C395A70]
M02_L01:
       mov       dword ptr [rbp-14],1
       mov       rcx,[rbp+10]
       cmp       byte ptr [rcx+119],0
       jne       short M02_L04
       mov       rbx,[rcx+0F0]
       test      rbx,rbx
       jne       short M02_L03
       mov       rcx,7FF86C4A52C0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],1
       call      qword ptr [7FF86C137390]; System.Text.Json.Serialization.Metadata.JsonTypeInfo.Configure()
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],2
       jmp       short M02_L04
M02_L02:
       xor       ecx,ecx
       call      qword ptr [7FF86C394FF0]
       int       3
M02_L03:
       mov       rcx,7FF86C4A52BC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF86C39DC20]
       int       3
M02_L04:
       mov       rcx,7FF86C4A52C4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       call      00007FF8CB89E040
       test      eax,eax
       jne       near ptr M02_L10
M02_L05:
       mov       rcx,7FF86C4A52C8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF86C4A52CC
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M02_L06:
       call      qword ptr [7FF86C39DEA8]
       int       3
M02_L07:
       mov       rcx,7FF86C4A52B8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       call      qword ptr [7FF86C39DC20]
       int       3
M02_L08:
       mov       rcx,rbx
       call      qword ptr [7FF86C04D740]; System.Text.Json.JsonSerializerOptions+TrackedCachingContexts.GetOrCreate(System.Text.Json.JsonSerializerOptions)
       mov       rsi,rax
       lea       rcx,[rbx+8]
       test      rcx,rcx
       jne       short M02_L09
       call      qword ptr [7FF86C39CE88]
       int       3
M02_L09:
       mov       rdx,rsi
       xor       r8d,r8d
       call      00007FF8CB8421C0
       test      rax,rax
       cmove     rax,rsi
       mov       rsi,rax
       jmp       near ptr M02_L00
M02_L10:
       mov       ecx,eax
       mov       rdx,rsi
       call      qword ptr [7FF86C395188]
       jmp       near ptr M02_L05
       sub       rsp,28
       call      qword ptr [7FF86C39DEC0]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+0F0]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+119],0
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       cmp       dword ptr [rbp-14],0
       je        short M02_L12
       mov       rcx,7FF86C4A52C4
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       qword ptr [rbp-20],0
       jne       short M02_L11
       xor       ecx,ecx
       call      qword ptr [7FF86C394FF0]
       int       3
M02_L11:
       mov       rcx,[rbp-20]
       call      00007FF8CB89E040
       test      eax,eax
       je        short M02_L12
       mov       ecx,eax
       mov       rdx,[rbp-20]
       call      qword ptr [7FF86C395188]
M02_L12:
       mov       rcx,7FF86C4A52C8
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       ret
; Total bytes of code 535
```
```assembly
; System.Text.Json.Serialization.JsonSerializerContext.get_Options()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M03_L01
M03_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L01:
       call      qword ptr [7FF901019CB8]
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF90101E4A0]; Precode of System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF90101E4B0]; Precode of System.Text.Json.JsonSerializerOptions.set_TypeInfoResolver(System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver)
       mov       rcx,rsi
       call      qword ptr [7FF90101E4C8]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FF901018278]; CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L00
; Total bytes of code 82
```
```assembly
; System.Text.Json.JsonSerializerOptions.GetTypeInfo(System.Type)
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FF90101AE88]; Precode of System.ArgumentNullException.ThrowIfNull(System.Object, System.String)
       mov       rcx,rbx
       call      qword ptr [7FF90101EF48]; Precode of System.Text.Json.Serialization.Metadata.JsonTypeInfo.IsInvalidForSerialization(System.Type)
       test      eax,eax
       jne       short M04_L00
       mov       dword ptr [rsp+20],1
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       r9d,101
       mov       rcx,rsi
       mov       rdx,rbx
       mov       r8d,1
       call      qword ptr [7FF90101E440]; Precode of System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, System.Nullable`1<Boolean>, Boolean, Boolean)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M04_L00:
       mov       rcx,[System.Text.Json.Serialization.Metadata.ReflectionEmitMemberAccessor.CreateParameterizedConstructor[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Reflection.ConstructorInfo)]
       mov       rcx,[rcx]
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF90101CE28]
       int       3
; Total bytes of code 118
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M05_L00
       cmp       [rdx],rcx
       jne       short M05_L01
M05_L00:
       mov       rax,rdx
       ret
M05_L01:
       jmp       qword ptr [7FF86BC0FD20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M06_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M06_L00
       test      rbx,rbx
       je        near ptr M06_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M06_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF86BC05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L00:
       test      rbx,rbx
       je        short M06_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L02
M06_L01:
       mov       rax,2AFA4CB0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L04:
       call      qword ptr [7FF86C396220]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       [rbx],rcx
       mov       rcx,26F0FC00C88
       mov       rsi,[rcx]
       imul      ecx,r8d,0B
       add       ecx,edx
       mov       edi,100
       cmp       ecx,100
       cmovg     edi,ecx
       mov       rcx,rsi
       mov       rdx,7FF86C49C710
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       edx,edi
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbx+8],rax
       test      rax,rax
       je        short M07_L01
       lea       rcx,[rax+10]
       mov       eax,[rax+8]
M07_L00:
       mov       [rbx+18],rcx
       mov       [rbx+20],eax
       xor       eax,eax
       mov       [rbx+10],eax
       mov       byte ptr [rbx+14],0
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       xor       ecx,ecx
       xor       eax,eax
       jmp       short M07_L00
; Total bytes of code 127
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.__Canon, System.Private.CoreLib]](System.__Canon)
       push      rsi
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       xorps     xmm4,xmm4
       movaps    [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       [rsp+50],rdx
       mov       rbx,rcx
       mov       rcx,rdx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M08_L05
       test      rsi,rsi
       je        near ptr M08_L06
       mov       rcx,rsi
       call      qword ptr [7FF8AC237170]
       test      rax,rax
       jne       short M08_L01
       mov       rcx,rsi
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
M08_L00:
       test      rdx,rdx
       je        near ptr M08_L06
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        near ptr M08_L07
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        near ptr M08_L08
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF8AC23D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       jmp       near ptr M08_L06
M08_L01:
       mov       rcx,rsi
       call      qword ptr [7FF8AC2371A8]
       test      rax,rax
       je        near ptr M08_L04
       mov       rcx,rsi
       call      qword ptr [7FF8AC2383E8]
       mov       rsi,rax
M08_L02:
       mov       rcx,rsi
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M08_L07
       mov       rdx,[rdx]
       mov       r11d,r9d
       lea       rdx,[rdx+r11*2]
       sub       r8d,r9d
       mov       [rsp+38],rdx
       mov       [rsp+40],r8d
       xor       edx,edx
       mov       [rsp+28],rdx
       mov       [rsp+30],edx
       mov       rdx,[rbx]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       lea       r8,[rsp+48]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       test      eax,eax
       jne       short M08_L03
       mov       rcx,rbx
       call      qword ptr [7FF8AC244FF8]
       jmp       short M08_L02
M08_L03:
       mov       ecx,[rsp+48]
       add       [rbx+10],ecx
       jmp       short M08_L06
M08_L04:
       mov       rcx,rsi
       call      qword ptr [7FF8AC2383E0]
       mov       rcx,rax
       mov       r8,[rbx]
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       xor       edx,edx
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M08_L00
M08_L05:
       call      qword ptr [7FF8AC2300E8]
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF8AC254678]
M08_L06:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M08_L07:
       call      qword ptr [7FF8AC23F2B8]
       int       3
M08_L08:
       mov       rcx,rbx
       call      qword ptr [7FF8AC244FD0]
       jmp       short M08_L06
; Total bytes of code 397
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+48],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        near ptr M09_L15
       mov       rcx,[rcx]
       mov       [rsp+48],rcx
       mov       [rsp+50],eax
       lea       rcx,[rsp+48]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rbp,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rbp,rbp
       je        near ptr M09_L14
       mov       rcx,26F0FC00C88
       mov       rbx,[rcx]
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       esi,esi
       lzcnt     esi,ecx
       xor       esi,1F
       add       esi,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M09_L16
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M09_L16
M09_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M09_L01
       mov       rcx,rbx
       call      qword ptr [7FF86BE2CE88]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
M09_L01:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,esi
       jbe       near ptr M09_L08
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,esi
       cmp       [rbp+8],ecx
       jne       near ptr M09_L17
       mov       ecx,esi
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       je        near ptr M09_L08
       mov       rcx,[rbx+10]
       cmp       esi,[rcx+8]
       jae       near ptr M09_L24
       mov       edx,esi
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M09_L02
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FF86C39D9C8]
M09_L02:
       mov       r15,[rax+8]
       call      qword ptr [7FF86C31DF38]; System.Threading.Thread.GetCurrentProcessorNumber()
       mov       ecx,0AAAAAAAB
       mov       edx,eax
       imul      rcx,rdx
       shr       rcx,23
       imul      ecx,0C
       mov       r13d,eax
       sub       r13d,ecx
       mov       eax,[r15+8]
       mov       [rsp+44],eax
       test      eax,eax
       jle       near ptr M09_L21
       mov       [rsp+40],eax
M09_L03:
       cmp       r13d,eax
       jae       near ptr M09_L24
       mov       ecx,r13d
       mov       r8,[r15+rcx*8+10]
       mov       [rsp+38],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+60],r10d
       mov       rcx,r8
       call      00007FF8CB89E120
       test      eax,eax
       jne       short M09_L04
       mov       rcx,[rsp+38]
       call      qword ptr [7FF86C395A70]
M09_L04:
       mov       rax,[rsp+38]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+5C],r8d
       cmp       [rcx+8],r8d
       jbe       short M09_L06
       test      r8d,r8d
       je        near ptr M09_L11
M09_L05:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+5C]
       inc       ecx
       mov       rax,[rsp+38]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+60],1
M09_L06:
       mov       rcx,rax
       call      00007FF8CB89E040
       test      eax,eax
       jne       near ptr M09_L18
M09_L07:
       cmp       dword ptr [rsp+60],0
       je        near ptr M09_L19
       mov       r15d,1
M09_L08:
       mov       rcx,26F0FC00C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       je        near ptr M09_L14
       cmp       dword ptr [rbp+8],0
       je        near ptr M09_L14
       mov       rcx,rbp
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       eax,[rbp+8]
       mov       [rsp+64],eax
       mov       rcx,rbx
       call      00007FF8CB813FE0
       test      eax,eax
       je        near ptr M09_L22
M09_L09:
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+64]
       mov       edx,3
       call      qword ptr [7FF86C39D9E0]
       test      r15d,r14d
       jne       short M09_L14
       mov       rcx,rbp
       call      qword ptr [7FF86C04D890]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       ebp,[rbp+8]
       mov       rcx,rbx
       call      00007FF8CB813FE0
       mov       r9d,eax
       test      r9d,r9d
       je        near ptr M09_L23
M09_L10:
       test      r14d,r14d
       jne       short M09_L12
       mov       esi,0FFFFFFFF
       mov       ecx,1
       jmp       short M09_L13
M09_L11:
       xor       edx,edx
       mov       [rax+14],edx
       jmp       near ptr M09_L05
M09_L12:
       xor       ecx,ecx
M09_L13:
       mov       [rsp+20],esi
       mov       [rsp+28],ecx
       mov       rcx,r13
       mov       edx,r15d
       mov       r8d,ebp
       call      qword ptr [7FF86C31DB78]
M09_L14:
       mov       rax,rdi
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M09_L15:
       call      qword ptr [7FF86BD77198]
       int       3
M09_L16:
       mov       ecx,3
       call      qword ptr [7FF86C395290]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M09_L00
M09_L17:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C31DB00]
       mov       rsi,rax
       mov       ecx,29B
       mov       rdx,7FF86BB44000
       call      qword ptr [7FF86BE27798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF86BF96310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L18:
       mov       ecx,eax
       mov       rdx,[rsp+38]
       call      qword ptr [7FF86C395188]
       jmp       near ptr M09_L07
M09_L19:
       inc       r13d
       mov       ecx,[rsp+44]
       cmp       ecx,r13d
       jne       short M09_L20
       xor       r13d,r13d
M09_L20:
       mov       edx,[rsp+40]
       dec       edx
       mov       [rsp+40],edx
       mov       eax,ecx
       jne       near ptr M09_L03
M09_L21:
       xor       r15d,r15d
       jmp       near ptr M09_L08
M09_L22:
       mov       rcx,rbx
       call      qword ptr [7FF86BC0E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M09_L09
M09_L23:
       mov       rcx,rbx
       call      qword ptr [7FF86BC0E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r9d,eax
       jmp       near ptr M09_L10
M09_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 933
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllAbstractMethods_ForComparison()
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,198
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rsp+190],rax
       mov       rbx,rcx
       mov       rcx,166ACEB10F0
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L01
       mov       rcx,1A742287028
       call      qword ptr [7FF86BC27C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L02
M00_L01:
       mov       rdi,rsi
M00_L02:
       cmp       [rdi],dil
       lea       rsi,[rdi+40]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L25
M00_L03:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L26
       mov       rsi,[rcx+8]
M00_L04:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+180],r8
       mov       [rsp+188],r8
       mov       [rsp+190],r8d
       mov       [rsp+194],edx
       mov       ebp,10
       inc       edi
M00_L05:
       dec       edi
       je        near ptr M00_L11
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L08
       cmp       dword ptr [rsp+190],0
       je        near ptr M00_L27
       cmp       dword ptr [rsp+190],1
       je        short M00_L09
       mov       edx,[rsp+194]
       cmp       edx,[rsp+190]
       je        near ptr M00_L29
M00_L06:
       movsxd    rdx,dword ptr [rsp+190]
       mov       rcx,[rsp+180]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L07:
       mov       edx,[rsp+190]
       inc       edx
       mov       [rsp+190],edx
M00_L08:
       add       rbp,8
       jmp       short M00_L05
M00_L09:
       cmp       dword ptr [rsp+194],2
       jl        near ptr M00_L28
M00_L10:
       movsxd    rdx,dword ptr [rsp+194]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+180],rax
       mov       rcx,[rsp+180]
       mov       r8,[rsp+188]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L06
M00_L11:
       mov       rsi,[rsp+180]
       mov       rdi,[rsp+188]
       mov       ebp,[rsp+190]
       test      ebp,ebp
       je        near ptr M00_L30
       cmp       ebp,1
       je        near ptr M00_L31
       test      ebp,ebp
       jl        near ptr M00_L32
       test      rsi,rsi
       je        near ptr M00_L33
       cmp       [rsi+8],ebp
       je        short M00_L13
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rcx,[rdi+10]
       lea       rdx,[rsi+10]
       mov       r8d,[rsi+8]
       cmp       ebp,r8d
       cmovg     ebp,r8d
       mov       r8d,ebp
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L35
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M00_L34
M00_L12:
       mov       rsi,rdi
M00_L13:
       mov       rcx,166C34002F8
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L36
M00_L14:
       test      rsi,rsi
       je        near ptr M00_L37
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L38
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L40
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L39
       mov       rcx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L15:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L45
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],rdx
       jne       near ptr M00_L44
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M00_L20
       lea       r14,[rdx+10]
       mov       esi,[rdx+8]
M00_L16:
       mov       rdi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+140],ymm0
       vmovdqu   ymmword ptr [rsp+160],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+48],ymm0
       vmovdqu   ymmword ptr [rsp+68],ymm0
       vmovdqu   ymmword ptr [rsp+88],ymm0
       vmovdqu   ymmword ptr [rsp+0A8],ymm0
       vmovdqu   ymmword ptr [rsp+0C8],ymm0
       vmovdqu   ymmword ptr [rsp+0E8],ymm0
       vmovdqu   ymmword ptr [rsp+100],ymm0
       xor       edx,edx
       mov       [rsp+38],edx
       mov       [rsp+3C],edx
       mov       [rsp+40],edx
       lea       rdx,[rsp+140]
       mov       [rsp+120],rdx
       mov       dword ptr [rsp+128],8
       lea       rdx,[rsp+140]
       mov       [rsp+130],rdx
       mov       dword ptr [rsp+138],8
       test      esi,esi
       jle       short M00_L19
       xor       ebp,ebp
M00_L17:
       mov       r15,[r14+rbp]
       mov       rdx,r15
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L18
       mov       rcx,[rsp+130]
       mov       edx,[rsp+138]
       mov       eax,[rsp+40]
       cmp       eax,edx
       jae       near ptr M00_L42
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r15
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rsp+40]
       inc       ecx
       mov       [rsp+40],ecx
M00_L18:
       add       rbp,8
       dec       esi
       jne       short M00_L17
M00_L19:
       mov       esi,[rsp+3C]
       add       esi,[rsp+40]
       jo        near ptr M00_L47
       mov       edx,esi
       test      edx,edx
       je        short M00_L21
       movsxd    rdx,edx
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       r8,offset MT_System.Reflection.MethodInfo[]
       cmp       [rdi],r8
       jne       near ptr M00_L43
       lea       r8,[rdi+10]
       mov       [rsp+20],r8
       mov       [rsp+28],esi
       lea       r8,[rsp+20]
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FF86C477D68]
       jmp       short M00_L22
M00_L20:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L16
M00_L21:
       mov       rdx,166C3400310
       mov       rdi,[rdx]
M00_L22:
       mov       r8d,[rsp+38]
       test      r8d,r8d
       jne       short M00_L24
M00_L23:
       mov       rdx,rdi
       mov       rcx,7FF86C36D650
       call      qword ptr [7FF86C15D398]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+30],rax
       mov       rcx,[rbx+90]
       lea       r8,[rsp+30]
       mov       rdx,7FF86C36E648
       cmp       [rcx],ecx
       call      qword ptr [7FF86C336E50]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,198
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M00_L24:
       lea       rcx,[rsp+38]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FF86C476F88]
       jmp       short M00_L23
M00_L25:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FF8CB8421C0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L03
M00_L26:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF86BC2D2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L04
M00_L27:
       mov       [rsp+188],r14
       jmp       near ptr M00_L07
M00_L28:
       mov       dword ptr [rsp+194],4
       jmp       near ptr M00_L10
M00_L29:
       mov       r15d,[rsp+194]
       add       r15d,r15d
       lea       rdx,[rsp+180]
       mov       r8d,r15d
       mov       rcx,7FF86BD723B8
       call      qword ptr [7FF86BC2D500]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+194],r15d
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,166C3400310
       mov       rsi,[rcx]
       jmp       near ptr M00_L13
M00_L31:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L13
M00_L32:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86C1D6730]
       int       3
M00_L33:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L13
M00_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L12
M00_L35:
       call      qword ptr [7FF86C1DEB38]
       jmp       near ptr M00_L12
M00_L36:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,166C34002E8
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c.<GetAllAbstractMethodsNoCache>b__64_0(System.Reflection.MethodInfo)
       call      qword ptr [7FF86BC26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,166C34002F8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L14
M00_L37:
       mov       ecx,11
       call      qword ptr [7FF86BE47E58]
       int       3
M00_L38:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L15
M00_L39:
       mov       rdx,166C3400310
       mov       r14,[rdx]
       jmp       near ptr M00_L15
M00_L40:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L41
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FF86C477B40]
       mov       r14,rsi
       jmp       near ptr M00_L15
M00_L41:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF86C477B58]
       jmp       near ptr M00_L15
M00_L42:
       lea       rcx,[rsp+38]
       mov       r8,r15
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FF86C476F58]
       jmp       near ptr M00_L18
M00_L43:
       call      qword ptr [7FF86C476F70]
       int       3
M00_L44:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L45:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L46
       mov       rdx,rax
       mov       rcx,7FF86C4C25A8
       call      qword ptr [7FF86BFB7F30]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L46:
       mov       rdx,r14
       mov       rcx,7FF86C4C2630
       call      qword ptr [7FF86C476BE0]
       mov       rdi,rax
       jmp       near ptr M00_L23
M00_L47:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1872
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD61B50
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M01_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C47D1E8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C33F6C0]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BC27C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M02_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M02_L02
       cmp       rdx,[r8]
       je        short M02_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M02_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF86BC2D908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FF86C33C708]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF8CB8940D0
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M03_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
M03_L00:
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       jne       short M03_L03
M03_L01:
       xor       edx,edx
M03_L02:
       mov       rax,rdx
       ret
M03_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       test      rax,rax
       je        short M03_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M03_L02
       jmp       short M03_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       r8,166AD400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M04_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M04_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M04_L03
       cmp       ebx,[r11]
       jne       short M04_L04
M04_L01:
       cmp       esi,1
       je        short M04_L02
       test      esi,esi
       jne       short M04_L05
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M04_L03:
       test      ebx,ebx
       je        short M04_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M04_L00
M04_L04:
       mov       esi,2
       jmp       short M04_L01
M04_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86BC2D920]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M05_L02
       cmp       dword ptr [rbx+8],0
       jne       short M05_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L01
M05_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rdx,7FF86C490330
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M05_L00
M05_L02:
       mov       ecx,2
       call      qword ptr [7FF86BE4C228]
       int       3
M05_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M05_L04
       jmp       short M05_L05
M05_L04:
       mov       rdx,7FF86C490330
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M05_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF86C0669E8]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 156
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
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,9AE9405033A5
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M07_L00
       cmp       dword ptr [rbx+8],0
       jne       short M07_L03
M07_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,1A742280008
       call      qword ptr [7FF86BC2D338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M07_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF86BC2D590]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,9AE9405033A5
       cmp       [rbp],r8
       je        short M07_L02
       call      CORINFO_HELP_FAIL_FAST
M07_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M07_L03:
       cmp       r14d,1
       je        near ptr M07_L07
M07_L04:
       mov       rcx,166AD400220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FF86BD7F1A8]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       ja        near ptr M07_L08
       mov       edx,eax
       mov       r8,rdx
       test      r8,r8
       je        short M07_L06
       mov       rcx,r8
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M07_L05
       xor       ecx,ecx
M07_L05:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M07_L05
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M07_L06:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF86BC2D338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M07_L01
M07_L07:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M07_L04
       cmp       word ptr [rbx+0C],2A
       je        near ptr M07_L04
       jmp       near ptr M07_L00
M07_L08:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M07_L06
; Total bytes of code 371
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M08_L04
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M08_L05
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M08_L02
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L03
       mov       rcx,rax
M08_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       lea       rcx,[r14+10]
       lea       rdx,[rdi+10]
       cmp       ebx,ebp
       cmovg     ebx,ebp
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M08_L09
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       short M08_L08
M08_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M08_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M08_L03:
       mov       rdx,7FF86C38D6B0
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M08_L00
M08_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86C1D6730]
       int       3
M08_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M08_L06
       mov       rcx,rax
       jmp       short M08_L07
M08_L06:
       mov       rdx,7FF86C38D6B0
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M08_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M08_L02
M08_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M08_L01
M08_L09:
       call      qword ptr [7FF86C1DEB38]
       jmp       near ptr M08_L01
; Total bytes of code 257
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c.<GetAllAbstractMethodsNoCache>b__64_0(System.Reflection.MethodInfo)
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rdx],rcx
       jne       short M09_L01
       mov       ebx,[rdx+5C]
M09_L00:
       test      ebx,400
       setne     al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       ebx,eax
       jmp       short M09_L00
; Total bytes of code 58
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M10_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FF86C33FD98]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M11_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M11_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M11_L04
       cmp       [r10],rcx
       je        short M11_L01
M11_L00:
       cmp       [r10+8],rcx
       je        short M11_L01
       cmp       [r10+10],rcx
       jne       short M11_L03
M11_L01:
       mov       rax,rdx
       ret
M11_L02:
       cmp       [r10],rcx
       je        short M11_L01
       jmp       short M11_L00
M11_L03:
       cmp       [r10+18],rcx
       je        short M11_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M11_L02
       test      r8,r8
       je        short M11_L05
M11_L04:
       cmp       [r10],rcx
       je        short M11_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M11_L04
M11_L05:
       test      dword ptr [rax],500C0000
       jne       short M11_L06
       xor       edx,edx
       jmp       short M11_L01
M11_L06:
       jmp       qword ptr [7FF86BFBD9B0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 116
```
```assembly
; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,rbx
       call      qword ptr [7FF8D6C88600]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M12_L00
       mov       rcx,rbx
       call      qword ptr [7FF8D6C87A48]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FF8D6C856D8]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FF8D6C88608]
       mov       rcx,rsi
       mov       r11,rax
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [rax]
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M12_L00:
       mov       rcx,rbx
       call      qword ptr [7FF8D6C88228]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllConstructorsCached()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllConstructors>d__22
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2467FAC7028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllConstructors_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__65
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,1F1768A7028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredFieldsCached()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+48],xmm4
       xor       eax,eax
       mov       [rsp+58],rax
       mov       [rsp+0C0],rcx
       mov       rcx,1AB167810F0
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M00_L00
       mov       rcx,1EBAD3E7028
       call      qword ptr [7FF86BBF7C78]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       short M00_L01
M00_L00:
       mov       rdi,rsi
M00_L01:
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       near ptr M00_L08
       mov       [rsp+40],rdi
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBFC6F0]; System.Type.GetRootElementType()
       mov       rsi,rax
       mov       [rsp+38],rsi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L18
       mov       rcx,[rsi+18]
       test      cl,2
       je        short M00_L02
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       mov       eax,[rcx]
       and       eax,80000030
       cmp       eax,30
       sete      al
       movzx     eax,al
M00_L03:
       test      eax,eax
       jne       short M00_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L19
       mov       rcx,rsi
       call      qword ptr [7FF86BBFC6F0]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       test      rax,rax
       je        near ptr M00_L46
       mov       rcx,rax
       call      00007FF8CB849400
M00_L04:
       test      eax,eax
       jne       near ptr M00_L47
M00_L05:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M00_L20
       mov       rcx,[rsi+18]
       mov       rax,7FF8CB8440B0
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M00_L48
M00_L06:
       cmp       ebx,1B
       je        near ptr M00_L47
M00_L07:
       mov       rdi,[rsp+40]
       lea       rdx,[rdi+20]
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FF86BD64B40]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M00_L08:
       test      rsi,rsi
       je        near ptr M00_L49
       cmp       dword ptr [rsi+8],0
       je        near ptr M00_L49
       mov       edi,[rsi+8]
       lea       edx,[rdi+15]
       test      edx,edx
       jl        near ptr M00_L50
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       rcx,[rbp+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,edi
       lea       rax,[rbp+rax*2+0C]
       vmovups   ymm0,[7FF86C415AC0]
       vmovups   [rax],ymm0
       mov       rcx,64006C00650069
       mov       [rax+20],rcx
       mov       word ptr [rax+28],73
M00_L09:
       mov       rcx,1AB2E4002E8
       mov       rsi,[rcx]
       mov       edi,[rbp+8]
       test      edi,edi
       je        near ptr M00_L51
       movzx     ecx,word ptr [rbp+0C]
       cmp       ecx,100
       jge       near ptr M00_L53
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L55
M00_L10:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [rbp+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M00_L54
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M00_L55
M00_L11:
       mov       rdi,rbp
M00_L12:
       mov       rsi,[rsi+10]
       test      rdi,rdi
       jne       near ptr M00_L21
       xor       r14d,r14d
       xor       r15d,r15d
M00_L13:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M00_L56
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L57
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       lea       rcx,[rsp+48]
       call      qword ptr [7FF86C1A64D8]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M00_L14:
       mov       [rsp+74],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L81
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L28
M00_L15:
       test      r13,r13
       je        near ptr M00_L70
       cmp       eax,[r13+20]
       jne       near ptr M00_L59
       mov       r8,[r13+8]
       test      r15d,r15d
       je        near ptr M00_L58
M00_L16:
       test      r8,r8
       jne       near ptr M00_L22
       xor       edx,edx
       xor       r10d,r10d
M00_L17:
       cmp       r15d,r10d
       jne       near ptr M00_L27
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M00_L23
       mov       rcx,r14
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M00_L24
M00_L18:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M00_L03
M00_L19:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M00_L04
M00_L20:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M00_L47
       jmp       near ptr M00_L07
M00_L21:
       lea       r14,[rdi+0C]
       mov       r15d,[rdi+8]
       jmp       near ptr M00_L13
M00_L22:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       near ptr M00_L17
M00_L23:
       mov       rcx,r14
       call      qword ptr [7FF86BBFFC00]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M00_L24:
       test      eax,eax
       je        near ptr M00_L59
M00_L25:
       mov       r14,[r13+10]
M00_L26:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M00_L29
       call      qword ptr [7FF86C126DD8]; System.DateTime.get_UtcNow()
       mov       r15,rax
       jmp       short M00_L30
M00_L27:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M00_L24
M00_L28:
       test      r13,r13
       jne       near ptr M00_L60
       jmp       near ptr M00_L70
M00_L29:
       lea       rdx,[rsp+60]
       mov       r11,7FF86BB40C68
       call      qword ptr [r11]
       mov       r15,4000000000000000
       or        r15,[rsp+68]
M00_L30:
       test      r14,r14
       je        near ptr M00_L44
       cmp       byte ptr [r14+43],0
       jne       near ptr M00_L43
       cmp       qword ptr [r14+38],0
       jge       short M00_L31
       cmp       qword ptr [r14+50],0
       je        short M00_L34
M00_L31:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r15
       cmp       [r14+38],rdx
       jbe       near ptr M00_L71
       cmp       qword ptr [r14+50],0
       jg        near ptr M00_L72
M00_L32:
       xor       r13d,r13d
M00_L33:
       test      r13d,r13d
       jne       near ptr M00_L43
M00_L34:
       cmp       qword ptr [r14+10],0
       je        short M00_L35
       mov       rcx,[r14+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF86C487C48]
       test      eax,eax
       jne       near ptr M00_L43
M00_L35:
       mov       [r14+58],r15
       mov       rdi,[r14+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M00_L73
M00_L36:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r15
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M00_L40
       mov       [rsi+48],r15
       test      byte ptr [7FF86C4F1B90],1
       je        near ptr M00_L74
M00_L37:
       mov       rcx,1AB2E4004B0
       mov       r14,[rcx]
       test      r14,r14
       jne       short M00_L38
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,1AB2E4004A8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M00_L75
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF86C488918
       mov       [r14+18],rcx
       mov       rcx,1AB2E4004B0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M00_L38:
       test      byte ptr [7FF86C4E0D20],1
       je        near ptr M00_L76
M00_L39:
       mov       rcx,1AB2E4004E0
       mov       r15,[rcx]
       test      r15,r15
       je        near ptr M00_L77
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r14,r14
       je        near ptr M00_L78
       mov       dword ptr [rsp+20],8
       mov       dword ptr [rsp+28],2000
       mov       [rsp+30],r15
       mov       rcx,r13
       mov       rdx,r14
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF86C48C960]
       call      qword ptr [7FF86C48C978]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FF86C48C990]
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF86C48C9A8]
M00_L40:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M00_L79
M00_L41:
       test      rdi,rdi
       je        near ptr M00_L80
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L45
       mov       r14,rdi
       test      r14,r14
       je        short M00_L42
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       cmp       [r14],rcx
       je        short M00_L42
       mov       rdx,rdi
       call      qword ptr [7FF86BBF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r14,rax
M00_L42:
       mov       [rsp+58],r14
       mov       rbx,[rsp+0C0]
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FF86C38FCF0
       cmp       [rcx],ecx
       call      qword ptr [7FF86C307E10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,78
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L43:
       cmp       byte ptr [r14+45],2
       je        near ptr M00_L35
       mov       r8,[rsi+10]
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FF86C487CA8]
M00_L44:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FF86C48C9C0]
       cmp       qword ptr [rsi+20],0
       je        short M00_L45
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C487C90]
       inc       qword ptr [rax+18]
M00_L45:
       mov       rcx,1EBAD3E7028
       mov       edx,3E
       mov       rax,[7FF86BB3A200]
       call      qword ptr [rax+28]
       mov       r14,rax
       mov       ecx,5
       call      qword ptr [7FF86C306F70]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,1AB2E4002E8
       mov       rcx,[rcx]
       mov       r8,rbp
       mov       r9,r14
       mov       rdx,7FF86C33EB60
       call      qword ptr [7FF86C306F40]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L42
M00_L46:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C30F540]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86C30F558]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L47:
       xor       esi,esi
       jmp       near ptr M00_L08
M00_L48:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L06
M00_L49:
       mov       rbp,1EBAD3F1CB8
       jmp       near ptr M00_L09
M00_L50:
       call      qword ptr [7FF86C30FEA0]
       int       3
M00_L51:
       call      qword ptr [7FF86C034A68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L52
       call      qword ptr [7FF86C48C888]
       mov       rbx,rax
M00_L52:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1EBAD3E9C30
       call      qword ptr [7FF86C30F558]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       call      qword ptr [7FF86C484BD0]
       test      eax,eax
       jne       short M00_L55
       jmp       near ptr M00_L10
M00_L54:
       call      qword ptr [7FF86C484BD0]
       test      eax,eax
       je        near ptr M00_L11
M00_L55:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF86C487A50]
       mov       rdi,rax
       jmp       near ptr M00_L12
M00_L56:
       call      qword ptr [7FF86C487B88]
       int       3
M00_L57:
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       lea       rdx,[rsp+48]
       mov       rcx,r12
       mov       r11,7FF86BB40C58
       call      qword ptr [r11]
       jmp       near ptr M00_L14
M00_L58:
       test      r8,r8
       jne       near ptr M00_L16
M00_L59:
       mov       r13,[r13+18]
       mov       eax,[rsp+74]
       jmp       near ptr M00_L15
M00_L60:
       cmp       eax,[r13+20]
       jne       near ptr M00_L68
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M00_L61
       mov       [rsp+48],r14
       mov       [rsp+50],r15d
       lea       rdx,[rsp+48]
       mov       rcx,r12
       mov       r11,7FF86BB40C60
       call      qword ptr [r11]
       jmp       short M00_L69
M00_L61:
       test      r15d,r15d
       jne       short M00_L62
       test      r8,r8
       je        short M00_L68
M00_L62:
       test      r8,r8
       je        short M00_L63
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M00_L64
M00_L63:
       xor       edx,edx
       xor       r10d,r10d
M00_L64:
       cmp       r15d,r10d
       je        short M00_L65
       xor       edx,edx
       mov       eax,edx
       jmp       short M00_L67
M00_L65:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M00_L66
       mov       rcx,r14
       call      qword ptr [7FF86BBFFC00]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L67
M00_L66:
       mov       r8,r14
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M00_L67:
       jmp       short M00_L69
M00_L68:
       mov       r13,[r13+18]
       mov       eax,[rsp+74]
       jmp       near ptr M00_L28
M00_L69:
       test      eax,eax
       je        short M00_L68
       jmp       near ptr M00_L25
M00_L70:
       xor       r14d,r14d
       jmp       near ptr M00_L26
M00_L71:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FF86C48C930]
       mov       r13d,1
       jmp       near ptr M00_L33
M00_L72:
       mov       rdx,[r14+58]
       mov       rcx,r15
       call      qword ptr [7FF86C307B70]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[r14+50]
       call      qword ptr [7FF86C48C948]
       test      eax,eax
       jne       short M00_L71
       jmp       near ptr M00_L32
M00_L73:
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF86C487C60]
       jmp       near ptr M00_L36
M00_L74:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L37
M00_L75:
       call      qword ptr [7FF86C484D68]
       int       3
M00_L76:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF86BBF5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L39
M00_L77:
       mov       ecx,2F
       call      qword ptr [7FF86BE1C258]
       int       3
M00_L78:
       mov       ecx,1C
       call      qword ptr [7FF86BE1C258]
       int       3
M00_L79:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C487C90]
       inc       qword ptr [rax+10]
       jmp       near ptr M00_L41
M00_L80:
       xor       r14d,r14d
       jmp       near ptr M00_L42
M00_L81:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2361
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD31B50
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M01_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C48DF50]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C4846A8]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BBF7CC0]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Type.GetRootElementType()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M02_L00:
       cmp       [rbx],rsi
       jne       near ptr M02_L07
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L05
       mov       rcx,[rsp+28]
M02_L01:
       cmp       ebx,1D
       ja        short M02_L02
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M02_L06
M02_L02:
       cmp       ebx,10
       sete      dil
       movzx     edi,dil
M02_L03:
       test      edi,edi
       jne       short M02_L04
       mov       [rsp+28],rcx
       mov       rcx,7FF86C3DBEB0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,[rsp+28]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       [rsp+28],rcx
       mov       rcx,7FF86C3DBDA0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsp+28]
       mov       rdx,7FF86C3DBDA8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rbx,[rsp+28]
       mov       rcx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       [rsp+28],rax
       mov       rbx,[rsp+28]
       jmp       near ptr M02_L00
M02_L05:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M02_L01
M02_L06:
       mov       edi,1
       jmp       near ptr M02_L03
M02_L07:
       mov       rcx,rbx
       mov       [rsp+28],rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       edi,eax
       mov       rcx,[rsp+28]
       jmp       near ptr M02_L03
; Total bytes of code 268
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD64B58]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M04_L06
       cmp       r8,40
       jbe       short M04_L02
       cmp       r8,800
       ja        near ptr M04_L11
       cmp       r8,100
       jae       near ptr M04_L09
M04_L00:
       mov       r9,r8
       shr       r9,6
M04_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M04_L03
M04_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M04_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M04_L05
M04_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L04:
       vzeroupper
       ret
M04_L05:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L03
M04_L06:
       test      r8b,18
       je        short M04_L07
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M04_L04
M04_L07:
       test      r8b,4
       je        short M04_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L04
M04_L08:
       test      r8,r8
       je        short M04_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L04
M04_L09:
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
       jmp       near ptr M04_L00
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L04
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF86BBF66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 327
```
```assembly
; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
       push      rax
       xor       eax,eax
       mov       [rsp],rax
M05_L00:
       mov       eax,15051505
       mov       edx,15051505
       mov       r8d,[rcx+8]
       mov       rcx,[rcx]
       mov       [rsp],rcx
M05_L01:
       cmp       r8d,3
       jbe       short M05_L03
M05_L02:
       add       r8d,0FFFFFFFC
       mov       r10d,eax
       rol       r10d,5
       add       eax,r10d
       xor       eax,[rcx]
       mov       r10d,edx
       rol       r10d,5
       add       edx,r10d
       xor       edx,[rcx+4]
       add       rcx,8
       cmp       r8d,4
       jge       short M05_L02
       jmp       short M05_L01
M05_L03:
       mov       r8d,r8d
       lea       r10,[7FF86C414FA0]
       mov       r10d,[r10+r8*4]
       lea       r9,[M05_L00]
       add       r10,r9
       jmp       r10
       mov       r8d,eax
       rol       r8d,5
       add       r8d,eax
       mov       eax,r8d
       xor       eax,[rcx]
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       movzx     edx,word ptr [rcx+4]
       xor       edx,r8d
M05_L04:
       xor       ecx,ecx
       mov       [rsp],rcx
       imul      ecx,edx,5D588B65
       add       eax,ecx
       add       rsp,8
       ret
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rcx]
       jmp       short M05_L04
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       movzx     edx,word ptr [rcx]
       xor       edx,r8d
       jmp       short M05_L04
; Total bytes of code 188
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M06_L03
       cmp       rcx,rdx
       je        short M06_L02
       cmp       r8,20
       jb        near ptr M06_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L01
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L12
M06_L00:
       add       rax,20
       cmp       r8,rax
       jbe       short M06_L01
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L12
       jmp       short M06_L00
M06_L01:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M06_L12
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       r8,4
       jae       short M06_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L04:
       test      r8b,1
       je        short M06_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M06_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L07
M06_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M06_L07:
       vzeroupper
       ret
M06_L08:
       cmp       r8,10
       jb        short M06_L11
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L10
M06_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M06_L12
       add       rax,10
       cmp       r8,rax
       ja        short M06_L09
M06_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M06_L12
       jmp       near ptr M06_L02
M06_L11:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M06_L07
M06_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 317
```
```assembly
; System.DateTime.get_UtcNow()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       lea       rcx,[rbp-18]
       mov       rax,7FF922735390
       call      rax
       mov       rbx,[rbp-18]
       mov       rax,1AB18401B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       short M07_L01
M07_L00:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       short M07_L02
       mov       rax,rbx
       add       rax,[rsi+10]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M07_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M07_L00
M07_L02:
       call      qword ptr [7FF86C126FA0]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M08_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M08_L01
M08_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       r8,1AB18400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M08_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M08_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M08_L04
M08_L03:
       test      ebx,ebx
       je        short M08_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M08_L02
       jmp       short M08_L05
M08_L04:
       cmp       ebx,[r11]
       jne       short M08_L05
       jmp       short M08_L06
M08_L05:
       mov       esi,2
M08_L06:
       cmp       esi,1
       je        near ptr M08_L00
       test      esi,esi
       jne       short M08_L07
       xor       edx,edx
       jmp       near ptr M08_L00
M08_L07:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86BBFD950]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 177
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M09_L00
       mov       rax,[rdx]
       cmp       rax,rcx
       jne       short M09_L01
M09_L00:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M09_L01:
       mov       r8,1AB18400038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
       cmp       r9d,8
       jge       short M09_L05
M09_L02:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M09_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       jbe       short M09_L04
M09_L03:
       test      ebx,ebx
       je        short M09_L05
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M09_L02
       jmp       short M09_L05
M09_L04:
       cmp       ebx,[r11]
       jne       short M09_L05
       cmp       esi,1
       je        near ptr M09_L00
M09_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86BBF6340]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 165
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
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M11_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M11_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M11_L00:
       call      qword ptr [7FF8AC23F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,1EBAD3E9C30
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1EBAD3E0008
       call      qword ptr [7FF86C034A38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M12_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M12_L01
M12_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C37FCB8
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M12_L01:
       mov       rax,1EBAD3EBB78
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,1EBAD3E0008
       call      qword ptr [7FF86BF8E4F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C307A20]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF86C307C00]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M12_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M12_L03
M12_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C390130
       call      qword ptr [7FF86BE17B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M12_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF86C307C18]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF86C307BB8]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```
```assembly
; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rax,rcx
       ret
; Total bytes of code 30
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M14_L00
       ret
M14_L00:
       jmp       qword ptr [7FF86BBF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FF86BE1E250]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredFields_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredFieldsNoCache>d__66
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2C5DDA07028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredMethodsCached()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllDeclaredMethods>d__24
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2C0C3BF7028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredMethods_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredMethodsNoCache>d__67
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,157187A7028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllFieldsCached()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllFields>d__25
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,1E0317D7028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllFields_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__68
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,27A4CBF7028
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllMethodsCached()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllMethods>d__27
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2DFC70AF4C8
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllMethods_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__69
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,1AA819AF4C8
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllPropertiesCached()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.TypeHelper+<GetAllProperties>d__28
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+2C],eax
       mov       rcx,2D52FDDB690
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllProperties_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__70
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,25A03B7B690
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAttributeFieldInfo()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,88
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       xor       eax,eax
       mov       [rsp+80],rax
       mov       rbx,rcx
       mov       rcx,1C69EC01CB8
       mov       rdx,1C69EC01CE0
       mov       r8d,1C
       call      qword ptr [7FF86BB2A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L18
       xor       ecx,ecx
       mov       [rsp+60],rcx
       mov       rcx,18609C00C88
       mov       rdi,[rcx]
       mov       rcx,18609C00C90
       mov       rbp,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L19
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L19
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L21
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L21
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M00_L21
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M00_L20
M00_L01:
       mov       [rsp+68],r14
       lea       rcx,[r14+10]
       mov       eax,[r14+8]
       mov       [rsp+78],rcx
       mov       [rsp+80],eax
       xor       ecx,ecx
       mov       [rsp+70],ecx
       mov       byte ptr [rsp+74],0
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L36
       mov       rcx,[rsi+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M00_L35
       mov       rcx,[rsi+10]
M00_L02:
       test      rcx,rcx
       je        near ptr M00_L37
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L38
       cmp       qword ptr [rcx+10],0
       je        short M00_L03
       mov       rax,[rcx+10]
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M00_L05
M00_L03:
       call      qword ptr [7FF86BBE7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
M00_L04:
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       short M00_L07
       mov       rcx,[rbp+8]
       call      qword ptr [7FF86BD54AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M00_L06
       xor       edx,edx
       jmp       short M00_L07
M00_L05:
       mov       rbp,rdi
       jmp       short M00_L04
M00_L06:
       lea       rdx,[rbp+20]
       mov       rcx,rbp
       mov       r8d,3
       call      qword ptr [7FF86BD54B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
M00_L07:
       cmp       byte ptr [rsp+74],0
       jne       near ptr M00_L39
       test      rdx,rdx
       je        near ptr M00_L39
       mov       r8d,[rsp+70]
       cmp       r8d,[rsp+80]
       ja        near ptr M00_L46
       mov       rcx,[rsp+78]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,r8d
       mov       edi,[rdx+8]
       cmp       edi,eax
       ja        near ptr M00_L39
       mov       r8d,edi
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+70]
       mov       [rsp+70],edi
M00_L08:
       mov       ecx,[rsp+70]
       cmp       ecx,[rsp+80]
       ja        near ptr M00_L46
       mov       rdx,[rsp+78]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,ecx
       je        near ptr M00_L40
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+70]
       inc       ecx
       mov       [rsp+70],ecx
M00_L09:
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L42
       mov       rdx,[rsi+20]
       test      rdx,rdx
       je        near ptr M00_L41
M00_L10:
       cmp       byte ptr [rsp+74],0
       jne       near ptr M00_L43
       test      rdx,rdx
       je        near ptr M00_L43
       mov       r8d,[rsp+70]
       cmp       r8d,[rsp+80]
       ja        near ptr M00_L46
       mov       rcx,[rsp+78]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,r8d
       mov       edi,[rdx+8]
       cmp       edi,eax
       ja        near ptr M00_L43
       mov       r8d,edi
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+70]
       mov       [rsp+70],edi
M00_L11:
       mov       ecx,[rsp+70]
       cmp       ecx,[rsp+80]
       ja        near ptr M00_L46
       mov       rdx,[rsp+78]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,ecx
       je        near ptr M00_L44
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+70]
       inc       ecx
       mov       [rsp+70],ecx
M00_L12:
       cmp       byte ptr [rsp+74],0
       jne       near ptr M00_L45
       mov       ecx,[rsp+70]
       cmp       ecx,[rsp+80]
       ja        near ptr M00_L46
       mov       rdx,[rsp+78]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,ecx
       cmp       eax,0C
       jb        near ptr M00_L45
       vmovups   xmm0,[7FF86C408C30]
       vmovups   [rdx],xmm0
       mov       rcx,65007400750062
       mov       [rdx+10],rcx
       mov       ecx,[rsp+70]
       add       ecx,0C
       mov       [rsp+70],ecx
M00_L13:
       mov       edx,[rsp+70]
       cmp       edx,[rsp+80]
       ja        near ptr M00_L46
       mov       rcx,[rsp+78]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+80]
       sub       eax,edx
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
       lea       rdx,[rsp+40]
       mov       rcx,1C69EC01D68
       call      qword ptr [7FF86C47CA08]; System.String.TryCopyTo(System.Span`1<Char>)
       test      eax,eax
       je        near ptr M00_L47
       mov       ecx,[rsp+70]
       add       ecx,0B
       mov       [rsp+70],ecx
M00_L14:
       mov       rcx,186098410E8
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L15
       mov       rcx,1C69EC01D98
       call      qword ptr [7FF86BBE7C48]; System.RuntimeType.InitializeCache()
       jmp       short M00_L16
M00_L15:
       mov       rax,rcx
M00_L16:
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86C117588]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rdx,rax
       lea       rcx,[rsp+60]
       call      qword ptr [7FF86BE0E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+60]
       call      qword ptr [7FF86BE04EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,1861FC002F8
       mov       rcx,[rcx]
       lea       r9,[rsp+58]
       mov       r8,rdi
       mov       rdx,7FF86C32F3E8
       call      qword ptr [7FF86C2F6D60]; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L48
       mov       rbp,[rsp+58]
M00_L17:
       xor       ecx,ecx
       mov       [rsp+58],rcx
       mov       [rsp+50],rbp
       mov       rcx,[rbx+90]
       lea       r8,[rsp+50]
       mov       rdx,7FF86C3908C8
       cmp       [rcx],ecx
       call      qword ptr [7FF86C2F7D20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,88
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L18:
       call      qword ptr [7FF86C19F1B0]
       mov       ecx,2CFB
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C47C9A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C2FF540]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L19:
       mov       ecx,3
       call      qword ptr [7FF86C2FEEB0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FF86C4776C0]
       jmp       near ptr M00_L01
M00_L21:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L33
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L32
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF86BBE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF86BB2B1A4],0
       je        short M00_L22
       call      qword ptr [7FF86C4776D8]
       mov       r15d,eax
       jmp       short M00_L24
M00_L22:
       mov       ecx,0B
       call      qword ptr [7FF86C4776F0]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FF86C4776F0]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M00_L23
       call      qword ptr [7FF86C477708]
       mov       r15d,eax
       jmp       short M00_L24
M00_L23:
       sar       r15d,10
M00_L24:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF86BBE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF86BB2B198]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M00_L28
M00_L25:
       cmp       r15d,[r14+8]
       jae       near ptr M00_L50
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rcx,r12
       call      qword ptr [7FF86C11E448]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L26
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+38],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M00_L26:
       mov       rcx,r12
       call      qword ptr [7FF86BBE6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+38]
       test      r12,r12
       jne       short M00_L29
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M00_L27
       xor       r15d,r15d
M00_L27:
       inc       r13d
M00_L28:
       cmp       [r14+8],r13d
       jg        short M00_L25
       jmp       short M00_L30
M00_L29:
       mov       r14,r12
       jmp       short M00_L31
M00_L30:
       xor       r14d,r14d
M00_L31:
       test      r14,r14
       je        short M00_L32
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L01
       mov       rcx,r14
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FF86C4776C0]
       jmp       near ptr M00_L01
M00_L32:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L01
       jmp       short M00_L34
M00_L33:
       mov       ecx,100
       mov       rdx,1C69EBF6F28
       call      qword ptr [7FF86BE0DAD0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L32
M00_L34:
       mov       rcx,r14
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rbp
       call      qword ptr [7FF86C4776C0]
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rbp
       mov       edx,r15d
       mov       r8d,100
       call      qword ptr [7FF86C477720]
       jmp       near ptr M00_L01
M00_L35:
       xor       ecx,ecx
       jmp       near ptr M00_L02
M00_L36:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L37:
       xor       edx,edx
       jmp       near ptr M00_L07
M00_L38:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L39:
       lea       rcx,[rsp+60]
       call      qword ptr [7FF86C4774E0]
       jmp       near ptr M00_L08
M00_L40:
       lea       rcx,[rsp+60]
       mov       rdx,1C69EBF0658
       call      qword ptr [7FF86C2F47B0]
       jmp       near ptr M00_L09
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FF86C47C978]; System.RuntimeFieldHandle.GetName(System.IRuntimeFieldInfo)
       mov       rdi,rax
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
       jmp       near ptr M00_L10
M00_L42:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L43:
       lea       rcx,[rsp+60]
       call      qword ptr [7FF86C4774E0]
       jmp       near ptr M00_L11
M00_L44:
       lea       rcx,[rsp+60]
       mov       rdx,1C69EBF0658
       call      qword ptr [7FF86C2F47B0]
       jmp       near ptr M00_L12
M00_L45:
       lea       rcx,[rsp+60]
       mov       rdx,1C69EC01D38
       call      qword ptr [7FF86C4774E0]
       jmp       near ptr M00_L13
M00_L46:
       call      qword ptr [7FF86BD57198]
       int       3
M00_L47:
       lea       rcx,[rsp+60]
       mov       rdx,1C69EC01D68
       call      qword ptr [7FF86C2F47B0]
       jmp       near ptr M00_L14
M00_L48:
       mov       rdx,rsi
       mov       rcx,7FF86C37F3C0
       xor       r8d,r8d
       call      qword ptr [7FF86C1168C8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L49
       mov       ecx,5
       call      qword ptr [7FF86C2F6E20]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,1861FC002F8
       mov       rcx,[rcx]
       mov       r8,rdi
       mov       r9,rbp
       mov       rdx,7FF86C37F518
       call      qword ptr [7FF86C2F6DD8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L17
M00_L49:
       xor       ebp,ebp
       jmp       near ptr M00_L17
M00_L50:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2241
```
```assembly
; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      rdi,rdi
       je        near ptr M01_L18
       test      bl,1
       jne       near ptr M01_L19
       mov       ebp,1
M01_L00:
       cmp       qword ptr [rsi+10],0
       je        short M01_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       near ptr M01_L17
M01_L01:
       mov       rcx,rsi
       call      qword ptr [7FF86BBE7C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M01_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M01_L20
M01_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M01_L21
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M01_L29
       test      r15,r15
       je        near ptr M01_L22
       lea       rdx,[r15+0C]
       mov       [rsp+20],rdx
       mov       edx,15051505
       mov       ecx,15051505
       mov       r8,[rsp+20]
       mov       r9d,[r15+8]
       cmp       r9d,2
       jle       short M01_L05
M01_L04:
       add       r9d,0FFFFFFFC
       mov       eax,edx
       rol       eax,5
       add       edx,eax
       xor       edx,[r8]
       mov       eax,ecx
       rol       eax,5
       add       ecx,eax
       xor       ecx,[r8+4]
       add       r8,8
       cmp       r9d,2
       jg        short M01_L04
M01_L05:
       test      r9d,r9d
       jg        near ptr M01_L23
M01_L06:
       imul      eax,ecx,5D588B65
       add       eax,edx
       xor       edx,edx
       mov       [rsp+20],rdx
M01_L07:
       mov       edx,eax
       not       eax
       test      edx,edx
       cmovl     edx,eax
       mov       r12,[rbp+8]
       mov       edi,[r12+8]
       mov       eax,edx
       cdq
       idiv      edi
       mov       r14d,edx
       cmp       r14d,edi
       jae       near ptr M01_L39
       mov       r8d,r14d
       mov       r13,[r12+r8*8+10]
       test      r13,r13
       je        near ptr M01_L29
M01_L08:
       cmp       r13,r15
       jne       near ptr M01_L25
M01_L09:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L39
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M01_L10:
       test      rdi,rdi
       je        near ptr M01_L30
M01_L11:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
M01_L12:
       dec       r14d
       je        short M01_L15
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M01_L14
       test      rsi,rsi
       jne       near ptr M01_L35
M01_L13:
       mov       rsi,r13
M01_L14:
       add       r15,8
       jmp       short M01_L12
M01_L15:
       test      ebp,ebp
       jne       near ptr M01_L37
M01_L16:
       mov       rax,rsi
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
M01_L17:
       mov       rsi,r14
       jmp       near ptr M01_L02
M01_L18:
       mov       ecx,3E7
       mov       rdx,7FF86BB24000
       call      qword ptr [7FF86BE07798]
       mov       rcx,rax
       call      qword ptr [7FF86C2FEBF8]
       int       3
M01_L19:
       mov       rcx,1861FC001B8
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FF86C2FFA68]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M01_L00
M01_L20:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FF8CB8421C0
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M01_L03
M01_L21:
       cmp       ebp,2
       je        near ptr M01_L31
       cmp       byte ptr [r12+18],0
       je        near ptr M01_L34
       jmp       near ptr M01_L33
M01_L22:
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,0D5782BA7
       mov       r9d,0B301FA07
       call      qword ptr [7FF86C02DB00]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       near ptr M01_L07
M01_L23:
       mov       r9d,ecx
       rol       r9d,5
       add       r9d,ecx
       mov       ecx,r9d
       xor       ecx,[r8]
       jmp       near ptr M01_L06
M01_L24:
       cmp       r14d,edi
       jae       near ptr M01_L39
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        short M01_L29
       jmp       near ptr M01_L08
M01_L25:
       test      r15,r15
       jne       short M01_L27
M01_L26:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M01_L24
       jmp       short M01_L28
M01_L27:
       mov       r8d,[r13+8]
       cmp       r8d,[r15+8]
       jne       short M01_L26
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       lea       rdx,[r15+0C]
       call      qword ptr [7FF86BBEFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M01_L26
       jmp       near ptr M01_L09
M01_L28:
       sub       r14d,edi
       jmp       short M01_L24
M01_L29:
       xor       edi,edi
       jmp       near ptr M01_L10
M01_L30:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FF86BBED2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L31:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FF86BBEF420]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L32
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FF86BBED2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L32:
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L33:
       mov       rdi,[r12+8]
       jmp       near ptr M01_L11
M01_L34:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FF86BBED2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L35:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       cmp       r12,rax
       je        near ptr M01_L38
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBEED90]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L36
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBEED90]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L36
       mov       ebp,1
M01_L36:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       r12,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rdx,rax
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+0B0]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L13
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBEED90]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L14
       jmp       near ptr M01_L13
M01_L37:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBEED90]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L16
M01_L38:
       mov       rcx,rsi
       call      qword ptr [7FF86C4767F0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1144
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M02_L08
M02_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M02_L09
M02_L01:
       test      rdi,rdi
       jne       near ptr M02_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M02_L10
M02_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M02_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD21B50
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M02_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M02_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M02_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M02_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M02_L11
M02_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M02_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C47CB10]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C474660]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M02_L02
M02_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vzeroupper
       cmp       [rcx],cl
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M03_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M03_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M03_L15
M03_L01:
       cmp       ebx,1D
       ja        short M03_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M03_L16
M03_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M03_L03:
       test      r14d,r14d
       jne       near ptr M03_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M03_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M03_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M03_L04:
       test      eax,eax
       jne       near ptr M03_L11
       cmp       rdi,rsi
       jne       near ptr M03_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M03_L05:
       cmp       [rbx],rsi
       jne       near ptr M03_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M03_L21
       mov       rcx,[rsp+28]
M03_L06:
       cmp       ebx,1D
       ja        short M03_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M03_L22
M03_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M03_L08:
       test      ebp,ebp
       jne       near ptr M03_L20
       cmp       [rcx],rsi
       jne       near ptr M03_L24
M03_L09:
       test      rcx,rcx
       je        near ptr M03_L25
       call      00007FF8CB849400
M03_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M03_L27
M03_L11:
       cmp       rdi,rsi
       jne       near ptr M03_L29
       mov       rcx,[rbp+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M03_L28
M03_L12:
       cmp       edi,1B
       je        near ptr M03_L27
M03_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M03_L00
M03_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L01
M03_L16:
       mov       r14d,1
       jmp       near ptr M03_L03
M03_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M03_L03
M03_L18:
       xor       eax,eax
       jmp       near ptr M03_L04
M03_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M03_L04
M03_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M03_L05
M03_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M03_L06
M03_L22:
       mov       ebp,1
       jmp       near ptr M03_L08
M03_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M03_L08
M03_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M03_L09
M03_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF86C2FF528]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C2FF540]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M03_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M03_L10
M03_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M03_L12
M03_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M03_L27
       jmp       near ptr M03_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD54B28]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M05_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M05_L07
       cmp       r8,40
       ja        short M05_L03
M05_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        near ptr M05_L06
M05_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L02:
       vzeroupper
       ret
M05_L03:
       cmp       r8,800
       ja        near ptr M05_L11
       cmp       r8,100
       jb        short M05_L04
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
M05_L04:
       mov       r9,r8
       shr       r9,6
M05_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L05
       and       r8,3F
       cmp       r8,10
       ja        near ptr M05_L00
       jmp       near ptr M05_L01
M05_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M05_L01
M05_L07:
       test      r8b,18
       jne       short M05_L08
       test      r8b,4
       jne       short M05_L09
       test      r8,r8
       je        near ptr M05_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M05_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M05_L02
M05_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M05_L02
M05_L09:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M05_L02
M05_L10:
       cmp       rcx,rdx
       jne       short M05_L11
       cmp       [rdx],dl
       jmp       near ptr M05_L02
M05_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF86BBE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 349
```
```assembly
; System.String.TryCopyTo(System.Span`1<Char>)
       sub       rsp,28
       mov       rax,rcx
       xor       r10d,r10d
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       jg        short M06_L00
       add       r8,r8
       mov       rcx,[rdx]
       lea       rdx,[rax+0C]
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,1
M06_L00:
       mov       eax,r10d
       add       rsp,28
       ret
; Total bytes of code 50
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetFullName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+20]
       test      rax,rax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF86BD54AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M07_L01
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86BD54B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M08_L01
       test      rdx,rdx
       je        short M08_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M08_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M08_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      qword ptr [7FF86BD57198]
       int       3
M08_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C4774E0]
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M09_L01
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rdx,rdx
       je        short M09_L00
       mov       rcx,18609C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF86BEAFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M09_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L01:
       call      qword ptr [7FF86BD57198]
       int       3
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.TryGetValueCore(key, out value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rdx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M10_L48
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M10_L48
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M10_L50
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M10_L52
M10_L00:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M10_L51
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M10_L52
M10_L01:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M10_L09
M10_L02:
       mov       rsi,[rbp+10]
       test      rbx,rbx
       jne       near ptr M10_L10
       xor       ebp,ebp
       xor       r14d,r14d
M10_L03:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M10_L11
M10_L04:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M10_L53
       mov       r15,[rsi+28]
       mov       rcx,[r15+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M10_L54
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86C1964D8]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M10_L05:
       mov       [rsp+4C],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M10_L80
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M10_L18
M10_L06:
       test      r13,r13
       je        near ptr M10_L67
       cmp       eax,[r13+20]
       jne       near ptr M10_L56
       mov       r8,[r13+8]
       test      r14d,r14d
       je        near ptr M10_L55
M10_L07:
       test      r8,r8
       jne       short M10_L12
       xor       edx,edx
       xor       r10d,r10d
M10_L08:
       cmp       r14d,r10d
       jne       near ptr M10_L17
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M10_L13
       mov       rcx,rbp
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M10_L14
M10_L09:
       mov       rcx,rsi
       mov       rdx,7FF86C36F1C8
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L02
M10_L10:
       lea       rbp,[rbx+0C]
       mov       r14d,[rbx+8]
       jmp       near ptr M10_L03
M10_L11:
       mov       rdx,7FF86C36F308
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M10_L04
M10_L12:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M10_L08
M10_L13:
       mov       rcx,rbp
       call      qword ptr [7FF86BBEFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M10_L14:
       test      eax,eax
       je        near ptr M10_L56
M10_L15:
       mov       rbp,[r13+10]
M10_L16:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M10_L19
       call      qword ptr [7FF86C116DD8]; System.DateTime.get_UtcNow()
       mov       r14,rax
       jmp       short M10_L20
M10_L17:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M10_L14
M10_L18:
       test      r13,r13
       jne       near ptr M10_L57
       jmp       near ptr M10_L67
M10_L19:
       lea       rdx,[rsp+38]
       mov       r11,7FF86BB30C88
       call      qword ptr [r11]
       mov       r14,4000000000000000
       or        r14,[rsp+40]
M10_L20:
       test      rbp,rbp
       je        near ptr M10_L42
       cmp       byte ptr [rbp+43],0
       jne       near ptr M10_L41
       cmp       qword ptr [rbp+38],0
       jge       short M10_L21
       cmp       qword ptr [rbp+50],0
       je        short M10_L24
M10_L21:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       cmp       [rbp+38],rdx
       jbe       near ptr M10_L68
       cmp       qword ptr [rbp+50],0
       jg        near ptr M10_L69
M10_L22:
       xor       r13d,r13d
M10_L23:
       test      r13d,r13d
       jne       near ptr M10_L41
M10_L24:
       cmp       qword ptr [rbp+10],0
       je        short M10_L25
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF86C477C18]
       test      eax,eax
       jne       near ptr M10_L41
M10_L25:
       mov       [rbp+58],r14
       mov       r15,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M10_L70
M10_L26:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M10_L36
       mov       [rsi+48],r14
       test      byte ptr [7FF86C4EA8D0],1
       je        near ptr M10_L71
M10_L27:
       mov       rcx,1861FC004B0
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M10_L28
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,1861FC004A8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M10_L72
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF86C478AB0
       mov       [rbp+18],rcx
       mov       rcx,1861FC004B0
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M10_L28:
       test      byte ptr [7FF86C4C5080],1
       je        near ptr M10_L73
M10_L29:
       mov       rcx,1861FC004E0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M10_L74
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M10_L75
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M10_L75
M10_L30:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M10_L31
       call      qword ptr [7FF86BE0FDB0]; System.Threading.Thread.InitializeCurrentThread()
M10_L31:
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        near ptr M10_L45
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
M10_L32:
       test      rbp,rbp
       je        near ptr M10_L47
       test      byte ptr [7FF86C4A5358],1
       je        near ptr M10_L77
M10_L33:
       mov       rcx,1861FC004F0
       cmp       rbp,[rcx]
       je        short M10_L35
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M10_L34
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M10_L34:
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M10_L35:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF86C47CAF8]
M10_L36:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M10_L78
M10_L37:
       test      r15,r15
       je        near ptr M10_L79
       mov       rcx,[rbx+18]
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M10_L44
       mov       rdx,r15
       test      rdx,rdx
       je        short M10_L38
       mov       rcx,rsi
       cmp       [rdx],rcx
       je        short M10_L38
       mov       rdx,r15
       call      qword ptr [7FF86BBE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M10_L38:
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M10_L39:
       mov       eax,1
M10_L40:
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
M10_L41:
       cmp       byte ptr [rbp+45],2
       je        near ptr M10_L25
       mov       r8,[rsi+10]
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF86C477C78]
M10_L42:
       mov       rdx,[rsi+10]
       mov       rbx,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r14
       call      qword ptr [7FF86C2F7A38]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rbx,rax
       jge       short M10_L43
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF86C477C48]
M10_L43:
       cmp       qword ptr [rsi+20],0
       je        short M10_L44
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C477C60]
       inc       qword ptr [rax+18]
M10_L44:
       xor       eax,eax
       mov       [rdi],rax
       jmp       short M10_L40
M10_L45:
       test      byte ptr [7FF86C4A5358],1
       je        near ptr M10_L76
M10_L46:
       mov       rcx,1861FC004F0
       mov       rbp,[rcx]
       jmp       near ptr M10_L32
M10_L47:
       or        dword ptr [r13+34],20000000
       jmp       near ptr M10_L35
M10_L48:
       call      qword ptr [7FF86C024A68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M10_L49
       call      qword ptr [7FF86C47C9A8]
       mov       rbx,rax
M10_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C69EBF9C30
       call      qword ptr [7FF86C2FF540]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M10_L50:
       call      qword ptr [7FF86C474BA0]
       test      eax,eax
       jne       short M10_L52
       jmp       near ptr M10_L00
M10_L51:
       call      qword ptr [7FF86C474BA0]
       test      eax,eax
       je        near ptr M10_L01
M10_L52:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF86C477A08]
       mov       rbx,rax
       jmp       near ptr M10_L01
M10_L53:
       call      qword ptr [7FF86C477B58]
       int       3
M10_L54:
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB30C78
       call      qword ptr [r11]
       jmp       near ptr M10_L05
M10_L55:
       test      r8,r8
       jne       near ptr M10_L07
M10_L56:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M10_L06
M10_L57:
       cmp       eax,[r13+20]
       jne       near ptr M10_L65
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M10_L58
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB30C80
       call      qword ptr [r11]
       jmp       short M10_L66
M10_L58:
       test      r14d,r14d
       jne       short M10_L59
       test      r8,r8
       je        short M10_L65
M10_L59:
       test      r8,r8
       je        short M10_L60
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M10_L61
M10_L60:
       xor       edx,edx
       xor       r10d,r10d
M10_L61:
       cmp       r14d,r10d
       je        short M10_L62
       xor       edx,edx
       mov       eax,edx
       jmp       short M10_L64
M10_L62:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M10_L63
       mov       rcx,rbp
       call      qword ptr [7FF86BBEFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M10_L64
M10_L63:
       mov       r8,rbp
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M10_L64:
       jmp       short M10_L66
M10_L65:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M10_L18
M10_L66:
       test      eax,eax
       je        short M10_L65
       jmp       near ptr M10_L15
M10_L67:
       xor       ebp,ebp
       jmp       near ptr M10_L16
M10_L68:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF86C47CAC8]
       mov       r13d,1
       jmp       near ptr M10_L23
M10_L69:
       mov       rdx,[rbp+58]
       mov       rcx,r14
       call      qword ptr [7FF86C2F7A38]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FF86C47CAE0]
       test      eax,eax
       jne       short M10_L68
       jmp       near ptr M10_L22
M10_L70:
       mov       rcx,rbp
       call      qword ptr [7FF86C477C30]
       jmp       near ptr M10_L26
M10_L71:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L27
M10_L72:
       call      qword ptr [7FF86C474D38]
       int       3
M10_L73:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF86BBE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L29
M10_L74:
       mov       ecx,2F
       call      qword ptr [7FF86BE0C228]
       int       3
M10_L75:
       mov       ecx,4
       call      qword ptr [7FF86C2FEEB0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L30
M10_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L46
M10_L77:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L33
M10_L78:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C477C60]
       inc       qword ptr [rax+10]
       jmp       near ptr M10_L37
M10_L79:
       xor       r8d,r8d
       mov       [rdi],r8
       jmp       near ptr M10_L39
M10_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
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
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M12_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M12_L00
       test      rbx,rbx
       je        near ptr M12_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M12_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L00:
       test      rbx,rbx
       je        short M12_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L02
M12_L01:
       mov       rax,1C69EBF0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L04:
       call      qword ptr [7FF86C2FFE70]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8AC241D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M13_L01
       cmp       [rax],ecx
       jle       short M13_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M13_L03
M13_L00:
       add       rsp,20
       pop       rbx
       ret
M13_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M13_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M13_L00
M13_L02:
       cmp       [rax+4],edx
       jle       short M13_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M13_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M13_L03
       jmp       short M13_L00
M13_L03:
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
       call      qword ptr [7FF8AC244DC8]
       test      eax,eax
       je        short M14_L00
       add       rsp,20
       pop       rbx
       ret
M14_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FF86BE0E250]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M16_L01
       mov       rcx,rbx
       call      qword ptr [7FF8AC241BD8]
       test      eax,eax
       je        short M16_L00
       add       rsp,20
       pop       rbx
       ret
M16_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M16_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8AC23C210]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M17_L00
       mov       rcx,rbx
       call      00007FF8CB89E040
       test      eax,eax
       jne       short M17_L01
       add       rsp,20
       pop       rbx
       ret
M17_L00:
       xor       ecx,ecx
       call      qword ptr [7FF86C2FEBF8]
       int       3
M17_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86C2FED00]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M18_L00
       add       rsp,28
       ret
M18_L00:
       call      qword ptr [7FF8AC251908]
       int       3
; Total bytes of code 20
```
```assembly
; System.RuntimeFieldHandle.GetName(System.IRuntimeFieldInfo)
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       rcx,[rbx]
       jne       short M19_L01
       mov       rdx,[rbx+38]
M19_L00:
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8AC23B3E8]; Precode of System.RuntimeFieldHandle.GetUtf8Name(System.RuntimeFieldHandleInternal)
       lea       rcx,[rsp+20]
       call      qword ptr [7FF8AC23B9B0]; Precode of System.MdUtf8String.ToString()
       nop
       add       rsp,30
       pop       rbx
       ret
M19_L01:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M19_L00
; Total bytes of code 71
```
```assembly
; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M20_L10
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF86BBE5860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF86BBEDB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M20_L01
M20_L00:
       mov       rcx,1C69EBF1A60
       cmp       rax,rcx
       je        short M20_L02
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBEDB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M20_L00
M20_L01:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       jne       near ptr M20_L11
M20_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       cmp       eax,2
       jne       short M20_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FF86BBE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C474D68]
M20_L03:
       test      rax,rax
       je        short M20_L04
       cmp       dword ptr [rax+8],0
       jne       near ptr M20_L09
M20_L04:
       xor       edx,edx
M20_L05:
       mov       rcx,rdi
       call      qword ptr [7FF86BBE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M20_L06:
       cmp       eax,10
       je        short M20_L08
       mov       rdx,rbp
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r8,rax
       test      r8,r8
       je        short M20_L07
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M20_L07
       mov       rdx,rax
       call      qword ptr [7FF86BBE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M20_L07:
       mov       rax,r8
       jmp       short M20_L03
M20_L08:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      qword ptr [7FF86BBE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C11D0C8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M20_L03
M20_L09:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M20_L12
       mov       rdx,rcx
       jmp       near ptr M20_L05
M20_L10:
       mov       ecx,1A1
       mov       rdx,7FF86BB24000
       call      qword ptr [7FF86BE07798]
       mov       rcx,rax
       call      qword ptr [7FF86C2FEBF8]
       int       3
M20_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C474D50]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BF74450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M20_L12:
       call      qword ptr [7FF86C474D80]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 414
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M21_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M21_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M21_L00:
       call      qword ptr [7FF8AC23F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,1C69EBF9C30
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,1C69EBF0008
       call      qword ptr [7FF86C024A38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M22_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M22_L01
M22_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C36FDF8
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M22_L01:
       mov       rax,1C69EBFBB78
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,1C69EBF0008
       call      qword ptr [7FF86BF7E4F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C2F78E8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF86C2F7B10]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M22_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M22_L03
M22_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C380280
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M22_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF86C2F7B28]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF86C2F7AC8]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAttributeMethodInfo()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A0
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       mov       rbx,rcx
       mov       rsi,2C9B5C81CE0
       mov       rcx,2891EF310F0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L22
M00_L00:
       cmp       [rdi],dil
       lea       rbp,[rdi+40]
       mov       r14,[rbp]
       test      r14,r14
       je        near ptr M00_L23
M00_L01:
       mov       rdi,r14
       mov       rbp,[rdi+20]
       test      rbp,rbp
       je        near ptr M00_L29
       add       rsi,0C
       mov       eax,15051505
       mov       edx,15051505
       mov       r8d,11
M00_L02:
       add       r8d,0FFFFFFFC
       mov       ecx,eax
       rol       ecx,5
       add       eax,ecx
       xor       eax,[rsi]
       mov       ecx,edx
       rol       ecx,5
       add       edx,ecx
       xor       edx,[rsi+4]
       add       rsi,8
       cmp       r8d,2
       jg        short M00_L02
       test      r8d,r8d
       jle       short M00_L03
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rsi]
M00_L03:
       imul      edx,5D588B65
       add       edx,eax
       mov       eax,edx
       not       edx
       test      eax,eax
       cmovl     eax,edx
       mov       rsi,[rbp+8]
       cdq
       idiv      dword ptr [rsi+8]
       mov       r14d,edx
       cmp       r14d,[rsi+8]
       jae       near ptr M00_L66
       mov       r8d,r14d
       mov       r15,[rsi+r8*8+10]
       test      r15,r15
       je        near ptr M00_L29
M00_L04:
       mov       r8,2C9B5C81CE0
       cmp       r15,r8
       jne       near ptr M00_L25
M00_L05:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L66
       mov       edx,r14d
       mov       rsi,[rcx+rdx*8+10]
M00_L06:
       test      rsi,rsi
       je        near ptr M00_L30
M00_L07:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       ecx,ecx
       mov       [rsp+70],rcx
       mov       [rsp+78],rcx
       mov       [rsp+80],ecx
       mov       [rsp+84],edx
       mov       ebp,10
       inc       edi
M00_L08:
       dec       edi
       je        short M00_L11
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       ecx,edx
       and       ecx,1E
       cmp       ecx,edx
       jne       short M00_L10
       cmp       dword ptr [rsp+80],0
       jne       near ptr M00_L31
       mov       [rsp+78],r14
M00_L09:
       mov       ecx,[rsp+80]
       inc       ecx
       mov       [rsp+80],ecx
M00_L10:
       add       rbp,8
       jmp       short M00_L08
M00_L11:
       vmovdqu   xmm0,xmmword ptr [rsp+70]
       vmovdqu   xmmword ptr [rsp+88],xmm0
       mov       rcx,[rsp+80]
       mov       [rsp+98],rcx
       cmp       dword ptr [rsp+98],0
       je        near ptr M00_L35
       cmp       qword ptr [rsp+88],0
       je        near ptr M00_L21
       mov       rcx,[rsp+88]
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L66
       mov       rcx,[rsp+88]
       mov       rsi,[rcx+10]
M00_L12:
       mov       rdi,rsi
       cmp       dword ptr [rsp+98],1
       jne       near ptr M00_L36
M00_L13:
       test      rsi,rsi
       je        near ptr M00_L43
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       rcx,28920C00C88
       mov       rdi,[rcx]
       mov       rcx,28920C00C90
       mov       rbp,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L44
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L44
M00_L14:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L46
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L46
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M00_L46
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M00_L45
M00_L15:
       mov       [rsp+50],r14
       test      r14,r14
       je        near ptr M00_L59
       lea       rcx,[r14+10]
       mov       eax,[r14+8]
M00_L16:
       mov       [rsp+60],rcx
       mov       [rsp+68],eax
       xor       ecx,ecx
       mov       [rsp+58],ecx
       mov       byte ptr [rsp+5C],0
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L60
       mov       rcx,rsi
       call      qword ptr [7FF86BD29CE0]; System.Reflection.RuntimeMethodInfo.get_DeclaringType()
M00_L17:
       test      rax,rax
       je        near ptr M00_L61
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rax],rcx
       jne       near ptr M00_L62
       mov       rcx,rax
       call      qword ptr [7FF86BBEC588]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86C117588]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rdx,rax
M00_L18:
       lea       rcx,[rsp+48]
       call      qword ptr [7FF86BE0E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+48]
       mov       rdx,2C9B5C70658
       call      qword ptr [7FF86BE04E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L63
       mov       rcx,rsi
       call      qword ptr [7FF86BD29CD8]; System.Reflection.RuntimeMethodInfo.get_Name()
M00_L19:
       lea       rcx,[rsp+48]
       mov       rdx,rax
       call      qword ptr [7FF86BE0E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+48]
       mov       rdx,2C9B5C70658
       call      qword ptr [7FF86BE04E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rsp+48]
       mov       rdx,2C9B5C81D48
       call      qword ptr [7FF86BE0E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+48]
       mov       rdx,2C9B5C81D78
       call      qword ptr [7FF86BE04E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,2C9B5C804C0
       call      qword ptr [7FF86BBEC588]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86C117588]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rdx,rax
       lea       rcx,[rsp+48]
       call      qword ptr [7FF86BE0E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+48]
       call      qword ptr [7FF86BE04EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,28936C002E8
       mov       rcx,[rcx]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,7FF86C32F140
       call      qword ptr [7FF86C2F6D60]; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L64
       mov       rbp,[rsp+40]
M00_L20:
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       [rsp+38],rbp
       mov       rcx,[rbx+90]
       lea       r8,[rsp+38]
       mov       rdx,7FF86C395908
       cmp       [rcx],ecx
       call      qword ptr [7FF86C2FD470]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L21:
       mov       rsi,[rsp+90]
       jmp       near ptr M00_L12
M00_L22:
       mov       rcx,2C9B5C81CB8
       call      qword ptr [7FF86BBE7C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L23:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF8CB8421C0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       near ptr M00_L01
M00_L24:
       cmp       r14d,[rsi+8]
       jae       near ptr M00_L66
       mov       ecx,r14d
       mov       r15,[rsi+rcx*8+10]
       test      r15,r15
       je        short M00_L29
       jmp       near ptr M00_L04
M00_L25:
       cmp       dword ptr [r15+8],11
       je        short M00_L27
M00_L26:
       inc       r14d
       cmp       [rsi+8],r14d
       jg        short M00_L24
       jmp       short M00_L28
M00_L27:
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       mov       rdx,2C9B5C81CEC
       call      qword ptr [7FF86BBEFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L26
       jmp       near ptr M00_L05
M00_L28:
       sub       r14d,[rsi+8]
       jmp       short M00_L24
M00_L29:
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L30:
       mov       rcx,rdi
       mov       rdx,2C9B5C81CE0
       mov       r8d,1
       xor       r9d,r9d
       call      qword ptr [7FF86BBED2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L07
M00_L31:
       cmp       dword ptr [rsp+80],1
       jne       short M00_L33
       cmp       dword ptr [rsp+84],2
       jge       short M00_L32
       mov       dword ptr [rsp+84],4
M00_L32:
       movsxd    rdx,dword ptr [rsp+84]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+70],rax
       mov       rcx,[rsp+70]
       mov       r8,[rsp+78]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L34
M00_L33:
       mov       edx,[rsp+84]
       cmp       edx,[rsp+80]
       jne       short M00_L34
       mov       r15d,[rsp+84]
       add       r15d,r15d
       lea       rdx,[rsp+70]
       mov       r8d,r15d
       mov       rcx,7FF86BD323B8
       call      qword ptr [7FF86BBED500]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+84],r15d
M00_L34:
       movsxd    rdx,dword ptr [rsp+80]
       mov       rcx,[rsp+70]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L09
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L13
M00_L36:
       mov       esi,1
       jmp       short M00_L40
M00_L37:
       cmp       qword ptr [rsp+88],0
       jne       short M00_L38
       mov       rcx,[rsp+90]
       jmp       short M00_L39
M00_L38:
       mov       rcx,[rsp+88]
       cmp       esi,[rcx+8]
       jae       near ptr M00_L66
       mov       rcx,[rsp+88]
       mov       rcx,[rcx+rsi*8+10]
M00_L39:
       mov       rdx,rdi
       call      qword ptr [7FF86C3DD308]
       test      eax,eax
       je        short M00_L41
       inc       esi
M00_L40:
       cmp       esi,[rsp+98]
       jl        short M00_L37
       jmp       short M00_L42
M00_L41:
       mov       rcx,rdi
       call      qword ptr [7FF86C3DC018]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L42:
       lea       rcx,[rsp+88]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FF86BBED578]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rcx,rax
       mov       edx,[rsp+98]
       call      qword ptr [7FF86C3DD320]
       mov       rdx,rax
       mov       rcx,offset MT_System.Reflection.MethodInfo
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       jmp       near ptr M00_L13
M00_L43:
       call      qword ptr [7FF86C19F1B0]
       mov       ecx,2D4F
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C3DE2C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C3D4D68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       mov       ecx,3
       call      qword ptr [7FF86C3D4708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L14
M00_L45:
       mov       rcx,r14
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FF86C3DCED0]
       jmp       near ptr M00_L15
M00_L46:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L57
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L56
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF86BBE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF86BB2B1A4],0
       je        short M00_L47
       call      qword ptr [7FF86C3DCEE8]
       mov       r15d,eax
       jmp       short M00_L49
M00_L47:
       mov       ecx,0B
       call      qword ptr [7FF86C3DCF00]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FF86C3DCF00]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M00_L48
       call      qword ptr [7FF86C3DCF18]
       mov       r15d,eax
       jmp       short M00_L49
M00_L48:
       sar       r15d,10
M00_L49:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF86BBE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF86BB2B198]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M00_L52
M00_L50:
       cmp       r15d,[r14+8]
       jae       near ptr M00_L66
       mov       ecx,r15d
       mov       rcx,[r14+rcx*8+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3DE340]
       test      rax,rax
       jne       short M00_L53
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M00_L51
       xor       r15d,r15d
M00_L51:
       inc       r13d
M00_L52:
       cmp       [r14+8],r13d
       jg        short M00_L50
       jmp       short M00_L54
M00_L53:
       mov       r14,rax
       jmp       short M00_L55
M00_L54:
       xor       r14d,r14d
M00_L55:
       test      r14,r14
       je        short M00_L56
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L15
       mov       rcx,r14
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FF86C3DCED0]
       jmp       near ptr M00_L15
M00_L56:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L15
       jmp       short M00_L58
M00_L57:
       mov       ecx,100
       mov       rdx,2C9B5C76F28
       call      qword ptr [7FF86BE0DAD0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L56
M00_L58:
       mov       rcx,r14
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rbp
       call      qword ptr [7FF86C3DCED0]
       mov       rcx,rdi
       call      qword ptr [7FF86C02D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rbp
       mov       edx,r15d
       mov       r8d,100
       call      qword ptr [7FF86C3DCF30]
       jmp       near ptr M00_L15
M00_L59:
       xor       ecx,ecx
       xor       eax,eax
       jmp       near ptr M00_L16
M00_L60:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       jmp       near ptr M00_L17
M00_L61:
       xor       edx,edx
       jmp       near ptr M00_L18
M00_L62:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L18
M00_L63:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M00_L19
M00_L64:
       mov       rdx,rsi
       mov       rcx,7FF86C37E9E0
       xor       r8d,r8d
       call      qword ptr [7FF86C1168C8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L65
       mov       ecx,5
       call      qword ptr [7FF86C2F6E20]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,28936C002E8
       mov       rcx,[rcx]
       mov       r8,rdi
       mov       r9,rbp
       mov       rdx,7FF86C394570
       call      qword ptr [7FF86C2F6DD8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L20
M00_L65:
       xor       ebp,ebp
       jmp       near ptr M00_L20
M00_L66:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2508
```
```assembly
; System.Reflection.RuntimeMethodInfo.get_DeclaringType()
       mov       rax,[rcx+8]
       cmp       byte ptr [rax+9C],0
       jne       short M01_L00
       mov       rax,[rcx+38]
       ret
M01_L00:
       xor       eax,eax
       ret
; Total bytes of code 21
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M02_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L00
       ret
M02_L00:
       jmp       qword ptr [7FF86BBE7C48]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetFullName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+20]
       test      rax,rax
       je        short M03_L00
       add       rsp,20
       pop       rbx
       ret
M03_L00:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF86BD54AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M03_L01
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86BD54B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M04_L01
       test      rdx,rdx
       je        short M04_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M04_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M04_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF86BD57198]
       int       3
M04_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C3DCCD8]
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M05_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M05_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L00:
       call      qword ptr [7FF86BD57198]
       int       3
M05_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C2F47B0]
; Total bytes of code 94
```
```assembly
; System.Reflection.RuntimeMethodInfo.get_Name()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L01:
       mov       rcx,rbx
       call      qword ptr [7FF86C3DE370]; System.RuntimeMethodHandle.GetName(System.IRuntimeMethodInfo)
       mov       rsi,rax
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M06_L00
; Total bytes of code 54
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M07_L01
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rdx,rdx
       je        short M07_L00
       mov       rcx,28920C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF86BEAFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M07_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       call      qword ptr [7FF86BD57198]
       int       3
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.TryGetValueCore(key, out value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rdx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M08_L48
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M08_L48
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M08_L50
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M08_L52
M08_L00:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M08_L51
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M08_L52
M08_L01:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M08_L09
M08_L02:
       mov       rsi,[rbp+10]
       test      rbx,rbx
       jne       near ptr M08_L10
       xor       ebp,ebp
       xor       r14d,r14d
M08_L03:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M08_L11
M08_L04:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M08_L53
       mov       r15,[rsi+28]
       mov       rcx,[r15+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M08_L54
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86C1964D8]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M08_L05:
       mov       [rsp+4C],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M08_L80
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M08_L18
M08_L06:
       test      r13,r13
       je        near ptr M08_L67
       cmp       eax,[r13+20]
       jne       near ptr M08_L56
       mov       r8,[r13+8]
       test      r14d,r14d
       je        near ptr M08_L55
M08_L07:
       test      r8,r8
       jne       short M08_L12
       xor       edx,edx
       xor       r10d,r10d
M08_L08:
       cmp       r14d,r10d
       jne       near ptr M08_L17
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M08_L13
       mov       rcx,rbp
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M08_L14
M08_L09:
       mov       rcx,rsi
       mov       rdx,7FF86C36F198
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L10:
       lea       rbp,[rbx+0C]
       mov       r14d,[rbx+8]
       jmp       near ptr M08_L03
M08_L11:
       mov       rdx,7FF86C36F2D8
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M08_L04
M08_L12:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M08_L08
M08_L13:
       mov       rcx,rbp
       call      qword ptr [7FF86BBEFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M08_L14:
       test      eax,eax
       je        near ptr M08_L56
M08_L15:
       mov       rbp,[r13+10]
M08_L16:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M08_L19
       call      qword ptr [7FF86C116DD8]; System.DateTime.get_UtcNow()
       mov       r14,rax
       jmp       short M08_L20
M08_L17:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M08_L14
M08_L18:
       test      r13,r13
       jne       near ptr M08_L57
       jmp       near ptr M08_L67
M08_L19:
       lea       rdx,[rsp+38]
       mov       r11,7FF86BB30CB8
       call      qword ptr [r11]
       mov       r14,4000000000000000
       or        r14,[rsp+40]
M08_L20:
       test      rbp,rbp
       je        near ptr M08_L42
       cmp       byte ptr [rbp+43],0
       jne       near ptr M08_L41
       cmp       qword ptr [rbp+38],0
       jge       short M08_L21
       cmp       qword ptr [rbp+50],0
       je        short M08_L24
M08_L21:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       cmp       [rbp+38],rdx
       jbe       near ptr M08_L68
       cmp       qword ptr [rbp+50],0
       jg        near ptr M08_L69
M08_L22:
       xor       r13d,r13d
M08_L23:
       test      r13d,r13d
       jne       near ptr M08_L41
M08_L24:
       cmp       qword ptr [rbp+10],0
       je        short M08_L25
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3DD680]
       test      eax,eax
       jne       near ptr M08_L41
M08_L25:
       mov       [rbp+58],r14
       mov       r15,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M08_L70
M08_L26:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M08_L36
       mov       [rsi+48],r14
       test      byte ptr [7FF86C4ED5D0],1
       je        near ptr M08_L71
M08_L27:
       mov       rcx,28936C004E8
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M08_L28
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,28936C004E0
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M08_L72
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF86C3DA400
       mov       [rbp+18],rcx
       mov       rcx,28936C004E8
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L28:
       test      byte ptr [7FF86C4CC8C0],1
       je        near ptr M08_L73
M08_L29:
       mov       rcx,28936C00518
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M08_L74
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M08_L75
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M08_L75
M08_L30:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M08_L31
       call      qword ptr [7FF86BE0FDB0]; System.Threading.Thread.InitializeCurrentThread()
M08_L31:
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        near ptr M08_L45
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
M08_L32:
       test      rbp,rbp
       je        near ptr M08_L47
       test      byte ptr [7FF86C499050],1
       je        near ptr M08_L77
M08_L33:
       mov       rcx,28936C00528
       cmp       rbp,[rcx]
       je        short M08_L35
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M08_L34
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M08_L34:
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L35:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF86C3DE448]
M08_L36:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M08_L78
M08_L37:
       test      r15,r15
       je        near ptr M08_L79
       mov       rcx,[rbx+18]
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M08_L44
       mov       rdx,r15
       test      rdx,rdx
       je        short M08_L38
       mov       rcx,rsi
       cmp       [rdx],rcx
       je        short M08_L38
       mov       rdx,r15
       call      qword ptr [7FF86BBE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M08_L38:
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M08_L39:
       mov       eax,1
M08_L40:
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
M08_L41:
       cmp       byte ptr [rbp+45],2
       je        near ptr M08_L25
       mov       r8,[rsi+10]
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF86C3DD6E0]
M08_L42:
       mov       rdx,[rsi+10]
       mov       rbx,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r14
       call      qword ptr [7FF86C2F7A38]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rbx,rax
       jge       short M08_L43
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF86C3DD6B0]
M08_L43:
       cmp       qword ptr [rsi+20],0
       je        short M08_L44
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3DD6C8]
       inc       qword ptr [rax+18]
M08_L44:
       xor       eax,eax
       mov       [rdi],rax
       jmp       short M08_L40
M08_L45:
       test      byte ptr [7FF86C499050],1
       je        near ptr M08_L76
M08_L46:
       mov       rcx,28936C00528
       mov       rbp,[rcx]
       jmp       near ptr M08_L32
M08_L47:
       or        dword ptr [r13+34],20000000
       jmp       near ptr M08_L35
M08_L48:
       call      qword ptr [7FF86C024A68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M08_L49
       call      qword ptr [7FF86C3DE2C8]
       mov       rbx,rax
M08_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C9B5C79C30
       call      qword ptr [7FF86C3D4D68]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L50:
       call      qword ptr [7FF86C2FCC18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M08_L52
       jmp       near ptr M08_L00
M08_L51:
       call      qword ptr [7FF86C2FCC18]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M08_L01
M08_L52:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF86C3DD260]
       mov       rbx,rax
       jmp       near ptr M08_L01
M08_L53:
       call      qword ptr [7FF86C3DD5C0]
       int       3
M08_L54:
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB30CA8
       call      qword ptr [r11]
       jmp       near ptr M08_L05
M08_L55:
       test      r8,r8
       jne       near ptr M08_L07
M08_L56:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M08_L06
M08_L57:
       cmp       eax,[r13+20]
       jne       near ptr M08_L65
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M08_L58
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB30CB0
       call      qword ptr [r11]
       jmp       short M08_L66
M08_L58:
       test      r14d,r14d
       jne       short M08_L59
       test      r8,r8
       je        short M08_L65
M08_L59:
       test      r8,r8
       je        short M08_L60
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M08_L61
M08_L60:
       xor       edx,edx
       xor       r10d,r10d
M08_L61:
       cmp       r14d,r10d
       je        short M08_L62
       xor       edx,edx
       mov       eax,edx
       jmp       short M08_L64
M08_L62:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M08_L63
       mov       rcx,rbp
       call      qword ptr [7FF86BBEFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M08_L64
M08_L63:
       mov       r8,rbp
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M08_L64:
       jmp       short M08_L66
M08_L65:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M08_L18
M08_L66:
       test      eax,eax
       je        short M08_L65
       jmp       near ptr M08_L15
M08_L67:
       xor       ebp,ebp
       jmp       near ptr M08_L16
M08_L68:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF86C3DE418]
       mov       r13d,1
       jmp       near ptr M08_L23
M08_L69:
       mov       rdx,[rbp+58]
       mov       rcx,r14
       call      qword ptr [7FF86C2F7A38]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FF86C3DE430]
       test      eax,eax
       jne       short M08_L68
       jmp       near ptr M08_L22
M08_L70:
       mov       rcx,rbp
       call      qword ptr [7FF86C3DD698]
       jmp       near ptr M08_L26
M08_L71:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L27
M08_L72:
       call      qword ptr [7FF86C3D6568]
       int       3
M08_L73:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF86BBE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L29
M08_L74:
       mov       ecx,2F
       call      qword ptr [7FF86BE0C228]
       int       3
M08_L75:
       mov       ecx,4
       call      qword ptr [7FF86C3D4708]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L30
M08_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L46
M08_L77:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L33
M08_L78:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3DD6C8]
       inc       qword ptr [rax+10]
       jmp       near ptr M08_L37
M08_L79:
       xor       r8d,r8d
       mov       [rdi],r8
       jmp       near ptr M08_L39
M08_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
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
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M10_L08
M10_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M10_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M10_L09
M10_L01:
       test      rdi,rdi
       jne       near ptr M10_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M10_L10
M10_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M10_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD21B50
       mov       [rbp-78],rax
       lea       rax,[M10_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M10_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M10_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M10_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M10_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M10_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M10_L11
M10_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M10_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C3DE460]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M10_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C3D5E90]
       jmp       near ptr M10_L00
M10_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M10_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M10_L02
M10_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M11_L03
       cmp       rcx,rdx
       je        short M11_L02
       cmp       r8,20
       jb        near ptr M11_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M11_L01
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M11_L12
M11_L00:
       add       rax,20
       cmp       r8,rax
       jbe       short M11_L01
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M11_L12
       jmp       short M11_L00
M11_L01:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M11_L12
M11_L02:
       mov       eax,1
       vzeroupper
       ret
M11_L03:
       cmp       r8,4
       jae       short M11_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M11_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M11_L04:
       test      r8b,1
       je        short M11_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M11_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M11_L07
M11_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M11_L07:
       vzeroupper
       ret
M11_L08:
       cmp       r8,10
       jb        short M11_L11
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M11_L10
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M11_L12
M11_L09:
       add       rax,10
       cmp       r8,rax
       jbe       short M11_L10
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M11_L12
       jmp       short M11_L09
M11_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M11_L12
       jmp       near ptr M11_L02
M11_L11:
       lea       rax,[r8-8]
       mov       r8,[rcx]
       sub       r8,[rdx]
       mov       rcx,[rcx+rax]
       sub       rcx,[rdx+rax]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       near ptr M11_L07
M11_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 343
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,6BF86C091913
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M12_L07
       mov       r15d,[rbx+8]
       test      r15d,r15d
       je        near ptr M12_L07
       cmp       r14d,1
       je        near ptr M12_L08
M12_L00:
       mov       r8,28920C00220
       mov       r13,[r8]
       lea       r8,[rbx+0C]
       mov       [rbp+38],r8
       mov       r12,[rbp+38]
       lea       r8,[rbp+28]
       lea       r9,[rbp+20]
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FF86BBEFB10]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r12
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    rax,r9d
       add       rax,[rbp+28]
       cmp       rax,7FFFFFFF
       ja        near ptr M12_L10
       mov       [rbp+34],eax
       cmp       r9d,r15d
       jne       near ptr M12_L09
M12_L01:
       xor       edx,edx
       mov       [rbp+38],rdx
       mov       eax,[rbp+34]
       cmp       eax,400
       ja        near ptr M12_L11
       mov       edx,eax
       mov       r8,rdx
       test      r8,r8
       je        short M12_L03
       mov       rcx,r8
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M12_L02
       xor       ecx,ecx
M12_L02:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M12_L02
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M12_L03:
       mov       r15d,eax
M12_L04:
       mov       [rbp+10],r8
       mov       [rbp+18],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+10]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF86BBED338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
M12_L05:
       lea       rdx,[rbp+40]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF86BBED590]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+40]
       mov       r8,6BF86C091913
       cmp       [rbp+8],r8
       je        short M12_L06
       call      CORINFO_HELP_FAIL_FAST
M12_L06:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L07:
       xor       r8d,r8d
       mov       [rbp+10],r8
       mov       [rbp+18],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+10]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2C9B5C70008
       call      qword ptr [7FF86BBED338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
       jmp       short M12_L05
M12_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M12_L00
       cmp       word ptr [rbx+0C],2A
       je        near ptr M12_L00
       jmp       short M12_L07
M12_L09:
       mov       rcx,r13
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FF86C3DD470]
       add       eax,[rbp+34]
       mov       r15d,eax
       test      r15d,r15d
       mov       [rbp+34],r15d
       jge       near ptr M12_L01
M12_L10:
       call      qword ptr [7FF86C19E928]
       int       3
M12_L11:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
       jmp       near ptr M12_L04
; Total bytes of code 521
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M13_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M13_L02
       cmp       rdx,[r8]
       jne       short M13_L03
M13_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF8CB8940D0
M13_L01:
       call      qword ptr [7FF86C2FEEC8]
       int       3
M13_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M13_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M13_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF86BBED908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M14_L05
       mov       rbp,[rdi]
       test      rbp,rbp
       je        near ptr M14_L06
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M14_L02
       mov       rcx,7FF86C3E4018
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M14_L04
M14_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[rbp+10]
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M14_L10
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M14_L09
M14_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M14_L02:
       mov       rcx,7FF86C3E401C
       call      CORINFO_HELP_COUNTPROFILE32
M14_L03:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M14_L04:
       mov       rcx,rsi
       mov       rdx,7FF86C474088
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M14_L00
M14_L05:
       mov       rcx,7FF86C3E4010
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86C196760]
       int       3
M14_L06:
       mov       rcx,7FF86C3E4014
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M14_L07
       jmp       short M14_L08
M14_L07:
       mov       rcx,rsi
       mov       rdx,7FF86C474088
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M14_L08:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M14_L03
M14_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M14_L01
M14_L10:
       call      qword ptr [7FF86C19EB68]
       jmp       near ptr M14_L01
; Total bytes of code 334
```
```assembly
; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rdx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       ecx,[rbx+10]
       test      ecx,ecx
       je        near ptr M15_L05
       cmp       ecx,1
       jne       short M15_L02
       mov       rcx,7FF86C49145C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],40
       jle       short M15_L01
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M15_L01
M15_L00:
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       r8,[rbx+8]
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86BBE57B8]; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L01:
       mov       rcx,rsi
       mov       rdx,7FF86C473398
       call      qword ptr [7FF86BBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M15_L00
M15_L02:
       mov       rcx,7FF86C491460
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],38
       jle       short M15_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M15_L04
M15_L03:
       mov       r8d,[rbx+10]
       mov       rdx,rbx
       call      qword ptr [7FF86BBED500]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       eax,[rbx+10]
       mov       [rbx+14],eax
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L04:
       mov       rcx,rsi
       mov       rdx,7FF86C473378
       call      qword ptr [7FF86BBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M15_L03
M15_L05:
       mov       rcx,7FF86C491458
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+30]
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],48
       jle       short M15_L08
       mov       rcx,[rcx+48]
       test      rcx,rcx
       je        short M15_L08
M15_L06:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M15_L09
M15_L07:
       mov       rcx,rdx
       call      qword ptr [7FF86BBE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L08:
       mov       rcx,rsi
       mov       rdx,7FF86C47E498
       call      qword ptr [7FF86BBEC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M15_L06
M15_L09:
       mov       rdx,7FF86C47E4B8
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M15_L07
; Total bytes of code 339
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M16_L00
       cmp       [rdx],rcx
       jne       short M16_L01
M16_L00:
       mov       rax,rdx
       ret
M16_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
M16_L02:
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       test      rax,rax
       je        short M16_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M16_L00
       jmp       short M16_L02
M16_L03:
       xor       edx,edx
       jmp       short M16_L00
; Total bytes of code 88
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M17_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M17_L00
       test      rbx,rbx
       je        near ptr M17_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M17_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M17_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF86BBE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L00:
       test      rbx,rbx
       je        short M17_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M17_L02
M17_L01:
       mov       rax,2C9B5C70008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M17_L04:
       call      qword ptr [7FF86C3D56B0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8AC241D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M18_L01
       cmp       [rax],ecx
       jle       short M18_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M18_L03
M18_L00:
       add       rsp,20
       pop       rbx
       ret
M18_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M18_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M18_L00
M18_L02:
       cmp       [rax+4],edx
       jle       short M18_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M18_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M18_L03
       jmp       short M18_L00
M18_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
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
       call      qword ptr [7FF8AC244DC8]
       test      eax,eax
       je        short M19_L00
       add       rsp,20
       pop       rbx
       ret
M19_L00:
       mov       rcx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M20_L00
       ret
M20_L00:
       jmp       qword ptr [7FF86BE0E250]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M21_L00
       add       rsp,28
       ret
M21_L00:
       call      qword ptr [7FF8AC251908]
       int       3
; Total bytes of code 20
```
```assembly
; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M22_L10
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF86BBE5860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF86BBEDB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M22_L01
M22_L00:
       mov       rcx,2C9B5C71A60
       cmp       rax,rcx
       je        short M22_L02
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBEDB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M22_L00
M22_L01:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       jne       near ptr M22_L11
M22_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       cmp       eax,2
       jne       short M22_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FF86BBE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C3D6598]
M22_L03:
       test      rax,rax
       je        short M22_L04
       cmp       dword ptr [rax+8],0
       jne       near ptr M22_L09
M22_L04:
       xor       edx,edx
M22_L05:
       mov       rcx,rdi
       call      qword ptr [7FF86BBE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M22_L06:
       cmp       eax,10
       je        short M22_L08
       mov       rdx,rbp
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r8,rax
       test      r8,r8
       je        short M22_L07
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M22_L07
       mov       rdx,rax
       call      qword ptr [7FF86BBE58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M22_L07:
       mov       rax,r8
       jmp       short M22_L03
M22_L08:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      qword ptr [7FF86BBE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C11D0C8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M22_L03
M22_L09:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M22_L12
       mov       rdx,rcx
       jmp       near ptr M22_L05
M22_L10:
       mov       ecx,1A1
       mov       rdx,7FF86BB24000
       call      qword ptr [7FF86BE07798]
       mov       rcx,rax
       call      qword ptr [7FF86C3D4450]
       int       3
M22_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C3D6580]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BF74450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M22_L12:
       call      qword ptr [7FF86C3D65B0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 414
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M23_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M23_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M23_L00:
       call      qword ptr [7FF8AC23F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,2C9B5C79C30
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,2C9B5C70008
       call      qword ptr [7FF86C024A38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M24_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M24_L01
M24_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C380C38
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M24_L01:
       mov       rax,2C9B5C7BB78
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,2C9B5C70008
       call      qword ptr [7FF86BF7E4F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C2F78E8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF86C2FD260]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M24_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M24_L03
M24_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3810B0
       call      qword ptr [7FF86BE07B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M24_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF86C2FD278]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF86C2FD218]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAttributePropertyInfo()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0A8
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       mov       [rsp+0A0],rax
       mov       rbx,rcx
       mov       rsi,29E899F1CE0
       mov       rcx,25DF2DE10F0
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M00_L00
       mov       rcx,29E899F1CB8
       call      qword ptr [7FF86BBF7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
       jmp       short M00_L01
M00_L00:
       mov       rbp,rdi
M00_L01:
       cmp       [rbp],bpl
       lea       rdi,[rbp+68]
       mov       r14,[rdi]
       test      r14,r14
       je        near ptr M00_L28
M00_L02:
       mov       rdi,r14
       mov       rbp,[rdi+20]
       test      rbp,rbp
       je        near ptr M00_L35
       add       rsi,0C
       mov       eax,15051505
       mov       edx,15051505
       mov       r8d,0C
M00_L03:
       add       r8d,0FFFFFFFC
       mov       ecx,eax
       rol       ecx,5
       add       eax,ecx
       xor       eax,[rsi]
       mov       ecx,edx
       rol       ecx,5
       add       edx,ecx
       xor       edx,[rsi+4]
       add       rsi,8
       cmp       r8d,2
       jg        short M00_L03
       test      r8d,r8d
       jg        near ptr M00_L29
M00_L04:
       imul      edx,5D588B65
       add       edx,eax
       mov       eax,edx
       not       edx
       test      eax,eax
       cmovl     eax,edx
       mov       rsi,[rbp+8]
       cdq
       idiv      dword ptr [rsi+8]
       mov       r14d,edx
       cmp       r14d,[rsi+8]
       jae       near ptr M00_L70
       mov       r8d,r14d
       mov       r15,[rsi+r8*8+10]
       test      r15,r15
       je        near ptr M00_L35
M00_L05:
       mov       r8,29E899F1CE0
       cmp       r15,r8
       jne       near ptr M00_L31
M00_L06:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M00_L70
       mov       edx,r14d
       mov       rsi,[rcx+rdx*8+10]
M00_L07:
       test      rsi,rsi
       je        near ptr M00_L36
M00_L08:
       mov       edx,[rsi+8]
       xor       ecx,ecx
       mov       [rsp+90],rcx
       mov       [rsp+98],rcx
       mov       [rsp+0A0],ecx
       mov       [rsp+0A4],edx
       xor       edi,edi
       cmp       dword ptr [rsi+8],0
       jle       short M00_L12
M00_L09:
       mov       rbp,[rsi+rdi*8+10]
       mov       edx,[rbp+58]
       mov       ecx,edx
       and       ecx,1A
       cmp       ecx,edx
       jne       short M00_L11
       cmp       dword ptr [rsp+0A0],0
       jne       near ptr M00_L37
       mov       [rsp+98],rbp
M00_L10:
       mov       ecx,[rsp+0A0]
       inc       ecx
       mov       [rsp+0A0],ecx
M00_L11:
       inc       edi
       cmp       [rsi+8],edi
       jg        short M00_L09
M00_L12:
       mov       rcx,[rsp+90]
       mov       rax,[rsp+98]
       mov       edx,[rsp+0A0]
       test      edx,edx
       je        near ptr M00_L41
       test      rcx,rcx
       je        near ptr M00_L19
       cmp       dword ptr [rcx+8],0
       jbe       near ptr M00_L70
       mov       rcx,[rcx+10]
M00_L13:
       cmp       edx,1
       jne       near ptr M00_L42
       mov       rsi,rcx
M00_L14:
       test      rsi,rsi
       je        near ptr M00_L43
       xor       ecx,ecx
       mov       [rsp+68],rcx
       mov       rcx,25DF4C00C88
       mov       rdi,[rcx]
       mov       rcx,25DF4C00C90
       mov       rbp,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L44
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L44
M00_L15:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L46
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L46
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M00_L46
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M00_L45
M00_L16:
       mov       [rsp+70],r14
       test      r14,r14
       je        near ptr M00_L60
       lea       rcx,[r14+10]
       mov       eax,[r14+8]
M00_L17:
       mov       [rsp+80],rcx
       mov       [rsp+88],eax
       xor       ecx,ecx
       mov       [rsp+78],ecx
       mov       byte ptr [rsp+7C],0
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L61
       mov       rcx,[rsi+30]
M00_L18:
       test      rcx,rcx
       je        near ptr M00_L62
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L63
       cmp       qword ptr [rcx+10],0
       je        short M00_L20
       mov       rax,[rcx+10]
       mov       rdi,[rax]
       test      rdi,rdi
       je        short M00_L20
       mov       rbp,rdi
       jmp       short M00_L21
M00_L19:
       mov       rcx,rax
       jmp       near ptr M00_L13
M00_L20:
       call      qword ptr [7FF86BBF7C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
M00_L21:
       mov       rdi,[rbp+20]
       test      rdi,rdi
       jne       short M00_L22
       mov       rcx,[rbp+8]
       call      qword ptr [7FF86BD64AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        near ptr M00_L27
       lea       rdx,[rbp+20]
       mov       rcx,rbp
       mov       r8d,3
       call      qword ptr [7FF86BD64B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdi,rax
M00_L22:
       cmp       byte ptr [rsp+7C],0
       jne       near ptr M00_L65
       test      rdi,rdi
       je        near ptr M00_L65
       mov       edx,[rsp+78]
       cmp       edx,[rsp+88]
       ja        near ptr M00_L64
       mov       rcx,[rsp+80]
       mov       eax,edx
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+88]
       sub       eax,edx
       mov       [rsp+38],rcx
       mov       [rsp+40],eax
       lea       rdx,[rsp+38]
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3EE298]; System.String.TryCopyTo(System.Span`1<Char>)
       test      eax,eax
       je        near ptr M00_L65
       mov       eax,[rsp+78]
       add       eax,[rdi+8]
       mov       [rsp+78],eax
M00_L23:
       lea       rcx,[rsp+80]
       lea       rdx,[rsp+50]
       mov       r8d,[rsp+78]
       call      qword ptr [7FF86C03D350]; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32)
       lea       rdx,[rsp+50]
       mov       rcx,29E899E0658
       call      qword ptr [7FF86C3EE298]; System.String.TryCopyTo(System.Span`1<Char>)
       test      eax,eax
       je        near ptr M00_L66
       mov       ecx,[rsp+78]
       inc       ecx
       mov       [rsp+78],ecx
M00_L24:
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L67
       mov       rcx,rsi
       call      qword ptr [7FF86BD4E390]; System.Reflection.RuntimePropertyInfo.get_Name()
M00_L25:
       lea       rcx,[rsp+68]
       mov       rdx,rax
       call      qword ptr [7FF86BE1E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+68]
       mov       rdx,29E899E0658
       call      qword ptr [7FF86BE14E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rsp+68]
       mov       rdx,29E899F1D10
       call      qword ptr [7FF86BE1E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+68]
       mov       rdx,29E899F1D40
       call      qword ptr [7FF86BE14E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       mov       rcx,29E899F04C0
       call      qword ptr [7FF86BBFC588]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86C127588]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rdx,rax
       lea       rcx,[rsp+68]
       call      qword ptr [7FF86BE1E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+68]
       call      qword ptr [7FF86BE14EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,25E0AC002E8
       mov       rcx,[rcx]
       lea       r9,[rsp+60]
       mov       r8,rdi
       mov       rdx,7FF86C33F808
       call      qword ptr [7FF86C306E50]; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L68
       mov       rbp,[rsp+60]
M00_L26:
       xor       ecx,ecx
       mov       [rsp+60],rcx
       mov       [rsp+48],rbp
       mov       rcx,[rbx+90]
       lea       r8,[rsp+48]
       mov       rdx,7FF86C396220
       cmp       [rcx],ecx
       call      qword ptr [7FF86C30D560]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0A8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L27:
       xor       edi,edi
       jmp       near ptr M00_L22
M00_L28:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimePropertyInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF8CB8421C0
       mov       r14,rax
       test      r14,r14
       cmove     r14,r15
       jmp       near ptr M00_L02
M00_L29:
       mov       r8d,edx
       rol       r8d,5
       add       r8d,edx
       mov       edx,r8d
       xor       edx,[rsi]
       jmp       near ptr M00_L04
M00_L30:
       cmp       r14d,[rsi+8]
       jae       near ptr M00_L70
       mov       ecx,r14d
       mov       r15,[rsi+rcx*8+10]
       test      r15,r15
       je        short M00_L35
       jmp       near ptr M00_L05
M00_L31:
       cmp       dword ptr [r15+8],0C
       je        short M00_L33
M00_L32:
       inc       r14d
       cmp       [rsi+8],r14d
       jg        short M00_L30
       jmp       short M00_L34
M00_L33:
       lea       rcx,[r15+0C]
       mov       r8d,[r15+8]
       add       r8d,r8d
       mov       rdx,29E899F1CEC
       call      qword ptr [7FF86BBFFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       test      eax,eax
       je        short M00_L32
       jmp       near ptr M00_L06
M00_L34:
       sub       r14d,[rsi+8]
       jmp       short M00_L30
M00_L35:
       xor       esi,esi
       jmp       near ptr M00_L07
M00_L36:
       mov       rcx,rdi
       mov       rdx,29E899F1CE0
       mov       r8d,1
       mov       r9d,3
       call      qword ptr [7FF86BBFD2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L08
M00_L37:
       cmp       dword ptr [rsp+0A0],1
       jne       short M00_L39
       cmp       dword ptr [rsp+0A4],2
       jge       short M00_L38
       mov       dword ptr [rsp+0A4],4
M00_L38:
       movsxd    rdx,dword ptr [rsp+0A4]
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+90],rax
       mov       rcx,[rsp+90]
       mov       r8,[rsp+98]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L40
M00_L39:
       mov       edx,[rsp+0A4]
       cmp       edx,[rsp+0A0]
       jne       short M00_L40
       mov       r14d,[rsp+0A4]
       add       r14d,r14d
       lea       rdx,[rsp+90]
       mov       r8d,r14d
       mov       rcx,7FF86BD4DCA8
       call      qword ptr [7FF86BBFD500]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+0A4],r14d
M00_L40:
       movsxd    rdx,dword ptr [rsp+0A0]
       mov       rcx,[rsp+90]
       mov       r8,rbp
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L10
M00_L41:
       xor       esi,esi
       jmp       near ptr M00_L14
M00_L42:
       call      qword ptr [7FF86C3E7FD8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       call      qword ptr [7FF86C1AF1B0]
       mov       ecx,2D7F
       mov       rdx,7FF86BED4F20
       call      qword ptr [7FF86BE17798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BED4F20
       call      qword ptr [7FF86BE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BED4F20
       call      qword ptr [7FF86BE17798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBF7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C3EE268]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C3E4D38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L44:
       mov       ecx,3
       call      qword ptr [7FF86C3E46D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L15
M00_L45:
       mov       rcx,r14
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FF86C3ECEB8]
       jmp       near ptr M00_L16
M00_L46:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L58
       cmp       dword ptr [rcx+8],4
       jbe       near ptr M00_L70
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L57
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF86BBF5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF86BB3B1A4],0
       je        short M00_L47
       call      qword ptr [7FF86C3ECED0]
       mov       r15d,eax
       jmp       short M00_L49
M00_L47:
       mov       ecx,0B
       call      qword ptr [7FF86C3ECEE8]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FF86C3ECEE8]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M00_L48
       call      qword ptr [7FF86C3ECF00]
       mov       r15d,eax
       jmp       short M00_L49
M00_L48:
       sar       r15d,10
M00_L49:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF86BBF5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF86BB3B198]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       near ptr M00_L53
M00_L50:
       cmp       r15d,[r14+8]
       jae       near ptr M00_L70
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FF86C12E448]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L51
       cmp       eax,[rcx+8]
       jae       near ptr M00_L70
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       cmp       eax,[rcx+8]
       jae       near ptr M00_L70
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M00_L51:
       mov       rcx,r12
       call      qword ptr [7FF86BBF6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M00_L54
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M00_L52
       xor       r15d,r15d
M00_L52:
       inc       r13d
M00_L53:
       cmp       [r14+8],r13d
       jg        near ptr M00_L50
       jmp       short M00_L55
M00_L54:
       mov       r14,r12
       jmp       short M00_L56
M00_L55:
       xor       r14d,r14d
M00_L56:
       test      r14,r14
       je        short M00_L57
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L16
       mov       rcx,r14
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FF86C3ECEB8]
       jmp       near ptr M00_L16
M00_L57:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L16
       jmp       short M00_L59
M00_L58:
       mov       ecx,100
       mov       rdx,29E899E6F28
       call      qword ptr [7FF86BE1DAD0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L57
M00_L59:
       mov       rcx,r14
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rdi
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rbp
       call      qword ptr [7FF86C3ECEB8]
       mov       rcx,rdi
       call      qword ptr [7FF86C03D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rdi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rbp
       mov       edx,r15d
       mov       r8d,100
       call      qword ptr [7FF86C3ECF18]
       jmp       near ptr M00_L16
M00_L60:
       xor       ecx,ecx
       xor       eax,eax
       jmp       near ptr M00_L17
M00_L61:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L62:
       xor       edi,edi
       jmp       near ptr M00_L22
M00_L63:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M00_L22
M00_L64:
       call      qword ptr [7FF86BD67198]
       int       3
M00_L65:
       lea       rcx,[rsp+68]
       mov       rdx,rdi
       call      qword ptr [7FF86C3ECCD8]
       jmp       near ptr M00_L23
M00_L66:
       lea       rcx,[rsp+68]
       mov       rdx,29E899E0658
       call      qword ptr [7FF86C3047E0]
       jmp       near ptr M00_L24
M00_L67:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M00_L25
M00_L68:
       mov       rdx,rsi
       mov       rcx,7FF86C38F3C0
       xor       r8d,r8d
       call      qword ptr [7FF86C1268C8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L69
       mov       ecx,5
       call      qword ptr [7FF86C306F10]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,25E0AC002E8
       mov       rcx,[rcx]
       mov       r8,rdi
       mov       r9,rbp
       mov       rdx,7FF86C394E88
       call      qword ptr [7FF86C306EC8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L26
M00_L69:
       xor       ebp,ebp
       jmp       near ptr M00_L26
M00_L70:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2709
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD31B50
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M01_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C3EE3A0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C3E5E78]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BBF7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vzeroupper
       cmp       [rcx],cl
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M02_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M02_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L15
M02_L01:
       cmp       ebx,1D
       ja        short M02_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M02_L16
M02_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M02_L03:
       test      r14d,r14d
       jne       near ptr M02_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M02_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M02_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M02_L04:
       test      eax,eax
       jne       near ptr M02_L11
       cmp       rdi,rsi
       jne       near ptr M02_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M02_L05:
       cmp       [rbx],rsi
       jne       near ptr M02_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L21
       mov       rcx,[rsp+28]
M02_L06:
       cmp       ebx,1D
       ja        short M02_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M02_L22
M02_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M02_L08:
       test      ebp,ebp
       jne       near ptr M02_L20
       cmp       [rcx],rsi
       jne       near ptr M02_L24
M02_L09:
       test      rcx,rcx
       je        near ptr M02_L25
       call      00007FF8CB849400
M02_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M02_L27
M02_L11:
       cmp       rdi,rsi
       jne       near ptr M02_L29
       mov       rcx,[rbp+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L28
M02_L12:
       cmp       edi,1B
       je        near ptr M02_L27
M02_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M02_L00
M02_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L01
M02_L16:
       mov       r14d,1
       jmp       near ptr M02_L03
M02_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M02_L03
M02_L18:
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L04
M02_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M02_L05
M02_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M02_L06
M02_L22:
       mov       ebp,1
       jmp       near ptr M02_L08
M02_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M02_L08
M02_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF86C3E4D20]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C3E4D38]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M02_L10
M02_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L12
M02_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M02_L27
       jmp       near ptr M02_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD64B28]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.String.TryCopyTo(System.Span`1<Char>)
       sub       rsp,28
       mov       rax,rcx
       xor       r10d,r10d
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       jg        short M04_L00
       mov       r8d,r8d
       add       r8,r8
       mov       rcx,[rdx]
       lea       rdx,[rax+0C]
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,1
M04_L00:
       mov       eax,r10d
       add       rsp,28
       ret
; Total bytes of code 53
```
```assembly
; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       r8d,eax
       ja        short M05_L00
       mov       rcx,[rcx]
       mov       r10d,r8d
       lea       rcx,[rcx+r10*2]
       sub       eax,r8d
       mov       [rdx],rcx
       mov       [rdx+8],eax
       mov       rax,rdx
       add       rsp,28
       ret
M05_L00:
       call      qword ptr [7FF86BD67198]
       int       3
; Total bytes of code 46
```
```assembly
; System.Reflection.RuntimePropertyInfo.get_Name()
       push      rsi
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rax,[rbx+8]
       test      rax,rax
       je        short M06_L01
M06_L00:
       add       rsp,48
       pop       rbx
       pop       rsi
       ret
M06_L01:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+28],xmm0
       mov       rdx,[rbx+48]
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86C3EE1A8]; System.MdUtf8String..ctor(Void*)
       vmovups   xmm0,[rsp+28]
       vmovups   [rsp+38],xmm0
       lea       rcx,[rsp+38]
       call      qword ptr [7FF86C12E040]; System.MdUtf8String.ToString()
       mov       rsi,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       jmp       short M06_L00
; Total bytes of code 93
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M07_L01
       test      rdx,rdx
       je        short M07_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M07_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M07_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FF86BD67198]
       int       3
M07_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C3ECCD8]
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M08_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M08_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      qword ptr [7FF86BD67198]
       int       3
M08_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C3047E0]
; Total bytes of code 94
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M09_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FF86BBF7C48]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetFullName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+20]
       test      rax,rax
       je        short M10_L00
       add       rsp,20
       pop       rbx
       ret
M10_L00:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF86BD64AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M10_L01
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86BD64B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M11_L01
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rdx,rdx
       je        short M11_L00
       mov       rcx,25DF4C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF86BEBFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M11_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L01:
       call      qword ptr [7FF86BD67198]
       int       3
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.TryGetValueCore(key, out value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rdx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M12_L48
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M12_L48
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M12_L50
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M12_L52
M12_L00:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M12_L51
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M12_L52
M12_L01:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M12_L09
M12_L02:
       mov       rsi,[rbp+10]
       test      rbx,rbx
       jne       near ptr M12_L10
       xor       ebp,ebp
       xor       r14d,r14d
M12_L03:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M12_L11
M12_L04:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M12_L53
       mov       r15,[rsi+28]
       mov       rcx,[r15+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M12_L54
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86C1A64D8]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M12_L05:
       mov       [rsp+4C],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M12_L80
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M12_L18
M12_L06:
       test      r13,r13
       je        near ptr M12_L67
       cmp       eax,[r13+20]
       jne       near ptr M12_L56
       mov       r8,[r13+8]
       test      r14d,r14d
       je        near ptr M12_L55
M12_L07:
       test      r8,r8
       jne       short M12_L12
       xor       edx,edx
       xor       r10d,r10d
M12_L08:
       cmp       r14d,r10d
       jne       near ptr M12_L17
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M12_L13
       mov       rcx,rbp
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M12_L14
M12_L09:
       mov       rcx,rsi
       mov       rdx,7FF86C37F2A8
       call      qword ptr [7FF86BE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M12_L02
M12_L10:
       lea       rbp,[rbx+0C]
       mov       r14d,[rbx+8]
       jmp       near ptr M12_L03
M12_L11:
       mov       rdx,7FF86C37F3E8
       call      qword ptr [7FF86BE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M12_L04
M12_L12:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M12_L08
M12_L13:
       mov       rcx,rbp
       call      qword ptr [7FF86BBFFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M12_L14:
       test      eax,eax
       je        near ptr M12_L56
M12_L15:
       mov       rbp,[r13+10]
M12_L16:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M12_L19
       call      qword ptr [7FF86C126DD8]; System.DateTime.get_UtcNow()
       mov       r14,rax
       jmp       short M12_L20
M12_L17:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M12_L14
M12_L18:
       test      r13,r13
       jne       near ptr M12_L57
       jmp       near ptr M12_L67
M12_L19:
       lea       rdx,[rsp+38]
       mov       r11,7FF86BB40C90
       call      qword ptr [r11]
       mov       r14,4000000000000000
       or        r14,[rsp+40]
M12_L20:
       test      rbp,rbp
       je        near ptr M12_L42
       cmp       byte ptr [rbp+43],0
       jne       near ptr M12_L41
       cmp       qword ptr [rbp+38],0
       jge       short M12_L21
       cmp       qword ptr [rbp+50],0
       je        short M12_L24
M12_L21:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       cmp       [rbp+38],rdx
       jbe       near ptr M12_L68
       cmp       qword ptr [rbp+50],0
       jg        near ptr M12_L69
M12_L22:
       xor       r13d,r13d
M12_L23:
       test      r13d,r13d
       jne       near ptr M12_L41
M12_L24:
       cmp       qword ptr [rbp+10],0
       je        short M12_L25
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3ED578]
       test      eax,eax
       jne       near ptr M12_L41
M12_L25:
       mov       [rbp+58],r14
       mov       r15,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M12_L70
M12_L26:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M12_L36
       mov       [rsi+48],r14
       test      byte ptr [7FF86C4FD4D8],1
       je        near ptr M12_L71
M12_L27:
       mov       rcx,25E0AC004E0
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M12_L28
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,25E0AC004D8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M12_L72
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF86C3EA340
       mov       [rbp+18],rcx
       mov       rcx,25E0AC004E0
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M12_L28:
       test      byte ptr [7FF86C4DC5F8],1
       je        near ptr M12_L73
M12_L29:
       mov       rcx,25E0AC00510
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M12_L74
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M12_L75
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M12_L75
M12_L30:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M12_L31
       call      qword ptr [7FF86BE1FDB0]; System.Threading.Thread.InitializeCurrentThread()
M12_L31:
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        near ptr M12_L45
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
M12_L32:
       test      rbp,rbp
       je        near ptr M12_L47
       test      byte ptr [7FF86C4A9678],1
       je        near ptr M12_L77
M12_L33:
       mov       rcx,25E0AC00520
       cmp       rbp,[rcx]
       je        short M12_L35
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M12_L34
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M12_L34:
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M12_L35:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF86C3EE388]
M12_L36:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M12_L78
M12_L37:
       test      r15,r15
       je        near ptr M12_L79
       mov       rcx,[rbx+18]
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M12_L44
       mov       rdx,r15
       test      rdx,rdx
       je        short M12_L38
       mov       rcx,rsi
       cmp       [rdx],rcx
       je        short M12_L38
       mov       rdx,r15
       call      qword ptr [7FF86BBF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M12_L38:
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M12_L39:
       mov       eax,1
M12_L40:
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
M12_L41:
       cmp       byte ptr [rbp+45],2
       je        near ptr M12_L25
       mov       r8,[rsi+10]
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF86C3ED5D8]
M12_L42:
       mov       rdx,[rsi+10]
       mov       rbx,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r14
       call      qword ptr [7FF86C307B28]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rbx,rax
       jge       short M12_L43
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF86C3ED5A8]
M12_L43:
       cmp       qword ptr [rsi+20],0
       je        short M12_L44
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3ED5C0]
       inc       qword ptr [rax+18]
M12_L44:
       xor       eax,eax
       mov       [rdi],rax
       jmp       short M12_L40
M12_L45:
       test      byte ptr [7FF86C4A9678],1
       je        near ptr M12_L76
M12_L46:
       mov       rcx,25E0AC00520
       mov       rbp,[rcx]
       jmp       near ptr M12_L32
M12_L47:
       or        dword ptr [r13+34],20000000
       jmp       near ptr M12_L35
M12_L48:
       call      qword ptr [7FF86C034A68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M12_L49
       call      qword ptr [7FF86C3EE268]
       mov       rbx,rax
M12_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,29E899E9C30
       call      qword ptr [7FF86C3E4D38]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M12_L50:
       call      qword ptr [7FF86C30CD08]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       jne       short M12_L52
       jmp       near ptr M12_L00
M12_L51:
       call      qword ptr [7FF86C30CD08]; System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
       test      eax,eax
       je        near ptr M12_L01
M12_L52:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF86C3ED260]
       mov       rbx,rax
       jmp       near ptr M12_L01
M12_L53:
       call      qword ptr [7FF86C3ED4B8]
       int       3
M12_L54:
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB40C80
       call      qword ptr [r11]
       jmp       near ptr M12_L05
M12_L55:
       test      r8,r8
       jne       near ptr M12_L07
M12_L56:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M12_L06
M12_L57:
       cmp       eax,[r13+20]
       jne       near ptr M12_L65
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M12_L58
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB40C88
       call      qword ptr [r11]
       jmp       short M12_L66
M12_L58:
       test      r14d,r14d
       jne       short M12_L59
       test      r8,r8
       je        short M12_L65
M12_L59:
       test      r8,r8
       je        short M12_L60
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M12_L61
M12_L60:
       xor       edx,edx
       xor       r10d,r10d
M12_L61:
       cmp       r14d,r10d
       je        short M12_L62
       xor       edx,edx
       mov       eax,edx
       jmp       short M12_L64
M12_L62:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M12_L63
       mov       rcx,rbp
       call      qword ptr [7FF86BBFFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M12_L64
M12_L63:
       mov       r8,rbp
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M12_L64:
       jmp       short M12_L66
M12_L65:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M12_L18
M12_L66:
       test      eax,eax
       je        short M12_L65
       jmp       near ptr M12_L15
M12_L67:
       xor       ebp,ebp
       jmp       near ptr M12_L16
M12_L68:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF86C3EE358]
       mov       r13d,1
       jmp       near ptr M12_L23
M12_L69:
       mov       rdx,[rbp+58]
       mov       rcx,r14
       call      qword ptr [7FF86C307B28]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FF86C3EE370]
       test      eax,eax
       jne       short M12_L68
       jmp       near ptr M12_L22
M12_L70:
       mov       rcx,rbp
       call      qword ptr [7FF86C3ED590]
       jmp       near ptr M12_L26
M12_L71:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M12_L27
M12_L72:
       call      qword ptr [7FF86C3E6520]
       int       3
M12_L73:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF86BBF5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M12_L29
M12_L74:
       mov       ecx,2F
       call      qword ptr [7FF86BE1C228]
       int       3
M12_L75:
       mov       ecx,4
       call      qword ptr [7FF86C3E46D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M12_L30
M12_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M12_L46
M12_L77:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M12_L33
M12_L78:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C3ED5C0]
       inc       qword ptr [rax+10]
       jmp       near ptr M12_L37
M12_L79:
       xor       r8d,r8d
       mov       [rdi],r8
       jmp       near ptr M12_L39
M12_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
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
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M14_L03
       cmp       rcx,rdx
       je        short M14_L02
       cmp       r8,20
       jb        near ptr M14_L08
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M14_L01
       vmovups   ymm0,[rcx]
       vpcmpeqb  ymm0,ymm0,[rdx]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M14_L12
M14_L00:
       add       rax,20
       cmp       r8,rax
       jbe       short M14_L01
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M14_L12
       jmp       short M14_L00
M14_L01:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M14_L12
M14_L02:
       mov       eax,1
       vzeroupper
       ret
M14_L03:
       cmp       r8,4
       jae       short M14_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M14_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M14_L04:
       test      r8b,1
       je        short M14_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M14_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M14_L07
M14_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M14_L07:
       vzeroupper
       ret
M14_L08:
       cmp       r8,10
       jb        short M14_L11
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M14_L10
M14_L09:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M14_L12
       add       rax,10
       cmp       r8,rax
       ja        short M14_L09
M14_L10:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb eax,xmm0
       cmp       eax,0FFFF
       jne       short M14_L12
       jmp       near ptr M14_L02
M14_L11:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M14_L07
M14_L12:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 317
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+10],ymm4
       vmovdqa   xmmword ptr [rbp+30],xmm4
       xor       eax,eax
       mov       [rbp+40],rax
       mov       rax,8631F940A818
       mov       [rbp+8],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M15_L07
       mov       r15d,[rbx+8]
       test      r15d,r15d
       je        near ptr M15_L07
       cmp       r14d,1
       je        near ptr M15_L08
M15_L00:
       mov       r8,25DF4C00220
       mov       r13,[r8]
       lea       r8,[rbx+0C]
       mov       [rbp+38],r8
       mov       r12,[rbp+38]
       lea       r8,[rbp+28]
       lea       r9,[rbp+20]
       mov       rcx,r12
       mov       edx,r15d
       call      qword ptr [7FF86BBFFB10]; System.Text.Unicode.Utf16Utility.GetPointerToFirstInvalidChar(Char*, Int32, Int64 ByRef, Int32 ByRef)
       sub       rax,r12
       mov       r9,rax
       shr       r9,3F
       add       r9,rax
       sar       r9,1
       movsxd    rax,r9d
       add       rax,[rbp+28]
       cmp       rax,7FFFFFFF
       ja        near ptr M15_L10
       mov       [rbp+34],eax
       cmp       r9d,r15d
       jne       near ptr M15_L09
M15_L01:
       xor       edx,edx
       mov       [rbp+38],rdx
       mov       eax,[rbp+34]
       cmp       eax,400
       ja        near ptr M15_L11
       mov       edx,eax
       mov       r8,rdx
       test      r8,r8
       je        short M15_L03
       mov       rcx,r8
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M15_L02
       xor       ecx,ecx
M15_L02:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M15_L02
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M15_L03:
       mov       r15d,eax
M15_L04:
       mov       [rbp+10],r8
       mov       [rbp+18],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+10]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF86BBFD338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
M15_L05:
       lea       rdx,[rbp+40]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF86BBFD590]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+40]
       mov       r8,8631F940A818
       cmp       [rbp+8],r8
       je        short M15_L06
       call      CORINFO_HELP_FAIL_FAST
M15_L06:
       nop
       lea       rsp,[rbp+48]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M15_L07:
       xor       r8d,r8d
       mov       [rbp+10],r8
       mov       [rbp+18],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+10]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,29E899E0008
       call      qword ptr [7FF86BBFD338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+40],rax
       jmp       short M15_L05
M15_L08:
       cmp       word ptr [rbx+0C],2E
       je        near ptr M15_L00
       cmp       word ptr [rbx+0C],2A
       je        near ptr M15_L00
       jmp       short M15_L07
M15_L09:
       mov       rcx,r13
       mov       rdx,r12
       mov       r8d,r15d
       call      qword ptr [7FF86C3ED398]
       add       eax,[rbp+34]
       mov       r15d,eax
       test      r15d,r15d
       mov       [rbp+34],r15d
       jge       near ptr M15_L01
M15_L10:
       call      qword ptr [7FF86C1AE928]
       int       3
M15_L11:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       r15d,[rax+8]
       jmp       near ptr M15_L04
; Total bytes of code 521
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M16_L01
       lea       rax,[rcx+rdx*8+10]
       mov       rdx,[rcx]
       mov       rdx,[rdx+30]
       test      r8,r8
       je        short M16_L02
       cmp       rdx,[r8]
       jne       short M16_L03
M16_L00:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FF8CB8940D0
M16_L01:
       call      qword ptr [7FF86C30EE98]
       int       3
M16_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
M16_L03:
       mov       r10,offset MT_System.Object[]
       cmp       [rcx],r10
       je        short M16_L00
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FF86BBFD908]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
; Total bytes of code 94
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        near ptr M17_L05
       mov       rbp,[rdi]
       test      rbp,rbp
       je        near ptr M17_L06
       mov       r14d,[rbp+8]
       cmp       r14d,ebx
       je        short M17_L02
       mov       rcx,7FF86C3F47A8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M17_L04
M17_L00:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       lea       rcx,[rsi+10]
       lea       rdx,[rbp+10]
       cmp       ebx,r14d
       cmovg     ebx,r14d
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M17_L10
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M17_L09
M17_L01:
       mov       rcx,rdi
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M17_L02:
       mov       rcx,7FF86C3F47AC
       call      CORINFO_HELP_COUNTPROFILE32
M17_L03:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M17_L04:
       mov       rcx,rsi
       mov       rdx,7FF86C484058
       call      qword ptr [7FF86BE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M17_L00
M17_L05:
       mov       rcx,7FF86C3F47A0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FF86C1A6760]
       int       3
M17_L06:
       mov       rcx,7FF86C3F47A4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M17_L07
       jmp       short M17_L08
M17_L07:
       mov       rcx,rsi
       mov       rdx,7FF86C484058
       call      qword ptr [7FF86BE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M17_L08:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M17_L03
M17_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M17_L01
M17_L10:
       call      qword ptr [7FF86C1AEB68]
       jmp       near ptr M17_L01
; Total bytes of code 334
```
```assembly
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M18_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M18_L00
       test      rbx,rbx
       je        near ptr M18_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M18_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M18_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M18_L00:
       test      rbx,rbx
       je        short M18_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M18_L02
M18_L01:
       mov       rax,29E899E0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M18_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M18_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M18_L04:
       call      qword ptr [7FF86C3E5698]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8AC241D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M19_L01
       cmp       [rax],ecx
       jle       short M19_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M19_L03
M19_L00:
       add       rsp,20
       pop       rbx
       ret
M19_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M19_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M19_L00
M19_L02:
       cmp       [rax+4],edx
       jle       short M19_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M19_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M19_L03
       jmp       short M19_L00
M19_L03:
       mov       ecx,ebx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
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
       call      qword ptr [7FF8AC244DC8]
       test      eax,eax
       je        short M20_L00
       add       rsp,20
       pop       rbx
       ret
M20_L00:
       mov       rcx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M21_L00
       ret
M21_L00:
       jmp       qword ptr [7FF86BE1E250]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M22_L01
       mov       rcx,rbx
       call      qword ptr [7FF8AC241BD8]
       test      eax,eax
       je        short M22_L00
       add       rsp,20
       pop       rbx
       ret
M22_L00:
       mov       rcx,rbx
       lea       rax,[Interop.CallStringMethod[[System.__Canon, System.Private.CoreLib],[System.Globalization.CalendarId, System.Private.CoreLib],[System.Globalization.CalendarDataType, System.Private.CoreLib]](System.Buffers.SpanFunc`5<Char,System.__Canon,System.Globalization.CalendarId,System.Globalization.CalendarDataType,ResultCode>, System.__Canon, System.Globalization.CalendarId, System.Globalization.CalendarDataType, System.String ByRef)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M22_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8AC23C210]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M23_L00
       mov       rcx,rbx
       call      00007FF8CB89E040
       test      eax,eax
       jne       short M23_L01
       add       rsp,20
       pop       rbx
       ret
M23_L00:
       xor       ecx,ecx
       call      qword ptr [7FF86C3E4420]
       int       3
M23_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86C3E4528]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M24_L00
       add       rsp,28
       ret
M24_L00:
       call      qword ptr [7FF8AC251908]
       int       3
; Total bytes of code 20
```
```assembly
; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M25_L10
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF86BBF5860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF86BBFDB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M25_L01
M25_L00:
       mov       rcx,29E899E1A60
       cmp       rax,rcx
       je        short M25_L02
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBFDB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M25_L00
M25_L01:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       jne       near ptr M25_L11
M25_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       cmp       eax,2
       jne       short M25_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FF86BBF6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C3E6550]
M25_L03:
       test      rax,rax
       je        short M25_L04
       cmp       dword ptr [rax+8],0
       jne       near ptr M25_L09
M25_L04:
       xor       edx,edx
M25_L05:
       mov       rcx,rdi
       call      qword ptr [7FF86BBF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M25_L06:
       cmp       eax,10
       je        short M25_L08
       mov       rdx,rbp
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r8,rax
       test      r8,r8
       je        short M25_L07
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M25_L07
       mov       rdx,rax
       call      qword ptr [7FF86BBF58D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M25_L07:
       mov       rax,r8
       jmp       short M25_L03
M25_L08:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      qword ptr [7FF86BBF6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C12D0C8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M25_L03
M25_L09:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M25_L12
       mov       rdx,rcx
       jmp       near ptr M25_L05
M25_L10:
       mov       ecx,1A1
       mov       rdx,7FF86BB34000
       call      qword ptr [7FF86BE17798]
       mov       rcx,rax
       call      qword ptr [7FF86C3E4420]
       int       3
M25_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C3E6538]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BF84450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M25_L12:
       call      qword ptr [7FF86C3E6568]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 414
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M26_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M26_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M26_L00:
       call      qword ptr [7FF8AC23F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,29E899E9C30
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,29E899E0008
       call      qword ptr [7FF86C034A38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M27_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M27_L01
M27_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3A0CA8
       call      qword ptr [7FF86BE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M27_L01:
       mov       rax,29E899EBB78
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,29E899E0008
       call      qword ptr [7FF86BF8E4F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3079D8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF86C30D350]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M27_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M27_L03
M27_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3A1120
       call      qword ptr [7FF86BE17B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M27_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF86C30D368]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF86C30D308]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAttributeType()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rcx,223EB800C88
       mov       rsi,[rcx]
       mov       rcx,223EB800C90
       mov       rdi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L11
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L13
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L13
       mov       rbp,[rcx+50]
       test      rbp,rbp
       je        near ptr M00_L13
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L12
M00_L01:
       mov       [rsp+48],rbp
       lea       rcx,[rbp+10]
       mov       eax,[rbp+8]
       mov       [rsp+58],rcx
       mov       [rsp+60],eax
       xor       ecx,ecx
       mov       [rsp+50],ecx
       mov       byte ptr [rsp+54],0
       mov       rcx,223EB2B10F0
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L27
M00_L02:
       mov       rdx,[rsi+20]
       test      rdx,rdx
       jne       short M00_L03
       mov       rcx,[rsi+8]
       call      qword ptr [7FF86BD94AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        near ptr M00_L10
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF86BD94B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
M00_L03:
       cmp       byte ptr [rsp+54],0
       jne       near ptr M00_L28
       test      rdx,rdx
       je        near ptr M00_L28
       mov       r8d,[rsp+50]
       mov       ecx,[rsp+60]
       cmp       r8d,ecx
       ja        near ptr M00_L31
       mov       rax,[rsp+58]
       mov       r10d,r8d
       lea       rax,[rax+r10*2]
       sub       ecx,r8d
       mov       esi,[rdx+8]
       cmp       esi,ecx
       ja        near ptr M00_L28
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FF86BC25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       esi,[rsp+50]
       mov       [rsp+50],esi
M00_L04:
       mov       ecx,[rsp+50]
       mov       edx,[rsp+60]
       cmp       ecx,edx
       ja        near ptr M00_L31
       mov       rax,[rsp+58]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L29
       mov       word ptr [rax],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
M00_L05:
       cmp       byte ptr [rsp+54],0
       jne       near ptr M00_L30
       mov       ecx,[rsp+50]
       mov       edx,[rsp+60]
       cmp       ecx,edx
       ja        near ptr M00_L31
       mov       rax,[rsp+58]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,0C
       jb        near ptr M00_L30
       vmovups   xmm0,[7FF86C446750]
       vmovups   [rax],xmm0
       mov       rcx,65007400750062
       mov       [rax+10],rcx
       mov       ecx,[rsp+50]
       add       ecx,0C
       mov       [rsp+50],ecx
M00_L06:
       mov       edx,[rsp+50]
       mov       ecx,[rsp+60]
       cmp       edx,ecx
       ja        near ptr M00_L31
       mov       r8,[rsp+58]
       mov       eax,edx
       lea       r8,[r8+rax*2]
       sub       ecx,edx
       cmp       ecx,6
       jb        near ptr M00_L32
       mov       rdx,264806B1D1C
       mov       rcx,r8
       mov       r8d,6
       call      qword ptr [7FF86C334888]; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       mov       ecx,[rsp+50]
       add       ecx,6
       mov       [rsp+50],ecx
M00_L07:
       mov       rcx,223EB2F1168
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L33
M00_L08:
       cmp       [rcx],ecx
       call      qword ptr [7FF86C157588]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rdx,rax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF86BE4E4C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+40]
       call      qword ptr [7FF86BE44EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rsi,rax
       mov       rcx,224018002E8
       mov       rcx,[rcx]
       lea       r9,[rsp+38]
       mov       r8,rsi
       mov       rdx,7FF86C36EFE8
       call      qword ptr [7FF86C336F58]; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L34
       mov       rdi,[rsp+38]
M00_L09:
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       [rsp+30],rdi
       mov       rcx,[rbx+90]
       lea       r8,[rsp+30]
       mov       rdx,7FF86C3BFEC0
       cmp       [rcx],ecx
       call      qword ptr [7FF86C337F00]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,68
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L10:
       xor       edx,edx
       jmp       near ptr M00_L03
M00_L11:
       mov       ecx,3
       call      qword ptr [7FF86C33EFE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L12:
       mov       rcx,rbp
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rbp+8]
       mov       rcx,rsi
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF86C4B77F8]
       jmp       near ptr M00_L01
M00_L13:
       mov       rcx,[rsi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L25
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L24
       mov       rbp,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF86BC25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF86BB6B1A4],0
       je        short M00_L14
       call      qword ptr [7FF86C4B7810]
       mov       r14d,eax
       jmp       short M00_L16
M00_L14:
       mov       ecx,0B
       call      qword ptr [7FF86C4B7828]
       mov       r14d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FF86C4B7828]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M00_L15
       call      qword ptr [7FF86C4B7840]
       mov       r14d,eax
       jmp       short M00_L16
M00_L15:
       sar       r14d,10
M00_L16:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF86BC25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FF86BB6B198]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       short M00_L20
M00_L17:
       cmp       r14d,[rbp+8]
       jae       near ptr M00_L36
       mov       ecx,r14d
       mov       r13,[rbp+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FF86C15E370]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L18
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M00_L18:
       mov       rcx,r13
       call      qword ptr [7FF86BC26820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M00_L21
       inc       r14d
       cmp       [rbp+8],r14d
       jne       short M00_L19
       xor       r14d,r14d
M00_L19:
       inc       r15d
M00_L20:
       cmp       [rbp+8],r15d
       jg        short M00_L17
       jmp       short M00_L22
M00_L21:
       mov       rbp,r12
       jmp       short M00_L23
M00_L22:
       xor       ebp,ebp
M00_L23:
       test      rbp,rbp
       je        short M00_L24
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L01
       mov       rcx,rbp
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rbp+8]
       mov       rcx,rsi
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rdi
       call      qword ptr [7FF86C4B77F8]
       jmp       near ptr M00_L01
M00_L24:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L01
       jmp       short M00_L26
M00_L25:
       mov       ecx,100
       mov       rdx,264806A6F28
       call      qword ptr [7FF86BE4DAD0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L24
M00_L26:
       mov       rcx,rbp
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,rsi
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,100
       mov       rcx,rdi
       call      qword ptr [7FF86C4B77F8]
       mov       rcx,rsi
       call      qword ptr [7FF86C06D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,r14d
       mov       r8d,100
       call      qword ptr [7FF86C4B7858]
       jmp       near ptr M00_L01
M00_L27:
       mov       rcx,264806B1CB8
       call      qword ptr [7FF86BC27C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L28:
       lea       rcx,[rsp+40]
       call      qword ptr [7FF86C4B7618]
       jmp       near ptr M00_L04
M00_L29:
       lea       rcx,[rsp+40]
       mov       rdx,264806A0658
       call      qword ptr [7FF86C3348E8]
       jmp       near ptr M00_L05
M00_L30:
       lea       rcx,[rsp+40]
       mov       rdx,264806B1CE0
       call      qword ptr [7FF86C4B7618]
       jmp       near ptr M00_L06
M00_L31:
       call      qword ptr [7FF86BD97198]
       int       3
M00_L32:
       lea       rcx,[rsp+40]
       mov       rdx,264806B1D10
       call      qword ptr [7FF86C3348E8]
       jmp       near ptr M00_L07
M00_L33:
       mov       rcx,264806B04C0
       call      qword ptr [7FF86BC27C48]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M00_L08
M00_L34:
       mov       rcx,264806B1CB8
       call      qword ptr [7FF86BE4E6E8]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rdx,rax
       mov       rcx,7FF86C3BE9E0
       xor       r8d,r8d
       call      qword ptr [7FF86C1568C8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        short M00_L35
       mov       ecx,5
       call      qword ptr [7FF86C337018]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,224018002E8
       mov       rcx,[rcx]
       mov       r8,rsi
       mov       r9,rdi
       mov       rdx,7FF86C3BEB28
       call      qword ptr [7FF86C336FD0]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L09
M00_L35:
       xor       edi,edi
       jmp       near ptr M00_L09
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1615
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vzeroupper
       cmp       [rcx],cl
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M01_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M01_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L15
M01_L01:
       cmp       ebx,1D
       ja        short M01_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M01_L16
M01_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M01_L03:
       test      r14d,r14d
       jne       near ptr M01_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M01_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M01_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M01_L04:
       test      eax,eax
       jne       near ptr M01_L11
       cmp       rdi,rsi
       jne       near ptr M01_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M01_L05:
       cmp       [rbx],rsi
       jne       near ptr M01_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L21
       mov       rcx,[rsp+28]
M01_L06:
       cmp       ebx,1D
       ja        short M01_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M01_L22
M01_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M01_L08:
       test      ebp,ebp
       jne       near ptr M01_L20
       cmp       [rcx],rsi
       jne       near ptr M01_L24
M01_L09:
       test      rcx,rcx
       je        near ptr M01_L25
       call      00007FF8CB849400
M01_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M01_L27
M01_L11:
       cmp       rdi,rsi
       jne       near ptr M01_L29
       mov       rcx,[rbp+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L28
M01_L12:
       cmp       edi,1B
       je        near ptr M01_L27
M01_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M01_L00
M01_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L01
M01_L16:
       mov       r14d,1
       jmp       near ptr M01_L03
M01_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M01_L03
M01_L18:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L04
M01_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M01_L05
M01_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M01_L06
M01_L22:
       mov       ebp,1
       jmp       near ptr M01_L08
M01_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M01_L08
M01_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF86C33F630]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C33F648]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L10
M01_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L27
       jmp       near ptr M01_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD94B28]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M03_L05
       cmp       r8,40
       jbe       short M03_L02
       cmp       r8,800
       ja        near ptr M03_L11
       cmp       r8,100
       jae       near ptr M03_L09
M03_L00:
       mov       r9,r8
       shr       r9,6
M03_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L03
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L07
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       vzeroupper
       ret
M03_L05:
       test      r8b,18
       jne       short M03_L06
       test      r8b,4
       jne       short M03_L08
       test      r8,r8
       je        short M03_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L04
M03_L06:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L04
M03_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L04
M03_L09:
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
       jmp       near ptr M03_L00
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L04
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF86BC266E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 321
```
```assembly
; System.Buffer.Memmove[[System.Char, System.Private.CoreLib]](Char ByRef, Char ByRef, UIntPtr)
       sub       rsp,28
       add       r8,r8
       call      qword ptr [7FF86BC25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
; Total bytes of code 19
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetFullName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+20]
       test      rax,rax
       je        short M05_L00
       add       rsp,20
       pop       rbx
       ret
M05_L00:
       mov       rcx,[rbx+8]
       call      qword ptr [7FF86BD94AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M05_L01
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86BD94B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M06_L01
       test      rdx,rdx
       je        short M06_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M06_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M06_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BC25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FF86BD97198]
       int       3
M06_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C4B7618]
; Total bytes of code 105
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M07_L01
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rdx,rdx
       je        short M07_L00
       mov       rcx,223EB800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF86BEEFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M07_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       call      qword ptr [7FF86BD97198]
       int       3
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.TryGetValueCore(key, out value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rdx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M08_L48
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M08_L48
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M08_L50
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M08_L52
M08_L00:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M08_L51
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M08_L52
M08_L01:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M08_L09
M08_L02:
       mov       rsi,[rbp+10]
       test      rbx,rbx
       jne       near ptr M08_L10
       xor       ebp,ebp
       xor       r14d,r14d
M08_L03:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M08_L11
M08_L04:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M08_L53
       mov       r15,[rsi+28]
       mov       rcx,[r15+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M08_L54
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86C1D64D8]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M08_L05:
       mov       [rsp+4C],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M08_L80
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M08_L18
M08_L06:
       test      r13,r13
       je        near ptr M08_L67
       cmp       eax,[r13+20]
       jne       near ptr M08_L56
       mov       r8,[r13+8]
       test      r14d,r14d
       je        near ptr M08_L55
M08_L07:
       test      r8,r8
       jne       short M08_L12
       xor       edx,edx
       xor       r10d,r10d
M08_L08:
       cmp       r14d,r10d
       jne       near ptr M08_L17
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M08_L13
       mov       rcx,rbp
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M08_L14
M08_L09:
       mov       rcx,rsi
       mov       rdx,7FF86C3AF348
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M08_L02
M08_L10:
       lea       rbp,[rbx+0C]
       mov       r14d,[rbx+8]
       jmp       near ptr M08_L03
M08_L11:
       mov       rdx,7FF86C3AF488
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M08_L04
M08_L12:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M08_L08
M08_L13:
       mov       rcx,rbp
       call      qword ptr [7FF86BC2FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M08_L14:
       test      eax,eax
       je        near ptr M08_L56
M08_L15:
       mov       rbp,[r13+10]
M08_L16:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M08_L19
       call      qword ptr [7FF86C156DD8]; System.DateTime.get_UtcNow()
       mov       r14,rax
       jmp       short M08_L20
M08_L17:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M08_L14
M08_L18:
       test      r13,r13
       jne       near ptr M08_L57
       jmp       near ptr M08_L67
M08_L19:
       lea       rdx,[rsp+38]
       mov       r11,7FF86BB70C88
       call      qword ptr [r11]
       mov       r14,4000000000000000
       or        r14,[rsp+40]
M08_L20:
       test      rbp,rbp
       je        near ptr M08_L42
       cmp       byte ptr [rbp+43],0
       jne       near ptr M08_L41
       cmp       qword ptr [rbp+38],0
       jge       short M08_L21
       cmp       qword ptr [rbp+50],0
       je        short M08_L24
M08_L21:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       cmp       [rbp+38],rdx
       jbe       near ptr M08_L68
       cmp       qword ptr [rbp+50],0
       jg        near ptr M08_L69
M08_L22:
       xor       r13d,r13d
M08_L23:
       test      r13d,r13d
       jne       near ptr M08_L41
M08_L24:
       cmp       qword ptr [rbp+10],0
       je        short M08_L25
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4B7D38]
       test      eax,eax
       jne       near ptr M08_L41
M08_L25:
       mov       [rbp+58],r14
       mov       r15,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M08_L70
M08_L26:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M08_L36
       mov       [rsi+48],r14
       test      byte ptr [7FF86C522D08],1
       je        near ptr M08_L71
M08_L27:
       mov       rcx,224018004A0
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M08_L28
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,22401800498
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M08_L72
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF86C4B8A38
       mov       [rbp+18],rcx
       mov       rcx,224018004A0
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L28:
       test      byte ptr [7FF86C5113F0],1
       je        near ptr M08_L73
M08_L29:
       mov       rcx,224018004D0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M08_L74
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M08_L75
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M08_L75
M08_L30:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M08_L31
       call      qword ptr [7FF86BE4FDB0]; System.Threading.Thread.InitializeCurrentThread()
M08_L31:
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        near ptr M08_L45
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
M08_L32:
       test      rbp,rbp
       je        near ptr M08_L47
       test      byte ptr [7FF86C4E3170],1
       je        near ptr M08_L77
M08_L33:
       mov       rcx,224018004E0
       cmp       rbp,[rcx]
       je        short M08_L35
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M08_L34
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M08_L34:
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M08_L35:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF86C4BCA80]
M08_L36:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M08_L78
M08_L37:
       test      r15,r15
       je        near ptr M08_L79
       mov       rcx,[rbx+18]
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M08_L44
       mov       rdx,r15
       test      rdx,rdx
       je        short M08_L38
       mov       rcx,rsi
       cmp       [rdx],rcx
       je        short M08_L38
       mov       rdx,r15
       call      qword ptr [7FF86BC258D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M08_L38:
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M08_L39:
       mov       eax,1
M08_L40:
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
M08_L41:
       cmp       byte ptr [rbp+45],2
       je        near ptr M08_L25
       mov       r8,[rsi+10]
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF86C4B7D98]
M08_L42:
       mov       rdx,[rsi+10]
       mov       rbx,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r14
       call      qword ptr [7FF86C337C30]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rbx,rax
       jge       short M08_L43
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF86C4B7D68]
M08_L43:
       cmp       qword ptr [rsi+20],0
       je        short M08_L44
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4B7D80]
       inc       qword ptr [rax+18]
M08_L44:
       xor       eax,eax
       mov       [rdi],rax
       jmp       short M08_L40
M08_L45:
       test      byte ptr [7FF86C4E3170],1
       je        near ptr M08_L76
M08_L46:
       mov       rcx,224018004E0
       mov       rbp,[rcx]
       jmp       near ptr M08_L32
M08_L47:
       or        dword ptr [r13+34],20000000
       jmp       near ptr M08_L35
M08_L48:
       call      qword ptr [7FF86C064A68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M08_L49
       call      qword ptr [7FF86C4BC978]
       mov       rbx,rax
M08_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,264806A9C30
       call      qword ptr [7FF86C33F648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M08_L50:
       call      qword ptr [7FF86C4B4CC0]
       test      eax,eax
       jne       short M08_L52
       jmp       near ptr M08_L00
M08_L51:
       call      qword ptr [7FF86C4B4CC0]
       test      eax,eax
       je        near ptr M08_L01
M08_L52:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF86C4B7B40]
       mov       rbx,rax
       jmp       near ptr M08_L01
M08_L53:
       call      qword ptr [7FF86C4B7C78]
       int       3
M08_L54:
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB70C78
       call      qword ptr [r11]
       jmp       near ptr M08_L05
M08_L55:
       test      r8,r8
       jne       near ptr M08_L07
M08_L56:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M08_L06
M08_L57:
       cmp       eax,[r13+20]
       jne       near ptr M08_L65
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M08_L58
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB70C80
       call      qword ptr [r11]
       jmp       short M08_L66
M08_L58:
       test      r14d,r14d
       jne       short M08_L59
       test      r8,r8
       je        short M08_L65
M08_L59:
       test      r8,r8
       je        short M08_L60
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M08_L61
M08_L60:
       xor       edx,edx
       xor       r10d,r10d
M08_L61:
       cmp       r14d,r10d
       je        short M08_L62
       xor       edx,edx
       mov       eax,edx
       jmp       short M08_L64
M08_L62:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M08_L63
       mov       rcx,rbp
       call      qword ptr [7FF86BC2FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M08_L64
M08_L63:
       mov       r8,rbp
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M08_L64:
       jmp       short M08_L66
M08_L65:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M08_L18
M08_L66:
       test      eax,eax
       je        short M08_L65
       jmp       near ptr M08_L15
M08_L67:
       xor       ebp,ebp
       jmp       near ptr M08_L16
M08_L68:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF86C4BCA50]
       mov       r13d,1
       jmp       near ptr M08_L23
M08_L69:
       mov       rdx,[rbp+58]
       mov       rcx,r14
       call      qword ptr [7FF86C337C30]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FF86C4BCA68]
       test      eax,eax
       jne       short M08_L68
       jmp       near ptr M08_L22
M08_L70:
       mov       rcx,rbp
       call      qword ptr [7FF86C4B7D50]
       jmp       near ptr M08_L26
M08_L71:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L27
M08_L72:
       call      qword ptr [7FF86C4B4E58]
       int       3
M08_L73:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF86BC25740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L29
M08_L74:
       mov       ecx,2F
       call      qword ptr [7FF86BE4C228]
       int       3
M08_L75:
       mov       ecx,4
       call      qword ptr [7FF86C33EFE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M08_L30
M08_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L46
M08_L77:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M08_L33
M08_L78:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4B7D80]
       inc       qword ptr [rax+10]
       jmp       near ptr M08_L37
M08_L79:
       xor       r8d,r8d
       mov       [rdi],r8
       jmp       near ptr M08_L39
M08_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
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
       call      qword ptr [7FF8AC241D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M10_L01
       cmp       [rax],ecx
       jle       short M10_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M10_L03
M10_L00:
       add       rsp,20
       pop       rbx
       ret
M10_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M10_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M10_L00
M10_L02:
       cmp       [rax+4],edx
       jle       short M10_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M10_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M10_L03
       jmp       short M10_L00
M10_L03:
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
       call      qword ptr [7FF8AC244DC8]
       test      eax,eax
       je        short M11_L00
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M12_L00
       ret
M12_L00:
       jmp       qword ptr [7FF86BE4E250]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M13_L01
       mov       rcx,rbx
       call      00007FF8CB89E120
       test      eax,eax
       je        short M13_L00
       mov       rcx,7FF86C40C910
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,20
       pop       rbx
       ret
M13_L00:
       mov       rcx,7FF86C40C914
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FF86C40C910
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86C33F6F0]
M13_L01:
       xor       ecx,ecx
       call      qword ptr [7FF86C33ED30]
       int       3
; Total bytes of code 100
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M14_L00
       mov       rcx,rbx
       call      00007FF8CB89E040
       test      eax,eax
       jne       short M14_L01
       add       rsp,20
       pop       rbx
       ret
M14_L00:
       xor       ecx,ecx
       call      qword ptr [7FF86C33ED30]
       int       3
M14_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86C33EE38]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M15_L00
       add       rsp,28
       ret
M15_L00:
       call      qword ptr [7FF8AC251908]
       int       3
; Total bytes of code 20
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M16_L08
M16_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M16_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M16_L09
M16_L01:
       test      rdi,rdi
       jne       near ptr M16_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M16_L10
M16_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M16_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD61B50
       mov       [rbp-78],rax
       lea       rax,[M16_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M16_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M16_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M16_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M16_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M16_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M16_L11
M16_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M16_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M16_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C4BCA98]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M16_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C4B4780]
       jmp       near ptr M16_L00
M16_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M16_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BC27C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M16_L02
M16_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        short M17_L00
       mov       rcx,rbx
       mov       rdx,7FF86C4FA500
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.IReflectableType
       call      qword ptr [7FF86BD9F618]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        short M17_L01
       mov       rcx,7FF86C4FA608
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rsi
       mov       rdx,7FF86C4FA610
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       r11,7FF86BB70AB8
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [r11]
M17_L00:
       mov       ecx,37B
       mov       rdx,7FF86BB64000
       call      qword ptr [7FF86BE47798]
       mov       rcx,rax
       call      qword ptr [7FF86C33ED30]
       int       3
M17_L01:
       mov       rcx,7FF86C4FA718
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,offset MT_System.Reflection.TypeDelegator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF86C4B7960]
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 200
```
```assembly
; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M18_L10
       mov       rcx,[rcx+18]
       mov       rdi,[rcx]
       mov       rcx,rdi
       call      qword ptr [7FF86BC25860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF86BC2DB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       je        short M18_L01
M18_L00:
       mov       rcx,264806A1A60
       cmp       rax,rcx
       je        short M18_L02
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FF86BC2DB18]; System.RuntimeType.GetBaseType()
       test      rax,rax
       jne       short M18_L00
M18_L01:
       mov       rcx,offset MT_System.Attribute
       cmp       rdi,rcx
       jne       near ptr M18_L11
M18_L02:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       cmp       eax,2
       jne       short M18_L06
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      qword ptr [7FF86BC26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C4B4E88]
M18_L03:
       test      rax,rax
       je        short M18_L04
       cmp       dword ptr [rax+8],0
       jne       near ptr M18_L09
M18_L04:
       xor       edx,edx
M18_L05:
       mov       rcx,rdi
       call      qword ptr [7FF86BC258D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M18_L06:
       cmp       eax,10
       je        short M18_L08
       mov       rdx,rbp
       movzx     r8d,sil
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       r8,rax
       test      r8,r8
       je        short M18_L07
       mov       rcx,offset MT_System.Attribute[]
       cmp       [r8],rcx
       je        short M18_L07
       mov       rdx,rax
       call      qword ptr [7FF86BC258D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       r8,rax
M18_L07:
       mov       rax,r8
       jmp       short M18_L03
M18_L08:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      qword ptr [7FF86BC26328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       rdx,rbp
       movzx     r8d,sil
       call      qword ptr [7FF86C15D0C8]; System.Attribute.InternalGetCustomAttributes(System.Reflection.PropertyInfo, System.Type, Boolean)
       jmp       near ptr M18_L03
M18_L09:
       mov       rcx,[rax+10]
       cmp       dword ptr [rax+8],1
       jne       short M18_L12
       mov       rdx,rcx
       jmp       near ptr M18_L05
M18_L10:
       mov       ecx,1A1
       mov       rdx,7FF86BB64000
       call      qword ptr [7FF86BE47798]
       mov       rcx,rax
       call      qword ptr [7FF86C33ED30]
       int       3
M18_L11:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C4B4E70]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BFB4450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M18_L12:
       call      qword ptr [7FF86C4B4EA0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 414
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M19_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M19_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M19_L00:
       call      qword ptr [7FF8AC23F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,264806A9C30
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,264806A0008
       call      qword ptr [7FF86C064A38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M20_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M20_L01
M20_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3AFF78
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M20_L01:
       mov       rax,264806ABB78
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,264806A0008
       call      qword ptr [7FF86BFBE4F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C337AE0]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF86C337CF0]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M20_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M20_L03
M20_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3C0400
       call      qword ptr [7FF86BE47B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M20_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF86C337D08]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF86C337CA8]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetImplementedInterfacesInterfaceNames()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,263EC7C1D18
       mov       [rsi+8],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,22357800230
       mov       r14,[rcx]
       mov       [rbp-0C0],r14
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rcx,rdi
       mov       rdx,263EC7C1CB8
       call      qword ptr [7FF86BD6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M00_L01
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       mov       edx,edx
       mov       rax,263EC7C1CE8
       mov       [rcx+rdx*8+10],rax
M00_L00:
       mov       ecx,[rdi+10]
       test      ecx,ecx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M00_L68
       mov       rcx,rsi
       call      qword ptr [7FF86BBFC9C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L02
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M00_L02
       mov       r15,rsi
       jmp       short M00_L03
M00_L01:
       mov       rcx,rdi
       mov       rdx,263EC7C1CE8
       call      qword ptr [7FF86BD6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M00_L00
M00_L02:
       mov       rcx,rax
       call      qword ptr [7FF86BBF7C48]; System.RuntimeType.InitializeCache()
       mov       r15,rax
M00_L03:
       cmp       [r15],r15b
       lea       rsi,[r15+58]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L70
M00_L04:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L71
       mov       rsi,[rcx+8]
M00_L05:
       test      rsi,rsi
       je        near ptr M00_L65
       lea       r15,[rsi+10]
       mov       esi,[rsi+8]
M00_L06:
       test      esi,esi
       jne       near ptr M00_L66
       mov       rdx,22357800208
       mov       r13,[rdx]
M00_L07:
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,22357800068
       mov       r15,[rcx]
       mov       rdx,r15
       lea       rcx,[rsi+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       call      qword ptr [7FF86BBF6358]; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       test      rax,rax
       je        short M00_L08
       lea       rcx,[rsi+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L08:
       mov       ecx,[rdi+10]
       test      ecx,ecx
       jle       short M00_L09
       call      qword ptr [7FF86BBF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r15d,eax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Collections.Generic.HashSet<System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-78],rax
       mov       dword ptr [rsi+2C],0FFFFFFFF
       lea       rcx,[rsi+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rsi+10]
       mov       rdx,[rbp-78]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r15d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rsi+20],rax
M00_L09:
       cmp       dword ptr [rdi+10],0
       je        near ptr M00_L74
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>+Enumerator
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       r12d,[rdi+14]
       lea       rcx,[r15+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+10],rcx
       mov       [r15+18],r12d
       mov       [r15+1C],ecx
M00_L10:
       mov       rcx,r15
       mov       [rbp-80],rcx
M00_L11:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>+Enumerator
       mov       rax,[rbp-80]
       cmp       [rax],rcx
       jne       near ptr M00_L31
       lea       rdi,[rax+8]
       mov       rcx,[rdi]
       mov       edx,[rdi+10]
       mov       r8,[rdi]
       cmp       edx,[r8+14]
       jne       near ptr M00_L33
       mov       edx,[rdi+14]
       cmp       edx,[rcx+10]
       jae       near ptr M00_L23
       mov       rcx,[rcx+8]
       mov       edx,[rdi+14]
       cmp       edx,[rcx+8]
       jae       near ptr M00_L34
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rdi+14]
       mov       rax,[rbp-80]
       mov       rdi,[rax+10]
M00_L12:
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L25
M00_L13:
       mov       r15,[rsi+10]
       mov       r12,[rsi+18]
       xor       r8d,r8d
       mov       [rbp-3C],r8d
       test      rdi,rdi
       je        near ptr M00_L21
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M00_L26
       lea       rcx,[rdi+0C]
       mov       [rbp-50],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rbp-50]
       mov       r10d,[rdi+8]
       cmp       r10d,2
       jle       short M00_L15
M00_L14:
       add       r10d,0FFFFFFFC
       mov       r9d,ecx
       rol       r9d,5
       add       ecx,r9d
       xor       ecx,[r11]
       mov       r9d,edx
       rol       r9d,5
       add       edx,r9d
       xor       edx,[r11+4]
       add       r11,8
       cmp       r10d,2
       jg        short M00_L14
M00_L15:
       test      r10d,r10d
       jle       short M00_L16
       mov       r10d,edx
       rol       r10d,5
       add       r10d,edx
       mov       edx,r10d
       xor       edx,[r11]
M00_L16:
       imul      r10d,edx,5D588B65
       add       r10d,ecx
       xor       ecx,ecx
       mov       [rbp-50],rcx
M00_L17:
       mov       [rbp-40],r10d
       mov       rdx,[rsi+8]
       mov       ecx,r10d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       imul      rcx,r11
       shr       rcx,20
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L34
       mov       ecx,ecx
       lea       r9,[rdx+rcx*4+10]
       mov       [rbp-90],r9
       mov       r11d,[r9]
       dec       r11d
       jns       near ptr M00_L27
M00_L18:
       cmp       dword ptr [rsi+30],0
       jg        near ptr M00_L22
       mov       edx,[rsi+28]
       mov       [rbp-44],edx
       cmp       [r15+8],edx
       je        near ptr M00_L29
M00_L19:
       mov       edx,[rbp-44]
       mov       r15d,edx
       lea       ecx,[r15+1]
       mov       [rsi+28],ecx
       mov       rcx,[rsi+10]
       mov       r11,rcx
M00_L20:
       cmp       r15d,[r11+8]
       jae       near ptr M00_L34
       mov       ecx,r15d
       shl       rcx,4
       mov       [rbp-88],r11
       lea       rcx,[r11+rcx+10]
       mov       [rcx+8],r10d
       mov       r9,[rbp-90]
       mov       edx,[r9]
       dec       edx
       mov       [rcx+0C],edx
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r15d
       mov       rdx,[rbp-90]
       mov       [rdx],r15d
       inc       dword ptr [rsi+34]
       cmp       dword ptr [rbp-3C],64
       jbe       near ptr M00_L11
       jmp       near ptr M00_L30
M00_L21:
       xor       r10d,r10d
       jmp       near ptr M00_L17
M00_L22:
       mov       ecx,[rsi+2C]
       mov       r11d,ecx
       dec       dword ptr [rsi+30]
       cmp       ecx,[r15+8]
       jae       near ptr M00_L34
       shl       rcx,4
       mov       ecx,[r15+rcx+1C]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rsi+2C],ecx
       mov       ecx,r11d
       mov       r11,r15
       mov       r15d,ecx
       jmp       near ptr M00_L20
M00_L23:
       xor       ecx,ecx
       mov       [rdi+8],rcx
       mov       dword ptr [rdi+14],0FFFFFFFF
       jmp       near ptr M00_L35
M00_L24:
       mov       rcx,[rbp-80]
       mov       r11,7FF86BB40CE8
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rax,[rbp-80]
       jmp       near ptr M00_L12
M00_L25:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86BBFE8E0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       mov       rax,[rbp-80]
       jmp       near ptr M00_L13
M00_L26:
       mov       rcx,r12
       mov       rdx,rdi
       mov       r11,7FF86BB40CF8
       call      qword ptr [r11]
       mov       r10d,eax
       mov       rax,[rbp-80]
       jmp       near ptr M00_L17
M00_L27:
       cmp       r11d,[r15+8]
       jae       near ptr M00_L34
       mov       edx,r11d
       shl       rdx,4
       lea       r11,[r15+rdx+10]
       mov       [rbp-98],r11
       cmp       [r11+8],r10d
       jne       short M00_L28
       mov       rdx,[r11]
       mov       rcx,r12
       mov       r8,rdi
       mov       r11,7FF86BB40D00
       call      qword ptr [r11]
       test      eax,eax
       mov       r11,[rbp-98]
       jne       near ptr M00_L11
M00_L28:
       mov       rax,[rbp-80]
       mov       r11d,[r11+0C]
       mov       r8d,[rbp-3C]
       inc       r8d
       mov       [rbp-3C],r8d
       cmp       [r15+8],r8d
       jb        near ptr M00_L32
       test      r11d,r11d
       mov       r10d,[rbp-40]
       jge       short M00_L27
       jmp       near ptr M00_L18
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FF86C447B28]
       mov       rcx,[rsi+8]
       mov       r15d,[rbp-40]
       mov       edx,r15d
       imul      rdx,[rsi+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L34
       mov       edx,edx
       lea       r9,[rcx+rdx*4+10]
       mov       rax,r9
       mov       [rbp-90],rax
       mov       r10d,r15d
       mov       rax,[rbp-80]
       jmp       near ptr M00_L19
M00_L30:
       mov       r15,[rbp-88]
       mov       rdx,r12
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L11
       mov       edx,[r15+8]
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FF86BF87F48]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF86BBFE9A0]; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
       jmp       near ptr M00_L11
M00_L31:
       mov       rcx,rax
       mov       r11,7FF86BB40CE0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L24
       jmp       near ptr M00_L75
M00_L32:
       call      qword ptr [7FF86BE17A08]
       int       3
M00_L33:
       call      qword ptr [7FF86BE1C138]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       mov       ecx,[rsi+28]
       test      ecx,ecx
       jle       short M00_L36
       mov       rax,[rsi+10]
       mov       eax,[rax+8]
       cdq
       idiv      ecx
       cmp       eax,3
       jg        near ptr M00_L76
M00_L36:
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       edx,[rsi+28]
       sub       edx,[rsi+30]
       js        near ptr M00_L77
       test      edx,edx
       je        near ptr M00_L78
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
M00_L37:
       mov       [rbp-70],rdi
       xor       r15d,r15d
       jmp       short M00_L41
M00_L38:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FF86BD64B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       r10,rax
       jmp       short M00_L44
M00_L39:
       mov       r14,[rbp-0C0]
M00_L40:
       inc       r15d
M00_L41:
       cmp       [r13+8],r15d
       jle       near ptr M00_L62
       cmp       r15d,[r13+8]
       jae       near ptr M00_L89
       mov       r12,[r13+r15*8+10]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L79
       cmp       qword ptr [r12+10],0
       je        short M00_L42
       mov       rcx,[r12+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       near ptr M00_L52
M00_L42:
       mov       rcx,r12
       call      qword ptr [7FF86BBF7C48]; System.RuntimeType.InitializeCache()
M00_L43:
       mov       r10,[rax+18]
       test      r10,r10
       je        short M00_L38
M00_L44:
       mov       rax,r10
M00_L45:
       mov       [rbp-0B0],rax
       cmp       qword ptr [rsi+8],0
       je        short M00_L40
       mov       r8,[rsi+10]
       mov       [rbp-0A0],r8
       xor       r10d,r10d
       mov       [rbp-54],r10d
       mov       r9,[rsi+18]
       mov       [rbp-0A8],r9
       test      rax,rax
       je        near ptr M00_L80
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r9],rcx
       jne       near ptr M00_L81
       lea       rcx,[rax+0C]
       mov       [rbp-60],rcx
       mov       ecx,15051505
       mov       edx,15051505
       mov       r11,[rbp-60]
       mov       r14d,[rax+8]
       cmp       r14d,2
       jle       short M00_L47
M00_L46:
       add       r14d,0FFFFFFFC
       mov       edi,ecx
       rol       edi,5
       add       ecx,edi
       xor       ecx,[r11]
       mov       edi,edx
       rol       edi,5
       add       edx,edi
       xor       edx,[r11+4]
       add       r11,8
       cmp       r14d,2
       jg        short M00_L46
M00_L47:
       test      r14d,r14d
       jle       short M00_L48
       mov       r14d,edx
       rol       r14d,5
       add       r14d,edx
       mov       edx,r14d
       xor       edx,[r11]
M00_L48:
       imul      r14d,edx,5D588B65
       add       r14d,ecx
       xor       ecx,ecx
       mov       [rbp-60],rcx
M00_L49:
       mov       rdx,[rsi+8]
       mov       ecx,r14d
       imul      rcx,[rsi+20]
       shr       rcx,20
       inc       rcx
       mov       r11d,[rdx+8]
       mov       edi,r11d
       imul      rcx,rdi
       shr       rcx,20
       cmp       ecx,r11d
       jae       near ptr M00_L89
       mov       ecx,ecx
       lea       rdx,[rdx+rcx*4+10]
       mov       edi,[rdx]
       dec       edi
       js        near ptr M00_L39
M00_L50:
       mov       r8,[rbp-0A0]
       cmp       edi,[r8+8]
       jae       near ptr M00_L89
       mov       edx,edi
       shl       rdx,4
       lea       r11,[r8+rdx+10]
       mov       [rbp-0B8],r11
       cmp       [r11+8],r14d
       je        short M00_L53
M00_L51:
       mov       edi,[r11+0C]
       mov       r10d,[rbp-54]
       inc       r10d
       mov       r8,[rbp-0A0]
       cmp       [r8+8],r10d
       jb        near ptr M00_L86
       test      edi,edi
       mov       [rbp-54],r10d
       jge       short M00_L50
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L40
M00_L52:
       mov       rax,rcx
       jmp       near ptr M00_L43
M00_L53:
       mov       rdx,[r11]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r9],rcx
       jne       near ptr M00_L84
       mov       r9,[rbp-0A8]
       cmp       rdx,rax
       je        near ptr M00_L82
       test      rdx,rdx
       je        near ptr M00_L83
       test      rax,rax
       je        near ptr M00_L83
       mov       ecx,[rdx+8]
       cmp       ecx,[rax+8]
       jne       near ptr M00_L83
       lea       rcx,[rdx+0C]
       mov       edx,[rdx+8]
       add       edx,edx
       mov       r8d,edx
       lea       rdx,[rax+0C]
       call      qword ptr [7FF86BBFFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r9,[rbp-0A8]
M00_L54:
       test      eax,eax
       mov       rax,[rbp-0B0]
       mov       r11,[rbp-0B8]
       je        near ptr M00_L51
       test      edi,edi
       jge       short M00_L55
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L40
M00_L55:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M00_L85
       cmp       qword ptr [r12+10],0
       je        short M00_L56
       mov       rcx,[r12+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L59
M00_L56:
       mov       rcx,r12
       call      qword ptr [7FF86BBF7C48]; System.RuntimeType.InitializeCache()
M00_L57:
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        short M00_L60
M00_L58:
       mov       rdi,[rbp-70]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       eax,[rdi+10]
       mov       r8d,[rcx+8]
       cmp       r8d,eax
       jbe       short M00_L61
       lea       r10d,[rax+1]
       mov       [rdi+10],r10d
       cmp       eax,r8d
       jae       near ptr M00_L89
       mov       eax,eax
       lea       rcx,[rcx+rax*8+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L40
M00_L59:
       mov       rax,rcx
       jmp       short M00_L57
M00_L60:
       lea       rdx,[rax+18]
       mov       rcx,rax
       xor       r8d,r8d
       call      qword ptr [7FF86BD64B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
       jmp       short M00_L58
M00_L61:
       mov       rcx,rdi
       call      qword ptr [7FF86BD6E3D0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L40
M00_L62:
       mov       rdi,[rbp-70]
       mov       esi,[rdi+10]
       test      esi,esi
       je        near ptr M00_L87
       movsxd    rdx,esi
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,[rdi+8]
       mov       r8d,esi
       mov       rdx,r15
       call      qword ptr [7FF86BBF7048]; System.Array.Copy(System.Array, System.Array, Int32)
M00_L63:
       cmp       dword ptr [r15+8],0
       je        near ptr M00_L88
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
M00_L64:
       mov       [rbp-68],rsi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-68]
       mov       rdx,7FF86C3401D8
       cmp       [rcx],ecx
       call      qword ptr [7FF86C307150]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L65:
       xor       r15d,r15d
       xor       esi,esi
       jmp       near ptr M00_L06
M00_L66:
       mov       edx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L73
       mov       rdx,r15
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M00_L72
M00_L67:
       jmp       near ptr M00_L07
M00_L68:
       call      qword ptr [7FF86C306FD0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L69
       call      qword ptr [7FF86C447BE8]
       mov       rbx,rax
M00_L69:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,263EC7C1D30
       call      qword ptr [7FF86C30E7F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L70:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,r13
       xor       r8d,r8d
       call      00007FF8CB8421C0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r13
       jmp       near ptr M00_L04
M00_L71:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FF86BBFD2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L05
M00_L72:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L67
M00_L73:
       mov       rdx,r15
       call      qword ptr [7FF86C1AF000]
       jmp       near ptr M00_L67
M00_L74:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2236D800428
       mov       r15,[rcx]
       jmp       near ptr M00_L10
M00_L75:
       mov       rcx,[rbp-80]
       mov       r11,7FF86BB40CF0
       call      qword ptr [r11]
       jmp       near ptr M00_L35
M00_L76:
       mov       edx,ecx
       sub       edx,[rsi+30]
       mov       rcx,rsi
       call      qword ptr [7FF86C446D60]
       jmp       near ptr M00_L36
M00_L77:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FF86C1A6760]
       int       3
M00_L78:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L37
M00_L79:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       jmp       near ptr M00_L45
M00_L80:
       xor       edx,edx
       mov       r14d,edx
       jmp       near ptr M00_L49
M00_L81:
       mov       rcx,r9
       mov       rdx,rax
       mov       r11,7FF86BB40D08
       call      qword ptr [r11]
       mov       r14d,eax
       mov       rax,[rbp-0B0]
       mov       r9,[rbp-0A8]
       jmp       near ptr M00_L49
M00_L82:
       mov       ecx,1
       mov       eax,ecx
       jmp       near ptr M00_L54
M00_L83:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       near ptr M00_L54
M00_L84:
       mov       r9,[rbp-0A8]
       mov       rcx,r9
       mov       r8,rax
       mov       r11,7FF86BB40D10
       call      qword ptr [r11]
       mov       r9,[rbp-0A8]
       jmp       near ptr M00_L54
M00_L85:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M00_L58
M00_L86:
       call      qword ptr [7FF86BE17A08]
       int       3
M00_L87:
       mov       r15,r14
       jmp       near ptr M00_L63
M00_L88:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2236D800430
       mov       rsi,[rcx]
       jmp       near ptr M00_L64
M00_L89:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-80],0
       je        short M00_L90
       mov       rcx,offset MT_System.Collections.Generic.List<System.String>+Enumerator
       mov       rax,[rbp-80]
       cmp       [rax],rcx
       je        short M00_L90
       mov       rcx,rax
       mov       r11,7FF86BB40CF0
       call      qword ptr [r11]
M00_L90:
       nop
       add       rsp,28
       ret
; Total bytes of code 3175
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       edi,[rbx+10]
       mov       ebp,edi
       lea       ecx,[rbp+1]
       mov       rdx,[rbx+8]
       cmp       dword ptr [rdx+8],0
       jne       short M01_L01
       mov       r14d,4
M01_L00:
       mov       edx,7FFFFFC7
       cmp       r14d,7FFFFFC7
       cmova     r14d,edx
       cmp       r14d,ecx
       cmovl     r14d,ecx
       cmp       r14d,edi
       jge       short M01_L02
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FF86C1A6760]
       int       3
M01_L01:
       mov       rdx,[rbx+8]
       mov       r14d,[rdx+8]
       add       r14d,r14d
       jmp       short M01_L00
M01_L02:
       mov       rcx,[rbx+8]
       cmp       [rcx+8],r14d
       je        near ptr M01_L08
       test      r14d,r14d
       jg        short M01_L05
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+88]
       test      rdx,rdx
       je        short M01_L04
M01_L03:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L08
M01_L04:
       mov       rdx,7FF86C426388
       call      qword ptr [7FF86BBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M01_L03
M01_L05:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+80]
       test      rax,rax
       je        short M01_L09
       mov       rcx,rax
M01_L06:
       mov       edx,r14d
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r14,rax
       test      edi,edi
       jle       short M01_L07
       mov       rcx,[rbx+8]
       mov       r8d,edi
       mov       rdx,r14
       call      qword ptr [7FF86BBF7048]; System.Array.Copy(System.Array, System.Array, Int32)
M01_L07:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       lea       ecx,[rbp+1]
       mov       [rbx+10],ecx
       mov       rcx,[rbx+8]
       movsxd    rdx,ebp
       mov       r8,rsi
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       mov       rdx,7FF86C32E4F8
       call      qword ptr [7FF86BBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M01_L06
; Total bytes of code 309
```
```assembly
; System.Object.GetType()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        short M02_L01
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       call      qword ptr [7FF86BBF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M02_L00
; Total bytes of code 41
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M03_L08
M03_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M03_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M03_L09
M03_L01:
       test      rdi,rdi
       jne       near ptr M03_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M03_L10
M03_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M03_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD31B50
       mov       [rbp-78],rax
       lea       rax,[M03_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M03_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M03_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M03_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M03_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M03_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M03_L11
M03_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M03_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M03_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C447A50]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M03_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C30F918]
       jmp       near ptr M03_L00
M03_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M03_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BBF7C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M03_L02
M03_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Collections.Generic.NonRandomizedStringEqualityComparer.GetStringComparer(System.Object)
       mov       rax,22357800048
       cmp       rcx,[rax]
       je        short M04_L00
       mov       rax,22357800068
       cmp       rcx,[rax]
       jne       short M04_L01
       mov       rax,22357800058
       mov       rax,[rax]
       ret
M04_L00:
       mov       rax,22357800050
       mov       rax,[rax]
       ret
M04_L01:
       mov       rax,22357800070
       xor       edx,edx
       mov       r8,22357800060
       cmp       rcx,[rax]
       mov       rax,[r8]
       cmovne    rax,rdx
       ret
; Total bytes of code 91
```
```assembly
; System.Collections.HashHelpers.GetPrime(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,ecx
       test      ebx,ebx
       jl        short M05_L01
       mov       rax,7FF8AB5C1660
       xor       ecx,ecx
       mov       edx,48
M05_L00:
       mov       r8d,[rax+rcx]
       cmp       r8d,ebx
       jl        short M05_L02
       mov       eax,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L01:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C30FBE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BF84450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L02:
       add       rcx,4
       dec       edx
       jne       short M05_L00
       mov       esi,ebx
       or        esi,1
       jmp       short M05_L05
M05_L03:
       mov       ecx,esi
       call      qword ptr [7FF86C30FC00]
       test      eax,eax
       je        short M05_L04
       lea       ecx,[rsi-1]
       mov       edx,288DF0CB
       mov       eax,edx
       imul      ecx
       mov       eax,edx
       shr       eax,1F
       sar       edx,4
       add       eax,edx
       imul      eax,65
       sub       ecx,eax
       jne       short M05_L06
M05_L04:
       add       esi,2
M05_L05:
       cmp       esi,7FFFFFFF
       jl        short M05_L03
       jmp       short M05_L07
M05_L06:
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L07:
       mov       eax,ebx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 180
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       ecx,edx
       call      qword ptr [7FF86BBF5A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       esi,eax
       movsxd    rdx,esi
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+0C0]
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
M06_L00:
       movsxd    rdx,esi
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       mov       dword ptr [rbx+2C],0FFFFFFFF
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       mov       eax,esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M06_L01:
       mov       rdx,7FF86C469A40
       call      qword ptr [7FF86BBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M06_L00
; Total bytes of code 170
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M07_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L02
M07_L00:
       test      rax,rax
       je        short M07_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L02
       test      rax,rax
       jne       short M07_L03
M07_L01:
       xor       edx,edx
M07_L02:
       mov       rax,rdx
       ret
M07_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L02
       test      rax,rax
       je        short M07_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L02
       test      rax,rax
       je        short M07_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L02
       jmp       short M07_L00
; Total bytes of code 86
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       esi,edx
       mov       edi,r8d
       mov       rcx,[rbx]
       call      qword ptr [7FF8AC22CEC8]
       mov       rcx,rax
       movsxd    rdx,esi
       call      qword ptr [7FF8AC229088]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rbp,rax
       mov       r14d,[rbx+28]
       mov       rcx,[rbx+10]
       mov       rdx,rbp
       mov       r8d,r14d
       call      qword ptr [7FF8AC23A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       movzx     ecx,dil
       test      cl,1
       jne       near ptr M08_L06
M08_L00:
       movsxd    rcx,esi
       call      qword ptr [7FF8AC236B68]
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      qword ptr [7FF8AC228FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,esi
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rbx+20],rax
       xor       ecx,ecx
       test      r14d,r14d
       jle       short M08_L03
       cmp       [rbp+8],r14d
       jl        near ptr M08_L04
M08_L01:
       mov       edx,ecx
       shl       rdx,4
       lea       rdx,[rbp+rdx+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M08_L02
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       mov       r9d,eax
       imul      r10,r9
       shr       r10,20
       cmp       r10d,eax
       jae       near ptr M08_L11
       mov       r10d,r10d
       lea       rax,[r8+r10*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M08_L02:
       inc       ecx
       cmp       ecx,r14d
       jl        short M08_L01
M08_L03:
       lea       rcx,[rbx+10]
       mov       rdx,rbp
       call      qword ptr [7FF8AC228FE8]; CORINFO_HELP_ASSIGN_REF
       nop
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
M08_L04:
       cmp       ecx,[rbp+8]
       jae       near ptr M08_L11
       mov       eax,ecx
       shl       rax,4
       lea       rdx,[rbp+rax+10]
       cmp       dword ptr [rdx+0C],0FFFFFFFF
       jl        short M08_L05
       mov       eax,[rdx+8]
       mov       r8,[rbx+8]
       mov       r10d,eax
       imul      r10,[rbx+20]
       shr       r10,20
       inc       r10
       mov       eax,[r8+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r8+8]
       jae       near ptr M08_L11
       mov       eax,r10d
       lea       rax,[r8+rax*4+10]
       mov       r8d,[rax]
       dec       r8d
       mov       [rdx+0C],r8d
       lea       edx,[rcx+1]
       mov       [rax],edx
M08_L05:
       inc       ecx
       cmp       ecx,r14d
       jl        short M08_L04
       jmp       near ptr M08_L03
M08_L06:
       mov       rcx,[rbx]
       call      qword ptr [7FF8AC22C500]
       mov       rdi,rax
       mov       rcx,[rbx+18]
       call      qword ptr [7FF8AC238750]
       mov       rcx,rax
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF8AC229090]; Precode of System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdi,rax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      qword ptr [7FF8AC228FE8]; CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       cmp       r15d,r14d
       jge       near ptr M08_L00
M08_L07:
       cmp       r15d,[rbp+8]
       jae       short M08_L11
       mov       rcx,r15
       shl       rcx,4
       lea       r13,[rbp+rcx+10]
       cmp       dword ptr [r13+0C],0FFFFFFFF
       jl        short M08_L10
       cmp       qword ptr [r13],0
       jne       short M08_L08
       xor       r12d,r12d
       jmp       short M08_L09
M08_L08:
       mov       rcx,[rbx]
       call      qword ptr [7FF8AC22E138]
       mov       rdx,[r13]
       mov       rcx,rdi
       mov       r11,rax
       call      qword ptr [rax]
       mov       r12d,eax
M08_L09:
       mov       [r13+8],r12d
M08_L10:
       inc       r15d
       cmp       r15d,r14d
       jl        short M08_L07
       jmp       near ptr M08_L00
M08_L11:
       call      qword ptr [7FF8AC228FD8]
       int       3
; Total bytes of code 540
```
```assembly
; System.Collections.Generic.HashSet`1[[System.__Canon, System.Private.CoreLib]].FindItemIndex(System.__Canon)
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
       mov       [rsp+30],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       qword ptr [rbx+8],0
       je        near ptr M09_L07
       mov       rdi,[rbx+10]
       xor       ebp,ebp
       mov       r14,[rbx+18]
       test      rsi,rsi
       je        near ptr M09_L13
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+88]
       test      r11,r11
       je        near ptr M09_L12
M09_L00:
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r14],rcx
       jne       near ptr M09_L14
       lea       rcx,[rsi+0C]
       mov       [rsp+28],rcx
       mov       ecx,15051505
       mov       r11d,15051505
       mov       rdx,[rsp+28]
       mov       eax,[rsi+8]
       cmp       eax,2
       jle       short M09_L02
M09_L01:
       add       eax,0FFFFFFFC
       mov       r8d,ecx
       rol       r8d,5
       add       ecx,r8d
       xor       ecx,[rdx]
       mov       r8d,r11d
       rol       r8d,5
       add       r11d,r8d
       xor       r11d,[rdx+4]
       add       rdx,8
       cmp       eax,2
       jg        short M09_L01
M09_L02:
       test      eax,eax
       jle       short M09_L03
       mov       eax,r11d
       rol       eax,5
       add       eax,r11d
       mov       r11d,eax
       xor       r11d,[rdx]
M09_L03:
       imul      r15d,r11d,5D588B65
       add       r15d,ecx
       xor       ecx,ecx
       mov       [rsp+28],rcx
M09_L04:
       mov       rcx,[rbx+8]
       mov       edx,r15d
       imul      rdx,[rbx+20]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M09_L19
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r13d,[rcx]
       dec       r13d
       js        short M09_L07
M09_L05:
       mov       r12d,[rdi+8]
       cmp       r13d,r12d
       jae       near ptr M09_L19
       mov       ecx,r13d
       shl       rcx,4
       lea       rax,[rdi+rcx+10]
       mov       [rsp+20],rax
       cmp       [rax+8],r15d
       je        short M09_L08
M09_L06:
       mov       rax,[rsp+20]
       mov       r13d,[rax+0C]
       inc       ebp
       cmp       r12d,ebp
       jb        near ptr M09_L18
       test      r13d,r13d
       jge       short M09_L05
M09_L07:
       mov       eax,0FFFFFFFF
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
M09_L08:
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+90]
       test      r11,r11
       je        short M09_L11
M09_L09:
       mov       rax,[rsp+20]
       mov       rdx,[rax]
       mov       r8,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r14],r8
       jne       near ptr M09_L17
       cmp       rdx,rsi
       je        near ptr M09_L15
       test      rdx,rdx
       je        near ptr M09_L16
       test      rsi,rsi
       je        near ptr M09_L16
       mov       r8d,[rdx+8]
       cmp       r8d,[rsi+8]
       jne       near ptr M09_L16
       lea       rcx,[rdx+0C]
       add       r8d,r8d
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BBFFBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M09_L10:
       test      eax,eax
       je        near ptr M09_L06
       mov       eax,r13d
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
M09_L11:
       mov       rdx,7FF86C42FAD8
       call      qword ptr [7FF86BBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L09
M09_L12:
       mov       rdx,7FF86C42FAC0
       call      qword ptr [7FF86BBFC5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M09_L00
M09_L13:
       xor       r15d,r15d
       jmp       near ptr M09_L04
M09_L14:
       mov       rcx,r14
       mov       rdx,rsi
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M09_L04
M09_L15:
       mov       ecx,1
       mov       eax,ecx
       jmp       short M09_L10
M09_L16:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M09_L10
M09_L17:
       mov       rcx,r14
       mov       r8,rsi
       call      qword ptr [r11]
       jmp       short M09_L10
M09_L18:
       call      qword ptr [7FF86BE17A08]
       int       3
M09_L19:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 602
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD64B28]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M11_L03
       cmp       rcx,rdx
       je        short M11_L02
       cmp       r8,20
       jae       near ptr M11_L08
       cmp       r8,10
       jb        near ptr M11_L12
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M11_L01
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M11_L13
M11_L00:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M11_L11
M11_L01:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       near ptr M11_L13
M11_L02:
       mov       eax,1
       vzeroupper
       ret
M11_L03:
       cmp       r8,4
       jae       short M11_L06
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M11_L04
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M11_L04:
       test      r8b,1
       je        short M11_L05
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M11_L05:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M11_L07
M11_L06:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M11_L07:
       vzeroupper
       ret
M11_L08:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M11_L10
M11_L09:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M11_L13
       add       rax,20
       cmp       r8,rax
       ja        short M11_L09
M11_L10:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       short M11_L13
       jmp       near ptr M11_L02
M11_L11:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       short M11_L13
       jmp       near ptr M11_L00
M11_L12:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       short M11_L07
M11_L13:
       xor       eax,eax
       vzeroupper
       ret
; Total bytes of code 328
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        near ptr M12_L06
       test      rbx,rbx
       je        near ptr M12_L07
       mov       rcx,[rsi]
       cmp       rcx,[rbx]
       jne       near ptr M12_L07
       cmp       dword ptr [rcx+4],18
       jne       near ptr M12_L07
       cmp       edi,[rsi+8]
       ja        short M12_L07
       cmp       edi,[rbx+8]
       ja        short M12_L07
       mov       r8d,edi
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[rsi+10]
       add       rbx,10
       test      dword ptr [rcx],1000000
       je        short M12_L05
       cmp       r8,4000
       ja        short M12_L04
       mov       rcx,rbx
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       short M12_L02
M12_L00:
       cmp       dword ptr [7FF8CBB53A90],0
       jne       short M12_L03
M12_L01:
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M12_L02:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L00
M12_L03:
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L01
M12_L04:
       mov       rcx,rbx
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF86C1AF000]
M12_L05:
       mov       rcx,rbx
       call      qword ptr [7FF86BBF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M12_L00
M12_L06:
       xor       ebp,ebp
       jmp       short M12_L08
M12_L07:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86C2467A8]; System.Array.GetLowerBound(Int32)
       mov       ebp,eax
M12_L08:
       test      rbx,rbx
       jne       short M12_L09
       xor       r9d,r9d
       jmp       short M12_L10
M12_L09:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C2467A8]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M12_L10:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,ebp
       mov       r8,rbx
       call      qword ptr [7FF86C2467C0]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       short M12_L00
; Total bytes of code 246
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
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,0F7AD2F3BCD46
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M14_L00
       cmp       dword ptr [rbx+8],0
       jne       short M14_L03
M14_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,263EC7B0008
       call      qword ptr [7FF86BBFD338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M14_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FF86BBFD590]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0F7AD2F3BCD46
       cmp       [rbp],r8
       je        short M14_L02
       call      CORINFO_HELP_FAIL_FAST
M14_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M14_L03:
       cmp       r14d,1
       jne       short M14_L04
       cmp       word ptr [rbx+0C],2E
       je        short M14_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M14_L00
M14_L04:
       mov       rcx,22357800220
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FF86BD4F1A8]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M14_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M14_L07
M14_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M14_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M14_L06
       xor       edx,edx
M14_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M14_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M14_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FF86BBFD338]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M14_L01
; Total bytes of code 348
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FF86BBF5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetMembersWithAttribute_ForComparison()
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__71<DotNetTips.Spargine.Core.InformationAttribute>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rsi+24],eax
       mov       rcx,23105FEB690
       mov       [rsi+18],rcx
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
; Total bytes of code 102
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeDisplayNameCached()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,70
       vzeroupper
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-50],ymm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp+10],rcx
       mov       byte ptr [rbp-28],1
       mov       byte ptr [rbp-26],1
       mov       word ptr [rbp-24],2B
       mov       rcx,1BFA4C00308
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M00_L31
       lea       rcx,[rbx+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M00_L30
       xor       edx,edx
       call      00007FF8CB8421C0
       cmp       rax,[rbp-38]
       jne       near ptr M00_L31
M00_L00:
       mov       rbx,[rbp-38]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-30],rbx
       mov       rbx,20023A91CB8
       mov       [rbp-60],rbx
       mov       rcx,offset MT_System.Int32[]
       test      dword ptr [rcx],80000000
       je        short M00_L02
       xor       eax,eax
       jmp       short M00_L03
M00_L02:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M00_L03:
       movzx     ecx,al
       test      ecx,ecx
       jne       near ptr M00_L18
       mov       rcx,offset MT_System.Int32[]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       rsi,[rbp-60]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M00_L19
M00_L04:
       cmp       ebx,14
       je        near ptr M00_L20
       cmp       ebx,1D
       sete      cl
       movzx     ecx,cl
M00_L05:
       test      ecx,ecx
       jne       near ptr M00_L15
       mov       rcx,rsi
       call      00007FF8CB848F60
       test      eax,eax
       jne       near ptr M00_L25
       mov       rbx,[rbp-30]
       movzx     ecx,byte ptr [rbp-28]
       movzx     edi,word ptr [rbp-24]
       test      cl,cl
       je        near ptr M00_L13
       mov       rcx,rsi
       call      qword ptr [7FF86BC17C48]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       mov       rax,[r14+20]
       test      rax,rax
       jne       short M00_L06
       mov       rcx,[r14+8]
       call      qword ptr [7FF86BD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        short M00_L07
       lea       rdx,[r14+20]
       mov       rcx,r14
       mov       r8d,3
       call      qword ptr [7FF86BD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M00_L06:
       test      rax,rax
       je        near ptr M00_L13
       mov       rcx,rsi
       call      qword ptr [7FF86BC17C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       mov       r14,[rsi+20]
       test      r14,r14
       jne       short M00_L09
       mov       rcx,[rsi+8]
       call      qword ptr [7FF86BD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M00_L08
       xor       r14d,r14d
       jmp       short M00_L09
M00_L07:
       xor       eax,eax
       jmp       short M00_L06
M00_L08:
       lea       rdx,[rsi+20]
       mov       rcx,rsi
       mov       r8d,3
       call      qword ptr [7FF86BD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       r14,rax
M00_L09:
       cmp       [rbx],bl
       test      r14,r14
       je        short M00_L11
       lea       rdx,[r14+0C]
       mov       r8d,[r14+8]
       test      r8d,r8d
       je        short M00_L11
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        near ptr M00_L27
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M00_L14
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L10:
       mov       [rbx+18],esi
M00_L11:
       movzx     r9d,di
       cmp       r9d,2B
       jne       near ptr M00_L28
M00_L12:
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       rcx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BE02200]; System.Text.StringBuilder.ToString()
       mov       [rbp-58],rax
       jmp       near ptr M00_L29
M00_L13:
       mov       rcx,20023A91CB8
       mov       rax,[7FF86BB5A1C0]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M00_L09
M00_L14:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M00_L10
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L10
M00_L15:
       mov       rcx,offset MT_System.Int32[]
       call      00007FF8CB84EBA0
       test      rax,rax
       je        near ptr M00_L21
       test      al,2
       jne       near ptr M00_L22
       mov       rcx,[rax+20]
       add       rcx,10
       mov       rdx,[rcx]
M00_L16:
       test      rdx,rdx
       je        near ptr M00_L23
M00_L17:
       mov       [rbp-40],rdx
       lea       rcx,[rbp-30]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-28]
       call      qword ptr [7FF86C326DA8]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-30]
       mov       rdx,20023A92534
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M00_L24
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M00_L12
M00_L18:
       mov       rbx,[rbp-60]
       mov       rcx,20023A91CB8
       mov       rax,[7FF86BB5A1E8]
       call      qword ptr [rax+28]
       mov       rcx,[rbp-30]
       mov       r9d,[rax+8]
       mov       r8d,[rbp-28]
       mov       [rbp-50],r8d
       mov       r8w,[rbp-24]
       mov       [rbp-4C],r8w
       lea       r8,[rbp-50]
       mov       [rsp+20],r8
       mov       r8,rax
       mov       rdx,rbx
       call      qword ptr [7FF86C3277C8]
       jmp       near ptr M00_L12
M00_L19:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L04
M00_L20:
       mov       ecx,1
       jmp       near ptr M00_L05
M00_L21:
       xor       edx,edx
       jmp       near ptr M00_L17
M00_L22:
       mov       rdx,rax
       and       rdx,0FFFFFFFFFFFFFFFD
       add       rdx,8
       mov       rdx,[rdx]
       jmp       near ptr M00_L16
M00_L23:
       mov       rcx,rax
       call      qword ptr [7FF86BC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L24:
       mov       r8d,2
       call      qword ptr [7FF86BD8F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L12
M00_L25:
       cmp       byte ptr [rbp-27],0
       je        near ptr M00_L12
       mov       rbx,[rbp-30]
       mov       rcx,20023A91CB8
       mov       rax,[7FF86BB5A1C0]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD8F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M00_L12
M00_L26:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L27:
       mov       rcx,rbx
       call      qword ptr [7FF86BD8F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L11
M00_L28:
       mov       r9d,[rbx+1C]
       add       r9d,[rbx+18]
       sub       r9d,[r14+8]
       jo        short M00_L26
       mov       r8d,[r14+8]
       mov       [rsp+20],r8d
       movzx     r8d,di
       mov       rcx,rbx
       mov       edx,2B
       call      qword ptr [7FF86C327858]
       jmp       near ptr M00_L12
M00_L29:
       call      M00_L33
       nop
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       r8,[rbp-58]
       mov       [rbp-48],r8
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       add       rsp,70
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L30:
       call      qword ptr [7FF86C4A4648]
       int       3
M00_L31:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C255650]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L32
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L00
M00_L32:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L33:
       sub       rsp,28
       vzeroupper
       mov       rbx,[rbp-30]
       cmp       dword ptr [rbx+20],0
       jge       short M00_L34
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF86BB54000
       call      qword ptr [7FF86BE37798]
       mov       rsi,rax
       call      qword ptr [7FF86C4A7510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF86BE3DB00]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       cmp       qword ptr [rbx+10],0
       jne       short M00_L35
       xor       ecx,ecx
       mov       [rbx+18],rcx
       jmp       near ptr M00_L42
M00_L35:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L36
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C4A75D0]
       jmp       near ptr M00_L42
M00_L36:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C4A75E8]
       mov       rsi,rax
       cmp       rsi,rbx
       je        near ptr M00_L41
       mov       rax,[rbx+8]
       mov       ecx,[rax+8]
       add       ecx,[rbx+1C]
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       short M00_L39
       cmp       ecx,400
       jge       short M00_L37
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M00_L38
M00_L37:
       xor       edx,edx
       call      qword ptr [7FF86C1CF2B8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M00_L38:
       mov       rcx,[rsi+8]
       mov       r8d,[rsi+18]
       mov       rdx,rdi
       call      qword ptr [7FF86BC17048]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       mov       rdx,[rsi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+1C]
       mov       [rbx+1C],ecx
M00_L41:
       mov       ecx,[rsi+1C]
       neg       ecx
       mov       [rbx+18],ecx
M00_L42:
       mov       rdx,1BFA4C00308
       mov       rsi,[rdx]
       mov       rax,[rsi+10]
       mov       rdx,rbx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L44
M00_L43:
       add       rsp,28
       ret
M00_L44:
       cmp       qword ptr [rsi+20],0
       jne       short M00_L46
       lea       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M00_L45
       call      qword ptr [7FF86C4A4648]
       int       3
M00_L45:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FF8CB8421C0
       test      rax,rax
       je        short M00_L43
M00_L46:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M00_L47
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4A7690]
       test      eax,eax
       jne       short M00_L43
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF86C4A76A8]
       jmp       short M00_L43
M00_L47:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M00_L43
; Total bytes of code 1605
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M01_L08
M01_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M01_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M01_L09
M01_L01:
       test      rdi,rdi
       jne       near ptr M01_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L10
M01_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M01_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD51B50
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M01_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M01_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M01_L11
M01_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M01_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C4AC2B8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C4A40F0]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BC17C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vzeroupper
       cmp       [rcx],cl
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M02_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M02_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L15
M02_L01:
       cmp       ebx,1D
       ja        short M02_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M02_L16
M02_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M02_L03:
       test      r14d,r14d
       jne       near ptr M02_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M02_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M02_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M02_L04:
       test      eax,eax
       jne       near ptr M02_L11
       cmp       rdi,rsi
       jne       near ptr M02_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M02_L05:
       cmp       [rbx],rsi
       jne       near ptr M02_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L21
       mov       rcx,[rsp+28]
M02_L06:
       cmp       ebx,1D
       ja        short M02_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M02_L22
M02_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M02_L08:
       test      ebp,ebp
       jne       near ptr M02_L20
       cmp       [rcx],rsi
       jne       near ptr M02_L24
M02_L09:
       test      rcx,rcx
       je        near ptr M02_L25
       call      00007FF8CB849400
M02_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M02_L27
M02_L11:
       cmp       rdi,rsi
       jne       near ptr M02_L29
       mov       rcx,[rbp+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L28
M02_L12:
       cmp       edi,1B
       je        near ptr M02_L27
M02_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M02_L00
M02_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L01
M02_L16:
       mov       r14d,1
       jmp       near ptr M02_L03
M02_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M02_L03
M02_L18:
       xor       eax,eax
       jmp       near ptr M02_L04
M02_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M02_L04
M02_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M02_L05
M02_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M02_L06
M02_L22:
       mov       ebp,1
       jmp       near ptr M02_L08
M02_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M02_L08
M02_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M02_L09
M02_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF86C32EF88]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C32EFA0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M02_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M02_L10
M02_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L12
M02_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M02_L27
       jmp       near ptr M02_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD84B28]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M04_L04
       cmp       r8,40
       ja        near ptr M04_L07
M04_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L03
M04_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L02:
       vzeroupper
       ret
M04_L03:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L01
M04_L04:
       test      r8b,18
       je        short M04_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L02
M04_L05:
       test      r8b,4
       je        short M04_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L02
M04_L06:
       test      r8,r8
       je        short M04_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L02
M04_L07:
       cmp       r8,800
       ja        short M04_L11
       cmp       r8,100
       jb        short M04_L08
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
M04_L08:
       mov       r9,r8
       shr       r9,6
M04_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L02
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF86BC166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 323
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M05_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       rsi,rax
M05_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M05_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M05_L03
       cmp       [rdx+8],r8d
       jb        short M05_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M05_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M05_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rax,20023A80008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF86BB54000
       call      qword ptr [7FF86BE37798]
       mov       rbx,rax
       call      qword ptr [7FF86C4A7048]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86BE3DB00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
; 		if (type.IsGenericType)
; 		^^^^^^^^^^^^^^^^^^^^^^^
; 			var genericArguments = type.GetGenericArguments();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		else if (type.IsArray)
; 		     ^^^^^^^^^^^^^^^^^
; 			ProcessType(builder, type.GetElementType()!, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = builder.Append("[]");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		else if (type.IsGenericParameter)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (options.IncludeGenericParameterNames)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = builder.Append(type.Name);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			AppendSimpleTypeName(builder, type, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L00:
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,50
       vzeroupper
       xor       eax,eax
       mov       [rsp+48],rax
       mov       [rsp+90],rcx
       mov       [rsp+0A0],r8
       mov       rbx,rdx
       mov       rcx,[rbx]
       mov       rbp,offset MT_System.RuntimeType
       cmp       [rcx],rbp
       jne       near ptr M06_L35
       mov       rax,[rcx+18]
       test      al,2
       jne       near ptr M06_L34
       test      dword ptr [rax],80000000
       je        short M06_L01
       xor       edx,edx
       jmp       short M06_L02
M06_L01:
       test      byte ptr [rax],30
       setne     dl
       movzx     edx,dl
M06_L02:
       movzx     r14d,dl
M06_L03:
       test      r14d,r14d
       jne       near ptr M06_L36
       mov       [rsp+98],rbx
       mov       r14,[rbx]
       mov       [rsp+30],r14
       cmp       [r14],rbp
       jne       near ptr M06_L39
       mov       rcx,[r14+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M06_L37
M06_L04:
       cmp       ebx,14
       je        near ptr M06_L38
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M06_L05:
       test      eax,eax
       jne       near ptr M06_L22
       mov       rbx,[rsp+98]
       mov       rcx,[rbx]
       cmp       [rcx],rbp
       jne       near ptr M06_L57
       call      00007FF8CB848F60
M06_L06:
       test      eax,eax
       jne       near ptr M06_L58
       mov       rsi,[rsp+90]
       mov       rsi,[rsi]
       mov       rbx,[rbx]
       mov       rdi,[rsp+0A0]
       movzx     ecx,byte ptr [rdi]
       movzx     edi,word ptr [rdi+4]
       test      ecx,ecx
       je        near ptr M06_L20
       mov       r14,[rbx]
       cmp       r14,rbp
       jne       near ptr M06_L59
       cmp       qword ptr [rbx+10],0
       je        short M06_L07
       mov       rcx,[rbx+10]
       mov       r15,[rcx]
       test      r15,r15
       jne       short M06_L09
M06_L07:
       mov       rcx,rbx
       call      qword ptr [7FF86BC17C48]; System.RuntimeType.InitializeCache()
       mov       r13,rax
M06_L08:
       mov       rax,[r13+20]
       test      rax,rax
       jne       short M06_L11
       mov       rcx,[r13+8]
       call      qword ptr [7FF86BD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M06_L10
       xor       eax,eax
       jmp       short M06_L11
M06_L09:
       mov       r13,r15
       jmp       short M06_L08
M06_L10:
       lea       rdx,[r13+20]
       mov       rcx,r13
       mov       r8d,3
       call      qword ptr [7FF86BD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M06_L11:
       test      rax,rax
       je        near ptr M06_L20
       cmp       r14,rbp
       jne       near ptr M06_L60
       cmp       qword ptr [rbx+10],0
       je        short M06_L12
       mov       rcx,[rbx+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       short M06_L14
M06_L12:
       mov       rcx,rbx
       call      qword ptr [7FF86BC17C48]; System.RuntimeType.InitializeCache()
       mov       rbx,rax
M06_L13:
       mov       rbp,[rbx+20]
       test      rbp,rbp
       jne       short M06_L16
       mov       rcx,[rbx+8]
       call      qword ptr [7FF86BD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M06_L15
       xor       ebp,ebp
       jmp       short M06_L16
M06_L14:
       mov       rbx,r14
       jmp       short M06_L13
M06_L15:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       call      qword ptr [7FF86BD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbp,rax
M06_L16:
       cmp       [rsi],sil
       test      rbp,rbp
       je        short M06_L18
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       test      r8d,r8d
       je        short M06_L18
       mov       rcx,[rsi+8]
       mov       eax,[rsi+18]
       lea       r14d,[rax+r8]
       cmp       r14d,[rcx+8]
       ja        near ptr M06_L61
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M06_L21
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M06_L17:
       mov       [rsi+18],r14d
M06_L18:
       cmp       edi,2B
       jne       near ptr M06_L62
M06_L19:
       add       rsp,50
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L20:
       mov       rcx,rbx
       mov       r14,[rbx]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rbp,rax
       jmp       short M06_L16
M06_L21:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M06_L17
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M06_L17
M06_L22:
       mov       rbx,[rsp+98]
       mov       rbx,[rbx]
       cmp       [rbx],rbp
       jne       near ptr M06_L43
       mov       rcx,[rbx+18]
       call      00007FF8CB84EBA0
       test      rax,rax
       je        near ptr M06_L40
       test      al,2
       jne       near ptr M06_L41
       mov       rcx,[rax+20]
       add       rcx,10
       mov       r14,[rcx]
M06_L23:
       test      r14,r14
       je        near ptr M06_L42
M06_L24:
       cmp       [r14],rbp
       jne       near ptr M06_L45
       mov       rcx,[r14+18]
       test      cl,2
       jne       near ptr M06_L44
       mov       ecx,[rcx]
       test      ecx,80000000
       je        short M06_L25
       xor       eax,eax
       jmp       short M06_L26
M06_L25:
       test      cl,30
       setne     al
       movzx     eax,al
M06_L26:
       movzx     ebx,al
M06_L27:
       test      ebx,ebx
       jne       near ptr M06_L46
       cmp       [r14],rbp
       jne       near ptr M06_L49
       mov       [rsp+38],r14
       mov       rcx,[r14+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       r14,[rsp+38]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M06_L47
M06_L28:
       cmp       ebx,14
       je        near ptr M06_L48
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M06_L29:
       test      eax,eax
       jne       near ptr M06_L32
       cmp       [r14],rbp
       jne       near ptr M06_L53
       mov       rcx,r14
       call      00007FF8CB848F60
M06_L30:
       test      eax,eax
       jne       near ptr M06_L54
       mov       rsi,[rsp+90]
       mov       rcx,[rsi]
       mov       rdi,[rsp+0A0]
       mov       r8d,[rdi]
       mov       [rsp+40],r8d
       mov       r8w,[rdi+4]
       mov       [rsp+44],r8w
       lea       r8,[rsp+40]
       mov       rdx,r14
       call      qword ptr [7FF86C3277F8]; DotNetTips.Spargine.Core.TypeHelper.AppendSimpleTypeName(System.Text.StringBuilder, System.Type, DotNetTips.Spargine.Core.DisplayNameOptions)
M06_L31:
       xor       ecx,ecx
       mov       [rsp+48],rcx
       mov       rcx,[rsi]
       mov       rdx,20023A92534
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M06_L56
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M06_L19
M06_L32:
       mov       rsi,[rsp+90]
       mov       rdi,[rsp+0A0]
       cmp       [r14],rbp
       jne       near ptr M06_L51
       mov       rcx,[r14+18]
       call      00007FF8CB84EBA0
       test      rax,rax
       je        near ptr M06_L50
       mov       rcx,rax
       call      qword ptr [7FF86BC15860]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       nop
M06_L33:
       mov       [rsp+48],rax
       lea       rdx,[rsp+48]
       mov       rcx,rsi
       mov       r8,rdi
       call      qword ptr [7FF86C326DA8]
       mov       rcx,[rsi]
       mov       rdx,20023A92534
       mov       r8,[rcx+8]
       mov       eax,[rcx+18]
       lea       r10d,[rax+2]
       cmp       [r8+8],r10d
       jb        near ptr M06_L52
       movsxd    rdx,eax
       lea       rdx,[r8+rdx*2+10]
       mov       word ptr [rdx],5B
       mov       word ptr [rdx+2],5D
       mov       [rcx+18],r10d
       jmp       near ptr M06_L31
M06_L34:
       xor       edx,edx
       jmp       near ptr M06_L02
M06_L35:
       mov       rax,[rcx]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       r14d,eax
       jmp       near ptr M06_L03
M06_L36:
       mov       rcx,[rbx]
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rsi,[rsp+90]
       mov       rcx,[rsi]
       mov       rdx,[rbx]
       mov       r9d,[rax+8]
       mov       rdi,[rsp+0A0]
       mov       r8d,[rdi]
       mov       [rsp+40],r8d
       mov       r8w,[rdi+4]
       mov       [rsp+44],r8w
       lea       r8,[rsp+40]
       mov       [rsp+20],r8
       mov       r8,rax
       call      qword ptr [7FF86C3277C8]
       jmp       near ptr M06_L19
M06_L37:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L04
M06_L38:
       mov       eax,1
       jmp       near ptr M06_L05
M06_L39:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M06_L05
M06_L40:
       xor       r14d,r14d
       jmp       near ptr M06_L24
M06_L41:
       mov       rcx,rax
       and       rcx,0FFFFFFFFFFFFFFFD
       add       rcx,8
       mov       r14,[rcx]
       jmp       near ptr M06_L23
M06_L42:
       mov       rcx,rax
       call      qword ptr [7FF86BC15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       mov       r14,rax
       jmp       near ptr M06_L24
M06_L43:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M06_L24
M06_L44:
       xor       eax,eax
       jmp       near ptr M06_L26
M06_L45:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       ebx,eax
       jmp       near ptr M06_L27
M06_L46:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rsi,[rsp+90]
       mov       rcx,[rsi]
       mov       r9d,[rax+8]
       mov       rdi,[rsp+0A0]
       mov       edx,[rdi]
       mov       [rsp+40],edx
       mov       dx,[rdi+4]
       mov       [rsp+44],dx
       lea       rdx,[rsp+40]
       mov       [rsp+20],rdx
       mov       rdx,r14
       mov       r8,rax
       call      qword ptr [7FF86C3277C8]
       jmp       near ptr M06_L31
M06_L47:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M06_L28
M06_L48:
       mov       eax,1
       jmp       near ptr M06_L29
M06_L49:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M06_L29
M06_L50:
       xor       eax,eax
       jmp       near ptr M06_L33
M06_L51:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       jmp       near ptr M06_L33
M06_L52:
       mov       r8d,2
       call      qword ptr [7FF86BD8F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M06_L31
M06_L53:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M06_L30
M06_L54:
       mov       rdi,[rsp+0A0]
       cmp       byte ptr [rdi+1],0
       je        short M06_L55
       mov       rsi,[rsp+90]
       mov       rbp,[rsi]
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD8F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L31
M06_L55:
       mov       rsi,[rsp+90]
       jmp       near ptr M06_L31
M06_L56:
       mov       r8d,2
       call      qword ptr [7FF86BD8F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M06_L19
M06_L57:
       mov       rax,[rcx]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M06_L06
M06_L58:
       mov       rdi,[rsp+0A0]
       cmp       byte ptr [rdi+1],0
       je        near ptr M06_L19
       mov       rsi,[rsp+90]
       mov       rsi,[rsi]
       mov       rcx,[rbx]
       mov       r14,[rcx]
       mov       rax,[r14+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD8F228]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M06_L19
M06_L59:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+20]
       jmp       near ptr M06_L11
M06_L60:
       mov       rcx,rbx
       mov       rax,[r14+50]
       call      qword ptr [rax+20]
       mov       rbp,rax
       jmp       near ptr M06_L16
M06_L61:
       mov       rcx,rsi
       call      qword ptr [7FF86BD8F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M06_L18
M06_L62:
       mov       r9d,[rsi+1C]
       add       r9d,[rsi+18]
       sub       r9d,[rbp+8]
       jo        short M06_L63
       mov       r8d,[rbp+8]
       mov       [rsp+20],r8d
       mov       r8d,edi
       mov       rcx,rsi
       mov       edx,2B
       call      qword ptr [7FF86C327858]
       jmp       near ptr M06_L19
M06_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1752
```
```assembly
; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       lea       rbp,[rsp+0D0]
       xor       eax,eax
       mov       [rbp-40],rax
       mov       [rbp-0A0],rcx
       lea       rdx,[rbp-40]
       mov       [rbp-0A8],rdx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF8AC229030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       mov       rdx,[rbp-0A8]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF8AC229038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rax,[rbp-40]
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 124
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
       jg        near ptr M08_L05
       cmp       eax,esi
       jl        near ptr M08_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M08_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M08_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M08_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M08_L00:
       cmp       ebp,edx
       ja        near ptr M08_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M08_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M08_L08
       cmp       edx,esi
       jl        near ptr M08_L08
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
       jl        near ptr M08_L09
       cmp       eax,400
       jge       short M08_L02
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M08_L03
M08_L02:
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FF86C1CF2B8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M08_L03:
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
       je        near ptr M08_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M08_L04:
       cmp       esi,r8d
       ja        near ptr M08_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M08_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FF86BB54000
       call      qword ptr [7FF86BE37798]
       mov       rsi,rax
       call      qword ptr [7FF86C4A74F8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF86BE3DB00]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L06:
       test      ecx,ecx
       jne       short M08_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M08_L00
M08_L07:
       call      qword ptr [7FF86BD87198]
       int       3
M08_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FF86BB54000
       call      qword ptr [7FF86BE37798]
       mov       rsi,rax
       call      qword ptr [7FF86C4A7510]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF86BE3DB00]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86C4A7528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M08_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M08_L04
M08_L11:
       call      qword ptr [7FF86C05D218]
       int       3
; Total bytes of code 621
```
```assembly
; System.Text.StringBuilder.Append(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rdx,rdx
       je        short M09_L01
       lea       rax,[rdx+0C]
       mov       r8d,[rdx+8]
       test      r8d,r8d
       je        short M09_L01
       mov       rcx,[rbx+8]
       mov       edx,[rbx+18]
       lea       esi,[rdx+r8]
       cmp       esi,[rcx+8]
       ja        short M09_L03
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+10]
       cmp       r8d,2
       jle       short M09_L02
       mov       r8d,r8d
       add       r8,r8
       mov       rdx,rax
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M09_L00:
       mov       [rbx+18],esi
M09_L01:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       movzx     edx,word ptr [rax]
       mov       [rcx],dx
       cmp       r8d,2
       jne       short M09_L00
       movzx     eax,word ptr [rax+2]
       mov       [rcx+2],ax
       jmp       short M09_L00
M09_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF86BD8F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       short M09_L01
; Total bytes of code 121
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
       call      qword ptr [7FF8AC24EA60]; Precode of System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M10_L01
       cmp       qword ptr [rdi+10],0
       je        short M10_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M10_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M10_L01:
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
       call      qword ptr [7FF8AC229030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FF8AC229038]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       short M12_L01
       xor       ebp,ebp
       xor       r14d,r14d
M12_L00:
       test      rbx,rbx
       jne       near ptr M12_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M12_L10
M12_L01:
       test      rbx,rbx
       jne       short M12_L04
       mov       rcx,7FF86C3CED1C
       call      CORINFO_HELP_COUNTPROFILE32
M12_L02:
       mov       rcx,7FF86C3CED24
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M12_L08
       xor       r14d,r14d
M12_L03:
       mov       rbp,rsi
       jmp       short M12_L00
M12_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M12_L05
       mov       rcx,7FF86C3CED18
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L02
M12_L05:
       cmp       dword ptr [r15+4],18
       je        short M12_L06
       mov       rcx,7FF86C3CED14
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L02
M12_L06:
       cmp       edi,[rsi+8]
       jbe       short M12_L07
       mov       rcx,7FF86C3CED10
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M12_L02
M12_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M12_L13
       mov       rcx,7FF86C3CED0C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M12_L02
M12_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M12_L03
M12_L09:
       mov       rcx,7FF86C3CED28
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M12_L12
       xor       r15d,r15d
M12_L10:
       mov       rcx,7FF86C3CED2C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FF86C256790]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M12_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M12_L10
M12_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M12_L15
       mov       rcx,7FF86C3CED08
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M12_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M12_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M12_L11
M12_L14:
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
       jmp       qword ptr [7FF86C1CEB68]
M12_L15:
       mov       rcx,7FF86C3CED20
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M12_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M12_L11
M12_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M12_L11
; Total bytes of code 488
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetTypeDisplayNameFullParameters()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+0F0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rcx,250EEA81CB8
       mov       [rbp-40],rcx
       mov       rcx,[rbp-40]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       [rbp-40],rcx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,21059C00C88
       mov       rsi,[rcx]
       mov       rcx,21059C00C90
       mov       rdi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L12
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L12
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L14
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L14
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M00_L14
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rdi+9D],0
       jne       near ptr M00_L13
M00_L01:
       mov       [rbp-60],r14
       lea       rcx,[r14+10]
       mov       eax,[r14+8]
       mov       [rbp-50],rcx
       mov       [rbp-48],eax
       xor       ecx,ecx
       mov       [rbp-58],ecx
       mov       byte ptr [rbp-54],0
       mov       rcx,[rbp-40]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L29
       mov       rcx,[rbp-40]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L28
       mov       rsi,[rax]
       test      rsi,rsi
       je        near ptr M00_L28
M00_L02:
       mov       rdx,[rsi+28]
       test      rdx,rdx
       jne       short M00_L03
       mov       rcx,[rsi+8]
       call      qword ptr [7FF86BD84AF8]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       je        near ptr M00_L10
       lea       rdx,[rsi+28]
       mov       rcx,rsi
       mov       r8d,7
       call      qword ptr [7FF86BD84B10]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
M00_L03:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M00_L30
       test      rdx,rdx
       je        near ptr M00_L30
       mov       r8d,[rbp-58]
       mov       ecx,[rbp-48]
       cmp       r8d,ecx
       ja        near ptr M00_L34
       mov       rax,[rbp-50]
       mov       r10d,r8d
       lea       rax,[rax+r10*2]
       sub       ecx,r8d
       mov       esi,[rdx+8]
       cmp       esi,ecx
       ja        near ptr M00_L30
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       esi,[rbp-58]
       mov       [rbp-58],esi
M00_L04:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M00_L34
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L31
       mov       rsi,250EEA70658
       mov       word ptr [rax],2E
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M00_L05:
       cmp       byte ptr [rbp-54],0
       jne       near ptr M00_L32
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M00_L34
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       cmp       edx,12
       jb        near ptr M00_L32
       vmovups   ymm0,[7FF86C44BA40]
       vmovups   [rax],ymm0
       mov       dword ptr [rax+20],65006D
       mov       ecx,[rbp-58]
       add       ecx,12
       mov       [rbp-58],ecx
M00_L06:
       mov       ecx,[rbp-58]
       mov       edx,[rbp-48]
       cmp       ecx,edx
       ja        near ptr M00_L34
       mov       rax,[rbp-50]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L33
       mov       word ptr [rax],2E
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M00_L07:
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FF86C326928]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Boolean, System.Private.CoreLib]](Boolean)
       mov       r8d,[rbp-58]
       cmp       r8d,[rbp-48]
       ja        near ptr M00_L34
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-98],xmm0
       mov       rdx,[rbp-50]
       mov       ecx,r8d
       lea       rdx,[rdx+rcx*2]
       mov       ecx,[rbp-48]
       sub       ecx,r8d
       mov       r8d,ecx
       lea       rcx,[rbp-98]
       call      qword ptr [7FF86C4ACE10]; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rbp-98]
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       lea       rdx,[rbp-0B0]
       mov       rcx,rsi
       call      qword ptr [7FF86C4ACE28]; System.String.TryCopyTo(System.Span`1<Char>)
       test      eax,eax
       je        near ptr M00_L35
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M00_L08:
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FF86C326928]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Boolean, System.Private.CoreLib]](Boolean)
       lea       rcx,[rbp-68]
       mov       rdx,rsi
       call      qword ptr [7FF86BE34E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-68]
       mov       edx,1
       call      qword ptr [7FF86C326928]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Boolean, System.Private.CoreLib]](Boolean)
       lea       rcx,[rbp-68]
       mov       rdx,rsi
       call      qword ptr [7FF86BE34E88]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       lea       rcx,[rbp-68]
       mov       edx,2E
       call      qword ptr [7FF86BE34DB0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       lea       rcx,[rbp-68]
       call      qword ptr [7FF86BE34EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rsi,rax
       mov       rcx,2106FC002E8
       mov       rcx,[rcx]
       lea       r9,[rbp-70]
       mov       r8,rsi
       mov       rdx,7FF86C3533F8
       call      qword ptr [7FF86C326940]; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L36
       mov       rdi,[rbp-70]
M00_L09:
       xor       ecx,ecx
       mov       [rbp-70],rcx
       mov       [rbp-78],rcx
       mov       [rbp-0A0],rdi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-0A0]
       mov       rdx,7FF86C3A45C8
       cmp       [rcx],ecx
       call      qword ptr [7FF86C327A08]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L10:
       xor       edx,edx
       jmp       near ptr M00_L03
M00_L11:
       call      qword ptr [7FF86C1CED48]
       mov       ecx,2643
       mov       rdx,7FF86BEF4F20
       call      qword ptr [7FF86BE37798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEF4F20
       call      qword ptr [7FF86BE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BEF4F20
       call      qword ptr [7FF86BE37798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC17858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C4ACBA0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C32F678]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L12:
       mov       ecx,3
       call      qword ptr [7FF86C32EFE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L13:
       mov       rcx,r14
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FF86C4A77F8]
       jmp       near ptr M00_L01
M00_L14:
       mov       rcx,[rsi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L26
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L25
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF86BC15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF86BB5B1A4],0
       je        short M00_L15
       call      qword ptr [7FF86C4A7810]
       mov       r15d,eax
       jmp       short M00_L17
M00_L15:
       mov       ecx,0B
       call      qword ptr [7FF86C4A7828]
       mov       r15d,[rax+10]
       mov       ecx,0B
       call      qword ptr [7FF86C4A7828]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M00_L16
       call      qword ptr [7FF86C4A7840]
       mov       r15d,eax
       jmp       short M00_L17
M00_L16:
       sar       r15d,10
M00_L17:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF86BC15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FF86BB5B198]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M00_L21
M00_L18:
       cmp       r15d,[r14+8]
       jae       near ptr M00_L37
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rbp-0B8],rax
       mov       rcx,r12
       call      qword ptr [7FF86C14E448]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L19
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rbp-0B8],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M00_L19:
       mov       rcx,r12
       call      qword ptr [7FF86BC16820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rbp-0B8]
       test      r12,r12
       jne       short M00_L22
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M00_L20
       xor       r15d,r15d
M00_L20:
       inc       r13d
M00_L21:
       cmp       [r14+8],r13d
       jg        near ptr M00_L18
       jmp       short M00_L23
M00_L22:
       mov       r14,r12
       jmp       short M00_L24
M00_L23:
       xor       r14d,r14d
M00_L24:
       test      r14,r14
       je        short M00_L25
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L01
       mov       rcx,r14
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rsi
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rdi
       call      qword ptr [7FF86C4A77F8]
       jmp       near ptr M00_L01
M00_L25:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rdi+9D],0
       je        near ptr M00_L01
       jmp       short M00_L27
M00_L26:
       mov       ecx,100
       mov       rdx,250EEA76F28
       call      qword ptr [7FF86BE3DAD0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L25
M00_L27:
       mov       rcx,r14
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rsi
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rdi
       call      qword ptr [7FF86C4A77F8]
       mov       rcx,rsi
       call      qword ptr [7FF86C05D8C0]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rsi+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rdi
       mov       edx,r15d
       mov       r8d,100
       call      qword ptr [7FF86C4A7858]
       jmp       near ptr M00_L01
M00_L28:
       call      qword ptr [7FF86BC17C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       near ptr M00_L02
M00_L29:
       mov       rcx,[rbp-40]
       mov       rax,[rbp-40]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M00_L03
M00_L30:
       lea       rcx,[rbp-68]
       call      qword ptr [7FF86C3269E8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M00_L04
M00_L31:
       lea       rcx,[rbp-68]
       mov       rsi,250EEA70658
       mov       rdx,rsi
       call      qword ptr [7FF86C324378]
       jmp       near ptr M00_L05
M00_L32:
       lea       rcx,[rbp-68]
       mov       rdx,250EEA81CE0
       call      qword ptr [7FF86C3269E8]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       near ptr M00_L06
M00_L33:
       lea       rcx,[rbp-68]
       mov       rdx,rsi
       call      qword ptr [7FF86C324378]
       jmp       near ptr M00_L07
M00_L34:
       call      qword ptr [7FF86BD87198]
       int       3
M00_L35:
       lea       rcx,[rbp-68]
       mov       rdx,rsi
       call      qword ptr [7FF86C324378]
       jmp       near ptr M00_L08
M00_L36:
       mov       rcx,2106FC00308
       mov       rcx,[rcx]
       call      qword ptr [7FF86C22F6B0]; Precode of Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].Get()
       mov       [rbp-78],rax
       xor       ecx,ecx
       mov       [rbp-80],ecx
       mov       [rbp-7C],cx
       mov       dword ptr [rsp+20],2E
       lea       rcx,[rbp-80]
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FF86C3269A0]; DotNetTips.Spargine.Core.DisplayNameOptions..ctor(Boolean, Boolean, Boolean, Char)
       mov       ecx,[rbp-80]
       mov       [rbp-88],ecx
       mov       cx,[rbp-7C]
       mov       [rbp-84],cx
       lea       rcx,[rbp-78]
       lea       rdx,[rbp-40]
       lea       r8,[rbp-88]
       call      qword ptr [7FF86C3269B8]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-78]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BE02200]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       mov       ecx,5
       call      qword ptr [7FF86C3269D0]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,2106FC002E8
       mov       rcx,[rcx]
       mov       r8,rsi
       mov       r9,rdi
       mov       rdx,7FF86C353510
       call      qword ptr [7FF86C326970]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       nop
       mov       rcx,[rbp-78]
       mov       rsi,rcx
       cmp       [rsi],sil
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FF86C255338]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,2106FC00308
       mov       rcx,[rcx]
       mov       rdx,rsi
       call      qword ptr [7FF86C255350]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       jmp       near ptr M00_L09
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,38
       mov       rdi,[rbp-78]
       cmp       [rdi],dil
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C255338]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,2106FC00308
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FF86C255350]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       vzeroupper
       add       rsp,38
       ret
; Total bytes of code 2167
```
```assembly
; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,40
       vzeroupper
       cmp       [rcx],cl
       mov       rbx,rcx
       mov       rsi,offset MT_System.RuntimeType
M01_L00:
       mov       rdi,[rbx]
       cmp       rdi,rsi
       jne       near ptr M01_L17
       mov       [rsp+30],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L15
M01_L01:
       cmp       ebx,1D
       ja        short M01_L02
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M01_L16
M01_L02:
       cmp       ebx,10
       sete      r14b
       movzx     r14d,r14b
M01_L03:
       test      r14d,r14d
       jne       near ptr M01_L14
       mov       [rsp+38],rbp
       cmp       rdi,rsi
       jne       near ptr M01_L19
       mov       rcx,[rbp+18]
       test      cl,2
       jne       near ptr M01_L18
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      al
       movzx     eax,al
M01_L04:
       test      eax,eax
       jne       near ptr M01_L11
       cmp       rdi,rsi
       jne       near ptr M01_L26
       mov       rbx,rbp
       mov       rbp,[rsp+38]
M01_L05:
       cmp       [rbx],rsi
       jne       near ptr M01_L23
       mov       [rsp+28],rbx
       mov       rcx,[rbx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L21
       mov       rcx,[rsp+28]
M01_L06:
       cmp       ebx,1D
       ja        short M01_L07
       mov       eax,1FEF7FFF
       bt        eax,ebx
       jae       near ptr M01_L22
M01_L07:
       cmp       ebx,10
       sete      bpl
       movzx     ebp,bpl
M01_L08:
       test      ebp,ebp
       jne       near ptr M01_L20
       cmp       [rcx],rsi
       jne       near ptr M01_L24
M01_L09:
       test      rcx,rcx
       je        near ptr M01_L25
       call      00007FF8CB849400
M01_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M01_L27
M01_L11:
       cmp       rdi,rsi
       jne       near ptr M01_L29
       mov       rcx,[rbp+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L28
M01_L12:
       cmp       edi,1B
       je        near ptr M01_L27
M01_L13:
       mov       eax,1
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L14:
       mov       rcx,rbp
       mov       rax,[rdi+68]
       call      qword ptr [rax+8]
       mov       rbp,rax
       mov       rbx,rbp
       jmp       near ptr M01_L00
M01_L15:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L01
M01_L16:
       mov       r14d,1
       jmp       near ptr M01_L03
M01_L17:
       mov       rcx,rbx
       mov       rax,[rdi+68]
       call      qword ptr [rax]
       mov       r14d,eax
       mov       rbp,rbx
       jmp       near ptr M01_L03
M01_L18:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L19:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L04
M01_L20:
       mov       rax,[rcx]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       rbx,rax
       mov       rbp,[rsp+38]
       jmp       near ptr M01_L05
M01_L21:
       call      CORINFO_HELP_POLL_GC
       mov       rcx,[rsp+28]
       jmp       near ptr M01_L06
M01_L22:
       mov       ebp,1
       jmp       near ptr M01_L08
M01_L23:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       rcx,rbx
       mov       ebp,eax
       jmp       near ptr M01_L08
M01_L24:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L09
M01_L25:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF86C32F660]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FF86C32F678]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       mov       rcx,rbp
       mov       rax,[rdi+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L10
M01_L27:
       xor       eax,eax
       add       rsp,40
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L28:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L12
M01_L29:
       mov       rcx,rbp
       mov       rax,[rdi+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M01_L27
       jmp       near ptr M01_L13
; Total bytes of code 663
```
```assembly
; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       push      rsi
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rdx
       mov       rcx,[rcx+8]
       mov       [rsp+20],rcx
       lea       rcx,[rsp+20]
       mov       edx,r8d
       call      qword ptr [7FF86BD84B28]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
       mov       rsi,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 63
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L02
       test      r8b,18
       jne       short M03_L01
       test      r8b,4
       jne       near ptr M03_L08
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
M03_L00:
       vzeroupper
       ret
M03_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L00
       nop       word ptr [rax+rax]
M03_L02:
       cmp       r8,40
       jbe       short M03_L05
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jb        short M03_L03
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
M03_L03:
       mov       r9,r8
       shr       r9,6
M03_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L04
       and       r8,3F
       cmp       r8,10
       jbe       short M03_L06
M03_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L06
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L07
M03_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M03_L00
M03_L07:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L06
M03_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M03_L00
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF86BC166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 332
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Boolean, System.Private.CoreLib]](Boolean)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M04_L00
       mov       r8,250EEA701E0
       mov       rcx,250EEA701C0
       test      dl,dl
       mov       rdx,rcx
       cmovne    rdx,r8
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M04_L01
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M04_L02
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       movzx     edx,dl
       mov       rcx,rbx
       xor       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C4A7E70]
M04_L01:
       call      qword ptr [7FF86BD87198]
       int       3
M04_L02:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C324378]
; Total bytes of code 150
```
```assembly
; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
```
```assembly
; System.String.TryCopyTo(System.Span`1<Char>)
       sub       rsp,28
       mov       rax,rcx
       xor       r10d,r10d
       mov       r8d,[rax+8]
       cmp       r8d,[rdx+8]
       jg        short M06_L00
       add       r8,r8
       mov       rcx,[rdx]
       lea       rdx,[rax+0C]
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,1
M06_L00:
       mov       eax,r10d
       add       rsp,28
       ret
; Total bytes of code 50
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendLiteral(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M07_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M07_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FF86BD87198]
       int       3
M07_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FF86C324378]
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Int32, System.Private.CoreLib]](Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       near ptr M08_L10
M08_L00:
       lea       rax,[rbx+18]
       mov       ecx,[rbx+10]
       mov       edi,[rax+8]
       cmp       ecx,edi
       ja        near ptr M08_L16
       mov       rax,[rax]
       mov       edx,ecx
       lea       rbp,[rax+rdx*2]
       sub       edi,ecx
       mov       rcx,[rbx]
       test      esi,esi
       jl        near ptr M08_L11
       mov       ecx,esi
       or        ecx,1
       xor       eax,eax
       lzcnt     eax,ecx
       xor       eax,1F
       mov       ecx,esi
       mov       rdx,7FF8AB5BC3D8
       add       rcx,[rdx+rax*8]
       sar       rcx,20
       cmp       ecx,edi
       jg        near ptr M08_L07
       mov       [rsp+50],ecx
       mov       [rsp+48],rbp
       movsxd    rax,ecx
       lea       rax,[rbp+rax*2]
       mov       ecx,esi
       cmp       ecx,0A
       jb        near ptr M08_L06
       cmp       esi,64
       jb        short M08_L02
       mov       rdx,250EEA71234
M08_L01:
       add       rax,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      r10d,r8d,64
       sub       ecx,r10d
       mov       r10,rdx
       shl       ecx,2
       mov       ecx,[r10+rcx]
       mov       [rax],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M08_L01
M08_L02:
       cmp       ecx,0A
       jb        short M08_L06
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,250EEA71234
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M08_L03:
       xor       eax,eax
       mov       [rsp+48],rax
       mov       ebp,1
M08_L04:
       xor       eax,eax
       mov       [rsp+48],rax
M08_L05:
       test      ebp,ebp
       jne       short M08_L08
       mov       rcx,rbx
       call      qword ptr [7FF86C2565B0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.Grow()
       jmp       near ptr M08_L00
M08_L06:
       add       ecx,30
       mov       [rax-2],cx
       jmp       short M08_L03
M08_L07:
       xor       eax,eax
       mov       [rsp+50],eax
       xor       ebp,ebp
       jmp       short M08_L04
M08_L08:
       mov       eax,[rsp+50]
       add       [rbx+10],eax
M08_L09:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M08_L10:
       mov       rcx,rbx
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FF86C4A7D08]
       jmp       short M08_L09
M08_L11:
       test      rcx,rcx
       je        short M08_L12
       call      qword ptr [7FF86C1C5788]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       jmp       short M08_L13
M08_L12:
       call      qword ptr [7FF86BE35DD0]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
M08_L13:
       mov       r8,[rax+28]
       test      r8,r8
       jne       short M08_L14
       xor       r9d,r9d
       xor       ecx,ecx
       jmp       short M08_L15
M08_L14:
       lea       r9,[r8+0C]
       mov       ecx,[r8+8]
M08_L15:
       mov       [rsp+38],r9
       mov       [rsp+40],ecx
       mov       [rsp+28],rbp
       mov       [rsp+30],edi
       lea       r8,[rsp+50]
       mov       [rsp+20],r8
       lea       r8,[rsp+38]
       lea       r9,[rsp+28]
       mov       ecx,esi
       mov       edx,0FFFFFFFF
       call      qword ptr [7FF86C4ACBD0]
       mov       ebp,eax
       jmp       near ptr M08_L05
M08_L16:
       call      qword ptr [7FF86BD87198]
       int       3
; Total bytes of code 434
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rbx,rcx
       lea       rsi,[rbx+18]
       mov       rcx,rsi
       mov       eax,[rbx+10]
       cmp       eax,[rcx+8]
       ja        short M09_L01
       mov       rcx,[rcx]
       mov       [rsp+20],rcx
       mov       [rsp+28],eax
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rdi,rax
       mov       rdx,[rbx+8]
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       [rsi],rcx
       mov       [rsi+8],rcx
       mov       [rbx+10],ecx
       test      rdx,rdx
       je        short M09_L00
       mov       rcx,21059C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FF86BEDFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M09_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M09_L01:
       call      qword ptr [7FF86BD87198]
       int       3
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return this.TryGetValueCore(key, out value);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+50],rdx
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rdi,r9
       test      rbx,rbx
       je        near ptr M10_L48
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M10_L48
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M10_L50
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M10_L52
M10_L00:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M10_L51
       mov       rax,7FF8AB5B6BF0
       test      byte ptr [rax+rcx],80
       jne       near ptr M10_L52
M10_L01:
       mov       rcx,[rsi+18]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M10_L09
M10_L02:
       mov       rsi,[rbp+10]
       test      rbx,rbx
       jne       near ptr M10_L10
       xor       ebp,ebp
       xor       r14d,r14d
M10_L03:
       mov       rdx,[rcx+18]
       mov       rbx,[rdx+10]
       test      rbx,rbx
       je        near ptr M10_L11
M10_L04:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M10_L53
       mov       r15,[rsi+28]
       mov       rcx,[r15+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M10_L54
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rcx,[rsp+28]
       call      qword ptr [7FF86C1C64D8]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M10_L05:
       mov       [rsp+4C],eax
       mov       rcx,[r13+10]
       mov       edx,eax
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       r8d,[rcx+8]
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M10_L80
       mov       edx,edx
       mov       r13,[rcx+rdx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M10_L18
M10_L06:
       test      r13,r13
       je        near ptr M10_L67
       cmp       eax,[r13+20]
       jne       near ptr M10_L56
       mov       r8,[r13+8]
       test      r14d,r14d
       je        near ptr M10_L55
M10_L07:
       test      r8,r8
       jne       short M10_L12
       xor       edx,edx
       xor       r10d,r10d
M10_L08:
       cmp       r14d,r10d
       jne       near ptr M10_L17
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       jne       short M10_L13
       mov       rcx,rbp
       mov       r8,[rcx]
       mov       rcx,[rcx+2]
       mov       r10,[rdx]
       xor       r8,r10
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      cl
       movzx     ecx,cl
       mov       eax,ecx
       jmp       short M10_L14
M10_L09:
       mov       rcx,rsi
       mov       rdx,7FF86C38F198
       call      qword ptr [7FF86BE37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       near ptr M10_L02
M10_L10:
       lea       rbp,[rbx+0C]
       mov       r14d,[rbx+8]
       jmp       near ptr M10_L03
M10_L11:
       mov       rdx,7FF86C38F2D8
       call      qword ptr [7FF86BE37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbx,rax
       jmp       near ptr M10_L04
M10_L12:
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M10_L08
M10_L13:
       mov       rcx,rbp
       call      qword ptr [7FF86BC1FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M10_L14:
       test      eax,eax
       je        near ptr M10_L56
M10_L15:
       mov       rbp,[r13+10]
M10_L16:
       mov       rdx,[rsi+10]
       mov       rcx,[rdx+8]
       test      rcx,rcx
       jne       short M10_L19
       call      qword ptr [7FF86C146DD8]; System.DateTime.get_UtcNow()
       mov       r14,rax
       jmp       short M10_L20
M10_L17:
       xor       ecx,ecx
       mov       eax,ecx
       jmp       short M10_L14
M10_L18:
       test      r13,r13
       jne       near ptr M10_L57
       jmp       near ptr M10_L67
M10_L19:
       lea       rdx,[rsp+38]
       mov       r11,7FF86BB60C80
       call      qword ptr [r11]
       mov       r14,4000000000000000
       or        r14,[rsp+40]
M10_L20:
       test      rbp,rbp
       je        near ptr M10_L42
       cmp       byte ptr [rbp+43],0
       jne       near ptr M10_L41
       cmp       qword ptr [rbp+38],0
       jge       short M10_L21
       cmp       qword ptr [rbp+50],0
       je        short M10_L24
M10_L21:
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       cmp       [rbp+38],rdx
       jbe       near ptr M10_L68
       cmp       qword ptr [rbp+50],0
       jg        near ptr M10_L69
M10_L22:
       xor       r13d,r13d
M10_L23:
       test      r13d,r13d
       jne       near ptr M10_L41
M10_L24:
       cmp       qword ptr [rbp+10],0
       je        short M10_L25
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4A7F60]
       test      eax,eax
       jne       near ptr M10_L41
M10_L25:
       mov       [rbp+58],r14
       mov       r15,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M10_L70
M10_L26:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rax,[rsi+48]
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r14
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rdx,rax
       cmp       rcx,rdx
       jge       near ptr M10_L36
       mov       [rsi+48],r14
       test      byte ptr [7FF86C517648],1
       je        near ptr M10_L71
M10_L27:
       mov       rcx,2106FC004B0
       mov       rbp,[rcx]
       test      rbp,rbp
       jne       short M10_L28
       mov       rcx,offset MT_System.Action<System.Object>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,2106FC004A8
       mov       rdx,[rcx]
       test      rdx,rdx
       je        near ptr M10_L72
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF86C4A8D68
       mov       [rbp+18],rcx
       mov       rcx,2106FC004B0
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M10_L28:
       test      byte ptr [7FF86C4F5CD0],1
       je        near ptr M10_L73
M10_L29:
       mov       rcx,2106FC004E0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M10_L74
       mov       rcx,offset MT_System.Threading.Tasks.Task
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       lea       rcx,[r13+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,2008
       mov       [r13+34],ecx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M10_L75
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M10_L75
M10_L30:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M10_L31
       call      qword ptr [7FF86BE3FDB0]; System.Threading.Thread.InitializeCurrentThread()
M10_L31:
       mov       rbp,[rax+8]
       test      rbp,rbp
       je        near ptr M10_L45
       xor       ecx,ecx
       cmp       byte ptr [rbp+18],0
       cmovne    rbp,rcx
M10_L32:
       test      rbp,rbp
       je        near ptr M10_L47
       test      byte ptr [7FF86C4C5CD0],1
       je        near ptr M10_L77
M10_L33:
       mov       rcx,2106FC004F0
       cmp       rbp,[rcx]
       je        short M10_L35
       mov       rax,[r13+28]
       test      rax,rax
       jne       short M10_L34
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+3C],1
       lea       rcx,[r13+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,r14
M10_L34:
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M10_L35:
       mov       rcx,r13
       xor       edx,edx
       call      qword ptr [7FF86C4ACDB0]
M10_L36:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M10_L78
M10_L37:
       test      r15,r15
       je        near ptr M10_L79
       mov       rcx,[rbx+18]
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M10_L44
       mov       rdx,r15
       test      rdx,rdx
       je        short M10_L38
       mov       rcx,rsi
       cmp       [rdx],rcx
       je        short M10_L38
       mov       rdx,r15
       call      qword ptr [7FF86BC158D8]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M10_L38:
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M10_L39:
       mov       eax,1
M10_L40:
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
M10_L41:
       cmp       byte ptr [rbp+45],2
       je        near ptr M10_L25
       mov       r8,[rsi+10]
       mov       rcx,r15
       mov       rdx,rbp
       call      qword ptr [7FF86C4A7FC0]
M10_L42:
       mov       rdx,[rsi+10]
       mov       rbx,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r14
       call      qword ptr [7FF86C327630]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rbx,rax
       jge       short M10_L43
       mov       rcx,rsi
       mov       rdx,r14
       call      qword ptr [7FF86C4A7F90]
M10_L43:
       cmp       qword ptr [rsi+20],0
       je        short M10_L44
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4A7FA8]
       inc       qword ptr [rax+18]
M10_L44:
       xor       eax,eax
       mov       [rdi],rax
       jmp       short M10_L40
M10_L45:
       test      byte ptr [7FF86C4C5CD0],1
       je        near ptr M10_L76
M10_L46:
       mov       rcx,2106FC004F0
       mov       rbp,[rcx]
       jmp       near ptr M10_L32
M10_L47:
       or        dword ptr [r13+34],20000000
       jmp       near ptr M10_L35
M10_L48:
       call      qword ptr [7FF86C054A68]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M10_L49
       call      qword ptr [7FF86C4ACBA0]
       mov       rbx,rax
M10_L49:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,250EEA79C30
       call      qword ptr [7FF86C32F678]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M10_L50:
       call      qword ptr [7FF86C4A4CD8]
       test      eax,eax
       jne       short M10_L52
       jmp       near ptr M10_L00
M10_L51:
       call      qword ptr [7FF86C4A4CD8]
       test      eax,eax
       je        near ptr M10_L01
M10_L52:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FF86C4A7CF0]
       mov       rbx,rax
       jmp       near ptr M10_L01
M10_L53:
       call      qword ptr [7FF86C4A7EA0]
       int       3
M10_L54:
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB60C70
       call      qword ptr [r11]
       jmp       near ptr M10_L05
M10_L55:
       test      r8,r8
       jne       near ptr M10_L07
M10_L56:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M10_L06
M10_L57:
       cmp       eax,[r13+20]
       jne       near ptr M10_L65
       mov       r8,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       je        short M10_L58
       mov       [rsp+28],rbp
       mov       [rsp+30],r14d
       lea       rdx,[rsp+28]
       mov       rcx,r12
       mov       r11,7FF86BB60C78
       call      qword ptr [r11]
       jmp       short M10_L66
M10_L58:
       test      r14d,r14d
       jne       short M10_L59
       test      r8,r8
       je        short M10_L65
M10_L59:
       test      r8,r8
       je        short M10_L60
       lea       rdx,[r8+0C]
       mov       r10d,[r8+8]
       jmp       short M10_L61
M10_L60:
       xor       edx,edx
       xor       r10d,r10d
M10_L61:
       cmp       r14d,r10d
       je        short M10_L62
       xor       edx,edx
       mov       eax,edx
       jmp       short M10_L64
M10_L62:
       mov       r8d,r10d
       add       r8,r8
       cmp       r8,0A
       je        short M10_L63
       mov       rcx,rbp
       call      qword ptr [7FF86BC1FBD0]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M10_L64
M10_L63:
       mov       r8,rbp
       mov       rcx,[r8]
       mov       r8,[r8+2]
       mov       r11,[rdx]
       xor       rcx,r11
       xor       r8,[rdx+2]
       or        r8,rcx
       sete      dl
       movzx     edx,dl
       mov       eax,edx
M10_L64:
       jmp       short M10_L66
M10_L65:
       mov       r13,[r13+18]
       mov       eax,[rsp+4C]
       jmp       near ptr M10_L18
M10_L66:
       test      eax,eax
       je        short M10_L65
       jmp       near ptr M10_L15
M10_L67:
       xor       ebp,ebp
       jmp       near ptr M10_L16
M10_L68:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FF86C4ACD80]
       mov       r13d,1
       jmp       near ptr M10_L23
M10_L69:
       mov       rdx,[rbp+58]
       mov       rcx,r14
       call      qword ptr [7FF86C327630]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FF86C4ACD98]
       test      eax,eax
       jne       short M10_L68
       jmp       near ptr M10_L22
M10_L70:
       mov       rcx,rbp
       call      qword ptr [7FF86C4A7F78]
       jmp       near ptr M10_L26
M10_L71:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCache+<>c
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L27
M10_L72:
       call      qword ptr [7FF86C4A4E70]
       int       3
M10_L73:
       mov       rcx,offset MT_System.Threading.Tasks.TaskScheduler
       call      qword ptr [7FF86BC15740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L29
M10_L74:
       mov       ecx,2F
       call      qword ptr [7FF86BE3C228]
       int       3
M10_L75:
       mov       ecx,4
       call      qword ptr [7FF86C32EFE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M10_L30
M10_L76:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L46
M10_L77:
       mov       rcx,offset MT_System.Threading.ExecutionContext
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L33
M10_L78:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C4A7FA8]
       inc       qword ptr [rax+10]
       jmp       near ptr M10_L37
M10_L79:
       xor       r8d,r8d
       mov       [rdi],r8
       jmp       near ptr M10_L39
M10_L80:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2031
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
; System.String.Concat(System.String, System.String)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       test      rsi,rsi
       je        near ptr M12_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M12_L00
       test      rbx,rbx
       je        near ptr M12_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M12_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M12_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L00:
       test      rbx,rbx
       je        short M12_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M12_L02
M12_L01:
       mov       rax,250EEA70008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M12_L04:
       call      qword ptr [7FF86C32FFC0]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8AC241D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M13_L01
       cmp       [rax],ecx
       jle       short M13_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M13_L03
M13_L00:
       add       rsp,20
       pop       rbx
       ret
M13_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M13_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M13_L00
M13_L02:
       cmp       [rax+4],edx
       jle       short M13_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M13_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M13_L03
       jmp       short M13_L00
M13_L03:
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
       call      qword ptr [7FF8AC244DC8]
       test      eax,eax
       je        short M14_L00
       add       rsp,20
       pop       rbx
       ret
M14_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M15_L00
       ret
M15_L00:
       jmp       qword ptr [7FF86BE3E250]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M16_L01
       mov       rcx,rbx
       call      qword ptr [7FF8AC241BD8]
       test      eax,eax
       je        short M16_L00
       add       rsp,20
       pop       rbx
       ret
M16_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M16_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8AC23C210]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M17_L00
       mov       rcx,rbx
       call      00007FF8CB89E040
       test      eax,eax
       jne       short M17_L01
       add       rsp,20
       pop       rbx
       ret
M17_L00:
       xor       ecx,ecx
       call      qword ptr [7FF86C32ED30]
       int       3
M17_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF86C32EE38]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M18_L00
       add       rsp,28
       ret
M18_L00:
       call      qword ptr [7FF8AC251908]
       int       3
; Total bytes of code 20
```
```assembly
; System.RuntimeType.InitializeCache()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,98
       vzeroupper
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-70],rcx
       mov       rcx,rbp
       mov       [rbp-60],rcx
       cmp       qword ptr [rbx+10],0
       je        near ptr M19_L08
M19_L00:
       mov       rcx,[rbx+10]
       mov       rdx,[rcx]
       mov       rdi,rdx
       test      rdi,rdi
       je        short M19_L01
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdi],rcx
       jne       near ptr M19_L09
M19_L01:
       test      rdi,rdi
       jne       near ptr M19_L07
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       [rbp-0A0],rdi
       xor       ecx,ecx
       mov       [rdi+98],ecx
       lea       rcx,[rdi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      00007FF8CB8461E0
       mov       r14,rax
       test      r14,r14
       je        near ptr M19_L10
M19_L02:
       mov       rax,[r14+8]
       test      rax,rax
       jne       near ptr M19_L05
       mov       [rbp+10],rbx
       mov       [rbp-0A8],r14
       mov       [rbp-50],r14
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,[rbp-50]
       mov       rcx,[rcx+18]
       lea       rdx,[rbp-50]
       mov       [rbp-98],rdx
       mov       [rbp-90],rcx
       lea       rcx,[rbp-98]
       lea       rdx,[rbp-48]
       mov       rax,7FF86BD51B50
       mov       [rbp-78],rax
       lea       rax,[M19_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF8CB71A0F0
       call      rax
M19_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M19_L04
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M19_L04:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       r14,[rbp-0A8]
       lea       rcx,[r14+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       mov       rbx,[rbp+10]
M19_L05:
       cmp       rax,rbx
       sete      cl
       mov       rdi,[rbp-0A0]
       mov       [rdi+9C],cl
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FF8CB85EA20
       mov       rdx,rax
       test      rdx,rdx
       je        short M19_L06
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache
       cmp       [rdx],rcx
       jne       short M19_L11
M19_L06:
       test      rdx,rdx
       cmovne    rdi,rdx
M19_L07:
       mov       rax,rdi
       add       rsp,98
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M19_L08:
       mov       [rbp-40],rbx
       lea       rcx,[rbp-40]
       mov       edx,1
       call      qword ptr [7FF86C4ACE40]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M19_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FF86C4A47B0]
       jmp       near ptr M19_L00
M19_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M19_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FF86BC17C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M19_L02
M19_L11:
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 566
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
       cmp       byte ptr [rbx+14],0
       jne       short M20_L02
       test      rsi,rsi
       je        short M20_L01
       mov       edi,[rsi+8]
       mov       edx,edi
       mov       ecx,[rbx+20]
       sub       ecx,[rbx+10]
       cmp       ecx,edx
       jge       short M20_L00
       mov       rcx,rbx
       call      qword ptr [7FF86C326A30]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.Grow(Int32)
M20_L00:
       lea       r8,[rbx+18]
       mov       edx,[rbx+10]
       mov       ecx,[r8+8]
       cmp       edx,ecx
       ja        short M20_L03
       mov       r8,[r8]
       mov       eax,edx
       lea       rax,[r8+rax*2]
       sub       ecx,edx
       cmp       edi,ecx
       ja        short M20_L04
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       mov       rcx,rax
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],edi
M20_L01:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M20_L02:
       mov       rcx,rbx
       mov       r8,rsi
       mov       rdx,7FF86C353668
       xor       r9d,r9d
       call      qword ptr [7FF86C326A00]
       jmp       short M20_L01
M20_L03:
       call      qword ptr [7FF86BD87198]
       int       3
M20_L04:
       call      qword ptr [7FF86C05D218]
       int       3
; Total bytes of code 149
```
```assembly
; DotNetTips.Spargine.Core.DisplayNameOptions..ctor(Boolean, Boolean, Boolean, Char)
       push      rbp
       mov       rbp,rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
; 	public bool FullName { get; } = fullName;
; 	                                ^^^^^^^^
       mov       rax,[rbp+10]
       mov       ecx,[rbp+18]
       mov       [rax],cl
; 	public bool IncludeGenericParameterNames { get; } = includeGenericParameterNames;
; 	                                                    ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       ecx,[rbp+20]
       mov       [rax+1],cl
; 	public bool IncludeGenericParameters { get; } = includeGenericParameters;
; 	                                                ^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       ecx,[rbp+28]
       mov       [rax+2],cl
; 	public char NestedTypeDelimiter { get; } = nestedTypeDelimiter;
; 	                                           ^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       ecx,[rbp+30]
       mov       [rax+4],cx
       pop       rbp
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
M22_L00:
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
; 		if (type.IsGenericType)
; 		^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       test      eax,eax
       je        short M22_L01
; 			var genericArguments = type.GetGenericArguments();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       [rbp-8],rax
; 			ProcessGenericType(builder, type, genericArguments, genericArguments.Length, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-28],rax
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-30],rax
       mov       rax,[rbp-8]
       mov       eax,[rax+8]
       mov       [rbp-34],eax
       mov       rax,[rbp+20]
       mov       ecx,[rax]
       mov       [rbp-20],ecx
       mov       cx,[rax+4]
       mov       [rbp-1C],cx
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-30]
       mov       r9d,[rbp-34]
       lea       rax,[rbp-20]
       mov       [rsp+20],rax
       mov       r8,[rbp-8]
       call      qword ptr [7FF86C327660]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       nop
       add       rsp,90
       pop       rbp
       ret
; 		else if (type.IsArray)
; 		     ^^^^^^^^^^^^^^^^^
M22_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax]
       cmp       [rcx],ecx
       call      qword ptr [7FF86C145EA8]; System.Type.get_IsArray()
       test      eax,eax
       je        short M22_L02
; 			ProcessType(builder, type.GetElementType()!, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       [rbp-10],rax
       lea       rdx,[rbp-10]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+20]
       call      qword ptr [7FF86C3269B8]
; 			_ = builder.Append("[]");
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rcx,[rax]
       mov       rdx,250EEA82568
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD8F228]; System.Text.StringBuilder.Append(System.String)
       nop
       add       rsp,90
       pop       rbp
       ret
; 		else if (type.IsGenericParameter)
; 		     ^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M22_L02:
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       test      eax,eax
       je        short M22_L03
; 			if (options.IncludeGenericParameterNames)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+20]
       call      qword ptr [7FF86C327678]; DotNetTips.Spargine.Core.DisplayNameOptions.get_IncludeGenericParameterNames()
       test      eax,eax
       je        near ptr M22_L04
; 				_ = builder.Append(type.Name);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-18],rax
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       rax,[rbp-60]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-40],rax
       mov       rdx,[rbp-40]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF86BD8F228]; System.Text.StringBuilder.Append(System.String)
       nop
       add       rsp,90
       pop       rbp
       ret
; 			AppendSimpleTypeName(builder, type, options);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M22_L03:
       mov       rax,[rbp+10]
       mov       rax,[rax]
       mov       [rbp-50],rax
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       [rbp-58],rax
       mov       rax,[rbp+20]
       mov       ecx,[rax]
       mov       [rbp-48],ecx
       mov       cx,[rax+4]
       mov       [rbp-44],cx
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       lea       r8,[rbp-48]
       call      qword ptr [7FF86C327690]; DotNetTips.Spargine.Core.TypeHelper.AppendSimpleTypeName(System.Text.StringBuilder, System.Type, DotNetTips.Spargine.Core.DisplayNameOptions)
M22_L04:
       nop
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 496
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M23_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FF8CB8952E0
       mov       rsi,rax
M23_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M23_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M23_L03
       cmp       [rdx+8],r8d
       jb        short M23_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FF86BC15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M23_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M23_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M23_L02:
       mov       rax,250EEA70008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M23_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FF86BB54000
       call      qword ptr [7FF86BE37798]
       mov       rbx,rax
       call      qword ptr [7FF86C4A76D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86BE3DB00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
```
```assembly
; System.TimeSpan.FromMinutes(Int64)
       sub       rsp,28
       mov       rax,394427B08
       cmp       rcx,rax
       jg        short M24_L00
       mov       rax,0FFFFFFFC6BBD84F8
       cmp       rcx,rax
       jl        short M24_L00
       imul      rax,rcx,23C34600
       add       rsp,28
       ret
M24_L00:
       call      qword ptr [7FF8AC23F360]
       int       3
; Total bytes of code 53
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-10],rax
       mov       [rbp-8],rdx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,250EEA79C30
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,250EEA70008
       call      qword ptr [7FF86C054A38]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp+20],rax
; 		item = item.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+10]
       mov       [rbp-40],rax
       cmp       qword ptr [rbp-40],0
       je        short M25_L00
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       jmp       short M25_L01
M25_L00:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3B02C8
       call      qword ptr [7FF86BE37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M25_L01:
       mov       rax,250EEA7BB78
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,250EEA70008
       call      qword ptr [7FF86BFAE4F0]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C3274E0]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF86C327810]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
       mov       rax,[rbp+18]
       mov       rax,[rax+18]
       mov       rax,[rax+18]
       mov       [rbp-48],rax
       cmp       qword ptr [rbp-48],0
       je        short M25_L02
       mov       rax,[rbp-48]
       mov       [rbp-30],rax
       jmp       short M25_L03
M25_L02:
       mov       rcx,[rbp+18]
       mov       rdx,7FF86C3B0740
       call      qword ptr [7FF86BE37B58]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M25_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FF86C327828]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF86C3277C8]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```
```assembly
; System.Text.StringBuilder.set_Length(Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      esi,esi
       jl        near ptr M26_L08
       cmp       esi,[rbx+20]
       jg        near ptr M26_L09
       test      esi,esi
       jne       short M26_L01
       cmp       qword ptr [rbx+10],0
       jne       short M26_L01
       xor       eax,eax
       mov       [rbx+18],rax
M26_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M26_L01:
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       mov       r8d,esi
       sub       r8d,eax
       test      r8d,r8d
       jg        near ptr M26_L10
       mov       rdi,rbx
       cmp       [rbx+1C],esi
       jle       short M26_L03
M26_L02:
       mov       rdi,[rdi+10]
       cmp       [rdi+1C],esi
       jg        short M26_L02
M26_L03:
       cmp       rdi,rbx
       je        near ptr M26_L07
       mov       rcx,[rbx+8]
       mov       r8d,[rcx+8]
       add       r8d,[rbx+1C]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r10d,66666667
       mov       eax,r10d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       ecx,[rcx+8]
       cmp       edx,ecx
       cmovl     edx,ecx
       cmp       r8d,edx
       cmovg     r8d,edx
       mov       ecx,r8d
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       near ptr M26_L11
       cmp       ecx,400
       jge       short M26_L04
       movsxd    rcx,ecx
       call      qword ptr [7FF8AC236B28]
       mov       rbp,rax
       jmp       short M26_L05
M26_L04:
       xor       edx,edx
       call      qword ptr [7FF8AC250B38]; Precode of System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M26_L05:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FF8AC23A308]; Precode of System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      qword ptr [7FF8AC228FE8]; CORINFO_HELP_ASSIGN_REF
M26_L06:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      qword ptr [7FF8AC228FE8]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M26_L07:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M26_L00
M26_L08:
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       ecx,esi
       call      qword ptr [7FF8AC251908]
       int       3
M26_L09:
       call      qword ptr [7FF8AC233560]
       mov       rbx,rax
       call      qword ptr [7FF8AC23E680]
       mov       r8,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      qword ptr [7FF8AC23C220]
       mov       rcx,rbx
       call      qword ptr [7FF8AC228FC0]; CORINFO_HELP_THROW
       int       3
M26_L10:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8AC2436F0]
       jmp       near ptr M26_L00
M26_L11:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      qword ptr [7FF8AC228FE8]; CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M26_L06
; Total bytes of code 369
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rax,[rbx+10]
       mov       rdx,rsi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       je        short M27_L01
       cmp       qword ptr [rbx+20],0
       jne       short M27_L02
       lea       rdi,[rbx+20]
       mov       rcx,[rbx]
       call      qword ptr [7FF91D7261A8]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FF91D726288]; Precode of System.Threading.Interlocked.CompareExchange[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.__Canon, System.__Canon)
       test      rax,rax
       jne       short M27_L02
M27_L00:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M27_L01:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M27_L02:
       lea       rcx,[rbx+2C]
       call      qword ptr [7FF91D726250]
       cmp       eax,[rbx+28]
       jg        short M27_L03
       mov       rcx,[rbx+18]
       mov       rdx,rsi
       lea       r11,[Microsoft.Extensions.ObjectPool.DefaultObjectPoolProvider.Create[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.ObjectPool.IPooledObjectPolicy`1<System.__Canon>)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       short M27_L00
M27_L03:
       lea       rcx,[rbx+2C]
       call      qword ptr [7FF91D726258]
       jmp       short M27_L01
; Total bytes of code 150
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasBaseClassCached()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       mov       rcx,2E8583B1CB8
       mov       rdi,offset MT_System.RuntimeType
M00_L00:
       cmp       [rcx],rdi
       jne       short M00_L03
       call      qword ptr [7FF86BBFDB18]; System.RuntimeType.GetBaseType()
M00_L01:
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L02
       mov       rax,2E8583A19B8
       cmp       rcx,rax
       jne       short M00_L00
       mov       esi,1
M00_L02:
       mov       rax,[rbx+90]
       mov       [rax+4C],sil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       jmp       short M00_L01
; Total bytes of code 105
```
```assembly
; System.RuntimeType.GetBaseType()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M01_L02
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       jne       short M01_L03
       mov       rcx,rbx
       call      00007FF8CB848F60
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L10
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L10
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L11
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       ecx,ecx
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF86BB3A400]
       mov       rsi,rax
       mov       rdi,2E8583A19B8
       xor       ebp,ebp
       jmp       short M01_L08
M01_L05:
       mov       rdx,[rsi+rbp*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF86BBF6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBFD3B0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L07
       mov       rcx,r14
       call      00007FF8CB848F60
       test      eax,eax
       je        short M01_L06
       mov       rcx,r14
       call      qword ptr [7FF86BB3A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L07
M01_L06:
       mov       rdi,r14
M01_L07:
       inc       ebp
M01_L08:
       cmp       [rsi+8],ebp
       jg        short M01_L05
       mov       rcx,2E8583A19B8
       cmp       rdi,rcx
       jne       short M01_L09
       mov       rcx,rbx
       call      qword ptr [7FF86BB3A3F8]
       mov       rcx,2E8583A4B90
       test      al,8
       cmovne    rdi,rcx
M01_L09:
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FF86BBF5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L01
; Total bytes of code 312
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasBaseClass_ForComparison()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       mov       rcx,256E1E31CB8
       mov       rdi,offset MT_System.RuntimeType
M00_L00:
       cmp       [rcx],rdi
       jne       short M00_L03
       call      qword ptr [7FF86BBEDB18]; System.RuntimeType.GetBaseType()
M00_L01:
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L02
       mov       rax,256E1E219B8
       cmp       rcx,rax
       jne       short M00_L00
       mov       esi,1
M00_L02:
       mov       rax,[rbx+90]
       mov       [rax+4C],sil
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L03:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       jmp       short M00_L01
; Total bytes of code 105
```
```assembly
; System.RuntimeType.GetBaseType()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M01_L02
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       jne       short M01_L03
       mov       rcx,rbx
       call      00007FF8CB848F60
       test      eax,eax
       jne       short M01_L04
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L10
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L10
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L11
M01_L01:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L02:
       xor       ecx,ecx
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       mov       rcx,rbx
       call      qword ptr [7FF86BB2A400]
       mov       rsi,rax
       mov       rdi,256E1E219B8
       xor       ebp,ebp
       jmp       short M01_L08
M01_L05:
       mov       rdx,[rsi+rbp*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      qword ptr [7FF86BBE6328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FF86BBED3B0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L07
       mov       rcx,r14
       call      00007FF8CB848F60
       test      eax,eax
       je        short M01_L06
       mov       rcx,r14
       call      qword ptr [7FF86BB2A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L07
M01_L06:
       mov       rdi,r14
M01_L07:
       inc       ebp
M01_L08:
       cmp       [rsi+8],ebp
       jg        short M01_L05
       mov       rcx,256E1E219B8
       cmp       rdi,rcx
       jne       short M01_L09
       mov       rcx,rbx
       call      qword ptr [7FF86BB2A3F8]
       mov       rcx,256E1E24B90
       test      al,8
       cmovne    rdi,rcx
M01_L09:
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       xor       eax,eax
       jmp       near ptr M01_L01
M01_L11:
       call      qword ptr [7FF86BBE5C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L01
; Total bytes of code 312
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ImplementsInterfaceCached()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,1B2DEBC3120
       mov       [rax+10],rdx
       mov       rdx,rax
       mov       rcx,1B2DEBCCF30
       call      qword ptr [7FF86BB2A5B8]; System.RuntimeType.MakeGenericType(System.Type[])
       mov       rdx,rax
       mov       rcx,1B2DEBD1CB8
       call      qword ptr [7FF86C2F6CD0]; DotNetTips.Spargine.Core.TypeHelper.ImplementsInterface(System.Type, System.Type)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 96
```
```assembly
; System.RuntimeType.MakeGenericType(System.Type[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       [rbp+18],rbx
       test      rbx,rbx
       je        near ptr M01_L29
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L30
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L31
       mov       r14,rsi
M01_L01:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M01_L35
       mov       [rbp-0C8],r14
       mov       rcx,[r14+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       r14,[rbp-0C8]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L33
M01_L02:
       cmp       ebx,1D
       ja        short M01_L03
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M01_L34
M01_L03:
       cmp       ebx,10
       sete      sil
       movzx     esi,sil
M01_L04:
       test      esi,esi
       jne       near ptr M01_L32
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      rax,rax
       je        near ptr M01_L36
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M01_L13
       mov       rcx,[rcx+18]
M01_L05:
       lea       rdx,[rbp-50]
       mov       [rbp-0B0],rdx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0B0]
       lea       rdx,[rbp-48]
       mov       r8d,1
       mov       rax,7FF86BC26468
       mov       [rbp-90],rax
       lea       rax,[M01_L06]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF8CB73F000
       call      rax
M01_L06:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M01_L07
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L07:
       mov       rcx,[rbp-98]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,[rbx+8]
       mov       rsi,[rbp+18]
       mov       edi,[rsi+8]
       cmp       ecx,edi
       jne       near ptr M01_L37
       cmp       edi,1
       jne       short M01_L08
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M01_L14
M01_L08:
       mov       edx,edi
       mov       rcx,offset MT_System.RuntimeType[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0C0],rax
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L12
       mov       rdx,[rbp-0C0]
       cmp       [rdx+8],edi
       jl        near ptr M01_L24
       mov       r13d,10
       jmp       short M01_L10
M01_L09:
       mov       rdx,[rbp-0C0]
       lea       rcx,[rdx+r13]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,8
       dec       edi
       je        short M01_L12
M01_L10:
       mov       rcx,[rsi+r13]
       test      rcx,rcx
       je        near ptr M01_L42
       mov       r12,rcx
       mov       rax,offset MT_System.RuntimeType
       cmp       [r12],rax
       je        short M01_L11
       xor       r12d,r12d
M01_L11:
       test      r12,r12
       jne       short M01_L09
       mov       r15d,1
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L09
       mov       r14d,1
       jmp       short M01_L09
M01_L12:
       test      r15d,r15d
       je        near ptr M01_L27
       test      r14d,r14d
       je        near ptr M01_L26
       mov       rcx,offset MT_System.Reflection.SignatureConstructedGenericType
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp+10]
       mov       r8,rsi
       call      qword ptr [7FF86C477060]
       mov       rax,rbx
       jmp       near ptr M01_L28
M01_L13:
       xor       ecx,ecx
       jmp       near ptr M01_L05
M01_L14:
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L08
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L38
M01_L15:
       cmp       edi,0F
       je        near ptr M01_L41
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     esi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L39
M01_L16:
       cmp       esi,1B
       je        near ptr M01_L41
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L40
M01_L17:
       cmp       ebx,10
       je        near ptr M01_L41
       mov       rcx,1B2DEBC1440
       cmp       [rbp-0B8],rcx
       je        near ptr M01_L41
       mov       rsi,[rbp+10]
       mov       [rbp-40],rsi
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,[rbp-40]
       test      rcx,rcx
       je        short M01_L19
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       test      rcx,rcx
       je        short M01_L20
       mov       rcx,[rcx+18]
M01_L18:
       lea       rdx,[rbp-68]
       mov       [rbp-0B0],rdx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0B0]
       lea       rdx,[rbp-58]
       lea       r9,[rbp-60]
       mov       r8d,1
       call      00007FF86BBD9620
       mov       rax,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       jmp       short M01_L21
M01_L19:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C2FF108]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C2FF120]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L20:
       xor       ecx,ecx
       jmp       short M01_L18
M01_L21:
       jmp       near ptr M01_L28
M01_L22:
       mov       r14d,1
M01_L23:
       mov       rdx,[rbp-0C0]
       cmp       r13d,[rdx+8]
       jae       near ptr M01_L43
       mov       ecx,r13d
       lea       rcx,[rdx+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       cmp       edi,r13d
       jle       near ptr M01_L12
M01_L24:
       mov       ecx,r13d
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L42
       mov       r12,rcx
       mov       rax,offset MT_System.RuntimeType
       cmp       [r12],rax
       je        short M01_L25
       xor       r12d,r12d
M01_L25:
       test      r12,r12
       jne       short M01_L23
       mov       r15d,1
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L23
       jmp       short M01_L22
M01_L26:
       mov       rcx,rsi
       call      qword ptr [7FF86C116280]; System.Object.MemberwiseClone()
       mov       rdx,rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C477078]
       jmp       short M01_L28
M01_L27:
       mov       rcx,[rbp-0C0]
       mov       rdx,rbx
       call      qword ptr [7FF86C115ED8]; System.RuntimeType.SanityCheckGenericArguments(System.RuntimeType[], System.RuntimeType[])
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FF86C115EF0]; System.RuntimeTypeHandle.Instantiate(System.Type[])
       nop
M01_L28:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       mov       ecx,9F9
       mov       rdx,7FF86BB24000
       call      qword ptr [7FF86BE07798]
       mov       rcx,rax
       call      qword ptr [7FF86C2FE808]
       int       3
M01_L30:
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L31:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C477018]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF86C2FEEC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BF76298]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L32:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L33:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L02
M01_L34:
       mov       esi,1
       jmp       near ptr M01_L04
M01_L35:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       esi,eax
       jmp       near ptr M01_L04
M01_L36:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C2FF108]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C2FF120]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L37:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C477030]
       mov       rsi,rax
       mov       ecx,9F9
       mov       rdx,7FF86BB24000
       call      qword ptr [7FF86BE07798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF86BF76340]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L38:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L15
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L41:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C476328]
       mov       rcx,rax
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FF86C2FEEC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BF74450]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L42:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF86C477048]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rcx,offset MT_System.RuntimeType[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FF86C477090]
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       vzeroupper
       mov       r8,rcx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FF86C477090]
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1766
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.ImplementsInterface(System.Type, System.Type)
; 		if (interfaceType == null || interfaceType.IsInterface == false)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return false;
; 			^^^^^^^^^^^^^
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _implementsInterfaceCache.GetOrAdd((type, interfaceType), static key =>
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		{
; 		 
; 			var (t, iface) = key;
; 			                     
; 
; 
; 			return t.GetInterfaces().Any(i => i == iface);
; 			                                              
; 		});
; 		   
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M02_L17
       mov       rdi,offset MT_System.RuntimeType
       cmp       [rbx],rdi
       je        short M02_L00
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+70]
       call      qword ptr [rax+18]
       test      al,20
       jne       short M02_L02
       jmp       near ptr M02_L17
M02_L00:
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M02_L16
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M02_L01:
       test      ecx,ecx
       je        near ptr M02_L17
M02_L02:
       test      rsi,rsi
       je        near ptr M02_L18
       mov       rcx,1725FC00338
       mov       r14,[rcx]
       mov       rcx,1725FC002F8
       mov       r15,[rcx]
       test      r14,r14
       je        near ptr M02_L19
M02_L03:
       mov       r13,[r15+8]
       mov       rcx,[r13+8]
       mov       [rbp-50],rsi
       mov       [rbp-48],rbx
       test      rcx,rcx
       jne       near ptr M02_L20
       xor       ecx,ecx
       mov       [rbp-58],rcx
       lea       rcx,[rbp-50]
       cmp       qword ptr [rbp-58],0
       jne       short M02_L04
       mov       rcx,[rbp-50]
       mov       [rbp-58],rcx
       lea       rcx,[rbp-58]
       cmp       qword ptr [rbp-58],0
       je        near ptr M02_L21
M02_L04:
       mov       r12,[rcx]
       cmp       [r12],rdi
       jne       near ptr M02_L22
       mov       rcx,r12
       call      00007FF8CB813FE0
       test      eax,eax
       je        near ptr M02_L14
M02_L05:
       mov       r12d,eax
M02_L06:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       lea       rcx,[rbp-48]
       cmp       qword ptr [rbp-60],0
       jne       short M02_L07
       mov       rcx,[rbp-48]
       mov       [rbp-60],rcx
       lea       rcx,[rbp-60]
       cmp       qword ptr [rbp-60],0
       je        near ptr M02_L23
M02_L07:
       mov       rax,[rcx]
       mov       [rbp-88],rax
       cmp       [rax],rdi
       jne       near ptr M02_L24
       mov       rcx,rax
       call      00007FF8CB813FE0
       test      eax,eax
       je        near ptr M02_L15
M02_L08:
       imul      edx,r12d,0C2B2AE3D
       add       edx,83B791A4
       rol       edx,11
       imul      edx,27D4EB2F
       imul      ecx,eax,0C2B2AE3D
       add       edx,ecx
       rol       edx,11
       imul      edx,27D4EB2F
       mov       ecx,edx
       shr       ecx,0F
       xor       ecx,edx
       imul      edx,ecx,85EBCA77
       mov       ecx,edx
       shr       ecx,0D
       xor       ecx,edx
       imul      edx,ecx,0C2B2AE3D
       mov       r12d,edx
       shr       r12d,10
       xor       r12d,edx
       xor       edx,edx
       mov       [rbp-58],rdx
       mov       [rbp-60],rdx
M02_L09:
       mov       rdi,[r13+8]
       test      rdi,rdi
       jne       near ptr M02_L30
       mov       rcx,[r13+10]
       mov       edx,r12d
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       edi,[rcx+8]
       mov       eax,edi
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,edi
       jae       near ptr M02_L34
       mov       edx,edx
       mov       rdi,[rcx+rdx*8+10]
       test      rdi,rdi
       je        near ptr M02_L29
M02_L10:
       cmp       r12d,[rdi+10]
       jne       near ptr M02_L26
       mov       rcx,[rdi+18]
       mov       rax,[rdi+20]
       mov       [rbp-98],rax
       test      rcx,rcx
       je        near ptr M02_L26
       mov       rdx,offset MT_System.RuntimeType
       mov       r8,rdx
       cmp       [rcx],r8
       jne       near ptr M02_L25
       cmp       rsi,rcx
       sete      r8b
       movzx     r8d,r8b
M02_L11:
       test      r8d,r8d
       je        near ptr M02_L26
       mov       rax,[rbp-98]
       test      rax,rax
       je        near ptr M02_L28
       mov       r8,offset MT_System.RuntimeType
       mov       rcx,r8
       cmp       [rax],rcx
       jne       near ptr M02_L27
       cmp       rbx,rax
       sete      r8b
       movzx     r8d,r8b
M02_L12:
       test      r8d,r8d
       je        near ptr M02_L26
       movzx     r8d,byte ptr [rdi+14]
       mov       [rbp-40],r8b
M02_L13:
       movzx     eax,byte ptr [rbp-40]
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
M02_L14:
       mov       rcx,r12
       call      qword ptr [7FF86BBEE988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M02_L05
M02_L15:
       mov       rcx,[rbp-88]
       call      qword ptr [7FF86BBEE988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M02_L08
M02_L16:
       xor       ecx,ecx
       jmp       near ptr M02_L01
M02_L17:
       xor       eax,eax
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
M02_L18:
       call      qword ptr [7FF86C19F180]
       mov       ecx,2643
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,0F32
       mov       rdx,7FF86BEC4F20
       call      qword ptr [7FF86BE07798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BBE7858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C47C378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C2FF120]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       mov       rcx,offset MT_System.Func<System.ValueTuple<System.Type, System.Type>, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1725FC00328
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<ImplementsInterface>b__53_0(System.ValueTuple`2<System.Type,System.Type>)
       call      qword ptr [7FF86BBE6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1725FC00338
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M02_L03
M02_L20:
       vmovdqu   xmm0,xmmword ptr [rbp-50]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       lea       rdx,[rbp-70]
       mov       r11,7FF86BB30C30
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M02_L09
M02_L21:
       xor       r12d,r12d
       jmp       near ptr M02_L06
M02_L22:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r12d,eax
       jmp       near ptr M02_L06
M02_L23:
       xor       eax,eax
       jmp       near ptr M02_L08
M02_L24:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       jmp       near ptr M02_L08
M02_L25:
       mov       rdx,rsi
       mov       r8,[rcx]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       mov       r8d,eax
       jmp       near ptr M02_L11
M02_L26:
       mov       rdi,[rdi+8]
       test      rdi,rdi
       jne       near ptr M02_L10
       jmp       short M02_L29
M02_L27:
       mov       rcx,rax
       mov       rdx,rbx
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       mov       r8d,eax
       jmp       near ptr M02_L12
M02_L28:
       xor       r8d,r8d
       jmp       near ptr M02_L12
M02_L29:
       mov       byte ptr [rbp-40],0
       mov       [rbp-70],rsi
       mov       [rbp-68],rbx
       mov       [rbp-80],rsi
       mov       [rbp-78],rbx
       lea       rdx,[rbp-80]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       dword ptr [rsp+30],1
       lea       r8,[rbp-40]
       mov       [rsp+38],r8
       mov       [rsp+20],eax
       lea       r8,[rbp-70]
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r13
       mov       rcx,r15
       call      qword ptr [7FF86C2F7798]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]].TryAddInternal(Tables<System.ValueTuple`2<System.__Canon,System.__Canon>,Boolean>, System.ValueTuple`2<System.__Canon,System.__Canon>, System.Nullable`1<Int32>, Boolean, Boolean, Boolean, Boolean ByRef)
       jmp       near ptr M02_L13
M02_L30:
       mov       r8,[r13+10]
       mov       edx,r12d
       imul      rdx,[r13+28]
       shr       rdx,20
       inc       rdx
       mov       ecx,[r8+8]
       mov       r11d,ecx
       imul      rdx,r11
       shr       rdx,20
       cmp       edx,ecx
       jae       short M02_L34
       mov       edx,edx
       mov       rax,[r8+rdx*8+10]
       test      rax,rax
       je        near ptr M02_L29
M02_L31:
       cmp       r12d,[rax+10]
       jne       short M02_L32
       mov       [rbp-90],rax
       vmovdqu   xmm0,xmmword ptr [rax+18]
       vmovdqu   xmmword ptr [rbp-70],xmm0
       mov       [rbp-80],rsi
       mov       [rbp-78],rbx
       lea       r8,[rbp-80]
       lea       rdx,[rbp-70]
       mov       rcx,rdi
       mov       r11,7FF86BB30C38
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-90]
       jne       short M02_L33
M02_L32:
       mov       rax,[rax+8]
       test      rax,rax
       jne       short M02_L31
       jmp       near ptr M02_L29
M02_L33:
       movzx     edx,byte ptr [rax+14]
       mov       [rbp-40],dl
       jmp       near ptr M02_L13
M02_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1365
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ImplementsInterface_ForComparison()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,29A8AD83120
       mov       [rax+10],rdx
       mov       rdx,rax
       mov       rcx,29A8AD8CF30
       call      qword ptr [7FF86BB6A5B8]; System.RuntimeType.MakeGenericType(System.Type[])
       mov       rdx,rax
       mov       rcx,29A8AD91CB8
       call      qword ptr [7FF86C336E98]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ImplementsInterfaceNoCache(System.Type, System.Type)
       mov       rcx,[rbx+90]
       mov       [rcx+4C],al
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 96
```
```assembly
; System.RuntimeType.MakeGenericType(System.Type[])
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       vzeroupper
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rcx,rsp
       mov       [rbp-88],rcx
       mov       rcx,rbp
       mov       [rbp-78],rcx
       mov       [rbp+18],rbx
       test      rbx,rbx
       je        near ptr M01_L30
       mov       rcx,[rsi+18]
       test      cl,2
       jne       near ptr M01_L31
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      cl
       movzx     ecx,cl
M01_L00:
       test      ecx,ecx
       je        near ptr M01_L32
       mov       r14,rsi
M01_L01:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M01_L36
       mov       [rbp-0C8],r14
       mov       rcx,[r14+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       mov       r14,[rbp-0C8]
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L34
M01_L02:
       cmp       ebx,1D
       ja        short M01_L03
       mov       ecx,1FEF7FFF
       bt        ecx,ebx
       jae       near ptr M01_L35
M01_L03:
       cmp       ebx,10
       sete      sil
       movzx     esi,sil
M01_L04:
       test      esi,esi
       jne       near ptr M01_L33
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       test      rax,rax
       je        near ptr M01_L37
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       test      rcx,rcx
       je        near ptr M01_L14
       mov       rcx,[rcx+18]
M01_L05:
       lea       rdx,[rbp-50]
       mov       [rbp-0B0],rdx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0B0]
       lea       rdx,[rbp-48]
       mov       r8d,1
       mov       rax,7FF86BC66468
       mov       [rbp-90],rax
       lea       rax,[M01_L06]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FF8CB73F000
       call      rax
M01_L06:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FF8CBB53A90],0
       je        short M01_L07
       call      qword ptr [7FF8CBB42648]; CORINFO_HELP_STOP_FOR_GC
M01_L07:
       mov       rcx,[rbp-98]
       mov       [rdi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       ecx,[rbx+8]
       mov       rsi,[rbp+18]
       mov       edi,[rsi+8]
       cmp       ecx,edi
       jne       near ptr M01_L38
       cmp       edi,1
       jne       short M01_L08
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M01_L15
M01_L08:
       mov       edx,edi
       mov       rcx,offset MT_System.RuntimeType[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-0C0],rax
       xor       r14d,r14d
       xor       r15d,r15d
       xor       r13d,r13d
       test      edi,edi
       jle       short M01_L13
       mov       rdx,[rbp-0C0]
       cmp       [rdx+8],edi
       jl        near ptr M01_L25
       mov       r13d,10
       jmp       short M01_L11
M01_L09:
       mov       r14d,1
M01_L10:
       mov       rdx,[rbp-0C0]
       lea       rcx,[rdx+r13]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       add       r13,8
       dec       edi
       je        short M01_L13
M01_L11:
       mov       rcx,[rsi+r13]
       test      rcx,rcx
       je        near ptr M01_L43
       mov       r12,rcx
       mov       rax,offset MT_System.RuntimeType
       cmp       [r12],rax
       je        short M01_L12
       xor       r12d,r12d
M01_L12:
       test      r12,r12
       jne       short M01_L10
       mov       r15d,1
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L10
       jmp       short M01_L09
M01_L13:
       test      r15d,r15d
       je        near ptr M01_L28
       test      r14d,r14d
       je        near ptr M01_L27
       mov       rcx,offset MT_System.Reflection.SignatureConstructedGenericType
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,[rbp+10]
       mov       r8,rsi
       call      qword ptr [7FF86C476448]
       mov       rax,rbx
       jmp       near ptr M01_L29
M01_L14:
       xor       ecx,ecx
       jmp       near ptr M01_L05
M01_L15:
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L08
       mov       [rbp-0B8],rcx
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L39
M01_L16:
       cmp       edi,0F
       je        near ptr M01_L42
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     esi,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L40
M01_L17:
       cmp       esi,1B
       je        near ptr M01_L42
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FF8CB8440B0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M01_L41
M01_L18:
       cmp       ebx,10
       je        near ptr M01_L42
       mov       rcx,29A8AD81440
       cmp       [rbp-0B8],rcx
       je        near ptr M01_L42
       mov       rsi,[rbp+10]
       mov       [rbp-40],rsi
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       [rbp-58],rcx
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,[rbp-40]
       test      rcx,rcx
       je        short M01_L20
       mov       [rbp-68],rcx
       mov       rcx,[rbp-68]
       test      rcx,rcx
       je        short M01_L21
       mov       rcx,[rcx+18]
M01_L19:
       lea       rdx,[rbp-68]
       mov       [rbp-0B0],rdx
       mov       [rbp-0A8],rcx
       lea       rcx,[rbp-0B0]
       lea       rdx,[rbp-58]
       lea       r9,[rbp-60]
       mov       r8d,1
       call      00007FF86BC18CC0
       mov       rax,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       jmp       short M01_L22
M01_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C33E508]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C33E520]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L21:
       xor       ecx,ecx
       jmp       short M01_L19
M01_L22:
       jmp       near ptr M01_L29
M01_L23:
       mov       r14d,1
M01_L24:
       mov       rdx,[rbp-0C0]
       cmp       r13d,[rdx+8]
       jae       near ptr M01_L44
       mov       ecx,r13d
       lea       rcx,[rdx+rcx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       inc       r13d
       cmp       edi,r13d
       jle       near ptr M01_L13
M01_L25:
       mov       ecx,r13d
       mov       rcx,[rsi+rcx*8+10]
       test      rcx,rcx
       je        near ptr M01_L43
       mov       r12,rcx
       mov       rax,offset MT_System.RuntimeType
       cmp       [r12],rax
       je        short M01_L26
       xor       r12d,r12d
M01_L26:
       test      r12,r12
       jne       short M01_L24
       mov       r15d,1
       mov       rax,[rcx]
       mov       rax,[rax+78]
       call      qword ptr [rax+10]
       test      eax,eax
       je        short M01_L24
       jmp       short M01_L23
M01_L27:
       mov       rcx,rsi
       call      qword ptr [7FF86C156250]; System.Object.MemberwiseClone()
       mov       rdx,rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FF86C476460]
       jmp       short M01_L29
M01_L28:
       mov       rcx,[rbp-0C0]
       mov       rdx,rbx
       call      qword ptr [7FF86C155EA8]; System.RuntimeType.SanityCheckGenericArguments(System.RuntimeType[], System.RuntimeType[])
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FF86C155EC0]; System.RuntimeTypeHandle.Instantiate(System.Type[])
       nop
M01_L29:
       add       rsp,0B8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L30:
       mov       ecx,9F9
       mov       rdx,7FF86BB64000
       call      qword ptr [7FF86BE47798]
       mov       rcx,rax
       call      qword ptr [7FF86C33DC08]
       int       3
M01_L31:
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L32:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C476400]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FF86C33E2C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BFB6268]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L33:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M01_L01
M01_L34:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L02
M01_L35:
       mov       esi,1
       jmp       near ptr M01_L04
M01_L36:
       mov       rcx,r14
       mov       rax,[r14]
       mov       rax,[rax+68]
       call      qword ptr [rax]
       mov       esi,eax
       jmp       near ptr M01_L04
M01_L37:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C33E508]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF86C33E520]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L38:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C476418]
       mov       rsi,rax
       mov       ecx,9F9
       mov       rdx,7FF86BB64000
       call      qword ptr [7FF86BE47798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF86BFB6310]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L39:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L16
M01_L40:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L17
M01_L41:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L18
M01_L42:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF86C4756F8]
       mov       rcx,rax
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FF86C33E2C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BFB4420]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FF86C476430]
       mov       rcx,r15
       call      CORINFO_HELP_THROW
       int       3
M01_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
       sub       rsp,28
       vzeroupper
       mov       rbx,rcx
       mov       rcx,offset MT_System.RuntimeType[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       lea       rcx,[rsi+10]
       mov       rdx,[rbp-0B8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FF86C476478]
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       vzeroupper
       mov       r8,rcx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FF86C476478]
       call      CORINFO_HELP_RETHROW
       int       3
; Total bytes of code 1766
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ImplementsInterfaceNoCache(System.Type, System.Type)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-2C],eax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c__DisplayClass73_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M02_L24
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M02_L26
       mov       rsi,offset MT_System.RuntimeType
       cmp       [rcx],rsi
       je        short M02_L00
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax+18]
       test      al,20
       jne       short M02_L02
       jmp       near ptr M02_L26
M02_L00:
       mov       rax,[rcx+18]
       test      al,2
       jne       near ptr M02_L25
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M02_L01:
       test      eax,eax
       je        near ptr M02_L26
M02_L02:
       cmp       [rbx],rsi
       jne       near ptr M02_L32
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M02_L27
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M02_L27
M02_L03:
       cmp       [r14],r14b
       lea       rbx,[r14+58]
       mov       rcx,[rbx]
       test      rcx,rcx
       je        near ptr M02_L28
M02_L04:
       cmp       byte ptr [rcx+18],0
       je        near ptr M02_L29
       mov       rbx,[rcx+8]
M02_L05:
       test      rbx,rbx
       je        near ptr M02_L21
       lea       r14,[rbx+10]
       mov       ebx,[rbx+8]
M02_L06:
       test      ebx,ebx
       jne       near ptr M02_L22
       mov       rdx,259F5C00208
       mov       rcx,[rdx]
M02_L07:
       test      rcx,rcx
       je        near ptr M02_L33
       mov       r11,offset MT_System.Type[]
       cmp       [rcx],r11
       je        near ptr M02_L12
       mov       r11,offset MT_System.Collections.Generic.List<System.Type>
       cmp       [rcx],r11
       je        short M02_L11
       mov       r11,7FF86BB70C38
       call      qword ptr [r11]
       mov       [rbp-38],rax
M02_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FF86BB70C40
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L09
       mov       rcx,[rbp-38]
       mov       r11,7FF86BB70C48
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,offset DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c__DisplayClass73_0.<ImplementsInterfaceNoCache>b__0(System.Type)
       call      rax
       test      eax,eax
       je        short M02_L08
       mov       dword ptr [rbp-2C],1
       call      M02_L35
       nop
       mov       eax,[rbp-2C]
       jmp       near ptr M02_L20
M02_L09:
       mov       rcx,[rbp-38]
       mov       r11,7FF86BB70C50
       call      qword ptr [r11]
M02_L10:
       xor       eax,eax
       jmp       near ptr M02_L20
M02_L11:
       mov       ebx,[rcx+10]
       mov       r14,[rcx+8]
       cmp       [r14+8],ebx
       jb        near ptr M02_L34
       add       r14,10
       jmp       short M02_L13
M02_L12:
       lea       r14,[rcx+10]
       mov       ebx,[rcx+8]
M02_L13:
       test      ebx,ebx
       jle       short M02_L10
       xor       r15d,r15d
       jmp       short M02_L16
M02_L14:
       xor       eax,eax
M02_L15:
       test      eax,eax
       jne       short M02_L19
       add       r15,8
       dec       ebx
       je        short M02_L10
M02_L16:
       mov       rcx,[r14+r15]
       mov       rdx,[rdi+8]
       cmp       rcx,rdx
       je        short M02_L18
       test      rcx,rcx
       je        short M02_L14
       test      rdx,rdx
       je        short M02_L14
       cmp       [rcx],rsi
       je        short M02_L14
       mov       rax,rdx
       mov       r8,offset MT_System.RuntimeType
       cmp       [rax],r8
       je        short M02_L17
       xor       eax,eax
M02_L17:
       test      rax,rax
       jne       short M02_L14
       mov       rax,[rcx]
       mov       rax,[rax+0A8]
       call      qword ptr [rax+18]
       jmp       short M02_L15
M02_L18:
       mov       eax,1
       jmp       short M02_L15
M02_L19:
       mov       eax,1
M02_L20:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L21:
       xor       r14d,r14d
       xor       ebx,ebx
       jmp       near ptr M02_L06
M02_L22:
       mov       edx,ebx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       r8d,ebx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M02_L31
       mov       rdx,r14
       call      00007FF8CB8137A0
       cmp       dword ptr [7FF8CBB53A90],0
       jne       near ptr M02_L30
M02_L23:
       mov       rcx,r15
       jmp       near ptr M02_L07
M02_L24:
       call      qword ptr [7FF86C1DF150]
       mov       ecx,263
       mov       rdx,7FF86BF02E38
       call      qword ptr [7FF86BE47798]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF86BF04F20
       call      qword ptr [7FF86BE47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FF86BF02E38
       call      qword ptr [7FF86BE47798]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF86BC27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF86C477948]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF86C33E520]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L25:
       xor       eax,eax
       jmp       near ptr M02_L01
M02_L26:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L27:
       mov       rcx,rbx
       call      qword ptr [7FF86BC27C48]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M02_L03
M02_L28:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FF8CB8421C0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r15
       jmp       near ptr M02_L04
M02_L29:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FF86BC2D2D8]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rbx,rax
       jmp       near ptr M02_L05
M02_L30:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L23
M02_L31:
       mov       rdx,r14
       call      qword ptr [7FF86C1DEC40]
       jmp       near ptr M02_L23
M02_L32:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M02_L07
M02_L33:
       mov       ecx,11
       call      qword ptr [7FF86BE47E58]
       int       3
M02_L34:
       call      qword ptr [7FF86BE47A08]
       int       3
M02_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M02_L36
       mov       rcx,[rbp-38]
       mov       r11,7FF86BB70C50
       call      qword ptr [r11]
M02_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 1024
```

