## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,213F5400AD8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L43
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L45
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L41
       test      byte ptr [7FFDC2C5A128],1
       je        near ptr M00_L44
M00_L01:
       mov       rcx,213F5400C28
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L36
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L20
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L37
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L38
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L35
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L22
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L22
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,213DF400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,213DF400170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L23
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L27
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L24
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L32
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,213F5400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L28
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L28
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L31
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L28
       mov       esi,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L28
       cmp       r11d,ebx
       je        short M00_L17
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L28
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       ebx,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       je        short M00_L19
M00_L16:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L39
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L17:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L18
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L28
M00_L18:
       mov       ebx,ecx
       jmp       short M00_L14
M00_L19:
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L20:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L40
M00_L21:
       mov       rcx,r12
       mov       r11,7FFDC2380F18
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L35
M00_L22:
       mov       ecx,2
       call      qword ptr [7FFDC2CA47F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L23:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L24:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L25
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC27B5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L26
M00_L25:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC27B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L26:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L27:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L28:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L29]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L29:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L30
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L30:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L31:
       mov       r8,213F5400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2C0CBA0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L28
       jmp       near ptr M00_L13
M00_L32:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L33]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L33:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L34
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L34:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L35:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L16
M00_L36:
       mov       rcx,r12
       mov       r11,7FFDC2380F10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L21
       jmp       near ptr M00_L46
M00_L37:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2CA78D0]
       int       3
M00_L38:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L39:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L40:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L41:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,213F5400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2436BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,213F5400AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L44:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,rdi
       mov       r11,7FFDC2380F08
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L46:
       mov       rcx,r12
       mov       r11,7FFDC2380F20
       call      qword ptr [r11]
       jmp       near ptr M00_L40
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L47
       mov       rcx,rax
       mov       r11,7FFDC2380F20
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1782
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,213DF400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,213DF400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,213F5400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2CA47F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2CA4810]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,213F5400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2C0CBA0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE49C0]
       vbroadcastsd ymm3,qword ptr [7FFDC2BE49E0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE49C0]
       vbroadcastsd ymm2,qword ptr [7FFDC2BE49E0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BE49C0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BE49E0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2CA4A68]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2435C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,1BE6C000AD8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L41
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L42
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L40
       test      byte ptr [7FFDC2C4C090],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1BE6C000C28
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L19
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L21
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1BE56000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1BE56000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1BE6C000AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L27
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L27
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       ebx,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L27
       cmp       r11d,esi
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       r13d,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L18
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L14
M00_L18:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FFDC2370F18
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FFDC2C94918]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L23:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L24
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC27A5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC27A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L25:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L29
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,1BE6C000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2BFCB28]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2370F10
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2C979A8]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1BE6C000AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1BE6C000AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFDC242F930]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC2370F08
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2370F20
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2370F20
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1787
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1BE56000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1BE56000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1BE6C000AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C94918]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C94930]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1BE6C000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BFCB28]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD47E0]
       vbroadcastsd ymm3,qword ptr [7FFDC2BD4800]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD47E0]
       vbroadcastsd ymm2,qword ptr [7FFDC2BD4800]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BD47E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BD4800]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2C94B70]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2425C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,1AA4C400AD8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L41
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L42
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L40
       test      byte ptr [7FFDC2C39A80],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1AA4C400C28
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L19
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L21
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1AA36400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1AA36400170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1AA4C400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L27
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L27
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       esi,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L27
       cmp       r11d,ebx
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       ebx,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       short M00_L18
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       ebx,ecx
       jmp       short M00_L14
M00_L18:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FFDC2361090
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FFDC2C84900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FFDC241D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L23:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L24
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC2795BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC27958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L25:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L29
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,1AA4C400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2BECB10]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2361088
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2C879C0]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1AA4C400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2416BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1AA4C400AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC2361080
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2361098
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2361098
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1782
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1AA36400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1AA36400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1AA4C400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C84900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC241D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C84918]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1AA4C400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BECB10]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BC5B20]
       vbroadcastsd ymm3,qword ptr [7FFDC2BC5B40]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BC5B20]
       vbroadcastsd ymm2,qword ptr [7FFDC2BC5B40]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BC5B20]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BC5B40]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2C84B58]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2415C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,1C9D9800AD8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L41
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L42
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L40
       test      byte ptr [7FFDC2C5A128],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1C9D9800C28
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L19
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L21
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1C9C3800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1C9C3800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1C9D9800AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L27
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L27
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       ebx,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L27
       cmp       r11d,esi
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       r13d,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L18
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L14
M00_L18:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FFDC2380F10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FFDC2CA47C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L23:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L24
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC27B5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC27B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L25:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L29
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,1C9D9800AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2C0CB40]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2380F08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2CA7960]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1C9D9800AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2436BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C9D9800AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC2380F00
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2380F18
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2380F18
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1787
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1C9C3800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1C9C3800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1C9D9800AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2CA47C8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2CA47E0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1C9D9800AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2C0CB40]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE3AC0]
       vbroadcastsd ymm3,qword ptr [7FFDC2BE3AE0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE3AC0]
       vbroadcastsd ymm2,qword ptr [7FFDC2BE3AE0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BE3AC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BE3AE0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2CA4B10]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2435C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,25E35400AD8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L40
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L41
       test      byte ptr [7FFDC2C29A80],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,25E35400C28
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L19
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L21
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,25E1F400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,25E1F400170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,25E35400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L27
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L27
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       ebx,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L27
       cmp       r11d,esi
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       r13d,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L18
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L14
M00_L18:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FFDC2350F10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FFDC2C74900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L23:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L24
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC2785BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC27858D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L25:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L29
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,25E35400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2BDCB10]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2350F08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2C77A50]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L41:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,25E35400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2406BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25E35400AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC2350F00
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2350F18
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2350F18
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1787
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,25E1F400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,25E1F400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,25E35400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C74900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C74918]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27858D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,25E35400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BDCB10]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BB2FE0]
       vbroadcastsd ymm3,qword ptr [7FFDC2BB3000]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BB2FE0]
       vbroadcastsd ymm2,qword ptr [7FFDC2BB3000]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BB2FE0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BB3000]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2C74B70]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2405C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,26F10400AD8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L40
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L41
       test      byte ptr [7FFDC2C4A898],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,26F10400C28
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L19
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L21
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L21
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,26EFA400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,26EFA400170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,26F10400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L27
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L27
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       ebx,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L27
       cmp       r11d,esi
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       r13d,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L18
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L14
M00_L18:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FFDC2370F10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FFDC2C94948]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L23:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L24
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC27A5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC27A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L25:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L29
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,26F10400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2BFCC18]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L18
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2370F08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2C97A98]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       ecx,11
       call      qword ptr [7FFDC242F930]
       int       3
M00_L41:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,26F10400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,26F10400AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC2370F00
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2370F18
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2370F18
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1787
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,26EFA400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,26EFA400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,26F10400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C94948]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C94960]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,26F10400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BFCC18]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD3060]
       vbroadcastsd ymm3,qword ptr [7FFDC2BD3080]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD3060]
       vbroadcastsd ymm2,qword ptr [7FFDC2BD3080]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BD3060]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BD3080]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2C94BA0]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2425C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,1B476000B08
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L40
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L41
       test      byte ptr [7FFDC2C7D580],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1B476000C68
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L22
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L24
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L24
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1B460000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1B460000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L25
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L29
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L26
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1B476000888
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L18
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L18
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L18
       mov       ebx,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rbx],0
       jne       short M00_L18
       cmp       r11d,esi
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       short M00_L18
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       r13d,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       near ptr M00_L21
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       short M00_L18
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L14
M00_L18:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L19]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L19:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L20
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L20:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L21:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L22:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L23:
       mov       rcx,r12
       mov       r11,7FFDC2351308
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L24:
       mov       ecx,2
       call      qword ptr [7FFDC2BDC120]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L25:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L26:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L27
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC2785BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L28
M00_L27:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC2785908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L28:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L30:
       mov       r8,1B476000888
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2C847E0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L18
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L21
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2351300
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L23
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2C87B10]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L41:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B476000AF8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2406BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1B476000B08
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC23512F8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2351310
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2351310
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1791
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1B460000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1B460000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rdi,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rdi
       mov       r15,rdi
       lea       rcx,[rbp-3C]
       mov       [rbp-60],rcx
       lea       r13,[rbp-3C]
       mov       rcx,1B476000888
       mov       rcx,[rcx]
       add       rcx,8
       lea       rdx,[rbp-3C]
       lea       r8,[rbp-3C]
       add       r8,2
       lea       rax,[rbp-3C]
       cmp       rax,r8
       je        short M01_L04
