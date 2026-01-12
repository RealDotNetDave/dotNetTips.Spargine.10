## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypeNames_NoCache()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFA4A5DEEC8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypeNamesNoCache()
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       sub       rsp,4E8
       vzeroupper
       lea       rbp,[rsp+520]
       xor       eax,eax
       mov       [rbp-468],rax
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
       mov       rcx,28FD2C01070
       mov       rdx,[rcx]
       lea       rcx,[rbx+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-458],rbx
       mov       rcx,offset MT_System.Type[]
       mov       [rbp-2B0],rcx
       lea       rcx,[rbp-2B0]
       mov       dword ptr [rcx+8],0D
       lea       rcx,[rbp-2B0]
       mov       r8,2D067D861C8
       mov       [rcx+10],r8
       mov       r8,2D067D83BD0
       mov       [rcx+18],r8
       mov       r8,2D067D861F0
       mov       [rcx+20],r8
       mov       r8,2D067D86F38
       mov       [rcx+28],r8
       mov       r8,2D067D862B8
       mov       [rcx+30],r8
       mov       r8,2D067D86290
       mov       [rcx+38],r8
       mov       r8,2D067D83FA0
       mov       [rcx+40],r8
       mov       r8,2D067D86268
       mov       [rcx+48],r8
       mov       r8,2D067D86218
       mov       [rcx+50],r8
       mov       r8,2D067D86240
       mov       [rcx+58],r8
       mov       r8,2D067D83B58
       mov       [rcx+60],r8
       mov       r8,2D067D83950
       mov       [rcx+68],r8
       mov       r8,2D067D83EF0
       mov       [rcx+70],r8
       mov       byte ptr [rbp-3F],1
       mov       byte ptr [rbp-3E],1
       mov       word ptr [rbp-3C],2B
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],0D
       jl        near ptr M01_L40
M01_L01:
       mov       rdi,[rbp-458]
       mov       rcx,offset MT_System.Type[]
       mov       [rbp-430],rcx
       lea       rcx,[rbp-430]
       mov       dword ptr [rcx+8],2E
       lea       rcx,[rbp-430]
       mov       rdx,2D067D80020
       mov       [rcx+10],rdx
       mov       rdx,2D067D827E0
       mov       [rcx+18],rdx
       mov       rdx,2D067D837C8
       mov       [rcx+20],rdx
       mov       rdx,2D067D8B890
       mov       [rcx+28],rdx
       mov       rdx,2D067D8C3D8
       mov       [rcx+30],rdx
       mov       rdx,2D067D83B80
       mov       [rcx+38],rdx
       mov       rdx,2D067D8C540
       mov       [rcx+40],rdx
       mov       rdx,2D067D906C0
       mov       [rcx+48],rdx
       mov       rdx,2D067D8C0B8
       mov       [rcx+50],rdx
       mov       rdx,2D067D83EC8
       mov       [rcx+58],rdx
       mov       rdx,2D067D862E0
       mov       [rcx+60],rdx
       mov       rdx,2D067D906E8
       mov       [rcx+68],rdx
       mov       rdx,2D067D8E068
       mov       [rcx+70],rdx
       mov       rdx,2D067D90710
       mov       [rcx+78],rdx
       mov       rdx,2D067D90738
       mov       [rcx+80],rdx
       mov       rdx,2D067D843E8
       mov       [rcx+88],rdx
       mov       rdx,2D067D90760
       mov       [rcx+90],rdx
       mov       rdx,2D067D90788
       mov       [rcx+98],rdx
       mov       rdx,2D067D907B0
       mov       [rcx+0A0],rdx
       mov       rdx,2D067D907D8
       mov       [rcx+0A8],rdx
       mov       rdx,2D067D90800
       mov       [rcx+0B0],rdx
       mov       rdx,2D067D8E1B8
       mov       [rcx+0B8],rdx
       mov       rdx,2D067D8E1E0
       mov       [rcx+0C0],rdx
       mov       rdx,2D067D90828
       mov       [rcx+0C8],rdx
       mov       rdx,2D067D90850
       mov       [rcx+0D0],rdx
       mov       rdx,2D067D90878
       mov       [rcx+0D8],rdx
       mov       rdx,2D067D908A0
       mov       [rcx+0E0],rdx
       mov       rdx,2D067D908C8
       mov       [rcx+0E8],rdx
       mov       rdx,2D067D908F0
       mov       [rcx+0F0],rdx
       mov       rdx,2D067D90918
       mov       [rcx+0F8],rdx
       mov       rdx,2D067D90940
       mov       [rcx+100],rdx
       mov       rdx,2D067D90968
       mov       [rcx+108],rdx
       mov       rdx,2D067D90990
       mov       [rcx+110],rdx
       mov       rdx,2D067D909B8
       mov       [rcx+118],rdx
       mov       rdx,2D067D909E0
       mov       [rcx+120],rdx
       mov       rdx,2D067D90A08
       mov       [rcx+128],rdx
       mov       rdx,2D067D90A30
       mov       [rcx+130],rdx
       mov       rdx,2D067D90A58
       mov       [rcx+138],rdx
       mov       rdx,2D067D90A80
       mov       [rcx+140],rdx
       mov       rdx,2D067D90AA8
       mov       [rcx+148],rdx
       mov       rdx,2D067D90AD0
       mov       [rcx+150],rdx
       mov       rdx,2D067D90AF8
       mov       [rcx+158],rdx
       mov       rdx,2D067D90B20
       mov       [rcx+160],rdx
       mov       rdx,2D067D90B48
       mov       [rcx+168],rdx
       mov       rdx,2D067D90B70
       mov       [rcx+170],rdx
       mov       rdx,2D067D90B98
       mov       [rcx+178],rdx
       mov       [rbp-48],rcx
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],2E
       jl        near ptr M01_L79
M01_L02:
       mov       rcx,2D067D83FA0
       call      00007FFAA9B21870
       mov       rcx,rax
       test      rcx,rcx
       je        near ptr M01_L164
M01_L03:
       test      rcx,rcx
       je        near ptr M01_L165
       mov       rax,offset MT_System.Reflection.RuntimeModule
       cmp       [rcx],rax
       jne       near ptr M01_L166
       mov       rcx,[rcx+10]
M01_L04:
       test      rcx,rcx
       je        near ptr M01_L167
       mov       rax,offset MT_System.Reflection.RuntimeAssembly
       cmp       [rcx],rax
       jne       near ptr M01_L168
       call      qword ptr [7FFA4A06C858]; System.Reflection.Assembly.GetTypes()
       mov       rbx,rax
M01_L05:
       mov       rcx,28FD2C020F8
       mov       r8,[rcx]
       test      r8,r8
       je        near ptr M01_L169
M01_L06:
       mov       rdx,rbx
       mov       rcx,7FFA4A69D5C0
       call      qword ptr [7FFA4A304318]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       test      rbx,rbx
       je        near ptr M01_L170
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L181
       mov       rdx,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Type>
       cmp       [rax],rdx
       jne       near ptr M01_L180
       mov       rdx,[rax+18]
       test      rdx,rdx
       je        near ptr M01_L94
       lea       rbx,[rdx+10]
       mov       esi,[rdx+8]
M01_L07:
       mov       r14,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0E8],ymm0
       vmovdqu   ymmword ptr [rbp-0C8],ymm0
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-1E0],ymm0
       vmovdqu   ymmword ptr [rbp-1C0],ymm0
       vmovdqu   ymmword ptr [rbp-1A0],ymm0
       vmovdqu   ymmword ptr [rbp-180],ymm0
       vmovdqu   ymmword ptr [rbp-160],ymm0
       vmovdqu   ymmword ptr [rbp-140],ymm0
       vmovdqu   ymmword ptr [rbp-128],ymm0
       xor       edx,edx
       mov       [rbp-1F0],edx
       mov       [rbp-1EC],edx
       mov       [rbp-1E8],edx
       lea       rdx,[rbp-0E8]
       mov       [rbp-108],rdx
       mov       dword ptr [rbp-100],8
       lea       rdx,[rbp-0E8]
       mov       [rbp-0F8],rdx
       mov       dword ptr [rbp-0F0],8
       test      esi,esi
       jle       short M01_L10
       xor       r15d,r15d
M01_L08:
       mov       r13,[rbx+r15]
       mov       rdx,r13
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M01_L09
       mov       rcx,[rbp-0F8]
       mov       edx,[rbp-0F0]
       mov       eax,[rbp-1E8]
       cmp       eax,edx
       jae       near ptr M01_L171
       mov       edx,eax
       lea       rcx,[rcx+rdx*8]
       mov       rdx,r13
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       ecx,[rbp-1E8]
       inc       ecx
       mov       [rbp-1E8],ecx
M01_L09:
       add       r15,8
       dec       esi
       jne       short M01_L08
M01_L10:
       mov       ebx,[rbp-1EC]
       add       ebx,[rbp-1E8]
       jo        near ptr M01_L204
       test      ebx,ebx
       je        near ptr M01_L95
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       test      ebx,ebx
       jl        near ptr M01_L172
       mov       edx,ebx
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       r8,[rsi+8]
       cmp       [r8+8],ebx
       jge       near ptr M01_L110
       mov       rcx,[rsi+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M01_L111
       mov       edx,4
M01_L11:
       mov       ecx,7FFFFFC7
       cmp       edx,7FFFFFC7
       cmova     edx,ecx
       cmp       edx,ebx
       cmovl     edx,ebx
       mov       rcx,rsi
       call      qword ptr [7FFA49F171E0]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L12:
       mov       [rsi+10],ebx
       mov       ebx,[rsi+10]
       mov       r14,[rsi+8]
       cmp       [r14+8],ebx
       jae       near ptr M01_L112
M01_L13:
       call      qword ptr [7FFA49F1F480]
       int       3
M01_L14:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFA49F15A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L31
M01_L15:
       mov       rcx,r13
       call      qword ptr [7FFA4A127258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L33
M01_L16:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],r13d
       je        short M01_L18
M01_L17:
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+24]
       mov       edx,r8d
       inc       r12d
       cmp       [r14+8],r12d
       mov       r8d,edx
       jae       near ptr M01_L36
       jmp       short M01_L13
M01_L18:
       mov       [rbp-6C],r8d
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       r10,[r14+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L140
       test      r10,r10
       je        near ptr M01_L138
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M01_L139
       cmp       rsi,r10
       sete      r9b
       movzx     r9d,r9b
M01_L19:
       test      r9d,r9d
       mov       r8d,[rbp-6C]
       je        short M01_L17
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L39
M01_L20:
       mov       ecx,[rdi+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L141
M01_L21:
       mov       ecx,eax
       call      qword ptr [7FFA49F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r8d,eax
M01_L22:
       mov       rcx,rdi
       mov       edx,r8d
       xor       r8d,r8d
       call      qword ptr [7FFA4A217C48]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
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
       jae       near ptr M01_L203
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       r14,rax
       mov       [rbp-478],r14
       jmp       near ptr M01_L37
M01_L23:
       mov       ecx,[rdi+3C]
       mov       r8d,ecx
       cmp       ecx,[r14+8]
       jae       near ptr M01_L203
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+3C],ecx
       dec       dword ptr [rdi+40]
       mov       eax,r8d
       mov       r8,r14
       mov       r14d,eax
       jmp       near ptr M01_L38
M01_L24:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFA49F15A70]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Initialize(Int32)
       jmp       near ptr M01_L80
M01_L25:
       mov       rcx,r13
       call      qword ptr [7FFA4A127258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L82
M01_L26:
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       cmp       [r14+rcx*8+20],r13d
       je        short M01_L28
M01_L27:
       mov       r10d,[r14+8]
       mov       r8d,r8d
       lea       rcx,[r8+r8*2]
       mov       r8d,[r14+rcx*8+24]
       mov       edx,r8d
       inc       r12d
       cmp       r10d,r12d
       mov       r8d,edx
       jae       near ptr M01_L85
       jmp       near ptr M01_L13
M01_L28:
       mov       [rbp-84],r8d
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       mov       r10,[r14+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L150
       test      r10,r10
       je        near ptr M01_L148
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r10],rcx
       jne       near ptr M01_L149
       cmp       rbx,r10
       sete      r9b
       movzx     r9d,r9b
M01_L29:
       test      r9d,r9d
       mov       r8d,[rbp-84]
       je        short M01_L27
       mov       ecx,[r14+8]
       mov       ecx,r8d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r14+rcx*8+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L78
M01_L30:
       call      M01_L205
       nop
       mov       rbx,[rbp-468]
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       rsi,[rbp-460]
       mov       rdi,[rbp-458]
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L14
M01_L31:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L137
       mov       rcx,[rbp-460]
       mov       [rbp-78],rcx
       xor       ecx,ecx
       mov       [rbp-80],rcx
       lea       rcx,[rbp-78]
       cmp       qword ptr [rbp-80],0
       jne       short M01_L32
       mov       rcx,[rbp-78]
       mov       [rbp-80],rcx
       lea       rcx,[rbp-80]
       cmp       qword ptr [rbp-80],0
       je        near ptr M01_L135
M01_L32:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L136
       mov       rcx,r13
       call      00007FFAA9B16270
       test      eax,eax
       je        near ptr M01_L15
M01_L33:
       mov       r13d,eax
M01_L34:
       xor       ecx,ecx
       mov       [rbp-80],rcx
M01_L35:
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
       jae       near ptr M01_L203
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rbp-478],rax
       mov       r8d,[rax]
       dec       r8d
M01_L36:
       cmp       [r14+8],r8d
       ja        near ptr M01_L16
       cmp       dword ptr [rdi+40],0
       jg        near ptr M01_L23
       mov       edx,[rdi+38]
       mov       [rbp-70],edx
       cmp       [r14+8],edx
       je        near ptr M01_L20
M01_L37:
       mov       edx,[rbp-70]
       mov       r14d,edx
       lea       ecx,[r14+1]
       mov       [rdi+38],ecx
       mov       rcx,[rdi+10]
       mov       r8,rcx
M01_L38:
       cmp       r14d,[r8+8]
       jae       near ptr M01_L203
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-470],r8
       lea       r10,[r8+rcx*8+10]
       mov       [rbp-480],r10
       mov       [r10+10],r13d
       mov       rax,[rbp-478]
       mov       ecx,[rax]
       dec       ecx
       mov       [r10+14],ecx
       mov       rcx,r10
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rsi,[rbp-480]
       lea       rcx,[rsi+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rbx,[rbp-478]
       mov       [rbx],r14d
       inc       dword ptr [rdi+44]
       cmp       r12d,64
       ja        near ptr M01_L142
M01_L39:
       mov       eax,[rbp-4C]
       inc       eax
       mov       [rbp-4C],eax
       cmp       dword ptr [rbp-4C],0D
       jge       near ptr M01_L01
M01_L40:
       mov       rcx,[rbp-48]
       mov       r8d,[rbp-4C]
       mov       rcx,[rcx+r8*8+10]
       mov       [rbp-460],rcx
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-468],rcx
       cmp       qword ptr [rbp-460],0
       je        near ptr M01_L143
       mov       rcx,28FD2C02110
       mov       rbx,[rcx]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,[rbx+20]
       mov       [rbp-60],rcx
       cmp       qword ptr [rbp-60],0
       je        near ptr M01_L133
       lea       rcx,[rbx+20]
       mov       r8,[rbp-60]
       test      rcx,rcx
       je        near ptr M01_L144
       xor       edx,edx
       call      00007FFAA9B1FBA0
       cmp       rax,[rbp-60]
       jne       near ptr M01_L133
M01_L41:
       mov       rbx,[rbp-60]
M01_L42:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-58],rbx
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-460]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L59
       mov       rcx,[rbp-460]
       mov       rcx,[rcx+18]
       test      cl,2
       jne       near ptr M01_L58
       test      dword ptr [rcx],80000000
       je        short M01_L46
       xor       eax,eax
       jmp       short M01_L47
M01_L43:
       mov       rcx,[rbp-460]
       call      qword ptr [7FFA4A1256C8]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
       jmp       near ptr M01_L53
M01_L44:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       call      qword ptr [7FFA4A12CBD0]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rbx,rax
       jmp       near ptr M01_L54
M01_L45:
       cmp       byte ptr [rbp-3F],0
       je        near ptr M01_L57
       jmp       near ptr M01_L66
M01_L46:
       test      byte ptr [rcx],30
       setne     al
       movzx     eax,al
M01_L47:
       movzx     ebx,al
M01_L48:
       test      ebx,ebx
       jne       near ptr M01_L60
       mov       rcx,[rbp-460]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L63
       mov       rcx,[rbp-460]
       mov       rcx,[rcx+18]
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L61
M01_L49:
       cmp       ebx,14
       je        near ptr M01_L62
       cmp       ebx,1D
       sete      al
       movzx     eax,al
M01_L50:
       test      eax,eax
       jne       near ptr M01_L64
       mov       rcx,[rbp-460]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L65
       mov       rcx,[rbp-460]
       call      00007FFAA9B22C30
M01_L51:
       test      eax,eax
       jne       near ptr M01_L45
       cmp       byte ptr [rbp-40],0
       jne       near ptr M01_L68
M01_L52:
       mov       rcx,[rbp-460]
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L69
       mov       rcx,[rbp-460]
       cmp       qword ptr [rcx+10],0
       je        near ptr M01_L43
       mov       rcx,[rbp-460]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M01_L43
M01_L53:
       mov       rbx,[rcx+18]
       test      rbx,rbx
       je        near ptr M01_L44
M01_L54:
       mov       rsi,[rbp-58]
       cmp       [rsi],sil
       test      rbx,rbx
       je        short M01_L56
       lea       rdx,[rbx+0C]
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M01_L56
       mov       r8,[rsi+8]
       mov       r14d,[rsi+18]
       lea       ecx,[r14+rdi]
       cmp       ecx,[r8+8]
       ja        near ptr M01_L72
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       edi,2
       jle       near ptr M01_L71
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA49F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L55:
       add       edi,r14d
       mov       [rsi+18],edi
M01_L56:
       movzx     r9d,word ptr [rbp-3C]
       cmp       r9d,2B
       jne       near ptr M01_L73
M01_L57:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rcx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A226DF8]; System.Text.StringBuilder.ToString()
       mov       [rbp-468],rax
       jmp       near ptr M01_L30
M01_L58:
       xor       eax,eax
       jmp       near ptr M01_L47
M01_L59:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+60]
       call      qword ptr [rax+8]
       mov       ebx,eax
       jmp       near ptr M01_L48
M01_L60:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+28]
       mov       rcx,[rbp-58]
       mov       r9d,[rax+8]
       mov       edx,[rbp-40]
       mov       [rbp-440],edx
       mov       dx,[rbp-3C]
       mov       [rbp-43C],dx
       lea       rdx,[rbp-440]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-460]
       mov       r8,rax
       call      qword ptr [7FFA4A5DFA38]; DotNetTips.Spargine.Core.TypeHelper.ProcessGenericType(System.Text.StringBuilder, System.Type, System.Type[], Int32, DotNetTips.Spargine.Core.DisplayNameOptions)
       jmp       near ptr M01_L57
M01_L61:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L49
M01_L62:
       mov       eax,1
       jmp       near ptr M01_L50
M01_L63:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L50
M01_L64:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+68]
       call      qword ptr [rax+8]
       mov       [rbp-68],rax
       lea       rcx,[rbp-58]
       lea       rdx,[rbp-68]
       lea       r8,[rbp-40]
       call      qword ptr [7FFA4A5DF318]; DotNetTips.Spargine.Core.TypeHelper.ProcessType(System.Text.StringBuilder ByRef, System.Type ByRef, DotNetTips.Spargine.Core.DisplayNameOptions ByRef)
       mov       rcx,[rbp-58]
       mov       rdx,2D067D90EC8
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A217A80]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L57
M01_L65:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+30]
       jmp       near ptr M01_L51
M01_L66:
       mov       rbx,[rbp-58]
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A217A80]; System.Text.StringBuilder.Append(System.String)
       jmp       near ptr M01_L57
M01_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L68:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       test      rax,rax
       jne       short M01_L70
       jmp       near ptr M01_L52
M01_L69:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rbx,rax
       jmp       near ptr M01_L54
M01_L70:
       mov       rcx,[rbp-460]
       mov       rax,[rbp-460]
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rbx,rax
       jmp       near ptr M01_L54
M01_L71:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       edi,2
       jne       near ptr M01_L55
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       near ptr M01_L55
M01_L72:
       mov       rcx,rsi
       mov       r8d,edi
       call      qword ptr [7FFA4A217A38]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M01_L56
M01_L73:
       mov       rcx,[rbp-58]
       movzx     r8d,word ptr [rbp-3C]
       mov       r9,[rbp-58]
       mov       edx,[r9+1C]
       add       edx,[r9+18]
       mov       r9d,edx
       sub       r9d,[rbx+8]
       jo        near ptr M01_L67
       mov       edx,[rbx+8]
       mov       [rsp+20],edx
       mov       edx,2B
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5DF798]; System.Text.StringBuilder.Replace(Char, Char, Int32, Int32)
       jmp       near ptr M01_L57
M01_L74:
       mov       r8,[rbp-4A0]
M01_L75:
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
       jae       near ptr M01_L203
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rbp-490],rax
M01_L76:
       lea       ecx,[r14+1]
       mov       [rdi+38],ecx
       mov       rcx,[rdi+10]
       mov       r8,rcx
M01_L77:
       cmp       r14d,[r8+8]
       jae       near ptr M01_L203
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-488],r8
       lea       r10,[r8+rcx*8+10]
       mov       [rbp-498],r10
       mov       [r10+10],r13d
       mov       rax,[rbp-490]
       mov       ecx,[rax]
       dec       ecx
       mov       [r10+14],ecx
       mov       rcx,r10
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-498]
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       inc       r14d
       mov       rsi,[rbp-490]
       mov       [rsi],r14d
       inc       dword ptr [rdi+44]
       cmp       r12d,64
       ja        near ptr M01_L163
M01_L78:
       mov       ecx,[rbp-4C]
       inc       ecx
       mov       [rbp-4C],ecx
       cmp       dword ptr [rbp-4C],2E
       jge       near ptr M01_L02
M01_L79:
       mov       rcx,[rbp-48]
       mov       edx,[rbp-4C]
       mov       rbx,[rcx+rdx*8+10]
       mov       dword ptr [rsp+20],2E
       mov       rcx,rbx
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFA4A5DF2D0]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M01_L182
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L24
M01_L80:
       mov       r14,[rdi+10]
       mov       r15,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [r15],rcx
       jne       near ptr M01_L147
       mov       [rbp-90],rbx
       xor       ecx,ecx
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       cmp       qword ptr [rbp-98],0
       jne       short M01_L81
       mov       rcx,[rbp-90]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-98]
       cmp       qword ptr [rbp-98],0
       je        near ptr M01_L145
M01_L81:
       mov       r13,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r13],rcx
       jne       near ptr M01_L146
       mov       rcx,r13
       call      00007FFAA9B16270
       test      eax,eax
       je        near ptr M01_L25
M01_L82:
       mov       r13d,eax
M01_L83:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M01_L84:
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
       jae       near ptr M01_L203
       mov       edx,edx
       lea       rax,[rcx+rdx*4+10]
       mov       [rbp-490],rax
       mov       r8d,[rax]
       dec       r8d
M01_L85:
       mov       r10d,[r14+8]
       cmp       r10d,r8d
       ja        near ptr M01_L26
       cmp       dword ptr [rdi+40],0
       jg        near ptr M01_L93
       mov       r14d,[rdi+38]
       cmp       r10d,r14d
       jne       near ptr M01_L76
       mov       ecx,[rdi+38]
       lea       eax,[rcx+rcx]
       cmp       eax,7FFFFFC3
       ja        near ptr M01_L151
M01_L86:
       mov       ecx,eax
       call      qword ptr [7FFA49F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
M01_L87:
       mov       [rbp-9C],eax
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4A0],rax
       mov       r10d,[rdi+38]
       mov       [rbp-0A0],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-4A8],rdx
       test      rdx,rdx
       je        near ptr M01_L159
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M01_L156
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L155
       cmp       r10d,[rdx+8]
       ja        near ptr M01_L154
       cmp       r10d,[rax+8]
       ja        near ptr M01_L153
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L158
       mov       rax,[rbp-4A0]
       cmp       r8,4000
       ja        near ptr M01_L157
       mov       rcx,r9
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L152
M01_L88:
       movsxd    rdx,dword ptr [rbp-9C]
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,[rbp-9C]
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+30],rax
       xor       ecx,ecx
       mov       edx,[rbp-0A0]
       test      edx,edx
       jle       near ptr M01_L74
       mov       r8,[rbp-4A0]
       cmp       [r8+8],edx
       jl        near ptr M01_L162
M01_L89:
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       cmp       dword ptr [r8+rax*8+24],0FFFFFFFF
       jl        short M01_L90
       mov       r10d,[r8+rax*8+20]
       mov       r9,[rdi+8]
       mov       r11d,r10d
       imul      r11,[rdi+30]
       shr       r11,20
       inc       r11
       mov       r10d,[r9+8]
       imul      r10,r11
       shr       r10,20
       cmp       r10d,[r9+8]
       jae       near ptr M01_L203
       mov       r10d,r10d
       lea       r10,[r9+r10*4+10]
       mov       r9d,[r10]
       dec       r9d
       mov       [r8+rax*8+24],r9d
       lea       eax,[rcx+1]
       mov       [r10],eax
M01_L90:
       inc       ecx
       cmp       ecx,edx
       jl        short M01_L89
       jmp       near ptr M01_L75
M01_L91:
       cmp       ecx,[r8+8]
       jae       near ptr M01_L203
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       cmp       dword ptr [r8+rax*8+24],0FFFFFFFF
       jl        short M01_L92
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       mov       r10d,[r8+rax*8+20]
       mov       r9,[rdi+8]
       imul      r10,[rdi+30]
       shr       r10,20
       inc       r10
       mov       eax,[r9+8]
       imul      r10,rax
       shr       r10,20
       cmp       r10d,[r9+8]
       jae       near ptr M01_L203
       mov       eax,r10d
       lea       r10,[r9+rax*4+10]
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       mov       r9d,[r10]
       dec       r9d
       mov       [r8+rax*8+24],r9d
       lea       eax,[rcx+1]
       mov       [r10],eax
M01_L92:
       inc       ecx
       cmp       ecx,edx
       jl        short M01_L91
       jmp       near ptr M01_L75
M01_L93:
       mov       ecx,[rdi+3C]
       mov       r8d,ecx
       cmp       ecx,r10d
       jae       near ptr M01_L203
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r14+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+3C],ecx
       dec       dword ptr [rdi+40]
       mov       eax,r8d
       mov       r8,r14
       mov       r14d,eax
       jmp       near ptr M01_L77
M01_L94:
       xor       ebx,ebx
       xor       esi,esi
       jmp       near ptr M01_L07
M01_L95:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,28FD2C01B00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L96:
       mov       r8d,[rbp-1F0]
       test      r8d,r8d
       jne       near ptr M01_L179
M01_L97:
       mov       ebx,[rsi+14]
       xor       r14d,r14d
       jmp       near ptr M01_L100
M01_L98:
       mov       [rbp-21C],r9d
       mov       ecx,r9d
       lea       rcx,[rcx+rcx*2]
       mov       r11,[r12+rcx*8+10]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       mov       rdx,[rbp-4B8]
       cmp       [rdx],rcx
       jne       near ptr M01_L188
       mov       rdx,[rbp-4B8]
       test      r11,r11
       je        near ptr M01_L186
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r11],rcx
       jne       near ptr M01_L187
       cmp       r15,r11
       sete      cl
       movzx     ecx,cl
M01_L99:
       test      ecx,ecx
       mov       [rbp-4B8],rdx
       mov       r9d,[rbp-21C]
       je        near ptr M01_L119
       mov       ecx,r9d
       lea       rcx,[rcx+rcx*2]
       lea       rcx,[r12+rcx*8+18]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L100:
       cmp       ebx,[rsi+14]
       jne       near ptr M01_L202
       cmp       r14d,[rsi+10]
       jae       near ptr M01_L132
       mov       rcx,[rsi+8]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L203
       mov       r15,[rcx+r14*8+10]
       inc       r14d
       mov       dword ptr [rsp+20],2E
       mov       rcx,r15
       mov       edx,1
       mov       r8d,1
       mov       r9d,1
       call      qword ptr [7FFA4A5DF2D0]; DotNetTips.Spargine.Core.TypeHelper.GetTypeDisplayName(System.Type, Boolean, Boolean, Boolean, Char)
       mov       r13,rax
       test      r15,r15
       je        near ptr M01_L182
       cmp       qword ptr [rdi+8],0
       je        near ptr M01_L116
M01_L101:
       mov       r12,[rdi+10]
       mov       rax,[rdi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       mov       [rbp-4B8],rax
       cmp       [rax],rcx
       jne       near ptr M01_L185
       mov       rax,[rbp-4B8]
       mov       [rbp-228],r15
       xor       ecx,ecx
       mov       [rbp-230],rcx
       lea       rcx,[rbp-228]
       cmp       qword ptr [rbp-230],0
       jne       short M01_L102
       mov       rcx,[rbp-228]
       mov       [rbp-230],rcx
       lea       rcx,[rbp-230]
       cmp       qword ptr [rbp-230],0
       je        near ptr M01_L183
M01_L102:
       mov       rdx,[rcx]
       mov       [rbp-4E0],rdx
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdx],rcx
       jne       near ptr M01_L184
       mov       [rbp-4B8],rax
       mov       rcx,rdx
       call      00007FFAA9B16270
       test      eax,eax
       je        near ptr M01_L117
M01_L103:
       mov       edx,eax
M01_L104:
       mov       eax,edx
M01_L105:
       xor       ecx,ecx
       mov       [rbp-230],rcx
M01_L106:
       mov       [rbp-214],eax
       xor       r8d,r8d
       mov       [rbp-218],r8d
       mov       rcx,[rdi+8]
       mov       edx,eax
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       r10d,[rcx+8]
       imul      rdx,r10
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L203
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       [rbp-4C0],r10
       mov       r9d,[r10]
       dec       r9d
M01_L107:
       cmp       [r12+8],r9d
       ja        near ptr M01_L118
       cmp       dword ptr [rdi+40],0
       jg        near ptr M01_L131
       mov       r9d,[rdi+38]
       mov       [rbp-220],r9d
       cmp       [r12+8],r9d
       je        near ptr M01_L120
M01_L108:
       mov       r9d,[rbp-220]
       mov       r12d,r9d
       lea       ecx,[r12+1]
       mov       [rdi+38],ecx
       mov       rcx,[rdi+10]
       mov       r9,rcx
