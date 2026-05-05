## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,1998FC00A20
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
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
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
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,19979C00190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,19979C00170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L22
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L26
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L23
M00_L05:
       mov       r13,rax
M00_L06:
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
       mov       r8,1998FC00A30
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
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
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L30
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L27
       mov       esi,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L27
       cmp       r11d,ebx
       je        short M00_L16
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L27
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       je        short M00_L18
M00_L15:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L38
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L16:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L17
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L27
M00_L17:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L18:
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L19:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L39
M00_L20:
       mov       rcx,r12
       mov       r11,7FF9E6050E68
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L34
M00_L21:
       mov       ecx,2
       call      qword ptr [7FF9E68EC450]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L22:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
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
       call      qword ptr [7FF9E6485F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L25
M00_L24:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L05
M00_L26:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L27:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L28]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M00_L28:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L29
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L29:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L30:
       mov       r8,1998FC00A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E68E5338]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L27
       jmp       near ptr M00_L12
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L32]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M00_L32:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L33
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L33:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L34:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L15
M00_L35:
       mov       rcx,r12
       mov       r11,7FF9E6050E60
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L20
       jmp       near ptr M00_L46
M00_L36:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E68EE178]
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
       test      byte ptr [7FF9E68F9F48],1
       je        short M00_L44
M00_L41:
       mov       rcx,1998FC00AA0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1998FC00A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6106BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1998FC00A20
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       ecx,11
       call      qword ptr [7FF9E610F948]
       int       3
M00_L44:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L45:
       mov       rcx,rdi
       mov       r11,7FF9E6050E58
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L46:
       mov       rcx,r12
       mov       r11,7FF9E6050E70
       call      qword ptr [r11]
       jmp       near ptr M00_L39
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L47
       mov       rcx,rax
       mov       r11,7FF9E6050E70
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
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
       mov       rax,19979C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,19979C00170
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
       mov       r8,1998FC00A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68EC450]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68EC468]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1998FC00A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68E5338]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E686DDA0]
       vbroadcastsd ymm3,qword ptr [7FF9E686DDC0]
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
       vpand     ymm1,ymm1,[7FF9E686DDA0]
       vbroadcastsd ymm2,qword ptr [7FF9E686DDC0]
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
       vpand     xmm2,xmm2,[7FF9E686DDA0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E686DDC0]
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
       call      qword ptr [7FF9E68EC888]
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
       jmp       qword ptr [7FF9E6105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,1D6AAC00A20
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
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1D694C00190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1D694C00170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1D6AAC00A30
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       esi,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L26
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FF9E6060E60
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF9E68FC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E6495F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6495C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L28
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,1D6AAC00A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E68F5368]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6060E58
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E68FE1A8]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       test      byte ptr [7FF9E6909F48],1
       je        short M00_L43
M00_L40:
       mov       rcx,1D6AAC00AA0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1D6AAC00A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D6AAC00A20
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FF9E611F948]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L40
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E6060E68
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E6060E68
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
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
       mov       rax,1D694C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1D694C00170
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
       mov       r8,1D6AAC00A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68FC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68FC498]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6495C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1D6AAC00A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68F5368]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E687C840]
       vbroadcastsd ymm3,qword ptr [7FF9E687C860]
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
       vpand     ymm1,ymm1,[7FF9E687C840]
       vbroadcastsd ymm2,qword ptr [7FF9E687C860]
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
       vpand     xmm2,xmm2,[7FF9E687C840]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E687C860]
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
       call      qword ptr [7FF9E68FC8B8]
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
       jmp       qword ptr [7FF9E6115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,1D269002A18
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
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1D269000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1D269000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1D269002A28
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       esi,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L26
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FF9E6070CD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF9E690C480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FF9E612D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E64A5F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E64A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L28
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,1D269002A28
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E6905368]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6070CD0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E690E1A8]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       test      byte ptr [7FF9E6919F48],1
       je        short M00_L43
M00_L40:
       mov       rcx,1D269002A98
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1D269002A08
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6126BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D269002A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FF9E612F948]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L40
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6070CC8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E6070CE0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E6070CE0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
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
       mov       rax,1D269000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1D269000170
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
       mov       r8,1D269002A28
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E690C480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E612D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E690C498]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E64A5C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1D269002A28
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E6905368]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E688A080]
       vbroadcastsd ymm3,qword ptr [7FF9E688A0A0]
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
       vpand     ymm1,ymm1,[7FF9E688A080]
       vbroadcastsd ymm2,qword ptr [7FF9E688A0A0]
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
       vpand     xmm2,xmm2,[7FF9E688A080]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E688A0A0]
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
       call      qword ptr [7FF9E690C8B8]
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
       jmp       qword ptr [7FF9E6125C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,25115000A20
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
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,250FF000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,250FF000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,25115000A30
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       ebx,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L26
       cmp       r11d,esi
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       r13d,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       r13d,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FF9E6060CD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF9E68FC4B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E6495F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6495C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L28
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,25115000A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E68F52D8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6060CD0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E68FE1D8]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       test      byte ptr [7FF9E6909930],1
       je        short M00_L43
M00_L40:
       mov       rcx,25115000AA0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L41:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,25115000A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25115000A20
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L42:
       mov       ecx,11
       call      qword ptr [7FF9E611F948]
       int       3
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L40
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6060CC8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E6060CE0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E6060CE0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1778
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
       mov       rax,250FF000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,250FF000170
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
       mov       r8,25115000A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68FC4B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68FC4C8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6495C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,25115000A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68F52D8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62B51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E687A100]
       vbroadcastsd ymm3,qword ptr [7FF9E687A120]
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
       vpand     ymm1,ymm1,[7FF9E687A100]
       vbroadcastsd ymm2,qword ptr [7FF9E687A120]
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
       vpand     xmm2,xmm2,[7FF9E687A100]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E687A120]
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
       call      qword ptr [7FF9E68FC8E8]
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
       jmp       qword ptr [7FF9E6115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,1296E802A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1296E800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,1296E800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,1296E802A28
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       esi,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rsi],0
       jne       near ptr M00_L26
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FF9E6050CD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF9E68EC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E6485F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L28
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,1296E802A28
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E68E5290]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6050CD0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E68EE1C0]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       mov       ecx,11
       call      qword ptr [7FF9E610F948]
       int       3
M00_L40:
       test      byte ptr [7FF9E68F9A58],1
       je        short M00_L43
M00_L41:
       mov       rcx,1296E802A98
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1296E802A08
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6106BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1296E802A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6050CC8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E6050CE0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E6050CE0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
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
       mov       rax,1296E800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1296E800170
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
       mov       r8,1296E802A28
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68EC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68EC498]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1296E802A28
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68E5290]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E6869D40]
       vbroadcastsd ymm3,qword ptr [7FF9E6869D60]
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
       vpand     ymm1,ymm1,[7FF9E6869D40]
       vbroadcastsd ymm2,qword ptr [7FF9E6869D60]
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
       vpand     xmm2,xmm2,[7FF9E6869D40]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6869D60]
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
       call      qword ptr [7FF9E68EC8B8]
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
       jmp       qword ptr [7FF9E6105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,28FCA802A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L18
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L20
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L20
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,28FCA800190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,28FCA800170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L21
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L25
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L22
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,28FCA802A28
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L26
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L26
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rsi,edx
       movzx     esi,word ptr [r10+rsi*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L26
       mov       ebx,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rbx],0
       jne       near ptr M00_L26
       cmp       r11d,esi
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       near ptr M00_L26
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       r13d,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       r13d,0FFFFFFFF
       jne       short M00_L17
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       near ptr M00_L26
M00_L16:
       mov       r13d,ecx
       jmp       short M00_L13
M00_L17:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L18:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L19:
       mov       rcx,r12
       mov       r11,7FF9E6030CD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L20:
       mov       ecx,2
       call      qword ptr [7FF9E68CC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L21:
       call      qword ptr [7FF9E60ED4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L22:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L23
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E6465F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L24
M00_L23:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6465C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L24:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L25:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L26:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62851A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L27]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M00_L27:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L28
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L28:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L29:
       mov       r8,28FCA802A28
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E68C5290]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L26
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62851A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       r13d,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L17
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6030CD0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L19
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E68CE1C0]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       mov       ecx,11
       call      qword ptr [7FF9E60EF948]
       int       3
M00_L40:
       test      byte ptr [7FF9E68D9930],1
       je        short M00_L43
M00_L41:
       mov       rcx,28FCA802A98
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,28FCA802A08
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E60E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28FCA802A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6030CC8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E6030CE0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E6030CE0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1778
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
       mov       rax,28FCA800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,28FCA800170
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
       mov       r8,28FCA802A28
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68CC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E60ED4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68CC498]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6465C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62851A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,28FCA802A28
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68C5290]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62851A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E6849D40]
       vbroadcastsd ymm3,qword ptr [7FF9E6849D60]
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
       vpand     ymm1,ymm1,[7FF9E6849D40]
       vbroadcastsd ymm2,qword ptr [7FF9E6849D60]
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
       vpand     xmm2,xmm2,[7FF9E6849D40]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6849D60]
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
       call      qword ptr [7FF9E68CC8B8]
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
       jmp       qword ptr [7FF9E60E5C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,25D10000A20
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L21
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L23
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,25CFA000190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,25CFA000170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L24
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L28
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L25
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,25D10000A30
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rsi,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L17
       cmp       [rsi],sil
       mov       ebx,r11d
       sar       ebx,5
       mov       ebx,[rsi+rbx*4]
       bt        ebx,r11d
       jae       near ptr M00_L17
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L17
       mov       esi,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rsi],0
       jne       short M00_L17
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       short M00_L17
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       near ptr M00_L20
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       short M00_L17
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L18]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L18:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L19
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L19:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L20:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L21:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L22:
       mov       rcx,r12
       mov       r11,7FF9E6060CD8
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L23:
       mov       ecx,2
       call      qword ptr [7FF9E68CC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L24:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L26
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E6495F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L27
M00_L26:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6495C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L27:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L28:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,25D10000A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E68C4EB8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L17
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L20
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6060CD0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L22
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E68CE1C0]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       mov       ecx,11
       call      qword ptr [7FF9E611F948]
       int       3
