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
       mov       rcx,29674C00AD8
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
       test      byte ptr [7FF7DC88BCE8],1
       je        near ptr M00_L44
M00_L01:
       mov       rcx,29674C00C28
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
       mov       rcx,[rcx+40]
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
       mov       rax,2965EC00190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,2965EC00170
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
       mov       r8,29674C00AE8
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
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L28
       mov       ebx,r11d
       mov       r15,7FF83693A308
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L28
       cmp       r11d,esi
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
       mov       r13d,ecx
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
       mov       r11,7FF7DBEC1098
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L35
M00_L22:
       mov       ecx,2
       call      qword ptr [7FF7DC8D4AF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L23:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC3B5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L26
M00_L25:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC3B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L29]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M00_L29:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L30
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L30:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L31:
       mov       r8,29674C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC7BCEA0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L33]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M00_L33:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L34
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L34:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
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
       mov       r11,7FF7DBEC1090
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L21
       jmp       near ptr M00_L46
M00_L37:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC8D7C90]
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
       mov       rdx,29674C00AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,29674C00AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       ecx,11
       call      qword ptr [7FF7DBF7F930]
       int       3
M00_L44:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,rdi
       mov       r11,7FF7DBEC1088
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L46:
       mov       rcx,r12
       mov       r11,7FF7DBEC10A0
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
       mov       r11,7FF7DBEC10A0
       call      qword ptr [r11]