M01_L109:
       cmp       r12d,[r9+8]
       jae       near ptr M01_L203
       mov       ecx,r12d
       lea       rcx,[rcx+rcx*2]
       mov       [rbp-4B0],r9
       lea       r11,[r9+rcx*8+10]
       mov       [rbp-4C8],r11
       mov       [r11+10],eax
       mov       r10,[rbp-4C0]
       mov       ecx,[r10]
       dec       ecx
       mov       [r11+14],ecx
       mov       rcx,r11
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       r15,[rbp-4C8]
       lea       rcx,[r15+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       inc       r12d
       mov       r13,[rbp-4C0]
       mov       [r13],r12d
       inc       dword ptr [rdi+44]
       cmp       dword ptr [rbp-218],64
       jbe       near ptr M01_L100
       jmp       near ptr M01_L201
M01_L110:
       cmp       ebx,[rsi+10]
       jge       near ptr M01_L12
       mov       r8d,[rsi+10]
       sub       r8d,ebx
       mov       rcx,[rsi+8]
       mov       edx,ebx
       call      qword ptr [7FFA4A83D728]; System.Array.Clear(System.Array, Int32, Int32)
       jmp       near ptr M01_L12
M01_L111:
       mov       rdx,[rsi+8]
       mov       edx,[rdx+8]
       add       edx,edx
       jmp       near ptr M01_L11
M01_L112:
       add       r14,10
       mov       r15,r14
       mov       r13d,ebx
       mov       r12d,[rbp-1F0]
       test      r12d,r12d
       jne       near ptr M01_L173
M01_L113:
       mov       ecx,[rbp-1E8]
       cmp       ecx,[rbp-0F0]
       ja        short M01_L114
       mov       rdx,[rbp-0F8]
       cmp       ecx,r13d
       ja        short M01_L115
       mov       r8d,ecx
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M01_L178
       mov       rcx,r15
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       je        near ptr M01_L96
       jmp       near ptr M01_L177
M01_L114:
       call      qword ptr [7FFA4A12FA50]
       int       3
M01_L115:
       call      qword ptr [7FFA4A3AC390]
       int       3
M01_L116:
       xor       ecx,ecx
       call      qword ptr [7FFA49F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Int32[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4D0],rax
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4D8],rax
       mov       dword ptr [rdi+3C],0FFFFFFFF
       mov       rax,0FFFFFFFFFFFFFFFF
       mov       ecx,r12d
       xor       edx,edx
       div       rcx
       inc       rax
       mov       [rdi+30],rax
       lea       rcx,[rdi+8]
       mov       rdx,[rbp-4D0]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rdi+10]
       mov       rdx,[rbp-4D8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L101
M01_L117:
       mov       rcx,[rbp-4E0]
       call      qword ptr [7FFA4A127258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L103
M01_L118:
       mov       ecx,r9d
       lea       rcx,[rcx+rcx*2]
       cmp       [r12+rcx*8+20],eax
       je        near ptr M01_L98
M01_L119:
       mov       r9d,r9d
       lea       rcx,[r9+r9*2]
       mov       r9d,[r12+rcx*8+24]
       mov       r8d,[rbp-218]
       inc       r8d
       mov       [rbp-218],r8d
       cmp       [r12+8],r8d
       mov       eax,[rbp-214]
       jae       near ptr M01_L107
       jmp       near ptr M01_L13
M01_L120:
       mov       ecx,[rdi+38]
       lea       r10d,[rcx+rcx]
       cmp       r10d,7FFFFFC3
       ja        near ptr M01_L189
M01_L121:
       mov       ecx,r10d
       call      qword ptr [7FFA49F15A88]; System.Collections.HashHelpers.GetPrime(Int32)
       mov       r12d,eax
M01_L122:
       movsxd    rdx,r12d
       mov       rcx,offset MT_System.Collections.Generic.Dictionary<System.Type, System.String>+Entry[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       [rbp-4E8],rax
       mov       r10d,[rdi+38]
       mov       [rbp-234],r10d
       mov       rcx,[rdi+10]
       mov       rdx,rcx
       mov       [rbp-4F0],rdx
       test      rdx,rdx
       je        near ptr M01_L198
       mov       rcx,[rdx]
       cmp       rcx,[rax]
       jne       near ptr M01_L195
       cmp       dword ptr [rcx+4],18
       jne       near ptr M01_L194
       cmp       r10d,[rdx+8]
       ja        near ptr M01_L193
       cmp       r10d,[rax+8]
       ja        near ptr M01_L192
       mov       r8d,r10d
       movzx     r9d,word ptr [rcx]
       imul      r8,r9
       add       rdx,10
       lea       r9,[rax+10]
       test      dword ptr [rcx],1000000
       je        near ptr M01_L197
       mov       rax,[rbp-4E8]
       cmp       r8,4000
       ja        near ptr M01_L196
       mov       rcx,r9
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L191
M01_L123:
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
       mov       r12d,[rbp-234]
       test      r12d,r12d
       jle       near ptr M01_L130
       mov       r8,[rbp-4E8]
       cmp       [r8+8],r12d
       jl        near ptr M01_L127
M01_L124:
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [r8+rdx*8+24],0FFFFFFFF
       jl        short M01_L125
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
       jae       near ptr M01_L203
       mov       edx,r10d
       lea       rdx,[rax+rdx*4+10]
       mov       eax,ecx
       lea       r10,[rax+rax*2]
       mov       eax,[rdx]
       dec       eax
       mov       [r8+r10*8+24],eax
       lea       eax,[rcx+1]
       mov       [rdx],eax
M01_L125:
       inc       ecx
       cmp       ecx,r12d
       jl        short M01_L124
M01_L126:
       lea       rcx,[rdi+10]
       mov       rdx,r8
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+8]
       mov       r12d,[rbp-214]
       mov       edx,r12d
       imul      rdx,[rdi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M01_L203
       mov       edx,edx
       lea       r10,[rcx+rdx*4+10]
       mov       rax,r10
       mov       [rbp-4C0],rax
       mov       eax,r12d
       jmp       near ptr M01_L108
M01_L127:
       mov       edx,[r8+8]
M01_L128:
       cmp       ecx,[r8+8]
       jae       near ptr M01_L203
       mov       edx,ecx
       lea       rdx,[rdx+rdx*2]
       cmp       dword ptr [r8+rdx*8+24],0FFFFFFFF
       jl        short M01_L129
       cmp       ecx,[r8+8]
       jae       near ptr M01_L203
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
       jae       near ptr M01_L203
       mov       edx,r10d
       lea       rdx,[rax+rdx*4+10]
       cmp       ecx,[r8+8]
       jae       near ptr M01_L203
       mov       eax,ecx
       lea       rax,[rax+rax*2]
       mov       r10d,[rdx]
       dec       r10d
       mov       [r8+rax*8+24],r10d
       lea       eax,[rcx+1]
       mov       [rdx],eax
M01_L129:
       inc       ecx
       cmp       ecx,r12d
       jl        near ptr M01_L128
       jmp       near ptr M01_L126
M01_L130:
       mov       r8,[rbp-4E8]
       jmp       near ptr M01_L126
M01_L131:
       mov       ecx,[rdi+3C]
       mov       r9d,ecx
       mov       ecx,[rdi+3C]
       cmp       ecx,[r12+8]
       jae       near ptr M01_L203
       lea       rcx,[rcx+rcx*2]
       mov       ecx,[r12+rcx*8+24]
       neg       ecx
       add       ecx,0FFFFFFFD
       mov       [rdi+3C],ecx
       dec       dword ptr [rdi+40]
       mov       ecx,r9d
       mov       r9,r12
       mov       r12d,ecx
       jmp       near ptr M01_L109
M01_L132:
       mov       rax,rdi
       add       rsp,4E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L133:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5D49F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L134
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L41
M01_L134:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M01_L42
M01_L135:
       xor       r13d,r13d
       jmp       near ptr M01_L34
M01_L136:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L34
M01_L137:
       mov       rcx,r15
       mov       rdx,[rbp-460]
       mov       r11,7FFA49E60BD8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L35
M01_L138:
       mov       r8d,[rbp-6C]
       jmp       near ptr M01_L17
M01_L139:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       r9d,eax
       jmp       near ptr M01_L19
M01_L140:
       mov       rcx,r15
       mov       r8,rsi
       mov       rdx,r10
       mov       r11,7FFA49E60BE0
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M01_L19
M01_L141:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L21
       mov       r8d,7FFFFFC3
       jmp       near ptr M01_L22
M01_L142:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L39
       mov       r14,[rbp-470]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFA4A217C48]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L39
M01_L143:
       call      qword ptr [7FFA4A52E2F8]
       mov       ecx,214D
       mov       rdx,7FFA4A255B58
       call      qword ptr [7FFA49F1F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A255B58
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFA4A255B58
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A8C6778]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A8C56B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L144:
       call      qword ptr [7FFA4A8C4768]
       int       3
M01_L145:
       xor       r13d,r13d
       jmp       near ptr M01_L83
M01_L146:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M01_L83
M01_L147:
       mov       rcx,r15
       mov       rdx,rbx
       mov       r11,7FFA49E60BE8
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M01_L84
M01_L148:
       mov       r8d,[rbp-84]
       jmp       near ptr M01_L27
M01_L149:
       mov       rcx,r10
       mov       rdx,rbx
       mov       r10,[r10]
       mov       r10,[r10+40]
       call      qword ptr [r10+10]
       mov       r9d,eax
       jmp       near ptr M01_L29
M01_L150:
       mov       rcx,r15
       mov       r8,rbx
       mov       rdx,r10
       mov       r11,7FFA49E60BF0
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M01_L29
M01_L151:
       cmp       ecx,7FFFFFC3
       jge       near ptr M01_L86
       mov       edx,7FFFFFC3
       mov       eax,edx
       jmp       near ptr M01_L87
M01_L152:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L88
M01_L153:
       jmp       short M01_L160
M01_L154:
       jmp       short M01_L160
M01_L155:
       jmp       short M01_L160
M01_L156:
       jmp       short M01_L160
M01_L157:
       mov       rcx,r9
       call      qword ptr [7FFA4A52E148]
       jmp       near ptr M01_L88
M01_L158:
       mov       rcx,r9
       call      qword ptr [7FFA49F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L88
M01_L159:
       xor       ecx,ecx
       mov       [rbp-0A4],ecx
       jmp       short M01_L161
M01_L160:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-0A4],eax
       mov       rax,[rbp-4A0]
M01_L161:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-0A0]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-4A8]
       mov       edx,[rbp-0A4]
       mov       r8,[rbp-4A0]
       call      qword ptr [7FFA4A83F540]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L88
M01_L162:
       mov       r10d,[r8+8]
       jmp       near ptr M01_L91
M01_L163:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L78
       mov       r14,[rbp-488]
       mov       edx,[r14+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFA4A217C48]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L78
M01_L164:
       mov       rcx,2D067D83FA0
       call      qword ptr [7FFA4A125710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L165:
       xor       ecx,ecx
       jmp       near ptr M01_L04
M01_L166:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       jmp       near ptr M01_L04
M01_L167:
       xor       esi,esi
       jmp       near ptr M01_L97
M01_L168:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rbx,rax
       jmp       near ptr M01_L05
M01_L169:
       mov       rcx,offset MT_System.Func<System.Type, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28FD2C020F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c.<BuiltInTypeNamesNoCache>b__54_0(System.Type)
       call      qword ptr [7FFA49F16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28FD2C020F8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
       jmp       near ptr M01_L06
M01_L170:
       mov       ecx,11
       call      qword ptr [7FFA49F1F930]
       int       3
M01_L171:
       lea       rcx,[rbp-1F0]
       mov       r8,r13
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Type>
       call      qword ptr [7FFA4A83D338]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].AddSlow(System.__Canon)
       jmp       near ptr M01_L09
M01_L172:
       mov       ecx,16
       mov       edx,0D
       call      qword ptr [7FFA4A5259F8]
       int       3
M01_L173:
       vmovdqu   xmm0,xmmword ptr [rbp-108]
       vmovdqu   xmmword ptr [rbp-450],xmm0
       lea       r8,[rbp-450]
       lea       rcx,[rbp-200]
       mov       rdx,offset MT_System.Span<System.Type>
       call      qword ptr [7FFA4A83D518]; System.Span`1[[System.__Canon, System.Private.CoreLib]].op_Implicit(System.Span`1<System.__Canon>)
       mov       r15d,[rbp-1F8]
       cmp       r15d,ebx
       ja        near ptr M01_L115
       mov       r8d,r15d
       shl       r8,3
       mov       rcx,r14
       mov       rdx,[rbp-200]
       call      qword ptr [7FFA49F157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r15d
       lea       rcx,[r14+rcx*8]
       sub       ebx,r15d
       mov       r13d,ebx
       mov       r15,rcx
       dec       r12d
       je        near ptr M01_L113
       lea       rcx,[rbp-210]
       lea       r8,[rbp-1E0]
       mov       rdx,7FFA4A87F8C0
       mov       r9d,1B
       call      qword ptr [7FFA4A83D560]; <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan[[System.Collections.Generic.SegmentedArrayBuilder`1+Arrays[[System.__Canon, System.Private.CoreLib]], System.Linq],[System.__Canon, System.Private.CoreLib]](Arrays<System.__Canon> ByRef, Int32)
       cmp       r12d,[rbp-208]
       ja        near ptr M01_L114
       mov       rbx,[rbp-210]
       mov       r14d,r12d
       xor       r12d,r12d
M01_L174:
       mov       r8,[rbx+r12*8]
       test      r8,r8
       jne       short M01_L175
       xor       edx,edx
       xor       eax,eax
       jmp       short M01_L176
M01_L175:
       lea       rdx,[r8+10]
       mov       eax,[r8+8]
M01_L176:
       cmp       eax,r13d
       jg        near ptr M01_L115
       mov       [rbp-434],eax
       mov       r8d,eax
       shl       r8,3
       mov       rcx,r15
       call      qword ptr [7FFA49F157A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbp-434]
       mov       edx,ecx
       lea       r15,[r15+rdx*8]
       sub       r13d,ecx
       inc       r12d
       cmp       r12d,r14d
       jl        short M01_L174
       jmp       near ptr M01_L113
M01_L177:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L96
M01_L178:
       mov       rcx,r15
       call      qword ptr [7FFA4A52E148]
       jmp       near ptr M01_L96
M01_L179:
       lea       rcx,[rbp-1F0]
       mov       rdx,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Type>
       call      qword ptr [7FFA4A83D680]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ReturnArrays(Int32)
       jmp       near ptr M01_L97
M01_L180:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       near ptr M01_L97
M01_L181:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA4A5D73D8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       jmp       near ptr M01_L97
M01_L182:
       mov       ecx,4
       call      qword ptr [7FFA49F1FD38]
       int       3
M01_L183:
       xor       edx,edx
       mov       [rbp-4B8],rax
       mov       eax,edx
       jmp       near ptr M01_L105
M01_L184:
       mov       [rbp-4B8],rax
       mov       rcx,rdx
       mov       rdx,[rdx]
       mov       rdx,[rdx+40]
       call      qword ptr [rdx+18]
       mov       edx,eax
       jmp       near ptr M01_L104
M01_L185:
       mov       rax,[rbp-4B8]
       mov       [rbp-4B8],rax
       mov       rcx,rax
       mov       rdx,r15
       mov       r11,7FFA49E60BF8
       call      qword ptr [r11]
       jmp       near ptr M01_L106
M01_L186:
       mov       [rbp-4B8],rdx
       mov       r9d,[rbp-21C]
       jmp       near ptr M01_L119
M01_L187:
       mov       [rbp-4B8],rdx
       mov       rcx,r11
       mov       rdx,r15
       mov       r11,[r11]
       mov       r11,[r11+40]
       call      qword ptr [r11+10]
       mov       ecx,eax
       mov       rdx,[rbp-4B8]
       jmp       near ptr M01_L99
M01_L188:
       mov       rdx,[rbp-4B8]
       mov       [rbp-4B8],rdx
       mov       rcx,rdx
       mov       r8,r15
       mov       rdx,r11
       mov       r11,7FFA49E60C00
       call      qword ptr [r11]
       mov       ecx,eax
       mov       rdx,[rbp-4B8]
       jmp       near ptr M01_L99
M01_L189:
       cmp       ecx,7FFFFFC3
       jge       short M01_L190
       mov       r12d,7FFFFFC3
       jmp       near ptr M01_L122
M01_L190:
       jmp       near ptr M01_L121
M01_L191:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L123
M01_L192:
       jmp       short M01_L199
M01_L193:
       jmp       short M01_L199
M01_L194:
       jmp       short M01_L199
M01_L195:
       jmp       short M01_L199
M01_L196:
       mov       rcx,r9
       call      qword ptr [7FFA4A52E148]
       jmp       near ptr M01_L123
M01_L197:
       mov       rcx,r9
       call      qword ptr [7FFA49F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L123
M01_L198:
       xor       ecx,ecx
       mov       [rbp-238],ecx
       jmp       short M01_L200
M01_L199:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       [rbp-238],eax
       mov       rax,[rbp-4E8]
M01_L200:
       mov       rcx,rax
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       eax,[rbp-234]
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,[rbp-4F0]
       mov       edx,[rbp-238]
       mov       r8,[rbp-4E8]
       call      qword ptr [7FFA4A83F540]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L123
M01_L201:
       mov       r12,[rbp-4B0]
       mov       r15,[rbp-4B8]
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L100
       mov       edx,[r12+8]
       mov       rcx,rdi
       mov       r8d,1
       call      qword ptr [7FFA4A217C48]; System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Resize(Int32, Boolean)
       jmp       near ptr M01_L100
M01_L202:
       call      qword ptr [7FFA49F1FC48]
       int       3
M01_L203:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L204:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L205:
       sub       rsp,38
       vzeroupper
       mov       rbx,[rbp-58]
       cmp       dword ptr [rbx+20],0
       jge       short M01_L206
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       rsi,rax
       call      qword ptr [7FFA4A8C5C68]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA4A4A6088]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L206:
       cmp       qword ptr [rbx+10],0
       jne       short M01_L207
       xor       eax,eax
       mov       [rbx+18],rax
       jmp       near ptr M01_L227
M01_L207:
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       mov       esi,eax
       neg       esi
       test      esi,esi
       jle       short M01_L209
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+18]
       mov       r8d,ecx
       mov       eax,esi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M01_L208
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,esi
       xor       r8d,r8d
       call      qword ptr [7FFA4A3A7348]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],esi
       jmp       near ptr M01_L227
M01_L208:
       mov       rcx,rbx
       mov       r8d,esi
       xor       edx,edx
       call      qword ptr [7FFA4A8C78A0]
       jmp       near ptr M01_L227
M01_L209:
       mov       rsi,rbx
       cmp       dword ptr [rbx+1C],0
       jle       short M01_L211
M01_L210:
       mov       rsi,[rsi+10]
       cmp       dword ptr [rsi+1C],0
       jg        short M01_L210
M01_L211:
       cmp       rsi,rbx
       je        near ptr M01_L226
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
       jge       short M01_L212
       mov       edx,eax
M01_L212:
       cmp       ecx,edx
       jle       short M01_L213
       mov       ecx,edx
M01_L213:
       sub       ecx,[rsi+1C]
       mov       rdx,[rsi+8]
       cmp       [rdx+8],ecx
       jge       near ptr M01_L224
       cmp       ecx,400
       jge       short M01_L214
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       jmp       short M01_L215
M01_L214:
       xor       edx,edx
       call      qword ptr [7FFA4A52E418]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rdi,rax
M01_L215:
       mov       r14,[rsi+8]
       mov       r15d,[rsi+18]
       test      r14,r14
       je        short M01_L218
       test      rdi,rdi
       je        short M01_L219
       mov       rcx,[r14]
       cmp       rcx,[rdi]
       jne       short M01_L219
       cmp       dword ptr [rcx+4],18
       jne       short M01_L219
       cmp       r15d,[r14+8]
       ja        short M01_L219
       cmp       r15d,[rdi+8]
       ja        short M01_L219
       mov       r8d,r15d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r14+10]
       lea       rax,[rdi+10]
       test      dword ptr [rcx],1000000
       je        short M01_L217
       cmp       r8,4000
       ja        short M01_L216
       mov       rcx,rax
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L223
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L223
M01_L216:
       mov       rcx,rax
       call      qword ptr [7FFA4A52E148]
       jmp       short M01_L223
M01_L217:
       mov       rcx,rax
       call      qword ptr [7FFA49F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L223
M01_L218:
       xor       r13d,r13d
       jmp       short M01_L220
M01_L219:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       r13d,eax
M01_L220:
       test      rdi,rdi
       jne       short M01_L221
       xor       r9d,r9d
       jmp       short M01_L222
M01_L221:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M01_L222:
       mov       [rsp+20],r15d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       edx,r13d
       mov       r8,rdi
       call      qword ptr [7FFA4A83F540]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M01_L223:
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L225
M01_L224:
       mov       rdx,[rsi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L225:
       mov       rdx,[rsi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rsi+1C]
       mov       [rbx+1C],edx
M01_L226:
       mov       edx,[rsi+1C]
       neg       edx
       mov       [rbx+18],edx
M01_L227:
       mov       rax,28FD2C02110
       mov       rsi,[rax]
       mov       rdi,[rsi+10]
       mov       rax,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rax
       jne       near ptr M01_L249
       mov       rax,[rbx+8]
       mov       eax,[rax+8]
       add       eax,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       eax,[rdx+0C]
       jg        near ptr M01_L254
       cmp       dword ptr [rbx+20],0
       jge       short M01_L228
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       rbx,rax
       call      qword ptr [7FFA4A8C5C68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFA4A4A6088]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L228:
       cmp       qword ptr [rbx+10],0
       jne       short M01_L229
       xor       edx,edx
       mov       [rbx+18],rdx
       jmp       near ptr M01_L250
M01_L229:
       mov       eax,[rbx+1C]
       add       eax,[rbx+18]
       mov       edi,eax
       neg       edi
       test      edi,edi
       jle       short M01_L231
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+18]
       mov       r8d,ecx
       mov       eax,edi
       add       r8,rax
       mov       eax,[rdx+8]
       cmp       r8,rax
       ja        short M01_L230
       mov       ecx,ecx
       lea       rcx,[rdx+rcx*2+10]
       mov       edx,edi
       xor       r8d,r8d
       call      qword ptr [7FFA4A3A7348]; System.SpanHelpers.Fill[[System.Char, System.Private.CoreLib]](Char ByRef, UIntPtr, Char)
       add       [rbx+18],edi
       jmp       near ptr M01_L250
M01_L230:
       mov       rcx,rbx
       mov       r8d,edi
       xor       edx,edx
       call      qword ptr [7FFA4A8C78A0]
       jmp       near ptr M01_L250
M01_L231:
       mov       rdi,rbx
       cmp       dword ptr [rbx+1C],0
       jle       short M01_L233
M01_L232:
       mov       rdi,[rdi+10]
       cmp       dword ptr [rdi+1C],0
       jg        short M01_L232
M01_L233:
       cmp       rdi,rbx
       je        near ptr M01_L248
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
       jge       short M01_L234
       mov       edx,eax
M01_L234:
       cmp       ecx,edx
       jle       short M01_L235
       mov       ecx,edx
M01_L235:
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       near ptr M01_L246
       cmp       ecx,400
       jge       short M01_L236
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       jmp       short M01_L237
M01_L236:
       xor       edx,edx
       call      qword ptr [7FFA4A52E418]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
M01_L237:
       mov       r15,[rdi+8]
       mov       r13d,[rdi+18]
       test      r15,r15
       je        short M01_L240
       test      r14,r14
       je        short M01_L241
       mov       rcx,[r15]
       cmp       rcx,[r14]
       jne       short M01_L241
       cmp       dword ptr [rcx+4],18
       jne       short M01_L241
       cmp       r13d,[r15+8]
       ja        short M01_L241
       cmp       r13d,[r14+8]
       ja        short M01_L241
       mov       r8d,r13d
       movzx     edx,word ptr [rcx]
       imul      r8,rdx
       lea       rdx,[r15+10]
       lea       rax,[r14+10]
       test      dword ptr [rcx],1000000
       je        short M01_L239
       cmp       r8,4000
       ja        short M01_L238
       mov       rcx,rax
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L245
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L245
M01_L238:
       mov       rcx,rax
       call      qword ptr [7FFA4A52E148]
       jmp       short M01_L245
M01_L239:
       mov       rcx,rax
       call      qword ptr [7FFA49F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L245
M01_L240:
       xor       r12d,r12d
       jmp       short M01_L242
M01_L241:
       mov       rcx,r15
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       r12d,eax
M01_L242:
       test      r14,r14
       jne       short M01_L243
       xor       r9d,r9d
       jmp       short M01_L244
M01_L243:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA4A8C66A0]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
M01_L244:
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r15
       mov       edx,r12d
       mov       r8,r14
       call      qword ptr [7FFA4A83F540]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M01_L245:
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L247
M01_L246:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L247:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       edx,[rdi+1C]
       mov       [rbx+1C],edx
M01_L248:
       mov       edx,[rdi+1C]
       neg       edx
       mov       [rbx+18],edx
       jmp       short M01_L250
M01_L249:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M01_L254
M01_L250:
       cmp       qword ptr [rsi+20],0
       jne       short M01_L252
       lea       rcx,[rsi+20]
       test      rcx,rcx
       jne       short M01_L251
       call      qword ptr [7FFA4A8C4768]
       int       3
M01_L251:
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       test      rax,rax
       je        short M01_L254
M01_L252:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        short M01_L253
       mov       rcx,[rsi+18]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5D4AE0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].Enqueue(System.__Canon)
       jmp       short M01_L254
M01_L253:
       add       rsi,2C
       lock dec  dword ptr [rsi]
M01_L254:
       add       rsp,38
       ret
; Total bytes of code 9959
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFA4A5EE8C8]; System.AppDomain.get_CurrentDomain()
       mov       rdx,rax
       mov       rcx,rbx
       mov       r8,1E76EBB06C0
       mov       r9d,1
       call      qword ptr [7FFA4A5EE8E0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.FindDerivedTypesNoCache(System.AppDomain, System.Type, Boolean)
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
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
       mov       rbx,1A6EFC000F8
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
       mov       rcx,1A6EFC000F8
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
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
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       mov       rbx,rdx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       test      rbx,rbx
       je        near ptr M02_L18
       cmp       qword ptr [rbp+20],0
       je        near ptr M02_L19
       mov       rcx,[rbp+20]
       mov       [rbp+20],rcx
       xor       ecx,ecx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-48]
       mov       rax,7FFA4A082D40
       mov       [rbp-80],rax
       lea       rax,[M02_L00]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9CE03A0
       call      rax
M02_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M02_L01
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       mov       rbx,[rbp-48]
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1A6D9C01B00
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
       call      00007FFAA9B3CC30
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
       call      00007FFA4AE68B28
       mov       rdi,[rbp-50]
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
M02_L05:
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__66
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
       mov       rdx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       movzx     edi,byte ptr [rbp+28]
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
       call      qword ptr [7FFA4A82ABA0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__66.MoveNext()
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
       call      qword ptr [7FFA49F371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       call      qword ptr [7FFA4A3C5C38]; System.Reflection.RuntimeAssembly.<GetManifestModule>g__GetManifestModuleWorker|93_0(System.Reflection.RuntimeAssembly)
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
       call      qword ptr [7FFA4A7E7720]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__66.<>m__Finally1()
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
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
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
       call      qword ptr [7FFA4A54DDE8]
       mov       ecx,22B
       mov       rdx,7FFA4A273C28
       call      qword ptr [7FFA49F3F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A275660
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A273C28
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4B3AFD68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4B3AFD80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L19:
       call      qword ptr [7FFA4A54DDE8]
       mov       ecx,247
       mov       rdx,7FFA4A273C28
       call      qword ptr [7FFA49F3F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A275660
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A273C28
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4B3AFD68]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4B3AFD80]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L20:
       mov       rcx,1A6D9C01B00
       mov       rdi,[rcx]
       jmp       near ptr M02_L16
M02_L21:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L16
M02_L22:
       mov       rcx,rax
       call      qword ptr [7FFA4A54DC68]
       jmp       near ptr M02_L16
M02_L23:
       mov       rcx,rax
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M02_L16
M02_L24:
       xor       r14d,r14d
       jmp       short M02_L26
M02_L25:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA4B3AFB40]; System.Array.GetLowerBound(Int32)
       mov       r14d,eax
M02_L26:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFA4B3AFB40]; System.Array.GetLowerBound(Int32)
       mov       r9d,eax
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8,rdi
       call      qword ptr [7FFA4A7EF300]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M02_L16
M02_L27:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,1A6EFC00528
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
       call      qword ptr [7FFA4A7E7720]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<LoadDerivedTypesNoCache>d__66.<>m__Finally1()
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
       call      qword ptr [7FFA4A5EE9B8]
       mov       rcx,rax
       call      qword ptr [7FFA4A5EE9D0]
       lea       rax,[M02_L02]
       add       rsp,38
       ret
; Total bytes of code 1569
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllAbstractMethodsCached()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,1BFC9877028
       call      qword ptr [7FFA4A5EEE80]; DotNetTips.Spargine.Core.TypeHelper.GetAllAbstractMethods(System.Type)
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.GetAllAbstractMethods(System.Type)
; 		type = type.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var cacheKey = $"{type.FullName}.{nameof(GetAllAbstractMethods)}";
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (_commonCache.TryGetValue<MethodInfo[]>(cacheKey, out var cachedMethods))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return Array.AsReadOnly(cachedMethods!);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var methods = type.GetTypeInfo().DeclaredMethods.Where(m => m.IsAbstract).ToArray();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		_commonCache.AddCacheItem(cacheKey, methods, TimeSpan.FromMinutes(TimeOutMinutes));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return Array.AsReadOnly(methods);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
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
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M01_L45
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbx],rcx
       jne       near ptr M01_L50
       cmp       qword ptr [rbx+10],0
       je        short M01_L00
       mov       rcx,[rbx+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L02
M01_L00:
       mov       [rsp+0C0],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA49F27C48]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
       mov       rbx,[rsp+0C0]
M01_L01:
       mov       rsi,[rdi+20]
       test      rsi,rsi
       jne       near ptr M01_L10
       mov       [rsp+38],rdi
       mov       rcx,[rdi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA49F2C6C0]; System.Type.GetRootElementType()
       mov       rsi,rax
       mov       [rsp+30],rsi
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L21
       mov       rcx,[rsi+18]
       test      cl,2
       jne       short M01_L03
       mov       eax,[rcx]
       and       eax,80000030
       cmp       eax,30
       sete      al
       movzx     eax,al
       jmp       short M01_L04
M01_L02:
       mov       rdi,rsi
       jmp       short M01_L01
M01_L03:
       xor       eax,eax
M01_L04:
       test      eax,eax
       jne       short M01_L07
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L22
       mov       rcx,rsi
       call      qword ptr [7FFA49F2C6C0]; System.Type.GetRootElementType()
       mov       rcx,rax
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M01_L46
M01_L05:
       test      rcx,rcx
       je        near ptr M01_L47
       call      00007FFAA9B22E70
M01_L06:
       test      eax,eax
       jne       near ptr M01_L48
M01_L07:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L23
       mov       [rsp+0C0],rbx
       mov       rcx,[rsi+18]
       mov       rax,7FFAA9B206C0
       vzeroupper
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L49
M01_L08:
       cmp       ebx,1B
       mov       rbx,[rsp+0C0]
       je        near ptr M01_L48
M01_L09:
       mov       rdi,[rsp+38]
       lea       rdx,[rdi+20]
       mov       rcx,rdi
       mov       r8d,3
       call      qword ptr [7FFA4A0C4A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rsi,rax
M01_L10:
       test      rsi,rsi
       je        near ptr M01_L51
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M01_L51
       mov       ebp,edi
       lea       edx,[rbp+16]
       test      edx,edx
       jl        near ptr M01_L52
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFAA9B68D20
       mov       r14,rax
       cmp       [r14],r14b
       lea       rcx,[r14+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA49F25818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       eax,ebp
       lea       rax,[r14+rax*2+0C]
       vmovups   ymm0,[7FFA4A749EA0]
       vmovups   [rax],ymm0
       mov       rcx,6F006800740065
       mov       [rax+20],rcx
       mov       dword ptr [rax+28],730064
M01_L11:
       mov       rcx,17F4A8000F8
       mov       rsi,[rcx]
       mov       edi,[r14+8]
       test      edi,edi
       je        near ptr M01_L53
       movzx     ecx,word ptr [r14+0C]
       cmp       ecx,100
       jge       near ptr M01_L55
       mov       rax,7FFAA8D06920
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L57
M01_L12:
       dec       edi
       mov       ecx,edi
       movzx     ecx,word ptr [r14+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M01_L56
       mov       rax,7FFAA8D06920
       test      byte ptr [rax+rcx],80
       jne       near ptr M01_L57
M01_L13:
       mov       rdi,r14
M01_L14:
       mov       rsi,[rsi+10]
       test      rdi,rdi
       jne       near ptr M01_L24
       xor       ebp,ebp
       xor       r15d,r15d
M01_L15:
       cmp       byte ptr [rsi+44],0
       jne       near ptr M01_L58
       mov       rdi,[rsi+28]
       mov       rcx,[rdi+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M01_L59
       mov       [rsp+50],rbp
       mov       [rsp+58],r15d
       lea       rcx,[rsp+50]
       call      qword ptr [7FFA4A535740]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M01_L16:
       mov       [rsp+74],eax
       mov       rdx,[r13+10]
       mov       r8d,eax
       imul      r8,[r13+28]
       shr       r8,20
       inc       r8
       mov       ecx,[rdx+8]
       imul      r8,rcx
       shr       r8,20
       cmp       r8d,[rdx+8]
       jae       near ptr M01_L113
       mov       r8d,r8d
       mov       r13,[rdx+r8*8+10]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rdx
       jne       near ptr M01_L43
M01_L17:
       test      r13,r13
       je        near ptr M01_L92
       cmp       eax,[r13+20]
       jne       near ptr M01_L71
       mov       r8,[r13+8]
       test      r15d,r15d
       je        near ptr M01_L60
M01_L18:
       test      r8,r8
       jne       near ptr M01_L25
       xor       edx,edx
       xor       ecx,ecx
M01_L19:
       cmp       r15d,ecx
       jne       near ptr M01_L42
       mov       r11,rbp
       mov       r10,rdx
       mov       r9d,ecx
       add       r9,r9
       cmp       r9,8
       jb        near ptr M01_L61
       cmp       r11,r10
       je        near ptr M01_L27
       cmp       r9,20
       jb        near ptr M01_L66
       xor       edx,edx
       add       r9,0FFFFFFFFFFFFFFE0
       je        near ptr M01_L26
       vmovups   ymm0,[rbp]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L70
M01_L20:
       add       rdx,20
       cmp       r9,rdx
       jbe       short M01_L26
       vmovups   ymm0,[rdx+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+rdx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M01_L70
       jmp       short M01_L20
M01_L21:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L04
M01_L22:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B0]
       call      qword ptr [rax]
       jmp       near ptr M01_L06
M01_L23:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+60]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       near ptr M01_L48
       jmp       near ptr M01_L09
M01_L24:
       lea       rbp,[rdi+0C]
       mov       r15d,[rdi+8]
       jmp       near ptr M01_L15
M01_L25:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       near ptr M01_L19
M01_L26:
       vmovups   ymm0,[r9+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+r9]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M01_L70
M01_L27:
       mov       r9d,1
M01_L28:
       test      r9d,r9d
       je        near ptr M01_L71
M01_L29:
       mov       rbp,[r13+10]
M01_L30:
       mov       rax,[rsi+10]
       mov       rcx,[rax+8]
       test      rcx,rcx
       jne       near ptr M01_L93
       call      qword ptr [7FFA4A4B5F80]; System.DateTime.get_UtcNow()
       mov       r15,rax
M01_L31:
       test      rbp,rbp
       je        near ptr M01_L103
       cmp       byte ptr [rbp+43],0
       jne       near ptr M01_L98
       mov       rdx,[rbp+38]
       test      rdx,rdx
       jl        near ptr M01_L94
M01_L32:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,r15
       cmp       rdx,rcx
       jbe       near ptr M01_L95
       cmp       qword ptr [rbp+50],0
       jg        near ptr M01_L96
M01_L33:
       xor       r13d,r13d
M01_L34:
       test      r13d,r13d
       jne       near ptr M01_L98
M01_L35:
       cmp       qword ptr [rbp+10],0
       jne       near ptr M01_L97
M01_L36:
       mov       [rbp+58],r15
       mov       rdi,[rbp+20]
       cmp       byte ptr [rsi+45],0
       jne       near ptr M01_L99
M01_L37:
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rsi+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,r15
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jl        near ptr M01_L100
M01_L38:
       cmp       qword ptr [rsi+20],0
       jne       near ptr M01_L101
M01_L39:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M01_L105
       mov       rsi,rdi
       test      rsi,rsi
       je        short M01_L40
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       cmp       [rsi],rcx
       je        short M01_L40
       mov       rdx,rdi
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
M01_L40:
       test      rsi,rsi
       je        near ptr M01_L106
       cmp       dword ptr [rsi+8],0
       jne       near ptr M01_L107
       mov       rcx,17F4A8001D8
       mov       rax,[rcx]
M01_L41:
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
M01_L42:
       xor       r9d,r9d
       jmp       near ptr M01_L28
M01_L43:
       test      r13,r13
       jne       near ptr M01_L72
       jmp       near ptr M01_L92
M01_L44:
       add       rdx,20
       cmp       r9,rdx
       jbe       near ptr M01_L82
       vmovups   ymm0,[rdx+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+rdx]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M01_L84
       jmp       short M01_L44
M01_L45:
       call      qword ptr [7FFA4A53E2B0]
       mov       ecx,214D
       mov       rdx,7FFA4A275DD8
       call      qword ptr [7FFA4A1A7738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A275DD8
       call      qword ptr [7FFA4A1A7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFA4A275DD8
       call      qword ptr [7FFA4A1A7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6BD320]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6BC570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L46:
       mov       rax,[rcx]
       mov       rax,[rax+98]
       call      qword ptr [rax+8]
       mov       rcx,rax
       jmp       near ptr M01_L05
M01_L47:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6BC558]
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFA4A6BC570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L48:
       xor       esi,esi
       jmp       near ptr M01_L10
M01_L49:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L08
M01_L50:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rsi,rax
       jmp       near ptr M01_L10
M01_L51:
       mov       r14,1BFC98806C0
       jmp       near ptr M01_L11
M01_L52:
       call      qword ptr [7FFA4A6B76F0]
       int       3
M01_L53:
       call      qword ptr [7FFA4A3C4108]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L54
       call      qword ptr [7FFA4A6BD320]
       mov       rbx,rax
M01_L54:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1BFC9879C08
       call      qword ptr [7FFA4A6BC570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L55:
       call      qword ptr [7FFA4A6B7138]
       test      eax,eax
       jne       short M01_L57
       jmp       near ptr M01_L12
M01_L56:
       call      qword ptr [7FFA4A6B7138]
       test      eax,eax
       je        near ptr M01_L13
M01_L57:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFA4A6B7150]
       mov       rdi,rax
       jmp       near ptr M01_L14
M01_L58:
       call      qword ptr [7FFA4A5EF6F0]
       int       3
M01_L59:
       mov       [rsp+50],rbp
       mov       [rsp+58],r15d
       lea       rdx,[rsp+50]
       mov       rcx,r12
       mov       r11,7FFA49E70BB8
       call      qword ptr [r11]
       jmp       near ptr M01_L16
M01_L60:
       test      r8,r8
       je        near ptr M01_L71
       jmp       near ptr M01_L18
M01_L61:
       cmp       r9,4
       jae       short M01_L64
       xor       r11d,r11d
       mov       rcx,r9
       and       rcx,2
       je        short M01_L62
       movzx     r11d,word ptr [rbp]
       movzx     r10d,word ptr [rdx]
       sub       r11d,r10d
M01_L62:
       test      r9b,1
       je        short M01_L63
       movzx     r9d,byte ptr [rcx+rbp]
       movzx     edx,byte ptr [rdx+rcx]
       sub       r9d,edx
       or        r11d,r9d
M01_L63:
       test      r11d,r11d
       sete      r9b
       movzx     r9d,r9b
       jmp       short M01_L65
M01_L64:
       lea       r10,[r9-4]
       mov       r9d,[rbp]
       sub       r9d,[rdx]
       mov       r8d,[r10+rbp]
       sub       r8d,[rdx+r10]
       or        r8d,r9d
       sete      r9b
       movzx     r9d,r9b
M01_L65:
       jmp       near ptr M01_L28
M01_L66:
       cmp       r9,10
       jb        short M01_L69
       xor       r8d,r8d
       lea       rcx,[r9-10]
       test      rcx,rcx
       je        short M01_L68
M01_L67:
       vmovups   xmm0,[r8+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb r9d,xmm0
       cmp       r9d,0FFFF
       jne       short M01_L70
       add       r8,10
       cmp       rcx,r8
       ja        short M01_L67
M01_L68:
       vmovups   xmm0,[rcx+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+rcx]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L70
       jmp       near ptr M01_L27
M01_L69:
       lea       rcx,[r9-8]
       mov       r9,[rbp]
       sub       r9,[rdx]
       mov       r11,[rcx+rbp]
       sub       r11,[rdx+rcx]
       or        r11,r9
       sete      r9b
       movzx     r9d,r9b
       jmp       short M01_L65
M01_L70:
       xor       r9d,r9d
       jmp       near ptr M01_L28
M01_L71:
       mov       r13,[r13+18]
       jmp       near ptr M01_L17
M01_L72:
       cmp       eax,[r13+20]
       jne       near ptr M01_L90
       mov       r8,[r13+8]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rdx
       je        short M01_L73
       mov       [rsp+50],rbp
       mov       [rsp+58],r15d
       lea       rdx,[rsp+50]
       mov       rcx,r12
       mov       r11,7FFA49E70BC0
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M01_L91
M01_L73:
       test      r15d,r15d
       jne       short M01_L74
       test      r8,r8
       je        near ptr M01_L90
M01_L74:
       test      r8,r8
       je        short M01_L75
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       short M01_L76
M01_L75:
       xor       edx,edx
       xor       ecx,ecx
M01_L76:
       cmp       r15d,ecx
       je        short M01_L77
       xor       r9d,r9d
       jmp       near ptr M01_L89
M01_L77:
       mov       r11,rbp
       mov       r10,rdx
       mov       r9d,ecx
       add       r9,r9
       cmp       r9,8
       jb        near ptr M01_L85
       cmp       r11,r10
       je        near ptr M01_L83
       cmp       r9,20
       jae       short M01_L81
       cmp       r9,10
       jae       short M01_L78
       lea       rcx,[r9-8]
       mov       r9,[rbp]
       sub       r9,[rdx]
       mov       r8,[rcx+rbp]
       sub       r8,[rdx+rcx]
       or        r8,r9
       sete      r9b
       movzx     r9d,r9b
       jmp       near ptr M01_L89
M01_L78:
       xor       r8d,r8d
       lea       rcx,[r9-10]
       test      rcx,rcx
       je        short M01_L80
M01_L79:
       vmovups   xmm0,[r8+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb r9d,xmm0
       cmp       r9d,0FFFF
       jne       short M01_L84
       add       r8,10
       cmp       rcx,r8
       ja        short M01_L79
M01_L80:
       vmovups   xmm0,[rcx+rbp]
       vpcmpeqb  xmm0,xmm0,[r10+rcx]
       vpmovmskb edx,xmm0
       cmp       edx,0FFFF
       jne       short M01_L84
       jmp       short M01_L83
M01_L81:
       xor       edx,edx
       add       r9,0FFFFFFFFFFFFFFE0
       je        short M01_L82
       vmovups   ymm0,[rbp]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       je        near ptr M01_L44
       jmp       short M01_L84
M01_L82:
       vmovups   ymm0,[r9+rbp]
       vpcmpeqb  ymm0,ymm0,[r10+r9]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M01_L84
M01_L83:
       mov       r9d,1
       jmp       short M01_L89
M01_L84:
       xor       r9d,r9d
       jmp       short M01_L89
M01_L85:
       cmp       r9,4
       jb        short M01_L86
       lea       r10,[r9-4]
       mov       r8d,[rbp]
       sub       r8d,[rdx]
       mov       ecx,[r10+rbp]
       sub       ecx,[rdx+r10]
       or        r8d,ecx
       sete      r9b
       movzx     r9d,r9b
       jmp       short M01_L89
M01_L86:
       xor       r11d,r11d
       mov       rcx,r9
       and       rcx,2
       je        short M01_L87
       movzx     r11d,word ptr [rbp]
       movzx     r8d,word ptr [rdx]
       sub       r11d,r8d
M01_L87:
       test      r9b,1
       je        short M01_L88
       movzx     r9d,byte ptr [rcx+rbp]
       movzx     edx,byte ptr [rdx+rcx]
       sub       r9d,edx
       or        r9d,r11d
       mov       r11d,r9d
M01_L88:
       test      r11d,r11d
       sete      r9b
       movzx     r9d,r9b
M01_L89:
       jmp       short M01_L91
M01_L90:
       mov       r13,[r13+18]
       mov       eax,[rsp+74]
       jmp       near ptr M01_L43
M01_L91:
       test      r9d,r9d
       je        short M01_L90
       jmp       near ptr M01_L29
M01_L92:
       xor       ebp,ebp
       jmp       near ptr M01_L30
M01_L93:
       lea       rdx,[rsp+60]
       mov       r11,7FFA49E70BC8
       call      qword ptr [r11]
       lea       rcx,[rsp+60]
       call      qword ptr [7FFA4A5EF660]
       mov       r15,rax
       jmp       near ptr M01_L31
M01_L94:
       cmp       qword ptr [rbp+50],0
       je        near ptr M01_L35
       jmp       near ptr M01_L32
M01_L95:
       mov       rcx,rbp
       mov       edx,3
       call      qword ptr [7FFA4A5EFF78]
       mov       r13d,1
       jmp       near ptr M01_L34
M01_L96:
       mov       rdx,[rbp+58]
       mov       rcx,r15
       call      qword ptr [7FFA4A5EF918]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[rbp+50]
       call      qword ptr [7FFA4A6B40C0]
       test      eax,eax
       jne       short M01_L95
       jmp       near ptr M01_L33
M01_L97:
       mov       rcx,[rbp+10]
       mov       rdx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A6B4078]
       test      eax,eax
       je        near ptr M01_L36
M01_L98:
       cmp       byte ptr [rbp+45],2
       jne       short M01_L102
       jmp       near ptr M01_L36
M01_L99:
       mov       rcx,rbp
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5EF888]
       jmp       near ptr M01_L37
M01_L100:
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFA4A5EF948]
       jmp       near ptr M01_L38
M01_L101:
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A6BD3F8]
       inc       qword ptr [rax+10]
       jmp       near ptr M01_L39
M01_L102:
       mov       r8,[rsi+10]
       mov       rcx,rdi
       mov       rdx,rbp
       call      qword ptr [7FFA4A5EF8E8]
M01_L103:
       mov       rdx,[rsi+10]
       mov       rdi,[rdx+28]
       mov       rdx,[rsi+48]
       mov       rcx,r15
       call      qword ptr [7FFA4A5EF918]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rdi,rax
       jge       short M01_L104
       mov       rcx,rsi
       mov       rdx,r15
       call      qword ptr [7FFA4A5EF948]
M01_L104:
       cmp       qword ptr [rsi+20],0
       je        short M01_L105
       mov       rcx,[rsi+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A6BD3F8]
       inc       qword ptr [rax+18]
M01_L105:
       mov       rcx,rbx
       call      qword ptr [7FFA4A1AE2B0]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+0C0]
       call      qword ptr [rax+10]
       mov       rbx,rax
       mov       rcx,17F4A800130
       mov       r8,[rcx]
       test      r8,r8
       jne       short M01_L109
       jmp       short M01_L108
M01_L106:
       mov       ecx,2
       call      qword ptr [7FFA4A1AC1C8]
       int       3
M01_L107:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       mov       rdx,rsi
       call      qword ptr [7FFA4A3C5B48]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rbp
       jmp       near ptr M01_L41
M01_L108:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,17F4A800118
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetAllAbstractMethods>b__16_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFA49F26BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,17F4A800130
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rsi
M01_L109:
       mov       rdx,rbx
       mov       rcx,7FFA4A67E3C0
       call      qword ptr [7FFA4A3242E8]; System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdx,rax
       mov       rcx,7FFA4A67E448
       call      qword ptr [7FFA4A326658]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFA4A5EEF70]; System.TimeSpan.FromMinutes(Int64)
       mov       rsi,rax
       mov       rcx,17F4A8000F8
       mov       rdi,[rcx]
       mov       ecx,[r14+8]
       xor       ecx,ecx
       je        short M01_L111
       call      qword ptr [7FFA4A3C4108]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L110
       call      qword ptr [7FFA4A6BD320]
       mov       rbx,rax
M01_L110:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1BFC9879C08
       call      qword ptr [7FFA4A6BC570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L111:
       mov       rcx,r14
       call      qword ptr [7FFA4A3C4150]; System.String.Trim()
       mov       rbp,rax
       test      rbx,rbx
       jne       near ptr M01_L112
       call      qword ptr [7FFA4A53E2B0]
       mov       ecx,2015
       mov       rdx,7FFA4A275DD8
       call      qword ptr [7FFA4A1A7738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A275DD8
       call      qword ptr [7FFA4A1A7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFA4A275DD8
       call      qword ptr [7FFA4A1A7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F27858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6BD320]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6BC570]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L112:
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdi,[rdi+10]
       mov       dword ptr [r14+18],1
       mov       byte ptr [rsp+40],1
       mov       [rsp+48],rsi
       lea       rdx,[rsp+40]
       mov       rcx,r14
       call      qword ptr [7FFA4A5EFB70]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions.set_AbsoluteExpirationRelativeToNow(System.Nullable`1<System.TimeSpan>)
       mov       [rsp+20],r14
       mov       rdx,rdi
       mov       r8,rbp
       mov       r9,rbx
       mov       rcx,7FFA4A68BE10
       call      qword ptr [7FFA4A5EFAB0]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       mov       rdx,rbx
       mov       rcx,7FFA4A67E5E8
       call      qword ptr [7FFA4A4BC618]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
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
M01_L113:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 3471
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllAbstractMethods()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1A0
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1B0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1C0],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rbx,rcx
       mov       rcx,12902441178
       mov       rsi,[rcx]
       test      rsi,rsi
       je        short M00_L03
M00_L01:
       cmp       [rsi],sil
       lea       rdi,[rsi+40]
       mov       rcx,[rdi]
       test      rcx,rcx
       jne       short M00_L02
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
M00_L02:
       cmp       byte ptr [rcx+18],0
       je        short M00_L04
       mov       rsi,[rcx+8]
       jmp       short M00_L05
M00_L03:
       mov       rcx,16998FB7028
       call      qword ptr [7FFA4A1556C8]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
       jmp       short M00_L01
M00_L04:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA4A156910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
M00_L05:
       mov       edi,[rsi+8]
       mov       edx,edi
       xor       r8d,r8d
       mov       [rsp+188],r8
       mov       [rsp+190],r8
       mov       [rsp+198],r8d
       mov       [rsp+19C],edx
       mov       ebp,10
       inc       edi
M00_L06:
       dec       edi
       je        near ptr M00_L12
       mov       r14,[rsi+rbp]
       mov       edx,[r14+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L09
       cmp       dword ptr [rsp+198],0
       je        near ptr M00_L25
       cmp       dword ptr [rsp+198],1
       je        short M00_L10
       mov       edx,[rsp+19C]
       cmp       edx,[rsp+198]
       je        near ptr M00_L27
M00_L07:
       movsxd    rdx,dword ptr [rsp+198]
       mov       rcx,[rsp+188]
       mov       r8,r14
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L08:
       mov       edx,[rsp+198]
       inc       edx
       mov       [rsp+198],edx
M00_L09:
       add       rbp,8
       jmp       short M00_L06
M00_L10:
       cmp       dword ptr [rsp+19C],2
       jl        near ptr M00_L26
M00_L11:
       movsxd    rdx,dword ptr [rsp+19C]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rsp+188],rax
       mov       rcx,[rsp+188]
       mov       r8,[rsp+190]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L07
M00_L12:
       mov       rsi,[rsp+188]
       mov       rdi,[rsp+190]
       mov       ebp,[rsp+198]
       test      ebp,ebp
       je        near ptr M00_L28
       cmp       ebp,1
       je        near ptr M00_L29
       test      ebp,ebp
       jl        near ptr M00_L30
       test      rsi,rsi
       je        near ptr M00_L31
       cmp       [rsi+8],ebp
       je        short M00_L15
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
       jbe       short M00_L13
       call      qword ptr [7FFA4A5DFBA0]
       jmp       short M00_L14
M00_L13:
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M00_L32
M00_L14:
       mov       rsi,rdi
M00_L15:
       mov       rcx,129088000E0
       mov       rdi,[rcx]
       test      rdi,rdi
       je        near ptr M00_L33
M00_L16:
       test      rsi,rsi
       je        near ptr M00_L34
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      qword ptr [7FFA49F46850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M00_L35
       mov       rdx,rsi
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        near ptr M00_L37
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L36
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
M00_L17:
       mov       rdx,r14
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Reflection.MethodInfo>
       call      qword ptr [7FFA49F46850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        near ptr M00_L40
       mov       r8,offset MT_System.Linq.Enumerable+ArrayWhereIterator<System.Reflection.MethodInfo>
       cmp       [rax],r8
       jne       near ptr M00_L39
       mov       r8,[rax+18]
       test      r8,r8
       je        near ptr M00_L23
       lea       r14,[r8+10]
       mov       esi,[r8+8]
M00_L18:
       mov       rdi,[rax+20]
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rsp+148],ymm0
       vmovdqu   ymmword ptr [rsp+168],ymm0
       lea       r8,[rsp+148]
       mov       [rsp+28],r8
       mov       dword ptr [rsp+30],8
       lea       r8,[rsp+28]
       lea       rcx,[rsp+40]
       mov       rbp,offset MT_System.Collections.Generic.SegmentedArrayBuilder<System.Reflection.MethodInfo>
       mov       rdx,rbp
       call      qword ptr [7FFA4A6946D8]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Span`1<System.__Canon>)
       test      esi,esi
       jle       short M00_L21
       xor       r15d,r15d
M00_L19:
       mov       r13,[r14+r15]
       mov       rdx,r13
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       je        short M00_L20
       lea       rcx,[rsp+40]
       mov       r8,r13
       mov       rdx,rbp
       call      qword ptr [7FFA4A6946F0]
M00_L20:
       add       r15,8
       dec       esi
       jne       short M00_L19
M00_L21:
       lea       rcx,[rsp+40]
       mov       rdx,rbp
       call      qword ptr [7FFA4A5D73C0]; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rsi,rax
       mov       r8d,[rsp+40]
       test      r8d,r8d
       jne       short M00_L24
M00_L22:
       mov       rdx,rsi
       mov       rcx,7FFA4A6341D0
       call      qword ptr [7FFA4A4DC648]; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsp+38],rax
       mov       rcx,[rbx+60]
       lea       r8,[rsp+38]
       mov       rdx,7FFA4A6351C8
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5D7408]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,1A0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L23:
       xor       r14d,r14d
       xor       esi,esi
       jmp       near ptr M00_L18
M00_L24:
       lea       rcx,[rsp+40]
       mov       rdx,rbp
       call      qword ptr [7FFA4A694150]
       jmp       short M00_L22
M00_L25:
       mov       [rsp+190],r14
       jmp       near ptr M00_L08
M00_L26:
       mov       dword ptr [rsp+19C],4
       jmp       near ptr M00_L11
M00_L27:
       mov       r15d,[rsp+19C]
       add       r15d,r15d
       lea       rdx,[rsp+188]
       mov       r8d,r15d
       mov       rcx,7FFA4A199BB8
       call      qword ptr [7FFA4A156AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rsp+19C],r15d
       jmp       near ptr M00_L07
M00_L28:
       mov       rcx,129088000F8
       mov       rsi,[rcx]
       jmp       near ptr M00_L15
M00_L29:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L15
M00_L30:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFA4A5559F8]
       int       3
M00_L31:
       mov       edx,ebp
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rsi,rax
       jmp       near ptr M00_L15
M00_L32:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L14
M00_L33:
       mov       rcx,offset MT_System.Func<System.Reflection.MethodInfo, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,129088000D0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c.<GetAllAbstractMethodsNoCache>b__56_0(System.Reflection.MethodInfo)
       call      qword ptr [7FFA49F46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,129088000E0
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L16
M00_L34:
       mov       ecx,11
       call      qword ptr [7FFA49F4F930]
       int       3
M00_L35:
       mov       rcx,rax
       mov       rdx,rdi
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r14,rax
       jmp       near ptr M00_L17
M00_L36:
       mov       rdx,129088000F8
       mov       r14,[rdx]
       jmp       near ptr M00_L17
M00_L37:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      qword ptr [7FFA49F46850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        short M00_L38
       mov       rcx,offset MT_System.Linq.Enumerable+ListWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,r14
       mov       r8,rdi
       call      qword ptr [7FFA4A6946A8]
       mov       r14,rsi
       jmp       near ptr M00_L17
M00_L38:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableWhereIterator<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFA4A6946C0]
       jmp       near ptr M00_L17
M00_L39:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rsi,rax
       jmp       near ptr M00_L22
M00_L40:
       mov       rdx,r14
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.MethodInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L41
       mov       rdx,rax
       mov       rcx,7FFA4A68FB38
       call      qword ptr [7FFA4A337A68]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rsi,rax
       jmp       near ptr M00_L22
M00_L41:
       mov       rdx,r14
       mov       rcx,7FFA4A68FBC0
       call      qword ptr [7FFA4A5DFE70]
       mov       rsi,rax
       jmp       near ptr M00_L22
; Total bytes of code 1592
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
       call      00007FFAA9B21870
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
       mov       rax,7FFA4A18C5A0
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9AB2C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L04
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFAA9B304E0
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
       call      qword ptr [7FFA4A6971B0]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA4A694C30]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA4A155710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,0D99B8BA0C49D
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M02_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M02_L06
       cmp       r14d,1
       jne       short M02_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M02_L01
       mov       rcx,7FFA4A811CB0
       call      CORINFO_HELP_COUNTPROFILE32
M02_L00:
       mov       rcx,12904000108
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFA4A811CB8
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M02_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M02_L04
M02_L01:
       cmp       r15d,2A
       jne       near ptr M02_L05
       mov       rcx,7FFA4A811CAC
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M02_L00
M02_L02:
       mov       rcx,7FFA4A811DC0
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M02_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M02_L03
       xor       ecx,ecx
M02_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M02_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M02_L04:
       mov       rcx,7FFA4A811DC4
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA4A156928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M02_L07
M02_L05:
       mov       rcx,7FFA4A811CA8
       call      CORINFO_HELP_COUNTPROFILE32
M02_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,16998FB0008
       call      qword ptr [7FFA4A156928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M02_L07:
       mov       rcx,7FFA4A811DC8
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFA4A156B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0D99B8BA0C49D
       cmp       [rbp],r8
       je        short M02_L08
       call      CORINFO_HELP_FAIL_FAST
M02_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       sub       rsp,28
       mov       eax,[rcx+8]
       cmp       rax,rdx
       jbe       short M03_L00
       lea       rax,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       rdx,[rcx+30]
       test      r8,r8
       je        short M03_L02
       cmp       rdx,[r8]
       je        short M03_L01
       mov       r10,offset MT_System.Object[]
       cmp       rcx,r10
       je        short M03_L01
       mov       rcx,rax
       add       rsp,28
       jmp       qword ptr [7FFA4A156EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M03_L00:
       call      qword ptr [7FFA4A5DF990]
       int       3
M03_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFAA9B67B10
M03_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M04_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
M04_L00:
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       jne       short M04_L03
M04_L01:
       xor       edx,edx
M04_L02:
       mov       rax,rdx
       ret
M04_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       test      rax,rax
       je        short M04_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M04_L02
       jmp       short M04_L00
; Total bytes of code 86
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       push      rsi
       push      rbx
       test      rdx,rdx
       je        short M05_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M05_L02
       mov       r8,12904000038
       mov       r8,[r8]
       add       r8,10
       rorx      r10,rax,20
       xor       r10,rcx
       mov       r9,9E3779B97F4A7C15
       imul      r10,r9
       mov       r9d,[r8]
       shrx      r10,r10,r9
       xor       r9d,r9d
M05_L00:
       lea       r11d,[r10+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[r8+r11*8]
       mov       ebx,[r11]
       mov       rsi,[r11+8]
       and       ebx,0FFFFFFFE
       cmp       rsi,rax
       jne       short M05_L03
       mov       rsi,rcx
       xor       rsi,[r11+10]
       cmp       rsi,1
       ja        short M05_L03
       cmp       ebx,[r11]
       jne       short M05_L04
M05_L01:
       cmp       esi,1
       je        short M05_L02
       test      esi,esi
       jne       short M05_L05
       xor       edx,edx
M05_L02:
       mov       rax,rdx
       pop       rbx
       pop       rsi
       ret
M05_L03:
       test      ebx,ebx
       je        short M05_L04
       inc       r9d
       add       r10d,r9d
       and       r10d,[r8+4]
       cmp       r9d,8
       jl        short M05_L00
M05_L04:
       mov       esi,2
       jmp       short M05_L01
M05_L05:
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA49F4FA98]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny_NoCacheLookup(Void*, System.Object)
; Total bytes of code 166
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Span`1<System.__Canon>)
       lea       rax,[rcx+10]
       xor       edx,edx
       mov       [rax],rdx
       mov       r10d,0D0
M06_L00:
       mov       [rax+r10],rdx
       sub       r10,8
       jne       short M06_L00
       mov       [rcx],edx
       mov       [rcx+4],edx
       mov       [rcx+8],edx
       mov       rax,[r8]
       mov       edx,[r8+8]
       vmovdqu   xmm0,xmmword ptr [r8]
       vmovdqu   xmmword ptr [rcx+0E8],xmm0
       mov       [rcx+0F8],rax
       mov       [rcx+100],edx
       ret
; Total bytes of code 67
```
```assembly
; System.Collections.Generic.SegmentedArrayBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
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
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       mov       [rsp+50],rax
       mov       [rsp+60],rdx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,[rsi+4]
       add       edi,[rsi+8]
       jo        near ptr M07_L24
       test      edi,edi
       jne       short M07_L05
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+18]
       test      rcx,rcx
       je        short M07_L03