M00_L40:
       test      byte ptr [7FF9E68D99D0],1
       je        short M00_L43
M00_L41:
       mov       rcx,25D10000AA0
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,25D10000A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,25D10000A20
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6060CC8
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E6060CE0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E6060CE0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1777
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
       mov       rax,25CFA000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,25CFA000170
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
       mov       r8,25D10000A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68CC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68CC498]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6495C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,25D10000A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68C4EB8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E68598E0]
       vbroadcastsd ymm3,qword ptr [7FF9E6859900]
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
       vpand     ymm1,ymm1,[7FF9E68598E0]
       vbroadcastsd ymm2,qword ptr [7FF9E6859900]
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
       vpand     xmm2,xmm2,[7FF9E68598E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6859900]
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
       call      qword ptr [7FF9E68CC8B8]
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
       jmp       qword ptr [7FF9E6115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,2484FC00AC8
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L42
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L39
       xor       r15d,r15d
       mov       [rbp-40],r15
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rcx
       jne       near ptr M00_L44
       mov       r13d,[rdi+8]
       test      r13d,r13d
       je        near ptr M00_L40
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       dword ptr [r12+8],0FFFFFFFF
       mov       [r12+0C],r13d
       lea       rcx,[r12+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
M00_L01:
       mov       [rbp-0C8],r12
M00_L02:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       r12,[rbp-0C8]
       cmp       [r12],rcx
       jne       near ptr M00_L34
       mov       ecx,[r12+8]
       inc       ecx
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L21
       mov       [r12+8],ecx
       mov       ecx,[r12+8]
       cmp       ecx,[r12+0C]
       jae       near ptr M00_L35
       mov       rcx,[r12+10]
       mov       eax,[r12+8]
       cmp       eax,[rcx+8]
       jae       near ptr M00_L36
       mov       rdx,[rcx+rax*8+10]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L33
       mov       r12,[rbp-0C8]
       mov       rdi,[rdx+30]
       cmp       [rdi],dil
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],2
       jle       near ptr M00_L23
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        near ptr M00_L23
M00_L03:
       mov       r13,[rax+10]
       test      r13,r13
       jne       short M00_L04
       mov       rax,24839C00190
       mov       r13,[rax]
       test      r13,r13
       jne       short M00_L04
       mov       rax,24839C00170
       mov       r13,[rax]
       test      r13,r13
       je        near ptr M00_L24
M00_L04:
       mov       rcx,offset MT_System.Globalization.CultureInfo
       cmp       [r13],rcx
       jne       near ptr M00_L28
       mov       rax,[r13+8]
       test      rax,rax
       je        near ptr M00_L25
M00_L05:
       mov       r13,rax
M00_L06:
       mov       dword ptr [rbp-44],61
       cmp       [r13],r13b
       lea       rcx,[rdi+0C]
       mov       edi,[rdi+8]
       cmp       byte ptr [r13+2C],0
       je        near ptr M00_L30
       mov       [rbp-60],rcx
       mov       rax,rcx
       lea       r8,[rbp-44]
       mov       [rbp-68],r8
       mov       [rbp-70],rax
       lea       r10,[rbp-44]
       mov       [rbp-78],r10
       mov       r8,2484FC00288
       mov       r8,[r8]
       add       r8,8
       lea       rdx,[rbp-44]
       lea       r9,[rbp-44]
       add       r9,2
       lea       r11,[rbp-44]
       cmp       r11,r9
       je        short M00_L08
M00_L07:
       movzx     r11d,word ptr [rdx]
       cmp       [r8],r8b
       lea       rbx,[r8+20]
       cmp       r11d,100
       jge       near ptr M00_L17
       cmp       [rbx],bl
       mov       esi,r11d
       sar       esi,5
       mov       ebx,[rbx+rsi*4]
       bt        ebx,r11d
       jae       near ptr M00_L17
       add       rdx,2
       cmp       rdx,r9
       jne       short M00_L07
M00_L08:
       test      edi,edi
       jle       near ptr M00_L29
       mov       r8d,edi
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L12
M00_L09:
       xor       edx,edx
       mov       r9d,ecx
M00_L10:
       movsxd    r11,r9d
       movzx     r11d,word ptr [rax+r11*2]
       movsxd    rbx,edx
       movzx     ebx,word ptr [r10+rbx*2]
       cmp       r11d,80
       mov       r10,[rbp-78]
       jge       near ptr M00_L17
       mov       esi,r11d
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+rsi],0
       jne       short M00_L17
       cmp       r11d,ebx
       je        short M00_L15
       lea       edx,[rdi-1]
       cmp       r9d,edx
       jge       short M00_L11
       movsxd    r9,r9d
       cmp       word ptr [rax+r9*2+2],80
       jae       short M00_L17
M00_L11:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L09
M00_L12:
       mov       ebx,0FFFFFFFF
M00_L13:
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       [rbp-68],rcx
M00_L14:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-58],rcx
       cmp       ebx,0FFFFFFFF
       jne       near ptr M00_L20
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L15:
       inc       edx
       inc       r9d
       test      edx,edx
       jle       near ptr M00_L10
       cmp       r9d,edi
       jge       short M00_L16
       movsxd    r8,r9d
       cmp       word ptr [rax+r8*2],80
       mov       rax,[rbp-70]
       jae       short M00_L17
M00_L16:
       mov       ebx,ecx
       jmp       short M00_L13
M00_L17:
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],rcx
       mov       rcx,[r13+20]
       mov       rdx,r10
       mov       r8d,1
       mov       r9,rax
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L18]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L18:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L19
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L19:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L13
M00_L20:
       mov       r15,[rbp-40]
       add       r15,1
       jo        near ptr M00_L37
       mov       [rbp-40],r15
       mov       r14,[rbp-0C0]
       jmp       near ptr M00_L02
M00_L21:
       mov       ecx,[r12+0C]
       mov       [r12+8],ecx
       jmp       near ptr M00_L38
M00_L22:
       mov       rcx,r12
       mov       r11,7FF9E6051198
       call      qword ptr [r11]
       mov       rdx,rax
       jmp       near ptr M00_L33
M00_L23:
       mov       ecx,2
       call      qword ptr [7FF9E67F52F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L24:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       r13,rax
       jmp       near ptr M00_L04
M00_L25:
       mov       rcx,[r13+30]
       cmp       byte ptr [rcx+1B1],0
       jne       short M00_L26
       mov       rcx,offset MT_System.Globalization.CompareInfo
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-0D8],rax
       mov       rdx,[r13+40]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp-0D8]
       mov       rdx,r13
       call      qword ptr [7FF9E6485F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0D8]
       jmp       short M00_L27
M00_L26:
       mov       rcx,[r13+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
M00_L27:
       lea       rcx,[r13+8]
       mov       [rbp-0D0],rax
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       r13,[rbp-0D0]
       mov       rax,r13
       jmp       near ptr M00_L05
M00_L28:
       mov       rcx,r13
       mov       rax,[r13]
       mov       rax,[rax+48]
       call      qword ptr [rax+30]
       mov       r13,rax
       jmp       near ptr M00_L06
M00_L29:
       mov       r8,2484FC00288
       mov       r8,[r8]
       add       r8,8
       mov       edx,edi
       call      qword ptr [7FF9E692D848]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       rax,[rbp-70]
       mov       r10,[rbp-78]
       jne       near ptr M00_L17
       jmp       near ptr M00_L12
M00_L30:
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A8],rax
       lea       rax,[M00_L31]
       mov       [rbp-98],rax
       lea       rax,[rbp-0B8]
       mov       rsi,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L31:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L32
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L32:
       mov       rcx,[rbp-0B0]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L14
M00_L33:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        near ptr M00_L02
       mov       r12,[rbp-0C8]
       jmp       near ptr M00_L20
M00_L34:
       mov       rcx,r12
       mov       r11,7FF9E6051190
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M00_L22
       jmp       near ptr M00_L45
M00_L35:
       mov       ecx,[r12+8]
       call      qword ptr [7FF9E692F390]
       int       3
M00_L36:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L37:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L38:
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
M00_L39:
       mov       ecx,11
       call      qword ptr [7FF9E610F948]
       int       3
M00_L40:
       test      byte ptr [7FF9E6981830],1
       je        short M00_L43
M00_L41:
       mov       rcx,2484FC00B08
       mov       r12,[rcx]
       jmp       near ptr M00_L01
M00_L42:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2484FC00AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountFastLongCountWithPredicate>b__5_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6106BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2484FC00AC8
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L43:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M00_L41
M00_L44:
       mov       rcx,rdi
       mov       r11,7FF9E6051188
       call      qword ptr [r11]
       mov       r12,rax
       jmp       near ptr M00_L01