M01_L03:
       movzx     eax,word ptr [rdx]
       cmp       [rcx],cl
       lea       r10,[rcx+20]
       cmp       eax,100
       jge       near ptr M01_L19
       cmp       [r10],r10b
       mov       r9d,eax
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,eax
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,r8
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       edi,ebx
       sub       edi,1
       inc       edi
       xor       r12d,r12d
       test      edi,edi
       je        near ptr M01_L08
M01_L05:
       xor       eax,eax
       mov       r10d,r12d
M01_L06:
       mov       [rbp-68],r10d
       movsxd    rcx,r10d
       movzx     r9d,word ptr [r15+rcx*2]
       mov       [rbp-6C],r9d
       mov       [rbp-64],eax
       movsxd    rcx,eax
       movzx     r11d,word ptr [r13+rcx*2]
       mov       [rbp-70],r11d
       cmp       r9d,80
       jge       near ptr M01_L19
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       lea       rcx,[rbp-80]
       mov       rdx,7FFE1D73A308
       mov       r8d,80
       call      qword ptr [7FFDC2C8F780]; System.ReadOnlySpan`1[[System.Boolean, System.Private.CoreLib]]..ctor(Void*, Int32)
       mov       rdx,[rbp-80]
       mov       ecx,[rbp-78]
       mov       r9d,[rbp-6C]
       cmp       r9d,ecx
       jae       near ptr M01_L26
       mov       ecx,r9d
       cmp       byte ptr [rdx+rcx],0
       jne       near ptr M01_L19
       cmp       r9d,[rbp-70]
       je        short M01_L11
       lea       edx,[rbx-1]
       mov       r10d,[rbp-68]
       cmp       r10d,edx
       jge       short M01_L07
       movsxd    r10,r10d
       cmp       word ptr [r15+r10*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       r12d
       cmp       r12d,edi
       jne       near ptr M01_L05
M01_L08:
       mov       edi,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       edi,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       eax,[rbp-64]
       inc       eax
       mov       r10d,[rbp-68]
       inc       r10d
       test      eax,eax
       jle       near ptr M01_L06
       cmp       r10d,ebx
       jge       short M01_L12
       movsxd    rdx,r10d
       cmp       word ptr [r15+rdx*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       edi,r12d
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2BDC120]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rdi+40]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2785BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC2785908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r13
       mov       r8d,1
       mov       r9,r15
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L20]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       edi,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       rdx,1B476000888
       mov       rcx,[rdx]
       mov       [rbp-0C8],rdi
       mov       [rbp-0C0],ebx
       lea       rdx,[rbp-0C8]
       call      qword ptr [7FFDC265E760]; Precode of System.Buffers.AsciiCharSearchValues`2[[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]].ContainsAnyExcept(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rdi
       mov       r9,rdi
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L24]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       edi,eax
       jmp       near ptr M01_L10
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1146
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D51AA0]
       vbroadcastsd ymm3,qword ptr [7FFDC2D51AC0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D51AA0]
       vbroadcastsd ymm2,qword ptr [7FFDC2D51AC0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2D51AA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2D51AC0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2BDC378]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2405C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0D8
       vzeroupper
       lea       rbp,[rsp+110]
       xor       eax,eax
       mov       [rbp-68],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       mov       [rbp-50],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-80],rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       [rbp+10],rbx
       mov       rdi,[rbx+270]
       mov       rcx,1A2C6000C60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L40
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       jne       near ptr M00_L41
       test      byte ptr [7FFDC2DDBDA0],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1A2C6000CC0
       mov       r12,[rcx]
M00_L02:
       mov       [rbp-0C8],r12
M00_L03:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L35
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L22
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L36
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L37
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L34
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L24
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L24
M00_L04:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1A2B0000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1A2B0000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L25
M00_L05:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L29
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L26
M00_L06:
       mov       r13,rax
M00_L07:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L31
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1A2C6000298
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L09
       xchg      ax,ax
M00_L08:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rbx,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L18
       cmp       [rbx],bl
       mov       esi,r11d
       sar       esi,5
       mov       ebx,[rbx+rsi*4]
       bt        ebx,r11d
       jae       near ptr M00_L18
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L08
M00_L09:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       edx,edx
       mov       r9d,ecx
M00_L11:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L18
       mov       esi,r11d
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+rsi],0
       jne       short M00_L18
       cmp       r11d,ebx
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L12
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       short M00_L18
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       r13d,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L15:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       near ptr M00_L21
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L11
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       short M00_L18
M00_L17:
       mov       r13d,ecx
       jmp       short M00_L14
M00_L18:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L19]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L19:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L20
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L20:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L21:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L03
M00_L22:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L23:
       mov       rcx,r12
       mov       r11,7FFDC2351B80
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L24:
       mov       ecx,2
       call      qword ptr [7FFDC2AD6FE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L25:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L05
M00_L26:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L27
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FFDC2785BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L28
M00_L27:
       mov       rcx,[r13+40]
       call      qword ptr [7FFDC2785908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L28:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L06
M00_L29:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L07
M00_L30:
       mov       r8,1A2C6000298
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FFDC2D5EAC0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L18
       jmp       near ptr M00_L13
M00_L31:
       mov       [rbp-50],rcx
       mov       r9,rcx
       lea       rcx,[rbp-44]
       mov       [rbp-58],rcx
       mov       rcx,[r13+20]
       lea       rdx,[rbp-44]
       mov       [rsp+20],edi
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L33
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L03
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L21
M00_L35:
       mov       rcx,r12
       mov       r11,7FFDC2351B78
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L23
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FFDC2BFFBA0]
       int       3
M00_L37:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L38:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L39:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15,[rbp-40]
       mov       [rcx+18],r15
       add       rsp,0D8
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
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L41:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L02
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1A2C6000C50
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2406BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A2C6000C60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FFDC2351B70
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FFDC2351B88
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FFDC2351B88
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1790
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1A2B0000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1A2B0000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1A2C6000298
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2AD6FE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2AD7000]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC2785908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1A2C6000298
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2D5EAC0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 995
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M02_L01
       cmp       [rax],ecx
       jle       short M02_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M02_L03
M02_L00:
       add       rsp,20
       pop       rbx
       ret
M02_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M02_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M02_L00
M02_L02:
       cmp       [rax+4],edx
       jle       short M02_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M02_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L03
       jmp       short M02_L00
M02_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M04_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M04_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M04_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M05_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L08:
       call      M05_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M05_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M06_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M06_L01
M06_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M06_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M06_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M06_L00
M06_L01:
       xor       eax,eax
       vzeroupper
       ret
M06_L02:
       mov       eax,1
       vzeroupper
       ret
M06_L03:
       cmp       edx,10
       jle       near ptr M06_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M06_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M06_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D1C2C0]
       vbroadcastsd ymm3,qword ptr [7FFDC2D1C2E0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M06_L02
       add       rax,40
       cmp       rax,r8
       jb        short M06_L04
M06_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D1C2C0]
       vbroadcastsd ymm2,qword ptr [7FFDC2D1C2E0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
M06_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2D1C2C0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2D1C2E0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M06_L01
       jmp       near ptr M06_L02
; Total bytes of code 351
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M07_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M07_L00:
       call      qword ptr [7FFDC2AD7228]
       int       3
; Total bytes of code 44
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
       jmp       qword ptr [7FFDC2405C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,22A4C802AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC2371068
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371070
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371078
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371080
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L35
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L44
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,22A4C800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,22A4C800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L41
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,22A4C802AE0
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r12,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L35
       cmp       [r12],r12b
       mov       r13d,ebx
       sar       r13d,5
       mov       r13d,[r12+r13*4]
       bt        r13d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
M00_L21:
       test      eax,eax
       jle       near ptr M00_L38
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r13,r11d
       movzx     r13d,word ptr [r9+r13*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L35
       mov       [rbp-3C],r15d
       mov       r12d,esi
       mov       r15,7FFE1D73A308
       cmp       byte ptr [r15+r12],0
       jne       near ptr M00_L39
       cmp       esi,r13d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L40
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,22A4C802AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22A4C802AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FFDC242F930]
       int       3
M00_L27:
       call      qword ptr [7FFDC242F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFDC2C948D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC27A5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC27A58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L36]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M00_L36:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L37
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L37:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L38:
       mov       r8,22A4C802AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2BFCAB0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L35
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L35
M00_L40:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L35
M00_L41:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L42]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M00_L42:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L43
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L43:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L44:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L45
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371080
       call      qword ptr [r11]
M00_L45:
       nop
       add       rsp,38
       ret
; Total bytes of code 1770
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,22A4C800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,22A4C800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,22A4C802AE0
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C948D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C948E8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27A58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,22A4C802AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BFCAB0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2C94B40]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD6C20]
       vbroadcastsd ymm3,qword ptr [7FFDC2BD6C40]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD6C20]
       vbroadcastsd ymm2,qword ptr [7FFDC2BD6C40]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BD6C20]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BD6C40]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,19C7F000AD0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC2350EE8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2350EF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2350EF8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2350F00
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L45
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,19C69000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,19C69000170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L42
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,19C7F000AE8
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r12,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       cmp       [r12],r12b
       mov       r15d,ebx
       sar       r15d,5
       mov       r15d,[r12+r15*4]
       bt        r15d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       mov       r15d,[rbp-3C]
       jne       short M00_L20