M07_L00:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M07_L04
M07_L01:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rbp,[rax]
M07_L02:
       mov       rax,rbp
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
M07_L03:
       mov       rcx,rbx
       mov       rdx,7FFA4A644700
       call      qword ptr [7FFA49F4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M07_L00
M07_L04:
       mov       rdx,7FFA4A642E48
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M07_L01
M07_L05:
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M07_L06
       jmp       short M07_L07
M07_L06:
       mov       rcx,rbx
       mov       rdx,7FFA4A644738
       call      qword ptr [7FFA49F4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rcx,rax
M07_L07:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+10]
       test      rax,rax
       je        short M07_L08
       mov       rcx,rax
       jmp       short M07_L09
M07_L08:
       mov       rdx,7FFA4A6447F8
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M07_L09:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        short M07_L10
       jmp       short M07_L11
M07_L10:
       mov       rcx,rbx
       mov       rdx,7FFA4A644758
       call      qword ptr [7FFA49F4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdi,rax
M07_L11:
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rax,[rdx+20]
       test      rax,rax
       je        short M07_L12
       jmp       short M07_L13
M07_L12:
       mov       rdx,7FFA4A644800
       call      qword ptr [7FFA49F4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
M07_L13:
       cmp       [rbp],rax
       je        short M07_L14
       call      qword ptr [7FFA4A694138]
       int       3
M07_L14:
       lea       r14,[rbp+10]
       mov       r15d,[rbp+8]
       mov       r13,r14
       mov       r12d,r15d
       mov       eax,[rsi]
       mov       [rsp+5C],eax
       test      eax,eax
       je        near ptr M07_L20
       mov       rdx,rdi
       vmovdqu   xmm0,xmmword ptr [rsi+0E8]
       vmovdqu   xmmword ptr [rsp+28],xmm0
       lea       r8,[rsp+28]
       lea       rcx,[rsp+48]
       call      qword ptr [7FFA4A694168]
       mov       r13d,[rsp+50]
       cmp       r13d,r15d
       jg        near ptr M07_L23
       mov       r12d,r13d
       shl       r12,3
       mov       r8,r12
       mov       rcx,r14
       mov       rdx,[rsp+48]
       call      qword ptr [7FFA49F457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14,r12
       sub       r15d,r13d
       mov       r12d,r15d
       mov       r13,r14
       mov       edi,[rsp+5C]
       dec       edi
       je        near ptr M07_L20
       mov       rcx,[rbx+30]
       mov       rcx,[rcx]
       mov       rdx,[rcx+38]
       test      rdx,rdx
       je        short M07_L15
       jmp       short M07_L16
M07_L15:
       mov       rcx,rbx
       mov       rdx,7FFA4A644890
       call      qword ptr [7FFA49F4F4B0]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       rdx,rax
M07_L16:
       lea       r8,[rsi+10]
       lea       rcx,[rsp+38]
       mov       r9d,1B
       call      qword ptr [7FFA4A694030]
       cmp       edi,[rsp+40]
       ja        short M07_L21
       mov       rbx,[rsp+38]
       xor       r14d,r14d
M07_L17:
       mov       r8,[rbx+r14*8]
       test      r8,r8
       jne       short M07_L18
       xor       edx,edx
       xor       r15d,r15d
       jmp       short M07_L19
M07_L18:
       lea       rdx,[r8+10]
       mov       r15d,[r8+8]
M07_L19:
       cmp       r15d,r12d
       jg        short M07_L23
       mov       eax,r15d
       shl       rax,3
       mov       [rsp+20],rax
       mov       r8,rax
       mov       rcx,r13
       call      qword ptr [7FFA49F457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8,[rsp+20]
       add       r13,r8
       sub       r12d,r15d
       inc       r14d
       cmp       r14d,edi
       jl        short M07_L17
M07_L20:
       lea       r8,[rsi+0F8]
       mov       ecx,[rsi+8]
       cmp       ecx,[r8+8]
       jbe       short M07_L22
M07_L21:
       call      qword ptr [7FFA4A15F1B0]
       int       3
M07_L22:
       mov       rdx,[r8]
       cmp       ecx,r12d
       ja        short M07_L23
       mov       r8d,ecx
       shl       r8,3
       mov       rcx,r13
       call      qword ptr [7FFA49F457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M07_L02
M07_L23:
       call      qword ptr [7FFA4A3DC390]
       int       3
M07_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 683
```
```assembly
; System.Array.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        short M08_L02
       cmp       dword ptr [rbx+8],0
       jne       short M08_L03
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M08_L01
M08_L00:
       mov       rcx,rdx
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L01:
       mov       rdx,7FFA4A6451D8
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M08_L00
M08_L02:
       mov       ecx,2
       call      qword ptr [7FFA49F4FD38]
       int       3
M08_L03:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M08_L04
       jmp       short M08_L05
M08_L04:
       mov       rdx,7FFA4A6451D8
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
M08_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA4A3D5B78]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
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
       jl        near ptr M10_L05
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M10_L06
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M10_L04
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L01
       mov       rcx,rax
M10_L00:
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
       ja        short M10_L02
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M10_L03
       jmp       short M10_L09
M10_L01:
       mov       rdx,7FFA4A642C30
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L00
M10_L02:
       call      qword ptr [7FFA4A5DFBA0]
M10_L03:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M10_L04:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M10_L05:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFA4A5559F8]
       int       3
M10_L06:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M10_L07
       mov       rcx,rax
       jmp       short M10_L08
M10_L07:
       mov       rdx,7FFA4A642C30
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M10_L08:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M10_L04
M10_L09:
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L03
; Total bytes of code 250
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c.<GetAllAbstractMethodsNoCache>b__56_0(System.Reflection.MethodInfo)
       push      rbx
       sub       rsp,20
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [rdx],rcx
       jne       short M11_L01
       mov       ebx,[rdx+5C]
M11_L00:
       test      ebx,400
       setne     al
       movzx     eax,al
       add       rsp,20
       pop       rbx
       ret
M11_L01:
       mov       rcx,rdx
       mov       rax,[rdx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       ebx,eax
       jmp       short M11_L00
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
       je        short M12_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M12_L00:
       call      qword ptr [7FFA4A697108]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M13_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M13_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M13_L04
       cmp       [r10],rcx
       je        short M13_L01
M13_L00:
       cmp       [r10+8],rcx
       je        short M13_L01
       cmp       [r10+10],rcx
       jne       short M13_L03
M13_L01:
       mov       rax,rdx
       ret
M13_L02:
       cmp       [r10],rcx
       je        short M13_L01
       jmp       short M13_L00
M13_L03:
       cmp       [r10+18],rcx
       je        short M13_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M13_L02
       test      r8,r8
       je        short M13_L05
M13_L04:
       cmp       [r10],rcx
       je        short M13_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M13_L04
M13_L05:
       test      dword ptr [rax],500C0000
       jne       short M13_L06
       xor       edx,edx
       jmp       short M13_L01
M13_L06:
       jmp       qword ptr [7FFA4A33D4E8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FFAA7D58600]
       mov       rcx,rsi
       mov       r11,rax
       call      qword ptr [rax]
       mov       edi,eax
       test      edi,edi
       je        short M14_L00
       mov       rcx,rbx
       call      qword ptr [7FFAA7D57A48]
       mov       rcx,rax
       movsxd    rdx,edi
       call      qword ptr [7FFAA7D556D8]; CORINFO_HELP_NEWARR_1_DIRECT
       mov       rdi,rax
       mov       rcx,rbx
       call      qword ptr [7FFAA7D58608]
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
M14_L00:
       mov       rcx,rbx
       call      qword ptr [7FFAA7D58228]
       mov       rcx,rax
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 128
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllConstructors()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+24],eax
       mov       rax,2E860D97028
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+20],0FFFFFFFE
       jne       near ptr M00_L11
       mov       r14d,[rdi+24]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L11
       xor       ecx,ecx
       mov       [rdi+20],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],r14
       mov       rdi,[r14]
       cmp       rdi,rsi
       jne       short M00_L04
M00_L01:
       mov       rcx,r14
       call      qword ptr [7FFA4A68CCB0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       r15,[r14+8]
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       jmp       short M00_L01
M00_L02:
       cmp       rdi,rsi
       jne       short M00_L07
       mov       r15,[r14+8]
M00_L03:
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
M00_L04:
       cmp       rdi,rsi
       jne       short M00_L06
       mov       rcx,r14
       call      qword ptr [7FFA4A68CCB0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.MoveNext()
M00_L05:
       test      eax,eax
       jne       short M00_L02
       jmp       short M00_L08
M00_L06:
       mov       rcx,r14
       mov       r11,7FFA49E80BC0
       call      qword ptr [r11]
       jmp       short M00_L05
M00_L07:
       mov       rcx,r14
       mov       r11,7FFA49E80BC8
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L03
M00_L08:
       cmp       rdi,rsi
       jne       short M00_L13
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L12
       cmp       ebx,1
       je        short M00_L12
M00_L09:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
M00_L10:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+20],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+24],eax
       jmp       near ptr M00_L00
M00_L12:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FEF88]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.<>m__Finally1()
       jmp       short M00_L09
M00_L13:
       mov       rcx,r14
       mov       r11,7FFA49E80BD0
       call      qword ptr [r11]
       jmp       short M00_L10
       sub       rsp,28
       mov       r14,[rbp-40]
       mov       rdi,[r14]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57
       cmp       rdi,rsi
       jne       short M00_L16
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L14
       cmp       ebx,1
       jne       short M00_L15
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FEF88]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.<>m__Finally1()
M00_L15:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
       jmp       short M00_L17
M00_L16:
       mov       rcx,r14
       mov       r11,7FFA49E80BD0
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.MoveNext()
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
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+20]
       test      edx,edx
       je        short M01_L01
       cmp       edx,1
       jne       near ptr M01_L32