M00_L45:
       mov       rcx,r12
       mov       r11,7FF9E60511A0
       call      qword ptr [r11]
       jmp       near ptr M00_L38
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L46
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       mov       rax,[rbp-0C8]
       cmp       [rax],rcx
       je        short M00_L46
       mov       rcx,rax
       mov       r11,7FF9E60511A0
       call      qword ptr [r11]
M00_L46:
       nop
       add       rsp,38
       ret
; Total bytes of code 1776
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
       mov       rax,24839C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,24839C00170
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
       mov       r8,2484FC00288
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E67F52F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E67F5308]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2484FC00288
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E692D848]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M03_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M04_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M05_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M05_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M05_L04
       mov       rbx,[rbp-18]
       jmp       short M05_L02
M05_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L04:
       call      M05_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M05_L05
       xor       esi,esi
       jmp       short M05_L06
M05_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M05_L06:
       test      rsi,rsi
       jne       short M05_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M05_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M05_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M05_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M05_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M05_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M05_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M05_L12:
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
       vpand     ymm1,ymm1,[7FF9E69BF6E0]
       vbroadcastsd ymm3,qword ptr [7FF9E69BF700]
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
       vpand     ymm1,ymm1,[7FF9E69BF6E0]
       vbroadcastsd ymm2,qword ptr [7FF9E69BF700]
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
       vpand     xmm2,xmm2,[7FF9E69BF6E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E69BF700]
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
       call      qword ptr [7FF9E67F5728]
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
       jmp       qword ptr [7FF9E6105C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,20C65400A00
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       short M00_L06
       nop       dword ptr [rax]
M00_L02:
       mov       rcx,rdi
       mov       r11,7FF9E6060BA8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6060BB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6060BB8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6060BC0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
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
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
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
       jae       near ptr M00_L34
M00_L09:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L12
       nop       dword ptr [rax+rax]
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
       jge       near ptr M00_L06
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L16:
       mov       rdx,[r12+rdi*8]
       mov       rcx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       cmp       [r14+18],rcx
       jne       near ptr M00_L43
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
M00_L17:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,20C4F400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,20C4F400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L18:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L19:
       mov       dword ptr [rbp-40],61
       cmp       [rdx],dl
       mov       rax,[rbp-0D0]
       lea       rcx,[rax+0C]
       mov       eax,[rax+8]
       mov       [rbp-0D8],rdx
       cmp       byte ptr [rdx+2C],0
       je        near ptr M00_L40
       mov       [rbp+10],rbx
       mov       [rbp-0B8],eax
       mov       [rbp-58],rcx
       mov       r10,rcx
       lea       r8,[rbp-40]
       mov       [rbp-60],r8
       mov       [rbp-68],r10
       lea       r9,[rbp-40]
       mov       [rbp-70],r9
       mov       r8,20C65400A18
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
       jge       near ptr M00_L34
       cmp       [r12],r12b
       mov       r13d,ebx
       sar       r13d,5
       mov       r13d,[r12+r13*4]
       bt        r13d,ebx
       jae       near ptr M00_L34
       add       r11,2
       cmp       r11,rsi
       jne       short M00_L20
M00_L21:
       test      eax,eax
       jle       near ptr M00_L37
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
       jge       near ptr M00_L34
       mov       [rbp-3C],r15d
       mov       r13d,esi
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L38
       cmp       esi,r12d
       je        near ptr M00_L08
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L24
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L39
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
       mov       rdx,20C654009F8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,20C65400A00
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF9E611FA20]
       int       3
M00_L27:
       call      qword ptr [7FF9E611F570]
       int       3
M00_L28:
       mov       ecx,2
       call      qword ptr [7FF9E68D7690]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L29:
       call      qword ptr [7FF9E611D590]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L18
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
       call      qword ptr [7FF9E6476010]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E6475D28]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L19
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L19
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L36
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L12
M00_L37:
       mov       r8,20C65400A18
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E67ED7B8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L11
M00_L38:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L34
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L34
M00_L40:
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L41]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L41:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L42
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L42:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L13
M00_L43:
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
       je        short M00_L44
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6060BC0
       call      qword ptr [r11]
M00_L44:
       nop
       add       rsp,38
       ret
; Total bytes of code 1772
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
       mov       rax,20C4F400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,20C4F400170
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
       mov       r8,20C65400A18
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68D7690]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E611D590]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68D76A8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6475D28]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,20C65400A18
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E67ED7B8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E68D6F28]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E6814880]
       vbroadcastsd ymm3,qword ptr [7FF9E68148A0]
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
       vpand     ymm1,ymm1,[7FF9E6814880]
       vbroadcastsd ymm2,qword ptr [7FF9E68148A0]
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
       vpand     xmm2,xmm2,[7FF9E6814880]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E68148A0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,2196F400A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L24
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L19
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L10
       jmp       near ptr M00_L28
M00_L02:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L17
       cmp       ebx,eax
       jge       short M00_L03
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L35
M00_L03:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L06
M00_L04:
       mov       [rbp-3C],r15d
M00_L05:
       mov       ebx,0FFFFFFFF
M00_L06:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L07:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L09
M00_L08:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L09:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L23
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L10:
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
M00_L11:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L12
       mov       rcx,21959400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L12
       mov       rcx,21959400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L12:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L13:
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
       mov       r8,2196F400A30
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L15
M00_L14:
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
       jne       short M00_L14
M00_L15:
       test      eax,eax
       jle       near ptr M00_L38
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L04
M00_L16:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L17:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L35
       mov       [rbp-3C],r15d
       mov       r13d,esi
       mov       r15,7FFA44069AC8
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L39
       cmp       esi,r12d
       je        near ptr M00_L02
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L18
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L40
M00_L18:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L05
       mov       r15d,[rbp-3C]
       jmp       short M00_L16
M00_L19:
       mov       rcx,rdi
       mov       r11,7FF9E6030E30
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L20:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6030E38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L22
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6030E40
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L20
       add       r15d,1
       jo        short M00_L21
       jmp       short M00_L20
M00_L21:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L22:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6030E48
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L23:
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
M00_L24:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2196F400A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E60E6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2196F400A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF9E60EF948]
       int       3
M00_L27:
       call      qword ptr [7FF9E60EF498]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L23
M00_L29:
       mov       ecx,2
       call      qword ptr [7FF9E68CC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L11
M00_L30:
       call      qword ptr [7FF9E60ED4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L12
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
       call      qword ptr [7FF9E6465F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E6465C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L13
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L13
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
       mov       rax,7FF9E62851A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L36]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M00_L36:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L37
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L37:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L06
M00_L38:
       mov       r8,2196F400A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E68C52A8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L35
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L05
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
       mov       rax,7FF9E62851A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L42]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M00_L42:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L43
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L43:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L07
M00_L44:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L09
       jmp       near ptr M00_L08
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L45
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6030E48
       call      qword ptr [r11]
M00_L45:
       nop
       add       rsp,38
       ret
; Total bytes of code 1773
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
       mov       rax,21959400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,21959400170
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
       mov       r8,2196F400A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68CC480]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E60ED4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68CC498]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6465C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62851A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2196F400A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68C52A8]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62851A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62851C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E68CC8B8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E684C780]
       vbroadcastsd ymm3,qword ptr [7FF9E684C7A0]
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
       vpand     ymm1,ymm1,[7FF9E684C780]
       vbroadcastsd ymm2,qword ptr [7FF9E684C7A0]
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
       vpand     xmm2,xmm2,[7FF9E684C780]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E684C7A0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,1DED3800A00
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L24
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L16
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L26
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L11
       jmp       near ptr M00_L27
M00_L02:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L06
M00_L03:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L04:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L34
       mov       r12d,esi
       mov       r13,7FFA44069AC8
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L34
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L05
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L34
M00_L05:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L03
M00_L06:
       mov       ebx,0FFFFFFFF
M00_L07:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L08:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L10
M00_L09:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L10:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L20
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L11:
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
M00_L12:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L13
       mov       rcx,1DEBD800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L13
       mov       rcx,1DEBD800170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L13:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L14:
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
       mov       r8,1DED3800A18
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L02
       nop       dword ptr [rax]
M00_L15:
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
       jne       short M00_L15
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       mov       r11,7FF9E6070CA8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L17:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070CB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070CB8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L17
       add       r15d,1
       jo        short M00_L18
       jmp       short M00_L17
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070CC0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L20:
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
M00_L21:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L22:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L04
       cmp       ebx,eax
       jge       short M00_L23
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L34
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L07
M00_L24:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1DED38009F8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6126BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1DED3800A00
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L25:
       mov       ecx,11
       call      qword ptr [7FF9E612F948]
       int       3
M00_L26:
       call      qword ptr [7FF9E612F498]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L20