M00_L47:
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
       mov       rax,2965EC00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2965EC00170
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
       mov       r8,29674C00AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8D4AF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8D4B10]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,29674C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC7BCEA0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC827460]
       vbroadcastsd ymm3,qword ptr [7FF7DC827480]
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
       vpand     ymm1,ymm1,[7FF7DC827460]
       vbroadcastsd ymm2,qword ptr [7FF7DC827480]
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
       vpand     xmm2,xmm2,[7FF7DC827460]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC827480]
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
       call      qword ptr [7FF7DC8D4E28]
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
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,2087F402AE0
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
       test      byte ptr [7FF7DC838660],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,2087F402008
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
       mov       rax,2087F400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,2087F400170
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
       mov       r8,2087F402AF0
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
       mov       r15,7FF83693A308
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
       mov       r11,7FF7DBEA0CE0
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FF7DC82ED30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L29
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,2087F402AF0
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC825290]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA0CD8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC82EB98]
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
       mov       rdx,2087F402AD0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2087F402AE0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF55728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBEA0CD0
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBEA0CE8
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
       mov       r11,7FF7DBEA0CE8
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1788
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
       mov       rax,2087F400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2087F400170
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
       mov       r8,2087F402AF0
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC82ED30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC82ED48]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2087F402AF0
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC825290]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC7772C0]
       vbroadcastsd ymm3,qword ptr [7FF7DC7772E0]
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
       vpand     ymm1,ymm1,[7FF7DC7772C0]
       vbroadcastsd ymm2,qword ptr [7FF7DC7772E0]
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
       vpand     xmm2,xmm2,[7FF7DC7772C0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC7772E0]
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
       call      qword ptr [7FF7DC895A58]
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
       jmp       qword ptr [7FF7DBF55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,2CE85000AD8
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
       test      byte ptr [7FF7DC85A128],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,2CE85000C28
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
       mov       rax,2CE6F000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,2CE6F000170
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
       mov       r8,2CE85000AE8
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
       mov       r15,7FF83693A308
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
       mov       r11,7FF7DBEA1090
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FF7DC8B4BB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L29
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,2CE85000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC78C9A8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA1088
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC8B7C78]
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
       mov       rdx,2CE85000AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2CE85000AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBEA1080
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBEA1098
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
       mov       r11,7FF7DBEA1098
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
       mov       rax,2CE6F000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2CE6F000170
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
       mov       r8,2CE85000AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8B4BB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8B4BD0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2CE85000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC78C9A8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC7F55C0]
       vbroadcastsd ymm3,qword ptr [7FF7DC7F55E0]
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
       vpand     ymm1,ymm1,[7FF7DC7F55C0]
       vbroadcastsd ymm2,qword ptr [7FF7DC7F55E0]
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
       vpand     xmm2,xmm2,[7FF7DC7F55C0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC7F55E0]
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
       call      qword ptr [7FF7DC8B4E10]
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
       jmp       qword ptr [7FF7DBF55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,180EA000AD8
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
       test      byte ptr [7FF7DC85A128],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,180EA000C28
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
       mov       rax,180D4000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,180D4000170
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
       mov       r8,180EA000AE8
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
       mov       r15,7FF83693A308
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
       mov       r11,7FF7DBEA1090
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FF7DC8B4BB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L29
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,180EA000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC78C9C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA1088
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC8B7C78]
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
       mov       rdx,180EA000AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,180EA000AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBEA1080
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBEA1098
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
       mov       r11,7FF7DBEA1098
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
       mov       rax,180D4000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,180D4000170
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
       mov       r8,180EA000AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8B4BB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8B4BD0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,180EA000AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC78C9C0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC7F51E0]
       vbroadcastsd ymm3,qword ptr [7FF7DC7F5200]
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
       vpand     ymm1,ymm1,[7FF7DC7F51E0]
       vbroadcastsd ymm2,qword ptr [7FF7DC7F5200]
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
       vpand     xmm2,xmm2,[7FF7DC7F51E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC7F5200]
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
       call      qword ptr [7FF7DC8B4E10]
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
       jmp       qword ptr [7FF7DBF55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,2740DC02AD0
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
       test      byte ptr [7FF7DC879B98],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,2740DC02C20
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
       mov       rax,2740DC00190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,2740DC00170
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
       mov       r8,2740DC02AE0
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
       mov       r15,7FF83693A308
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
       mov       r11,7FF7DBEC0F10
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FF7DC8D4BE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC3B5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC3B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L29
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,2740DC02AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC7AC918]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEC0F08
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC8D7D38]
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
       call      qword ptr [7FF7DBF7F930]
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
       mov       rdx,2740DC02AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2740DC02AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBEC0F00
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBEC0F18
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
       mov       r11,7FF7DBEC0F18
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
       mov       rax,2740DC00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2740DC00170
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
       mov       r8,2740DC02AE0
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8D4BE8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8D4C00]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3B58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2740DC02AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC7AC918]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC8128A0]
       vbroadcastsd ymm3,qword ptr [7FF7DC8128C0]
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
       vpand     ymm1,ymm1,[7FF7DC8128A0]
       vbroadcastsd ymm2,qword ptr [7FF7DC8128C0]
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
       vpand     xmm2,xmm2,[7FF7DC8128A0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC8128C0]
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
       call      qword ptr [7FF7DC8D4E40]
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
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,22912C00AD8
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
       test      byte ptr [7FF7DC87A878],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,22912C00C28
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
       mov       rax,228FCC00190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,228FCC00170
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
       mov       r8,22912C00AE8
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
       mov       r15,7FF83693A308
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
       mov       r11,7FF7DBEC1090
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FF7DC8D4C30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L22:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC3B5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC3B5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L29
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L30:
       mov       r8,22912C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC82CA20]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEC1088
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC8D7D80]
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
       call      qword ptr [7FF7DBF7F930]
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
       mov       rdx,22912C00AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,22912C00AD8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBEC1080
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBEC1098
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
       mov       r11,7FF7DBEC1098
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
       mov       rax,228FCC00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,228FCC00170
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
       mov       r8,22912C00AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8D4C30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8D4C48]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3B5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,22912C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC82CA20]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1D51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC805920]
       vbroadcastsd ymm3,qword ptr [7FF7DC805940]
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
       vpand     ymm1,ymm1,[7FF7DC805920]
       vbroadcastsd ymm2,qword ptr [7FF7DC805940]
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
       vpand     xmm2,xmm2,[7FF7DC805920]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC805940]
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
       call      qword ptr [7FF7DC8D4E88]
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
       jmp       qword ptr [7FF7DBF75C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,1A8BE400B58
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
       test      byte ptr [7FF7DC8EF2F8],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1A8BE400C68
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
       mov       rax,1A8A8400190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1A8A8400170
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
       mov       r8,1A8BE400888
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
       mov       r15,7FF83693A308
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L19]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L19:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L20
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBE91308
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L24:
       mov       ecx,2
       call      qword ptr [7FF7DC7FC2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L25:
       call      qword ptr [7FF7DBF4D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC385BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L28
M00_L27:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC385908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       r8,1A8BE400888
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC8D6790]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBE91300
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L23
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC8D7E58]
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
       call      qword ptr [7FF7DBF4F930]
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
       mov       rdx,1A8BE400B48
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1A8BE400B58
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBE912F8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBE91310
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
       mov       r11,7FF7DBE91310
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
       mov       rax,1A8A8400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1A8A8400170
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
       mov       rcx,1A8BE400888
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
       mov       rdx,7FF83693A308
       mov       r8d,80
       call      qword ptr [7FF7DC8DFAC8]; System.ReadOnlySpan`1[[System.Boolean, System.Private.CoreLib]]..ctor(Void*, Int32)
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
       call      qword ptr [7FF7DC7FC2B8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF4D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC385BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC385908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L20]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       edi,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       rdx,1A8BE400888
       mov       rcx,[rdx]
       mov       [rbp-0C8],rdi
       mov       [rbp-0C0],ebx
       lea       rdx,[rbp-0C8]
       call      qword ptr [7FF7DC25E760]; Precode of System.Buffers.AsciiCharSearchValues`2[[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib]].ContainsAnyExcept(System.ReadOnlySpan`1<Char>)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M01_L24]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC994220]
       vbroadcastsd ymm3,qword ptr [7FF7DC994240]
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
       vpand     ymm1,ymm1,[7FF7DC994220]
       vbroadcastsd ymm2,qword ptr [7FF7DC994240]
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
       vpand     xmm2,xmm2,[7FF7DC994220]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC994240]
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
       call      qword ptr [7FF7DC7FC4F8]
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
       jmp       qword ptr [7FF7DBF45C38]
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
       mov       rcx,1F7F8000D18
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
       test      byte ptr [7FF7DCA0E550],1
       je        near ptr M00_L43
M00_L01:
       mov       rcx,1F7F8000DB0
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
       mov       rax,1F7E2000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L05
       mov       rax,1F7E2000170
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
       mov       r8,1F7F8000298
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
       mov       r15,7FF83693A308
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L19]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L19:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L20
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA1B70
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L24:
       mov       ecx,2
       call      qword ptr [7FF7DC727300]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L04
M00_L25:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L28
M00_L27:
       mov       rcx,[r13+40]
       call      qword ptr [7FF7DC395908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       r8,1F7F8000298
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF7DC97EDA8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L33
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA1B68
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L23
       jmp       near ptr M00_L45
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF7DC82FD80]
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
       call      qword ptr [7FF7DBF5F930]
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
       mov       rdx,1F7F8000D08
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F7F8000D18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L01
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF7DBEA1B60
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L02
M00_L45:
       mov       rcx,r12
       mov       r11,7FF7DBEA1B78
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
       mov       r11,7FF7DBEA1B78
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
       mov       rax,1F7E2000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1F7E2000170
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
       mov       r8,1F7F8000298
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC727300]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC727318]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC395908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1F7F8000298
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC97EDA8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M05_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L02
M05_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M05_L08
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M05_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L00
M05_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M05_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M05_L04:
       test      r14,r14
       je        near ptr M05_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M05_L06
M05_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M05_L07
M05_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M05_L05
M05_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M05_L10:
       xor       r14d,r14d
       jmp       near ptr M05_L04
M05_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M05_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M05_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC95F300]
       vbroadcastsd ymm3,qword ptr [7FF7DC95F320]
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
       vpand     ymm1,ymm1,[7FF7DC95F300]
       vbroadcastsd ymm2,qword ptr [7FF7DC95F320]
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
       vpand     xmm2,xmm2,[7FF7DC95F300]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC95F320]
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
       call      qword ptr [7FF7DC727558]
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
       jmp       qword ptr [7FF7DBF55C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       mov       rcx,1F6B1400AD0
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
       mov       r11,7FF7DBEB0EE8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEB0EF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEB0EF8
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
       mov       r11,7FF7DBEB0F00
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
       mov       rcx,1F69B400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1F69B400170
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
       mov       r8,1F6B1400AE8
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
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L35
       mov       [rbp-3C],r15d
       mov       r13d,esi
       mov       r15,7FF83693A308
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L39
       cmp       esi,r12d
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
       mov       rdx,1F6B1400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1F6B1400AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF7DBF6F930]
       int       3
M00_L27:
       call      qword ptr [7FF7DBF6F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FF7DC8C4C18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FF7DBF6D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC3A5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L36]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M00_L36:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L37
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L37:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L38:
       mov       r8,1F6B1400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC7ACED0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L42]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M00_L42:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L43
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEB0F00
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
       mov       rax,1F69B400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1F69B400170
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
       mov       r8,1F6B1400AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8C4C18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF6D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8C4C30]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1F6B1400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC7ACED0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8C4E58]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC813660]
       vbroadcastsd ymm3,qword ptr [7FF7DC813680]
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
       vpand     ymm1,ymm1,[7FF7DC813660]
       vbroadcastsd ymm2,qword ptr [7FF7DC813680]
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
       vpand     xmm2,xmm2,[7FF7DC813660]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC813680]
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
       mov       rcx,1E963400AD0
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
       mov       r11,7FF7DBEA0EE8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEA0EF0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEA0EF8
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
       mov       r11,7FF7DBEA0F00
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
       mov       rcx,1E94D400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1E94D400170
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
       mov       r8,1E963400AE8
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
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L35
       mov       [rbp-3C],r15d
       mov       r13d,esi
       mov       r15,7FF83693A308
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L39
       cmp       esi,r12d
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
       mov       rdx,1E963400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E963400AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L27:
       call      qword ptr [7FF7DBF5F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FF7DC8B4BB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L36]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L36:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L37
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L37:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L38:
       mov       r8,1E963400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC78C8B8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L42]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L42:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L43
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA0F00
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
       mov       rax,1E94D400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1E94D400170
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
       mov       r8,1E963400AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8B4BB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8B4BD0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1E963400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC78C8B8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8B4E10]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC7F4080]
       vbroadcastsd ymm3,qword ptr [7FF7DC7F40A0]
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
       vpand     ymm1,ymm1,[7FF7DC7F4080]
       vbroadcastsd ymm2,qword ptr [7FF7DC7F40A0]
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
       vpand     xmm2,xmm2,[7FF7DC7F4080]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC7F40A0]
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
       mov       rcx,1D768C00AD0
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
       mov       r11,7FF7DBE91060
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBE91068
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBE91070
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
       mov       r11,7FF7DBE91078
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
       mov       rcx,1D752C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,1D752C00170
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
       mov       r8,1D768C00AE8
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
       mov       r13,7FF83693A308
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
       mov       rdx,1D768C00AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF46BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D768C00AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF7DBF4F930]
       int       3
M00_L27:
       call      qword ptr [7FF7DBF4F480]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L29:
       mov       ecx,2
       call      qword ptr [7FF7DC8A4C30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FF7DBF4D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC385BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC385908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1A51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L38
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,1D768C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC77CA50]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1A51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L45
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBE91078
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
       mov       rax,1D752C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1D752C00170
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
       mov       r8,1D768C00AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8A4C30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF4D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8A4C48]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC385908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1D768C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC77CA50]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8A4E70]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC7E4FA0]
       vbroadcastsd ymm3,qword ptr [7FF7DC7E4FC0]
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
       vpand     ymm1,ymm1,[7FF7DC7E4FA0]
       vbroadcastsd ymm2,qword ptr [7FF7DC7E4FC0]
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
       vpand     xmm2,xmm2,[7FF7DC7E4FA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC7E4FC0]
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
       mov       rcx,2503F400AD0
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
       mov       r11,7FF7DBEA1060
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEA1068
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEA1070
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
       mov       r11,7FF7DBEA1078
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
       mov       r13,7FF83693A308
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
       mov       rcx,[rcx+30]
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
       mov       rcx,25029400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L19
       mov       rcx,25029400170
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
       mov       r8,2503F400AE8
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
       mov       rdx,2503F400AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2503F400AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       ecx,11
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L26:
       call      qword ptr [7FF7DBF5F480]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L28:
       mov       ecx,2
       call      qword ptr [7FF7DC8B4C00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L18
M00_L29:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L36
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L13
M00_L37:
       mov       r8,2503F400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC79CEB8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L40
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA1078
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
       mov       rax,25029400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,25029400170
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
       mov       r8,2503F400AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8B4C00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8B4C18]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2503F400AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC79CEB8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8B4E58]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC805AC0]
       vbroadcastsd ymm3,qword ptr [7FF7DC805AE0]
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
       vpand     ymm1,ymm1,[7FF7DC805AC0]
       vbroadcastsd ymm2,qword ptr [7FF7DC805AE0]
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
       vpand     xmm2,xmm2,[7FF7DC805AC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC805AE0]
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
       mov       rcx,1FD78C02AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L24
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FF7DBEB0EE0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEB0EE8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEB0EF0
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
       mov       r11,7FF7DBEB0EF8
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
       jl        near ptr M00_L18
       jmp       near ptr M00_L27
M00_L08:
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
       jge       near ptr M00_L34
       mov       r12d,esi
       mov       r13,7FF83693A308
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L34
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L12
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L34
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
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L28
       mov       rcx,[rcx+240]
       mov       rdx,[rcx+10]
       test      rdx,rdx
       je        near ptr M00_L28
M00_L19:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L20
       mov       rcx,1FD78C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L20
       mov       rcx,1FD78C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L20:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
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
       mov       r8,1FD78C02AE0
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
       jae       near ptr M00_L34
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L14
M00_L24:
       mov       ecx,11
       call      qword ptr [7FF7DBF6F930]
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1FD78C02AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1FD78C02AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FF7DBF6F480]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L28:
       mov       ecx,2
       call      qword ptr [7FF7DC8C4C00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L29:
       call      qword ptr [7FF7DBF6D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L20
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
       call      qword ptr [7FF7DC3A5BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3A58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L21
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L21
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L36
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L14
M00_L37:
       mov       r8,1FD78C02AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC7ACEB8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L40
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEB0EF8
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
       mov       rax,1FD78C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1FD78C00170
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
       mov       r8,1FD78C02AE0
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8C4C00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF6D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8C4C18]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3A58D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1FD78C02AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC7ACEB8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8C4E58]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC812CA0]
       vbroadcastsd ymm3,qword ptr [7FF7DC812CC0]
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
       vpand     ymm1,ymm1,[7FF7DC812CA0]
       vbroadcastsd ymm2,qword ptr [7FF7DC812CC0]
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
       vpand     xmm2,xmm2,[7FF7DC812CA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC812CC0]
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
       mov       rcx,1E7B8C00AD0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L24
       xor       r15d,r15d
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       je        near ptr M00_L06
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rcx
       je        near ptr M00_L05
       mov       rcx,rdi
       mov       r11,7FF7DBEB1060
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEB1068
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEB1070
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
       mov       r11,7FF7DBEB1078
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
       mov       r13,7FF83693A308
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
       mov       rcx,[rcx+30]
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
       mov       rcx,1E7A2C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L19
       mov       rcx,1E7A2C00170
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
       mov       r8,1E7B8C00AE8
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
       mov       ecx,11
       call      qword ptr [7FF7DBF6F930]
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1E7B8C00AC8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF66BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E7B8C00AD0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FF7DBF6F480]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L28:
       mov       ecx,2
       call      qword ptr [7FF7DC8C4C48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L18
M00_L29:
       call      qword ptr [7FF7DBF6D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC3A5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L36
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L13
M00_L37:
       mov       r8,1E7B8C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC82CF30]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L40
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEB1078
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
       mov       rax,1E7A2C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1E7A2C00170
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
       mov       r8,1E7B8C00AE8
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8C4C48]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF6D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8C4C60]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3A5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1E7B8C00AE8
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC82CF30]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF7DC1C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8C4EA0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC8051A0]
       vbroadcastsd ymm3,qword ptr [7FF7DC8051C0]
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
       vpand     ymm1,ymm1,[7FF7DC8051A0]
       vbroadcastsd ymm2,qword ptr [7FF7DC8051C0]
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
       vpand     xmm2,xmm2,[7FF7DC8051A0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC8051C0]
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
       mov       rcx,2090EC02AC8
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
       mov       r11,7FF7DBEA12B0
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEA12B8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEA12C0
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
       mov       r11,7FF7DBEA12C8
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
       call      qword ptr [7FF7DBF5F480]
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
       mov       r13,7FF83693A308
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
       mov       rcx,[rcx+38]
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
       mov       rcx,2090EC00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,2090EC00170
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
       mov       r8,2090EC02AE0
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L26]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L27
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L27:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,11
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2090EC02AC0
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF56BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2090EC02AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L31:
       mov       ecx,2
       call      qword ptr [7FF7DC8B44B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC395BC0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       r8,2090EC02AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC80FD50]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L40
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEA12C8
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
       mov       rax,2090EC00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2090EC00170
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
       mov       r8,2090EC02AE0
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC8B44B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF5D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC8B44C8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3958D8]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2090EC02AE0
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC80FD50]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC8B4EA0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC98BEC0]
       vbroadcastsd ymm3,qword ptr [7FF7DC98BEE0]
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
       vpand     ymm1,ymm1,[7FF7DC98BEC0]
       vbroadcastsd ymm2,qword ptr [7FF7DC98BEE0]
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
       vpand     xmm2,xmm2,[7FF7DC98BEC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC98BEE0]
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
       mov       rcx,19F37400D10
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
       mov       r11,7FF7DBEC1B40
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L01:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEC1B48
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L03
       mov       rcx,[rbp-0C8]
       mov       r11,7FF7DBEC1B50
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
       mov       r11,7FF7DBEC1B58
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
       mov       r13,7FF83693A308
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
       mov       rcx,[rcx+30]
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
       mov       rcx,19F21400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L20
       mov       rcx,19F21400170
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
       mov       r8,19F37400298
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L25]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L25:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L26
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M00_L26:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L14
M00_L27:
       mov       ecx,11
       call      qword ptr [7FF7DBF7F930]
       int       3
M00_L28:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,19F37400D08
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF7DBF76BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,19F37400D10
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L29:
       call      qword ptr [7FF7DBF7F480]
       int       3
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L04
M00_L31:
       mov       ecx,2
       call      qword ptr [7FF7DC7372E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L19
M00_L32:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC3B5BF0]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF7DC3B5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       r8,19F37400298
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF7DC99EBF8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M00_L40
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF7DBEC1B58
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
       mov       rax,19F21400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,19F21400170
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
       mov       r8,19F37400298
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
       mov       r13,7FF83693A308
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
       call      qword ptr [7FF7DC7372E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF7DBF7D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF7DC737300]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF7DC3B5908]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L21
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,19F37400298
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF7DC99EBF8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF7DC1D51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FF83BDD0F60
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FF83BEAF778],0
       je        short M01_L25
       call      qword ptr [7FF83BE9D608]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF7DC737528]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF8375977D0]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FF8375AEA88]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FF8375AFC28]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FF8375AD468]
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
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF837597468]
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
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       call      qword ptr [7FF8375AEA78]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       rsi,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       test      rsi,rsi
       je        short M06_L01
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L02
M06_L00:
       mov       dword ptr [rbp-2C],1
       lea       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FF8375BDC10]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L03
       mov       rax,[rbp-28]
       mov       [rbp-40],rax
       jmp       near ptr M06_L08
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FF8375AA268]
       int       3
M06_L02:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L00
M06_L03:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF8375AE578]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M06_L10
       call      qword ptr [7FF8375A1A30]
       mov       r14,rax
       lea       rcx,[r14+30]
       mov       rdx,rdi
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FF8375AE5A0]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[r14+40]
       mov       rdx,rax
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [r14+60],0
M06_L04:
       test      r14,r14
       je        near ptr M06_L11
       mov       [rbp-28],r14
       mov       rcx,[rbp-28]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-28]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF8375AF490]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       rbx,rax
       mov       [rbp-38],rsi
       xor       ecx,ecx
       mov       [rbp-2C],ecx
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC38]
       test      eax,eax
       je        short M06_L06
M06_L05:
       mov       dword ptr [rbp-2C],1
       mov       r8,[rbp-28]
       mov       rcx,rsi
       mov       rdx,rbx
       xor       r9d,r9d
       call      qword ptr [7FF8375BDBA0]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       jmp       short M06_L07
M06_L06:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC48]
       jmp       short M06_L05
M06_L07:
       mov       rcx,rsi
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       call      qword ptr [7FF8375AA268]
       int       3
M06_L10:
       xor       r14d,r14d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FF8375A1A38]
       mov       rsi,rax
       call      qword ptr [7FF8375AE948]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,rbx
       mov       rcx,rsi
       call      qword ptr [7FF8375AEAA8]
       mov       rcx,rsi
       call      qword ptr [7FF837596FA8]; CORINFO_HELP_THROW
       int       3
M06_L12:
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L13
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L13:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-2C],0
       je        short M06_L14
       mov       rcx,[rbp-38]
       call      qword ptr [7FF8375AFC98]; Precode of System.Threading.Monitor.Exit(System.Object)
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
       vpand     ymm1,ymm1,[7FF7DC97F080]
       vbroadcastsd ymm3,qword ptr [7FF7DC97F0A0]
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
       vpand     ymm1,ymm1,[7FF7DC97F080]
       vbroadcastsd ymm2,qword ptr [7FF7DC97F0A0]
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
       vpand     xmm2,xmm2,[7FF7DC97F080]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF7DC97F0A0]
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
       call      qword ptr [7FF7DC3B5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC7AC888]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC8BFB10]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7DC8B63E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC9A40F0]
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
       call      qword ptr [7FF7DC8BFB10]
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
       jmp       qword ptr [7FF7DC7ADCE0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC7A8A38
       mov       [rdi+18],rcx
       mov       rcx,1C8B7C00AD0
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
M03_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L04
       call      qword ptr [7FF7DC3B5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1C8B7C00AE0
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,1C8B7C00AE0
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
       call      qword ptr [7FF7DC7ACBD0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC7AD410]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC7AD458]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FF7DC5CE220]
       mov       ecx,65
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC73FE10]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC73FE28]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF7DC8B63E8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC7ADCE0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1C8B7C00AF0
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
       call      qword ptr [7FF7DC9A43A8]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1C8A1C00218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC7AE0D0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1C8A1C00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7ADE00]
       mov       edx,eax
       mov       rcx,1C8B7C00AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC9A4168]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC8BFE40]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC8B7570]
       int       3
M03_L23:
       call      qword ptr [7FF7DC9A4198]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC8B61C0]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC7AC9C0]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC7ADCF8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC9A43F0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A4288]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A5DD0]
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
       call      qword ptr [7FF7DC2D41C8]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC7BCE28]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC8BFB70]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF7DC8B6478]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC9A4180]
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
       call      qword ptr [7FF7DC8BFB70]
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
       jmp       qword ptr [7FF7DC7BE280]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC7B8FD8
       mov       [rdi+18],rcx
       mov       rcx,26647C00AD0
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
       call      qword ptr [7FF7DC2D41C8]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,26647C00AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,26647C00AE0
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
       call      qword ptr [7FF7DC7BD170]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC7BD968]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC7BD9E0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF7DC5CE760]
       mov       ecx,65
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B43D8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B43F0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF7DC8B6478]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC7BE280]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,26647C00AF0
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
       call      qword ptr [7FF7DC9A4408]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,26631C00218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC7BE670]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,26631C00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7BE388]
       mov       edx,eax
       mov       rcx,26647C00AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC9A41F8]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC8BFF18]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC8B7540]
       int       3
M03_L23:
       call      qword ptr [7FF7DC9A4228]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC8B61D8]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC7BCF60]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC7BE298]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC9A4450]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A42E8]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A5230]
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
       call      qword ptr [7FF7DC3B5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC7BCDE0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC8BFB88]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7DC8B6478]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC9A4168]
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
       call      qword ptr [7FF7DC8BFB88]
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
       jmp       qword ptr [7FF7DC7BE238]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC7B8F90
       mov       [rdi+18],rcx
       mov       rcx,1A236400AD0
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
       call      qword ptr [7FF7DC3B5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1A236400AE0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,1A236400AE0
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
       call      qword ptr [7FF7DC7BD128]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC7BD968]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC7BD9B0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF7DC5CE718]
       mov       ecx,65
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC313D40
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7B4390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7B43A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF7DC8B6478]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC7BE238]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1A236400AF0
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
       call      qword ptr [7FF7DC9A4420]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1A220400218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC7BE628]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1A220400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7BE340]
       mov       edx,eax
       mov       rcx,1A236400AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC9A41E0]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC8BFEB8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC8B7570]
       int       3
M03_L23:
       call      qword ptr [7FF7DC9A4210]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC8B6250]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC7BCF18]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC7BE250]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC9A4468]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A4300]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A5248]
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
       call      qword ptr [7FF7DC3A5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC7ACDB0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC8AFB70]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7DC8A6460]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC9940F0]
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
       call      qword ptr [7FF7DC8AFB70]
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
       jmp       qword ptr [7FF7DC7AE208]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC7A8F60
       mov       [rdi+18],rcx
       mov       rcx,13A03402AC8
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
       call      qword ptr [7FF7DC3A5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,13A03402AD8
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,13A03402AD8
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
       call      qword ptr [7FF7DC7AD0F8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC7AD938]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC7AD968]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF7DC5BE6E8]
       mov       ecx,65
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC303D40
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A4348]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A4360]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF7DC8A6460]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC7AE208]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L20
       mov       rcx,13A03402AE8
       mov       rcx,[rcx]
       cmp       byte ptr [rcx+9D],0
       jne       near ptr M03_L21
M03_L15:
       mov       eax,[rbx+34]
       mov       [rbp-34],eax
       test      eax,5600000
       jne       near ptr M03_L23
       lea       rcx,[rbx+34]
       mov       edx,eax
       or        edx,4000000
       lock cmpxchg [rcx],edx
       cmp       eax,[rbp-34]
       jne       near ptr M03_L22
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
       call      qword ptr [7FF7DC994258]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L24
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L25
       mov       rdx,13A03400218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       jne       short M03_L19
M03_L18:
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M03_L19:
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC7AE5F8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
       jmp       short M03_L18
M03_L20:
       mov       rdx,13A03400230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L21:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7AE310]
       mov       edx,eax
       mov       rcx,13A03402AE8
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC994018]
       jmp       near ptr M03_L15
M03_L22:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC8AFD38]
       test      eax,eax
       jne       near ptr M03_L16
M03_L23:
       mov       ecx,18
       call      qword ptr [7FF7DC8A7558]
       int       3
M03_L24:
       call      qword ptr [7FF7DC994048]
       jmp       near ptr M03_L17
M03_L25:
       call      qword ptr [7FF7DC8A6238]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC7ACEE8]
       lea       rax,[M03_L18]
       add       rsp,28
       ret
; Total bytes of code 1090
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC7AE220]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC9942A0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC994120]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC995DB8]
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
       call      qword ptr [7FF7DC3A5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC7ACD68]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC8AFB70]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7DC8A6400]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC8AFF48]
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
       call      qword ptr [7FF7DC8AFB70]
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
       jmp       qword ptr [7FF7DC7AE1C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC7A8F18
       mov       [rdi+18],rcx
       mov       rcx,1E40E000AD0
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
M03_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L04
       call      qword ptr [7FF7DC3A5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1E40E000AE0
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,1E40E000AE0
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
       call      qword ptr [7FF7DC7AD0B0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC7AD8F0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC7AD938]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FF7DC5BE718]
       mov       ecx,65
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC303D40
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7A4318]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7A4330]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF7DC8A6400]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC7AE1C0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1E40E000AF0
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
       call      qword ptr [7FF7DC994240]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1E3F8000218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC7AE5B0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1E3F8000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC7AE2C8]
       mov       edx,eax
       mov       rcx,1E40E000AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC8AFFC0]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC8AFCF0]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC8A74F8]
       int       3
M03_L23:
       call      qword ptr [7FF7DC994000]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC8A61D8]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC7ACEA0]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC7AE1D8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC994078]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC994108]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC995200]
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
       call      qword ptr [7FF7DC2C5638]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC81C870]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC89FBB8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF7DC8963A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC9942B8]
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
       call      qword ptr [7FF7DC89FBB8]
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
       jmp       qword ptr [7FF7DC81DCC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC818A20
       mov       [rdi+18],rcx
       mov       rcx,1BD15C00AD0
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
       call      qword ptr [7FF7DC2C5638]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1BD15C00AE0
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,1BD15C00AE0
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
       call      qword ptr [7FF7DC81CBB8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC81D368]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC81D398]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FF7DC5BE268]
       mov       ecx,65
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC814048]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC814060]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF7DC8963A0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC81DCC8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1BD15C00AF0
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
       call      qword ptr [7FF7DC994408]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1BCFFC00218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC81E0B8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1BCFFC00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC81DDD0]
       mov       edx,eax
       mov       rcx,1BD15C00AF0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC9941C8]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC89FEA0]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC897540]
       int       3
M03_L23:
       call      qword ptr [7FF7DC9941F8]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC8961D8]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC81C9A8]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC81DCE0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC994450]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC9942E8]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC995218]
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
       call      qword ptr [7FF7DC2D7B28]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC9064C0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DC9A5458]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF7DC82C3A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DC9A58D8]
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
       call      qword ptr [7FF7DC9A5458]
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
       jmp       qword ptr [7FF7DC907930]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC902670
       mov       [rdi+18],rcx
       mov       rcx,2022D000B50
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
       call      qword ptr [7FF7DC2D7B28]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,2022D000B60
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,2022D000B60
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
       call      qword ptr [7FF7DC906808]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC907048]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC907090]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF7DC5CE238]
       mov       ecx,65
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC73FF78]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC73FF90]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF7DC82C3A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DC907930]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,2022D000B70
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
       call      qword ptr [7FF7DC9A5CC8]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,20217000218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DC907D08]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,20217000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DC9079F0]
       mov       edx,eax
       mov       rcx,2022D000B70
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DC9A5A40]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DC9A5740]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC82D470]
       int       3
M03_L23:
       call      qword ptr [7FF7DC9A5A70]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC82C030]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC9065F8]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DC907948]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DC9A5D10]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A5B60]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DC9A7660]
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
       call      qword ptr [7FF7DC3A5458]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF7DC98ED78]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF7DCA561C0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF7DC7372D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF7DCA567A8]
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
       call      qword ptr [7FF7DCA561C0]
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
       jmp       qword ptr [7FF7DCA541F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FF837597018]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FF837597020]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FF837598E90]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF837596FD0]; CORINFO_HELP_ASSIGN_REF
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
       mov       rcx,7FF7DC98AF28
       mov       [rdi+18],rcx
       mov       rcx,1939E800D58
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
       call      qword ptr [7FF7DC3A5458]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1939E800D68
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,1939E800D68
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
       call      qword ptr [7FF7DC98F0C0]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF7DC98F900]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF7DC98F948]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF7DC5BE718]
       mov       ecx,65
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC303D40
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC736580]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC736598]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF7DC7372D0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF7DCA541F8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1939E800D78
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
       call      qword ptr [7FF7DCA56A78]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,19388800218
       mov       rdx,[rdx]
       call      00007FF83BB5C9B0
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF7DCA545D0]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,19388800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF7DCA542E8]
       mov       edx,eax
       mov       rcx,1939E800D78
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF7DCA56820]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF7DCA56550]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF7DC844DC8]
       int       3
M03_L23:
       call      qword ptr [7FF7DCA56850]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF7DC737018]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF7DC98EEB0]
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
       call      qword ptr [7FF8375AFD78]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF7DCA54210]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF7DCA56AC0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF7DCA56910]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF7DCA57D68]
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
       call      qword ptr [7FF7DBF6F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF7DBF6F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBEB1098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF66850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF7DBF6F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF7DBEB1090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBEB1078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEB1080
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
       mov       r11,7FF7DBEB1088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEB1088
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
       jmp       qword ptr [7FF7DC3AF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF8F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF7DBF8F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBED1098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF86850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF7DBF8F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF7DBED1090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBED1078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBED1080
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
       mov       r11,7FF7DBED1088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBED1088
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
       jmp       qword ptr [7FF7DC3CF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF7F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF7DBF7F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBEC1098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF76850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF7DBF7F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF7DBEC1090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBEC1078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEC1080
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
       mov       r11,7FF7DBEC1088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEC1088
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
       jmp       qword ptr [7FF7DC3BF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF5F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBEA1098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF56850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF7DBF5F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF7DBEA1090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBEA1078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEA1080
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
       mov       r11,7FF7DBEA1088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEA1088
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
       jmp       qword ptr [7FF7DC39F060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF5F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBEA1098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF56850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF7DBF5F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF7DBEA1090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBEA1078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEA1080
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
       mov       r11,7FF7DBEA1088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEA1088
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
       jmp       qword ptr [7FF7DC39F060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF8F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF7DBF8F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBED1098
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF7DBF86850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF7DBF8F9D8]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF7DBED1090
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBED1078
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBED1080
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
       mov       r11,7FF7DBED1088
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBED1088
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
       jmp       qword ptr [7FF7DC3CF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF6F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBEB1318
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
       mov       r11,7FF7DBEB1310
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBEB12F8
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEB1300
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
       mov       r11,7FF7DBEB1308
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBEB1308
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
       jge       short M01_L06
       test      r8,r8
       je        short M01_L05
M01_L03:
       cmp       [r10],rcx
       je        short M01_L01
M01_L04:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L07
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L08
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L07:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L04
M01_L08:
       jmp       qword ptr [7FF7DC3AF060]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 123
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
       call      qword ptr [7FF7DBF4F930]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF7DBE91B88
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
       mov       r11,7FF7DBE91B80
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF7DBE91B68
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBE91B70
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
       mov       r11,7FF7DBE91B78
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF7DBE91B78
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
       jge       short M01_L06
       test      r8,r8
       je        short M01_L05
M01_L03:
       cmp       [r10],rcx
       je        short M01_L01
M01_L04:
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M01_L07
M01_L05:
       test      dword ptr [rax],500C0000
       jne       short M01_L08
       xor       edx,edx
       jmp       short M01_L01
M01_L06:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L00
M01_L07:
       cmp       [r10],rcx
       je        short M01_L01
       jmp       short M01_L04
M01_L08:
       jmp       qword ptr [7FF7DC38F030]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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
       call      qword ptr [7FF7DBF4F930]
       int       3
M00_L03:
       mov       r11,7FF7DBE91070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBE91078
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
       mov       r11,7FF7DBE91080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBE91080
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
       call      qword ptr [7FF7DBF7F930]
       int       3
M00_L03:
       mov       r11,7FF7DBEC1070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEC1078
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
       mov       r11,7FF7DBEC1080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEC1080
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
       call      qword ptr [7FF7DBF6F930]
       int       3
M00_L03:
       mov       r11,7FF7DBEB1070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEB1078
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
       mov       r11,7FF7DBEB1080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEB1080
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
       call      qword ptr [7FF7DBF7F930]
       int       3
M00_L03:
       mov       r11,7FF7DBEC1070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEC1078
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
       mov       r11,7FF7DBEC1080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEC1080
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
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L03:
       mov       r11,7FF7DBEA1070
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEA1078
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
       mov       r11,7FF7DBEA1080
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEA1080
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
       call      qword ptr [7FF7DBF4F930]
       int       3
M00_L03:
       mov       r11,7FF7DBE910B8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBE910C0
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
       mov       r11,7FF7DBE910C8
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBE910C8
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
       call      qword ptr [7FF7DBF5F930]
       int       3
M00_L03:
       mov       r11,7FF7DBEA1428
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEA1430
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
       mov       r11,7FF7DBEA1438
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEA1438
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
       call      qword ptr [7FF7DBF7F930]
       int       3
M00_L03:
       mov       r11,7FF7DBEC1B50
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEC1B58
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
       mov       r11,7FF7DBEC1B60
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEC1B60
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
       call      qword ptr [7FF7DC59E718]
       mov       ecx,65
       mov       rdx,7FF7DC4041B8
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E3D50
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4041B8
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC784330]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC784348]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBE91078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBE91080
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
       mov       r11,7FF7DBE91088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBE91088
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,211CE3C0008
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
       call      qword ptr [7FF7DC8A6970]
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
       call      qword ptr [7FF7DC5AE718]
       mov       ecx,65
       mov       rdx,7FF7DC4141B8
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4141B8
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794378]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794390]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBEA1078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEA1080
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
       mov       r11,7FF7DBEA1088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEA1088
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,24828030008
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
       call      qword ptr [7FF7DC8B69B8]
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
       call      qword ptr [7FF7DC5CE268]
       mov       ecx,65
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3140A0
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4341B8
       call      qword ptr [7FF7DBF7F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF7D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC73FF00]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC73FF18]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBEC1078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEC1080
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
       mov       r11,7FF7DBEC1088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEC1088
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF75818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F3949D0008
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
       call      qword ptr [7FF7DC8D69D0]
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
       call      qword ptr [7FF7DC5AE6E8]
       mov       ecx,65
       mov       rdx,7FF7DC4141B8
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4141B8
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC794348]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC794360]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBEA1078
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEA1080
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
       mov       r11,7FF7DBEA1088
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEA1088
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28002180008
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
       call      qword ptr [7FF7DC8B69D0]
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
       call      qword ptr [7FF7DC59E760]
       mov       ecx,65
       mov       rdx,7FF7DC4041B8
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E40A0
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4041B8
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7843C0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7843D8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBE90F10
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBE90F18
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
       mov       r11,7FF7DBE90F20
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBE90F20
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,17FC86A0008
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
       call      qword ptr [7FF7DC8A6A78]
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
       call      qword ptr [7FF7DC59E718]
       mov       ecx,65
       mov       rdx,7FF7DC4041B8
       call      qword ptr [7FF7DBF4F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2E3D40
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4041B8
       call      qword ptr [7FF7DBF4F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF4D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC784390]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7843A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBE91090
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBE91098
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
       mov       r11,7FF7DBE910A0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBE910A0
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF45818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1A510BD0008
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
       call      qword ptr [7FF7DC8A6A60]
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
       call      qword ptr [7FF7DC5BE238]
       mov       ecx,65
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC3040A0
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4241B8
       call      qword ptr [7FF7DBF6F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF6D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC814030]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC814048]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBEB1260
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEB1268
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
       mov       r11,7FF7DBEB1270
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEB1270
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF65818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A042300008
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
       call      qword ptr [7FF7DC8C6AD8]
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
       call      qword ptr [7FF7DC5AE718]
       mov       ecx,65
       mov       rdx,7FF7DC4141B8
       call      qword ptr [7FF7DBF5F210]
       mov       rbx,rax
       mov       ecx,1B77
       mov       rdx,7FF7DC2F3D40
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF7DC4141B8
       call      qword ptr [7FF7DBF5F210]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF7DBF5D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF7DC7265C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF7DC7265E0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF7DBEA1A68
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF7DBEA1A70
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
       mov       r11,7FF7DBEA1A78
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF7DBEA1A78
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
       call      00007FF83BB9AFE0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF7DBF55818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FEAE310008
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
       call      qword ptr [7FF7DC83ED78]
       int       3
; Total bytes of code 235
```