M01_L00:
       mov       dword ptr [rcx+20],0FFFFFFFD
       lea       rbx,[rcx+28]
       mov       rdx,[rbx]
       mov       rax,rdx
       mov       r8d,[rbx+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M01_L66
       mov       edx,[rbx+14]
       cmp       edx,[rax+10]
       jae       near ptr M01_L31
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L68
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rbx,[rbp+10]
       mov       rdx,[rbx+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+20],1
       mov       eax,1
       jmp       near ptr M01_L69
M01_L01:
       mov       dword ptr [rcx+20],0FFFFFFFF
       mov       rbx,[rcx+10]
       mov       rdx,rbx
       test      rdx,rdx
       je        near ptr M01_L33
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       test      rcx,rcx
       je        short M01_L02
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L34
M01_L02:
       test      rcx,rcx
       je        near ptr M01_L36
       mov       r11,offset MT_System.RuntimeType
       cmp       [rcx],r11
       jne       near ptr M01_L35
M01_L03:
       mov       rsi,rcx
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.ConstructorInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,2A7E1C000F8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        near ptr M01_L24
M01_L05:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L45
       cmp       qword ptr [rsi+10],0
       je        short M01_L06
       mov       rcx,[rsi+10]
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       near ptr M01_L25
M01_L06:
       mov       rcx,rsi
       call      qword ptr [7FFA4A1456C8]; System.RuntimeType.InitializeCache()
       mov       r14,rax
M01_L07:
       cmp       [r14],r14b
       lea       rdi,[r14+48]
       mov       rcx,[rdi]
       test      rcx,rcx
       je        near ptr M01_L37
M01_L08:
       cmp       byte ptr [rcx+18],0
       je        near ptr M01_L38
       mov       rdi,[rcx+8]
M01_L09:
       mov       r14d,[rdi+8]
       mov       edx,r14d
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       [rbp-60],rcx
       mov       [rbp-58],ecx
       mov       [rbp-54],edx
       mov       r15d,10
       inc       r14d
M01_L10:
       dec       r14d
       jne       near ptr M01_L26
       vmovdqu   xmm0,xmmword ptr [rbp-68]
       vmovdqu   xmmword ptr [rbp-50],xmm0
       mov       rcx,[rbp-58]
       mov       [rbp-40],rcx
       cmp       dword ptr [rbp-40],0
       je        near ptr M01_L43
       cmp       dword ptr [rbp-40],1
       jne       near ptr M01_L44
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,[rbp-48]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L11:
       test      rdi,rdi
       je        near ptr M01_L64
       mov       rdx,rdi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.Reflection.ConstructorInfo>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L56
       mov       rdi,[r14]
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       cmp       rdi,rcx
       jne       near ptr M01_L46
       mov       r15d,[r14+8]
M01_L12:
       test      r15d,r15d
       jle       near ptr M01_L19
       mov       rdx,[rbx+8]
       mov       edx,[rdx+8]
       sub       edx,[rbx+10]
       cmp       edx,r15d
       jge       short M01_L17
       mov       edx,r15d
       add       edx,[rbx+10]
       jo        near ptr M01_L67
       mov       rcx,[rbx+8]
       cmp       dword ptr [rcx+8],0
       jne       near ptr M01_L29
       mov       ecx,4
M01_L13:
       cmp       ecx,7FFFFFC7
       ja        near ptr M01_L47
M01_L14:
       cmp       ecx,edx
       jl        near ptr M01_L48
M01_L15:
       cmp       ecx,[rbx+10]
       jl        near ptr M01_L65
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       je        short M01_L17
       test      ecx,ecx
       jle       near ptr M01_L50
       mov       edx,ecx
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       cmp       dword ptr [rbx+10],0
       jg        near ptr M01_L49
M01_L16:
       lea       rcx,[rbx+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
M01_L17:
       mov       rdx,[rbx+8]
       mov       r9d,[rbx+10]
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       cmp       rdi,rcx
       jne       near ptr M01_L55
       mov       r13d,[r14+8]
       test      rdx,rdx
       je        near ptr M01_L54
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       cmp       [rdx],rcx
       jne       near ptr M01_L54
       cmp       dword ptr [rdi+4],18
       jne       near ptr M01_L54
       test      r9d,r9d
       jl        near ptr M01_L54
       cmp       r13d,[r14+8]
       ja        near ptr M01_L54
       lea       ecx,[r9+r13]
       cmp       ecx,[rdx+8]
       ja        near ptr M01_L54
       movzx     ecx,word ptr [MT_System.Reflection.ConstructorInfo[]]
       mov       r8d,r13d
       imul      r8,rcx
       add       r14,10
       mov       eax,r9d
       imul      rcx,rax
       lea       rcx,[rdx+rcx+10]
       test      dword ptr [rdi],1000000
       je        near ptr M01_L53
       cmp       r8,4000
       ja        near ptr M01_L52
       mov       rdx,r14
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L51
M01_L18:
       add       [rbx+10],r15d
       inc       dword ptr [rbx+14]
M01_L19:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rsi],rcx
       jne       near ptr M01_L60
       mov       rcx,rsi
       call      qword ptr [7FFA4A147078]; System.RuntimeType.GetBaseType()
       mov       rdi,rax
M01_L20:
       test      rdi,rdi
       je        near ptr M01_L30
       mov       rcx,rdi
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L61
M01_L21:
       test      rcx,rcx
       je        near ptr M01_L63
       mov       r11,offset MT_System.RuntimeType
       cmp       [rcx],r11
       jne       near ptr M01_L62
M01_L22:
       mov       rsi,rcx
M01_L23:
       test      rsi,rsi
       jne       near ptr M01_L05
M01_L24:
       mov       esi,[rbx+14]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rbx,[rbp+10]
       mov       [rbx+30],rcx
       mov       [rbx+38],esi
       mov       [rbx+3C],ecx
       mov       rcx,rbx
       jmp       near ptr M01_L00
M01_L25:
       mov       r14,rdi
       jmp       near ptr M01_L07
M01_L26:
       mov       r13,[rdi+r15]
       mov       edx,[r13+5C]
       mov       ecx,edx
       and       ecx,3C
       cmp       ecx,edx
       jne       short M01_L28
       cmp       dword ptr [rbp-58],0
       jne       near ptr M01_L39
       mov       [rbp-60],r13
M01_L27:
       mov       ecx,[rbp-58]
       inc       ecx
       mov       [rbp-58],ecx
M01_L28:
       add       r15,8
       jmp       near ptr M01_L10
M01_L29:
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       jmp       near ptr M01_L13
M01_L30:
       xor       esi,esi
       jmp       short M01_L23
M01_L31:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],0FFFFFFFF
       mov       [rcx+28],rax
       mov       [rcx+30],rax
       mov       [rcx+38],rax
       mov       rcx,[rbp+10]
M01_L32:
       xor       eax,eax
       jmp       near ptr M01_L69
M01_L33:
       call      qword ptr [7FFA4A54E2F8]
       mov       ecx,259
       mov       rdx,7FFA4A273D80
       call      qword ptr [7FFA49F3F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A2757B8
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A273D80
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6AC570]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6A7390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L34:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Reflection.IReflectableType
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M01_L02
M01_L35:
       mov       r11,7FFA49E80B58
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L03
M01_L36:
       mov       rcx,offset MT_System.Reflection.TypeDelegator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA4A6A6BC8]
       jmp       near ptr M01_L04
M01_L37:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeConstructorInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L08
       mov       rcx,r15
       jmp       near ptr M01_L08
M01_L38:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,1
       call      qword ptr [7FFA4A146910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L09
M01_L39:
       cmp       dword ptr [rbp-58],1
       jne       short M01_L41
       cmp       dword ptr [rbp-54],2
       jge       short M01_L40
       mov       dword ptr [rbp-54],4
M01_L40:
       movsxd    rdx,dword ptr [rbp-54]
       mov       rcx,offset MT_System.Reflection.ConstructorInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       r8,[rbp-60]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L42
M01_L41:
       mov       edx,[rbp-54]
       cmp       edx,[rbp-58]
       jne       short M01_L42
       mov       r12d,[rbp-54]
       add       r12d,r12d
       lea       rdx,[rbp-68]
       mov       r8d,r12d
       mov       rcx,7FFA4A4DB8A0
       call      qword ptr [7FFA4A146AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       [rbp-54],r12d
M01_L42:
       movsxd    rdx,dword ptr [rbp-58]
       mov       rcx,[rbp-68]
       mov       r8,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M01_L27
M01_L43:
       mov       rcx,2A7CBC01AD8
       mov       rdi,[rcx]
       jmp       near ptr M01_L11
M01_L44:
       lea       rdx,[rbp-50]
       mov       r8d,[rbp-40]
       mov       rcx,7FFA4A4DB8A0
       call      qword ptr [7FFA4A146AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-40]
       mov       [rbp-3C],ecx
       mov       rdi,[rbp-50]
       jmp       near ptr M01_L11
M01_L45:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+0B8]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M01_L11
M01_L46:
       mov       rcx,r14
       mov       r11,7FFA49E80B90
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M01_L12
M01_L47:
       mov       ecx,7FFFFFC7
       jmp       near ptr M01_L14
M01_L48:
       mov       ecx,edx
       jmp       near ptr M01_L15
M01_L49:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+10]
       mov       rdx,r13
       call      qword ptr [7FFA49F3F588]; System.Array.Copy(System.Array, System.Array, Int32)
       jmp       near ptr M01_L16
M01_L50:
       mov       rcx,2A7E1C000F8
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L17
M01_L51:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M01_L18
M01_L52:
       mov       rdx,r14
       call      qword ptr [7FFA4A54DC98]
       jmp       near ptr M01_L18
M01_L53:
       mov       rdx,r14
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L18
M01_L54:
       mov       [rsp+20],r13d
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,r14
       mov       r8,rdx
       xor       edx,edx
       call      qword ptr [7FFA4A6A4F18]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
       jmp       near ptr M01_L18
M01_L55:
       mov       rcx,r14
       mov       r8d,r9d
       mov       r11,7FFA49E80B98
       call      qword ptr [r11]
       jmp       near ptr M01_L18
M01_L56:
       mov       rcx,rdi
       mov       r11,7FFA49E80B70
       call      qword ptr [r11]
       mov       [rbp-70],rax
M01_L57:
       mov       rcx,[rbp-70]
       mov       r11,7FFA49E80B78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L59
       mov       rcx,[rbp-70]
       mov       r11,7FFA49E80B80
       call      qword ptr [r11]
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edi,[rbx+10]
       cmp       [rcx+8],edi
       jbe       short M01_L58
       lea       edx,[rdi+1]
       mov       [rbx+10],edx
       mov       edx,edi
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M01_L57
M01_L58:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFA49F371C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       short M01_L57
M01_L59:
       mov       rcx,[rbp-70]
       mov       r11,7FFA49E80B88
       call      qword ptr [r11]
       jmp       near ptr M01_L19
M01_L60:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+98]
       call      qword ptr [rax+20]
       mov       rdi,rax
       jmp       near ptr M01_L20
M01_L61:
       mov       rdx,rdi
       mov       rcx,offset MT_System.Reflection.IReflectableType
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rcx,rax
       jmp       near ptr M01_L21
M01_L62:
       mov       r11,7FFA49E80BA0
       call      qword ptr [r11]
       mov       rcx,rax
       jmp       near ptr M01_L22
M01_L63:
       mov       rcx,offset MT_System.Reflection.TypeDelegator
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFA4A6A6BC8]
       mov       rcx,rsi
       jmp       near ptr M01_L22
M01_L64:
       mov       ecx,17
       call      qword ptr [7FFA49F3FD38]
       int       3
M01_L65:
       mov       ecx,7
       mov       edx,0F
       call      qword ptr [7FFA4A5459F8]
       int       3
M01_L66:
       call      qword ptr [7FFA49F3FC48]
       int       3
M01_L67:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L68:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L69:
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
       sub       rsp,38
       cmp       qword ptr [rbp-70],0
       je        short M01_L70
       mov       rcx,[rbp-70]
       mov       r11,7FFA49E80B88
       call      qword ptr [r11]
M01_L70:
       nop
       add       rsp,38
       ret
       sub       rsp,38
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A68CCA8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
; Total bytes of code 2233
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllConstructorsNoCache>d__57.<>m__Finally1()
       mov       dword ptr [rcx+20],0FFFFFFFF
       ret
; Total bytes of code 8
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredFields()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredFieldsNoCache>d__58
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+2C],eax
       mov       rax,2E536F27028
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+28],0FFFFFFFE
       jne       near ptr M00_L37
       mov       r14d,[rdi+2C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L37
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-68],r14
M00_L01:
       mov       rdi,[r14]
       cmp       rdi,rsi
       jne       near ptr M00_L31
       mov       r15,r14
       mov       ecx,[r15+28]
       test      ecx,ecx
       je        short M00_L04
       cmp       ecx,1
       jne       near ptr M00_L35
       mov       dword ptr [r15+28],0FFFFFFFF
       inc       dword ptr [r15+30]
M00_L02:
       mov       ecx,[r15+30]
       mov       rdx,[r15+20]
       cmp       ecx,[rdx+8]
       jge       near ptr M00_L19
       cmp       ecx,[rdx+8]
       jae       near ptr M00_L34
       mov       ecx,ecx
       mov       rdx,[rdx+rcx*8+10]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r15+28],1
       mov       r15,[r14+8]
M00_L03:
       mov       [rbp-40],r15
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       jmp       short M00_L01
M00_L04:
       mov       dword ptr [r15+28],0FFFFFFFF
       mov       r13,[r15+10]
       mov       rdx,r13
       test      rdx,rdx
       je        near ptr M00_L32
       lea       rcx,[r15+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L30
       cmp       qword ptr [rcx+10],0
       je        short M00_L05
       mov       rax,[rcx+10]
       mov       r13,[rax]
       test      r13,r13
       jne       near ptr M00_L15
M00_L05:
       call      qword ptr [7FFA4A1556C8]; System.RuntimeType.InitializeCache()
       mov       r12,rax
M00_L06:
       cmp       [r12],r12b
       lea       r13,[r12+50]
       mov       rcx,[r13]
       test      rcx,rcx
       je        near ptr M00_L21
M00_L07:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L22
       mov       r13,[rcx+8]
M00_L08:
       mov       r12d,[r13+8]
       mov       edx,r12d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r12d,r12d
       jle       short M00_L13
       add       r13,10
M00_L09:
       mov       rax,[r13]
       mov       [rbp-70],rax
       mov       edx,[rax+18]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L12
       mov       rax,[rbp-70]
       cmp       dword ptr [rbp-48],0
       je        near ptr M00_L18
       cmp       dword ptr [rbp-48],1
       je        near ptr M00_L16
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L24
M00_L10:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,rax
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L11:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L12:
       add       r13,8
       dec       r12d
       jne       short M00_L09
M00_L13:
       mov       r13,[rbp-58]
       mov       r12,[rbp-50]
       mov       eax,[rbp-48]
       mov       [rbp-60],eax
       test      eax,eax
       je        near ptr M00_L25
       cmp       eax,1
       je        near ptr M00_L26
       test      eax,eax
       jl        near ptr M00_L33
       test      r13,r13
       je        near ptr M00_L27
       cmp       [r13+8],eax
       jne       near ptr M00_L28
M00_L14:
       lea       rcx,[r15+20]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r15+30],ecx
       jmp       near ptr M00_L02
M00_L15:
       mov       r12,r13
       jmp       near ptr M00_L06
M00_L16:
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L23
M00_L17:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rax,[rbp-70]
       jmp       near ptr M00_L10
M00_L18:
       mov       [rbp-50],rax
       jmp       near ptr M00_L11
M00_L19:
       xor       eax,eax
       mov       [r15+20],rax
       jmp       near ptr M00_L35
M00_L20:
       mov       rcx,r14
       mov       r11,7FFA49E90B20
       call      qword ptr [r11]
       mov       r15,rax
       jmp       near ptr M00_L03
M00_L21:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,rax
       mov       [rbp-78],rcx
       lea       rcx,[rcx+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,[rbp-78]
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L07
       mov       r13,[rbp-78]
       mov       rcx,r13
       jmp       near ptr M00_L07
M00_L22:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,2
       call      qword ptr [7FFA4A156910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r13,rax
       jmp       near ptr M00_L08
M00_L23:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L17
M00_L24:
       mov       r10d,[rbp-44]
       add       r10d,r10d
       mov       [rbp-5C],r10d
       lea       rdx,[rbp-58]
       mov       r8d,r10d
       mov       rcx,7FFA4A1B21F0
       call      qword ptr [7FFA4A156AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-5C]
       mov       [rbp-44],edx
       mov       rax,[rbp-70]
       jmp       near ptr M00_L10
M00_L25:
       mov       rcx,2A4A2001BE0
       mov       r13,[rcx]
       jmp       near ptr M00_L14
M00_L26:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       mov       rcx,r13
       mov       r8,r12
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L14
M00_L27:
       mov       edx,eax
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       jmp       near ptr M00_L14
M00_L28:
       mov       edx,eax
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r12,rax
       lea       rcx,[r12+10]
       lea       rdx,[r13+10]
       mov       r8d,[r13+8]
       mov       r13d,[rbp-60]
       cmp       r13d,r8d
       jle       short M00_L29
       mov       r13d,r8d
M00_L29:
       mov       r8d,r13d
       shl       r8,3
       call      qword ptr [7FFA49F457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r13,r12
       jmp       near ptr M00_L14
M00_L30:
       mov       edx,3E
       mov       rax,[rcx]
       mov       rax,[rax+80]
       call      qword ptr [rax+28]
       mov       r13,rax
       jmp       near ptr M00_L14
M00_L31:
       mov       rcx,r14
       mov       r11,7FFA49E90B18
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L35
M00_L32:
       call      qword ptr [7FFA4A55E2F8]
       mov       ecx,259
       mov       rdx,7FFA4A283D80
       call      qword ptr [7FFA49F4F210]
       mov       rdi,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A2857B8
       call      qword ptr [7FFA49F4F210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA49F4D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,5
       mov       rdx,7FFA4A283D80
       call      qword ptr [7FFA49F4F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA49F4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6BC2E8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6B7408]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L33:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFA4A5559F8]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       cmp       rdi,rsi
       jne       short M00_L38
       xor       ecx,ecx
       mov       [r14+20],rcx
       mov       dword ptr [r14+28],0FFFFFFFE
M00_L36:
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
M00_L37:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+28],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+2C],eax
       jmp       near ptr M00_L00
M00_L38:
       mov       rcx,r14
       mov       r11,7FFA49E90B28
       call      qword ptr [r11]
       jmp       short M00_L36
       sub       rsp,28
       mov       r14,[rbp-68]
       mov       rdi,[r14]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredFieldsNoCache>d__58
       cmp       rdi,rsi
       jne       short M00_L39
       xor       ecx,ecx
       mov       [r14+20],rcx
       mov       dword ptr [r14+28],0FFFFFFFE
       jmp       short M00_L40
M00_L39:
       mov       rcx,r14
       mov       r11,7FFA49E90B28
       call      qword ptr [r11]
M00_L40:
       nop
       add       rsp,28
       ret
; Total bytes of code 1401
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
       call      00007FFAA9B21870
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
       mov       rax,7FFA4A18C5A0
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9AB2C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L04
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFAA9B304E0
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
       call      qword ptr [7FFA4A6BD8A8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA4A6B7420]
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFA49F46328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA4A155710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      qword ptr [7FFA49F46328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
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
       jmp       qword ptr [7FFA4A156EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FFA4A6B42D0]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFAA9B67B10
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,782645318927
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M03_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L06
       cmp       r14d,1
       jne       short M03_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M03_L01
       mov       rcx,7FFA4A8734E8
       call      CORINFO_HELP_COUNTPROFILE32
M03_L00:
       mov       rcx,2A4A2000108
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFA4A8734F0
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M03_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M03_L04
M03_L01:
       cmp       r15d,2A
       jne       near ptr M03_L05
       mov       rcx,7FFA4A8734E4
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
M03_L02:
       mov       rcx,7FFA4A8735F8
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M03_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M03_L03
       xor       ecx,ecx
M03_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M03_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M03_L04:
       mov       rcx,7FFA4A8735FC
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA4A156928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M03_L07
M03_L05:
       mov       rcx,7FFA4A8734E0
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,2E536F20008
       call      qword ptr [7FFA4A156928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L07:
       mov       rcx,7FFA4A873600
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFA4A156B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,782645318927
       cmp       [rbp],r8
       je        short M03_L08
       call      CORINFO_HELP_FAIL_FAST
M03_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
```
```assembly
; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       ebx,r8d
       test      ebx,ebx
       jl        short M04_L01
       mov       rdi,[rsi]
       test      rdi,rdi
       je        short M04_L02
       cmp       [rdi+8],ebx
       jne       short M04_L05
M04_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFA4A5559F8]
       int       3
M04_L02:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L03
       mov       rcx,rax
       jmp       short M04_L04
M04_L03:
       mov       rdx,7FFA4A715A88
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L04:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L00
M04_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L06
       mov       rcx,rax
       jmp       short M04_L07
M04_L06:
       mov       rdx,7FFA4A715A88
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       lea       rdx,[rdi+10]
       mov       r8d,[rdi+8]
       cmp       ebx,r8d
       cmovg     ebx,r8d
       mov       r8d,ebx
       shl       r8,3
       call      qword ptr [7FFA49F457A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,rbp
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       near ptr M04_L00
; Total bytes of code 214
```
```assembly
; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       sub       rsp,28
       cmp       r8,4000
       ja        short M05_L02
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       short M05_L01
M05_L00:
       add       rsp,28
       ret
M05_L01:
       call      CORINFO_HELP_POLL_GC
       jmp       short M05_L00
M05_L02:
       add       rsp,28
       jmp       qword ptr [7FFA4A55DC98]
; Total bytes of code 49
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFAA9B68D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA49F45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA49F45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,2E536F20008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA4A6B6430]
       int       3
; Total bytes of code 244
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllDeclaredMethods()
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
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredMethodsNoCache>d__59
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+28],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+2C],eax
       mov       rax,27046287028
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+28],0FFFFFFFE
       jne       near ptr M00_L40
       mov       r14d,[rdi+2C]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L40
       xor       ecx,ecx
       mov       [rdi+28],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-68],r14
M00_L01:
       mov       rcx,[rbp-68]
       mov       rdi,[rcx]
       cmp       rdi,rsi
       jne       near ptr M00_L34
       mov       r14,rcx
       mov       edx,[r14+28]
       test      edx,edx
       je        short M00_L04
       cmp       edx,1
       jne       near ptr M00_L38
       mov       dword ptr [r14+28],0FFFFFFFF
       inc       dword ptr [r14+30]
M00_L02:
       mov       edx,[r14+30]
       mov       rax,[r14+20]
       cmp       edx,[rax+8]
       jge       near ptr M00_L17
       cmp       edx,[rax+8]
       jae       near ptr M00_L37
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+28],1
       mov       rcx,[rbp-68]
       mov       r14,[rcx+8]
M00_L03:
       mov       [rbp-40],r14
       mov       rdi,[rbx+60]
       mov       rdx,[rbp-40]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+8],rcx
       jmp       near ptr M00_L01
M00_L04:
       mov       dword ptr [r14+28],0FFFFFFFF
       mov       r15,[r14+10]
       mov       rdx,r15
       test      rdx,rdx
       je        near ptr M00_L35
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L33
       cmp       qword ptr [rcx+10],0
       je        short M00_L05
       mov       rax,[rcx+10]
       mov       r15,[rax]
       test      r15,r15
       jne       near ptr M00_L22
M00_L05:
       call      qword ptr [7FFA4A1556C8]; System.RuntimeType.InitializeCache()
       mov       r13,rax
M00_L06:
       cmp       [r13],r13b
       lea       r15,[r13+40]
       mov       rcx,[r15]
       test      rcx,rcx
       je        near ptr M00_L24
M00_L07:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L25
       mov       r15,[rcx+8]
M00_L08:
       mov       r13d,[r15+8]
       mov       edx,r13d
       xor       r8d,r8d
       mov       [rbp-58],r8
       mov       [rbp-50],r8
       mov       [rbp-48],r8d
       mov       [rbp-44],edx
       test      r13d,r13d
       jle       near ptr M00_L18
       add       r15,10
       jmp       short M00_L13
M00_L09:
       mov       edx,[rbp-44]
       cmp       edx,[rbp-48]
       je        near ptr M00_L27
M00_L10:
       movsxd    rdx,dword ptr [rbp-48]
       mov       rcx,[rbp-58]
       mov       r8,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M00_L11:
       mov       edx,[rbp-48]
       inc       edx
       mov       [rbp-48],edx
M00_L12:
       add       r15,8
       dec       r13d
       je        short M00_L18
M00_L13:
       mov       r12,[r15]
       mov       edx,[r12+58]
       mov       r8d,edx
       and       r8d,3C
       cmp       r8d,edx
       jne       short M00_L12
       cmp       dword ptr [rbp-48],0
       je        short M00_L15
       cmp       dword ptr [rbp-48],1
       jne       short M00_L09
       cmp       dword ptr [rbp-44],2
       jl        near ptr M00_L26
M00_L14:
       movsxd    rdx,dword ptr [rbp-44]
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       mov       r8,[rbp-50]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       short M00_L10
M00_L15:
       mov       [rbp-50],r12
       jmp       short M00_L11
M00_L16:
       mov       r12d,r8d
       jmp       short M00_L19
M00_L17:
       xor       eax,eax
       mov       [r14+20],rax
       jmp       near ptr M00_L38
M00_L18:
       mov       r15,[rbp-58]
       mov       r13,[rbp-50]
       mov       r12d,[rbp-48]
       test      r12d,r12d
       je        near ptr M00_L28
       cmp       r12d,1
       je        near ptr M00_L29
       test      r12d,r12d
       jl        near ptr M00_L36
       test      r15,r15
       je        near ptr M00_L30
       cmp       [r15+8],r12d
       je        short M00_L21
       mov       edx,r12d
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r13,rax
       lea       rcx,[r13+10]
       lea       rdx,[r15+10]
       mov       r8d,[r15+8]
       cmp       r12d,r8d
       jg        short M00_L16
M00_L19:
       mov       r8d,r12d
       shl       r8,3
       cmp       r8,4000
       ja        near ptr M00_L32
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M00_L31
M00_L20:
       mov       r15,r13
M00_L21:
       lea       rcx,[r14+20]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+30],ecx
       jmp       near ptr M00_L02
M00_L22:
       mov       r13,r15
       jmp       near ptr M00_L06
M00_L23:
       mov       rcx,[rbp-68]
       mov       r11,7FFA49E90AD0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L03
M00_L24:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeMethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r15
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M00_L07
       mov       rcx,r12
       jmp       near ptr M00_L07
M00_L25:
       xor       edx,edx
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA4A156910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       r15,rax
       jmp       near ptr M00_L08
M00_L26:
       mov       dword ptr [rbp-44],4
       jmp       near ptr M00_L14
M00_L27:
       mov       eax,[rbp-44]
       add       eax,eax
       mov       [rbp-5C],eax
       lea       rdx,[rbp-58]
       mov       r8d,eax
       mov       rcx,7FFA4A199BB8
       call      qword ptr [7FFA4A156AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       edx,[rbp-5C]
       mov       [rbp-44],edx
       jmp       near ptr M00_L10
M00_L28:
       mov       rcx,offset MT_System.Array+EmptyArray<System.Reflection.MethodInfo>
       call      qword ptr [7FFA49F45728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22FB1402148
       mov       r15,[rcx]
       jmp       near ptr M00_L21
M00_L29:
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,r15
       mov       r8,r13
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M00_L21
M00_L30:
       mov       edx,r12d
       mov       rcx,offset MT_System.Reflection.MethodInfo[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       jmp       near ptr M00_L21
M00_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FFA4A55DC68]
       jmp       near ptr M00_L20
M00_L33:
       mov       edx,3E
       mov       rax,[rcx]
       mov       rax,[rax+90]
       call      qword ptr [rax+8]
       mov       r15,rax
       jmp       near ptr M00_L21
M00_L34:
       mov       r11,7FFA49E90AC8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L23
       jmp       near ptr M00_L38
M00_L35:
       call      qword ptr [7FFA4A55E2B0]
       mov       ecx,259
       mov       rdx,7FFA4A283C28
       call      qword ptr [7FFA49F4F210]
       mov       rdi,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A285660
       call      qword ptr [7FFA49F4F210]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA49F4D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,5
       mov       rdx,7FFA4A283C28
       call      qword ptr [7FFA49F4F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA49F4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6BC210]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6B7450]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L36:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFA4A5559C8]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       cmp       rdi,rsi
       jne       short M00_L41
       xor       r11d,r11d
       mov       rcx,[rbp-68]
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
M00_L39:
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
M00_L40:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA4A60EE98]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredMethodsNoCache>d__59..ctor(Int32)
       jmp       near ptr M00_L00
M00_L41:
       mov       rcx,[rbp-68]
       mov       r11,7FFA49E90AD8
       call      qword ptr [r11]
       jmp       short M00_L39
       sub       rsp,28
       mov       rcx,[rbp-68]
       mov       rdi,[rcx]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredMethodsNoCache>d__59
       cmp       rdi,rsi
       jne       short M00_L42
       xor       r11d,r11d
       mov       [rcx+20],r11
       mov       dword ptr [rcx+28],0FFFFFFFE
       jmp       short M00_L43
M00_L42:
       mov       r11,7FFA49E90AD8
       call      qword ptr [r11]
M00_L43:
       nop
       add       rsp,28
       ret
; Total bytes of code 1422
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
       call      00007FFAA9B21870
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
       mov       rax,7FFA4A18C5A0
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9AB2C30
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L04
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFAA9B304E0
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
       call      qword ptr [7FFA4A6BD9C8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA4A6B7468]
       jmp       near ptr M01_L00
M01_L09:
       call      qword ptr [7FFA49F46328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA4A155710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M01_L02
M01_L11:
       mov       rdx,rax
       call      qword ptr [7FFA49F46328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
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
       jmp       qword ptr [7FFA4A156EC8]; System.Runtime.CompilerServices.CastHelpers.StelemRef_Helper(System.Object ByRef, Void*, System.Object)
M02_L00:
       call      qword ptr [7FFA4A6B46A8]
       int       3
M02_L01:
       mov       rcx,rax
       mov       rdx,r8
       add       rsp,28
       jmp       near ptr 00007FFAA9B67B10
M02_L02:
       xor       ecx,ecx
       mov       [rax],rcx
       add       rsp,28
       ret
; Total bytes of code 94
```
```assembly
; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp+8],xmm4
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,388748DD88B3
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        near ptr M03_L06
       cmp       dword ptr [rbx+8],0
       je        near ptr M03_L06
       cmp       r14d,1
       jne       short M03_L00
       movzx     r15d,word ptr [rbx+0C]
       cmp       r15d,2E
       jne       short M03_L01
       mov       rcx,7FFA4A873488
       call      CORINFO_HELP_COUNTPROFILE32
M03_L00:
       mov       rcx,22FB1400108
       mov       r15,[rcx]
       mov       rcx,r15
       mov       rdx,7FFA4A873490
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,r15
       mov       rdx,rbx
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+18]
       mov       r15d,eax
       cmp       r15d,400
       jbe       short M03_L02
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r13,[rax+10]
       mov       r15d,[rax+8]
       jmp       short M03_L04
M03_L01:
       cmp       r15d,2A
       jne       near ptr M03_L05
       mov       rcx,7FFA4A873484
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M03_L00
M03_L02:
       mov       rcx,7FFA4A873598
       call      CORINFO_HELP_COUNTPROFILE32
       mov       edx,r15d
       mov       r13,rdx
       test      r13,r13
       je        short M03_L04
       mov       rcx,r13
       add       rcx,0F
       and       rcx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rcx
       add       rcx,rsp
       jb        short M03_L03
       xor       ecx,ecx
M03_L03:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rcx
       jae       short M03_L03
       mov       rsp,rcx
       test      [rsp],esp
       sub       rsp,30
       lea       r13,[rsp+30]
M03_L04:
       mov       rcx,7FFA4A87359C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rbp+8],r13
       mov       [rbp+10],r15d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA4A156928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       short M03_L07
M03_L05:
       mov       rcx,7FFA4A873480
       call      CORINFO_HELP_COUNTPROFILE32
M03_L06:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,27046280008
       call      qword ptr [7FFA4A156928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M03_L07:
       mov       rcx,7FFA4A8735A0
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFA4A156B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,388748DD88B3
       cmp       [rbp],r8
       je        short M03_L08
       call      CORINFO_HELP_FAIL_FAST
M03_L08:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 495
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
       jl        near ptr M04_L04
       mov       rdi,[rsi]
       test      rdi,rdi
       je        near ptr M04_L05
       mov       ebp,[rdi+8]
       cmp       ebp,ebx
       je        short M04_L02
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L03
       mov       rcx,rax
M04_L00:
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
       ja        near ptr M04_L09
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       short M04_L08
M04_L01:
       mov       rcx,rsi
       mov       rdx,r14
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M04_L02:
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rdx,7FFA4A715AA0
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M04_L00
M04_L04:
       mov       ecx,45
       mov       edx,0D
       call      qword ptr [7FFA4A5559C8]
       int       3
M04_L05:
       mov       rdx,[rcx+18]
       mov       rax,[rdx+18]
       test      rax,rax
       je        short M04_L06
       mov       rcx,rax
       jmp       short M04_L07
M04_L06:
       mov       rdx,7FFA4A715AA0
       call      qword ptr [7FFA49F4F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
M04_L07:
       mov       edx,ebx
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M04_L02
M04_L08:
       call      CORINFO_HELP_POLL_GC
       jmp       short M04_L01
M04_L09:
       call      qword ptr [7FFA4A55DC68]
       jmp       near ptr M04_L01
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M05_L00
       ret
M05_L00:
       jmp       qword ptr [7FFA49F45C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
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
       je        near ptr M06_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M06_L01
       test      rsi,rsi
       je        short M06_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M06_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M06_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFAA9B68D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA49F45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA49F45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M06_L00:
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
M06_L01:
       test      rsi,rsi
       je        short M06_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M06_L03
M06_L02:
       mov       rax,27046280008
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M06_L03:
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
M06_L04:
       call      qword ptr [7FFA4A6B63E8]
       int       3
; Total bytes of code 244
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllDeclaredMethodsNoCache>d__59..ctor(Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       [rbx+28],edx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+2C],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 25
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllFields()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+24],eax
       mov       rax,24753BC7028
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+20],0FFFFFFFE
       jne       near ptr M00_L12
       mov       r14d,[rdi+24]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L12
       xor       ecx,ecx
       mov       [rdi+20],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],r14
       mov       rdi,[r14]
       cmp       rdi,rsi
       jne       short M00_L04
M00_L01:
       mov       rcx,r14
       call      qword ptr [7FFA4A68CD30]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       r15,[r14+8]
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       jmp       short M00_L01
M00_L02:
       cmp       rdi,rsi
       jne       short M00_L07
       mov       r15,[r14+8]
M00_L03:
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
M00_L04:
       cmp       rdi,rsi
       jne       short M00_L06
       mov       rcx,r14
       call      qword ptr [7FFA4A68CD30]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.MoveNext()
M00_L05:
       test      eax,eax
       jne       short M00_L02
       jmp       short M00_L08
M00_L06:
       mov       rcx,r14
       mov       r11,7FFA49E80B68
       call      qword ptr [r11]
       jmp       short M00_L05
M00_L07:
       mov       rcx,r14
       mov       r11,7FFA49E80B70
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L03
M00_L08:
       cmp       rdi,rsi
       jne       short M00_L13
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L11
       cmp       ebx,1
       je        short M00_L11
M00_L09:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
M00_L10:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FEF70]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.<>m__Finally1()
       jmp       short M00_L09
M00_L12:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+20],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+24],eax
       jmp       near ptr M00_L00
M00_L13:
       mov       rcx,r14
       mov       r11,7FFA49E80B78
       call      qword ptr [r11]
       jmp       short M00_L10
       sub       rsp,28
       mov       r14,[rbp-40]
       mov       rdi,[r14]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60
       cmp       rdi,rsi
       jne       short M00_L16
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L14
       cmp       ebx,1
       jne       short M00_L15
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FEF70]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.<>m__Finally1()
M00_L15:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
       jmp       short M00_L17