M00_L21:
       test      eax,eax
       jle       near ptr M00_L39
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L40
       cmp       esi,r12d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L41
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,19C7F000AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2406BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19C7F000AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L27:
       call      qword ptr [7FFDC240F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFDC2C74900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC2785BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC27858D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       r15d,[rbp-3C]
M00_L36:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L38
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L39:
       mov       r8,19C7F000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2BDCBE8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L40:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L41:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L42:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L43]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M00_L43:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L44
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L44:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L45:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2350F00
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1782
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,19C69000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,19C69000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,19C7F000AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C74900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C74918]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27858D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,19C7F000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BDCBE8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2C74B70]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BB43E0]
       vbroadcastsd ymm3,qword ptr [7FFDC2BB4400]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BB43E0]
       vbroadcastsd ymm2,qword ptr [7FFDC2BB4400]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BB43E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BB4400]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,22020400AD0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L24
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC2381060
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2381068
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2381070
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L26
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L17
       jmp       near ptr M00_L27
M00_L08:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L10:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L34
       mov       r12d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L34
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L11
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L34
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L14:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L16
M00_L15:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L16:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L17:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L28
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L28
M00_L18:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L19
       mov       rcx,2200A400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L19
       mov       rcx,2200A400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L19:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L20:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,22020400AE8
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L08
M00_L21:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L34
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L34
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L21
       jmp       near ptr M00_L08
M00_L22:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L10
       cmp       ebx,eax
       jge       short M00_L23
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L34
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L13
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,22020400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2436BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22020400AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L26:
       call      qword ptr [7FFDC243F480]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L28:
       mov       ecx,2
       call      qword ptr [7FFDC2CA4900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L18
M00_L29:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L19
M00_L30:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L31
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC27B5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC27B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L32:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L34:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L36
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L13
M00_L37:
       mov       r8,22020400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2C0CBE8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       jmp       near ptr M00_L12
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L40
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L14
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L16
       jmp       near ptr M00_L15
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1729
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2200A400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2200A400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,22020400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2CA4900]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2CA4918]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,22020400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2C0CBE8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2CA4B70]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE5740]
       vbroadcastsd ymm3,qword ptr [7FFDC2BE5760]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE5740]
       vbroadcastsd ymm2,qword ptr [7FFDC2BE5760]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BE5740]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BE5760]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,215F6000AE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC2360EE0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2360EE8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2360EF0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2360EF8
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L46
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,215E0000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,215E0000170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L43
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,215F6000AF8
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
       mov       [rbp-3C],r15d
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L39
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
       mov       r15d,[rbp-3C]
M00_L21:
       test      eax,eax
       jle       near ptr M00_L40
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L41
       cmp       esi,r12d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L42
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,215F6000AD8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2416BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,215F6000AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L27:
       call      qword ptr [7FFDC241F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFDC2C84978]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FFDC241D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC2795BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC2795908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       r15d,[rbp-3C]
M00_L36:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L38
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L40:
       mov       r8,215F6000AF8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2B5C678]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L41:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L42:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L43:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L45
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L45:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L46:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2360EF8
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1790
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,215E0000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,215E0000170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,215F6000AF8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C84978]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC241D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C84990]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC2795908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,215F6000AF8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2B5C678]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2C84BB8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD2220]
       vbroadcastsd ymm3,qword ptr [7FFDC2BD2240]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BD2220]
       vbroadcastsd ymm2,qword ptr [7FFDC2BD2240]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BD2220]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BD2240]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,1DBC6800AD0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L26
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC2380EE0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2380EE8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2380EF0
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2380EF8
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L46
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1DBB0800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1DBB0800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L43
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,1DBC6800AE8
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
       mov       [rbp-3C],r15d
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L39
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
       mov       r15d,[rbp-3C]
M00_L21:
       test      eax,eax
       jle       near ptr M00_L40
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L41
       cmp       esi,r12d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L42
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1DBC6800AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2436BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DBC6800AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       call      qword ptr [7FFDC243F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFDC2CA4930]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC27B5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC27B5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       r15d,[rbp-3C]
M00_L36:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L38
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L40:
       mov       r8,1DBC6800AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2B7C690]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L41:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L42:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L43:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L45
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L45:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L46:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2380EF8
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1790
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1DBB0800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1DBB0800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,1DBC6800AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2CA4930]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC243D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2CA4948]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27B5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1DBC6800AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2B7C690]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2CA4B88]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE2960]
       vbroadcastsd ymm3,qword ptr [7FFDC2BE2980]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BE2960]
       vbroadcastsd ymm2,qword ptr [7FFDC2BE2980]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BE2960]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BE2980]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,22002400AD0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L26
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC23510A8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23510B0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23510B8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23510C0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L08:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L23
       cmp       ebx,eax
       jge       short M00_L09
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
M00_L10:
       mov       [rbp-3C],r15d
M00_L11:
       mov       ebx,0FFFFFFFF
M00_L12:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L13:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L15
M00_L14:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L15:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L46
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L29
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L29
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,21FEC400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,21FEC400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L43
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,22002400AE8
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L21
       mov       [rbp-3C],r15d
M00_L20:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L39
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L35
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
       mov       r15d,[rbp-3C]
M00_L21:
       test      eax,eax
       jle       near ptr M00_L40
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L10
M00_L22:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L23:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L41
       cmp       esi,r12d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L42
M00_L24:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L11
       mov       r15d,[rbp-3C]
       jmp       short M00_L22
M00_L25:
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,22002400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2406BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22002400AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       call      qword ptr [7FFDC240F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FFDC2C748E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
M00_L31:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L32
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC2785BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC2785908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L33:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L35:
       mov       r15d,[rbp-3C]
M00_L36:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L38
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L40:
       mov       r8,22002400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2BDE328]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L41:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L42:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L43:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L45
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L45:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L46:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L15
       jmp       near ptr M00_L14
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23510C0
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1790
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,21FEC400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,21FEC400170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,22002400AE8
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2C748E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2C74900]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC2785908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,22002400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2BDE328]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FFDC25A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 983
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2C74B40]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BBEE20]
       vbroadcastsd ymm3,qword ptr [7FFDC2BBEE40]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2BBEE20]
       vbroadcastsd ymm2,qword ptr [7FFDC2BBEE40]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2BBEE20]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2BBEE40]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,18E0EC00AE0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L29
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L28
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L07
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC23512C8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23512D0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23512D8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23512E0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        short M00_L06
       add       r12,10
       jmp       short M00_L08
M00_L06:
       call      qword ptr [7FFDC240F480]
       int       3
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L08:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L19
       jmp       near ptr M00_L30
M00_L09:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L25
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L25
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L09
M00_L10:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L14
M00_L11:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L12:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L25
       mov       r12d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L25
       cmp       esi,r15d
       je        near ptr M00_L23
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L13
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L25
M00_L13:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L11
M00_L14:
       mov       ebx,0FFFFFFFF
M00_L15:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L16:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L18
M00_L17:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L18:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L19:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L31
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L20:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,18DF8C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,18DF8C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L32
M00_L21:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L33
M00_L22:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,18E0EC00888
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L10
       jmp       near ptr M00_L09
M00_L23:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L12
       cmp       ebx,eax
       jge       short M00_L24
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       short M00_L25
M00_L24:
       mov       ebx,ecx
       jmp       near ptr M00_L15