M00_L28:
       mov       ecx,2
       call      qword ptr [7FF9E68D7F30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L12
M00_L29:
       call      qword ptr [7FF9E612D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L13
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
       call      qword ptr [7FF9E64A5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E64A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L14
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L14
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L36
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L07
M00_L37:
       mov       r8,1DED3800A18
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E68D4B88]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       jmp       near ptr M00_L06
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L40
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L08
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L10
       jmp       near ptr M00_L09
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070CC0
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1739
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
       mov       rax,1DEBD800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,1DEBD800170
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
       mov       r8,1DED3800A18
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68D7F30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E612D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68D7F48]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E64A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,1DED3800A18
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68D4B88]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E68DC378]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E68653E0]
       vbroadcastsd ymm3,qword ptr [7FF9E6865400]
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
       vpand     ymm1,ymm1,[7FF9E68653E0]
       vbroadcastsd ymm2,qword ptr [7FF9E6865400]
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
       vpand     xmm2,xmm2,[7FF9E68653E0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6865400]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,2141BC00A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L26
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L04
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L22
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L13
       jmp       near ptr M00_L28
M00_L02:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6050CC0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L03:
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
M00_L04:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       short M00_L01
M00_L05:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       mov       r15d,[rbp-3C]
       jle       near ptr M00_L20
       cmp       ebx,eax
       jge       short M00_L06
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L36
M00_L06:
       mov       ebx,ecx
       mov       [rbp-3C],r15d
       jmp       short M00_L09
M00_L07:
       mov       [rbp-3C],r15d
M00_L08:
       mov       ebx,0FFFFFFFF
M00_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L10:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L12
M00_L11:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L12:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L03
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L13:
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
M00_L14:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L15
       mov       rcx,21405C00190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L15
       mov       rcx,21405C00170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L30
M00_L15:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L34
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L31
M00_L16:
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
       mov       r8,2141BC00A30
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       je        short M00_L18
       mov       [rbp-3C],r15d
M00_L17:
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
       jne       short M00_L17
       mov       r15d,[rbp-3C]
M00_L18:
       test      eax,eax
       jle       near ptr M00_L40
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        near ptr M00_L07
M00_L19:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L20:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r12,r11d
       movzx     r12d,word ptr [r9+r12*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L36
       mov       [rbp-3C],r15d
       mov       r15d,esi
       mov       r13,7FFA44069AC8
       cmp       byte ptr [r15+r13],0
       jne       near ptr M00_L41
       cmp       esi,r12d
       je        near ptr M00_L05
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L21
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L42
M00_L21:
       inc       ecx
       cmp       ecx,r8d
       je        near ptr M00_L08
       mov       r15d,[rbp-3C]
       jmp       short M00_L19
M00_L22:
       mov       rcx,rdi
       mov       r11,7FF9E6050CA8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L23:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6050CB0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L02
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6050CB8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L23
       add       r15d,1
       jo        short M00_L24
       jmp       short M00_L23
M00_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2141BC00A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6106BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2141BC00A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       mov       ecx,11
       call      qword ptr [7FF9E610F948]
       int       3
M00_L27:
       call      qword ptr [7FF9E610F498]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L03
M00_L29:
       mov       ecx,2
       call      qword ptr [7FF9E68BC468]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L14
M00_L30:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L15
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
       call      qword ptr [7FF9E6485F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L16
M00_L34:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L16
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L38
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L38:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L09
M00_L39:
       mov       r15d,[rbp-3C]
       jmp       near ptr M00_L36
M00_L40:
       mov       r8,2141BC00A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E68B4E88]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L36
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L08
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L45
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L45:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L10
M00_L46:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L12
       jmp       near ptr M00_L11
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L47
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6050CC0
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1794
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
       mov       rax,21405C00190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,21405C00170
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
       mov       r8,2141BC00A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68BC468]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E610D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68BC480]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6485C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2141BC00A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68B4E88]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62A51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62A51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E68BC8A0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E6849740]
       vbroadcastsd ymm3,qword ptr [7FF9E6849760]
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
       vpand     ymm1,ymm1,[7FF9E6849740]
       vbroadcastsd ymm2,qword ptr [7FF9E6849760]
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
       vpand     xmm2,xmm2,[7FF9E6849740]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6849760]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,226A1400A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L25
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L24
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L21
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       near ptr M00_L16
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L26
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L12
       jmp       near ptr M00_L27
       nop       dword ptr [rax]
M00_L02:
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
       jne       short M00_L02
M00_L03:
       test      eax,eax
       jle       near ptr M00_L37
       mov       r8d,eax
       sub       r8d,1
       inc       r8d
       xor       ecx,ecx
       test      r8d,r8d
       je        short M00_L07
M00_L04:
       xor       r11d,r11d
       mov       ebx,ecx
M00_L05:
       movsxd    rsi,ebx
       movzx     esi,word ptr [r10+rsi*2]
       movsxd    r15,r11d
       movzx     r15d,word ptr [r9+r15*2]
       cmp       esi,80
       mov       r9,[rbp-70]
       jge       near ptr M00_L34
       mov       r12d,esi
       mov       r13,7FFA44069AC8
       cmp       byte ptr [r12+r13],0
       jne       near ptr M00_L34
       cmp       esi,r15d
       je        near ptr M00_L22
       lea       r11d,[rax-1]
       cmp       ebx,r11d
       jge       short M00_L06
       movsxd    r11,ebx
       cmp       word ptr [r10+r11*2+2],80
       jae       near ptr M00_L34
M00_L06:
       inc       ecx
       cmp       ecx,r8d
       jne       short M00_L04
M00_L07:
       mov       ebx,0FFFFFFFF
M00_L08:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       [rbp-60],rcx
M00_L09:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-50],rdx
       cmp       ebx,0FFFFFFFF
       je        short M00_L11
M00_L10:
       mov       r15d,[rbp-3C]
       inc       r15d
       mov       [rbp-3C],r15d
M00_L11:
       inc       edi
       mov       r13d,[rbp-0B4]
       cmp       edi,r13d
       mov       r12,[rbp-0F8]
       mov       r14,[rbp-0C0]
       jge       near ptr M00_L20
       mov       rbx,[rbp+10]
       mov       r15d,[rbp-3C]
M00_L12:
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
M00_L13:
       mov       rcx,[rdx+10]
       test      rcx,rcx
       jne       short M00_L14
       mov       rcx,2268B400190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L14
       mov       rcx,2268B400170
       mov       rcx,[rcx]
       test      rcx,rcx
       je        near ptr M00_L29
M00_L14:
       mov       rdx,offset MT_System.Globalization.CultureInfo
       cmp       [rcx],rdx
       jne       near ptr M00_L33
       mov       rdx,[rcx+8]
       test      rdx,rdx
       je        near ptr M00_L30
M00_L15:
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
       mov       r8,226A1400A30
       mov       r8,[r8]
       add       r8,8
       lea       r11,[rbp-40]
       lea       rsi,[rbp-40]
       add       rsi,2
       lea       rbx,[rbp-40]
       cmp       rbx,rsi
       mov       [rbp-3C],r15d
       je        near ptr M00_L03
       jmp       near ptr M00_L02
M00_L16:
       mov       rcx,rdi
       mov       r11,7FF9E6040CA8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L17:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040CB0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L19
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040CB8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L17
       add       r15d,1
       jo        short M00_L18
       jmp       short M00_L17
M00_L18:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L19:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040CC0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L20:
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
M00_L21:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
M00_L22:
       inc       r11d
       inc       ebx
       test      r11d,r11d
       jle       near ptr M00_L05
       cmp       ebx,eax
       jge       short M00_L23
       movsxd    r8,ebx
       cmp       word ptr [r10+r8*2],80
       mov       r10,[rbp-68]
       jae       near ptr M00_L34
M00_L23:
       mov       ebx,ecx
       jmp       near ptr M00_L08
M00_L24:
       mov       ecx,11
       call      qword ptr [7FF9E60FF948]
       int       3
M00_L25:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,226A1400A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E60F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,226A1400A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L26:
       call      qword ptr [7FF9E60FF498]
       int       3
M00_L27:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L20
M00_L28:
       mov       ecx,2
       call      qword ptr [7FF9E68DC4B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L13
M00_L29:
       call      qword ptr [7FF9E60FD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
       mov       rcx,rax
       jmp       near ptr M00_L14
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
       call      qword ptr [7FF9E6475F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L32
M00_L31:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E6475C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       jmp       near ptr M00_L15
M00_L33:
       mov       rdx,[rcx]
       mov       rdx,[rdx+48]
       call      qword ptr [rdx+30]
       mov       rdx,rax
       jmp       near ptr M00_L15
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
       mov       rax,7FF9E62951A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L35]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62951C0]
M00_L35:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L36
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L36:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L08
M00_L37:
       mov       r8,226A1400A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E68D53B0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
       test      eax,eax
       mov       eax,[rbp-0B8]
       mov       r9,[rbp-70]
       mov       r10,[rbp-68]
       jne       near ptr M00_L34
       jmp       near ptr M00_L07
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
       mov       rax,7FF9E62951A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62951C0]
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L40
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       rdx,[rbp-0A8]
       mov       [rsi+8],rdx
       mov       ebx,eax
       mov       [rbp-3C],r15d
       jmp       near ptr M00_L09