M00_L16:
       mov       rcx,r14
       mov       r11,7FFA49E80B78
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.MoveNext()
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
       mov       edx,[rcx+20]
       test      edx,edx
       je        short M01_L01
       cmp       edx,1
       jne       near ptr M01_L05
M01_L00:
       mov       dword ptr [rcx+20],0FFFFFFFD
       lea       rbx,[rcx+28]
       mov       rdx,[rbx]
       mov       rax,rdx
       mov       r8d,[rbx+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M01_L15
       mov       edx,[rbx+14]
       cmp       edx,[rax+10]
       jae       near ptr M01_L04
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L16
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+30]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],1
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       mov       dword ptr [rcx+20],0FFFFFFFF
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M01_L11
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.FieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,206BEC020F0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFA4A23E310]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rsi,rax
       test      rsi,rsi
       jne       near ptr M01_L10
M01_L02:
       mov       esi,[rbx+14]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+30],rcx
       mov       [rax+38],esi
       mov       [rax+3C],ecx
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rax
       call      qword ptr [7FFA4A23E310]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rsi,rax
       jmp       short M01_L09
M01_L04:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A5FEF70]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.<>m__Finally1()
       xor       eax,eax
       mov       rcx,[rbp+10]
       mov       [rcx+28],rax
       mov       [rcx+30],rax
       mov       [rcx+38],rax
       mov       rcx,[rbp+10]
M01_L05:
       xor       eax,eax
       jmp       near ptr M01_L17
M01_L06:
       mov       rdx,206BEC01BE0
       mov       rdx,[rdx]
M01_L07:
       mov       rcx,rbx
       call      qword ptr [7FFA4A54E208]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rdi,r14
       jne       near ptr M01_L14
       mov       rcx,rsi
       call      qword ptr [7FFA4A147078]; System.RuntimeType.GetBaseType()
M01_L08:
       test      rax,rax
       jne       short M01_L03
       xor       esi,esi
M01_L09:
       test      rsi,rsi
       je        near ptr M01_L02
M01_L10:
       mov       rdi,[rsi]
       mov       r14,offset MT_System.RuntimeType
       cmp       rdi,r14
       jne       near ptr M01_L13
       xor       edx,edx
       mov       [rsp+20],edx
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       xor       r8d,r8d
       mov       r9d,3E
       call      qword ptr [7FFA4A14C708]; System.RuntimeType.GetFieldCandidates(System.String, System.Reflection.BindingFlags, Boolean)
       mov       r8d,[rbp-30]
       test      r8d,r8d
       je        short M01_L06
       cmp       r8d,1
       je        near ptr M01_L12
       lea       rdx,[rbp-40]
       mov       rcx,7FFA4A1A21F0
       call      qword ptr [7FFA4A146AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-30]
       mov       [rbp-2C],ecx
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L07
M01_L11:
       call      qword ptr [7FFA4A54E2F8]
       mov       ecx,259
       mov       rdx,7FFA4A273D80
       call      qword ptr [7FFA49F3F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A2757B8
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A273D80
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6AC6A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6A73C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L12:
       mov       rcx,offset MT_System.Reflection.FieldInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rdx,r15
       jmp       near ptr M01_L07
M01_L13:
       mov       rcx,rsi
       mov       rax,[rdi+0C0]
       call      qword ptr [rax]
       mov       rdx,rax
       jmp       near ptr M01_L07
M01_L14:
       mov       rcx,rsi
       mov       rax,[rdi+98]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L08
M01_L15:
       call      qword ptr [7FFA49F3FC48]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L17:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,28
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A68CD28]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.System.IDisposable.Dispose()
       nop
       add       rsp,28
       ret
; Total bytes of code 808
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllFieldsNoCache>d__60.<>m__Finally1()
       mov       dword ptr [rcx+20],0FFFFFFFF
       ret
; Total bytes of code 8
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllMethods()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+24],eax
       mov       rax,1F04DA5F348
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+20],0FFFFFFFE
       jne       near ptr M00_L11
       mov       r14d,[rdi+24]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L11
       xor       ecx,ecx
       mov       [rdi+20],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],r14
       mov       r14,[rbp-40]
       mov       rdi,[r14]
       cmp       rdi,rsi
       jne       short M00_L04
M00_L01:
       mov       rcx,r14
       call      qword ptr [7FFA4A645DC8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       r15,[r14+8]
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       jmp       short M00_L01
M00_L02:
       cmp       rdi,rsi
       jne       short M00_L07
       mov       r15,[r14+8]
M00_L03:
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
M00_L04:
       cmp       rdi,rsi
       jne       short M00_L06
       mov       rcx,r14
       call      qword ptr [7FFA4A645DC8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.MoveNext()
M00_L05:
       test      eax,eax
       jne       short M00_L02
       jmp       short M00_L08
M00_L06:
       mov       rcx,r14
       mov       r11,7FFA49E60B08
       call      qword ptr [r11]
       jmp       short M00_L05
M00_L07:
       mov       rcx,r14
       mov       r11,7FFA49E60B10
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L03
M00_L08:
       cmp       rdi,rsi
       jne       short M00_L13
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L12
       cmp       ebx,1
       je        short M00_L12
M00_L09:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
M00_L10:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFA4A5CE988]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61..ctor(Int32)
       jmp       near ptr M00_L00
M00_L12:
       mov       rcx,r14
       call      qword ptr [7FFA4A5CE9E8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.<>m__Finally1()
       jmp       short M00_L09
M00_L13:
       mov       rcx,r14
       mov       r11,7FFA49E60B18
       call      qword ptr [r11]
       jmp       short M00_L10
       sub       rsp,28
       mov       r14,[rbp-40]
       mov       rdi,[r14]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61
       cmp       rdi,rsi
       jne       short M00_L16
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L14
       cmp       ebx,1
       jne       short M00_L15
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FFA4A5CE9E8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.<>m__Finally1()
M00_L15:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
       jmp       short M00_L17
M00_L16:
       mov       rcx,r14
       mov       r11,7FFA49E60B18
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rbp-38],xmm4
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       edx,[rcx+20]
       test      edx,edx
       je        near ptr M01_L06
       cmp       edx,1
       jne       near ptr M01_L05
M01_L00:
       mov       dword ptr [rcx+20],0FFFFFFFD
       lea       rbx,[rcx+28]
       mov       rdx,[rbx]
       mov       rax,rdx
       mov       r8d,[rbx+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M01_L13
       mov       edx,[rbx+14]
       cmp       edx,[rax+10]
       jae       near ptr M01_L15
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L14
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+30]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],1
       mov       eax,1
       jmp       near ptr M01_L16
M01_L01:
       test      rsi,rsi
       je        near ptr M01_L12
M01_L02:
       mov       rdi,[rsi]
       mov       r14,offset MT_System.RuntimeType
       cmp       rdi,r14
       jne       near ptr M01_L08
       mov       dword ptr [rsp+20],3E
       mov       dword ptr [rsp+28],3
       xor       edx,edx
       mov       [rsp+30],rdx
       mov       [rsp+38],edx
       lea       rdx,[rbp-38]
       mov       rcx,rsi
       xor       r8d,r8d
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FFA4A126898]; System.RuntimeType.GetMethodCandidates(System.String, Int32, System.Reflection.BindingFlags, System.Reflection.CallingConventions, System.Type[], Boolean)
       lea       rcx,[rbp-38]
       mov       rdx,offset MT_System.RuntimeType+ListBuilder<System.Reflection.MethodInfo>
       call      qword ptr [7FFA4A126B38]; System.RuntimeType+ListBuilder`1[[System.__Canon, System.Private.CoreLib]].ToArray()
M01_L03:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFA4A52DCC8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       rdi,r14
       jne       near ptr M01_L09
       mov       rcx,rsi
       call      qword ptr [7FFA4A127078]; System.RuntimeType.GetBaseType()
M01_L04:
       test      rax,rax
       jne       near ptr M01_L11
       jmp       near ptr M01_L10
M01_L05:
       xor       eax,eax
       jmp       near ptr M01_L16
M01_L06:
       mov       dword ptr [rcx+20],0FFFFFFFF
       mov       rdx,[rcx+10]
       test      rdx,rdx
       jne       near ptr M01_L07
       call      qword ptr [7FFA4A52DDB8]
       mov       ecx,259
       mov       rdx,7FFA4A253C28
       call      qword ptr [7FFA49F1F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A255660
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A253C28
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F1D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6778B8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6773F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L07:
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MethodInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA4A306430]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFA4A21E2B0]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L12
       jmp       near ptr M01_L02
M01_L08:
       mov       rcx,rsi
       mov       rax,[rdi+0C0]
       call      qword ptr [rax+10]
       jmp       near ptr M01_L03
M01_L09:
       mov       rcx,rsi
       mov       rax,[rdi+98]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L04
M01_L10:
       xor       esi,esi
       jmp       near ptr M01_L01
M01_L11:
       mov       rcx,rax
       call      qword ptr [7FFA4A21E2B0]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rsi,rax
       jmp       near ptr M01_L01
M01_L12:
       mov       esi,[rbx+14]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+30],rcx
       mov       [rax+38],esi
       mov       [rax+3C],ecx
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L13:
       call      qword ptr [7FFA49F1FC48]
       int       3
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L15:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A5CE9E8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.<>m__Finally1()
       xor       eax,eax
       mov       rcx,[rbp+10]
       mov       [rcx+28],rax
       mov       [rcx+30],rax
       mov       [rcx+38],rax
       mov       rcx,[rbp+10]
       jmp       near ptr M01_L05
M01_L16:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       sub       rsp,48
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A645DC0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.System.IDisposable.Dispose()
       nop
       add       rsp,48
       ret
; Total bytes of code 751
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61..ctor(Int32)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       [rbx+20],edx
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+24],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 25
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllMethodsNoCache>d__61.<>m__Finally1()
       mov       dword ptr [rcx+20],0FFFFFFFF
       ret
; Total bytes of code 8
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetAllProperties()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+24],eax
       mov       rax,232246D06C0
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+20],0FFFFFFFE
       jne       near ptr M00_L11
       mov       r14d,[rdi+24]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L11
       xor       ecx,ecx
       mov       [rdi+20],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],r14
       mov       rdi,[r14]
       cmp       rdi,rsi
       jne       short M00_L04
M00_L01:
       mov       rcx,r14
       call      qword ptr [7FFA4A68CD30]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       r15,[r14+8]
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       jmp       short M00_L01
M00_L02:
       cmp       rdi,rsi
       jne       short M00_L07
       mov       r15,[r14+8]
M00_L03:
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
M00_L04:
       cmp       rdi,rsi
       jne       short M00_L06
       mov       rcx,r14
       call      qword ptr [7FFA4A68CD30]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.MoveNext()
M00_L05:
       test      eax,eax
       jne       short M00_L02
       jmp       short M00_L08
M00_L06:
       mov       rcx,r14
       mov       r11,7FFA49E80B88
       call      qword ptr [r11]
       jmp       short M00_L05
M00_L07:
       mov       rcx,r14
       mov       r11,7FFA49E80B90
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L03
M00_L08:
       cmp       rdi,rsi
       jne       short M00_L13
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L12
       cmp       ebx,1
       je        short M00_L12
M00_L09:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
M00_L10:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+20],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+24],eax
       jmp       near ptr M00_L00
M00_L12:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FEF70]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.<>m__Finally1()
       jmp       short M00_L09
M00_L13:
       mov       rcx,r14
       mov       r11,7FFA49E80B98
       call      qword ptr [r11]
       jmp       short M00_L10
       sub       rsp,28
       mov       r14,[rbp-40]
       mov       rdi,[r14]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62
       cmp       rdi,rsi
       jne       short M00_L16
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L14
       cmp       ebx,1
       jne       short M00_L15
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FEF70]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.<>m__Finally1()
M00_L15:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
       jmp       short M00_L17
M00_L16:
       mov       rcx,r14
       mov       r11,7FFA49E80B98
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.MoveNext()
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
       mov       edx,[rcx+20]
       test      edx,edx
       je        short M01_L01
       cmp       edx,1
       jne       near ptr M01_L10
M01_L00:
       mov       dword ptr [rcx+20],0FFFFFFFD
       lea       rbx,[rcx+28]
       mov       rdx,[rbx]
       mov       rax,rdx
       mov       r8d,[rbx+10]
       cmp       r8d,[rdx+14]
       jne       near ptr M01_L15
       mov       edx,[rbx+14]
       cmp       edx,[rax+10]
       jae       near ptr M01_L09
       mov       rax,[rax+8]
       cmp       edx,[rax+8]
       jae       near ptr M01_L16
       mov       edx,edx
       mov       rdx,[rax+rdx*8+10]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbp+10]
       mov       rdx,[rcx+30]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],1
       mov       eax,1
       jmp       near ptr M01_L17
M01_L01:
       mov       dword ptr [rcx+20],0FFFFFFFF
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M01_L11
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.PropertyInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,1F18F4020F0
       mov       rdx,[rcx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       call      qword ptr [7FFA4A23E310]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L06
       mov       rdi,offset MT_System.RuntimeType
M01_L02:
       mov       r14,[rsi]
       cmp       r14,rdi
       jne       near ptr M01_L13
       xor       edx,edx
       mov       [rsp+20],rdx
       mov       [rsp+28],edx
       lea       rdx,[rbp-40]
       mov       rcx,rsi
       xor       r8d,r8d
       mov       r9d,3E
       call      qword ptr [7FFA4A147C60]; System.RuntimeType.GetPropertyCandidates(System.String, System.Reflection.BindingFlags, System.Type[], Boolean)
       cmp       dword ptr [rbp-30],0
       jne       short M01_L07
       mov       rdx,1F18F4010C8
       mov       rdx,[rdx]
M01_L03:
       mov       rcx,rbx
       call      qword ptr [7FFA4A54E208]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddRange(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       cmp       r14,rdi
       jne       near ptr M01_L14
       mov       rcx,rsi
       call      qword ptr [7FFA4A147078]; System.RuntimeType.GetBaseType()
M01_L04:
       test      rax,rax
       je        short M01_L08
       mov       rcx,rax
       call      qword ptr [7FFA4A23E310]; System.Reflection.IntrospectionExtensions.GetTypeInfo(System.Type)
       mov       rsi,rax
M01_L05:
       test      rsi,rsi
       jne       short M01_L02
M01_L06:
       mov       esi,[rbx+14]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+28]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+30],rcx
       mov       [rax+38],esi
       mov       [rax+3C],ecx
       mov       rcx,rax
       jmp       near ptr M01_L00
M01_L07:
       cmp       dword ptr [rbp-30],1
       je        near ptr M01_L12
       lea       rdx,[rbp-40]
       mov       r8d,[rbp-30]
       mov       rcx,7FFA4A192388
       call      qword ptr [7FFA4A146AD8]; System.Array.Resize[[System.__Canon, System.Private.CoreLib]](System.__Canon[] ByRef, Int32)
       mov       ecx,[rbp-30]
       mov       [rbp-2C],ecx
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L03
M01_L08:
       xor       esi,esi
       jmp       short M01_L05
M01_L09:
       xor       eax,eax
       mov       [rbx+8],rax
       mov       dword ptr [rbx+14],0FFFFFFFF
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+20],0FFFFFFFF
       mov       [rcx+28],rax
       mov       [rcx+30],rax
       mov       [rcx+38],rax
       mov       rcx,[rbp+10]
M01_L10:
       xor       eax,eax
       jmp       near ptr M01_L17
M01_L11:
       call      qword ptr [7FFA4A54E2F8]
       mov       ecx,259
       mov       rdx,7FFA4A273D80
       call      qword ptr [7FFA49F3F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A2757B8
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A273D80
       call      qword ptr [7FFA49F3F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F3D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6AC840]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6A6EF8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L12:
       mov       rcx,offset MT_System.Reflection.PropertyInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       r15,rax
       mov       rcx,r15
       mov       r8,[rbp-38]
       xor       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       mov       rdx,r15
       jmp       near ptr M01_L03
M01_L13:
       mov       rcx,rsi
       mov       rax,[r14+0C0]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M01_L03
M01_L14:
       mov       rcx,rsi
       mov       rax,[r14+98]
       call      qword ptr [rax+20]
       jmp       near ptr M01_L04
M01_L15:
       call      qword ptr [7FFA49F3FC48]
       int       3
M01_L16:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L17:
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A68CD28]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
; Total bytes of code 802
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetAllPropertiesNoCache>d__62.<>m__Finally1()
       mov       dword ptr [rcx+20],0FFFFFFFF
       ret
; Total bytes of code 8
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,98
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqa   xmmword ptr [rsp+80],xmm4
       mov       [rsp+90],rax
       mov       rbx,rcx
       mov       rcx,26D788106C0
       mov       rdx,26D788106E8
       mov       r8d,1C
       call      qword ptr [7FFA49E7A490]; System.RuntimeType.GetField(System.String, System.Reflection.BindingFlags)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L16
       xor       ecx,ecx
       mov       [rsp+70],rcx
       mov       rcx,22CE3800C88
       mov       rdi,[rcx]
       mov       rcx,22CE3800C90
       mov       rbp,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L17
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L17
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L19
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L19
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M00_L19
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M00_L18
M00_L01:
       mov       [rsp+78],r14
       lea       rcx,[r14+10]
       mov       eax,[r14+8]
       mov       [rsp+88],rcx
       mov       [rsp+90],eax
       xor       ecx,ecx
       mov       [rsp+80],ecx
       mov       byte ptr [rsp+84],0
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L34
       mov       rcx,[rsi+8]
       cmp       byte ptr [rcx+9C],0
       jne       near ptr M00_L33
       mov       rcx,[rsi+10]
M00_L02:
       test      rcx,rcx
       je        near ptr M00_L35
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       near ptr M00_L36
       cmp       qword ptr [rcx+10],0
       je        short M00_L03
       mov       rax,[rcx+10]
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M00_L05
M00_L03:
       call      qword ptr [7FFA49F37C48]; System.RuntimeType.InitializeCache()
       mov       rbp,rax
M00_L04:
       mov       rdx,[rbp+20]
       test      rdx,rdx
       jne       short M00_L07
       mov       rcx,[rbp+8]
       call      qword ptr [7FFA4A0D4A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
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
       call      qword ptr [7FFA4A0D4A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
       mov       rdx,rax
M00_L07:
       cmp       byte ptr [rsp+84],0
       jne       near ptr M00_L37
       test      rdx,rdx
       je        near ptr M00_L37
       mov       r8d,[rsp+80]
       cmp       r8d,[rsp+90]
       ja        near ptr M00_L44
       mov       rcx,[rsp+88]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+90]
       sub       eax,r8d
       mov       edi,[rdx+8]
       cmp       edi,eax
       ja        near ptr M00_L37
       mov       r8d,edi
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+80]
       mov       [rsp+80],edi
M00_L08:
       mov       ecx,[rsp+80]
       cmp       ecx,[rsp+90]
       ja        near ptr M00_L44
       mov       rdx,[rsp+88]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+90]
       sub       eax,ecx
       je        near ptr M00_L38
       mov       rdi,26D78800658
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+80]
       inc       ecx
       mov       [rsp+80],ecx
M00_L09:
       mov       rcx,offset MT_System.Reflection.RtFieldInfo
       cmp       [rsi],rcx
       jne       near ptr M00_L40
       mov       rdx,[rsi+20]
       test      rdx,rdx
       je        near ptr M00_L39
M00_L10:
       cmp       byte ptr [rsp+84],0
       jne       near ptr M00_L41
       test      rdx,rdx
       je        near ptr M00_L41
       mov       r8d,[rsp+80]
       cmp       r8d,[rsp+90]
       ja        near ptr M00_L44
       mov       rcx,[rsp+88]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       mov       eax,[rsp+90]
       sub       eax,r8d
       mov       ebp,[rdx+8]
       cmp       ebp,eax
       ja        near ptr M00_L41
       mov       r8d,ebp
       add       r8,r8
       add       rdx,0C
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,[rsp+80]
       mov       [rsp+80],ebp
M00_L11:
       mov       ecx,[rsp+80]
       cmp       ecx,[rsp+90]
       ja        near ptr M00_L44
       mov       rdx,[rsp+88]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+90]
       sub       eax,ecx
       je        near ptr M00_L42
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+80]
       inc       ecx
       mov       [rsp+80],ecx
M00_L12:
       cmp       byte ptr [rsp+84],0
       jne       near ptr M00_L43
       mov       ecx,[rsp+80]
       cmp       ecx,[rsp+90]
       ja        near ptr M00_L44
       mov       rdx,[rsp+88]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+90]
       sub       eax,ecx
       cmp       eax,0C
       jb        near ptr M00_L43
       vmovups   xmm0,[7FFA4A75B4C0]
       vmovups   [rdx],xmm0
       mov       rcx,65007400750062
       mov       [rdx+10],rcx
       mov       ecx,[rsp+80]
       add       ecx,0C
       mov       [rsp+80],ecx
M00_L13:
       mov       r8d,[rsp+80]
       cmp       r8d,[rsp+90]
       ja        near ptr M00_L44
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       rdx,[rsp+88]
       mov       ecx,r8d
       lea       rdx,[rdx+rcx*2]
       mov       ecx,[rsp+90]
       sub       ecx,r8d
       mov       r8d,ecx
       lea       rcx,[rsp+58]
       call      qword ptr [7FFA4A6CD7E8]; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       vmovdqu   xmm0,xmmword ptr [rsp+58]
       vmovdqu   xmmword ptr [rsp+38],xmm0
       lea       rdx,[rsp+38]
       mov       rcx,rdi
       call      qword ptr [7FFA4A6CD800]; System.String.TryCopyTo(System.Span`1<Char>)
       test      eax,eax
       je        near ptr M00_L45
       mov       ecx,[rsp+80]
       inc       ecx
       mov       [rsp+80],ecx
M00_L14:
       mov       rcx,26D78810770
       call      qword ptr [7FFA49F3C588]; System.RuntimeType.get_Cache()
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A4C67A8]; System.RuntimeType+RuntimeTypeCache.GetFullName()
       mov       rdx,rax
       lea       rcx,[rsp+70]
       call      qword ptr [7FFA4A1BE088]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       lea       rcx,[rsp+70]
       call      qword ptr [7FFA4A1B4E40]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       rdi,rax
       mov       rcx,22CF9800108
       mov       rcx,[rcx]
       lea       r9,[rsp+68]
       mov       r8,rdi
       mov       rdx,7FFA4A68A550
       call      qword ptr [7FFA4A5FEE20]; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
       test      eax,eax
       je        near ptr M00_L46
       mov       rbp,[rsp+68]
M00_L15:
       xor       ecx,ecx
       mov       [rsp+68],rcx
       mov       [rsp+48],rbp
       mov       rcx,[rbx+60]
       lea       r8,[rsp+48]
       mov       rdx,7FFA4A6A9F68
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A6C4030]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,98
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L16:
       call      qword ptr [7FFA4A54E2B0]
       mov       ecx,26A1
       mov       rdx,7FFA4A285DD8
       call      qword ptr [7FFA4A1B7738]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A285DD8
       call      qword ptr [7FFA4A1B7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F37858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,110B
       mov       rdx,7FFA4A285DD8
       call      qword ptr [7FFA4A1B7738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F37858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6CD770]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6CC558]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L17:
       mov       ecx,3
       call      qword ptr [7FFA4A6C7390]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L18:
       mov       rcx,r14
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FFA4A6C78E8]
       jmp       near ptr M00_L01
M00_L19:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L31
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L30
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFA49F35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFA49E7B17C],0
       je        short M00_L20
       call      qword ptr [7FFA4A6C7900]
       mov       r15d,eax
       jmp       short M00_L22
M00_L20:
       mov       ecx,9
       call      qword ptr [7FFA4A6C7918]
       mov       r15d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFA4A6C7918]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M00_L21
       call      qword ptr [7FFA4A6C7930]
       mov       r15d,eax
       jmp       short M00_L22
M00_L21:
       sar       r15d,10
M00_L22:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFA49F35740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFA49E7B170]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M00_L26
M00_L23:
       cmp       r15d,[r14+8]
       jae       near ptr M00_L48
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FFA4A4CD680]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L24
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M00_L24:
       mov       rcx,r12
       call      qword ptr [7FFA49F36820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M00_L27
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M00_L25
       xor       r15d,r15d
M00_L25:
       inc       r13d
M00_L26:
       cmp       [r14+8],r13d
       jg        short M00_L23
       jmp       short M00_L28
M00_L27:
       mov       r14,r12
       jmp       short M00_L29
M00_L28:
       xor       r14d,r14d
M00_L29:
       test      r14,r14
       je        short M00_L30
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L01
       mov       rcx,r14
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FFA4A6C78E8]
       jmp       near ptr M00_L01
M00_L30:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L01
       jmp       short M00_L32
M00_L31:
       mov       ecx,100
       mov       rdx,26D78806F28
       call      qword ptr [7FFA4A1BD7D0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L30
M00_L32:
       mov       rcx,r14
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rdi
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rbp
       call      qword ptr [7FFA4A6C78E8]
       mov       rcx,rdi
       call      qword ptr [7FFA4A3DCA08]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFA4A6C7978]
       jmp       near ptr M00_L01
M00_L33:
       xor       ecx,ecx
       jmp       near ptr M00_L02
M00_L34:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M00_L02
M00_L35:
       xor       edx,edx
       jmp       near ptr M00_L07
M00_L36:
       mov       rax,[rcx]
       mov       rax,[rax+50]
       call      qword ptr [rax+20]
       mov       rdx,rax
       jmp       near ptr M00_L07
M00_L37:
       lea       rcx,[rsp+70]
       call      qword ptr [7FFA4A6C7678]
       jmp       near ptr M00_L08
M00_L38:
       lea       rcx,[rsp+70]
       mov       rdi,26D78800658
       mov       rdx,rdi
       call      qword ptr [7FFA4A5FC7E0]
       jmp       near ptr M00_L09
M00_L39:
       mov       rcx,rsi
       call      qword ptr [7FFA4A6CD7B8]; System.RuntimeFieldHandle.GetName(System.IRuntimeFieldInfo)
       mov       rbp,rax
       lea       rcx,[rsi+20]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,rbp
       jmp       near ptr M00_L10
M00_L40:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       rdx,rax
       jmp       near ptr M00_L10
M00_L41:
       lea       rcx,[rsp+70]
       call      qword ptr [7FFA4A6C7678]
       jmp       near ptr M00_L11
M00_L42:
       lea       rcx,[rsp+70]
       mov       rdx,rdi
       call      qword ptr [7FFA4A5FC7E0]
       jmp       near ptr M00_L12
M00_L43:
       lea       rcx,[rsp+70]
       mov       rdx,26D78810740
       call      qword ptr [7FFA4A6C7678]
       jmp       near ptr M00_L13
M00_L44:
       call      qword ptr [7FFA4A0D7138]
       int       3
M00_L45:
       lea       rcx,[rsp+70]
       mov       rdx,rdi
       call      qword ptr [7FFA4A5FC7E0]
       jmp       near ptr M00_L14
M00_L46:
       mov       rcx,rsi
       mov       rdx,26D78810770
       xor       r8d,r8d
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+28]
       mov       rdx,rax
       lea       r8,[rsp+50]
       mov       rcx,7FFA4A6A63E0
       call      qword ptr [7FFA4A1BCA50]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rdx,rax
       mov       rcx,offset MT_System.ObsoleteAttribute
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       je        short M00_L47
       mov       ecx,5
       call      qword ptr [7FFA4A5FEEC8]; System.TimeSpan.FromMinutes(Int64)
       mov       [rsp+20],rax
       mov       rcx,22CF9800108
       mov       rcx,[rcx]
       mov       r8,rdi
       mov       r9,rbp
       mov       rdx,7FFA4A6A6740
       call      qword ptr [7FFA4A5FEE80]; DotNetTips.Spargine.Core.Cache.InMemoryCache.AddCacheItem[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon, System.TimeSpan)
       jmp       near ptr M00_L15
M00_L47:
       xor       ebp,ebp
       jmp       near ptr M00_L15
M00_L48:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2387
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
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       test      rdi,rdi
       je        near ptr M01_L16
       test      bl,1
       jne       near ptr M01_L17
       mov       ebp,1
M01_L00:
       cmp       qword ptr [rsi+10],0
       je        short M01_L01
       mov       rcx,[rsi+10]
       mov       r14,[rcx]
       test      r14,r14
       jne       short M01_L04
M01_L01:
       mov       rcx,rsi
       call      qword ptr [7FFA49F37C48]; System.RuntimeType.InitializeCache()
       mov       rsi,rax
M01_L02:
       mov       r14d,ebp
       mov       r15,rdi
       cmp       [rsi],sil
       lea       r13,[rsi+50]
       mov       r12,[r13]
       test      r12,r12
       je        near ptr M01_L18
M01_L03:
       mov       rsi,r12
       cmp       [rsi],sil
       cmp       r14d,1
       jne       near ptr M01_L19
       mov       rbp,[rsi+20]
       test      rbp,rbp
       je        near ptr M01_L27
       test      r15,r15
       jne       short M01_L05
       movsx     rdx,byte ptr [0]
       mov       edx,[0]
       add       edx,edx
       movsx     rcx,byte ptr [0]
       xor       ecx,ecx
       mov       r8d,27E99435
       mov       r9d,6C0D1DDE
       call      qword ptr [7FFA4A3DCC48]; System.Marvin.ComputeHash32(Byte ByRef, UInt32, UInt32, UInt32)
       jmp       short M01_L06
M01_L04:
       mov       rsi,r14
       jmp       short M01_L02
M01_L05:
       mov       rcx,r15
       call      qword ptr [7FFA49F366D0]; System.String.GetNonRandomizedHashCode()
M01_L06:
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
       jae       near ptr M01_L37
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        near ptr M01_L27
M01_L07:
       cmp       r13,r15
       jne       near ptr M01_L21
M01_L08:
       mov       rcx,[rbp+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M01_L37
       mov       edx,r14d
       mov       rdi,[rcx+rdx*8+10]
M01_L09:
       test      rdi,rdi
       je        near ptr M01_L28
M01_L10:
       xor       esi,esi
       xor       ebx,2
       xor       ebp,ebp
       mov       r14d,[rdi+8]
       mov       r15d,10
       inc       r14d
M01_L11:
       dec       r14d
       je        short M01_L14
       mov       r13,[rdi+r15]
       mov       ecx,[r13+18]
       mov       eax,ebx
       and       eax,ecx
       cmp       eax,ecx
       jne       short M01_L13
       test      rsi,rsi
       jne       near ptr M01_L33
M01_L12:
       mov       rsi,r13
M01_L13:
       add       r15,8
       jmp       short M01_L11
M01_L14:
       test      ebp,ebp
       jne       near ptr M01_L35
M01_L15:
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
M01_L16:
       mov       ecx,3E7
       mov       rdx,7FFA49E74000
       call      qword ptr [7FFA4A1B7738]
       mov       rcx,rax
       call      qword ptr [7FFA4A6C6B50]
       int       3
M01_L17:
       mov       rcx,22CE3801FA8
       mov       rcx,[rcx]
       mov       rdx,rdi
       call      qword ptr [7FFA4A6CC240]
       mov       rdi,rax
       mov       ebp,2
       jmp       near ptr M01_L00
M01_L18:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.Reflection.RuntimeFieldInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       lea       rcx,[r12+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r13
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rsi,rax
       test      rsi,rsi
       cmove     rsi,r12
       mov       r12,rsi
       jmp       near ptr M01_L03
M01_L19:
       cmp       ebp,2
       je        near ptr M01_L29
       cmp       byte ptr [r12+18],0
       je        near ptr M01_L32
       jmp       near ptr M01_L31
M01_L20:
       cmp       r14d,edi
       jae       near ptr M01_L37
       mov       ecx,r14d
       mov       r13,[r12+rcx*8+10]
       test      r13,r13
       je        short M01_L27
       jmp       near ptr M01_L07
M01_L21:
       test      r15,r15
       jne       short M01_L23
M01_L22:
       inc       r14d
       mov       edi,[r12+8]
       cmp       edi,r14d
       jg        short M01_L20
       jmp       short M01_L26
M01_L23:
       mov       ecx,[r13+8]
       cmp       ecx,[r15+8]
       jne       short M01_L22
       lea       rcx,[r13+0C]
       lea       rdx,[r15+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       jne       short M01_L24
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
       jmp       short M01_L25
M01_L24:
       call      qword ptr [7FFA49F3FB70]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
M01_L25:
       test      eax,eax
       je        short M01_L22
       jmp       near ptr M01_L08
M01_L26:
       sub       r14d,edi
       jmp       short M01_L20
M01_L27:
       xor       edi,edi
       jmp       near ptr M01_L09
M01_L28:
       mov       rcx,rsi
       mov       rdx,r15
       mov       r8d,1
       mov       r9d,2
       call      qword ptr [7FFA49F3D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L29:
       lea       rcx,[r12+28]
       mov       r8,rdi
       mov       rdx,offset MT_System.Reflection.CerHashtable<System.String, System.Reflection.RuntimeFieldInfo[]>
       call      qword ptr [7FFA49F3F3C0]; System.Reflection.CerHashtable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].get_Item(System.__Canon)
       test      rax,rax
       jne       short M01_L30
       mov       rcx,r12
       mov       rdx,rdi
       mov       r8d,2
       mov       r9d,2
       call      qword ptr [7FFA49F3D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
M01_L30:
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L31:
       mov       rdi,[r12+8]
       jmp       near ptr M01_L10
M01_L32:
       mov       rcx,r12
       mov       r8d,ebp
       xor       edx,edx
       mov       r9d,2
       call      qword ptr [7FFA49F3D2C0]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rdi,rax
       jmp       near ptr M01_L10
M01_L33:
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
       je        near ptr M01_L36
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA49F3ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L34
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA49F3ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        short M01_L34
       mov       ebp,1
M01_L34:
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
       jne       near ptr M01_L12
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA49F3ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L13
       jmp       near ptr M01_L12
M01_L35:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       cmp       [rcx],ecx
       call      qword ptr [7FFA49F3ED30]; System.Type.get_IsInterface()
       test      eax,eax
       je        near ptr M01_L15
M01_L36:
       mov       rcx,rsi
       call      qword ptr [7FFA4A6CC318]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1052
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
       call      00007FFAA9B21870
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
       mov       rax,7FFA4A096D90
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9AB2C30
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M02_L04
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFAA9B304E0
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
       call      qword ptr [7FFA4A6CD908]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA4A6CC570]
       jmp       near ptr M02_L00
M02_L09:
       call      qword ptr [7FFA49F36328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA49F37C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
       mov       rbx,[rbp+10]
       jmp       near ptr M02_L02
M02_L11:
       mov       rdx,rax
       call      qword ptr [7FFA49F36328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
; Total bytes of code 568
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
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     ebx,al
       mov       rbp,[rsp+30]
       cmp       dword ptr [7FFAA9E7F778],0
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
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFAA9E7F778],0
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
       call      00007FFAA9B22E70
M03_L10:
       test      eax,eax
       mov       rbp,[rsp+38]
       jne       near ptr M03_L27
M03_L11:
       cmp       rdi,rsi
       jne       near ptr M03_L29
       mov       rcx,[rbp+18]
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FFAA9E7F778],0
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
       call      qword ptr [7FFA4A6CC540]
       mov       r8,rax
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFA4A6CC558]
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
       call      qword ptr [7FFA4A0D4A98]; System.RuntimeTypeHandle.ConstructName(System.TypeNameFormatFlags)
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
       jb        near ptr M05_L09
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M05_L09
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       near ptr M05_L06
       cmp       r8,40
       jbe       short M05_L02
       cmp       r8,800
       ja        near ptr M05_L10
       cmp       r8,100
       jb        short M05_L00
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
M05_L00:
       mov       r9,r8
       shr       r9,6
M05_L01:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M05_L01
       and       r8,3F
       cmp       r8,10
       jbe       short M05_L03
M05_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M05_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M05_L05
M05_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M05_L04:
       vzeroupper
       ret
M05_L05:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M05_L03
M05_L06:
       test      r8b,18
       jne       short M05_L07
       test      r8b,4
       jne       short M05_L08
       test      r8,r8
       je        short M05_L04
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M05_L04
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M05_L04
M05_L07:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M05_L04
M05_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M05_L04
M05_L09:
       cmp       rcx,rdx
       jne       short M05_L10
       cmp       [rdx],dl
       jmp       short M05_L04
M05_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFA49F366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 313
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
       jg        short M07_L00
       add       r8,r8
       mov       rcx,[rdx]
       lea       rdx,[rax+0C]
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,1
M07_L00:
       mov       eax,r10d
       add       rsp,28
       ret
; Total bytes of code 50
```
```assembly
; System.RuntimeType.get_Cache()
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M08_L00
       mov       rax,[rax]
       test      rax,rax
       je        short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFA49F37C48]; System.RuntimeType.InitializeCache()
; Total bytes of code 24
```
```assembly
; System.RuntimeType+RuntimeTypeCache.GetFullName()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rax,[rbx+20]
       test      rax,rax
       je        short M09_L00
       add       rsp,20
       pop       rbx
       ret
M09_L00:
       mov       rcx,[rbx+8]
       call      qword ptr [7FFA4A0D4A68]; System.RuntimeType.IsFullNameRoundtripCompatible(System.RuntimeType)
       test      eax,eax
       jne       short M09_L01
       xor       eax,eax
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       lea       rdx,[rbx+20]
       mov       rcx,rbx
       mov       r8d,3
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA4A0D4A80]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
; Total bytes of code 69
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       cmp       byte ptr [rbx+14],0
       jne       short M10_L01
       test      rdx,rdx
       je        short M10_L01
       lea       r8,[rbx+18]
       mov       ecx,[rbx+10]
       mov       eax,[r8+8]
       cmp       ecx,eax
       ja        short M10_L00
       mov       r8,[r8]
       mov       r10d,ecx
       lea       r10,[r8+r10*2]
       sub       eax,ecx
       mov       esi,[rdx+8]
       cmp       esi,eax
       ja        short M10_L01
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,r10
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       [rbx+10],esi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M10_L00:
       call      qword ptr [7FFA4A0D7138]
       int       3