M00_L25:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L26]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L27
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L27:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,18E0EC00AD8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2406BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,18E0EC00AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L31:
       mov       ecx,2
       call      qword ptr [7FFDC2B4C0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L21
M00_L33:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L34
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC2785BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC27858D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L35:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L36:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L22
M00_L37:
       mov       r8,18E0EC00888
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2B4FE70]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L25
       jmp       near ptr M00_L14
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L40
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L16
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L18
       jmp       near ptr M00_L17
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC23512E0
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1733
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0C8
       vzeroupper
       lea       rbp,[rsp+100]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0C0],ymm4
       vmovdqu   ymmword ptr [rbp-0A0],ymm4
       vmovdqu   ymmword ptr [rbp-80],ymm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-0B8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-0A0],rcx
       mov       rcx,rbp
       mov       [rbp-90],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,18DF8C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,18DF8C00170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rdi,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rdi
       mov       r15,rdi
       lea       rcx,[rbp-3C]
       mov       [rbp-60],rcx
       lea       r13,[rbp-3C]
       mov       rcx,18E0EC00888
       mov       rcx,[rcx]
       add       rcx,8
       lea       rdx,[rbp-3C]
       lea       r8,[rbp-3C]
       add       r8,2
       lea       rax,[rbp-3C]
       cmp       rax,r8
       je        short M01_L04
M01_L03:
       movzx     eax,word ptr [rdx]
       cmp       [rcx],cl
       lea       r10,[rcx+20]
       cmp       eax,100
       jge       near ptr M01_L19
       cmp       [r10],r10b
       mov       r9d,eax
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,eax
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,r8
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       edi,ebx
       sub       edi,1
       inc       edi
       xor       r12d,r12d
       test      edi,edi
       je        near ptr M01_L08
M01_L05:
       xor       eax,eax
       mov       r10d,r12d
M01_L06:
       mov       [rbp-68],r10d
       movsxd    rcx,r10d
       movzx     r9d,word ptr [r15+rcx*2]
       mov       [rbp-6C],r9d
       mov       [rbp-64],eax
       movsxd    rcx,eax
       movzx     r11d,word ptr [r13+rcx*2]
       mov       [rbp-70],r11d
       cmp       r9d,80
       jge       near ptr M01_L19
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-80],xmm0
       lea       rcx,[rbp-80]
       mov       rdx,7FFE1D73A308
       mov       r8d,80
       call      qword ptr [7FFDC2C7F828]; System.ReadOnlySpan`1[[System.Boolean, System.Private.CoreLib]]..ctor(Void*, Int32)
       mov       rdx,[rbp-80]
       mov       ecx,[rbp-78]
       mov       r9d,[rbp-6C]
       cmp       r9d,ecx
       jae       near ptr M01_L26
       mov       ecx,r9d
       cmp       byte ptr [rdx+rcx],0
       jne       near ptr M01_L19
       cmp       r9d,[rbp-70]
       je        short M01_L11
       lea       edx,[rbx-1]
       mov       r10d,[rbp-68]
       cmp       r10d,edx
       jge       short M01_L07
       movsxd    r10,r10d
       cmp       word ptr [r15+r10*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       r12d
       cmp       r12d,edi
       jne       near ptr M01_L05
M01_L08:
       mov       edi,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       edi,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,0C8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       eax,[rbp-64]
       inc       eax
       mov       r10d,[rbp-68]
       inc       r10d
       test      eax,eax
       jle       near ptr M01_L06
       cmp       r10d,ebx
       jge       short M01_L12
       movsxd    rdx,r10d
       cmp       word ptr [r15+rdx*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       edi,r12d
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2B4C0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC240D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,[rdi+40]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2785BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27858D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r13
       mov       r8d,1
       mov       r9,r15
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L20]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       edi,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       rdx,18E0EC00888
       mov       rcx,[rdx]
       mov       [rbp-0C8],rdi
       mov       [rbp-0C0],ebx
       lea       rdx,[rbp-0C8]
       call      qword ptr [7FFDC265E760]; Precode of System.Buffers.AsciiCharSearchValues`2[[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]].ContainsAnyExcept(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rdi
       mov       r9,rdi
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L24]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       edi,eax
       jmp       near ptr M01_L10
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1146
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2C74420]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D4AF60]
       vbroadcastsd ymm3,qword ptr [7FFDC2D4AF80]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D4AF60]
       vbroadcastsd ymm2,qword ptr [7FFDC2D4AF80]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2D4AF60]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2D4AF80]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountWithPredicate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0F8
       vzeroupper
       lea       rbp,[rsp+130]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rcx
       lea       rcx,[rbp-0B0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-78],rax
       mov       rcx,rsp
       mov       [rbp-98],rcx
       mov       rcx,rbp
       mov       [rbp-88],rcx
       mov       rdi,[rbx+270]
       mov       rcx,13164800C60
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L28
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L27
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FFDC2371B30
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371B38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371B40
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L01
       add       r15d,1
       jo        short M00_L02
       jmp       short M00_L01
M00_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371B48
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L04:
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       mov       r15d,[rbp-3C]
       mov       [rcx+38],r15d
       add       rsp,0F8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L05:
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L29
       add       r12,10
       jmp       short M00_L07
M00_L06:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
M00_L07:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L18
       jmp       near ptr M00_L30
M00_L08:
       movzx     ebx,word ptr [r11]
       cmp       [r8],r8b
       lea       r15,[r8+20]
       cmp       ebx,100
       jge       near ptr M00_L24
       cmp       [r15],r15b
       mov       r12d,ebx
       sar       r12d,5
       mov       r15d,[r15+r12*4]
       bt        r15d,ebx
       jae       near ptr M00_L24
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L08
M00_L09:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L13
M00_L10:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L11:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L24
       mov       r12d,esi
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L24
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L12
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L24
M00_L12:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L10
M00_L13:
       mov       ebx,0FFFFFFFF
M00_L14:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L15:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L17
M00_L16:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L17:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L04
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L18:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L41
       mov       rax,[rdx+30]
       mov       [rbp-0D0],rax
       cmp       [rax],al
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L31
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L19:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L20
       mov       rcx,1314E800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L20
       mov       rcx,1314E800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L32
M00_L20:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L36
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L33
M00_L21:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L38
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,13164800298
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L09
       jmp       near ptr M00_L08
M00_L22:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L11
       cmp       ebx,eax
       jge       short M00_L23
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       short M00_L24
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L14
M00_L24:
       mov       [rsp+20],eax
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       mov       rdx,r9
       mov       r8d,1
       mov       r9,r10
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L25]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L25:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L26
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L26:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L14
M00_L27:
       mov       ecx,11
       call      qword ptr [7FFDC242F930]
       int       3
M00_L28:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,13164800C58
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FFDC2426BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,13164800C60
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L29:
       call      qword ptr [7FFDC242F480]
       int       3
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L31:
       mov       ecx,2
       call      qword ptr [7FFDC2B07018]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L32:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L20
M00_L33:
       mov       [rbp-0E0],rcx
       mov       rdx,[rcx+30]
       cmp       byte ptr [rdx+1B1],0
       jne       short M00_L34
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0F0],rax
       mov       r8,[rbp-0E0]
       mov       rdx,[r8+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0F0]
       mov       rdx,[rbp-0E0]
       call      qword ptr [7FFDC27A5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFDC27A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       rdx,rax
M00_L35:
       mov       rax,[rbp-0E0]
       lea       rcx,[rax+8]
       mov       [rbp-0E8],rdx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-0E8]
       mov       rax,rdx
       mov       rdx,rax
       jmp       near ptr M00_L21
M00_L36:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L21
M00_L37:
       mov       r8,13164800298
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FFDC2D5EB50]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L24
       jmp       near ptr M00_L13
M00_L38:
       mov       [rbp+10],rbx
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-40]
       mov       [rbp-50],rcx
       mov       rdx,[rbp-0D8]
       mov       rcx,[rdx+20]
       lea       rdx,[rbp-40]
       mov       [rsp+20],eax
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M00_L40
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L15
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L17
       jmp       near ptr M00_L16
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FFDC2371B48
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1737
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
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
       vmovdqu   ymmword ptr [rbp-60],ymm4
       mov       rbx,rdx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-80],rcx
       mov       rcx,rbp
       mov       [rbp-70],rcx
       mov       rbx,[rbx+30]
       cmp       [rbx],bl
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M01_L13
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M01_L13
M01_L00:
       mov       rdi,[rax+10]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1314E800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1314E800170
       mov       rdi,[rax]
       test      rdi,rdi
       je        near ptr M01_L14
M01_L01:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [rdi],rcx
       jne       near ptr M01_L18
       mov       r14,[rdi+8]
       test      r14,r14
       je        near ptr M01_L15