M00_L41:
       mov       r14,[rbp-0C0]
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       je        near ptr M00_L11
       jmp       near ptr M00_L10
       sub       rsp,38
       vzeroupper
       cmp       qword ptr [rbp-0C8],0
       je        short M00_L42
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040CC0
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1739
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
       mov       rax,2268B400190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2268B400170
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
       mov       r8,226A1400A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68DC4B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E60FD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68DC4C8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6475C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62951A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62951C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,226A1400A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68D53B0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62951A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62951C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E68DC8E8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E6859BC0]
       vbroadcastsd ymm3,qword ptr [7FF9E6859BE0]
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
       vpand     ymm1,ymm1,[7FF9E6859BC0]
       vbroadcastsd ymm2,qword ptr [7FF9E6859BE0]
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
       vpand     xmm2,xmm2,[7FF9E6859BC0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6859BE0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,286D0800A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L26
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L25
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        near ptr M00_L27
       add       r12,10
M00_L01:
       mov       [rbp-0F8],r12
       mov       [rbp-0B4],r13d
       xor       edi,edi
       cmp       edi,r13d
       jl        near ptr M00_L16
       jmp       near ptr M00_L28
M00_L02:
       mov       rcx,rdi
       mov       r11,7FF9E6070E20
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070E28
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070E30
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6070E38
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
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
M00_L07:
       lea       r12,[rdi+10]
       mov       r13d,[rdi+8]
       jmp       near ptr M00_L01
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
       jge       near ptr M00_L06
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
       mov       rcx,286BA800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L18
       mov       rcx,286BA800170
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
       mov       r8,286D0800A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E612F948]
       int       3
M00_L26:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,286D0800A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6126BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,286D0800A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L27:
       call      qword ptr [7FF9E612F498]
       int       3
M00_L28:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L06
M00_L29:
       mov       ecx,2
       call      qword ptr [7FF9E690C4B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L17
M00_L30:
       call      qword ptr [7FF9E612D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E64A5F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L33
M00_L32:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E64A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L37]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L37:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L38
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,286D0800A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E69053B0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L44]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M00_L44:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L45
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF9E6070E38
       call      qword ptr [r11]
M00_L47:
       nop
       add       rsp,38
       ret
; Total bytes of code 1789
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
       mov       rax,286BA800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,286BA800170
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
       mov       r8,286D0800A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E690C4B0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E612D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E690C4C8]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E64A5C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,286D0800A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E69053B0]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62C51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       call      qword ptr [7FF9E62C51C0]
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E690C8E8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E688C6A0]
       vbroadcastsd ymm3,qword ptr [7FF9E688C6C0]
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
       vpand     ymm1,ymm1,[7FF9E688C6A0]
       vbroadcastsd ymm2,qword ptr [7FF9E688C6C0]
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
       vpand     xmm2,xmm2,[7FF9E688C6A0]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E688C6C0]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,246F4800A18
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L29
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L28
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        short M00_L01
       add       r12,10
       jmp       near ptr M00_L08
M00_L01:
       call      qword ptr [7FF9E60FF498]
       int       3
M00_L02:
       mov       rcx,rdi
       mov       r11,7FF9E6040FC8
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040FD0
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040FD8
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6040FE0
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
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
       mov       r13,7FFA44069AC8
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
       jge       near ptr M00_L06
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
       mov       rcx,246DE800190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,246DE800170
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
       mov       r8,246F4800A30
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
       mov       rax,7FF9E62951A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L26]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L27
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L27:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,11
       call      qword ptr [7FF9E60FF948]
       int       3
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,246F4800A10
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E60F6BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,246F4800A18
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L06
M00_L31:
       mov       ecx,2
       call      qword ptr [7FF9E68CC498]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FF9E60FD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E6475F08]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E6475C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       r8,246F4800A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E68C6550]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62951A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L40
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF9E6040FE0
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1732
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
       mov       rax,246DE800190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,246DE800170
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
       mov       r8,246F4800A30
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E68CC498]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E60FD4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E68CC4B0]
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6475C20]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62951A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,246F4800A30
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E68C6550]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62951A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E68CC8D0]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E6882100]
       vbroadcastsd ymm3,qword ptr [7FF9E6882120]
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
       vpand     ymm1,ymm1,[7FF9E6882100]
       vbroadcastsd ymm2,qword ptr [7FF9E6882120]
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
       vpand     xmm2,xmm2,[7FF9E6882100]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E6882120]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdi,[rbx+278]
       mov       rcx,2D119000AC0
       mov       r14,[rcx]
       test      r14,r14
       je        near ptr M00_L29
M00_L00:
       mov       [rbp-0C0],r14
       test      rdi,rdi
       je        near ptr M00_L28
       xor       r15d,r15d
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person[]
       cmp       [rdi],rax
       je        near ptr M00_L07
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       cmp       [rdi],rax
       jne       short M00_L02
       mov       r13d,[rdi+10]
       mov       r12,[rdi+8]
       cmp       [r12+8],r13d
       jb        short M00_L01
       add       r12,10
       jmp       near ptr M00_L08
M00_L01:
       call      qword ptr [7FF9E611F498]
       int       3
M00_L02:
       mov       rcx,rdi
       mov       r11,7FF9E6061280
       call      qword ptr [r11]
       mov       [rbp-0C8],rax
M00_L03:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6061288
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L05
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6061290
       call      qword ptr [r11]
       mov       rdx,rax
       mov       rcx,[r14+8]
       call      qword ptr [r14+18]
       test      eax,eax
       je        short M00_L03
       add       r15d,1
       jo        short M00_L04
       jmp       short M00_L03
M00_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L05:
       mov       rcx,[rbp-0C8]
       mov       r11,7FF9E6061298
       call      qword ptr [r11]
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
M00_L06:
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
       mov       r13,7FFA44069AC8
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
       jge       near ptr M00_L06
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
       mov       rcx,2D103000190
       mov       rcx,[rcx]
       test      rcx,rcx
       jne       short M00_L21
       mov       rcx,2D103000170
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
       mov       r8,2D119000288
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L26]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L26:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L27
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M00_L27:
       mov       rcx,[rbp-0A8]
       mov       [rsi+8],rcx
       mov       ebx,eax
       jmp       near ptr M00_L15
M00_L28:
       mov       ecx,11
       call      qword ptr [7FF9E611F948]
       int       3
M00_L29:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Models.RefTypes.Person, System.Boolean>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,2D119000AB8
       mov       rdx,[rdx]
       mov       rcx,r14
       mov       r8,offset DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<>c.<CountCountWithPredicate>b__2_0(DotNetTips.Spargine.Tester.Models.RefTypes.Person)
       call      qword ptr [7FF9E6116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2D119000AC0
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L30:
       mov       [rbp-3C],r15d
       mov       [rbp+10],rbx
       jmp       near ptr M00_L06
M00_L31:
       mov       ecx,2
       call      qword ptr [7FF9E67F5380]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rdx,rax
       jmp       near ptr M00_L20
M00_L32:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E6495F38]; System.Globalization.CompareInfo.InitSort(System.Globalization.CultureInfo)
       mov       rax,[rbp-0F0]
       mov       rdx,rax
       jmp       short M00_L35
M00_L34:
       mov       rcx,[rbp-0E0]
       mov       rcx,[rcx+40]
       call      qword ptr [7FF9E6495C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       r8,2D119000288
       mov       r8,[r8]
       add       r8,8
       mov       edx,eax
       call      qword ptr [7FF9E694D938]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-0A0],rax
       lea       rax,[M00_L39]
       mov       [rbp-90],rax
       lea       rax,[rbp-0B0]
       mov       rsi,[rbp-78]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M00_L39:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M00_L40
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r11,7FF9E6061298
       call      qword ptr [r11]
M00_L42:
       nop
       add       rsp,38
       ret
; Total bytes of code 1732
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
       mov       rax,2D103000190
       mov       rdi,[rax]
       test      rdi,rdi
       jne       short M01_L01
       mov       rax,2D103000170
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
       mov       r8,2D119000288
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
       mov       r13,7FFA44069AC8
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
       call      qword ptr [7FF9E67F5380]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M01_L00
M01_L14:
       call      qword ptr [7FF9E611D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FF9E67F5398]; System.Globalization.CompareInfo..ctor(System.Globalization.CultureInfo)
       jmp       short M01_L17
M01_L16:
       mov       rcx,[rdi+40]
       call      qword ptr [7FF9E6495C50]; System.Globalization.CultureInfo.GetCultureInfo(System.String)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L20]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L20:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L21
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
M01_L21:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       mov       r13d,eax
       jmp       near ptr M01_L09