M10_L01:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA4A6C7678]
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
       mov       rcx,22CE3800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFA4A2810F8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M11_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L01:
       call      qword ptr [7FFA4A0D7138]
       int       3
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Core.Cache.InMemoryCache.TryGetValue[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon ByRef)
; 		key = key.ArgumentNotNullOrEmpty();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (this.Cache.TryGetValue(key, out var item) && item is T t)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			value = t;
; 			^^^^^^^^^^
; 			return true;
; 			^^^^^^^^^^^^
; 		value = default;
; 		^^^^^^^^^^^^^^^^
; 		return false;
; 		^^^^^^^^^^^^^
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
       vmovdqu   ymmword ptr [rsp+40],ymm4
       xor       eax,eax
       mov       [rsp+60],rax
       mov       [rsp+70],rdx
       mov       [rsp+0D8],r9
       mov       rbp,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       je        near ptr M12_L30
       mov       rdi,[rsp+0D8]
       mov       r14d,[rbx+8]
       test      r14d,r14d
       je        near ptr M12_L30
       movzx     ecx,word ptr [rbx+0C]
       cmp       ecx,100
       jge       near ptr M12_L32
       mov       rax,7FFAA8D06920
       test      byte ptr [rax+rcx],80
       jne       near ptr M12_L34
M12_L00:
       dec       r14d
       mov       ecx,r14d
       movzx     ecx,word ptr [rbx+rcx*2+0C]
       cmp       ecx,100
       jge       near ptr M12_L33
       mov       rax,7FFAA8D06920
       test      byte ptr [rax+rcx],80
       jne       near ptr M12_L34
M12_L01:
       mov       rbp,[rbp+10]
       mov       [rsp+38],rbp
       test      rbx,rbx
       jne       near ptr M12_L08
       xor       r14d,r14d
       xor       r15d,r15d
M12_L02:
       cmp       byte ptr [rbp+44],0
       jne       near ptr M12_L35
       mov       rbx,[rbp+28]
       mov       [rsp+30],rbx
       mov       rcx,[rbx+20]
       mov       r13,[rcx+8]
       mov       r12,[r13+8]
       mov       rcx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rcx
       jne       near ptr M12_L36
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       lea       rcx,[rsp+40]
       call      qword ptr [7FFA4A545740]; System.String.GetNonRandomizedHashCode(System.ReadOnlySpan`1<Char>)
M12_L03:
       mov       [rsp+6C],eax
       mov       rdx,[r13+10]
       mov       r8d,eax
       imul      r8,[r13+28]
       shr       r8,20
       inc       r8
       mov       ecx,[rdx+8]
       mov       r11d,ecx
       imul      r8,r11
       shr       r8,20
       cmp       r8d,ecx
       jae       near ptr M12_L86
       mov       r8d,r8d
       mov       r13,[rdx+r8*8+10]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rdx
       jne       near ptr M12_L28
M12_L04:
       test      r13,r13
       je        near ptr M12_L70
       cmp       eax,[r13+20]
       jne       near ptr M12_L48
       mov       r8,[r13+8]
       test      r15d,r15d
       je        near ptr M12_L37
M12_L05:
       test      r8,r8
       jne       near ptr M12_L09
       xor       edx,edx
       xor       ecx,ecx
M12_L06:
       cmp       r15d,ecx
       jne       near ptr M12_L27
       mov       r11,r14
       mov       r10,rdx
       mov       r9d,ecx
       add       r9,r9
       cmp       r9,8
       jb        near ptr M12_L38
       cmp       r11,r10
       je        near ptr M12_L11
       cmp       r9,20
       jb        near ptr M12_L43
       xor       edx,edx
       add       r9,0FFFFFFFFFFFFFFE0
       je        short M12_L10
       vmovups   ymm0,[r14]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M12_L47
M12_L07:
       add       rdx,20
       cmp       r9,rdx
       jbe       short M12_L10
       vmovups   ymm0,[r14+rdx]
       vpcmpeqb  ymm0,ymm0,[r10+rdx]
       vpmovmskb ecx,ymm0
       cmp       ecx,0FFFFFFFF
       jne       near ptr M12_L47
       jmp       short M12_L07
M12_L08:
       lea       r14,[rbx+0C]
       mov       r15d,[rbx+8]
       jmp       near ptr M12_L02
M12_L09:
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       near ptr M12_L06
M12_L10:
       vmovups   ymm0,[r14+r9]
       vpcmpeqb  ymm0,ymm0,[r10+r9]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M12_L47
M12_L11:
       mov       r9d,1
M12_L12:
       test      r9d,r9d
       je        near ptr M12_L48
M12_L13:
       mov       r14,[r13+10]
M12_L14:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       jne       near ptr M12_L73
       mov       [rsp+28],r14
       mov       [rsp+0D8],rdi
       lea       rcx,[rsp+50]
       mov       rax,7FFBCE505380
       call      rax
       mov       rbx,[rsp+50]
       mov       rax,22CE3801AA8
       mov       rdi,[rax]
       sub       rbx,[rdi+8]
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M12_L71
M12_L15:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M12_L72
       add       rbx,[rdi+10]
M12_L16:
       mov       rdi,[rsp+0D8]
M12_L17:
       mov       r14,[rsp+28]
       test      r14,r14
       je        near ptr M12_L83
       cmp       byte ptr [r14+43],0
       jne       near ptr M12_L78
       mov       rdx,[r14+38]
       test      rdx,rdx
       jl        near ptr M12_L74
M12_L18:
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rbx
       cmp       rdx,rcx
       jbe       near ptr M12_L75
       cmp       qword ptr [r14+50],0
       jg        near ptr M12_L76
M12_L19:
       xor       r15d,r15d
M12_L20:
       test      r15d,r15d
       jne       near ptr M12_L78
M12_L21:
       cmp       qword ptr [r14+10],0
       jne       near ptr M12_L77
M12_L22:
       mov       [r14+58],rbx
       mov       r15,[r14+20]
       mov       rbp,[rsp+38]
       cmp       byte ptr [rbp+45],0
       jne       near ptr M12_L79
M12_L23:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+28]
       mov       rdx,[rbp+48]
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rbx
       mov       r8,3FFFFFFFFFFFFFFF
       and       rdx,r8
       sub       rax,rdx
       cmp       rcx,rax
       jl        near ptr M12_L80
M12_L24:
       cmp       qword ptr [rbp+20],0
       jne       near ptr M12_L81
M12_L25:
       mov       rcx,[rsi+18]
       mov       rbp,[rcx]
       mov       rcx,rbp
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       je        near ptr M12_L85
       mov       rdx,r15
       test      rdx,rdx
       je        short M12_L26
       mov       rcx,rbp
       cmp       [rdx],rcx
       je        short M12_L26
       mov       rdx,r15
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
M12_L26:
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M12_L27:
       xor       r9d,r9d
       jmp       near ptr M12_L12
M12_L28:
       test      r13,r13
       jne       near ptr M12_L49
       jmp       near ptr M12_L70
M12_L29:
       add       rdx,20
       cmp       r9,rdx
       jbe       near ptr M12_L59
       vmovups   ymm0,[r14+rdx]
       vpcmpeqb  ymm0,ymm0,[r10+rdx]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       jne       near ptr M12_L61
       jmp       short M12_L29
M12_L30:
       call      qword ptr [7FFA4A3D4108]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M12_L31
       call      qword ptr [7FFA4A6CD770]
       mov       rbx,rax
M12_L31:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26D78809C08
       call      qword ptr [7FFA4A6CC558]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M12_L32:
       call      qword ptr [7FFA4A6C70C0]
       test      eax,eax
       jne       short M12_L34
       jmp       near ptr M12_L00
M12_L33:
       call      qword ptr [7FFA4A6C70C0]
       test      eax,eax
       je        near ptr M12_L01
M12_L34:
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFA4A6C70D8]
       mov       rbx,rax
       jmp       near ptr M12_L01
M12_L35:
       call      qword ptr [7FFA4A5FF660]
       int       3
M12_L36:
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       lea       rdx,[rsp+40]
       mov       rcx,r12
       mov       r11,7FFA49E80BA0
       call      qword ptr [r11]
       jmp       near ptr M12_L03
M12_L37:
       test      r8,r8
       je        near ptr M12_L48
       jmp       near ptr M12_L05
M12_L38:
       cmp       r9,4
       jae       short M12_L41
       xor       ecx,ecx
       mov       r8,r9
       and       r8,2
       je        short M12_L39
       movzx     ecx,word ptr [r14]
       movzx     r11d,word ptr [rdx]
       sub       ecx,r11d
M12_L39:
       test      r9b,1
       je        short M12_L40
       movzx     r9d,byte ptr [r14+r8]
       movzx     edx,byte ptr [rdx+r8]
       sub       r9d,edx
       or        ecx,r9d
M12_L40:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
       jmp       short M12_L42
M12_L41:
       lea       r11,[r9-4]
       mov       ecx,[r14]
       sub       ecx,[rdx]
       mov       r10d,[r14+r11]
       sub       r10d,[rdx+r11]
       or        ecx,r10d
       sete      cl
       movzx     ecx,cl
M12_L42:
       mov       r9d,ecx
       jmp       near ptr M12_L12
M12_L43:
       cmp       r9,10
       jb        short M12_L46
       xor       edx,edx
       lea       r8,[r9-10]
       test      r8,r8
       je        short M12_L45
M12_L44:
       vmovups   xmm0,[r14+rdx]
       vpcmpeqb  xmm0,xmm0,[r10+rdx]
       vpmovmskb r9d,xmm0
       cmp       r9d,0FFFF
       jne       short M12_L47
       add       rdx,10
       cmp       r8,rdx
       ja        short M12_L44
M12_L45:
       vmovups   xmm0,[r14+r8]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M12_L47
       jmp       near ptr M12_L11
M12_L46:
       lea       r8,[r9-8]
       mov       r9,[r14]
       sub       r9,[rdx]
       mov       r10,[r14+r8]
       sub       r10,[rdx+r8]
       or        r10,r9
       sete      cl
       movzx     ecx,cl
       jmp       short M12_L42
M12_L47:
       xor       r9d,r9d
       jmp       near ptr M12_L12
M12_L48:
       mov       r13,[r13+18]
       jmp       near ptr M12_L04
M12_L49:
       cmp       eax,[r13+20]
       jne       near ptr M12_L68
       mov       r8,[r13+8]
       mov       rdx,offset MT_System.Collections.Generic.NonRandomizedStringEqualityComparer+OrdinalComparer
       cmp       [r12],rdx
       je        short M12_L50
       mov       [rsp+40],r14
       mov       [rsp+48],r15d
       lea       rdx,[rsp+40]
       mov       rcx,r12
       mov       r11,7FFA49E80BA8
       call      qword ptr [r11]
       mov       r9d,eax
       jmp       near ptr M12_L69
M12_L50:
       test      r15d,r15d
       jne       short M12_L51
       test      r8,r8
       je        near ptr M12_L68
M12_L51:
       test      r8,r8
       je        short M12_L52
       lea       rdx,[r8+0C]
       mov       ecx,[r8+8]
       jmp       short M12_L53
M12_L52:
       xor       edx,edx
       xor       ecx,ecx
M12_L53:
       cmp       r15d,ecx
       je        short M12_L54
       xor       r9d,r9d
       jmp       near ptr M12_L67
M12_L54:
       mov       r11,r14
       mov       r10,rdx
       mov       r9d,ecx
       add       r9,r9
       cmp       r9,8
       jb        near ptr M12_L62
       cmp       r11,r10
       je        near ptr M12_L60
       cmp       r9,20
       jae       short M12_L58
       cmp       r9,10
       jae       short M12_L55
       lea       r8,[r9-8]
       mov       r9,[r14]
       sub       r9,[rdx]
       mov       r10,[r14+r8]
       sub       r10,[rdx+r8]
       or        r10,r9
       sete      cl
       movzx     ecx,cl
       jmp       near ptr M12_L66
M12_L55:
       xor       edx,edx
       lea       r8,[r9-10]
       test      r8,r8
       je        short M12_L57
M12_L56:
       vmovups   xmm0,[r14+rdx]
       vpcmpeqb  xmm0,xmm0,[r10+rdx]
       vpmovmskb r9d,xmm0
       cmp       r9d,0FFFF
       jne       short M12_L61
       add       rdx,10
       cmp       r8,rdx
       ja        short M12_L56
M12_L57:
       vmovups   xmm0,[r14+r8]
       vpcmpeqb  xmm0,xmm0,[r10+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M12_L61
       jmp       short M12_L60
M12_L58:
       xor       edx,edx
       add       r9,0FFFFFFFFFFFFFFE0
       je        short M12_L59
       vmovups   ymm0,[r14]
       vpcmpeqb  ymm0,ymm0,[r10]
       vpmovmskb r8d,ymm0
       cmp       r8d,0FFFFFFFF
       je        near ptr M12_L29
       jmp       short M12_L61
M12_L59:
       vmovups   ymm0,[r14+r9]
       vpcmpeqb  ymm0,ymm0,[r10+r9]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       short M12_L61
M12_L60:
       mov       r9d,1
       jmp       short M12_L67
M12_L61:
       xor       r9d,r9d
       jmp       short M12_L67
M12_L62:
       cmp       r9,4
       jb        short M12_L63
       lea       r11,[r9-4]
       mov       ecx,[r14]
       sub       ecx,[rdx]
       mov       r8d,[r14+r11]
       sub       r8d,[rdx+r11]
       or        r8d,ecx
       sete      cl
       movzx     ecx,cl
       jmp       short M12_L66
M12_L63:
       xor       ecx,ecx
       mov       r8,r9
       and       r8,2
       je        short M12_L64
       movzx     ecx,word ptr [r14]
       movzx     r11d,word ptr [rdx]
       sub       ecx,r11d
M12_L64:
       test      r9b,1
       je        short M12_L65
       movzx     r9d,byte ptr [r14+r8]
       movzx     edx,byte ptr [rdx+r8]
       sub       r9d,edx
       or        r9d,ecx
       mov       ecx,r9d
M12_L65:
       test      ecx,ecx
       sete      cl
       movzx     ecx,cl
M12_L66:
       mov       r9d,ecx
M12_L67:
       jmp       short M12_L69
M12_L68:
       mov       r13,[r13+18]
       mov       eax,[rsp+6C]
       jmp       near ptr M12_L28
M12_L69:
       test      r9d,r9d
       je        short M12_L68
       jmp       near ptr M12_L13
M12_L70:
       xor       r14d,r14d
       mov       [rsp+28],r14
       mov       r14,[rsp+28]
       jmp       near ptr M12_L14
M12_L71:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M12_L15
M12_L72:
       call      qword ptr [7FFA4A4C61A8]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M12_L16
M12_L73:
       lea       rdx,[rsp+58]
       mov       r11,7FFA49E80BB0
       call      qword ptr [r11]
       lea       rcx,[rsp+58]
       call      qword ptr [7FFA4A5FF5D0]
       mov       r15,rax
       mov       [rsp+28],r14
       mov       rbx,r15
       jmp       near ptr M12_L17
M12_L74:
       cmp       qword ptr [r14+50],0
       je        near ptr M12_L21
       jmp       near ptr M12_L18
M12_L75:
       mov       rcx,r14
       mov       edx,3
       call      qword ptr [7FFA4A5FFE70]
       mov       r15d,1
       jmp       near ptr M12_L20
M12_L76:
       mov       rdx,[r14+58]
       mov       rcx,rbx
       call      qword ptr [7FFA4A5FF888]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       mov       rcx,rax
       mov       rdx,[r14+50]
       call      qword ptr [7FFA4A5FFFA8]
       test      eax,eax
       jne       short M12_L75
       jmp       near ptr M12_L19
M12_L77:
       mov       rcx,[r14+10]
       mov       rdx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5FFF60]
       test      eax,eax
       je        near ptr M12_L22
M12_L78:
       cmp       byte ptr [r14+45],2
       jne       short M12_L82
       jmp       near ptr M12_L22
M12_L79:
       mov       rcx,r14
       call      qword ptr [7FFA4A5FF7F8]
       jmp       near ptr M12_L23
M12_L80:
       mov       rcx,rbp
       mov       rdx,rbx
       call      qword ptr [7FFA4A5FF8B8]
       jmp       near ptr M12_L24
M12_L81:
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A6CD8F0]
       inc       qword ptr [rax+10]
       jmp       near ptr M12_L25
M12_L82:
       mov       rbp,[rsp+38]
       mov       r8,[rbp+10]
       mov       rcx,[rsp+30]
       mov       rdx,r14
       call      qword ptr [7FFA4A5FF858]
       nop
M12_L83:
       mov       rbp,[rsp+38]
       mov       rdx,[rbp+10]
       mov       rsi,[rdx+28]
       mov       rdx,[rbp+48]
       mov       rcx,rbx
       call      qword ptr [7FFA4A5FF888]; System.DateTime.op_Subtraction(System.DateTime, System.DateTime)
       cmp       rsi,rax
       jge       short M12_L84
       mov       rcx,rbp
       mov       rdx,rbx
       call      qword ptr [7FFA4A5FF8B8]
M12_L84:
       cmp       qword ptr [rbp+20],0
       je        short M12_L85
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A6CD8F0]
       inc       qword ptr [rax+18]
M12_L85:
       xor       eax,eax
       mov       [rdi],rax
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
M12_L86:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2222
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
       je        near ptr M14_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M14_L00
       test      rbx,rbx
       je        near ptr M14_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M14_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M14_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFAA9B68D20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA49F35818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L00:
       test      rbx,rbx
       je        short M14_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M14_L02
M14_L01:
       mov       rax,26D78800008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M14_L04:
       call      qword ptr [7FFA4A6C7660]
       int       3
; Total bytes of code 235
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFAA9990D78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M15_L01
       cmp       [rax],ecx
       jle       short M15_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M15_L03
M15_L00:
       add       rsp,20
       pop       rbx
       ret
M15_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M15_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M15_L00
M15_L02:
       cmp       [rax+4],edx
       jle       short M15_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M15_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M15_L03
       jmp       short M15_L00
M15_L03:
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
       call      qword ptr [7FFAA9993E40]
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
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M17_L00
       ret
M17_L00:
       jmp       qword ptr [7FFA4A1BDE18]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M18_L00
       mov       rcx,rbx
       call      qword ptr [7FFAA9990C38]
       test      eax,eax
       je        short M18_L01
       add       rsp,20
       pop       rbx
       ret
M18_L00:
       xor       ecx,ecx
       call      qword ptr [7FFAA998B268]
       int       3
M18_L01:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      rbx,rbx
       je        short M19_L00
       mov       rcx,rbx
       call      00007FFAA9B16030
       mov       esi,eax
       test      esi,esi
       jne       short M19_L01
       mov       rcx,7FFA4A72DC90
       call      CORINFO_HELP_COUNTPROFILE32
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L00:
       xor       ecx,ecx
       call      qword ptr [7FFA4A6C6B50]
       int       3
M19_L01:
       mov       rcx,7FFA4A72DC94
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,esi
       mov       rdx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFA4A6C7960]
; Total bytes of code 92
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M20_L00
       add       rsp,28
       ret
M20_L00:
       call      qword ptr [7FFAA99A09B0]
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
       jne       short M21_L01
       mov       rdx,[rbx+38]
M21_L00:
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAA998A458]; Precode of System.RuntimeFieldHandle.GetUtf8Name(System.RuntimeFieldHandleInternal)
       lea       rcx,[rsp+20]
       call      qword ptr [7FFAA998AA10]; Precode of System.MdUtf8String.ToString()
       nop
       add       rsp,30
       pop       rbx
       ret
M21_L01:
       mov       rcx,rbx
       lea       r11,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       short M21_L00
; Total bytes of code 71
```
```assembly
; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rsi,rsi
       je        near ptr M22_L05
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M22_L02
M22_L00:
       mov       rdx,rsi
       call      qword ptr [7FFA49F36850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rbp,rax
       test      rbp,rbp
       jne       short M22_L03
       mov       rcx,7FFA4A716034
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,7FFA4A716038
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+18]
       mov       rcx,[rcx+20]
       test      rcx,rcx
       je        short M22_L04
M22_L01:
       mov       rdx,rsi
       mov       r8,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA4A5FF900]; System.Linq.Enumerable.TryGetFirstNonIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
M22_L02:
       mov       rcx,rbx
       mov       rdx,7FFA4A6F9ED0
       call      qword ptr [7FFA4A1B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M22_L00
M22_L03:
       mov       rcx,7FFA4A71603C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rbp
       mov       rdx,7FFA4A716040
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rbp
       mov       rdx,rdi
       mov       rax,[rcx]
       mov       rax,[rax+50]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax+20]
M22_L04:
       mov       rcx,rbx
       mov       rdx,7FFA4A6F9EB0
       call      qword ptr [7FFA4A1B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M22_L01
M22_L05:
       mov       rcx,7FFA4A716030
       call      CORINFO_HELP_COUNTPROFILE32
       mov       ecx,11
       call      qword ptr [7FFA4A1B7DF8]
       int       3
; Total bytes of code 257
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M23_L00
       cmp       [rdx],rcx
       jne       short M23_L01
M23_L00:
       mov       rax,rdx
       ret
M23_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
M23_L02:
       cmp       rax,rcx
       je        short M23_L00
       test      rax,rax
       je        short M23_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       test      rax,rax
       je        short M23_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       test      rax,rax
       je        short M23_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M23_L00
       test      rax,rax
       je        short M23_L03
       mov       rax,[rax+10]
       jmp       short M23_L02
M23_L03:
       xor       edx,edx
       jmp       short M23_L00
; Total bytes of code 83
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
       call      qword ptr [7FFAA998E3B8]
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
       mov       rax,26D78809C08
       mov       [rsp+20],rax
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       mov       r9,26D78800008
       call      qword ptr [7FFA4A3D40D8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
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
       mov       rdx,7FFA4A6B1FF0
       call      qword ptr [7FFA4A1B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-18],rax
M25_L01:
       mov       rax,26D7880B7A0
       mov       [rsp+20],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-10]
       mov       r9,26D78800008
       call      qword ptr [7FFA4A54E208]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp+28],rax
; 		_ = this.Cache.Set(key, item, new MemoryCacheEntryOptions().SetAbsoluteExpiration(timeout));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A5FF5E8]; DotNetTips.Spargine.Core.Cache.InMemoryCache.get_Cache()
       mov       [rbp-28],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FFA4A5FF9F0]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions..ctor()
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
       mov       rdx,7FFA4A6B24E8
       call      qword ptr [7FFA4A1B7AF8]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       [rbp-30],rax
M25_L03:
       mov       rcx,[rbp-20]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFA4A5FFA08]; Microsoft.Extensions.Caching.Memory.MemoryCacheEntryExtensions.SetAbsoluteExpiration(Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions, System.TimeSpan)
       mov       [rbp-38],rax
       mov       rax,[rbp-38]
       mov       [rsp+20],rax
       mov       rdx,[rbp-28]
       mov       r8,[rbp+20]
       mov       r9,[rbp+28]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA4A5FF9A8]; Microsoft.Extensions.Caching.Memory.CacheExtensions.Set[[System.__Canon, System.Private.CoreLib]](Microsoft.Extensions.Caching.Memory.IMemoryCache, System.Object, System.__Canon, Microsoft.Extensions.Caching.Memory.MemoryCacheEntryOptions)
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 362
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetMembersWithAttribute()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       rbx,rcx
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63<DotNetTips.Spargine.Core.InformationAttribute>
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+24],eax
       mov       rax,2EF037806C0
       mov       [rdi+18],rax
       cmp       dword ptr [rdi+20],0FFFFFFFE
       jne       near ptr M00_L11
       mov       r14d,[rdi+24]
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       cmp       r14d,eax
       jne       near ptr M00_L11
       xor       ecx,ecx
       mov       [rdi+20],ecx
       mov       r14,rdi
M00_L00:
       mov       rdx,[rdi+18]
       lea       rcx,[r14+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-40],r14
       mov       rdi,[r14]
       cmp       rdi,rsi
       jne       short M00_L04
M00_L01:
       mov       rcx,r14
       call      qword ptr [7FFA4A66A0D8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       test      eax,eax
       je        near ptr M00_L08
       mov       r15,[r14+8]
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
       jmp       short M00_L01
M00_L02:
       cmp       rdi,rsi
       jne       short M00_L07
       mov       r15,[r14+8]
M00_L03:
       mov       [rbp-38],r15
       mov       r13,[rbx+60]
       mov       rdx,[rbp-38]
       lea       rcx,[r13+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],rcx
M00_L04:
       cmp       rdi,rsi
       jne       short M00_L06
       mov       rcx,r14
       call      qword ptr [7FFA4A66A0D8]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
M00_L05:
       test      eax,eax
       jne       short M00_L02
       jmp       short M00_L08
M00_L06:
       mov       rcx,r14
       mov       r11,7FFA49E60D70
       call      qword ptr [r11]
       jmp       short M00_L05
M00_L07:
       mov       rcx,r14
       mov       r11,7FFA49E60D78
       call      qword ptr [r11]
       mov       r15,rax
       jmp       short M00_L03
M00_L08:
       cmp       rdi,rsi
       jne       short M00_L13
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L12
       cmp       ebx,1
       je        short M00_L12
M00_L09:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
M00_L10:
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L11:
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       xor       eax,eax
       mov       [r14+20],eax
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [r14+24],eax
       jmp       near ptr M00_L00
M00_L12:
       mov       rcx,r14
       call      qword ptr [7FFA4A5DEEE0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       jmp       short M00_L09
M00_L13:
       mov       rcx,r14
       mov       r11,7FFA49E60D80
       call      qword ptr [r11]
       jmp       short M00_L10
       sub       rsp,28
       mov       r14,[rbp-40]
       mov       rdi,[r14]
       mov       rsi,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63<DotNetTips.Spargine.Core.InformationAttribute>
       cmp       rdi,rsi
       jne       short M00_L16
       mov       ebx,[r14+20]
       cmp       ebx,0FFFFFFFD
       je        short M00_L14
       cmp       ebx,1
       jne       short M00_L15
M00_L14:
       mov       rcx,r14
       call      qword ptr [7FFA4A5DEEE0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
M00_L15:
       xor       ecx,ecx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       mov       [r14+38],rcx
       mov       dword ptr [r14+20],0FFFFFFFE
       jmp       short M00_L17
M00_L16:
       mov       rcx,r14
       mov       r11,7FFA49E60D80
       call      qword ptr [r11]
M00_L17:
       nop
       add       rsp,28
       ret
; Total bytes of code 495
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].MoveNext()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,348
       vzeroupper
       lea       rbp,[rsp+380]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE20
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-50],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       rbx,rcx
       lea       rcx,[rbp-268]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-250],rcx
       mov       rcx,rbp
       mov       [rbp-240],rcx
       mov       ecx,[rbx+20]
       test      ecx,ecx
       je        short M01_L02
       cmp       ecx,1
       jne       near ptr M01_L120
M01_L01:
       mov       dword ptr [rbx+20],0FFFFFFFD
       lea       rsi,[rbx+28]
       mov       rcx,[rsi]
       mov       edx,[rsi+10]
       mov       rax,[rsi]
       cmp       edx,[rax+14]
       jne       near ptr M01_L195
       mov       edx,[rsi+14]
       cmp       edx,[rcx+10]
       jae       near ptr M01_L119
       mov       rcx,[rcx+8]
       mov       edx,[rsi+14]
       cmp       edx,[rcx+8]
       jae       near ptr M01_L196
       mov       rdx,[rcx+rdx*8+10]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rsi+14]
       mov       rdx,[rbx+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [rbx+20],1
       mov       edi,1
       jmp       near ptr M01_L197
M01_L02:
       mov       dword ptr [rbx+20],0FFFFFFFF
       mov       rdx,[rbx+10]
       test      rdx,rdx
       je        near ptr M01_L121
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.Collections.Generic.List<System.Reflection.MemberInfo>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,2AE848000F8
       mov       rdx,[rcx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp-2B0],rdi
       mov       r14,[rbx+10]
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       r15,rax
       mov       rdx,r15
       mov       rcx,r14
       mov       r8d,1
       call      qword ptr [7FFA4A5DEEB0]; System.Attribute.IsDefined(System.Reflection.MemberInfo, System.Type, Boolean)
       test      eax,eax
       je        short M01_L03
       mov       r8,[rbx+10]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [rdi+10],eax
       mov       edx,edx
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
M01_L03:
       mov       rcx,[rbx+10]
       mov       rdx,offset MT_System.RuntimeType
       cmp       [rcx],rdx
       jne       near ptr M01_L122
       mov       edx,3C
       call      qword ptr [7FFA49E5A4D0]; System.RuntimeType.GetMembers(System.Reflection.BindingFlags)
       mov       r14,rax
M01_L04:
       mov       [rbp-2B8],r14
       xor       r13d,r13d
       jmp       near ptr M01_L67
M01_L05:
       mov       rcx,rdi
       mov       rdx,r8
       call      qword ptr [7FFA49F171C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       mov       rdi,[rbp-2B0]
       jmp       short M01_L03
M01_L06:
       xor       eax,eax
M01_L07:
       mov       rcx,rax
M01_L08:
       test      rcx,rcx
       je        near ptr M01_L133
M01_L09:
       mov       rax,2EF03772888
       cmp       rcx,rax
       jne       near ptr M01_L132
M01_L10:
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r12],rcx
       jne       near ptr M01_L21
       mov       r15d,8
M01_L11:
       cmp       r15d,2
       je        near ptr M01_L154
       cmp       r15d,10
       je        near ptr M01_L73
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       r15,rax
       mov       rcx,offset MT_System.Reflection.RuntimeMethodInfo
       cmp       [r12],rcx
       jne       near ptr M01_L72
       mov       [rbp-308],r15
       mov       rcx,2EF037727E0
       cmp       r15,rcx
       je        near ptr M01_L155
       mov       rcx,2EF03772888
       cmp       r15,rcx
       sete      al
       movzx     eax,al
M01_L12:
       mov       [rbp-13C],eax
       test      eax,eax
       jne       near ptr M01_L160
       mov       rcx,2AE6E800308
       mov       rdx,[rcx]
       mov       [rbp-318],rdx
       mov       r8,r15
       cmp       qword ptr [rdx+8],0
       je        near ptr M01_L20
       mov       r10,[rdx+10]
       mov       [rbp-320],r10
       xor       r9d,r9d
       mov       [rbp-140],r9d
       mov       r11,[rdx+18]
       mov       [rbp-328],r11
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.RuntimeType>
       cmp       [r11],rcx
       jne       near ptr M01_L158
       mov       r11,[rbp-328]
       mov       [rbp-150],r8
       xor       ecx,ecx
       mov       [rbp-158],rcx
       lea       rcx,[rbp-150]
       cmp       qword ptr [rbp-158],0
       jne       short M01_L13
       mov       rcx,[rbp-150]
       mov       [rbp-158],rcx
       lea       rcx,[rbp-158]
       cmp       qword ptr [rbp-158],0
       je        near ptr M01_L156
M01_L13:
       mov       r8,[rcx]
       mov       [rbp-338],r8
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r8],rcx
       jne       near ptr M01_L157
       mov       rcx,r8
       call      00007FFAA9B16270
       test      eax,eax
       je        near ptr M01_L22
M01_L14:
       mov       r8d,eax
M01_L15:
       mov       eax,r8d
M01_L16:
       xor       ecx,ecx
       mov       [rbp-158],rcx
M01_L17:
       mov       [rbp-144],eax
       mov       rdx,[rbp-318]
       mov       rcx,[rdx+8]
       mov       r8d,eax
       imul      r8,[rdx+20]
       shr       r8,20
       inc       r8
       mov       edx,[rcx+8]
       mov       r11d,edx
       imul      r8,r11
       shr       r8,20
       cmp       r8d,edx
       jae       near ptr M01_L196
       mov       edx,r8d
       lea       rdx,[rcx+rdx*4+10]
       mov       r10d,[rdx]
       dec       r10d
       js        short M01_L20
M01_L18:
       mov       r9,[rbp-320]
       mov       r11d,[r9+8]
       mov       [rbp-29C],r11d
       cmp       r10d,r11d
       jae       near ptr M01_L196
       mov       [rbp-148],r10d
       mov       edx,r10d
       shl       rdx,4
       lea       r8,[r9+rdx+10]
       mov       [rbp-330],r8
       cmp       [r8+8],eax
       je        near ptr M01_L159
M01_L19:
       mov       r10d,[r8+0C]
       mov       ecx,r10d
       mov       edx,[rbp-140]
       inc       edx
       cmp       [rbp-29C],edx
       jb        near ptr M01_L187
       test      ecx,ecx
       mov       [rbp-140],edx
       mov       r10d,ecx
       mov       eax,[rbp-144]
       jge       short M01_L18
M01_L20:
       mov       rax,[r12+38]
       mov       [rbp-340],rax
       cmp       [rax],al
       mov       rcx,rax
       call      00007FFAA9B21870
       test      rax,rax
       jne       short M01_L23
       mov       rcx,[rbp-340]
       call      qword ptr [7FFA4A125710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       jmp       short M01_L23
M01_L21:
       mov       rcx,r12
       mov       rax,[r12]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       r15d,eax
       jmp       near ptr M01_L11
M01_L22:
       mov       rcx,[rbp-338]
       call      qword ptr [7FFA4A127258]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M01_L14
M01_L23:
       mov       [rbp-310],rax
       mov       rcx,[r12+50]
       call      00007FFAA9B66460
       mov       [rbp-15C],eax
       mov       rdx,[rbp-310]
       cmp       [rdx],dl
       mov       rcx,rdx
       call      00007FFAA9B66250
       mov       [rbp-168],rax
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-1B8],ymm1
       vmovdqu   ymmword ptr [rbp-198],ymm1
       vmovdqu   xmmword ptr [rbp-178],xmm1
       mov       dword ptr [rbp-1D8],10
       mov       rcx,[rbp-168]
       lea       r9,[rbp-1AC]
       mov       [rsp+20],r9
       lea       r9,[rbp-1B8]
       mov       [rsp+28],r9
       lea       r9,[rbp-1D8]
       mov       r8d,[rbp-15C]
       mov       edx,0C000000
       mov       rax,7FFA4A1630E8
       mov       [rbp-258],rax
       lea       rax,[M01_L24]
       mov       [rbp-248],rax
       lea       rax,[rbp-268]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9B11590
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L25
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       r8,[rbp-260]
       mov       [rsi+8],r8
       mov       r8d,[rbp-1D8]
       mov       [rbp-1B0],r8d
       cmp       dword ptr [rbp-1B0],0
       je        near ptr M01_L62
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-1D0],xmm0
       vmovdqu   xmmword ptr [rbp-1C8],xmm0
       xor       ebx,ebx
       jmp       near ptr M01_L37
M01_L26:
       cmp       ebx,10
       jae       near ptr M01_L196
       lea       r8,[rbp-1AC]
       mov       edx,[r8+rbx*4]
M01_L27:
       lea       r8,[rbp-1C0]
       lea       r9,[rbp-1D0]
       mov       rcx,[rbp-168]
       call      00007FFAA9B24B90
       test      eax,eax
       jl        near ptr M01_L188
       mov       edi,[rbp-1C0]
       mov       r14,[rbp-310]
       mov       [rbp-1E0],r14
       xor       r15d,r15d
       mov       [rbp-348],r15
       mov       r12,[rbp-1E0]
       lea       r8,[rbp-200]
       mov       rcx,[rbp-168]
       mov       edx,edi
       call      00007FFAA9B254D0
       test      eax,eax
       jl        near ptr M01_L189
       mov       rcx,r12
       mov       edx,[rbp-200]
       xor       r8d,r8d
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A15AC40]; System.Reflection.RuntimeModule.ResolveType(Int32, System.Type[], System.Type[])
       mov       r12,rax
       test      r12,r12
       jne       near ptr M01_L38
M01_L28:
       xor       r12d,r12d
M01_L29:
       mov       rax,[rbp-308]
       mov       rcx,[rax+18]
       test      cl,2
       jne       near ptr M01_L164
       mov       ecx,[rcx]
       and       ecx,80000030
       cmp       ecx,30
       sete      cl
       movzx     ecx,cl
M01_L30:
       test      ecx,ecx
       jne       near ptr M01_L165
       test      r12,r12
       je        near ptr M01_L170
       cmp       r12,rax
       je        near ptr M01_L43
       cmp       [r12],r12d
       mov       rcx,[r12+18]
       mov       rdx,rcx
       mov       r8,[rax+18]
       mov       r10,r8
       cmp       rdx,r10
       je        near ptr M01_L168
       test      cl,2
       jne       short M01_L31
       test      r8b,2
       jne       near ptr M01_L169
M01_L31:
       mov       rcx,2AE6E800038
       mov       rcx,[rcx]
       add       rcx,10
       rorx      r8,rdx,20
       xor       r8,r10
       mov       r9,9E3779B97F4A7C15
       imul      r8,r9
       mov       r9d,[rcx]
       shrx      r8,r8,r9
       xor       r9d,r9d
       mov       [rbp-204],r9d
M01_L32:
       lea       r11d,[r8+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rcx+r11*8]
       mov       r15d,[r11]
       mov       r9,[r11+8]
       and       r15d,0FFFFFFFE
       cmp       r9,rdx
       jne       near ptr M01_L39
       mov       r9,r10
       xor       r9,[r11+10]
       cmp       r9,1
       ja        short M01_L39
       cmp       r15d,[r11]
       jne       near ptr M01_L40
       mov       ecx,r9d
M01_L33:
       test      ecx,ecx
       jne       near ptr M01_L41
       xor       r9d,r9d
M01_L34:
       movzx     ecx,r9b
M01_L35:
       test      ecx,ecx
       jne       near ptr M01_L44
M01_L36:
       inc       ebx
M01_L37:
       cmp       ebx,[rbp-1B0]
       jge       near ptr M01_L62
       cmp       qword ptr [rbp-1B8],0
       je        near ptr M01_L26
       mov       rdx,[rbp-1B8]
       cmp       ebx,[rdx+8]
       jae       near ptr M01_L196
       mov       edx,[rdx+rbx*4+10]
       jmp       near ptr M01_L27
M01_L38:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L28
       jmp       near ptr M01_L29
M01_L39:
       test      r15d,r15d
       je        short M01_L40
       mov       r9d,[rbp-204]
       inc       r9d
       add       r8d,r9d
       and       r8d,[rcx+4]
       cmp       r9d,8
       mov       [rbp-204],r9d
       jl        near ptr M01_L32
M01_L40:
       mov       ecx,2
       jmp       near ptr M01_L33
M01_L41:
       cmp       ecx,1
       jne       short M01_L42
       mov       r9d,1
       jmp       near ptr M01_L34
M01_L42:
       mov       rcx,rdx
       mov       rdx,r10
       mov       r8d,1
       call      qword ptr [7FFA4A124BE8]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r9d,eax
       jmp       near ptr M01_L34
M01_L43:
       mov       ecx,1
       jmp       near ptr M01_L35
M01_L44:
       mov       r8d,edi
       and       r8d,0FF000000
       cmp       r8d,0A000000
       jne       near ptr M01_L57
       lea       r8,[rbp-218]
       mov       rcx,[rbp-168]
       mov       edx,edi
       call      00007FFAA9B34C70
       test      eax,eax
       jl        near ptr M01_L190
       mov       eax,[rbp-218]
       mov       r10,[rbp-210]
M01_L45:
       test      eax,eax
       jle       near ptr M01_L192
       cmp       [r10],r10b
       cmp       eax,1
       jle       near ptr M01_L193
       cmp       byte ptr [r10+1],0
       je        short M01_L47
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA49E5A378]; System.RuntimeType.get_IsGenericType()
       test      eax,eax
       jne       near ptr M01_L171
       mov       rcx,[rbp-1E0]
       mov       [rbp-1E8],rcx
       lea       rcx,[rbp-1E8]
       mov       edx,edi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA4A12D3B0]; System.ModuleHandle.ResolveMethodHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
       mov       r15,rax
M01_L46:
       mov       [rbp-348],r15
M01_L47:
       xor       edx,edx
       mov       edi,[rbp-15C]
       mov       ecx,edi
       and       ecx,0FF000000
       cmp       ecx,8000000
       je        near ptr M01_L59
       cmp       ecx,6000000
       je        short M01_L48
       cmp       ecx,17000000
       jne       near ptr M01_L58
M01_L48:
       lea       r8,[rbp-230]
       mov       rcx,[rbp-168]
       mov       edx,edi
       call      00007FFAA9B254D0
       test      eax,eax
       jl        near ptr M01_L194
       mov       edx,[rbp-230]
M01_L49:
       mov       ecx,edx
       and       ecx,0FF000000
       cmp       ecx,2000000
       jne       near ptr M01_L173
       mov       rcx,[rbp-1E0]
       cmp       [rcx],cl
       mov       [rbp-1E8],rcx
       lea       rcx,[rbp-1E8]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA4A1274C8]; System.ModuleHandle.ResolveTypeHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
M01_L50:
       mov       [rbp-1F0],rax
       cmp       [r12],r12b
       mov       [rbp-1F8],r12
       mov       rcx,[rbp-1F8]
       test      rcx,rcx
       je        near ptr M01_L174
       mov       r12,[rcx+18]
M01_L51:
       mov       r15,[rbp-348]
       test      r15,r15
       je        near ptr M01_L61
       mov       rcx,offset MT_System.RuntimeMethodInfoStub
       cmp       [r15],rcx
       jne       near ptr M01_L175
       mov       rdx,[r15+50]
M01_L52:
       mov       rcx,[rbp-1F0]
       test      rcx,rcx
       je        near ptr M01_L176
       mov       rcx,[rcx+18]
       mov       [rbp-348],r15
M01_L53:
       mov       r8,[rbp-1E0]
       mov       r8,[r8+18]
       lea       r9,[rbp-1F8]
       mov       [rbp-278],r9
       mov       [rbp-270],r12
       lea       r9,[rbp-1F0]
       mov       [rbp-288],r9
       mov       [rbp-280],rcx
       lea       rcx,[rbp-1E0]
       mov       [rbp-298],rcx
       mov       [rbp-290],r8
       lea       rcx,[rbp-278]
       lea       r8,[rbp-288]
       lea       r9,[rbp-298]
       mov       rax,7FFA4A168068
       mov       [rbp-258],rax
       lea       rax,[M01_L54]
       mov       [rbp-248],rax
       lea       rax,[rbp-268]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9ABE060
       call      rax
M01_L54:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L55
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
M01_L55:
       mov       rcx,[rbp-260]
       mov       [rsi+8],rcx
       test      eax,eax
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L36
M01_L56:
       mov       eax,1
       jmp       near ptr M01_L64
M01_L57:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbp-228],xmm0
       lea       r8,[rbp-228]
       mov       rcx,[rbp-168]
       mov       edx,edi
       call      00007FFAA9B44850
       test      eax,eax
       jl        near ptr M01_L191
       mov       eax,[rbp-228]
       mov       r10,[rbp-220]
       jmp       near ptr M01_L45
M01_L58:
       cmp       ecx,14000000
       je        near ptr M01_L48
       cmp       ecx,4000000
       je        near ptr M01_L48
       cmp       ecx,2000000
       jne       near ptr M01_L172
       mov       edx,edi
       jmp       near ptr M01_L49
M01_L59:
       lea       rcx,[rbp-168]
       mov       edx,edi
       call      qword ptr [7FFA4A6DD170]
       mov       edx,eax
M01_L60:
       lea       rcx,[rbp-168]
       call      qword ptr [7FFA4A6DD170]
       mov       edx,eax
       jmp       near ptr M01_L49
M01_L61:
       xor       edx,edx
       jmp       near ptr M01_L52
M01_L62:
       mov       rcx,[rbp-2C0]
       call      qword ptr [7FFA4A5DF2E8]; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       mov       rbx,rax
       test      rbx,rbx
       jne       near ptr M01_L70
M01_L63:
       xor       eax,eax
M01_L64:
       mov       r12,[rbp-2C0]
M01_L65:
       test      eax,eax
       jne       near ptr M01_L116
M01_L66:
       inc       r13d
       mov       rbx,[rbp+10]
       mov       rdi,[rbp-2B0]
       mov       r14,[rbp-2B8]
M01_L67:
       mov       ecx,[r14+8]
       cmp       ecx,r13d
       jle       near ptr M01_L118
       cmp       r13d,ecx
       jae       near ptr M01_L196
       mov       r12,[r14+r13*8+10]
       mov       [rbp-2C0],r12
       test      r12,r12
       je        near ptr M01_L177
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       r15,rax
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L123
       mov       ecx,[rcx]
       and       ecx,0F0000
       cmp       ecx,0C0000
       sete      cl
       movzx     ecx,cl
M01_L68:
       test      ecx,ecx
       jne       near ptr M01_L124
       mov       rcx,r15
       call      00007FFAA9B22C30
       test      eax,eax
       jne       near ptr M01_L125
       mov       rcx,[r15+18]
       test      cl,2
       jne       near ptr M01_L06
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        near ptr M01_L06
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L131
M01_L69:
       jmp       near ptr M01_L07
M01_L70:
       mov       rdi,[rbx+38]
       cmp       [rdi],dil
       mov       rcx,rdi
       call      00007FFAA9B21870
       mov       r14,rax
       test      r14,r14
       jne       short M01_L71
       mov       rcx,rdi
       call      qword ptr [7FFA4A125710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       mov       r14,rax
M01_L71:
       mov       rcx,[rbx+50]
       call      00007FFAA9B66460
       mov       edx,eax
       mov       dword ptr [rsp+20],1
       mov       rcx,r14
       mov       r8,[rbp-308]
       xor       r9d,r9d
       call      qword ptr [7FFA4A12D368]; System.Reflection.CustomAttribute.IsCustomAttributeDefined(System.Reflection.RuntimeModule, Int32, System.RuntimeType, Int32, Boolean)
       test      eax,eax
       jne       near ptr M01_L56
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A5DF2E8]; System.Reflection.RuntimeMethodInfo.GetParentDefinition()
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L70
       jmp       near ptr M01_L63
M01_L72:
       mov       rcx,r12
       mov       rdx,r15
       mov       r8d,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       jmp       near ptr M01_L64
M01_L73:
       mov       rdx,r12
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [rdx],rcx
       jne       near ptr M01_L134
M01_L74:
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       r15,rax
       mov       rcx,offset MT_System.Reflection.RuntimePropertyInfo
       cmp       [r12],rcx
       jne       near ptr M01_L150
       mov       [rbp-2E0],r15
       mov       rax,[r12+30]
       mov       [rbp-2F0],rax
       cmp       [rax],al
       mov       rcx,rax
       call      00007FFAA9B21870
       test      rax,rax
       je        short M01_L75
       jmp       short M01_L76
M01_L75:
       mov       rcx,[rbp-2F0]
       call      qword ptr [7FFA4A125710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
       nop
M01_L76:
       mov       [rbp-2E8],rax
       mov       edx,[r12+50]
       mov       [rbp-44],edx
       cmp       [rax],al
       mov       rcx,rax
       call      00007FFAA9B66250
       mov       [rbp-50],rax
       vxorps    ymm0,ymm0,ymm0
       vmovdqu   ymmword ptr [rbp-0A0],ymm0
       vmovdqu   ymmword ptr [rbp-80],ymm0
       vmovdqu   xmmword ptr [rbp-60],xmm0
       mov       dword ptr [rbp-0D8],10
       mov       rcx,[rbp-50]
       lea       r9,[rbp-94]
       mov       [rsp+20],r9
       lea       r9,[rbp-0A0]
       mov       [rsp+28],r9
       lea       r9,[rbp-0D8]
       mov       r8d,[rbp-44]
       mov       edx,0C000000
       mov       rax,7FFA4A1630E8
       mov       [rbp-258],rax
       lea       rax,[M01_L77]
       mov       [rbp-248],rax
       lea       rax,[rbp-268]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9B11590
       call      rax
M01_L77:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L78
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
M01_L78:
       mov       r8,[rbp-260]
       mov       [rsi+8],r8
       mov       r8d,[rbp-0D8]
       mov       [rbp-98],r8d
       cmp       dword ptr [rbp-98],0
       je        near ptr M01_L111
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0B8],xmm0
       vmovdqu   xmmword ptr [rbp-0B0],xmm0
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-0D0],xmm0
       vmovdqu   xmmword ptr [rbp-0C8],xmm0
       xor       ebx,ebx
       jmp       near ptr M01_L90
M01_L79:
       cmp       ebx,10
       jae       near ptr M01_L196
       lea       r8,[rbp-94]
       mov       edx,[r8+rbx*4]
M01_L80:
       lea       r8,[rbp-0A8]
       lea       r9,[rbp-0B8]
       mov       rcx,[rbp-50]
       call      00007FFAA9B24B90
       test      eax,eax
       jl        near ptr M01_L179
       mov       edi,[rbp-0A8]
       mov       r14,[rbp-2E8]
       mov       [rbp-0E0],r14
       xor       r15d,r15d
       mov       [rbp-2F8],r15
       mov       r12,[rbp-0E0]
       lea       r8,[rbp-100]
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      00007FFAA9B254D0
       test      eax,eax
       jl        near ptr M01_L180
       mov       rcx,r12
       mov       edx,[rbp-100]
       xor       r8d,r8d
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A15AC40]; System.Reflection.RuntimeModule.ResolveType(Int32, System.Type[], System.Type[])
       mov       r12,rax
       test      r12,r12
       jne       near ptr M01_L91
M01_L81:
       xor       r12d,r12d
M01_L82:
       mov       rax,[rbp-2E0]
       mov       rcx,[rax+18]
       mov       rdx,rcx
       test      dl,2
       jne       near ptr M01_L135
       mov       edx,[rdx]
       and       edx,80000030
       cmp       edx,30
       sete      dl
       movzx     edx,dl
M01_L83:
       test      edx,edx
       jne       near ptr M01_L136
       test      r12,r12
       je        near ptr M01_L142
       cmp       r12,rax
       je        near ptr M01_L95
       mov       rdx,[r12+18]
       mov       r8,rdx
       mov       r10,rcx
       cmp       r8,r10
       je        near ptr M01_L139
       test      dl,2
       jne       short M01_L84
       test      cl,2
       jne       near ptr M01_L140
M01_L84:
       mov       rcx,2AE6E800038
       mov       rcx,[rcx]
       mov       rdx,r8
       mov       r9,r10
       add       rcx,10
       rol       rdx,20
       xor       rdx,r9
       mov       r9,9E3779B97F4A7C15
       imul      rdx,r9
       mov       r9d,[rcx]
       shrx      rdx,rdx,r9
       xor       r9d,r9d
M01_L85:
       lea       r11d,[rdx+1]
       movsxd    r11,r11d
       lea       r11,[r11+r11*2]
       lea       r11,[rcx+r11*8]
       mov       r15d,[r11]
       mov       rax,[r11+8]
       and       r15d,0FFFFFFFE
       cmp       rax,r8
       jne       near ptr M01_L92
       mov       rax,r10
       xor       rax,[r11+10]
       cmp       rax,1
       ja        short M01_L92
       cmp       r15d,[r11]
       jne       near ptr M01_L141
       mov       ecx,eax
M01_L86:
       test      ecx,ecx
       jne       near ptr M01_L93
       xor       r9d,r9d
M01_L87:
       movzx     ecx,r9b
M01_L88:
       test      ecx,ecx
       jne       near ptr M01_L96
M01_L89:
       inc       ebx
M01_L90:
       cmp       ebx,[rbp-98]
       jge       near ptr M01_L111
       cmp       qword ptr [rbp-0A0],0
       je        near ptr M01_L79
       mov       rdx,[rbp-0A0]
       cmp       ebx,[rdx+8]
       jae       near ptr M01_L196
       mov       edx,[rdx+rbx*4+10]
       jmp       near ptr M01_L80
M01_L91:
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r12],rcx
       jne       near ptr M01_L81
       jmp       near ptr M01_L82
M01_L92:
       test      r15d,r15d
       je        near ptr M01_L141
       inc       r9d
       add       edx,r9d
       and       edx,[rcx+4]
       cmp       r9d,8
       jl        near ptr M01_L85
       jmp       near ptr M01_L141
M01_L93:
       cmp       ecx,1
       jne       short M01_L94
       mov       r9d,1
       jmp       near ptr M01_L87
M01_L94:
       mov       rcx,r8
       mov       rdx,r10
       mov       r8d,1
       call      qword ptr [7FFA4A124BE8]; System.Runtime.CompilerServices.TypeHandle.CanCastToWorker(System.Runtime.CompilerServices.TypeHandle, System.Runtime.CompilerServices.TypeHandle, Boolean)
       mov       r9d,eax
       jmp       near ptr M01_L87
M01_L95:
       mov       ecx,1
       jmp       near ptr M01_L88
M01_L96:
       lea       r8,[rbp-0D0]
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFA4A1275A0]; System.Reflection.CustomAttribute.AttributeUsageCheck(System.RuntimeType, Boolean, ListBuilder`1<System.Object> ByRef)
       test      eax,eax
       je        near ptr M01_L89
       mov       r8d,edi
       and       r8d,0FF000000
       cmp       r8d,0A000000
       jne       near ptr M01_L108
       lea       r8,[rbp-120]
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      00007FFAA9B34C70
       test      eax,eax
       jl        near ptr M01_L181
       mov       eax,[rbp-120]
       mov       r10,[rbp-118]