M01_L02:
       mov       dword ptr [rbp-3C],61
       cmp       [r14],r14b
       lea       rcx,[rbx+0C]
       mov       ebx,[rbx+8]
       cmp       byte ptr [r14+2C],0
       je        near ptr M01_L23
       mov       [rbp-58],rcx
       mov       rdi,rcx
       lea       r8,[rbp-3C]
       mov       [rbp-60],r8
       lea       r15,[rbp-3C]
       mov       r8,13164800298
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-3C]
       lea       rax,[rbp-3C]
       add       rax,2
       lea       r10,[rbp-3C]
       cmp       r10,rax
       je        short M01_L04
M01_L03:
       movzx     r10d,word ptr [rdx]
       cmp       [r8],r8b
       lea       r9,[r8+20]
       cmp       r10d,100
       jge       near ptr M01_L19
       cmp       [r9],r9b
       mov       r11d,r10d
       sar       r11d,5
       mov       r9d,[r9+r11*4]
       bt        r9d,r10d
       jae       near ptr M01_L19
       add       rdx,2
       cmp       rdx,rax
       jne       short M01_L03
M01_L04:
       test      ebx,ebx
       jle       near ptr M01_L22
       mov       r8d,ebx
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M01_L08
M01_L05:
       xor       edx,edx
       mov       eax,ecx
M01_L06:
       movsxd    r10,eax
       movzx     r10d,word ptr [rdi+r10*2]
       movsxd    r9,edx
       movzx     r9d,word ptr [r15+r9*2]
       cmp       r10d,80
       jge       near ptr M01_L19
       mov       r11d,r10d
       mov       r13,7FFE1D73A308
       cmp       byte ptr [r11+r13],0
       jne       near ptr M01_L19
       cmp       r10d,r9d
       je        short M01_L11
       lea       edx,[rbx-1]
       cmp       eax,edx
       jge       short M01_L07
       cdqe
       cmp       word ptr [rdi+rax*2+2],80
       jae       near ptr M01_L19
M01_L07:
       inc       ecx
       cmp       ecx,r8d
       jne       short M01_L05
M01_L08:
       mov       r13d,0FFFFFFFF
M01_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M01_L10:
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-50],rax
       cmp       r13d,0FFFFFFFF
       setne     al
       movzx     eax,al
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
M01_L11:
       inc       edx
       inc       eax
       test      edx,edx
       jle       near ptr M01_L06
       cmp       eax,ebx
       jge       short M01_L12
       movsxd    r8,eax
       cmp       word ptr [rdi+r8*2],80
       jae       near ptr M01_L19
M01_L12:
       mov       r13d,ecx
       jmp       short M01_L09
M01_L13:
       mov       ecx,2
       call      qword ptr [7FFDC2B07018]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FFDC242D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rdi,rax
       jmp       near ptr M01_L01
M01_L15:
       mov       rcx,[rdi+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M01_L16
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFDC2B07030]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FFDC27A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
M01_L17:
       lea       rcx,[rdi+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M01_L02
M01_L18:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r14,rax
       jmp       near ptr M01_L02
M01_L19:
       mov       [rsp+20],ebx
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r14+20]
       mov       rdx,r15
       mov       r8d,1
       mov       r9,rdi
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L21
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,13164800298
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FFDC2D5EB50]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       jne       near ptr M01_L19
       jmp       near ptr M01_L08
M01_L23:
       mov       [rbp-48],rcx
       mov       r9,rcx
       lea       rcx,[rbp-3C]
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       lea       rdx,[rbp-3C]
       mov       [rsp+20],ebx
       xor       r8d,r8d
       mov       [rsp+28],r8d
       mov       [rsp+30],r8
       mov       r8d,1
       mov       rax,7FFDC25C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFE22290F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFE2236F778],0
       je        short M01_L25
       call      qword ptr [7FFE2235D608]; CORINFO_HELP_STOP_FOR_GC
M01_L25:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L10
; Total bytes of code 995
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M02_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L00:
       call      qword ptr [7FFDC2B07270]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M03_L01
       cmp       [rax],ecx
       jle       short M03_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M03_L03
M03_L00:
       add       rsp,20
       pop       rbx
       ret
M03_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M03_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M03_L00
M03_L02:
       cmp       [rax+4],edx
       jle       short M03_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M03_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M03_L03
       jmp       short M03_L00
M03_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       push      rsi
       push      rbx
       sub       rsp,28
       call      qword ptr [7FFE1E3977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFE1E3AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFE1E3AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFE1E3AD468]
       int       3
; Total bytes of code 61
```
```assembly
; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdx,[rbx+50]
       test      rdx,rdx
       jne       short M05_L00
       mov       rcx,[rbx+30]
       mov       rdi,[rcx+8]
       lea       rcx,[rbx+50]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFE1E397468]
       cmp       byte ptr [rax],0
       jne       short M05_L01
       mov       rdx,[rbx+30]
       mov       rdx,[rdx+10]
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M05_L01:
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 115
```
```assembly
; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-40],rax
       mov       rbx,rcx
       test      rbx,rbx
       je        near ptr M06_L09
       mov       rcx,rbx
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FFE1E3AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFE1E3BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFE1E3AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FFE1E3A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFE1E3AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFE1E3AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FFE1E3BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-28]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L08:
       call      M06_L12
       nop
       mov       rax,[rbp-40]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M06_L09:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFE1E3AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFE1E3A1A38]
       mov       rsi,rax
       call      qword ptr [7FFE1E3AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FFE1E3AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FFE1E396FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FFE1E3AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L14:
       nop
       add       rsp,28
       ret
; Total bytes of code 497
```
```assembly
; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       mov       rax,rcx
       cmp       edx,8
       jge       short M07_L03
       movsxd    rdx,edx
       lea       rcx,[rax+rdx*2]
       cmp       rax,rcx
       je        short M07_L01
M07_L00:
       movzx     edx,word ptr [rax]
       cmp       [r8],r8b
       lea       r10,[r8+20]
       cmp       edx,100
       jge       short M07_L02
       mov       r9d,edx
       sar       r9d,5
       mov       r10d,[r10+r9*4]
       bt        r10d,edx
       jae       short M07_L02
       add       rax,2
       cmp       rax,rcx
       jne       short M07_L00
M07_L01:
       xor       eax,eax
       vzeroupper
       ret
M07_L02:
       mov       eax,1
       vzeroupper
       ret
M07_L03:
       cmp       edx,10
       jle       near ptr M07_L06
       vmovups   ymm0,[r8]
       cmp       edx,20
       jle       short M07_L05
       lea       r8d,[rdx-20]
       movsxd    r8,r8d
       lea       r8,[rax+r8*2]
M07_L04:
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rax+20]
       vpshufb   ymm2,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D3BBA0]
       vbroadcastsd ymm3,qword ptr [7FFDC2D3BBC0]
       vpshufb   ymm1,ymm3,ymm1
       vpand     ymm1,ymm1,ymm2
       vxorps    ymm2,ymm2,ymm2
       vpcmpeqb  ymm1,ymm2,ymm1
       vptest    ymm1,ymm1
       jne       short M07_L02
       add       rax,40
       cmp       rax,r8
       jb        short M07_L04
M07_L05:
       add       edx,0FFFFFFF0
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2]
       cmp       rax,rcx
       cmova     rax,rcx
       vmovups   ymm1,[rax]
       vpackuswb ymm1,ymm1,[rcx]
       vpshufb   ymm0,ymm0,ymm1
       vpsrld    ymm1,ymm1,4
       vpand     ymm1,ymm1,[7FFDC2D3BBA0]
       vbroadcastsd ymm2,qword ptr [7FFDC2D3BBC0]
       vpshufb   ymm1,ymm2,ymm1
       vpand     ymm0,ymm1,ymm0
       vxorps    ymm1,ymm1,ymm1
       vpcmpeqb  ymm0,ymm1,ymm0
       vptest    ymm0,ymm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