M01_L22:
       mov       r8,2D119000288
       mov       r8,[r8]
       add       r8,8
       mov       edx,ebx
       call      qword ptr [7FF9E694D938]; System.Buffers.IndexOfAnyAsciiSearcher.IndexOfAnyCore[[System.Boolean, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Negate, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+Default, System.Private.CoreLib],[System.Buffers.SearchValues+FalseConst, System.Private.CoreLib],[System.Buffers.IndexOfAnyAsciiSearcher+ContainsAnyResultMapper`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int32, AsciiState ByRef)
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
       mov       rax,7FF9E62B51A0
       mov       [rbp-88],rax
       lea       rax,[M01_L24]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA45F7F3F0
       call      rax
M01_L24:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA46053A10],0
       je        short M01_L25
       call      qword ptr [7FFA46041648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FF9E67F57B8]
       int       3
; Total bytes of code 44
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFA44CC47E8]
       mov       rbx,rax
       mov       rsi,rbx
       call      qword ptr [7FFA44CDB9F8]
       mov       rdx,rax
       test      rsi,rsi
       je        short M04_L00
       mov       rcx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA44CDCBA8]
       mov       rax,[rbx]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L00:
       call      qword ptr [7FFA44CDA3D0]
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
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rdx,rdi
M05_L00:
       lea       rcx,[rsi+10]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA44CC4480]
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
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        near ptr M06_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       call      qword ptr [7FFA44CDB9E8]; Precode of System.Globalization.CultureInfo.get_CachedCulturesByName()
       mov       [rbp-28],rax
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       je        short M06_L01
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L00
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L00:
       mov       dword ptr [rbp-1C],1
       lea       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       call      qword ptr [7FFA44CEAB70]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryGetValue(System.__Canon, System.__Canon ByRef)
       test      eax,eax
       je        short M06_L04
       mov       rbx,[rbp-18]
       jmp       short M06_L02
M06_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L02:
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,rbx
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L03:
       mov       rcx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rcx]
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L04:
       call      M06_L10
       nop
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFA44CDB4E8]; Precode of System.Globalization.CultureData.GetCultureData(System.String, Boolean)
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L05
       xor       esi,esi
       jmp       short M06_L06
M06_L05:
       call      qword ptr [7FFA44CCE970]
       mov       rsi,rax
       lea       rcx,[rsi+30]
       mov       rdx,rbx
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      qword ptr [7FFA44CDB510]; Precode of System.Globalization.CultureData.get_CultureName()
       lea       rcx,[rsi+40]
       mov       rdx,rax
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+60],0
M06_L06:
       test      rsi,rsi
       jne       short M06_L07
       call      qword ptr [7FFA44CCE978]
       mov       rbx,rax
       call      qword ptr [7FFA44CDB8B8]
       mov       r9,rax
       mov       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rdx,[rdx]
       mov       r8,[rbp+10]
       mov       rcx,rbx
       call      qword ptr [7FFA44CDBA18]
       mov       rcx,rbx
       call      qword ptr [7FFA44CC3FC0]; CORINFO_HELP_THROW
       int       3
M06_L07:
       mov       [rbp-18],rsi
       mov       rcx,[rbp-18]
       mov       byte ptr [rcx+60],1
       mov       rcx,[rbp-18]
       mov       rcx,[rcx+40]
       call      qword ptr [7FFA44CDC400]; Precode of System.Globalization.TextInfo.ToLowerAsciiInvariant(System.String)
       mov       [rbp+10],rax
       mov       rax,[rbp-28]
       mov       [rbp-30],rax
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       test      rax,rax
       jne       short M06_L08
       xor       ecx,ecx
       call      qword ptr [7FFA44CD71F0]
       int       3
M06_L08:
       mov       rcx,rax
       call      qword ptr [7FFA44CDCBB8]
       test      eax,eax
       jne       short M06_L09
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCBC8]
M06_L09:
       mov       dword ptr [rbp-1C],1
       mov       r8,[rbp-18]
       mov       rcx,[rbp-28]
       mov       rdx,[rbp+10]
       xor       r9d,r9d
       call      qword ptr [7FFA44CEAB00]; Precode of System.Collections.Generic.Dictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryInsert(System.__Canon, System.__Canon, System.Collections.Generic.InsertionBehavior)
       nop
       mov       rcx,[rbp-28]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       rax,[rbp-18]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rbp
       ret
M06_L10:
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L11
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L11:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-1C],0
       je        short M06_L12
       mov       rcx,[rbp-30]
       call      qword ptr [7FFA44CDCC18]; Precode of System.Threading.Monitor.Exit(System.Object)
M06_L12:
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
       vpand     ymm1,ymm1,[7FF9E69D1F60]
       vbroadcastsd ymm3,qword ptr [7FF9E69D1F80]
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
       vpand     ymm1,ymm1,[7FF9E69D1F60]
       vbroadcastsd ymm2,qword ptr [7FF9E69D1F80]
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
       vpand     xmm2,xmm2,[7FF9E69D1F60]
       vpshufb   xmm0,xmm0,xmm1
       vmovsd    xmm1,qword ptr [7FF9E69D1F80]
       vpshufb   xmm1,xmm1,xmm2
       vpand     xmm0,xmm1,xmm0
       vxorps    xmm1,xmm1,xmm1
       vpcmpeqb  xmm0,xmm1,xmm0
       vptest    xmm0,xmm0
       je        near ptr M07_L01
       jmp       near ptr M07_L02
; Total bytes of code 351
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E64857A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E68E5218]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E68EFD80]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF9E68EDCE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E69A41F8]
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
       call      qword ptr [7FF9E68EFD80]
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
       jmp       qword ptr [7FF9E68E66A0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E68E13F8
       mov       [rdi+18],rcx
       mov       rcx,1C84FC02A10
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
M03_L03:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L04
       call      qword ptr [7FF9E64857A0]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1C84FC02A20
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,1C84FC02A20
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
       call      qword ptr [7FF9E68E5590]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E68E5DD0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68E5E00]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FF9E66AF510]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E4FE0
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68ED590]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68ED5A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF9E68EDCE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E68E66A0]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1C84FC02A30
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
       call      qword ptr [7FF9E69A4558]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1C84FC00218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E68E6A90]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1C84FC00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68E67C0]
       mov       edx,eax
       mov       rcx,1C84FC02A30
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E69A4300]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E69A4048]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E68EF078]
       int       3
M03_L23:
       call      qword ptr [7FF9E69A4330]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E68EEE80]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E68E5350]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E68E66B8]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69A45A0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E69A43F0]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69A54B8]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E63ACB70]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E68B4DC8]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E68BFD20]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF9E68BDCE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E69A4168]
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
       call      qword ptr [7FF9E68BFD20]
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
       jmp       qword ptr [7FF9E68B6250]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E68B0FA8
       mov       [rdi+18],rcx
       mov       rcx,174AA000A18
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
       call      qword ptr [7FF9E63ACB70]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,174AA000A28
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,174AA000A28
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
       call      qword ptr [7FF9E68B5140]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E68B59C8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68B59F8]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9E66AF090]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E5370
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68BD9E0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68BD9F8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF9E68BDCE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E68B6250]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,174AA000A38
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
       call      qword ptr [7FF9E69A4390]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,17494000218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E68B6640]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,17494000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68B6388]
       mov       edx,eax
       mov       rcx,174AA000A38
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E69A42A0]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E68BFFD8]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E68BF060]
       int       3
M03_L23:
       call      qword ptr [7FF9E69A42D0]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E68BEE68]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E68B4F00]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E68B6268]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69A4540]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E69A43C0]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69A5488]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E62CFD08]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E6894DC8]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E689FD80]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF9E689DC98]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E69843C0]
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
       call      qword ptr [7FF9E689FD80]
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
       jmp       qword ptr [7FF9E6896250]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E6890FA8
       mov       [rdi+18],rcx
       mov       rcx,1D5C3800A18
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
       call      qword ptr [7FF9E62CFD08]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1D5C3800A28
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,1D5C3800A28
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
       call      qword ptr [7FF9E6895140]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E6895980]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68959B0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9E668F078]
       mov       ecx,65
       mov       rdx,7FF9E64EB700
       call      qword ptr [7FF9E60EF228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63C54F0
       call      qword ptr [7FF9E60EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E64EB700
       call      qword ptr [7FF9E60EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E6985398]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E689EE98]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF9E689DC98]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E6896250]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1D5C3800A38
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
       call      qword ptr [7FF9E6984558]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1D5AD800218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E6896640]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1D5AD800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68963E8]
       mov       edx,eax
       mov       rcx,1D5C3800A38
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E6984300]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E6984048]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E689F030]
       int       3
M03_L23:
       call      qword ptr [7FF9E6984330]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E689EE20]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E6894F00]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E6896268]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69845A0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E69843F0]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69854A0]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E64757A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E68D5188]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E68DFDC8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF9E68DDCF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E69942D0]
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
       call      qword ptr [7FF9E68DFDC8]
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
       jmp       qword ptr [7FF9E68D6610]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E68D1368
       mov       [rdi+18],rcx
       mov       rcx,2A36A800A18
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
       call      qword ptr [7FF9E64757A0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,2A36A800A28
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,2A36A800A28
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
       call      qword ptr [7FF9E68D5500]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E68D5D40]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68D5D88]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9E669F528]
       mov       ecx,65
       mov       rdx,7FF9E64FB700
       call      qword ptr [7FF9E60FF228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63D4FE0
       call      qword ptr [7FF9E60FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E64FB700
       call      qword ptr [7FF9E60FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68DD5A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68DD5C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF9E68DDCF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E68D6610]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L20
       mov       rcx,2A36A800A38
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
       call      qword ptr [7FF9E69945A0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L24
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L25
       mov       rdx,2A354800218
       mov       rdx,[rdx]
       call      00007FFA45D45920
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
       call      qword ptr [7FF9E68D6A00]; System.Threading.Tasks.Task.RunContinuations(System.Object)
       jmp       short M03_L18
M03_L20:
       mov       rdx,2A354800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L21:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68D67A8]
       mov       edx,eax
       mov       rcx,2A36A800A38
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E6994348]
       jmp       near ptr M03_L15
M03_L22:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E6994090]
       test      eax,eax
       jne       near ptr M03_L16
M03_L23:
       mov       ecx,18
       call      qword ptr [7FF9E68DF090]
       int       3
M03_L24:
       call      qword ptr [7FF9E6994378]
       jmp       near ptr M03_L17
M03_L25:
       call      qword ptr [7FF9E68DEE98]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E68D52C0]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E68D6628]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69945E8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E6994438]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69954E8]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E638C9C0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E68C5290]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E68CFDB0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF9E68CDD88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E6984378]
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
       call      qword ptr [7FF9E68CFDB0]
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
       jmp       qword ptr [7FF9E68C6718]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E68C1470
       mov       [rdi+18],rcx
       mov       rcx,1A753C00A18
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
       call      qword ptr [7FF9E638C9C0]; System.Threading.Thread.InitializeCurrentThread()
M03_L04:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1A753C00A28
       mov       rsi,[rcx]
M03_L05:
       test      rsi,rsi
       je        short M03_L07
       mov       rcx,1A753C00A28
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
       call      qword ptr [7FF9E68C5608]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E68C5E48]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68C5E90]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
       jmp       near ptr M03_L18
M03_L10:
       call      qword ptr [7FF9E668F558]
       mov       ecx,65
       mov       rdx,7FF9E64EB700
       call      qword ptr [7FF9E60EF228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63C5370
       call      qword ptr [7FF9E60EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E64EB700
       call      qword ptr [7FF9E60EF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60ED9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68CD650]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68CD668]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF9E68CDD88]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L03
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L05
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E68C6718]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L01
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1A753C00A38
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
       call      qword ptr [7FF9E69845A0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1A73DC00218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E68C6B08]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1A73DC00230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68C6880]
       mov       edx,eax
       mov       rcx,1A753C00A38
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E69843C0]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E6984060]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E68CF108]
       int       3
M03_L23:
       call      qword ptr [7FF9E69843F0]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E68CEF10]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E68C53C8]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E68C6730]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69845E8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E6984468]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69854A0]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E64857A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E68E5260]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E68EFDC8]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF9E68EDCF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E69A4408]
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
       call      qword ptr [7FF9E68EFDC8]
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
       jmp       qword ptr [7FF9E68E66E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E68E1440
       mov       [rdi+18],rcx
       mov       rcx,2AECA000A18
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
       call      qword ptr [7FF9E64857A0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,2AECA000A28
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,2AECA000A28
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
       call      qword ptr [7FF9E68E55D8]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E68E5E18]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68E5E60]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9E66AF528]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E4FE0
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68ED5A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68ED5C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF9E68EDCF8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E68E66E8]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,2AECA000A38
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
       call      qword ptr [7FF9E69A45A0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,2AEB4000218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E68E6AD8]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,2AEB4000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68E6838]
       mov       edx,eax
       mov       rcx,2AECA000A38
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E69A4348]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E69A4090]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E68EF108]
       int       3
M03_L23:
       call      qword ptr [7FF9E69A4378]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E68EEF10]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E68E5398]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E68E6700]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69A45E8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E69A4438]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69A54B8]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E64857A0]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E68D6CA0]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E69B4AB0]
       jmp       short M00_L04
M00_L08:
       mov       ecx,4
       call      qword ptr [7FF9E68DDCE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E69B50E0]
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
       call      qword ptr [7FF9E69B4AB0]
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
       jmp       qword ptr [7FF9E68DC150]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E68D2E80
       mov       [rdi+18],rcx
       mov       rcx,1AB7F000A18
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
       call      qword ptr [7FF9E64857A0]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1AB7F000A28
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,1AB7F000A28
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
       call      qword ptr [7FF9E68D7018]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E68D7888]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E68D78D0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9E66AF510]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E4FE0
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68DD590]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68DD5A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,4
       call      qword ptr [7FF9E68DDCE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E68DC150]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1AB7F000A38
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
       call      qword ptr [7FF9E69B5278]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,1AB69000218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E68DC528]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,1AB69000230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E68DC1C8]
       mov       edx,eax
       mov       rcx,1AB7F000A38
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E69B5020]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E69B4D68]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E68DF7B0]
       int       3
M03_L23:
       call      qword ptr [7FF9E69B5050]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E68DF5A0]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E68D6DD8]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E68DC168]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69B52C0]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E69B5110]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E69B6190]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FF9E62DFD20]; System.Threading.Thread.InitializeCurrentThread()
       mov       rbx,rax
M00_L01:
       mov       [rbp-40],rbx
       mov       rdx,[rbx+8]
       mov       [rbp-48],rdx
       mov       rdx,[rbx+10]
       mov       [rbp-50],rdx
       lea       rcx,[rbp-38]
       call      qword ptr [7FF9E691DB00]; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1.MoveNext()
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
       call      qword ptr [7FF9E6994E28]
       jmp       short M00_L04
M00_L08:
       mov       ecx,3
       call      qword ptr [7FF9E67C52F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L09:
       lea       rcx,[rbp-28]
       call      qword ptr [7FF9E6995428]
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
       call      qword ptr [7FF9E6994E28]
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
       jmp       qword ptr [7FF9E691EF88]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
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
       call      qword ptr [7FFA44CC4030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0A0]
       call      qword ptr [rax]
       lea       rcx,[rbp-98]
       call      qword ptr [7FFA44CC4038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       rbx,[rbp-40]
       call      qword ptr [7FFA44CC5EB8]
       lea       rcx,[rax+10]
       mov       rdx,[rbp-40]
       call      qword ptr [7FFA44CC3FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        near ptr M03_L10
       mov       rcx,offset MT_System.Func<System.Int32>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FF9E6919CE0
       mov       [rdi+18],rcx
       mov       rcx,1750F800AC0
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
       call      qword ptr [7FF9E62DFD20]; System.Threading.Thread.InitializeCurrentThread()
M03_L01:
       mov       rsi,[rax+8]
       test      rsi,rsi
       jne       near ptr M03_L12
       mov       rcx,1750F800AD0
       mov       rsi,[rcx]
M03_L02:
       test      rsi,rsi
       je        short M03_L04
       mov       rcx,1750F800AD0
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
       call      qword ptr [7FF9E691DE78]; System.Threading.Tasks.Task.ScheduleAndStart(Boolean)
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
       call      qword ptr [7FF9E691E6D0]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].GetStateMachineBox[[DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark+<CountCountAsync>d__1, DotNetTips.Spargine.Extensions.BenchmarkTests]](<CountCountAsync>d__1 ByRef, System.Threading.Tasks.Task`1<System.Threading.Tasks.VoidTaskResult> ByRef)
       mov       rdx,rax
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9E691E718]; System.Runtime.CompilerServices.AsyncTaskMethodBuilder`1[[System.Threading.Tasks.VoidTaskResult, System.Private.CoreLib]].AwaitUnsafeOnCompleted[[System.Runtime.CompilerServices.ConfiguredTaskAwaitable`1+ConfiguredTaskAwaiter[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](ConfiguredTaskAwaiter<Int32> ByRef, System.Runtime.CompilerServices.IAsyncStateMachineBox)
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
       call      qword ptr [7FF9E669F090]
       mov       ecx,65
       mov       rdx,7FF9E64FB700
       call      qword ptr [7FF9E60FF228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63D54F0
       call      qword ptr [7FF9E60FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E64FB700
       call      qword ptr [7FF9E60FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E67C4AF8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E67C4B10]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L11:
       mov       ecx,3
       call      qword ptr [7FF9E67C52F0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L12:
       xor       ecx,ecx
       cmp       byte ptr [rsi+18],0
       cmovne    rsi,rcx
       jmp       near ptr M03_L02
M03_L13:
       mov       rcx,rdx
       xor       edx,edx
       call      qword ptr [7FF9E691EF88]; System.Runtime.CompilerServices.TaskAwaiter.HandleNonSuccessAndDebuggerNotification(System.Threading.Tasks.Task, System.Threading.Tasks.ConfigureAwaitOptions)
       jmp       near ptr M03_L09
M03_L14:
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       mov       rbx,[rcx]
       test      rbx,rbx
       je        near ptr M03_L19
       mov       rcx,1750F800AE0
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
       call      qword ptr [7FF9E69956B0]
       mov       rcx,[rsi+10]
       test      rcx,rcx
       jne       near ptr M03_L23
M03_L17:
       lea       rcx,[rbx+20]
       test      rcx,rcx
       je        near ptr M03_L24
       mov       rdx,174F9800218
       mov       rdx,[rdx]
       call      00007FFA45D45920
       test      rax,rax
       je        short M03_L18
       mov       rcx,rbx
       mov       rdx,rax
       call      qword ptr [7FF9E691F360]; System.Threading.Tasks.Task.RunContinuations(System.Object)
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
       mov       rdx,174F9800230
       mov       rdx,[rdx]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M03_L18
M03_L20:
       mov       rcx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9E691F000]
       mov       edx,eax
       mov       rcx,1750F800AE0
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FF9E69954A0]
       jmp       near ptr M03_L15
M03_L21:
       mov       rcx,rbx
       mov       edx,4000000
       mov       r8d,5600000
       call      qword ptr [7FF9E69951D0]
       test      eax,eax
       jne       near ptr M03_L16
M03_L22:
       mov       ecx,18
       call      qword ptr [7FF9E67CF540]
       int       3
M03_L23:
       call      qword ptr [7FF9E69954D0]
       jmp       near ptr M03_L17
M03_L24:
       call      qword ptr [7FF9E67CF330]
       int       3
       sub       rsp,28
       mov       rdx,rcx
       mov       rcx,[rbp+10]
       mov       dword ptr [rcx+8],0FFFFFFFE
       add       rcx,10
       call      qword ptr [7FF9E691DC38]
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
       call      qword ptr [7FFA44CDCCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FF9E691EFA0]; System.Threading.Tasks.Task.InternalWait(Int32, System.Threading.CancellationToken)
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
       call      qword ptr [7FF9E69956F8]
       jmp       short M05_L01
M05_L04:
       test      sil,2
       jne       short M05_L05
       mov       rcx,rbx
       call      qword ptr [7FF9E6995590]
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FF9E6996B98]
       jmp       short M05_L02