M01_L97:
       test      eax,eax
       jle       near ptr M01_L182
       cmp       [r10],r10b
       cmp       eax,1
       jle       near ptr M01_L183
       cmp       byte ptr [r10+1],0
       je        short M01_L99
       mov       rcx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFA49E5A378]; System.RuntimeType.get_IsGenericType()
       test      eax,eax
       jne       near ptr M01_L143
       mov       rcx,[rbp-0E0]
       mov       [rbp-0E8],rcx
       lea       rcx,[rbp-0E8]
       mov       edx,edi
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA4A12D3B0]; System.ModuleHandle.ResolveMethodHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
       mov       r15,rax
M01_L98:
       mov       [rbp-2F8],r15
M01_L99:
       xor       edx,edx
       mov       edi,[rbp-44]
       mov       ecx,edi
       and       ecx,0FF000000
       cmp       ecx,8000000
       je        near ptr M01_L144
       cmp       ecx,6000000
       je        short M01_L100
       cmp       ecx,17000000
       jne       near ptr M01_L109
M01_L100:
       lea       r8,[rbp-138]
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      00007FFAA9B254D0
       test      eax,eax
       jl        near ptr M01_L186
       mov       edx,[rbp-138]
M01_L101:
       mov       ecx,edx
       and       ecx,0FF000000
       cmp       ecx,2000000
       jne       near ptr M01_L146
       mov       rcx,[rbp-0E0]
       cmp       [rcx],cl
       mov       [rbp-0E8],rcx
       lea       rcx,[rbp-0E8]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFA4A1274C8]; System.ModuleHandle.ResolveTypeHandle(Int32, System.RuntimeTypeHandle[], System.RuntimeTypeHandle[])
M01_L102:
       mov       [rbp-0F0],rax
       cmp       [r12],r12b
       mov       [rbp-0F8],r12
       mov       rcx,[rbp-0F8]
       test      rcx,rcx
       je        near ptr M01_L147
       mov       r12,[rcx+18]
M01_L103:
       mov       r15,[rbp-2F8]
       test      r15,r15
       je        near ptr M01_L110
       mov       rcx,offset MT_System.RuntimeMethodInfoStub
       cmp       [r15],rcx
       jne       near ptr M01_L148
       mov       rdx,[r15+50]
M01_L104:
       mov       rcx,[rbp-0F0]
       test      rcx,rcx
       je        near ptr M01_L149
       mov       rcx,[rcx+18]
       mov       [rbp-2F8],r15
M01_L105:
       mov       r8,[rbp-0E0]
       mov       r8,[r8+18]
       lea       r9,[rbp-0F8]
       mov       [rbp-278],r9
       mov       [rbp-270],r12
       lea       r9,[rbp-0F0]
       mov       [rbp-288],r9
       mov       [rbp-280],rcx
       lea       rcx,[rbp-0E0]
       mov       [rbp-298],rcx
       mov       [rbp-290],r8
       lea       rcx,[rbp-278]
       lea       r8,[rbp-288]
       lea       r9,[rbp-298]
       mov       rax,7FFA4A168068
       mov       [rbp-258],rax
       lea       rax,[M01_L106]
       mov       [rbp-248],rax
       lea       rax,[rbp-268]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9ABE060
       call      rax
M01_L106:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L107
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
M01_L107:
       mov       rcx,[rbp-260]
       mov       [rsi+8],rcx
       test      eax,eax
       setne     cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M01_L89
       mov       ebx,1
       jmp       short M01_L112
M01_L108:
       lea       rcx,[rbp-50]
       lea       rdx,[rbp-110]
       mov       r8d,edi
       call      qword ptr [7FFA4A6DD158]
       mov       eax,[rbp-110]
       mov       r10,[rbp-108]
       jmp       near ptr M01_L97
M01_L109:
       cmp       ecx,14000000
       je        near ptr M01_L100
       cmp       ecx,4000000
       je        near ptr M01_L100
       cmp       ecx,2000000
       jne       near ptr M01_L145
       mov       edx,edi
       jmp       near ptr M01_L101
M01_L110:
       xor       edx,edx
       jmp       near ptr M01_L104
M01_L111:
       xor       ebx,ebx
M01_L112:
       mov       r12,[rbp-2C0]
M01_L113:
       test      ebx,ebx
       je        near ptr M01_L151
M01_L114:
       mov       eax,1
M01_L115:
       jmp       near ptr M01_L65
M01_L116:
       mov       rdi,[rbp-2B0]
       inc       dword ptr [rdi+14]
       mov       rcx,[rdi+8]
       mov       edx,[rdi+10]
       cmp       [rcx+8],edx
       jbe       short M01_L117
       lea       r8d,[rdx+1]
       mov       [rdi+10],r8d
       movsxd    rdx,edx
       mov       r8,r12
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       jmp       near ptr M01_L66
M01_L117:
       mov       rcx,rdi
       mov       rdx,r12
       call      qword ptr [7FFA49F171C8]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       jmp       near ptr M01_L66
M01_L118:
       mov       esi,[rdi+14]
       lea       rcx,[rbx+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+30],rcx
       mov       [rbx+38],esi
       mov       [rbx+3C],ecx
       jmp       near ptr M01_L01
M01_L119:
       xor       ecx,ecx
       mov       [rsi+8],rcx
       mov       dword ptr [rsi+14],0FFFFFFFF
       mov       rcx,rbx
       call      qword ptr [7FFA4A5DEEE0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       xor       eax,eax
       mov       [rbx+28],rax
       mov       [rbx+30],rax
       mov       [rbx+38],rax
M01_L120:
       xor       edi,edi
       jmp       near ptr M01_L197
M01_L121:
       call      qword ptr [7FFA4A52E2F8]
       mov       ecx,259
       mov       rdx,7FFA4A254120
       call      qword ptr [7FFA49F1F210]
       mov       rsi,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A255B58
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA49F1D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       ecx,5
       mov       rdx,7FFA4A254120
       call      qword ptr [7FFA49F1F210]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA49F1D9C8]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA4A6DF0D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA4A6D7BD0]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L122:
       mov       edx,3C
       mov       rax,[rcx]
       mov       rax,[rax+88]
       call      qword ptr [rax+20]
       mov       r14,rax
       jmp       near ptr M01_L04
M01_L123:
       xor       ecx,ecx
       jmp       near ptr M01_L68
M01_L124:
       xor       ecx,ecx
       jmp       near ptr M01_L08
M01_L125:
       mov       rcx,r15
       call      qword ptr [7FFA49E5A400]
       mov       r15,rax
       mov       rax,2EF037727E0
       mov       [rbp-2C8],rax
       xor       eax,eax
       jmp       short M01_L129
M01_L126:
       mov       [rbp-2A8],rax
       mov       rdx,[r15+rax*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,rax
       mov       [rbp-2D0],rcx
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A1269A0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L128
       mov       rcx,[rbp-2D0]
       call      00007FFAA9B22C30
       test      eax,eax
       je        short M01_L127
       mov       rcx,[rbp-2D0]
       call      qword ptr [7FFA49E5A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L128
M01_L127:
       mov       rcx,[rbp-2D0]
       mov       [rbp-2C8],rcx
M01_L128:
       mov       rax,[rbp-2A8]
       inc       eax
M01_L129:
       cmp       [r15+8],eax
       jg        short M01_L126
       mov       rax,2EF037727E0
       cmp       [rbp-2C8],rax
       jne       short M01_L130
       mov       rax,[rbx]
       mov       rax,[rax+30]
       mov       rax,[rax]
       mov       rcx,[rax]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rcx,rax
       call      qword ptr [7FFA49E5A3F8]
       test      al,8
       je        short M01_L130
       mov       rcx,2EF03775890
       mov       r15,rcx
       mov       [rbp-2C8],r15
M01_L130:
       mov       rcx,[rbp-2C8]
       jmp       near ptr M01_L08
M01_L131:
       call      qword ptr [7FFA49F15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L69
M01_L132:
       call      qword ptr [7FFA4A127078]; System.RuntimeType.GetBaseType()
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L09
M01_L133:
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rax,offset MT_System.Attribute
       cmp       [rcx],rax
       je        near ptr M01_L10
       jmp       near ptr M01_L178
M01_L134:
       mov       rdx,r12
       mov       rcx,offset MT_System.Reflection.PropertyInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       jmp       near ptr M01_L74
M01_L135:
       xor       edx,edx
       jmp       near ptr M01_L83
M01_L136:
       mov       rdx,r12
       test      rdx,rdx
       je        near ptr M01_L89
M01_L137:
       mov       [rbp-300],rdx
       mov       rcx,rdx
       call      qword ptr [7FFA49E5A358]
       test      eax,eax
       je        short M01_L138
       mov       rcx,[rbp-300]
       call      qword ptr [7FFA49E5A3C8]; Precode of System.RuntimeType.GetGenericTypeDefinition()
       cmp       rax,[rbp-2E0]
       je        near ptr M01_L96
M01_L138:
       mov       rcx,[rbp-300]
       call      qword ptr [7FFA4A127078]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       test      r8,r8
       mov       rdx,r8
       jne       short M01_L137
       jmp       near ptr M01_L89
M01_L139:
       mov       ecx,1
       jmp       near ptr M01_L86
M01_L140:
       xor       ecx,ecx
       jmp       near ptr M01_L86
M01_L141:
       mov       ecx,2
       jmp       near ptr M01_L86
M01_L142:
       xor       ecx,ecx
       jmp       near ptr M01_L88
M01_L143:
       mov       r15,[rbp-0E0]
       mov       rcx,r12
       call      qword ptr [7FFA49E58318]
       mov       r8,rax
       mov       edx,edi
       mov       rcx,r15
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A15AC28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M01_L98
M01_L144:
       lea       r8,[rbp-128]
       mov       rcx,[rbp-50]
       mov       edx,edi
       call      00007FFAA9B254D0
       test      eax,eax
       jl        near ptr M01_L184
       mov       edx,[rbp-128]
       lea       r8,[rbp-130]
       mov       rcx,[rbp-50]
       call      00007FFAA9B254D0
       test      eax,eax
       jl        near ptr M01_L185
       mov       edx,[rbp-130]
       jmp       near ptr M01_L101
M01_L145:
       cmp       ecx,2A000000
       jne       near ptr M01_L101
       lea       rcx,[rbp-50]
       mov       edx,edi
       call      qword ptr [7FFA4A6DD170]
       mov       edx,eax
       mov       ecx,edx
       and       ecx,0FF000000
       cmp       ecx,6000000
       jne       near ptr M01_L101
       lea       rcx,[rbp-50]
       call      qword ptr [7FFA4A6DD170]
       mov       edx,eax
       jmp       near ptr M01_L101
M01_L146:
       xor       eax,eax
       jmp       near ptr M01_L102
M01_L147:
       xor       r12d,r12d
       jmp       near ptr M01_L103
M01_L148:
       mov       [rbp-2F8],r15
       mov       rcx,r15
       mov       r11,7FFA49E60CC0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       r15,[rbp-2F8]
       jmp       near ptr M01_L104
M01_L149:
       xor       ecx,ecx
       mov       [rbp-2F8],r15
       jmp       near ptr M01_L105
M01_L150:
       mov       rcx,r12
       mov       rdx,r15
       mov       r8d,1
       mov       rax,[r12]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       mov       ebx,eax
       jmp       near ptr M01_L113
M01_L151:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA4A6DCF60]
       cmp       byte ptr [rax+0D],0
       je        short M01_L153
       mov       rcx,r12
       call      qword ptr [7FFA4A6DCF78]
       mov       r15,rax
       mov       rcx,r12
       mov       rdx,r15
       call      qword ptr [7FFA4A6DCF90]
       mov       [rbp-2D8],rax
       test      rax,rax
       je        short M01_L153
M01_L152:
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,[rbp-2D8]
       xor       r8d,r8d
       mov       [rbp-2D8],rcx
       mov       rax,[rcx]
       mov       rax,[rax+48]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       near ptr M01_L114
       mov       rcx,[rbp-2D8]
       mov       rdx,r15
       call      qword ptr [7FFA4A6DCF90]
       mov       rdx,rax
       test      rdx,rdx
       mov       [rbp-2D8],rdx
       jne       short M01_L152
M01_L153:
       xor       eax,eax
       jmp       near ptr M01_L115
M01_L154:
       mov       rdx,r12
       mov       rcx,offset MT_System.Reflection.EventInfo
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rcx,[rbx]
       mov       rcx,[rcx+30]
       mov       rcx,[rcx]
       mov       rcx,[rcx]
       call      System.RuntimeTypeHandle.GetRuntimeTypeFromHandle(IntPtr)
       mov       rdx,rax
       mov       rcx,r12
       mov       r8d,1
       call      qword ptr [7FFA4A6DCF48]
       jmp       near ptr M01_L65
M01_L155:
       mov       eax,1
       jmp       near ptr M01_L12
M01_L156:
       xor       r8d,r8d
       mov       eax,r8d
       jmp       near ptr M01_L16
M01_L157:
       mov       rcx,r8
       mov       r8,[r8]
       mov       r8,[r8+40]
       call      qword ptr [r8+18]
       mov       r8d,eax
       jmp       near ptr M01_L15
M01_L158:
       mov       r11,[rbp-328]
       mov       rcx,r11
       mov       rdx,r8
       mov       r11,7FFA49E60CC8
       call      qword ptr [r11]
       jmp       near ptr M01_L17
M01_L159:
       mov       rdx,[r8]
       mov       rcx,[rbp-328]
       mov       r8,r15
       mov       r11,7FFA49E60CD0
       call      qword ptr [r11]
       test      eax,eax
       mov       r8,[rbp-330]
       je        near ptr M01_L19
       mov       r10d,[rbp-148]
       test      r10d,r10d
       jl        near ptr M01_L20
       mov       rcx,2EF03772A10
       cmp       r15,rcx
       jne       short M01_L162
M01_L160:
       test      dword ptr [r12+5C],2000
       je        short M01_L161
       jmp       near ptr M01_L56
M01_L161:
       cmp       dword ptr [rbp-13C],0
       jne       short M01_L163
M01_L162:
       mov       rcx,2EF03772A38
       cmp       r15,rcx
       mov       r15,[rbp-308]
       jne       near ptr M01_L20
M01_L163:
       mov       rcx,r12
       call      00007FFAA9AE6690
       test      al,80
       je        near ptr M01_L20
       jmp       near ptr M01_L56
M01_L164:
       xor       ecx,ecx
       jmp       near ptr M01_L30
M01_L165:
       mov       rdx,r12
       test      rdx,rdx
       je        near ptr M01_L36
M01_L166:
       mov       [rbp-350],rdx
       mov       rcx,rdx
       call      qword ptr [7FFA49E5A358]
       test      eax,eax
       je        short M01_L167
       mov       rcx,[rbp-350]
       call      qword ptr [7FFA49E5A3C8]; Precode of System.RuntimeType.GetGenericTypeDefinition()
       cmp       rax,[rbp-308]
       je        near ptr M01_L44
M01_L167:
       mov       rcx,[rbp-350]
       call      qword ptr [7FFA4A127078]; System.RuntimeType.GetBaseType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       test      r8,r8
       mov       rdx,r8
       jne       short M01_L166
       jmp       near ptr M01_L36
M01_L168:
       mov       ecx,1
       jmp       near ptr M01_L33
M01_L169:
       xor       ecx,ecx
       jmp       near ptr M01_L33
M01_L170:
       xor       ecx,ecx
       jmp       near ptr M01_L35
M01_L171:
       mov       r15,[rbp-1E0]
       mov       rcx,r12
       call      qword ptr [7FFA49E58318]
       mov       r8,rax
       mov       edx,edi
       mov       rcx,r15
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A15AC28]
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+58]
       call      qword ptr [rax+38]
       mov       r15,rax
       jmp       near ptr M01_L46