M07_L06:
       vmovups   xmm0,[r8]
       lea       eax,[rdx-8]
       cdqe
       lea       rax,[rcx+rax*2]
       cmp       rcx,rax
       cmova     rcx,rax
       vmovups   xmm1,[rcx]
       vpackuswb xmm1,xmm1,[rax]
       vpsrld    xmm2,xmm1,4
       vpand     xmm2,xmm2,[7FFDC2D3BBA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FFDC2D3BBC0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC26D6D18]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2B7C660]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C9F870]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFDC2C96178]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2C9FDE0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C9F870]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2B7DAB8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L07
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2B78810
       mov       [rdi+18],rcx
       mov       rcx,21000000AD0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDC26D6D18]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,21000000AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,21000000AE0
       cmp       rsi,[rcx]
       je        short M03_L05
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L03:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       or        dword ptr [r14+34],20000000
M03_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2B7C9A8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L06
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L08
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2B7D1E8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2B7D230]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L09:
       mov       rdx,[rbp-30]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L10:
       call      qword ptr [7FFDC29CE298]
       mov       ecx,65
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC27140A0
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2B0FBE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2B0FC00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FFDC2C96178]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2B7DAB8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,21000000AF0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2C9FE10]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,20FEA000218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2B7DEA8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,20FEA000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2B7DBF0]
       mov       edx,eax
       mov       rcx,21000000AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2C9FD08]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2C9FA38]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C97240]
       int       3
M03_L23:
       call      qword ptr [7FFDC2C9FD38]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2C95F50]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2B7C798]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1089
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2B7DAD0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2C9FF90]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2C9FE40]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D75B48]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC26C7CA8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2BFCAF8]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C7F858]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFDC2C76088]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2C7FF90]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C7F858]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2BFDF68]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       jne       short M03_L02
       lea       rax,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rax],rdx
       mov       [rax+8],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L00:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L01:
       mov       rax,[rbp-30]
       mov       eax,[rax+38]
       mov       rdx,[rbx+60]
       mov       [rdx+38],eax
       jmp       near ptr M03_L14
M03_L02:
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2BF8CA8
       mov       [rdi+18],rcx
       mov       rcx,22AF4400AD0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M03_L11
M03_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L04
       call      qword ptr [7FFDC26C7CA8]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,22AF4400AE0
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,22AF4400AE0
       cmp       rsi,[rcx]
       je        short M03_L08
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L06:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L08
M03_L07:
       or        dword ptr [r14+34],20000000
M03_L08:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2BFCE40]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L09
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L00
M03_L09:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2BFD680]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2BFD6C8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FFDC29BE760]
       mov       ecx,65
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC27040A0
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2BF40D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2BF40F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FFDC2C76088]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2BFDF68]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,22AF4400AF0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2D640F0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,22ADE400218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2BFE340]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,22ADE400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2BFE028]
       mov       edx,eax
       mov       rcx,22AF4400AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2C7FF18]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2C7FC00]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C77150]
       int       3
M03_L23:
       call      qword ptr [7FFDC2C7FF48]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2C75F38]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2BFCC30]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1085
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2BFDF80]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2D64138]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2C7FFC0]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D64ED0]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC2795458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2BECA08]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C6F888]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFDC2C66130]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2C6FDF8]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C6F888]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2BEDE60]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L07
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2BE8BB8
       mov       [rdi+18],rcx
       mov       rcx,21250000AD0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDC2795458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,21250000AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,21250000AE0
       cmp       rsi,[rcx]
       je        short M03_L05
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L03:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       or        dword ptr [r14+34],20000000
M03_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2BECD50]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L06
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L08
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2BED590]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2BED5C0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L09:
       mov       rdx,[rbp-30]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L10:
       call      qword ptr [7FFDC29AE718]
       mov       ecx,65
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC26F3D40
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2BE40C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2BE40D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FFDC2C66130]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2BEDE60]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,21250000AF0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2C6FF60]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,2123A000218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2BEE250]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,2123A000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2BEDF80]
       mov       edx,eax
       mov       rcx,21250000AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2C6FD20]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2C6FA50]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C672E8]
       int       3
M03_L23:
       call      qword ptr [7FFDC2C6FD50]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2C65F68]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2BECB40]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1089
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2BEDE78]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2C6FFA8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2C6FE28]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D54F48]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC2795458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2BECA08]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C6F888]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFDC2C66160]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2C6FFC0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C6F888]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2BEDE78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L07
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2BE8BB8
       mov       [rdi+18],rcx
       mov       rcx,1FB1A400AD0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDC2795458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1FB1A400AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,1FB1A400AE0
       cmp       rsi,[rcx]
       je        short M03_L05
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L03:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       or        dword ptr [r14+34],20000000
M03_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2BECD50]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L06
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L08
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2BED5A8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2BED5D8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L09:
       mov       rdx,[rbp-30]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L10:
       call      qword ptr [7FFDC29AE718]
       mov       ecx,65
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC26F3D40
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2BE4090]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2BE40A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FFDC2C66160]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2BEDE78]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1FB1A400AF0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2D54060]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1FB04400218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2BEE250]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,1FB04400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2BEDEF0]
       mov       edx,eax
       mov       rcx,1FB1A400AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2C6FF00]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2C6FC30]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C67258]
       int       3
M03_L23:
       call      qword ptr [7FFDC2C6FF30]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2C65F38]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2BECB40]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1089
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2BEDE90]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2D540A8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2D54000]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D54F30]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC27A5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2BFCAB0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C7F8A0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFDC2C761D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2C7FDF8]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2C7F8A0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2BFDF08]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L07
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2BF8C60
       mov       [rdi+18],rcx
       mov       rcx,18F10C00AD0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDC27A5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,18F10C00AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,18F10C00AE0
       cmp       rsi,[rcx]
       je        short M03_L05
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L03:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       or        dword ptr [r14+34],20000000
M03_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2BFCDF8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L06
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L08
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2BFD638]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2BFD668]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L09:
       mov       rdx,[rbp-30]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L10:
       call      qword ptr [7FFDC29BE6E8]
       mov       ecx,65
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2703D40
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2BF4078]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2BF4090]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FFDC2C761D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2BFDF08]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,18F10C00AF0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2C7FF60]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,18EFAC00218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2BFE2F8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,18EFAC00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2BFE028]
       mov       edx,eax
       mov       rcx,18F10C00AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2C7FD20]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2C7FA68]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C772D0]
       int       3
M03_L23:
       call      qword ptr [7FFDC2C7FD50]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2C75FB0]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2BFCBE8]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1089
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2BFDF20]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2C7FFA8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2C7FE28]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D64F30]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC27B5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2C0E298]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2D74330]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFDC2C96118]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2D74708]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2D74330]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2C0F708]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L07
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2C0A448
       mov       [rdi+18],rcx
       mov       rcx,262BA000AD0
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDC27B5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,262BA000AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,262BA000AE0
       cmp       rsi,[rcx]
       je        short M03_L05
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L03:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       or        dword ptr [r14+34],20000000
M03_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2C0E5E0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L06
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L08
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2C0EDD8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2C0EE50]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L09:
       mov       rdx,[rbp-30]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L10:
       call      qword ptr [7FFDC29CE718]
       mov       ecx,65
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2713D40
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2C04018]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2C04030]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FFDC2C96118]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2C0F708]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,262BA000AF0
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2D74B58]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,262A4000218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2C0FAE0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,262A4000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2C0F7C8]
       mov       edx,eax
       mov       rcx,262BA000AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2D74768]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2D744B0]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C97288]
       int       3
M03_L23:
       call      qword ptr [7FFDC2D74798]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2C95EF0]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2C0E3D0]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1089
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2C0F720]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2D74BA0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2D74A38]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D75980]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC26B7510]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2CB60A0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2D551D0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FFDC2BDC0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2D554A0]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2D551D0]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2CB74F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       jne       short M03_L02
       lea       rax,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rax]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       edx,edx
       mov       [rax],rdx
       mov       [rax+8],rdx
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L00:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L01:
       mov       rax,[rbp-30]
       mov       eax,[rax+38]
       mov       rdx,[rbx+60]
       mov       [rdx+38],eax
       jmp       near ptr M03_L14
M03_L02:
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2CB2250
       mov       [rdi+18],rcx
       mov       rcx,151FE000B50
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M03_L11
M03_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L04
       call      qword ptr [7FFDC26B7510]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,151FE000B60
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,151FE000B60
       cmp       rsi,[rcx]
       je        short M03_L08
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L06
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L06:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L08
M03_L07:
       or        dword ptr [r14+34],20000000
M03_L08:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2CB63E8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L09
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       near ptr M03_L00
M03_L09:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2CB6C28]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2CB6C58]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FFDC29AE1F0]
       mov       ecx,65
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC26F40A0
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AEFCD8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AEFCF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FFDC2BDC0D8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2CB74F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,151FE000B70
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2D55A28]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,151E8000218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2CB78E8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,151E8000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2CB7600]
       mov       edx,eax
       mov       rcx,151FE000B70
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2D555C0]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2D552D8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2BDD1A0]
       int       3