; Total bytes of code 124
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60FF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E60FF948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6040E60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60F6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E60FF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6040E58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6040E40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6040E48
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
       mov       r11,7FF9E6040E50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6040E50
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
       jmp       qword ptr [7FF9E647F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E611F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E611F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6060E60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E6116850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E611F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6060E58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6060E40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6060E48
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
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6060E50
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
       jmp       qword ptr [7FF9E649F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60FF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E60FF948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6040E60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60F6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E60FF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6040E58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6040E40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6040E48
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
       mov       r11,7FF9E6040E50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6040E50
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
       jmp       qword ptr [7FF9E647F3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60EF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E60EF948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6030E60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E60EF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6030E58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6030E40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6030E48
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
       mov       r11,7FF9E6030E50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6030E50
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
       jmp       qword ptr [7FF9E646F3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E612F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E612F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6070E60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E6126850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E612F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6070E58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6070E40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6070E48
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
       mov       r11,7FF9E6070E50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6070E50
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
       jmp       qword ptr [7FF9E64AF3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60EF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E60EF948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6030E60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E60E6850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E60EF9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6030E58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6030E40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6030E48
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
       mov       r11,7FF9E6030E50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6030E50
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
       jmp       qword ptr [7FF9E646F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
       test      rsi,rsi
       je        short M00_L01
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E610F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
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
       call      qword ptr [7FF9E610F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E6050F60
       call      qword ptr [r11]
       mov       edi,eax
       jmp       short M00_L00
M00_L03:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Linq.Enumerable+Iterator<DotNetTips.Spargine.Tester.Models.RefTypes.Person>
       call      qword ptr [7FF9E6106850]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       call      qword ptr [7FF9E610F9F0]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L05
       mov       rcx,rax
       mov       r11,7FF9E6050F58
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E6050F40
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6050F48
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
       mov       r11,7FF9E6050F50
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E6050F50
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
       jmp       qword ptr [7FF9E648F3D8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountEnumerableExtensionsCount()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rsi,[rbx+278]
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
       call      qword ptr [7FF9E610F948]
       int       3
M00_L02:
       mov       rcx,rax
       mov       r11,7FF9E60512C0
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
       mov       r11,7FF9E60512B8
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L00
M00_L05:
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9E60512A0
       call      qword ptr [r11]
       mov       [rbp-20],rax
M00_L06:
       mov       rcx,[rbp-20]
       mov       r11,7FF9E60512A8
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
       mov       r11,7FF9E60512B0
       call      qword ptr [r11]
       jmp       near ptr M00_L00
       sub       rsp,28
       cmp       qword ptr [rbp-20],0
       je        short M00_L09
       mov       rcx,[rbp-20]
       mov       r11,7FF9E60512B0
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
       je        short M01_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M01_L06
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M01_L04
       cmp       [r10],rcx
       jne       short M01_L01
M01_L00:
       mov       rax,rdx
       ret
M01_L01:
       cmp       [r10+8],rcx
       je        short M01_L00
       jmp       short M01_L03
M01_L02:
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L03:
       cmp       [r10+10],rcx
       je        short M01_L00
       cmp       [r10+18],rcx
       je        short M01_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M01_L02
       test      r8,r8
       je        short M01_L06
M01_L04:
       cmp       [r10],rcx
       je        short M01_L00
M01_L05:
       add       r10,8
       dec       r8
       test      r8,r8
       jle       short M01_L06
       cmp       [r10],rcx
       je        short M01_L00
       jmp       short M01_L05
M01_L06:
       test      dword ptr [rax],500C0000
       jne       short M01_L07
       xor       edx,edx
       jmp       short M01_L00
M01_L07:
       jmp       qword ptr [7FF9E648F3A8]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 125
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

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E610F948]
       int       3
M00_L03:
       mov       r11,7FF9E6050E38
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6050E40
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
       mov       r11,7FF9E6050E48
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6050E48
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E611F948]
       int       3
M00_L03:
       mov       r11,7FF9E6060E40
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6060E48
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
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E610F948]
       int       3
M00_L03:
       mov       r11,7FF9E6050E38
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6050E40
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
       mov       r11,7FF9E6050E48
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6050E48
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E611F948]
       int       3
M00_L03:
       mov       r11,7FF9E6060E38
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6060E40
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
       mov       r11,7FF9E6060E48
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6060E48
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E60FF948]
       int       3
M00_L03:
       mov       r11,7FF9E6040E40
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6040E48
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
       mov       r11,7FF9E6040E50
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6040E50
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E611F948]
       int       3
M00_L03:
       mov       r11,7FF9E6060E40
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6060E48
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
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E610F948]
       int       3
M00_L03:
       mov       r11,7FF9E6050F30
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6050F38
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
       mov       r11,7FF9E6050F40
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6050F40
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E60FF948]
       int       3