M01_L172:
       cmp       ecx,2A000000
       jne       near ptr M01_L49
       lea       rcx,[rbp-168]
       mov       edx,edi
       call      qword ptr [7FFA4A6DD170]
       mov       edx,eax
       mov       r8d,edx
       and       r8d,0FF000000
       cmp       r8d,6000000
       jne       near ptr M01_L49
       jmp       near ptr M01_L60
M01_L173:
       xor       eax,eax
       jmp       near ptr M01_L50
M01_L174:
       xor       r12d,r12d
       jmp       near ptr M01_L51
M01_L175:
       mov       [rbp-348],r15
       mov       rcx,r15
       mov       r11,7FFA49E60CE0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       r15,[rbp-348]
       jmp       near ptr M01_L52
M01_L176:
       xor       ecx,ecx
       mov       [rbp-348],r15
       jmp       near ptr M01_L53
M01_L177:
       mov       ecx,1A1
       mov       rdx,7FFA49E54000
       call      qword ptr [7FFA49F1F210]
       mov       rcx,rax
       call      qword ptr [7FFA4A6D6010]
       int       3
M01_L178:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6DCF30]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A21FF60]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L179:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L180:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L181:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L182:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L183:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L184:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L185:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L186:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L187:
       call      qword ptr [7FFA49F1F480]
       int       3
M01_L188:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L189:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L190:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M01_L191:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L192:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L193:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7870]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L194:
       mov       rcx,offset MT_System.BadImageFormatException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFA4A6D7648]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L195:
       call      qword ptr [7FFA49F1FC48]
       int       3
M01_L196:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L197:
       movzx     eax,dil
       add       rsp,348
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
       sub       rsp,38
       vzeroupper
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A66A0D0]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].System.IDisposable.Dispose()
       nop
       add       rsp,38
       ret
; Total bytes of code 7300
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<GetMembersWithAttributeNoCache>d__63`1[[System.__Canon, System.Private.CoreLib]].<>m__Finally1()
       mov       dword ptr [rcx+20],0FFFFFFFF
       ret
; Total bytes of code 8
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.HasBaseClass()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       esi,esi
       mov       rcx,1A5FA7106C0
       mov       rdi,offset MT_System.RuntimeType
M00_L00:
       cmp       [rcx],rdi
       jne       short M00_L03
       call      qword ptr [7FFA4A127078]; System.RuntimeType.GetBaseType()
M00_L01:
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L02
       mov       rax,1A5FA7027E0
       cmp       rcx,rax
       jne       short M00_L00
       mov       esi,1
M00_L02:
       mov       rax,[rbx+60]
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
; Total bytes of code 102
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
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,[rcx]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M01_L01:
       test      eax,eax
       jne       short M01_L05
       mov       rcx,rbx
       call      00007FFAA9B22C30
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[rbx+18]
       test      cl,2
       jne       short M01_L03
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L03
       mov       rax,[rcx+20]
       add       rax,10
       mov       rax,[rax]
       test      rax,rax
       je        near ptr M01_L12
M01_L02:
       jmp       short M01_L04
M01_L03:
       xor       eax,eax
M01_L04:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L05:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L06:
       mov       rcx,rbx
       call      qword ptr [7FFA49E5A400]
       mov       rsi,rax
       mov       rdi,1A5FA7027E0
       xor       ebp,ebp
       jmp       short M01_L10
M01_L07:
       mov       rdx,[rsi+rbp*8+10]
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r14,rax
       mov       rcx,r14
       cmp       [rcx],ecx
       call      qword ptr [7FFA4A1269A0]; System.RuntimeType.get_IsActualInterface()
       test      eax,eax
       jne       short M01_L09
       mov       rcx,r14
       call      00007FFAA9B22C30
       test      eax,eax
       je        short M01_L08
       mov       rcx,r14
       call      qword ptr [7FFA49E5A3F8]
       mov       ecx,eax
       and       ecx,4
       and       eax,8
       or        ecx,eax
       je        short M01_L09
M01_L08:
       mov       rdi,r14
M01_L09:
       inc       ebp
M01_L10:
       cmp       [rsi+8],ebp
       jg        short M01_L07
       mov       rcx,1A5FA7027E0
       cmp       rdi,rcx
       jne       short M01_L11
       mov       rcx,rbx
       call      qword ptr [7FFA49E5A3F8]
       mov       rcx,1A5FA705890
       test      al,8
       cmovne    rdi,rcx
M01_L11:
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L12:
       call      qword ptr [7FFA49F15C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       near ptr M01_L02
; Total bytes of code 298
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ImplementsInterface()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,offset MT_System.Type[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdx,2D9BEB33FA0
       mov       [rax+10],rdx
       mov       rdx,rax
       mov       rcx,2D9BEB3CB58
       call      qword ptr [7FFA49E8A5B8]; System.RuntimeType.MakeGenericType(System.Type[])
       mov       r8,rax
       mov       rcx,rbx
       mov       rdx,2D9BEB406C0
       call      qword ptr [7FFA4A5FE970]; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.ImplementsInterfaceNoCache(System.Type, System.Type)
       mov       rcx,[rbx+60]
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
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     ebx,al
       mov       r14,[rbp-0C8]
       cmp       dword ptr [7FFAA9E7F778],0
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
       mov       rax,7FFA49FB4DE8
       mov       [rbp-90],rax
       lea       rax,[M01_L06]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFAA9AEDC80
       call      rax
M01_L06:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M01_L07
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA4A6B77B0]
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
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     edi,al
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L39
M01_L16:
       cmp       edi,0F
       je        near ptr M01_L42
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     esi,al
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L40
M01_L17:
       cmp       esi,1B
       je        near ptr M01_L42
       mov       rcx,[rbp-0B8]
       mov       rcx,[rcx+18]
       mov       rax,7FFAA9B206C0
       call      rax
       movzx     ebx,al
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M01_L41
M01_L18:
       cmp       ebx,10
       je        near ptr M01_L42
       mov       rcx,2D9BEB31990
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
       call      00007FFA49F38C48
       mov       rax,[rbp-60]
       xor       ecx,ecx
       mov       [rbp-60],rcx
       jmp       short M01_L22
M01_L20:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA4A6B6D90]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA4A6B6DA8]
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
       call      qword ptr [7FFA4A4D5410]; System.Object.MemberwiseClone()
       mov       rdx,rax
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA4A6B77C8]
       jmp       short M01_L29
M01_L28:
       mov       rcx,[rbp-0C0]
       mov       rdx,rbx
       call      qword ptr [7FFA4A4D5068]; System.RuntimeType.SanityCheckGenericArguments(System.RuntimeType[], System.RuntimeType[])
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FFA4A4D5080]; System.RuntimeTypeHandle.Instantiate(System.Type[])
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
       mov       rdx,7FFA49E84000
       call      qword ptr [7FFA49F4F210]
       mov       rcx,rax
       call      qword ptr [7FFA4A6B57A0]
       int       3
M01_L31:
       xor       ecx,ecx
       jmp       near ptr M01_L00
M01_L32:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA4A6B7738]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFA4A6B7750]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA4A335DB8]
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
       call      qword ptr [7FFA4A6B6D90]
       mov       r8,rax
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA4A6B6DA8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L38:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA4A6B7768]
       mov       rsi,rax
       mov       ecx,9F9
       mov       rdx,7FFA49E84000
       call      qword ptr [7FFA49F4F210]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA4A335E60]
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
       call      qword ptr [7FFA4A6B7780]
       mov       rcx,rax
       mov       rdx,[rbp-0B8]
       call      qword ptr [7FFA4A6B7750]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA4A24FF60]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L43:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       call      qword ptr [7FFA4A6B7798]
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
       call      qword ptr [7FFA4A6B77E0]
       call      CORINFO_HELP_RETHROW
       int       3
       sub       rsp,28
       vzeroupper
       mov       r8,rcx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-0C0]
       call      qword ptr [7FFA4A6B77E0]
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
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,offset MT_DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c__DisplayClass65_0
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       test      rbx,rbx
       je        near ptr M02_L25
       mov       rcx,[rdi+8]
       test      rcx,rcx
       je        near ptr M02_L27
       mov       rsi,offset MT_System.RuntimeType
       cmp       [rcx],rsi
       je        short M02_L00
       mov       rax,[rcx]
       mov       rax,[rax+70]
       call      qword ptr [rax+18]
       test      al,20
       jne       short M02_L02
       jmp       near ptr M02_L27
M02_L00:
       mov       rax,[rcx+18]
       test      al,2
       jne       near ptr M02_L26
       mov       eax,[rax]
       and       eax,0F0000
       cmp       eax,0C0000
       sete      al
       movzx     eax,al
M02_L01:
       test      eax,eax
       je        near ptr M02_L27
M02_L02:
       cmp       [rbx],rsi
       jne       near ptr M02_L32
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M02_L28
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M02_L28
M02_L03:
       cmp       [r14],r14b
       lea       rbx,[r14+58]
       mov       rcx,[rbx]
       test      rcx,rcx
       je        near ptr M02_L29
M02_L04:
       cmp       byte ptr [rcx+18],0
       je        near ptr M02_L30
       mov       rbx,[rcx+8]
M02_L05:
       test      rbx,rbx
       je        near ptr M02_L21
       lea       r14,[rbx+10]
       mov       ebx,[rbx+8]
M02_L06:
       test      ebx,ebx
       jne       near ptr M02_L22
       mov       rdx,29929C00348
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
       mov       r11,7FFA49E90AE8
       call      qword ptr [r11]
       mov       [rbp-38],rax
M02_L08:
       mov       rcx,[rbp-38]
       mov       r11,7FFA49E90AF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L09
       mov       rcx,[rbp-38]
       mov       r11,7FFA49E90AF8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,rdi
       mov       rax,offset DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark+<>c__DisplayClass65_0.<ImplementsInterfaceNoCache>b__0(System.Type)
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
       mov       r11,7FFA49E90B00
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
       jbe       short M02_L23
       mov       rdx,r14
       call      qword ptr [7FFA4A6B4108]
       jmp       short M02_L24
M02_L23:
       mov       rdx,r14
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       near ptr M02_L31
M02_L24:
       mov       rcx,r15
       jmp       near ptr M02_L07
M02_L25:
       call      qword ptr [7FFA4A55DDE8]
       mov       ecx,259
       mov       rdx,7FFA4A284120
       call      qword ptr [7FFA49F4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFA4A285B58
       call      qword ptr [7FFA49F4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,5
       mov       rdx,7FFA4A284120
       call      qword ptr [7FFA49F4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA49F4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFA4A6BCAE0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFA4A6B6DA8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L26:
       xor       eax,eax
       jmp       near ptr M02_L01
M02_L27:
       xor       eax,eax
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L28:
       mov       rcx,rbx
       call      qword ptr [7FFA4A1556C8]; System.RuntimeType.InitializeCache()
       mov       r14,rax
       jmp       near ptr M02_L03
M02_L29:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       lea       rcx,[r15+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       rdx,r15
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,r15
       jmp       near ptr M02_L04
M02_L30:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FFA4A156910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rbx,rax
       jmp       near ptr M02_L05
M02_L31:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M02_L24
M02_L32:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+98]
       call      qword ptr [rax+38]
       mov       rcx,rax
       jmp       near ptr M02_L07
M02_L33:
       mov       ecx,11
       call      qword ptr [7FFA49F4F930]
       int       3
M02_L34:
       call      qword ptr [7FFA49F4F480]
       int       3
M02_L35:
       sub       rsp,28
       cmp       qword ptr [rbp-38],0
       je        short M02_L36
       mov       rcx,[rbp-38]
       mov       r11,7FFA49E90B00
       call      qword ptr [r11]
M02_L36:
       nop
       add       rsp,28
       ret
; Total bytes of code 1017
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.BuiltInTypes()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFA4A60EFB8]; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
       mov       [rsp+28],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper.get_BuiltInTypes()
; 			if (_builtInTypes == null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ComputeBuiltInTypes();
; 				^^^^^^^^^^^^^^^^^^^^^^
; 			return _builtInTypes == null
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				? new List<Type>().AsReadOnly()
; 				                               
; 				: _builtInTypes.ToList().AsReadOnly();
; 				                                      
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
       mov       rbx,156C9000108
       cmp       qword ptr [rbx],0
       je        near ptr M01_L07
M01_L00:
       mov       rbx,[rbx]
       test      rbx,rbx
       je        near ptr M01_L13
       mov       rdx,rbx
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      qword ptr [7FFA49F46850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       near ptr M01_L08
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rbx]
       mov       r14,offset MT_System.Collections.Generic.HashSet<System.Type>
       cmp       rdi,r14
       jne       near ptr M01_L09
       mov       r15d,[rbx+28]
       sub       r15d,[rbx+30]
M01_L01:
       test      r15d,r15d
       je        near ptr M01_L10
       movsxd    rdx,r15d
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       lea       rcx,[rsi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rsi+8]
       cmp       rdi,r14
       jne       near ptr M01_L12
       xor       edi,edi
       mov       r14d,[rbx+28]
       sub       r14d,[rbx+30]
       js        near ptr M01_L11
       mov       r8d,[r13+8]
       cmp       [r13+8],r14d
       jl        near ptr M01_L06
       mov       r12,[rbx+10]
       xor       eax,eax
       cmp       dword ptr [rbx+28],0
       jle       short M01_L04
M01_L02:
       test      r14d,r14d
       je        short M01_L04
       cmp       eax,[r12+8]
       jae       near ptr M01_L14
       mov       [rbp-48],rax
       mov       r8,rax
       shl       r8,4
       lea       r8,[r12+r8+10]
       cmp       dword ptr [r8+0C],0FFFFFFFF
       jl        short M01_L03
       lea       edx,[rdi+1]
       mov       [rbp-3C],edx
       mov       r8,[r8]
       movsxd    rdx,edi
       mov       rcx,r13
       call      System.Runtime.CompilerServices.CastHelpers.StelemRef(System.Object[], IntPtr, System.Object)
       dec       r14d
       mov       edi,[rbp-3C]
M01_L03:
       mov       rax,[rbp-48]
       inc       eax
       mov       rcx,rax
       cmp       ecx,[rbx+28]
       mov       rax,rcx
       jl        short M01_L02
M01_L04:
       mov       [rsi+10],r15d
M01_L05:
       cmp       [rsi],sil
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
M01_L06:
       mov       ecx,6
       call      qword ptr [7FFA4AC9E1C0]
       int       3
M01_L07:
       call      qword ptr [7FFA4A60EFE8]; DotNetTips.Spargine.Core.TypeHelper.ComputeBuiltInTypes()
       jmp       near ptr M01_L00
M01_L08:
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+38]
       mov       rsi,rax
       jmp       short M01_L05
M01_L09:
       mov       rcx,rbx
       mov       r11,7FFA49E90C30
       call      qword ptr [r11]
       mov       r15d,eax
       jmp       near ptr M01_L01
M01_L10:
       mov       rcx,156C4801B00
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L05
M01_L11:
       mov       ecx,28F
       mov       rdx,7FFA49E84000
       call      qword ptr [7FFA4A1C7738]
       mov       rdx,rax
       mov       ecx,r14d
       call      qword ptr [7FFA4AC9C690]
       int       3
M01_L12:
       mov       rcx,rbx
       mov       rdx,r13
       mov       r11,7FFA49E90C38
       xor       r8d,r8d
       call      qword ptr [r11]
       jmp       near ptr M01_L04
M01_L13:
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA4A346430]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.Type>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFA4A3E5B48]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IList`1<System.__Canon>)
       mov       rax,rsi
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
M01_L14:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 598
```

## .NET 10.0.1 (10.0.1, 10.0.125.57005), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.TypeHelperBenchmark.GetImplementedInterfaces()
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
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,offset MT_System.Collections.Generic.List<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,23146F306C0
       mov       [rax+8],rcx
       mov       rcx,rax
       call      qword ptr [7FFA4A1461C0]; System.Object.GetType()
       cmp       qword ptr [rax+10],0
       je        short M00_L00
       mov       rcx,[rax+10]
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       near ptr M00_L11
M00_L00:
       mov       rcx,rax
       call      qword ptr [7FFA4A1456C8]; System.RuntimeType.InitializeCache()
       mov       rdi,rax
M00_L01:
       cmp       [rdi],dil
       lea       rsi,[rdi+58]
       mov       rcx,[rsi]
       test      rcx,rcx
       je        near ptr M00_L15
M00_L02:
       cmp       byte ptr [rcx+18],0
       je        near ptr M00_L16
       mov       rsi,[rcx+8]
M00_L03:
       test      rsi,rsi
       je        near ptr M00_L12
       lea       rdi,[rsi+10]
       mov       esi,[rsi+8]
M00_L04:
       test      esi,esi
       jne       near ptr M00_L13
       mov       rdx,1F0B2000348
       mov       rbp,[rdx]
M00_L05:
       mov       rcx,1F0B2002130
       mov       rsi,[rcx]
       test      rsi,rsi
       je        near ptr M00_L19
M00_L06:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       near ptr M00_L20
       mov       rdi,rbp
       test      rdi,rdi
       je        near ptr M00_L24
       mov       r14,rbp
       test      r14,r14
       je        near ptr M00_L22
       cmp       dword ptr [r14+8],0
       je        near ptr M00_L21
       mov       rcx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
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
M00_L07:
       mov       rdx,r15
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L27
       mov       rdx,offset MT_System.Linq.Enumerable+ArraySelectIterator<System.Type, System.String>
       cmp       [rsi],rdx
       jne       near ptr M00_L26
       mov       r15,[rsi+18]
       mov       edx,[r15+8]
       mov       rcx,offset MT_System.String[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       lea       rbp,[r15+10]
       mov       r14d,[r15+8]
       lea       r15,[rdi+10]
       mov       r13d,[rdi+8]
       mov       rsi,[rsi+20]
       xor       r12d,r12d
       test      r13d,r13d
       jle       short M00_L09
       cmp       r13d,r14d
       jg        near ptr M00_L25
       xor       r12d,r12d
M00_L08:
       lea       rcx,[r15+r12]
       mov       [rsp+30],rcx
       mov       rdx,[r12+rbp]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rsp+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       add       r12,8
       dec       r13d
       jne       short M00_L08
M00_L09:
       test      rdi,rdi
       je        near ptr M00_L29
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L30
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L10:
       mov       [rsp+28],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L11:
       mov       rdi,rsi
       jmp       near ptr M00_L01
M00_L12:
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M00_L04
M00_L13:
       mov       edx,esi
       mov       rcx,offset MT_System.Type[]
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       r8d,esi
       shl       r8,3
       cmp       r8,4000
       ja        short M00_L18
       mov       rdx,rdi
       call      00007FFAA9B15D60
       cmp       dword ptr [7FFAA9E7F778],0
       jne       short M00_L17
M00_L14:
       jmp       near ptr M00_L05
M00_L15:
       mov       rcx,offset MT_System.RuntimeType+RuntimeTypeCache+MemberInfoCache<System.RuntimeType>
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rsi
       mov       rdx,rbp
       xor       r8d,r8d
       call      00007FFAA9B1FBA0
       mov       rcx,rax
       test      rcx,rcx
       cmove     rcx,rbp
       jmp       near ptr M00_L02
M00_L16:
       xor       edx,edx
       xor       r8d,r8d
       mov       r9d,5
       call      qword ptr [7FFA4A146910]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Populate(System.String, MemberListType, CacheType)
       mov       rsi,rax
       jmp       near ptr M00_L03
M00_L17:
       call      CORINFO_HELP_POLL_GC
       jmp       short M00_L14
M00_L18:
       mov       rdx,rdi
       call      qword ptr [7FFA4A54DC98]
       jmp       short M00_L14
M00_L19:
       mov       rcx,offset MT_System.Func<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F0B20020F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       mov       r8,offset DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__32_0(System.Type)
       call      qword ptr [7FFA49F36BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F0B2002130
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,rdi
       mov       rdx,offset MT_System.Linq.Enumerable+Iterator<System.Type>
       mov       r8,7FFA4A74C768
       call      qword ptr [7FFA49F35920]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      rax
       mov       r15,rax
       jmp       near ptr M00_L07
M00_L21:
       mov       rcx,offset MT_System.Array+EmptyArray<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,1F0B20021D8
       mov       r15,[rdx]
       jmp       near ptr M00_L07
M00_L22:
       mov       rdx,rbp
       mov       rcx,offset MT_System.Collections.Generic.List<System.Type>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M00_L23
       mov       rcx,offset MT_System.Linq.Enumerable+ListSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,r15
       mov       r8,rsi
       call      qword ptr [7FFA4A6AC1B0]
       mov       r15,rdi
       jmp       near ptr M00_L07
M00_L23:
       mov       rcx,offset MT_System.Linq.Enumerable+IListSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rdi
       mov       r8,rsi
       call      qword ptr [7FFA4A6AC1C8]
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Linq.Enumerable+IEnumerableSelectIterator<System.Type, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,r15
       mov       rdx,rbp
       mov       r8,rsi
       call      qword ptr [7FFA4A6AC1E0]
       jmp       near ptr M00_L07
M00_L25:
       mov       edx,r12d
       lea       rcx,[r15+rdx*8]
       mov       [rsp+30],rcx
       cmp       r12d,r14d
       jae       near ptr M00_L31
       mov       edx,r12d
       mov       rdx,[rbp+rdx*8]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
       mov       rcx,[rsp+30]
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       inc       r12d
       cmp       r12d,r13d
       jl        short M00_L25
       jmp       near ptr M00_L09
M00_L26:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L27:
       mov       rdx,r15
       mov       rcx,offset MT_System.Collections.Generic.ICollection<System.String>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L28
       mov       rdx,rax
       mov       rcx,7FFA4A5E6470
       call      qword ptr [7FFA4A327A68]; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L28:
       mov       rdx,r15
       mov       rcx,7FFA4A74CEA8
       call      qword ptr [7FFA4A6A6028]
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFA49F3FD38]
       int       3
M00_L30:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<System.String>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F0B20021E0
       mov       rsi,[rcx]
       jmp       near ptr M00_L10
M00_L31:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1250
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
       je        short M01_L01
M01_L00:
       add       rsp,20
       pop       rbx
       ret
M01_L01:
       call      qword ptr [7FFA49F35C80]; System.RuntimeTypeHandle.GetRuntimeTypeFromHandleSlow(IntPtr)
       jmp       short M01_L00
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
       call      00007FFAA9B21870
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
       mov       rax,7FFA4A17C5A0
       mov       [rbp-78],rax
       lea       rax,[M02_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFAA9AB2C30
       call      rax
M02_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFAA9E7F778],0
       je        short M02_L04
       call      qword ptr [7FFAA9E6D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFAA9B304E0
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
       call      qword ptr [7FFA4A6AC2B8]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M02_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFA4A6A6F88]
       jmp       near ptr M02_L00
M02_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M02_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFA4A145710]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
       mov       rax,0F6178E9A0C2C
       mov       [rbp],rax
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r14d,r9d
       test      rbx,rbx
       je        short M04_L00
       cmp       dword ptr [rbx+8],0
       jne       short M04_L03
M04_L00:
       xor       r8d,r8d
       mov       [rbp+8],r8
       mov       [rbp+10],r8d
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rcx,rsi
       mov       r9d,edi
       mov       rdx,23146F20008
       call      qword ptr [7FFA4A146928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
M04_L01:
       lea       rdx,[rbp+18]
       mov       rcx,rsi
       mov       r8,rbx
       mov       r9d,edi
       call      qword ptr [7FFA4A146B50]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].Insert(System.__Canon[] ByRef, System.String, MemberListType)
       mov       rax,[rbp+18]
       mov       r8,0F6178E9A0C2C
       cmp       [rbp],r8
       je        short M04_L02
       call      CORINFO_HELP_FAIL_FAST
M04_L02:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M04_L03:
       cmp       r14d,1
       jne       short M04_L04
       cmp       word ptr [rbx+0C],2E
       je        short M04_L04
       cmp       word ptr [rbx+0C],2A
       jne       short M04_L00
M04_L04:
       mov       rcx,1F0B2000108
       mov       rcx,[rcx]
       mov       rdx,rbx
       call      qword ptr [7FFA4A075D10]; Precode of System.Text.UTF8Encoding.GetByteCount(System.String)
       cmp       eax,400
       jbe       short M04_L05
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Byte[]
       call      CORINFO_HELP_NEWARR_1_VC
       lea       r8,[rax+10]
       mov       eax,[rax+8]
       jmp       short M04_L07
M04_L05:
       mov       r8d,eax
       test      r8,r8
       je        short M04_L07
       mov       rdx,r8
       add       rdx,0F
       and       rdx,0FFFFFFFFFFFFFFF0
       add       rsp,30
       neg       rdx
       add       rdx,rsp
       jb        short M04_L06
       xor       edx,edx
M04_L06:
       test      [rsp],esp
       sub       rsp,1000
       cmp       rsp,rdx
       jae       short M04_L06
       mov       rsp,rdx
       test      [rsp],esp
       sub       rsp,30
       lea       r8,[rsp+30]
M04_L07:
       mov       [rbp+8],r8
       mov       [rbp+10],eax
       mov       [rsp+20],r14d
       lea       r8,[rbp+8]
       mov       rdx,rbx
       mov       rcx,rsi
       mov       r9d,edi
       call      qword ptr [7FFA4A146928]; System.RuntimeType+RuntimeTypeCache+MemberInfoCache`1[[System.__Canon, System.Private.CoreLib]].GetListByName(System.String, System.Span`1<Byte>, MemberListType, CacheType)
       mov       [rbp+18],rax
       jmp       near ptr M04_L01
; Total bytes of code 348
```
```assembly
; DotNetTips.Spargine.Core.TypeHelper+<>c.<GetImplementedInterfaces>b__32_0(System.Type)
; 		return Array.AsReadOnly(input.GetType().GetInterfaces().Select(p => p.Name).ToArray());
; 		                                                                    ^^^^^^
       push      rbx
       sub       rsp,20
       mov       rcx,rdx
       mov       rax,offset MT_System.RuntimeType
       cmp       [rcx],rax
       jne       short M05_L04
       cmp       qword ptr [rcx+10],0
       je        short M05_L00
       mov       rax,[rcx+10]
       mov       rbx,[rax]
       test      rbx,rbx
       jne       short M05_L02
M05_L00:
       call      qword ptr [7FFA4A1456C8]; System.RuntimeType.InitializeCache()
       mov       rcx,rax
M05_L01:
       mov       rax,[rcx+18]
       test      rax,rax
       je        short M05_L03
       add       rsp,20
       pop       rbx
       ret
M05_L02:
       mov       rcx,rbx
       jmp       short M05_L01
M05_L03:
       lea       rdx,[rcx+18]
       xor       r8d,r8d
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFA4A14CBD0]; System.RuntimeType+RuntimeTypeCache.ConstructName(System.String ByRef, System.TypeNameFormatFlags)
M05_L04:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax+30]
; Total bytes of code 105
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M06_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L00:
       call      qword ptr [7FFA4A6A6BF8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointer(System.Object, IntPtr, IntPtr)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       mov       rcx,[rdi]
       mov       eax,ebx
       rol       eax,5
       add       eax,ecx
       mov       edx,esi
       ror       edx,5
       add       eax,edx
       mov       rdx,1F0B2000B60
       mov       rdx,[rdx]
       mov       rdx,[rdx+8]
       movsxd    r8,eax
       mov       r10,9E3779B97F4A7C15
       imul      r8,r10
       movzx     r10d,byte ptr [rdx+10]
       shrx      r8,r8,r10
       xor       r10d,r10d
M07_L00:
       lea       r9d,[r8+1]
       movsxd    r9,r9d
       imul      r9,30
       lea       r9,[rdx+r9+10]
       mov       r11d,[r9]
       mov       ebp,[r9+8]
       mov       r14,[r9+10]
       mov       r15,[r9+18]
       mov       r13,[r9+20]
       cmp       eax,ebp
       jne       short M07_L01
       mov       rbp,rcx
       sub       rbp,r14
       mov       r14,rbx
       sub       r14,r15
       or        rbp,r14
       mov       r14,rsi
       sub       r14,r13
       or        rbp,r14
       jne       short M07_L01
       mov       rbp,[r9+28]
       and       r11d,0FFFFFFFE
       cmp       r11d,[r9]
       jne       short M07_L02
       mov       rcx,7FFA4A6FFA00
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rax,rbp
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M07_L01:
       test      r11d,r11d
       je        short M07_L02
       inc       r10d
       add       r8d,r10d
       mov       r9d,[rdx+8]
       add       r9d,0FFFFFFFE
       and       r8d,r9d
       cmp       r10d,8
       jl        near ptr M07_L00
M07_L02:
       mov       rcx,7FFA4A6FFA04
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,rdi
       mov       rdx,rbx
       mov       r8,rsi
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFA4A23C7E0]; System.Runtime.CompilerServices.VirtualDispatchHelpers.VirtualFunctionPointerSlow(System.Object, IntPtr, IntPtr)
; Total bytes of code 274
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M08_L00
       ret
M08_L00:
       jmp       qword ptr [7FFA49F35C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M09_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M09_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M09_L01
       cmp       [r10],rcx
       je        short M09_L06
M09_L00:
       cmp       [r10+8],rcx
       je        short M09_L06
       cmp       [r10+10],rcx
       je        short M09_L06
       cmp       [r10+18],rcx
       je        short M09_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M09_L04
       test      r8,r8
       je        short M09_L03
M09_L01:
       cmp       [r10],rcx
       je        short M09_L06
M09_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M09_L03
       cmp       [r10],rcx
       je        short M09_L06
       jmp       short M09_L02
M09_L03:
       test      dword ptr [rax],500C0000
       je        short M09_L05
       jmp       qword ptr [7FFA4A32D4E8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M09_L04:
       cmp       [r10],rcx
       je        short M09_L06
       jmp       short M09_L00
M09_L05:
       xor       edx,edx
M09_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Linq.Enumerable.ICollectionToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,[rbx+18]
       mov       rdi,[rcx+28]
       test      rdi,rdi
       je        near ptr M10_L03
M10_L00:
       mov       rcx,rsi
       mov       rdx,7FFA4A6E5F78
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       r11,rdi
       call      qword ptr [rdi]
       mov       edi,eax
       test      edi,edi
       je        near ptr M10_L06
       mov       rcx,7FFA4A6E6080
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],38
       jle       short M10_L04
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M10_L04
M10_L01:
       movsxd    rdx,edi
       call      CORINFO_HELP_NEWARR_1_PTR
       mov       rdi,rax
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],40
       jle       short M10_L05
       mov       rbp,[rcx+40]
       test      rbp,rbp
       je        short M10_L05
M10_L02:
       mov       rcx,rsi
       mov       rdx,7FFA4A6E6088
       call      CORINFO_HELP_CLASSPROFILE32
       mov       rcx,rsi
       mov       r11,rbp
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [rbp]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L03:
       mov       rcx,rbx
       mov       rdx,7FFA4A6CCAA0
       call      qword ptr [7FFA49F3F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdi,rax
       jmp       near ptr M10_L00
M10_L04:
       mov       rcx,rbx
       mov       rdx,7FFA4A6CCC88
       call      qword ptr [7FFA49F3F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L01
M10_L05:
       mov       rcx,rbx
       mov       rdx,7FFA4A6CCC90
       call      qword ptr [7FFA49F3F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rbp,rax
       jmp       short M10_L02
M10_L06:
       mov       rcx,7FFA4A6E6190
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx+18]
       cmp       qword ptr [rcx+8],30
       jle       short M10_L09
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        short M10_L09
M10_L07:
       mov       rdx,[rcx+18]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M10_L10
M10_L08:
       mov       rcx,rdx
       call      qword ptr [7FFA49F35728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rax]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M10_L09:
       mov       rcx,rbx
       mov       rdx,7FFA4A6CCC68
       call      qword ptr [7FFA49F3F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rcx,rax
       jmp       short M10_L07
M10_L10:
       mov       rdx,7FFA4A6CCCA8
       call      qword ptr [7FFA49F3F630]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       rdx,rax
       jmp       short M10_L08
; Total bytes of code 372
```