M03_L23:
       call      qword ptr [7FFDC2D555F0]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2BD7CD8]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2CB61D8]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1085
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2CB7510]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2D55A70]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2D558C0]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2D56850]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountCountAsync()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-30],ymm4
       mov       [rbp-38],rcx
       mov       dword ptr [rbp-30],0FFFFFFFF
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M00_L08
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M00_L08
M00_L00:
       mov       rbx,[rax+10]
       test      rbx,rbx
       jne       short M00_L01
       call      qword ptr [7FFDC27A5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FFDC2D6E910]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       nop
       mov       rdx,[rbp-50]
       cmp       rdx,[rbx+10]
       je        short M00_L02
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
M00_L02:
       mov       rsi,[rbx+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L04
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L03
       cmp       qword ptr [rsi+10],0
       jne       short M00_L07
M00_L03:
       cmp       qword ptr [rbp-48],0
       jne       short M00_L06
M00_L04:
       mov       rax,[rbp-28]
       test      rax,rax
       je        short M00_L09
M00_L05:
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L06:
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L04
M00_L07:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2E15E00]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FFDC2AF6FD0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FFDC2E16508]
       jmp       short M00_L05
       sub       rsp,28
       mov       rdx,[rbp-50]
       mov       rax,[rbp-40]
       cmp       rdx,[rax+10]
       je        short M00_L10
       lea       rcx,[rax+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
M00_L10:
       mov       rsi,[rax+8]
       mov       rdx,[rbp-48]
       cmp       rdx,rsi
       je        short M00_L13
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       je        short M00_L11
       cmp       qword ptr [rsi+10],0
       jne       short M00_L12
M00_L11:
       cmp       qword ptr [rbp-48],0
       je        short M00_L13
       mov       rdx,[rbp-48]
       cmp       qword ptr [rdx+10],0
       je        short M00_L13
M00_L12:
       mov       rcx,rsi
       mov       rdx,[rbp-48]
       call      qword ptr [7FFDC2E15E00]
M00_L13:
       nop
       add       rsp,28
       ret
; Total bytes of code 366
```
```assembly
; BenchmarkDotNet.Helpers.AwaitHelper.GetResult(System.Threading.Tasks.Task)
       mov       edx,[rcx+34]
       and       edx,11000000
       cmp       edx,1000000
       jne       short M01_L00
       ret
M01_L00:
       xor       edx,edx
       jmp       qword ptr [7FFDC2D6FD68]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
; Total bytes of code 26
```
```assembly
; System.Threading.Thread.InitializeCurrentThread()
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
       xor       eax,eax
       mov       [rbp-40],rax
       lea       rcx,[rbp-40]
       mov       [rbp-0A0],rcx
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFE1E397020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFE1E398E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFE1E396FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
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
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-28],rax
       mov       [rbp+10],rcx
       mov       eax,[rcx+8]
       mov       rbx,[rcx]
       test      eax,eax
       je        near ptr M03_L07
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFDC2D6AAC0
       mov       [rdi+18],rcx
       mov       rcx,28DE9400C60
       mov       rsi,[rcx]
       mov       rcx,offset MT_System.Threading.Tasks.Task<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rcx,[r14+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r14+10],rcx
       lea       rcx,[r14+18]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       dword ptr [r14+34],2008
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],4
       jle       near ptr M03_L11
       mov       rcx,[rcx+240]
       mov       rax,[rcx+20]
       test      rax,rax
       je        near ptr M03_L11
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       call      qword ptr [7FFDC27A5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,28DE9400C70
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,28DE9400C70
       cmp       rsi,[rcx]
       je        short M03_L05
       mov       rax,[r14+28]
       test      rax,rax
       jne       short M03_L03
       mov       rcx,offset MT_System.Threading.Tasks.Task+ContingentProperties
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+3C],1
       lea       rcx,[r14+28]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rdi
M03_L03:
       lea       rcx,[rax+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L05
M03_L04:
       or        dword ptr [r14+34],20000000
M03_L05:
       mov       rcx,r14
       xor       edx,edx
       call      qword ptr [7FFDC2D6EC58]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
       mov       [rbp-30],r14
       xor       ecx,ecx
       mov       [rbp-28],ecx
       test      byte ptr [rbp-28],4
       jne       short M03_L06
       mov       rcx,[rbp-30]
       test      dword ptr [rcx+34],1600000
       jne       short M03_L08
M03_L06:
       xor       ecx,ecx
       mov       rax,[rbp+10]
       mov       [rax+8],ecx
       lea       rcx,[rax+18]
       mov       rdx,[rbp-30]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       edx,[rbp-28]
       mov       rax,[rbp+10]
       mov       [rax+20],edx
       lea       rdx,[rax+10]
       mov       rcx,rax
       call      qword ptr [7FFDC2D6F4B0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FFDC2D6F4E0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L07:
       mov       rcx,[rbp+10]
       lea       rdx,[rcx+18]
       vmovdqu   xmm0,xmmword ptr [rdx]
       vmovdqu   xmmword ptr [rbp-30],xmm0
       xor       eax,eax
       mov       [rdx],rax
       mov       [rdx+8],rax
       mov       dword ptr [rcx+8],0FFFFFFFF
M03_L08:
       mov       rdx,[rbp-30]
       mov       eax,[rdx+34]
       and       eax,11000000
       cmp       eax,1000000
       jne       near ptr M03_L13
M03_L09:
       mov       rdx,[rbp-30]
       mov       edx,[rdx+38]
       mov       rax,[rbx+60]
       mov       [rax+38],edx
       jmp       near ptr M03_L14
M03_L10:
       call      qword ptr [7FFDC29BE268]
       mov       ecx,65
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2703D40
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AF6280]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AF6298]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FFDC2AF6FD0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FFDC2D6FD68]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,28DE9400C80
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L20
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L22
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L21
M03_L16:
       mov       byte ptr [rbx+38],0
       lea       rcx,[rbx+34]
       mov       eax,[rbx+34]
       or        eax,1000000
       xchg      eax,[rcx]
       mov       rsi,[rbx+28]
       test      rsi,rsi
       je        short M03_L17
       mov       rcx,rbx
       call      qword ptr [7FFDC2E166A0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,28DD3400218
       mov       rdx,[rdx]
       call      00007FFE2201C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FFDC2E14168]; System.Threading.Tasks.Task.RunContinuations(System.Object)
M03_L18:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rdx,28DD3400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFDC2D6FF00]
       mov       edx,eax
       mov       rcx,28DE9400C80
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFDC2E16448]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FFDC2E16190]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FFDC2C24AC8]
       int       3
M03_L23:
       call      qword ptr [7FFDC2E16478]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FFDC2AF6D18]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FFDC2D6EA48]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1089
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFE1E3AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M04_L01
       cmp       [rax],ecx
       jle       short M04_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M04_L03
M04_L00:
       add       rsp,20
       pop       rbx
       ret
M04_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M04_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M04_L00
M04_L02:
       cmp       [rax+4],edx
       jle       short M04_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M04_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M04_L03
       jmp       short M04_L00
M04_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       test      dword ptr [rbx+34],1600000
       jne       short M05_L00
       mov       rcx,rbx
       mov       edx,0FFFFFFFF
       xor       r8d,r8d
       call      qword ptr [7FFDC2D6FD80]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
M05_L00:
       test      dword ptr [rbx+34],10000000
       jne       short M05_L03
M05_L01:
       mov       ecx,[rbx+34]
       and       ecx,1600000
       cmp       ecx,1000000
       jne       short M05_L04
M05_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L03:
       mov       rcx,rbx
       mov       rax,[rbx]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       test      eax,eax
       je        short M05_L01
       mov       rcx,rbx
       call      qword ptr [7FFDC2E166E8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FFDC2E16520]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFDC2E17A38]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC241F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC2361098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC2416850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFDC241F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC2361090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2361078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361088
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFDC279F060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC23610B0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC2416850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC23610A8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2361090
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361098
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC23610A0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC23610A0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 317
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFDC279F060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC242F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC242F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC2371098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC2426850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFDC242F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC2371090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2371078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2371080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2371088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2371088
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFDC27AF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC240F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC2351098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC2406850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFDC240F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC2351090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2351078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2351080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2351088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2351088
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFDC278F060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC242F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC242F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC2371098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC2426850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFDC242F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC2371090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2371078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2371080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2371088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2371088
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFDC27AF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC243F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC2381098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FFDC2436850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      qword ptr [7FFDC243F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC2381090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2381088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2381088
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L07
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L07
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L07
       cmp       [r10+10],rcx
       je        short M01_L07
       cmp       [r10+18],rcx
       je        short M01_L07
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L05
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L07
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L04
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L06
       jmp       qword ptr [7FFDC27BF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L02
M01_L05:
       cmp       [r10],rcx
       je        short M01_L07
       jmp       short M01_L00
M01_L06:
       xor       edx,edx
M01_L07:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L02
       mov       rax,[rdx]
       cmp       rax,rcx
       je        short M02_L02
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
M02_L00:
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       jne       short M02_L03
M02_L01:
       xor       edx,edx
M02_L02:
       mov       rax,rdx
       ret
M02_L03:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       test      rax,rax
       je        short M02_L01
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L02
       jmp       short M02_L00
; Total bytes of code 86
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rax],rcx
       jne       short M00_L02
       mov       edi,[rax+8]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],edi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FFDC23813B0
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       mov       edi,eax
       jmp       short M00_L00