M00_L03:
       mov       r11,7FF9E6041280
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6041288
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
       mov       r11,7FF9E6041290
       call      qword ptr [r11]
       jmp       short M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6041290
       call      qword ptr [r11]
M00_L08:
       nop
       add       rsp,28
       ret
; Total bytes of code 223
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66BF030]
       mov       ecx,65
       mov       rdx,7FF9E651B700
       call      qword ptr [7FF9E611F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63F4FE0
       call      qword ptr [7FF9E611F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E611D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E651B700
       call      qword ptr [7FF9E611F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E611D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68C7EB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68C7ED0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6060E40
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6060E48
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
       mov       r11,7FF9E6060E50
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6060E50
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1F688D20008
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
       call      qword ptr [7FF9E68CD9F8]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66CF510]
       mov       ecx,65
       mov       rdx,7FF9E652B700
       call      qword ptr [7FF9E612F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E6404FE0
       call      qword ptr [7FF9E612F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E612D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E652B700
       call      qword ptr [7FF9E612F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E612D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E6907AC8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E6907AE0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6070E40
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6070E48
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
       mov       r11,7FF9E6070E50
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6070E50
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6125818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6125818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25734410008
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
       call      qword ptr [7FF9E690DA58]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66AF048]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E4FE0
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68B7EE8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68B7F00]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6050E40
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6050E48
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
       mov       r11,7FF9E6050E50
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6050E50
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1CF0D9D0008
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
       call      qword ptr [7FF9E68BDA40]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E669F510]
       mov       ecx,65
       mov       rdx,7FF9E64FB700
       call      qword ptr [7FF9E60FF228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63D4FE0
       call      qword ptr [7FF9E60FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E64FB700
       call      qword ptr [7FF9E60FF228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E60FD9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68D7AB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68D7AC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6040CB8
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6040CC0
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
       mov       r11,7FF9E6040CC8
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6040CC8
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E60F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E60F5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A3DC2E0008
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
       call      qword ptr [7FF9E68DDA40]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66AF510]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E4FE0
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E68E7AB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E68E7AC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6050CD0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6050CD8
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
       mov       r11,7FF9E6050CE0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6050CE0
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,29CAABC0008
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
       call      qword ptr [7FF9E68EDA40]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66CF510]
       mov       ecx,65
       mov       rdx,7FF9E652B700
       call      qword ptr [7FF9E612F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E6404FE0
       call      qword ptr [7FF9E612F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E612D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E652B700
       call      qword ptr [7FF9E612F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E612D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E6907AB0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E6907AC8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6070E50
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6070E58
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
       mov       r11,7FF9E6070E60
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6070E60
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6125818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6125818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,1FACCBB0008
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
       call      qword ptr [7FF9E690DA40]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66AF510]
       mov       ecx,65
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63E4FE0
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E650B700
       call      qword ptr [7FF9E610F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E610D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E67EDD58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E67EDD70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E6051020
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E6051028
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
       mov       r11,7FF9E6051030
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E6051030
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,28864960008
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
       call      qword ptr [7FF9E68DE268]
       int       3
; Total bytes of code 244
```

## .NET 10.0.7 (10.0.7, 10.0.726.21808), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.EnumerableExtensionsCountCollectionBenchmark.CountFastLongCount()
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+278]
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
       call      qword ptr [7FF9E66BF558]
       mov       ecx,65
       mov       rdx,7FF9E651B700
       call      qword ptr [7FF9E611F228]
       mov       rbx,rax
       mov       ecx,1B69
       mov       rdx,7FF9E63F54F0
       call      qword ptr [7FF9E611F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E611D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9E651B700
       call      qword ptr [7FF9E611F228]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9E611D9C8]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9E67F4BB8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9E67F4BD0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L03:
       mov       r11,7FF9E60612B0
       call      qword ptr [r11]
       mov       rcx,rax
       mov       [rbp-18],rcx
M00_L04:
       mov       rcx,[rbp-18]
       mov       r11,[rcx]
       mov       r11,7FF9E60612B8
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
       mov       r11,7FF9E60612C0
       call      qword ptr [r11]
       jmp       near ptr M00_L01
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp-18],0
       je        short M00_L08
       mov       rcx,[rbp-18]
       mov       r11,7FF9E60612C0
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
       call      00007FFA45D99F20
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9E6115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9E6115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2EB472C0008
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
       call      qword ptr [7FF9E693DE90]
       int       3
; Total bytes of code 235
```