M00_L04:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FFDC23813A8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2381390
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2381398
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L08
       add       edi,1
       jo        short M00_L07
       jmp       short M00_L06
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L08:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC23813A0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FFDC23813A0
       call      qword ptr [r11]
M00_L09:
       nop
       add       rsp,28
       ret
; Total bytes of code 316
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L06
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L03
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L01
       cmp       [r10],rcx
       je        short M01_L06
M01_L00:
       cmp       [r10+8],rcx
       je        short M01_L06
       cmp       [r10+10],rcx
       je        short M01_L06
       cmp       [r10+18],rcx
       je        short M01_L06
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L04
       test      r8,r8
       je        short M01_L03
M01_L01:
       cmp       [r10],rcx
       je        short M01_L06
M01_L02:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L03
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L02
M01_L03:
       test      dword ptr [rax],500C0000
       je        short M01_L05
       jmp       qword ptr [7FFDC27BF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L04:
       cmp       [r10],rcx
       je        short M01_L06
       jmp       short M01_L00
M01_L05:
       xor       edx,edx
M01_L06:
       mov       rax,rdx
       ret
; Total bytes of code 121
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       jne       short M02_L04
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
M02_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
; Total bytes of code 88
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+270]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L02
       mov       rcx,rax
       mov       r11,7FFDC2361B68
       call      qword ptr [r11]
M00_L00:
       mov       rcx,[rbx+60]
       mov       [rcx+38],eax
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M00_L01:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L02:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L03
       mov       rcx,rax
       xor       edx,edx
       mov       rax,[rax]
       mov       rax,[rax+50]
       call      qword ptr [rax]
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.ICollection
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L04
       mov       rcx,rax
       mov       r11,7FFDC2361B60
       call      qword ptr [r11]
       jmp       short M00_L00
M00_L04:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFDC2361B48
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L05:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361B50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L07
       add       edi,1
       jo        short M00_L06
       jmp       short M00_L05
M00_L06:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L07:
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361B58
       call      qword ptr [r11]
       mov       eax,edi
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L08
       mov       rcx,[rbp-20]
       mov       r11,7FFDC2361B58
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 289
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M01_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L03
       cmp       [r10],rcx
       je        short M01_L01
M01_L00:
       cmp       [r10+8],rcx
       jne       short M01_L02
M01_L01:
       mov       rax,rdx
       ret
M01_L02:
       cmp       [r10+10],rcx
       je        short M01_L01
       cmp       [r10+18],rcx
       je        short M01_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L08
       test      r8,r8
       je        short M01_L05
M01_L03:
       cmp       [r10],rcx
       je        short M01_L01
M01_L04:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L06
M01_L05:
       test      dword ptr [rax],500C0000
       je        short M01_L07
       jmp       qword ptr [7FFDC279F060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
M01_L06:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L04
M01_L07:
       xor       edx,edx
       jmp       short M01_L01
M01_L08:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
; Total bytes of code 123
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
M02_L02:
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       jne       short M02_L04
M02_L03:
       xor       edx,edx
       jmp       short M02_L00
M02_L04:
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       test      rax,rax
       je        short M02_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M02_L00
       jmp       short M02_L02
; Total bytes of code 88
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L03:
       mov       r11,7FFDC2381070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L03:
       mov       r11,7FFDC2361070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2361078
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2361080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2361080
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC240F930]
       int       3
M00_L03:
       mov       r11,7FFDC2351070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2351078
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2351080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2351080
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L03:
       mov       r11,7FFDC2381070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L03:
       mov       r11,7FFDC2381070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L03:
       mov       r11,7FFDC23610B8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC23610C0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC23610C8
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC23610C8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC243F930]
       int       3
M00_L03:
       mov       r11,7FFDC23812F8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2381300
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381308
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381308
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       short M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        short M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rcx,[rbx+60]
       mov       [rcx+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       mov       ecx,11
       call      qword ptr [7FFDC241F930]
       int       3
M00_L03:
       mov       r11,7FFDC2361B30
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2361B38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2361B40
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2361B40
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29AE250]
       mov       ecx,65
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC26F3D40
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28141B8
       call      qword ptr [7FFDC241F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC241D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AEFB88]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AEFBA0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC2361078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2361080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2361088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2361088
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2415818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2415818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2E3B4C80008
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
       call      qword ptr [7FFDC2C86628]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC299E718]
       mov       ecx,65
       mov       rdx,7FFDC28041B8
       call      qword ptr [7FFDC240F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC26E3D30
       call      qword ptr [7FFDC240F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC240D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28041B8
       call      qword ptr [7FFDC240F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC240D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2BD40A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2BD40C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC2351078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2351080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2351088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2351088
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2405818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2405818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,238B50B0008
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
       call      qword ptr [7FFDC2C766D0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29CE718]
       mov       ecx,65
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2713D40
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2C04090]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2C040A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC2381078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2381080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2381088
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,278C6340008
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
       call      qword ptr [7FFDC2CA66D0]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29BE268]
       mov       ecx,65
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2703D40
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AFFBB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AFFBD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC2371078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2371080
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2371088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2371088
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1D6C0760008
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
       call      qword ptr [7FFDC2C966B8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29CE760]
       mov       ecx,65
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC27140A0
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28341B8
       call      qword ptr [7FFDC243F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC243D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2C04060]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2C04078]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC2380F10
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2380F18
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2380F20
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2380F20
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2435818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,27BFDC70008
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
       call      qword ptr [7FFDC2CA6718]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29BE250]
       mov       ecx,65
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC27040A0
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AFFD08]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AFFD20]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC23710D8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC23710E0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC23710E8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC23710E8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23AB02C0008
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
       call      qword ptr [7FFDC2C96760]
       int       3
; Total bytes of code 244
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29BE238]
       mov       ecx,65
       mov       rdx,7FFDC2825758
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC2704A98
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC2825758
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AFFC78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AFFC90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC23712E8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC23712F0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC23712F8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC23712F8
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M01_L00
       mov       edi,[rbx+8]
       test      edi,edi
       je        short M01_L00
       test      rsi,rsi
       je        near ptr M01_L03
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rsi,rsi
       je        short M01_L01
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,2028A9C0008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFDC2CA6778]
       int       3
; Total bytes of code 235
```

## .NET 10.0.2 (10.0.2, 10.0.225.61305), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+270]
       test      rcx,rcx
       je        short M00_L02
       xor       esi,esi
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rcx],r11
       jne       near ptr M00_L03
       mov       ecx,[rcx+8]
       xor       r11d,r11d
       test      ecx,ecx
       je        short M00_L01
       nop       word ptr [rax+rax]
M00_L00:
       add       rsi,1
       jo        near ptr M00_L07
       inc       r11d
       cmp       r11d,ecx
       jb        short M00_L00
M00_L01:
       mov       rax,[rbx+60]
       mov       [rax+18],rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M00_L02:
       call      qword ptr [7FFDC29BE268]
       mov       ecx,65
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FFDC27040A0
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFDC28241B8
       call      qword ptr [7FFDC242F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFDC242D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFDC2AF62E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFDC2AF62F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FFDC2371B80
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FFDC2371B88
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L06
       add       rsi,1
       jo        short M00_L05
       jmp       short M00_L04
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L06:
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2371B90
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FFDC2371B90
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 368
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
       je        near ptr M01_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M01_L00
       test      rbx,rbx
       je        near ptr M01_L03
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M01_L03
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M01_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFE2205AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFDC2425818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L00:
       test      rbx,rbx
       je        short M01_L01
       mov       ebp,[rbx+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M01_L02
M01_L01:
       mov       rax,253CCE70008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L02:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L04:
       call      qword ptr [7FFDC2C1EB38]
       int       3
; Total bytes of code 235
```

