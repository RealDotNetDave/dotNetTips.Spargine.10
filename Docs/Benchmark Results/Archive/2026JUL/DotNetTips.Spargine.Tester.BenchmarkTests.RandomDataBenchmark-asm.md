## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateAddressRef()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,1E8
       lea       rbp,[rsp+220]
       xor       eax,eax
       mov       [rbp-1B8],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-1B0],xmm4
       vmovdqa   xmmword ptr [rbp-1A0],xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-170]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-138],rax
       mov       rcx,rsp
       mov       [rbp-158],rcx
       mov       rcx,rbp
       mov       [rbp-148],rcx
       mov       rcx,1E5538012F0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L49
       mov       rdx,[rcx+18]
M00_L01:
       test      rdx,rdx
       je        near ptr M00_L50
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L57
       mov       rcx,rbx
       mov       r11,7FF9F7080A00
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L19
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rbx],rcx
       je        near ptr M00_L13
       mov       rcx,rbx
       mov       r11,7FF9F7080A08
       call      qword ptr [r11]
       mov       esi,eax
M00_L02:
       mov       edi,esi
       test      edi,edi
       jl        near ptr M00_L51
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L52
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L52
M00_L03:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L04
       call      qword ptr [7FF9F77543F0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L04:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r11,[rcx+18]
       mov       r8,[rcx+20]
       mov       r10,rdx
       shl       r10,11
       xor       r11,rax
       xor       r8,rdx
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       xor       rdx,r11
       xor       rax,r8
       xor       r11,r10
       rol       r8,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r11
       mov       [rcx+20],r8
       mov       r11d,edi
       shr       r9,20
       mov       r8d,r9d
       imul      r11,r8
       mov       r8d,r11d
       cmp       r8d,edi
       jb        near ptr M00_L53
M00_L05:
       shr       r11,20
       mov       edx,r11d
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rbx],rcx
       je        near ptr M00_L16
       mov       rcx,rbx
       mov       r11,7FF9F7080A10
       call      qword ptr [r11]
M00_L06:
       mov       [rbp-188],rax
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rcx,1E5538012E8
       mov       rbx,[rcx]
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L73
       mov       rsi,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rsi],rcx
       jne       near ptr M00_L70
       mov       rcx,225E887B790
       mov       [rbp-90],rcx
       xor       ecx,ecx
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       cmp       qword ptr [rbp-98],0
       jne       short M00_L07
       mov       rcx,[rbp-90]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-98]
       cmp       qword ptr [rbp-98],0
       je        near ptr M00_L68
M00_L07:
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L69
       mov       rcx,rdi
       call      00007FFA56D49590
       test      eax,eax
       je        near ptr M00_L20
M00_L08:
       mov       edi,eax
M00_L09:
       xor       ecx,ecx
       mov       [rbp-98],rcx
M00_L10:
       mov       rcx,[rbx+8]
       mov       edx,edi
       imul      rdx,[rbx+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L104
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       rbx,[rbx+10]
       xor       r15d,r15d
       dec       r14d
       mov       r13d,[rbx+8]
       cmp       r13d,r14d
       jbe       near ptr M00_L73
M00_L11:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rbx+rcx*8+10]
       cmp       [r12+10],edi
       je        near ptr M00_L21
M00_L12:
       mov       r14d,[r12+14]
       inc       r15d
       mov       r13d,[rbx+8]
       cmp       r13d,r15d
       jb        near ptr M00_L42
       cmp       r13d,r14d
       jbe       near ptr M00_L73
       jmp       short M00_L11
M00_L13:
       mov       rcx,[rbx+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],r11
       jne       short M00_L15
       mov       esi,[rcx+8]
M00_L14:
       jmp       near ptr M00_L02
M00_L15:
       mov       r11,7FF9F7080A18
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L14
M00_L16:
       mov       rcx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],rax
       jne       short M00_L18
       cmp       [rcx+8],edx
       jbe       near ptr M00_L56
       mov       eax,edx
       mov       rax,[rcx+rax*8+10]
M00_L17:
       jmp       near ptr M00_L06
M00_L18:
       mov       r11,7FF9F7080A20
       call      qword ptr [r11]
       jmp       short M00_L17
M00_L19:
       xor       eax,eax
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,rdi
       call      qword ptr [7FF9F73178D0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L08
M00_L21:
       mov       r14,[r12]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rsi],rcx
       jne       near ptr M00_L72
       test      r14,r14
       je        near ptr M00_L12
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [r14],rcx
       jne       near ptr M00_L71
       mov       rcx,225E887B790
       cmp       r14,rcx
       sete      r13b
       movzx     r13d,r13b
M00_L22:
       test      r13d,r13d
       je        near ptr M00_L12
       add       r12,8
M00_L23:
       test      r12,r12
       je        near ptr M00_L74
       mov       rbx,[r12]
       mov       [rbp-190],rbx
       mov       rcx,[rbp-188]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M00_L75
M00_L24:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IList<DotNetTips.Spargine.Tester.Data.Models.State>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L81
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Data.Models.State>
       cmp       [rsi],rcx
       je        near ptr M00_L43
       mov       rcx,rsi
       mov       r11,7FF9F7080A60
       call      qword ptr [r11]
M00_L25:
       test      eax,eax
       je        near ptr M00_L46
       mov       rcx,rsi
       mov       r11,7FF9F7080A68
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jl        near ptr M00_L76
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L77
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L77
M00_L26:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L27
       call      qword ptr [7FF9F77543F0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L27:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r11,[rcx+18]
       mov       r8,[rcx+20]
       mov       r10,rdx
       shl       r10,11
       xor       r11,rax
       xor       r8,rdx
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       xor       rdx,r11
       xor       rax,r8
       xor       r11,r10
       rol       r8,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r11
       mov       [rcx+20],r8
       mov       r11d,ebx
       shr       r9,20
       mov       r8d,r9d
       imul      r11,r8
       mov       r8d,r11d
       cmp       r8d,ebx
       jb        near ptr M00_L78
M00_L28:
       mov       rdx,r11
       shr       rdx,20
       mov       rcx,rsi
       mov       r11,7FF9F7080A70
       call      qword ptr [r11]
M00_L29:
       mov       rbx,rax
M00_L30:
       mov       [rbp-1A8],rbx
       test      rbx,rbx
       je        near ptr M00_L48
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L92
M00_L31:
       test      rsi,rsi
       je        near ptr M00_L48
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<DotNetTips.Spargine.Tester.Data.Models.City>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L98
       mov       rcx,rdi
       mov       r11,7FF9F7080AA8
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,rdi
       mov       r11,7FF9F7080AB0
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jl        near ptr M00_L93
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L94
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L94
M00_L32:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L33
       call      qword ptr [7FF9F77543F0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L33:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r11,[rcx+18]
       mov       r8,[rcx+20]
       mov       r10,rdx
       shl       r10,11
       xor       r11,rax
       xor       r8,rdx
       lea       r9,[rdx+rdx*4]
       rol       r9,7
       lea       r9,[r9+r9*8]
       xor       rdx,r11
       xor       rax,r8
       xor       r11,r10
       rol       r8,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r11
       mov       [rcx+20],r8
       mov       r11d,esi
       shr       r9,20
       mov       r8d,r9d
       imul      r11,r8
       mov       r8d,r11d
       cmp       r8d,esi
       jb        near ptr M00_L95
M00_L34:
       mov       rdx,r11
       shr       rdx,20
       mov       rcx,rdi
       mov       r11,7FF9F7080AB8
       call      qword ptr [r11]
M00_L35:
       mov       rsi,rax
M00_L36:
       mov       [rbp-1C0],rsi
M00_L37:
       lea       rcx,[rbp-100]
       mov       rax,7FF9F74609F0
       mov       [rbp-160],rax
       lea       rax,[M00_L38]
       mov       [rbp-150],rax
       mov       rax,[rbp-138]
       lea       rdx,[rbp-170]
       mov       [rax+8],rdx
       mov       rax,[rbp-138]
       mov       byte ptr [rax+4],0
       mov       rax,7FFA93BB0930
       vzeroupper
       call      rax
M00_L38:
       mov       rcx,[rbp-138]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M00_L39
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M00_L39:
       mov       rcx,[rbp-138]
       mov       rdx,[rbp-168]
       mov       [rcx+8],rdx
       test      eax,eax
       jne       near ptr M00_L101
       vmovups   xmm0,[rbp-100]
       vmovups   [rbp-0F0],xmm0
       mov       rcx,225E887FED8
       call      qword ptr [7FF9F73DE5F8]; System.String.IsNullOrEmpty(System.String)
       mov       ecx,20
       mov       edx,24
       test      eax,eax
       cmovne    ecx,edx
       call      qword ptr [7FF9F7136670]; System.String.FastAllocateString(IntPtr)
       mov       rbx,rax
       cmp       [rbx],bl
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-110],xmm0
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       lea       rcx,[rbp-110]
       call      qword ptr [7FF9F77E67F0]; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       mov       rsi,[rbp-110]
       mov       edi,[rbp-108]
       lea       rcx,[rbp-128]
       mov       rdx,225E887FED8
       call      qword ptr [7FF9F7557C60]; System.MemoryExtensions.AsSpan(System.String)
       mov       [rbp-180],rsi
       mov       [rbp-178],edi
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0F0]
       lea       r8,[rbp-118]
       lea       r9,[rbp-128]
       call      qword ptr [7FF9F7315188]; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       mov       ecx,19
       call      qword ptr [7FF9F7755050]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressLineOne(Int32)
       mov       rsi,rax
       mov       ecx,19
       call      qword ptr [7FF9F7755068]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressLineTwo(Int32)
       mov       rdi,rax
       mov       rcx,[rbp-1C0]
       call      qword ptr [7FF9F7755080]; DotNetTips.Spargine.Tester.RandomData.GetCityName(DotNetTips.Spargine.Tester.Data.Models.City)
       mov       r14,rax
       mov       rcx,[rbp-188]
       mov       r15,[rcx+68]
       mov       rcx,225E8870008
       test      r15,r15
       cmove     r15,rcx
       mov       ecx,14
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7754F18]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r13,rax
       mov       rcx,[rbp-188]
       mov       ecx,[rcx+0B8]
       call      qword ptr [7FF9F76CFFD8]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r12,rax
       mov       rcx,[rbp-188]
       mov       rdx,[rbp-1C0]
       call      qword ptr [7FF9F77550C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Models.Country, DotNetTips.Spargine.Tester.Data.Models.City)
       mov       [rbp-1C8],rax
       mov       rcx,[rbp-1A8]
       call      qword ptr [7FF9F77550E0]; DotNetTips.Spargine.Tester.RandomData.GetStateName(DotNetTips.Spargine.Tester.Data.Models.State)
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       r13,[rbp-1C8]
       mov       [rsp+40],r13
       mov       [rsp+48],rax
       lea       rcx,[rbp-0E0]
       mov       [rsp+20],r14
       mov       [rsp+28],r15
       mov       rdx,rbx
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FF9F77550F8]; DotNetTips.Spargine.Tester.RandomData+AddressComponents..ctor(System.String, System.String, System.String, System.String, System.String, System.String, System.String, System.String, System.String)
       vmovdqu   ymm0,ymmword ptr [rbp-0E0]
       vmovdqu   ymmword ptr [rbp-88],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-68],ymm0
       mov       rcx,[rbp-0A0]
       mov       [rbp-48],rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.RandomData+<>c.<.cctor>b__93_1(AddressComponents)
       mov       rbx,[rbp-190]
       cmp       [rbx+18],rcx
       jne       near ptr M00_L102
       mov       rcx,[rbx+8]
       lea       rdx,[rbp-88]
       call      qword ptr [7FF9F75550E0]; DotNetTips.Spargine.Tester.RandomData+<>c.<.cctor>b__93_1(AddressComponents)
M00_L40:
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L41
       mov       r10,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],r10
       jne       near ptr M00_L103
M00_L41:
       mov       [rbp-130],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+60]
       lea       r8,[rbp-130]
       mov       rdx,7FF9F77B39D8
       cmp       [rcx],ecx
       call      qword ptr [7FF9F775DE30]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,1E8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L42:
       call      qword ptr [7FF9F713F570]
       int       3
M00_L43:
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Data.Models.State>
       cmp       [rcx],r11
       jne       short M00_L45
       mov       eax,[rcx+10]
M00_L44:
       jmp       near ptr M00_L25
M00_L45:
       mov       r11,7FF9F7080A78
       call      qword ptr [r11]
       jmp       short M00_L44
M00_L46:
       xor       eax,eax
       jmp       near ptr M00_L29
M00_L47:
       xor       eax,eax
       jmp       near ptr M00_L35
M00_L48:
       xor       esi,esi
       mov       [rbp-1C0],rsi
       jmp       near ptr M00_L37
M00_L49:
       call      qword ptr [7FF9F74C41C8]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L50:
       call      qword ptr [7FF9F76CF0A8]
       mov       ecx,65
       mov       rdx,7FF9F751DF40
       call      qword ptr [7FF9F713F300]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9F7415AC0
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F751DF40
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F77E65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F77E58C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       mov       ecx,21AC
       mov       rdx,7FF9F7074000
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F77E46C0]
       int       3
M00_L52:
       mov       ecx,8
       call      qword ptr [7FF9F77E4960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L53:
       mov       eax,edi
       neg       eax
       xor       edx,edx
       div       edi
       jmp       short M00_L55
M00_L54:
       mov       r11,[rcx+8]
       mov       r8,[rcx+10]
       mov       rax,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,r8
       shl       r9,11
       xor       rax,r11
       xor       r10,r8
       lea       rsi,[r8+r8*4]
       rol       rsi,7
       lea       rsi,[rsi+rsi*8]
       xor       r8,rax
       xor       r11,r10
       xor       rax,r9
       rol       r10,2D
       mov       [rcx+8],r11
       mov       [rcx+10],r8
       mov       [rcx+18],rax
       mov       [rcx+20],r10
       mov       r11d,edi
       shr       rsi,20
       mov       eax,esi
       imul      r11,rax
       mov       r8d,r11d
M00_L55:
       cmp       r8d,edx
       jb        short M00_L54
       jmp       near ptr M00_L05
M00_L56:
       call      qword ptr [7FF9F775E790]
       int       3
M00_L57:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L66
       mov       rcx,rbx
       mov       r11,7FF9F7080A28
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L58
       xor       eax,eax
       mov       [rbp-1A0],rax
       jmp       near ptr M00_L64
M00_L58:
       mov       rcx,1E553801DD0
       mov       rcx,[rcx]
       mov       edx,eax
       call      qword ptr [7FF9F774CE80]; System.Random+ThreadSafeRandom.Next(Int32)
       mov       esi,eax
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FF9F7080A30
       call      qword ptr [r11]
       mov       [rbp-198],rax
M00_L59:
       mov       rcx,[rbp-198]
       mov       r11,7FF9F7080A38
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L62
       mov       rcx,[rbp-198]
       mov       r11,7FF9F7080A40
       call      qword ptr [r11]
       cmp       edi,esi
       je        short M00_L60
       add       edi,1
       jo        short M00_L61
       jmp       short M00_L59
M00_L60:
       mov       [rbp-1A0],rax
       jmp       short M00_L63
M00_L61:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L62:
       mov       rcx,[rbp-198]
       mov       r11,7FF9F7080A48
       call      qword ptr [r11]
       xor       eax,eax
       jmp       short M00_L65
M00_L63:
       call      M00_L105
       nop
M00_L64:
       mov       rax,[rbp-1A0]
M00_L65:
       jmp       near ptr M00_L06
M00_L66:
       mov       rcx,7FF9F78B7AE8
       call      qword ptr [7FF9F74C6BF8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0
       je        short M00_L67
       mov       rcx,1E553801DD0
       mov       rcx,[rcx]
       mov       edx,[rbx+8]
       call      qword ptr [7FF9F774CE80]; System.Random+ThreadSafeRandom.Next(Int32)
       cmp       eax,[rbx+8]
       jae       near ptr M00_L104
       mov       ecx,eax
       mov       rax,[rbx+rcx*8+10]
       jmp       near ptr M00_L06
M00_L67:
       xor       eax,eax
       jmp       near ptr M00_L06
M00_L68:
       xor       edi,edi
       jmp       near ptr M00_L09
M00_L69:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edi,eax
       jmp       near ptr M00_L09
M00_L70:
       mov       rcx,rsi
       mov       r11,7FF9F7080A50
       mov       rdx,225E887B790
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L10
M00_L71:
       mov       rcx,r14
       mov       rdx,225E887B790
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       mov       r13d,eax
       jmp       near ptr M00_L22
M00_L72:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r11,7FF9F7080A58
       mov       r8,225E887B790
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L22
M00_L73:
       xor       r12d,r12d
       jmp       near ptr M00_L23
M00_L74:
       call      qword ptr [7FF9F713D3E0]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,225E887B790
       call      qword ptr [7FF9F707A310]; Precode of System.RuntimeType.get_FullName()
       mov       rdi,rax
       mov       ecx,37D
       mov       rdx,7FF9F7414FF0
       call      qword ptr [7FF9F713F300]
       mov       [rsp+20],rax
       mov       r9,rdi
       mov       r8,1E553801300
       mov       r8,[r8]
       mov       rdx,rbx
       mov       rcx,7FF9F75917D0
       call      qword ptr [7FF9F7554DC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F713F318]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L75:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Data.Models.State>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F77542B8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-188]
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L24
M00_L76:
       mov       ecx,21AC
       mov       rdx,7FF9F7074000
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F77E46C0]
       int       3
M00_L77:
       mov       ecx,8
       call      qword ptr [7FF9F77E4960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L26
M00_L78:
       mov       eax,ebx
       neg       eax
       xor       edx,edx
       div       ebx
       jmp       short M00_L80
M00_L79:
       mov       r11,[rcx+8]
       mov       r8,[rcx+10]
       mov       rax,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,r8
       shl       r9,11
       xor       rax,r11
       xor       r10,r8
       lea       rdi,[r8+r8*4]
       rol       rdi,7
       lea       rdi,[rdi+rdi*8]
       xor       r8,rax
       xor       r11,r10
       xor       rax,r9
       rol       r10,2D
       mov       [rcx+8],r11
       mov       [rcx+10],r8
       mov       [rcx+18],rax
       mov       [rcx+20],r10
       mov       r11d,ebx
       shr       rdi,20
       mov       eax,edi
       imul      r11,rax
       mov       r8d,r11d
M00_L80:
       cmp       r8d,edx
       jb        short M00_L79
       jmp       near ptr M00_L28
M00_L81:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Data.Models.State>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L90
       mov       rcx,rsi
       mov       r11,7FF9F7080A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L82
       xor       ecx,ecx
       mov       [rbp-1B8],rcx
       jmp       near ptr M00_L88
M00_L82:
       mov       rcx,1E553801DD0
       mov       rcx,[rcx]
       mov       edx,eax
       call      qword ptr [7FF9F774CE80]; System.Random+ThreadSafeRandom.Next(Int32)
       mov       ebx,eax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FF9F7080A88
       call      qword ptr [r11]
       mov       [rbp-1B0],rax
M00_L83:
       mov       rcx,[rbp-1B0]
       mov       r11,7FF9F7080A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L86
       mov       rcx,[rbp-1B0]
       mov       r11,7FF9F7080A98
       call      qword ptr [r11]
       cmp       edi,ebx
       je        short M00_L84
       add       edi,1
       jo        short M00_L85
       jmp       short M00_L83
M00_L84:
       mov       [rbp-1B8],rax
       jmp       short M00_L87
M00_L85:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L86:
       mov       rcx,[rbp-1B0]
       mov       r11,7FF9F7080AA0
       call      qword ptr [r11]
       xor       ebx,ebx
       jmp       short M00_L89
M00_L87:
       call      M00_L107
       nop
M00_L88:
       mov       rbx,[rbp-1B8]
M00_L89:
       jmp       near ptr M00_L30
M00_L90:
       mov       rdx,rbx
       mov       rcx,7FF9F78B8060
       call      qword ptr [7FF9F74C6BF8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        short M00_L91
       mov       rcx,1E553801DD0
       mov       rcx,[rcx]
       mov       edx,[rsi+8]
       call      qword ptr [7FF9F774CE80]; System.Random+ThreadSafeRandom.Next(Int32)
       cmp       eax,[rsi+8]
       jae       near ptr M00_L104
       mov       ecx,eax
       mov       rbx,[rsi+rcx*8+10]
       jmp       near ptr M00_L30
M00_L91:
       xor       ebx,ebx
       jmp       near ptr M00_L30
M00_L92:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Data.Models.City>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F77542B8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-1A8]
       jmp       near ptr M00_L31
M00_L93:
       mov       ecx,21AC
       mov       rdx,7FF9F7074000
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FF9F77E46C0]
       int       3
M00_L94:
       mov       ecx,8
       call      qword ptr [7FF9F77E4960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L32
M00_L95:
       mov       eax,esi
       neg       eax
       xor       edx,edx
       div       esi
       jmp       short M00_L97
M00_L96:
       mov       r11,[rcx+8]
       mov       r8,[rcx+10]
       mov       rax,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,r8
       shl       r9,11
       xor       rax,r11
       xor       r10,r8
       lea       r14,[r8+r8*4]
       rol       r14,7
       lea       r14,[r14+r14*8]
       xor       r8,rax
       xor       r11,r10
       xor       rax,r9
       rol       r10,2D
       mov       [rcx+8],r11
       mov       [rcx+10],r8
       mov       [rcx+18],rax
       mov       [rcx+20],r10
       mov       r11d,esi
       shr       r14,20
       mov       eax,r14d
       imul      r11,rax
       mov       r8d,r11d
M00_L97:
       cmp       r8d,edx
       jb        short M00_L96
       jmp       near ptr M00_L34
M00_L98:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Data.Models.City>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L99
       mov       rdx,rax
       mov       rcx,7FF9F78B83B8
       call      qword ptr [7FF9F77551A0]
       mov       rsi,rax
       jmp       near ptr M00_L36
M00_L99:
       mov       rdx,rsi
       mov       rcx,7FF9F78B8440
       call      qword ptr [7FF9F74C6BF8]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        short M00_L100
       mov       rcx,1E553801DD0
       mov       rcx,[rcx]
       mov       edx,[rsi+8]
       call      qword ptr [7FF9F774CE80]; System.Random+ThreadSafeRandom.Next(Int32)
       cmp       eax,[rsi+8]
       jae       short M00_L104
       mov       edx,eax
       mov       rsi,[rsi+rdx*8+10]
       jmp       near ptr M00_L36
M00_L100:
       xor       esi,esi
       jmp       near ptr M00_L36
M00_L101:
       mov       ecx,eax
       call      qword ptr [7FF9F77E54E8]
       int       3
M00_L102:
       lea       rdx,[rbp-88]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M00_L40
M00_L103:
       mov       rdx,rax
       mov       rcx,r10
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L104:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L105:
       sub       rsp,58
       cmp       qword ptr [rbp-198],0
       je        short M00_L106
       mov       rcx,[rbp-198]
       mov       r11,7FF9F7080A48
       call      qword ptr [r11]
M00_L106:
       nop
       vzeroupper
       add       rsp,58
       ret
M00_L107:
       sub       rsp,58
       cmp       qword ptr [rbp-1B0],0
       je        short M00_L108
       mov       rcx,[rbp-1B0]
       mov       r11,7FF9F7080AA0
       call      qword ptr [r11]
M00_L108:
       nop
       vzeroupper
       add       rsp,58
       ret
; Total bytes of code 4237
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFA3C43E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA3C448738]
       call      qword ptr [7FFA3C435EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       [rbp+10],rcx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rbx,rax
       mov       rcx,rsp
       mov       [rbp-58],rcx
       mov       rcx,rbp
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp+10],0
       je        short M02_L03
       mov       rcx,7FF9F780EDD4
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+10]
       mov       rax,7FF9F730BDE0
       mov       [rbp-60],rax
       lea       rax,[M02_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFA56D542E0
       call      rax
M02_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L01
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L01:
       mov       rcx,[rbp-68]
       mov       [rbx+8],rcx
M02_L02:
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
M02_L03:
       mov       rcx,7FF9F780EDD0
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       jmp       short M02_L02
; Total bytes of code 195
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M03_L01
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M03_L04
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M03_L03
M03_L00:
       cmp       [r10],rcx
       jne       short M03_L02
M03_L01:
       mov       rax,rdx
       ret
M03_L02:
       cmp       [r10+8],rcx
       je        short M03_L01
       cmp       [r10+10],rcx
       je        short M03_L01
       cmp       [r10+18],rcx
       je        short M03_L01
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M03_L00
       test      r8,r8
       je        short M03_L04
M03_L03:
       cmp       [r10],rcx
       je        short M03_L01
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M03_L03
M03_L04:
       test      dword ptr [rax],500C0000
       jne       short M03_L05
       xor       edx,edx
       jmp       short M03_L01
M03_L05:
       jmp       qword ptr [7FF9F74CDA58]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 109
```
```assembly
; System.String.IsNullOrEmpty(System.String)
       test      rcx,rcx
       je        short M04_L00
       cmp       dword ptr [rcx+8],0
       sete      al
       movzx     eax,al
       ret
M04_L00:
       mov       eax,1
       ret
; Total bytes of code 22
```
```assembly
; System.String.FastAllocateString(IntPtr)
       mov       rdx,rcx
       mov       rcx,offset MT_System.String
       jmp       near ptr 00007FFA56DB9D30
; Total bytes of code 18
```
```assembly
; System.Span`1[[System.Char, System.Private.CoreLib]]..ctor(Char ByRef, Int32)
       mov       [rcx],rdx
       mov       [rcx+8],r8d
       ret
; Total bytes of code 8
```
```assembly
; System.MemoryExtensions.AsSpan(System.String)
       test      rdx,rdx
       jne       short M07_L01
       xor       edx,edx
       mov       [rcx],rdx
       mov       [rcx+8],rdx
M07_L00:
       mov       rax,rcx
       ret
M07_L01:
       lea       rax,[rdx+0C]
       mov       edx,[rdx+8]
       mov       [rcx],rax
       mov       [rcx+8],edx
       jmp       short M07_L00
; Total bytes of code 33
```
```assembly
; System.Guid.TryFormatCore[[System.Char, System.Private.CoreLib]](System.Span`1<Char>, Int32 ByRef, System.ReadOnlySpan`1<Char>)
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rax,[r9]
       mov       r10d,[r9+8]
       test      r10d,r10d
       je        near ptr M08_L12
       cmp       r10d,1
       jne       near ptr M08_L08
       movzx     eax,word ptr [rax]
       or        eax,20
       cmp       eax,64
       jle       near ptr M08_L09
       cmp       eax,6E
       jne       near ptr M08_L11
       mov       ebx,20
M08_L00:
       mov       rax,[rdx]
       mov       edx,[rdx+8]
       movzx     r10d,bl
       cmp       r10d,edx
       jg        near ptr M08_L15
       mov       [r8],r10d
       sar       ebx,8
       mov       [rsp+28],rax
       mov       r8,rax
       test      bl,bl
       jne       near ptr M08_L16
M08_L01:
       sar       ebx,8
       vmovups   xmm0,[rcx]
       vmovups   xmm1,[7FF9F78350A0]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FF9F78350B0]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FF9F78350C0]
       test      ebx,ebx
       jl        short M08_L02
       vxorps    xmm2,xmm2,xmm2
       vmovaps   xmm3,xmm0
       vmovaps   xmm0,xmm2
       vmovaps   xmm2,xmm3
       jmp       short M08_L03
M08_L02:
       vpshufb   xmm2,xmm0,[7FF9F78350D0]
       vpshufb   xmm3,xmm1,[7FF9F78350E0]
       vpshufb   xmm1,xmm1,[7FF9F78350F0]
       vpshufb   xmm0,xmm0,[7FF9F7835100]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FF9F7835110]
       vmovaps   xmm1,xmm3
M08_L03:
       vpmovzxbw xmm3,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm4,xmm2
       vpsrldq   xmm2,xmm2,8
       vpmovzxbw xmm2,xmm2
       test      ebx,ebx
       jge       short M08_L07
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [r8],xmm3
       vmovups   [r8+28],xmm4
       vmovups   [r8+38],xmm2
       vmovups   [r8+10],xmm1
       vmovups   [r8+20],xmm0
       add       r8,48
M08_L04:
       test      bl,bl
       jne       near ptr M08_L17
M08_L05:
       xor       eax,eax
       mov       [rsp+28],rax
       mov       eax,1
M08_L06:
       add       rsp,30
       pop       rbx
       ret
M08_L07:
       vmovups   [r8],xmm3
       vmovups   [r8+10],xmm1
       vmovups   [r8+20],xmm4
       vmovups   [r8+30],xmm2
       add       r8,40
       jmp       short M08_L04
M08_L08:
       call      qword ptr [7FF9F77E4EA0]
       int       3
M08_L09:
       cmp       eax,62
       je        short M08_L14
       cmp       eax,64
       je        short M08_L12
M08_L10:
       call      qword ptr [7FF9F77E4EA0]
       int       3
M08_L11:
       cmp       eax,70
       je        short M08_L13
       cmp       eax,78
       jne       short M08_L10
       call      qword ptr [7FF9F77E4EE8]
       nop
       add       rsp,30
       pop       rbx
       ret
M08_L12:
       mov       ebx,80000024
       jmp       near ptr M08_L00
M08_L13:
       mov       ebx,80292826
       jmp       near ptr M08_L00
M08_L14:
       mov       ebx,807D7B26
       jmp       near ptr M08_L00
M08_L15:
       xor       eax,eax
       mov       [r8],eax
       jmp       short M08_L06
M08_L16:
       lea       r8,[rax+2]
       movzx     edx,bl
       mov       [rax],dx
       jmp       near ptr M08_L01
M08_L17:
       movzx     eax,bl
       mov       [r8],ax
       jmp       near ptr M08_L05
; Total bytes of code 494
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressLineOne(Int32)
; 		return $"{GenerateNumber(AddressNumberCount)} {GenerateWord(addressLength - AddressNumberCount - 1)}";
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       mov       ecx,5
       call      qword ptr [7FF9F76CFFD8]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       mov       ecx,ebx
       sub       ecx,5
       jo        near ptr M09_L03
       sub       ecx,1
       jo        near ptr M09_L03
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7754F18]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       test      rsi,rsi
       je        near ptr M09_L01
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M09_L01
       test      rbx,rbx
       je        near ptr M09_L00
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M09_L00
       mov       r14d,edi
       mov       edx,ebp
       lea       rdx,[r14+rdx+1]
       cmp       rdx,7FFFFFFF
       jg        near ptr M09_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],20
       inc       edi
       movsxd    rcx,edi
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,rsi
       mov       rdx,225E8877C88
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
M09_L01:
       mov       rdx,rbx
       mov       rcx,225E8877C88
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
M09_L02:
       call      qword ptr [7FF9F77E4BB8]
       int       3
M09_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 313
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressLineTwo(Int32)
; 		return $"{GenerateWord(addressLength - AddressNumberCount - 1)} {GenerateNumber(AddressNumberCount)}";
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       sub       ecx,5
       jo        near ptr M10_L03
       sub       ecx,1
       jo        near ptr M10_L03
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7754F18]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FF9F76CFFD8]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M10_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M10_L01
       test      rsi,rsi
       je        near ptr M10_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M10_L00
       mov       r14d,edi
       mov       edx,ebp
       lea       rdx,[r14+rdx+1]
       cmp       rdx,7FFFFFFF
       jg        near ptr M10_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],20
       inc       edi
       movsxd    rcx,edi
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M10_L00:
       mov       rcx,rbx
       mov       rdx,225E8877C88
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
M10_L01:
       mov       rdx,rsi
       mov       rcx,225E8877C88
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
M10_L02:
       call      qword ptr [7FF9F77E4BB8]
       int       3
M10_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 309
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetCityName(DotNetTips.Spargine.Tester.Data.Models.City)
; 		city?.Name ?? Core.ControlChars.EmptyString;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rcx,rcx
       je        short M11_L01
       mov       rax,[rcx+18]
M11_L00:
       mov       rcx,225E8870008
       test      rax,rax
       cmove     rax,rcx
       ret
M11_L01:
       xor       eax,eax
       jmp       short M11_L00
; Total bytes of code 31
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,0C523EEC9807B
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M12_L13
M12_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M12_L25
       add       edi,1
       jo        near ptr M12_L25
       cmp       r15d,100
       jg        near ptr M12_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M12_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M12_L01:
       push      0
       push      0
       dec       r15
       jne       short M12_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M12_L02:
       test      ebx,ebx
       jl        near ptr M12_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M12_L25
       mov       r13,rax
       test      r13,r13
       je        short M12_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M12_L03:
       push      0
       push      0
       dec       r13
       jne       short M12_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M12_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M12_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F756FB28
       mov       [rbp+60],rax
       lea       rax,[M12_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA91B83670
       call      rax
M12_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M12_L06
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M12_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M12_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M12_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M12_L09
M12_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M12_L25
       cmp       edx,0FFFF
       ja        near ptr M12_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M12_L25
       cmp       ecx,ebx
       jge       short M12_L10
       jmp       short M12_L08
M12_L09:
       mov       r13,[rbp+10]
M12_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M12_L11:
       mov       r8,0C523EEC9807B
       cmp       [rbp+8],r8
       je        short M12_L12
       call      CORINFO_HELP_FAIL_FAST
M12_L12:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M12_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M12_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FF9F76CFE70]
       mov       ebx,eax
       jmp       near ptr M12_L00
M12_L14:
       call      qword ptr [7FF9F76CFE88]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M12_L15
       call      qword ptr [7FF9F77E6598]
       mov       rbx,rax
M12_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,225E8872FC0
       call      qword ptr [7FF9F73DDB78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M12_L16:
       call      qword ptr [7FF9F731F300]
       int       3
M12_L17:
       mov       ecx,eax
       call      qword ptr [7FF9F77E4870]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M12_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E553801E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7761DD8]
       mov       [rbp+28],rax
       mov       rcx,1E553800C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9F7410D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M12_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M12_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FF9F7554D08]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M12_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M12_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M12_L20
M12_L19:
       call      qword ptr [7FF9F731F300]
       int       3
M12_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FF9F755C870]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M12_L24
M12_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M12_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M12_L23:
       cmp       r10d,r8d
       jae       short M12_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M12_L22
       cmp       edx,0FFFF
       ja        short M12_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M12_L22
M12_L24:
       cmp       r10d,r14d
       jl        short M12_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FF9F7131548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E553801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7761DE0]
       mov       rcx,1E553800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F7410D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M12_L11
M12_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FF9F7740338],1
       jne       short M12_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M12_L26:
       mov       rcx,1E553801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7761DE0]
       mov       rcx,1E553800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F7410D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1124
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       xor       eax,eax
       mov       [rbp+30],rax
       mov       rax,0C523EEC9807B
       mov       [rbp+8],rax
       mov       ebx,ecx
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       mov       eax,1
       test      ecx,ecx
       cmove     ebx,eax
; 		byte[]? rentedBytes = null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		char[]? rentedChars = null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rbp+10],rcx
; 		var bytes = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc byte[length]
; 			                         
; 			: (rentedBytes = ArrayPool<byte>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       cmp       ebx,100
       jg        near ptr M13_L17
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M13_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M13_L00:
       push      0
       push      0
       dec       rsi
       jne       short M13_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M13_L01:
       test      ebx,ebx
       jl        near ptr M13_L21
       mov       edi,ebx
M13_L02:
       cmp       ebx,100
       jg        near ptr M13_L19
; 		var chars = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc char[length]
; 			                         
; 			: (rentedChars = ArrayPool<char>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       mov       eax,ebx
       mov       ecx,2
       mul       rcx
       jb        near ptr M13_L23
       mov       r14,rax
       test      r14,r14
       je        short M13_L04
       add       r14,0F
       shr       r14,4
       add       rsp,20
M13_L03:
       push      0
       push      0
       dec       r14
       jne       short M13_L03
       sub       rsp,20
       lea       r14,[rsp+20]
M13_L04:
       test      ebx,ebx
       jl        near ptr M13_L21
       mov       r15d,ebx
M13_L05:
       test      edi,edi
       jle       short M13_L06
       mov       rcx,rsi
       mov       [rbp+30],rcx
       mov       edx,edi
       call      qword ptr [7FF9F7554D38]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+30],rcx
M13_L06:
       xor       ecx,ecx
       mov       [rbp+30],rcx
; 			for (var digitIndex = 0; digitIndex < length; digitIndex++)
; 			                         ^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       jle       short M13_L08
       cmp       ebx,r15d
       jg        short M13_L09
       cmp       ebx,edi
       jg        short M13_L09
; 				chars[digitIndex] = (char)('0' + (bytes[digitIndex] % 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M13_L07:
       mov       eax,ecx
       movzx     edx,byte ptr [rsi+rax]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M13_L11
       cmp       edx,0FFFF
       ja        short M13_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M13_L11
       cmp       ecx,ebx
       jl        short M13_L07
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M13_L08:
       mov       [rbp+20],r14
       mov       [rbp+28],r15d
       lea       rcx,[rbp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       jmp       short M13_L12
M13_L09:
       cmp       ecx,r15d
       jae       short M13_L10
       mov       eax,ecx
       cmp       ecx,edi
       jae       short M13_L10
       mov       edx,ecx
       movzx     edx,byte ptr [rsi+rdx]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M13_L11
       cmp       edx,0FFFF
       ja        short M13_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M13_L11
       cmp       ecx,ebx
       jl        short M13_L09
       jmp       short M13_L08
M13_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M13_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			if (rentedBytes is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M13_L12:
       cmp       qword ptr [rbp+18],0
       je        short M13_L14
; 				ArrayPool<byte>.Shared.Return(rentedBytes);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      byte ptr [7FF9F7740338],1
       je        near ptr M13_L22
M13_L13:
       mov       rcx,1E553801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7761DE0]
; 			if (rentedChars is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M13_L14:
       cmp       qword ptr [rbp+10],0
       je        short M13_L15
; 				ArrayPool<char>.Shared.Return(rentedChars);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,1E553800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F7410D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
M13_L15:
       mov       rax,rbx
       mov       r8,0C523EEC9807B
       cmp       [rbp+8],r8
       je        short M13_L16
       call      CORINFO_HELP_FAIL_FAST
M13_L16:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M13_L17:
       test      byte ptr [7FF9F7740338],1
       je        short M13_L20
M13_L18:
       mov       rcx,1E553801E50
       mov       rcx,[rcx]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7761DD8]
       mov       [rbp+18],rax
       test      rax,rax
       je        short M13_L21
       cmp       [rax+8],ebx
       jb        short M13_L21
       add       rax,10
       mov       rsi,rax
       mov       edi,ebx
       jmp       near ptr M13_L02
M13_L19:
       mov       rcx,1E553800C88
       mov       rcx,[rcx]
       mov       edx,ebx
       call      qword ptr [7FF9F7410D08]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+10],rax
       test      rax,rax
       je        short M13_L21
       cmp       [rax+8],ebx
       jb        short M13_L21
       add       rax,10
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M13_L05
M13_L20:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M13_L18
M13_L21:
       call      qword ptr [7FF9F731F300]
       int       3
M13_L22:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M13_L13
M13_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp+18],0
       je        short M13_L25
       test      byte ptr [7FF9F7740338],1
       jne       short M13_L24
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M13_L24:
       mov       rcx,1E553801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7761DE0]
M13_L25:
       cmp       qword ptr [rbp+10],0
       je        short M13_L26
       mov       rcx,1E553800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F7410D10]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
M13_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Models.Country, DotNetTips.Spargine.Tester.Data.Models.City)
; 		country = country.ArgumentNotNull();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (string.IsNullOrEmpty(country.PostalFormat))
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return string.Empty;
; 			^^^^^^^^^^^^^^^^^^^^
; 		var postalFormats = _postalFormatsCache.GetOrAdd(country, static c => c.PostalFormat!.Split(Core.ControlChars.Comma));
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var sb = _stringBuilderPool.Get().SetCapacity(format.Length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillPostalCodeFromFormat(sb, format);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = sb.Replace("CC", country.Iso2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ApplyCityReplacement(sb, format, city);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       xor       eax,eax
       mov       [rbp-40],rax
       mov       rbx,rcx
       mov       rsi,rdx
       test      rbx,rbx
       je        near ptr M14_L36
       mov       rcx,[rbx+88]
       test      rcx,rcx
       je        near ptr M14_L27
       cmp       dword ptr [rcx+8],0
       je        near ptr M14_L27
       mov       rcx,1E553801378
       mov       rdi,[rcx]
       mov       rcx,1E553801330
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M14_L37
M14_L00:
       mov       r15,rbx
       mov       r13,[r14+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M14_L28
       mov       rdx,r15
       mov       r11,7FF9F7080D00
       call      qword ptr [r11]
       mov       r12d,eax
M14_L01:
       mov       r15,[r13+8]
       mov       rcx,[r13+10]
       mov       r8d,r12d
       imul      r8,[r13+28]
       shr       r8,20
       inc       r8
       mov       edx,[rcx+8]
       mov       r11d,edx
       imul      r8,r11
       shr       r8,20
       cmp       r8d,edx
       jae       near ptr M14_L49
       mov       r8d,r8d
       mov       rax,[rcx+r8*8+10]
       test      rax,rax
       je        near ptr M14_L41
       test      r15,r15
       je        near ptr M14_L32
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M14_L32
M14_L02:
       cmp       r12d,[rax+20]
       jne       near ptr M14_L31
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M14_L31
       cmp       rdx,rbx
       jne       near ptr M14_L31
M14_L03:
       mov       rdx,[rax+10]
       mov       [rbp-40],rdx
M14_L04:
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       test      rcx,rcx
       je        near ptr M14_L33
       lea       rdi,[rcx+10]
       mov       r14d,[rcx+8]
M14_L05:
       test      r14d,r14d
       je        near ptr M14_L42
       lea       r15d,[r14-1]
       test      r15d,r15d
       jne       near ptr M14_L34
       xor       r13d,r13d
M14_L06:
       cmp       r13d,r14d
       jae       near ptr M14_L49
       mov       ecx,r13d
       mov       rdi,[rdi+rcx*8]
       mov       rcx,1E553801338
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        near ptr M14_L45
       lea       rcx,[r14+20]
       mov       r8,[rbp-58]
       test      rcx,rcx
       je        near ptr M14_L44
       xor       edx,edx
       call      00007FFA56D53270
       cmp       rax,[rbp-58]
       jne       near ptr M14_L45
M14_L07:
       mov       r14,[rbp-58]
M14_L08:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       edx,[rdi+8]
       test      r14,r14
       je        near ptr M14_L47
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       cmp       ecx,edx
       jl        near ptr M14_L48
M14_L09:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [rbp-88],r14
       lea       r14,[rdi+0C]
       mov       r15d,[rdi+8]
       xor       r13d,r13d
       cmp       r13d,r15d
       jge       near ptr M14_L13
M14_L10:
       cmp       r13d,r15d
       jae       near ptr M14_L23
       movzx     edx,word ptr [r14+r13*2]
       cmp       edx,41
       je        near ptr M14_L17
       cmp       edx,4E
       jne       near ptr M14_L16
       mov       ecx,1
       call      qword ptr [7FF9F76CFFD8]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       test      rax,rax
       je        short M14_L12
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M14_L12
       mov       r12,[rbp-88]
       mov       rcx,[r12+8]
       mov       eax,[r12+18]
       lea       r10d,[rax+r8]
       mov       [rbp-7C],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M14_L21
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M14_L20
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M14_L19
M14_L11:
       mov       r10d,[rbp-7C]
       mov       [r12+18],r10d
M14_L12:
       inc       r13d
       cmp       r13d,r15d
       jl        near ptr M14_L10
M14_L13:
       mov       rdx,[rbx+48]
       mov       r12,[rbp-88]
       mov       r8d,[r12+1C]
       add       r8d,[r12+18]
       mov       rcx,225E887FEFC
       test      rdx,rdx
       jne       near ptr M14_L18
       xor       r9d,r9d
       xor       eax,eax
M14_L14:
       mov       [rbp-68],rcx
       mov       dword ptr [rbp-60],2
       mov       [rbp-78],r9
       mov       [rbp-70],eax
       mov       [rsp+20],r8d
       lea       rdx,[rbp-68]
       lea       r8,[rbp-78]
       mov       rcx,r12
       xor       r9d,r9d
       call      qword ptr [7FF9F77556B0]; System.Text.StringBuilder.Replace(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Int32, Int32)
       test      rsi,rsi
       je        short M14_L15
       mov       edx,[rdi+8]
       mov       ecx,[rdi+8]
       add       rdi,0C
       mov       rcx,rdi
       mov       r8,225E887FF5C
       mov       r9d,4
       call      qword ptr [7FF9F77556C8]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       jge       near ptr M14_L25
M14_L15:
       mov       rcx,r12
       call      qword ptr [7FF9F73E6DE8]; System.Text.StringBuilder.ToString()
       mov       [rbp-90],rax
       jmp       near ptr M14_L26
M14_L16:
       mov       r12,[rbp-88]
       mov       ecx,[r12+18]
       mov       rax,[r12+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       near ptr M14_L22
       cmp       ecx,r8d
       jae       near ptr M14_L23
       mov       [rax+rcx*2+10],dx
       inc       dword ptr [r12+18]
       jmp       near ptr M14_L12
M14_L17:
       mov       r12,[rbp-88]
       mov       ecx,41
       mov       edx,5A
       call      qword ptr [7FF9F7754588]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M14_L24
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FF9F73D7258]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M14_L12
M14_L18:
       lea       r9,[rdx+0C]
       mov       eax,[rdx+8]
       jmp       near ptr M14_L14
M14_L19:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M14_L11
M14_L20:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M14_L11
M14_L21:
       mov       rcx,r12
       call      qword ptr [7FF9F73D72B8]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M14_L12
M14_L22:
       mov       rcx,r12
       call      qword ptr [7FF9F73D7480]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M14_L12
M14_L23:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M14_L25:
       mov       r8,[rsi+18]
       mov       ecx,[r12+1C]
       add       ecx,[r12+18]
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,225E887FF50
       xor       r9d,r9d
       call      qword ptr [7FF9F7755698]; System.Text.StringBuilder.Replace(System.String, System.String, Int32, Int32)
       jmp       near ptr M14_L15
M14_L26:
       call      M14_L50
       nop
       mov       rax,[rbp-90]
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
M14_L27:
       mov       rax,225E8870008
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
M14_L28:
       mov       rcx,r15
       call      00007FFA56D49590
       test      eax,eax
       je        short M14_L30
       mov       r12d,eax
M14_L29:
       jmp       near ptr M14_L01
M14_L30:
       mov       rcx,r15
       call      qword ptr [7FF9F73178D0]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       mov       r12d,eax
       jmp       short M14_L29
M14_L31:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M14_L02
       jmp       near ptr M14_L41
M14_L32:
       cmp       r12d,[rax+20]
       jne       near ptr M14_L40
       mov       [rbp-98],rax
       mov       rdx,[rax+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M14_L38
       test      rdx,rdx
       je        near ptr M14_L39
       cmp       rdx,rbx
       mov       rax,[rbp-98]
       jne       near ptr M14_L40
       jmp       near ptr M14_L03
M14_L33:
       xor       edi,edi
       xor       r14d,r14d
       jmp       near ptr M14_L05
M14_L34:
       mov       r13d,r15d
       shr       r13d,1
       or        r13d,r15d
       mov       ecx,r13d
       shr       ecx,2
       or        r13d,ecx
       mov       ecx,r13d
       shr       ecx,4
       or        r13d,ecx
       mov       ecx,r13d
       shr       ecx,8
       or        r13d,ecx
       mov       ecx,r13d
       shr       ecx,10
       or        r13d,ecx
       xor       ecx,ecx
       mov       [rbp-44],ecx
M14_L35:
       lea       rcx,[rbp-44]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-44]
       mov       edx,4
       call      qword ptr [7FF9F7554D38]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,r13d
       and       ecx,[rbp-44]
       cmp       ecx,r15d
       ja        short M14_L35
       mov       r13d,ecx
       jmp       near ptr M14_L06
M14_L36:
       call      qword ptr [7FF9F76CF0A8]
       mov       ecx,15
       mov       rdx,7FF9F7414FF0
       call      qword ptr [7FF9F713F300]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9F7415AC0
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FF9F7414FF0
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F77E65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F77E58C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M14_L37:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Data.Models.Country, System.String[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1E553801368
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GeneratePostalCode>b__83_0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      qword ptr [7FF9F7136BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1E553801378
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M14_L00
M14_L38:
       mov       rcx,r15
       mov       r8,rbx
       mov       r11,7FF9F7080D08
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-98]
       je        short M14_L40
       jmp       near ptr M14_L03
M14_L39:
       mov       rax,[rbp-98]
M14_L40:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M14_L32
M14_L41:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r12d
       shl       r9,20
       or        r9,1
       mov       rdx,r13
       mov       r8,rbx
       mov       rcx,r14
       call      qword ptr [7FF9F74CC870]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M14_L04
M14_L42:
       call      qword ptr [7FF9F7755530]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M14_L43
       call      qword ptr [7FF9F77E65B0]
       mov       rbx,rax
M14_L43:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,225E887FF10
       call      qword ptr [7FF9F77E58C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M14_L44:
       call      qword ptr [7FF9F77E4D68]
       int       3
M14_L45:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77555F0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M14_L46
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M14_L07
M14_L46:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M14_L08
M14_L47:
       call      qword ptr [7FF9F76CF0A8]
       mov       ecx,0BBE
       mov       rdx,7FF9F751DF40
       call      qword ptr [7FF9F713F300]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FF9F7415AC0
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FF9F751DF40
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F713DAA0]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F77E65B0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F77E58C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M14_L48:
       mov       rcx,r14
       call      qword ptr [7FF9F77E55F0]
       jmp       near ptr M14_L09
M14_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M14_L50:
       sub       rsp,48
       mov       r12,[rbp-88]
       cmp       dword ptr [r12+20],0
       jge       short M14_L51
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,3AD
       mov       rdx,7FF9F7074000
       call      qword ptr [7FF9F713F300]
       mov       rbx,rax
       call      qword ptr [7FF9F77E51D0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FF9F73DDB78]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M14_L51:
       cmp       qword ptr [r12+10],0
       jne       short M14_L52
       xor       ecx,ecx
       mov       [r12+18],rcx
       jmp       near ptr M14_L59
M14_L52:
       mov       ecx,[r12+1C]
       add       ecx,[r12+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M14_L53
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF9F77E5350]
       jmp       near ptr M14_L59
M14_L53:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FF9F77E5368]; System.Text.StringBuilder.FindChunkForIndex(Int32)
       mov       rbx,rax
       cmp       rbx,r12
       je        near ptr M14_L58
       mov       rax,[r12+8]
       mov       ecx,[rax+8]
       add       ecx,[r12+1C]
       mov       eax,[r12+1C]
       add       eax,[r12+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[r12+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M14_L56
       cmp       ecx,400
       jge       short M14_L54
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M14_L55
M14_L54:
       xor       edx,edx
       call      qword ptr [7FF9F76CF1C8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M14_L55:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF9F713F678]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M14_L57
M14_L56:
       mov       rdx,[rbx+8]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
M14_L57:
       mov       rdx,[rbx+10]
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r12+1C],ecx
M14_L58:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r12+18],ecx
M14_L59:
       mov       rdx,1E553801338
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r12
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M14_L61
M14_L60:
       add       rsp,48
       ret
M14_L61:
       cmp       qword ptr [rbx+20],0
       jne       short M14_L63
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M14_L62
       call      qword ptr [7FF9F77E4D68]
       int       3
M14_L62:
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFA56D53270
       test      rax,rax
       je        short M14_L60
M14_L63:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M14_L64
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77E57E8]
       test      eax,eax
       jne       short M14_L60
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FF9F77E5800]
       jmp       short M14_L60
M14_L64:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M14_L60
; Total bytes of code 2511
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetStateName(DotNetTips.Spargine.Tester.Data.Models.State)
; 		state?.Name ?? Core.ControlChars.EmptyString;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rcx,rcx
       je        short M15_L01
       mov       rax,[rcx+20]
M15_L00:
       mov       rcx,225E8870008
       test      rax,rax
       cmove     rax,rcx
       ret
M15_L01:
       xor       eax,eax
       jmp       short M15_L00
; Total bytes of code 31
```
```assembly
; DotNetTips.Spargine.Tester.RandomData+AddressComponents..ctor(System.String, System.String, System.String, System.String, System.String, System.String, System.String, System.String, System.String)
       push      rdi
       push      rsi
       push      rbx
       mov       rbx,rcx
       mov       rsi,r8
       mov       rdi,r9
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+18]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+20]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+28]
       mov       rdx,[rsp+50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+30]
       mov       rdx,[rsp+58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+38]
       mov       rdx,[rsp+60]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       lea       rcx,[rbx+40]
       mov       rdx,[rsp+68]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 133
```
```assembly
; DotNetTips.Spargine.Tester.RandomData+<>c.<.cctor>b__93_1(AddressComponents)
; 		[typeof(Address)] = c => new Address
; 		                         ^^^^^^^^^^^
; 		{
; 		 
; 			Id = c.Id,
; 			          
; 			Address1 = c.Address1,
; 			                      
; 			Address2 = c.Address2,
; 			                      
; 			City = c.CityName,
; 			                  
; 			Country = c.CountryName,
; 			                        
; 			CountyProvince = c.CountyProvince,
; 			                                  
; 			Phone = c.Phone,
; 			                
; 			PostalCode = c.PostalCode,
; 			                          
; 			State = c.StateName
; 			                   
; 		},
; 		 
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rdx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F7755CB0]; DotNetTips.Spargine.Tester.Models.RefTypes.Address..ctor()
       mov       rdx,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FF9F7542548]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Id(System.String)
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755CE0]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Address1(System.String)
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755CF8]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Address2(System.String)
       mov       rdx,[rbx+18]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755D10]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_City(System.String)
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755D28]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Country(System.String)
       mov       rdx,[rbx+28]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755D40]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_CountyProvince(System.String)
       mov       rdx,[rbx+30]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755D58]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Phone(System.String)
       mov       rdx,[rbx+38]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755D70]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_PostalCode(System.String)
       mov       rdx,[rbx+40]
       mov       rcx,rsi
       call      qword ptr [7FF9F7755D88]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_State(System.String)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 162
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
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M19_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M19_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M19_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M19_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M19_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M19_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M19_L03:
       cmp       ecx,8
       ja        short M19_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M19_L00]
       add       rdx,r8
       jmp       rdx
M19_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M19_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M19_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M19_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M19_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M19_L01
M19_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M19_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M19_L01
; Total bytes of code 269
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
       je        near ptr M20_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M20_L01
       test      rsi,rsi
       je        short M20_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M20_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M20_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M20_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M20_L01:
       test      rsi,rsi
       je        short M20_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M20_L03
M20_L02:
       mov       rax,225E8870008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M20_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M20_L04:
       call      qword ptr [7FF9F77E4BB8]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA3C44CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M21_L01
       cmp       [rax],ecx
       jle       short M21_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M21_L03
M21_L00:
       add       rsp,20
       pop       rbx
       ret
M21_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M21_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M21_L00
M21_L02:
       cmp       [rax+4],edx
       jle       short M21_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M21_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M21_L03
       jmp       short M21_L00
M21_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Random+ThreadSafeRandom.Next(Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       ebx,edx
       test      ebx,ebx
       jl        near ptr M22_L03
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M22_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M22_L04
M22_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M22_L01
       call      qword ptr [7FF9F77543F0]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M22_L01:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r8d,ebx
       shr       r11,20
       mov       r10d,r11d
       imul      r8,r10
       mov       r10d,r8d
       cmp       r10d,ebx
       jb        short M22_L05
M22_L02:
       mov       rax,r8
       shr       rax,20
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M22_L03:
       mov       ecx,21AC
       mov       rdx,7FF9F7074000
       call      qword ptr [7FF9F713F300]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FF9F77E46C0]
       int       3
M22_L04:
       mov       ecx,8
       call      qword ptr [7FF9F77E4960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M22_L00
M22_L05:
       mov       eax,ebx
       neg       eax
       xor       edx,edx
       div       ebx
       cmp       r10d,edx
       jae       short M22_L02
M22_L06:
       mov       r8,[rcx+8]
       mov       r10,[rcx+10]
       mov       rax,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,r10
       shl       r11,11
       xor       rax,r8
       xor       r9,r10
       lea       rsi,[r10+r10*4]
       rol       rsi,7
       lea       rsi,[rsi+rsi*8]
       xor       r10,rax
       xor       r8,r9
       xor       rax,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],r10
       mov       [rcx+18],rax
       mov       [rcx+20],r9
       mov       r8d,ebx
       shr       rsi,20
       mov       eax,esi
       imul      r8,rax
       mov       r10d,r8d
       cmp       r10d,edx
       jb        short M22_L06
       jmp       near ptr M22_L02
; Total bytes of code 344
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rsi,rdx
       call      qword ptr [7FFA602E5730]
       cmp       byte ptr [rax],0
       jne       short M23_L00
       mov       rcx,rbx
       call      qword ptr [7FFA602E7868]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFA602E56E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M23_L01
M23_L00:
       mov       rcx,rbx
       call      qword ptr [7FFA602E7870]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFA602E56E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        short M23_L02
       mov       rcx,rbx
       call      qword ptr [7FFA602E8218]
       mov       rcx,rax
       mov       rdx,rdi
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M23_L01:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
M23_L02:
       mov       rcx,rbx
       call      qword ptr [7FFA602E8220]
       mov       rcx,rax
       mov       rdx,rsi
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
; Total bytes of code 168
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],2
       jle       short M24_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M24_L02
M24_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M24_L01
       mov       rax,1E553800190
       mov       rax,[rax]
       test      rax,rax
       jne       short M24_L01
       mov       rax,1E553800170
       mov       rax,[rax]
       test      rax,rax
       je        short M24_L03
M24_L01:
       add       rsp,28
       ret
M24_L02:
       mov       ecx,2
       call      qword ptr [7FF9F77E4960]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M24_L00
M24_L03:
       add       rsp,28
       jmp       qword ptr [7FF9F713D590]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 115
```
```assembly
; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436C80]
       mov       rcx,rax
       call      qword ptr [7FFA3C434080]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       call      qword ptr [7FFA3C437568]
       mov       rcx,rax
       call      qword ptr [7FFA3C4340A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M26_L00
       cmp       [rdx],rcx
       jne       short M26_L01
M26_L00:
       mov       rax,rdx
       ret
M26_L01:
       jmp       qword ptr [7FF9F7314E10]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacterMinMax()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       edx,0FFFF
       call      qword ptr [7FF9F769C4E0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+60]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 48
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F753FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F772E0A0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74943D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F772E0B8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePersonRef()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rbx,rcx
       mov       rcx,1FBA4C01320
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L06
       mov       rdi,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rdi],rcx
       jne       near ptr M00_L15
       mov       rcx,23C39C4B808
       mov       [rsp+40],rcx
       xor       ecx,ecx
       mov       [rsp+38],rcx
       lea       rcx,[rsp+40]
       cmp       qword ptr [rsp+38],0
       jne       short M00_L00
       mov       rcx,[rsp+40]
       mov       [rsp+38],rcx
       lea       rcx,[rsp+38]
       cmp       qword ptr [rsp+38],0
       je        near ptr M00_L13
M00_L00:
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M00_L14
       mov       rcx,rbp
       call      00007FFA56D49590
       test      eax,eax
       je        near ptr M00_L07
M00_L01:
       mov       ebp,eax
M00_L02:
       xor       ecx,ecx
       mov       [rsp+38],rcx
M00_L03:
       mov       rcx,[rsi+8]
       mov       edx,ebp
       imul      rdx,[rsi+30]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       mov       r8d,eax
       imul      rdx,r8
       shr       rdx,20
       cmp       edx,eax
       jae       near ptr M00_L20
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       mov       r13d,[rsi+8]
       cmp       r13d,r14d
       jbe       short M00_L06
M00_L04:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rsi+rcx*8+10]
       cmp       [r12+10],ebp
       je        short M00_L08
M00_L05:
       mov       r14d,[r12+14]
       inc       r15d
       mov       r13d,[rsi+8]
       cmp       r13d,r15d
       jb        near ptr M00_L17
       cmp       r13d,r14d
       ja        short M00_L04
M00_L06:
       xor       r12d,r12d
       jmp       short M00_L10
M00_L07:
       mov       rcx,rbp
       call      qword ptr [7FF9F72F77F8]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L01
M00_L08:
       mov       r14,[r12]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rdi],rcx
       jne       near ptr M00_L16
       test      r14,r14
       je        short M00_L05
       mov       rcx,offset MT_System.RuntimeType
       cmp       [r14],rcx
       jne       near ptr M00_L12
       mov       rcx,23C39C4B808
       cmp       r14,rcx
       sete      r13b
       movzx     r13d,r13b
M00_L09:
       test      r13d,r13d
       je        short M00_L05
       add       r12,8
M00_L10:
       test      r12,r12
       je        near ptr M00_L19
       mov       rax,[r12]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L11
       mov       r8,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rcx],r8
       jne       near ptr M00_L18
M00_L11:
       mov       [rsp+30],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       edx,edx
       mov       [rbx+8],rdx
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L12:
       mov       rcx,r14
       mov       rdx,23C39C4B808
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       mov       r13d,eax
       jmp       near ptr M00_L09
M00_L13:
       xor       ebp,ebp
       jmp       near ptr M00_L02
M00_L14:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L02
M00_L15:
       mov       rcx,rdi
       mov       r11,7FF9F7070CE0
       mov       rdx,23C39C4B808
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L16:
       mov       rcx,rdi
       mov       rdx,r14
       mov       r11,7FF9F7070CE8
       mov       r8,23C39C4B808
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L09
M00_L17:
       call      qword ptr [7FF9F712F498]
       int       3
M00_L18:
       mov       rdx,rax
       mov       rcx,r8
       call      qword ptr [7FF9F7126328]; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L19:
       call      qword ptr [7FF9F712D308]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,23C39C4B808
       call      qword ptr [7FF9F706A310]; Precode of System.RuntimeType.get_FullName()
       mov       rdi,rax
       mov       ecx,435
       mov       rdx,7FF9F73F4FF0
       call      qword ptr [7FF9F712F228]
       mov       [rsp+20],rax
       mov       r9,rdi
       mov       r8,1FBA4C01300
       mov       r8,[r8]
       mov       rdx,rbx
       mov       rcx,7FF9F75717D0
       call      qword ptr [7FF9F7534CF0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F712F240]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 796
```
```assembly
; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
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
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       je        short M01_L01
       lea       rcx,[rbp+10]
       mov       [rbp-98],rcx
       lea       rcx,[rbp-90]
       call      qword ptr [7FFA3C434030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-98]
       call      qword ptr [rax]
       mov       ebx,eax
       lea       rcx,[rbp-90]
       call      qword ptr [7FFA3C434038]; CORINFO_HELP_JIT_PINVOKE_END
       mov       eax,ebx
M01_L00:
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
M01_L01:
       xor       eax,eax
       jmp       short M01_L00
; Total bytes of code 119
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       test      rdx,rdx
       je        short M02_L00
       cmp       [rdx],rcx
       jne       short M02_L01
M02_L00:
       mov       rax,rdx
       ret
M02_L01:
       jmp       qword ptr [7FF9F72F4D38]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       short M03_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M03_L02
M03_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M03_L01
       mov       rax,1FBA4C00190
       mov       rax,[rax]
       test      rax,rax
       jne       short M03_L01
       mov       rax,1FBA4C00170
       mov       rax,[rax]
       test      rax,rax
       je        short M03_L03
M03_L01:
       add       rsp,28
       ret
M03_L02:
       mov       ecx,2
       call      qword ptr [7FF9F773E568]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L03:
       add       rsp,28
       jmp       qword ptr [7FF9F712D4B8]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 115
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileNameWithPath()
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
       mov       rsi,[rbx+138]
       mov       ecx,0A
       call      qword ptr [7FF9F776DAD0]; DotNetTips.Spargine.Tester.RandomData.GenerateFileNameWord(Int32)
       mov       rdi,rax
       mov       rcx,offset MT_System.String
       mov       edx,1
       call      00007FFA56DB9D30
       mov       rbp,rax
       mov       word ptr [rbp+0C],2E
       test      rdi,rdi
       je        near ptr M00_L06
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L06
       mov       r15d,[rbp+8]
       test      r15d,r15d
       je        near ptr M00_L07
       mov       r13d,r14d
       mov       edx,r15d
       lea       rdx,[r13+rdx+0F]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L08
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+28]
       lea       rcx,[rdi+r13*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    rax,r14d
       lea       rax,[rdi+rax*2]
       vmovups   xmm0,[7FF9F71F9280]
       vmovups   [rax],xmm0
       mov       rcx,74002E00730070
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],6D0065
       mov       word ptr [rax+1C],70
M00_L00:
       test      rsi,rsi
       je        near ptr M00_L09
       test      r12,r12
       je        near ptr M00_L10
       cmp       dword ptr [rsi+8],0
       je        near ptr M00_L05
       cmp       dword ptr [r12+8],0
       je        near ptr M00_L04
       lea       rcx,[r12+0C]
       mov       eax,[r12+8]
       mov       [rsp+50],rcx
       mov       [rsp+58],eax
       lea       rcx,[rsp+50]
       call      qword ptr [7FF9F73DD8C0]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       jne       near ptr M00_L05
       lea       rdi,[rsi+0C]
       mov       esi,[rsi+8]
       lea       rbp,[r12+0C]
       mov       r12d,[r12+8]
       lea       ecx,[rsi-1]
       movzx     ecx,word ptr [rdi+rcx*2]
       cmp       ecx,5C
       je        short M00_L02
       cmp       ecx,2F
       je        short M00_L02
       movzx     ecx,word ptr [rbp]
       cmp       ecx,5C
       je        near ptr M00_L11
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L01:
       test      ecx,ecx
       jne       short M00_L02
       mov       rcx,2C3FF317394
       mov       [rsp+50],rdi
       mov       [rsp+58],esi
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1
       mov       [rsp+30],rbp
       mov       [rsp+38],r12d
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       call      qword ptr [7FF9F73DD8F0]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+50],rdi
       mov       [rsp+58],esi
       mov       [rsp+40],rbp
       mov       [rsp+48],r12d
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       call      qword ptr [7FF9F74CDA58]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r12,rax
M00_L03:
       jmp       short M00_L05
M00_L04:
       mov       r12,rsi
M00_L05:
       mov       [rsp+60],r12
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+60]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L06:
       mov       rcx,rbp
       mov       rdx,2C3FF3209C0
       call      qword ptr [7FF9F714D9C8]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rdi
       mov       rdx,2C3FF3209C0
       call      qword ptr [7FF9F714D9C8]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FF9F77F4990]
       int       3
M00_L09:
       mov       ecx,1C47C
       mov       rdx,7FF9F7084000
       call      qword ptr [7FF9F714F228]
       mov       rcx,rax
       call      qword ptr [7FF9F77F4168]
       int       3
M00_L10:
       mov       ecx,1C488
       mov       rdx,7FF9F7084000
       call      qword ptr [7FF9F714F228]
       mov       rcx,rax
       call      qword ptr [7FF9F77F4168]
       int       3
M00_L11:
       mov       ecx,1
       jmp       near ptr M00_L01
; Total bytes of code 707
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFileNameWord(Int32)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,6208D857322E
       mov       [rbp+8],rax
       mov       ebx,ecx
; 		Span<byte> randomBytes = stackalloc byte[length];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rsi
       jne       short M01_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M01_L01:
       test      ebx,ebx
       jl        near ptr M01_L10
       mov       edi,ebx
; 		RandomNumberGenerator.Fill(randomBytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edi,edi
       jle       short M01_L02
       mov       rcx,rsi
       mov       [rbp+18],rcx
       mov       edx,edi
       call      qword ptr [7FF9F7554C60]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+18],rcx
M01_L02:
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		var charBuffer = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,2836A400C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F7410D08]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       rdx,rax
       mov       [rbp+10],rdx
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       test      edi,edi
       jle       short M01_L04
       test      rdx,rdx
       je        short M01_L05
       cmp       [rdx+8],edi
       jl        short M01_L05
; 				charBuffer[wordIndex] = (char)(DefaultMinCharacterRandomFile + (randomBytes[wordIndex] % range));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       r8d,ecx
       movzx     eax,byte ptr [rsi+r8]
       mov       r10d,eax
       imul      r10,4EC4EC4F
       shr       r10,23
       imul      r10d,1A
       sub       eax,r10d
       add       eax,41
       jo        short M01_L07
       cmp       eax,0FFFF
       ja        short M01_L07
       mov       [rdx+r8*2+10],ax
       add       ecx,1
       jo        short M01_L07
       cmp       ecx,ebx
       jl        short M01_L03
; 			return new string(charBuffer, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       mov       rcx,rdx
       mov       r8d,ebx
       xor       edx,edx
       call      System.String.Ctor(Char[], Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       mov       eax,ecx
       movzx     r8d,byte ptr [rsi+rax]
       mov       eax,r8d
       imul      rax,4EC4EC4F
       shr       rax,23
       imul      eax,1A
       sub       r8d,eax
       add       r8d,41
       jo        short M01_L07
       cmp       r8d,0FFFF
       ja        short M01_L07
       mov       eax,r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L06
       mov       r8d,ecx
       mov       [rdx+r8*2+10],ax
       add       ecx,1
       jo        short M01_L07
       cmp       ecx,edi
       jl        short M01_L05
       jmp       short M01_L04
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			ArrayPool<char>.Shared.Return(charBuffer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L08:
       mov       rcx,r14
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F7410D10]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
       mov       rax,rbx
       mov       r8,6208D857322E
       cmp       [rbp+8],r8
       je        short M01_L09
       call      CORINFO_HELP_FAIL_FAST
M01_L09:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L10:
       call      qword ptr [7FF9F731F228]
       int       3
       sub       rsp,28
       mov       rcx,2836A400C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F7410D10]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
       nop
       add       rsp,28
       ret
; Total bytes of code 419
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L11
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
       ja        short M02_L06
M02_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L02:
       vzeroupper
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L12
       cmp       r8,100
       jae       near ptr M02_L10
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
       ja        short M02_L00
       jmp       short M02_L01
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L07:
       test      r8b,18
       jne       short M02_L08
       test      r8b,4
       jne       short M02_L09
       test      r8,r8
       je        short M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M02_L02
M02_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M02_L02
M02_L09:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M02_L02
M02_L10:
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
       jmp       near ptr M02_L04
M02_L11:
       cmp       rcx,rdx
       jne       short M02_L12
       cmp       [rdx],dl
       jmp       near ptr M02_L02
M02_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71466E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 340
```
```assembly
; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M03_L00
       movzx     eax,word ptr [rdx]
       cmp       eax,5C
       je        short M03_L01
       cmp       eax,2F
       je        short M03_L01
M03_L00:
       cmp       ecx,2
       jl        short M03_L02
       movzx     eax,word ptr [rdx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        short M03_L02
       cmp       word ptr [rdx+2],3A
       sete      al
       movzx     eax,al
       ret
M03_L01:
       mov       eax,1
       ret
M03_L02:
       xor       eax,eax
       ret
; Total bytes of code 63
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,[r8]
       mov       esi,[r8+8]
       mov       rdi,[rdx]
       mov       ebp,[rdx+8]
       mov       r14,[rcx]
       mov       r15d,[rcx+8]
       mov       edx,r15d
       add       edx,ebp
       jo        near ptr M04_L02
       add       edx,esi
       jo        near ptr M04_L02
       test      edx,edx
       je        near ptr M04_L00
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r13,rax
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+34],eax
       cmp       r15d,eax
       ja        near ptr M04_L01
       mov       r10d,r15d
       add       r10,r10
       mov       [rsp+28],r10
       mov       r8,r10
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,[rsp+28]
       add       r14,r12
       mov       r12d,[rsp+34]
       sub       r12d,r15d
       cmp       ebp,r12d
       ja        short M04_L01
       mov       r15d,ebp
       add       r15,r15
       mov       r8,r15
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+r15]
       sub       r12d,ebp
       cmp       esi,r12d
       ja        short M04_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
M04_L00:
       mov       rax,2C3FF310008
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
M04_L01:
       call      qword ptr [7FF9F755CDF8]
       int       3
M04_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 260
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx]
       mov       ebp,[rcx+8]
       mov       ecx,ebp
       add       ecx,esi
       jo        near ptr M05_L02
       test      ecx,ecx
       je        short M05_L00
       movsxd    rcx,ecx
       call      qword ptr [7FFA3C4469D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        short M05_L01
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M05_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
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
M05_L00:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
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
M05_L01:
       call      qword ptr [7FFA3C44A280]
       int       3
M05_L02:
       call      qword ptr [7FFA3C433FD0]
       int       3
; Total bytes of code 176
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
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7145818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2C3FF310008
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
       call      qword ptr [7FF9F77F4990]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,61
       mov       edx,7A
       call      qword ptr [7FF9F76BC4F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+60]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 51
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F755FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F774E0B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74B43D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F774DFB0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rsi
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       mov       rax,5E86836DE8DA
       mov       [rsp+50],rax
       mov       rbx,rcx
       lea       rsi,[rsp+20]
       mov       [rsp+40],rsi
       mov       rcx,rsi
       mov       edx,0C
       call      qword ptr [7FF9F7524C60]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rsp+40],rcx
       mov       rcx,27863CAB768
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M00_L02
       call      qword ptr [7FF9F72E5680]; System.RuntimeType.CreateInstanceOfT()
M00_L00:
       xor       ecx,ecx
       mov       [rsp+38],rcx
       mov       ecx,[rsi]
       mov       [rax+8],ecx
       mov       ecx,[rsi+4]
       mov       [rax+0C],ecx
       mov       ecx,[rsi+8]
       mov       [rax+10],ecx
       mov       [rsp+30],rax
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+30]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       mov       r8,5E86836DE8DA
       cmp       [rsp+50],r8
       je        short M00_L01
       call      CORINFO_HELP_FAIL_FAST
M00_L01:
       nop
       add       rsp,58
       pop       rbx
       pop       rsi
       ret
M00_L02:
       xor       edx,edx
       mov       [rsp+38],rdx
       lea       rdx,[rsp+38]
       call      qword ptr [7FF9F772E238]
       mov       rax,[rsp+38]
       jmp       short M00_L00
; Total bytes of code 221
```
```assembly
; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       vzeroupper
       lea       rbp,[rsp+90]
       mov       rbx,rcx
       mov       esi,edx
       lea       rcx,[rbp-70]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       r8,rsp
       mov       [rbp-58],r8
       mov       r8,rbp
       mov       [rbp-48],r8
       mov       r8d,esi
       mov       rdx,rbx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F753FB28
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L00:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L01
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-68]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L02
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
M01_L02:
       mov       ecx,eax
       call      qword ptr [7FF9F772E148]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 186
```
```assembly
; System.RuntimeType.CreateInstanceOfT()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       lea       rbp,[rsp+40]
       mov       rbx,rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       mov       rax,[rcx]
       test      rax,rax
       je        short M02_L02
M02_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M02_L04
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M02_L03
       mov       rsi,rdx
M02_L01:
       cmp       byte ptr [rsi+28],0
       je        short M02_L05
       mov       rax,[rsi+8]
       mov       rcx,[rsi+10]
       call      rax
       mov       rdi,rax
       mov       rax,[rsi+18]
       mov       rcx,rdi
       call      rax
       nop
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L02:
       mov       rcx,rbx
       call      qword ptr [7FF9F72E56E0]; System.RuntimeType.InitializeCache()
       jmp       short M02_L00
M02_L03:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M02_L04
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M02_L04
       jmp       short M02_L01
M02_L04:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FF9F72E5F38]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M02_L01
M02_L05:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F772E280]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9F772E298]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F772E2B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       sub       rsp,28
       mov       rdi,rcx
       mov       rcx,offset MT_System.Reflection.TargetInvocationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9F772E2C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 271
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDecimal()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D0
       xor       eax,eax
       mov       [rsp+0C8],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+0C8],1
       xor       ecx,ecx
       mov       [rsp+0CC],ecx
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rsp+0B8],xmm0
       mov       qword ptr [rsp+0C0],64
       mov       [rsp+0B8],ecx
       mov       esi,[rsp+0B8]
       mov       edi,[rsp+0BC]
       mov       rbp,[rsp+0C0]
       vmovups   [rsp+0A8],xmm0
       mov       [rsp+98],esi
       mov       [rsp+9C],edi
       mov       [rsp+0A0],rbp
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+98]
       call      qword ptr [7FF9F774DB48]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+0A8]
       vmovups   [rsp+88],xmm0
       mov       edx,[rsp+88]
       test      edx,0FF0000
       je        short M00_L00
       sar       edx,10
       movzx     edx,dl
       lea       rcx,[rsp+88]
       mov       r8d,2
       call      qword ptr [7FF9F77D4D50]
M00_L00:
       mov       ecx,[rsp+8C]
       mov       rdx,[rsp+90]
       shr       rdx,20
       or        ecx,edx
       jne       near ptr M00_L07
       mov       r14d,[rsp+90]
       mov       ecx,[rsp+88]
       test      ecx,ecx
       jge       short M00_L01
       neg       r14d
       test      r14d,r14d
       jle       short M00_L02
       jmp       near ptr M00_L07
M00_L01:
       test      r14d,r14d
       jl        near ptr M00_L07
M00_L02:
       xor       ecx,ecx
       mov       [rsp+78],ecx
       mov       [rsp+7C],ecx
       mov       qword ptr [rsp+80],3E8
       mov       [rsp+68],esi
       mov       [rsp+6C],edi
       mov       [rsp+70],rbp
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+68]
       call      qword ptr [7FF9F774DB48]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+58],xmm0
       mov       edx,[rsp+58]
       test      edx,0FF0000
       je        short M00_L03
       sar       edx,10
       movzx     edx,dl
       lea       rcx,[rsp+58]
       mov       r8d,2
       call      qword ptr [7FF9F77D4D50]
M00_L03:
       mov       ecx,[rsp+5C]
       mov       rdx,[rsp+60]
       shr       rdx,20
       or        ecx,edx
       jne       near ptr M00_L08
       mov       ecx,[rsp+60]
       mov       edx,[rsp+58]
       test      edx,edx
       jge       short M00_L04
       neg       ecx
       test      ecx,ecx
       jle       short M00_L05
       jmp       near ptr M00_L08
M00_L04:
       test      ecx,ecx
       jl        near ptr M00_L08
M00_L05:
       mov       edx,r14d
       add       edx,1
       jo        near ptr M00_L10
       cmp       ecx,edx
       cmovge    edx,ecx
       mov       ecx,r14d
       call      qword ptr [7FF9F7744210]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       test      eax,eax
       jl        near ptr M00_L09
       xor       ecx,ecx
M00_L06:
       mov       edx,eax
       mov       [rsp+48],ecx
       xor       ecx,ecx
       mov       [rsp+4C],ecx
       mov       [rsp+50],rdx
       mov       [rsp+38],esi
       mov       [rsp+3C],edi
       mov       [rsp+40],rbp
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FF9F774DB78]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+48]
       vmovups   [rsp+28],xmm0
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F774DCB0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       nop
       add       rsp,0D0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M00_L07:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77D4D68]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F77D4D80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77D4D68]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F77D4D80]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L09:
       mov       ecx,80000000
       neg       eax
       jmp       near ptr M00_L06
M00_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 661
```
```assembly
; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       push      rsi
       push      rbx
       sub       rsp,68
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx]
       add       eax,[rsi]
       shr       eax,10
       movzx     r8d,al
       mov       eax,[rbx+4]
       or        eax,[rbx+0C]
       jne       near ptr M01_L08
       mov       eax,[rsi+4]
       or        eax,[rsi+0C]
       jne       near ptr M01_L06
       mov       ecx,[rbx+8]
       mov       r10d,[rsi+8]
       imul      rcx,r10
       cmp       r8d,1C
       jg        short M01_L03
M01_L00:
       mov       [rbx+8],rcx
M01_L01:
       mov       eax,[rsi]
       xor       eax,[rbx]
       and       eax,80000000
       mov       ecx,r8d
       shl       ecx,10
       or        eax,ecx
       mov       [rbx],eax
M01_L02:
       add       rsp,68
       pop       rbx
       pop       rsi
       ret
M01_L03:
       cmp       r8d,2F
       jg        near ptr M01_L18
       add       r8d,0FFFFFFE3
       mov       eax,r8d
       mov       rdx,7FFA3B7D89E0
       mov       r8,[rdx+rax*8]
       mov       rax,rcx
       xor       edx,edx
       div       r8
       mov       rdx,rax
       imul      rdx,r8
       sub       rcx,rdx
       mov       rdx,rax
       shr       r8,1
       cmp       rcx,r8
       jb        short M01_L05
       ja        short M01_L04
       test      al,1
       je        short M01_L05
M01_L04:
       lea       rdx,[rax+1]
M01_L05:
       mov       r8d,1C
       mov       rcx,rdx
       jmp       short M01_L00
M01_L06:
       mov       rdx,[rsi+8]
       mov       ecx,[rbx+8]
       lea       rax,[rsp+48]
       mulx      rdx,r10,rcx
       mov       [rax],r10
       mov       rcx,[rsp+48]
       mov       rax,rdx
       mov       [rsp+50],rcx
       cmp       dword ptr [rsi+4],0
       je        short M01_L09
       mov       eax,[rbx+8]
       mov       ecx,[rsi+4]
       imul      rax,rcx
       add       rax,rdx
       mov       rdx,rax
       shr       rdx,20
       je        short M01_L09
M01_L07:
       mov       [rsp+58],rax
       mov       edx,3
       jmp       near ptr M01_L15
M01_L08:
       mov       edx,[rsi+4]
       or        edx,[rsi+0C]
       jne       short M01_L11
       mov       rdx,[rbx+8]
       mov       eax,[rsi+8]
       lea       rcx,[rsp+40]
       mulx      rax,r10,rax
       mov       [rcx],r10
       mov       rdx,[rsp+40]
       mov       rcx,rax
       mov       [rsp+50],rdx
       cmp       dword ptr [rbx+4],0
       je        short M01_L10
       mov       ecx,[rsi+8]
       mov       edx,[rbx+4]
       imul      rcx,rdx
       add       rcx,rax
       mov       rdx,rcx
       shr       rdx,20
       mov       rax,rcx
       jne       short M01_L07
M01_L09:
       mov       [rsp+58],eax
       mov       edx,2
       jmp       near ptr M01_L14
M01_L10:
       mov       rax,rcx
       jmp       short M01_L09
M01_L11:
       mov       rdx,[rbx+8]
       mov       rax,[rsi+8]
       lea       rcx,[rsp+38]
       mulx      rax,r10,rax
       mov       [rcx],r10
       mov       rdx,[rsp+38]
       mov       rcx,rdx
       mov       [rsp+50],rcx
       mov       edx,[rbx+4]
       or        edx,[rsi+4]
       je        short M01_L12
       mov       r10d,[rbx+4]
       mov       r9d,[rsi+4]
       imul      r10,r9
       mov       rdx,[rbx+8]
       mov       ecx,[rsi+4]
       lea       r9,[rsp+30]
       mulx      rdx,r11,rcx
       mov       [r9],r11
       mov       rcx,[rsp+30]
       add       r10,rdx
       add       rax,rcx
       lea       rdx,[r10+1]
       cmp       rax,rcx
       cmovb     r10,rdx
       mov       rdx,[rsi+8]
       mov       ecx,[rbx+4]
       lea       r9,[rsp+28]
       mulx      rcx,r11,rcx
       mov       [r9],r11
       mov       rdx,[rsp+28]
       add       r10,rcx
       add       rax,rdx
       lea       rcx,[r10+1]
       cmp       rax,rdx
       cmovb     r10,rcx
       mov       [rsp+58],rax
       mov       [rsp+60],r10
       mov       edx,5
       jmp       short M01_L14
M01_L12:
       mov       [rsp+58],rax
       mov       edx,3
       jmp       short M01_L14
M01_L13:
       test      edx,edx
       je        short M01_L18
       dec       edx
M01_L14:
       lea       rcx,[rsp+50]
       mov       eax,edx
       cmp       dword ptr [rcx+rax*4],0
       je        short M01_L13
M01_L15:
       cmp       edx,2
       ja        short M01_L16
       cmp       r8d,1C
       jle       short M01_L17
M01_L16:
       lea       rcx,[rsp+50]
       call      qword ptr [7FF9F77D4D38]
       mov       r8d,eax
M01_L17:
       mov       rax,[rsp+50]
       mov       [rbx+8],rax
       mov       eax,[rsp+58]
       mov       [rbx+4],eax
       jmp       near ptr M01_L01
M01_L18:
       vxorps    xmm0,xmm0,xmm0
       vmovups   [rbx],xmm0
       jmp       near ptr M01_L02
; Total bytes of code 587
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F754FB28
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
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
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77D4EA0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74A43D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F77D4420]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,60
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx]
       sub       eax,[rsi]
       shr       eax,10
       movsx     rdi,al
       xor       ebp,ebp
       mov       eax,[rsi+4]
       or        eax,[rsi+0C]
       jne       near ptr M03_L32
       mov       r8d,[rsi+8]
       test      r8d,r8d
       je        near ptr M03_L13
       mov       rax,[rbx+8]
       mov       [rsp+50],rax
       mov       eax,[rbx+4]
       mov       [rsp+58],eax
       xor       edx,edx
       cmp       dword ptr [rsp+58],0
       jne       near ptr M03_L14
       mov       eax,[rsp+54]
       cmp       eax,r8d
       jae       near ptr M03_L15
       mov       edx,eax
       xor       eax,eax
       mov       [rsp+54],eax
M03_L00:
       mov       eax,[rsp+50]
       div       r8d
       mov       [rsp+50],eax
       mov       ecx,edx
M03_L01:
       test      ecx,ecx
       je        near ptr M03_L05
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M03_L31
       mov       edx,[rsp+58]
       mov       rax,[rsp+50]
       xor       r10d,r10d
       cmp       edx,19999999
       ja        near ptr M03_L20
       mov       r10,2781DC001C0
       mov       r10,[r10]
       cmp       edi,13
       jg        near ptr M03_L19
       cmp       edx,4
       jae       near ptr M03_L21
M03_L02:
       mov       r14d,9
M03_L03:
       test      r14d,r14d
       je        near ptr M03_L31
M03_L04:
       cmp       r14d,0A
       jae       near ptr M03_L53
       mov       edx,r14d
       mov       rax,7FFA3B7D2B70
       mov       r15d,[rax+rdx*4]
       add       edi,r14d
       mov       rdx,[rsp+50]
       mov       eax,r15d
       lea       r10,[rsp+28]
       mulx      rdx,r9,rax
       mov       [r10],r9
       mov       r10,[rsp+28]
       mov       [rsp+50],r10
       mov       r10d,[rsp+58]
       imul      r10,rax
       add       rdx,r10
       mov       [rsp+58],edx
       shr       rdx,20
       test      edx,edx
       jne       near ptr M03_L52
       mov       edx,ecx
       imul      rax,rdx
       mov       rdx,rax
       shr       rdx,20
       div       r8d
       mov       ecx,edx
       mov       r10d,eax
       add       r10,[rsp+50]
       mov       [rsp+50],r10
       cmp       r10,rax
       jae       near ptr M03_L01
       mov       eax,[rsp+58]
       inc       eax
       mov       [rsp+58],eax
       test      eax,eax
       jne       near ptr M03_L01
       test      edx,edx
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FF9F77D4F00]
       mov       edi,eax
       jmp       short M03_L06
M03_L05:
       test      edi,edi
       jl        near ptr M03_L16
M03_L06:
       test      ebp,ebp
       je        near ptr M03_L50
       mov       eax,[rsp+50]
       mov       rcx,[rsp+54]
       test      al,al
       je        near ptr M03_L12
M03_L07:
       test      al,0F
       jne       short M03_L08
       cmp       edi,4
       jl        short M03_L08
       mov       rdx,346DC5D63886594B
       mulx      r8,r8,rcx
       shr       r8,0B
       imul      rdx,r8,2710
       mov       r10,rcx
       sub       r10,rdx
       shl       r10,20
       mov       edx,eax
       add       rdx,r10
       mov       r10,346DC5D63886594B
       mulx      rdx,rdx,r10
       shr       rdx,0B
       imul      r10d,edx,2710
       cmp       eax,r10d
       jne       short M03_L08
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFFC
M03_L08:
       test      al,3
       jne       short M03_L09
       cmp       edi,2
       jl        short M03_L09
       mov       r8,28F5C28F5C28F5C3
       mov       rdx,rcx
       shr       rdx,2
       mulx      r8,r8,r8
       shr       r8,2
       imul      rdx,r8,64
       mov       r10,rcx
       sub       r10,rdx
       shl       r10,20
       mov       edx,eax
       add       rdx,r10
       mov       r10,28F5C28F5C28F5C3
       shr       rdx,2
       mulx      rdx,rdx,r10
       shr       rdx,2
       imul      r10d,edx,64
       cmp       eax,r10d
       jne       short M03_L09
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFFE
M03_L09:
       test      al,1
       jne       short M03_L10
       test      edi,edi
       jle       short M03_L10
       mov       rdx,0CCCCCCCCCCCCCCCD
       mulx      r8,r8,rcx
       shr       r8,3
       lea       rdx,[r8+r8*4]
       add       rdx,rdx
       mov       r10,rcx
       sub       r10,rdx
       shl       r10,20
       mov       edx,eax
       add       rdx,r10
       mov       r10,0CCCCCCCCCCCCCCCD
       mulx      rdx,rdx,r10
       shr       rdx,3
       lea       r10d,[rdx+rdx*4]
       add       r10d,r10d
       cmp       eax,r10d
       jne       short M03_L10
       mov       rcx,r8
       mov       eax,edx
       dec       edi
M03_L10:
       mov       [rbx+8],eax
       mov       [rbx+0C],ecx
       shr       rcx,20
       mov       [rbx+4],ecx
M03_L11:
       mov       eax,[rbx]
       xor       eax,[rsi]
       and       eax,80000000
       mov       ecx,edi
       shl       ecx,10
       or        eax,ecx
       mov       [rbx],eax
       add       rsp,60
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M03_L12:
       cmp       edi,8
       jl        near ptr M03_L07
       mov       rdx,0ABCC77118461CEFD
       mulx      r8,r8,rcx
       shr       r8,1A
       imul      rdx,r8,5F5E100
       mov       r10,rcx
       sub       r10,rdx
       shl       r10,20
       mov       edx,eax
       add       rdx,r10
       mov       r10,0ABCC77118461CEFD
       mulx      rdx,rdx,r10
       shr       rdx,1A
       imul      r10d,edx,5F5E100
       cmp       eax,r10d
       jne       near ptr M03_L07
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFF8
       test      al,al
       jne       near ptr M03_L07
       jmp       short M03_L12
M03_L13:
       mov       rcx,offset MT_System.DivideByZeroException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F77D4EE8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M03_L14:
       mov       eax,[rsp+58]
       xor       edx,edx
       div       r8d
       mov       [rsp+58],eax
M03_L15:
       mov       eax,[rsp+54]
       div       r8d
       mov       [rsp+54],eax
       jmp       near ptr M03_L00
M03_L16:
       mov       r14d,edi
       neg       r14d
       cmp       r14d,9
       jge       short M03_L17
       mov       edx,r14d
       jmp       short M03_L18
M03_L17:
       mov       edx,9
M03_L18:
       mov       r14d,edx
       jmp       near ptr M03_L04
M03_L19:
       mov       r9d,edi
       neg       r9d
       add       r9d,1C
       lea       r11d,[r9-1]
       cmp       r11d,8
       jae       near ptr M03_L53
       lea       r11d,[r9-1]
       shl       r11,4
       cmp       [r10+r11+10],edx
       jbe       short M03_L22
       mov       r10d,r9d
M03_L20:
       lea       edx,[r10+rdi]
       test      edx,edx
       jge       near ptr M03_L30
       jmp       near ptr M03_L52
M03_L21:
       cmp       edx,4
       jne       short M03_L22
       mov       r9,4B82FA09B5A52CB9
       cmp       rax,r9
       jbe       near ptr M03_L02
M03_L22:
       cmp       edx,0A7C5
       jbe       short M03_L24
       cmp       edx,418937
       jbe       short M03_L23
       mov       r9d,2
       cmp       edx,28F5C28
       jbe       short M03_L27
       jmp       short M03_L25
M03_L23:
       mov       r9d,4
       cmp       edx,68DB8
       jbe       short M03_L27
       jmp       short M03_L25
M03_L24:
       cmp       edx,1AD
       jbe       short M03_L26
       mov       r9d,6
       cmp       edx,10C6
       jbe       short M03_L27
M03_L25:
       dec       r9d
       jmp       short M03_L27
M03_L26:
       mov       r9d,8
       cmp       edx,2A
       ja        short M03_L25
M03_L27:
       lea       r11d,[r9-1]
       shl       r11,4
       cmp       [r10+r11+10],edx
       jne       short M03_L29
       lea       edx,[r9-1]
       shl       rdx,4
       cmp       [r10+rdx+18],rax
       jae       short M03_L28
       dec       r9d
       mov       r10d,r9d
       jmp       near ptr M03_L20
M03_L28:
       mov       r10d,r9d
       jmp       near ptr M03_L20
M03_L29:
       mov       r10d,r9d
       jmp       near ptr M03_L20
M03_L30:
       mov       r14d,r10d
       jmp       near ptr M03_L03
M03_L31:
       lea       r13d,[rcx+rcx]
       cmp       r13d,ecx
       jb        near ptr M03_L48
       cmp       r13d,r8d
       jb        near ptr M03_L06
       ja        near ptr M03_L48
       test      byte ptr [rsp+50],1
       je        near ptr M03_L06
       jmp       near ptr M03_L48
M03_L32:
       mov       r13d,[rsi+4]
       test      r13d,r13d
       jne       short M03_L33
       mov       r13d,[rsi+0C]
M03_L33:
       xor       r14d,r14d
       lzcnt     r14d,r13d
       shlx      rax,[rbx+8],r14
       mov       [rsp+40],rax
       mov       eax,[rbx+0C]
       mov       edx,[rbx+4]
       shl       rdx,20
       add       rax,rdx
       mov       edx,r14d
       neg       edx
       add       edx,20
       shrx      rax,rax,rdx
       mov       [rsp+48],rax
       shlx      r13,[rsi+8],r14
       cmp       dword ptr [rsi+4],0
       jne       near ptr M03_L41
       xor       eax,eax
       mov       [rsp+58],eax
       mov       rax,[rsp+40]
       mov       rdx,[rsp+48]
       div       r13
       mov       [rsp+40],rdx
       mov       [rsp+50],rax
M03_L34:
       cmp       qword ptr [rsp+40],0
       jne       short M03_L37
       test      edi,edi
       jge       near ptr M03_L06
       mov       r14d,edi
       neg       r14d
       cmp       r14d,9
       jge       short M03_L35
       mov       ecx,r14d
       jmp       short M03_L36
M03_L35:
       mov       ecx,9
M03_L36:
       mov       r14d,ecx
       jmp       short M03_L38
M03_L37:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M03_L39
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FF9F774DB90]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M03_L39
M03_L38:
       cmp       r14d,0A
       jae       near ptr M03_L53
       mov       ecx,r14d
       mov       rdx,7FFA3B7D2B70
       mov       r15d,[rdx+rcx*4]
       add       edi,r14d
       lea       rcx,[rsp+50]
       mov       edx,r15d
       call      qword ptr [7FF9F774DC20]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M03_L52
       lea       rcx,[rsp+40]
       mov       edx,r15d
       call      qword ptr [7FF9F77D4F18]
       lea       rcx,[rsp+40]
       mov       rdx,r13
       call      qword ptr [7FF9F77D4F30]
       mov       edx,eax
       lea       rcx,[rsp+50]
       call      qword ptr [7FF9F774DC50]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M03_L34
       jmp       short M03_L40
M03_L39:
       mov       rcx,[rsp+40]
       test      rcx,rcx
       jl        near ptr M03_L48
       add       rcx,rcx
       cmp       rcx,r13
       ja        near ptr M03_L48
       jne       near ptr M03_L06
       test      byte ptr [rsp+50],1
       je        near ptr M03_L06
       jmp       near ptr M03_L48
M03_L40:
       cmp       qword ptr [rsp+40],0
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FF9F77D4F00]
       mov       edi,eax
       jmp       near ptr M03_L06
M03_L41:
       mov       [rsp+30],r13
       mov       ecx,[rsi+0C]
       mov       edx,[rsi+4]
       shl       rdx,20
       add       rcx,rdx
       mov       edx,r14d
       neg       edx
       add       edx,20
       shrx      rcx,rcx,rdx
       mov       [rsp+38],ecx
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FF9F77D4F48]
       mov       ecx,eax
       mov       [rsp+50],rcx
       xor       ecx,ecx
       mov       [rsp+58],ecx
M03_L42:
       mov       ecx,[rsp+48]
       or        rcx,[rsp+40]
       jne       short M03_L45
       test      edi,edi
       jge       near ptr M03_L06
       mov       r14d,edi
       neg       r14d
       cmp       r14d,9
       jge       short M03_L43
       mov       ecx,r14d
       jmp       short M03_L44
M03_L43:
       mov       ecx,9
M03_L44:
       jmp       short M03_L46
M03_L45:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M03_L47
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FF9F774DB90]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       ecx,eax
       test      ecx,ecx
       je        near ptr M03_L47
M03_L46:
       cmp       ecx,0A
       jae       near ptr M03_L53
       mov       edx,ecx
       mov       rax,7FFA3B7D2B70
       mov       r15d,[rax+rdx*4]
       add       edi,ecx
       lea       rcx,[rsp+50]
       mov       edx,r15d
       call      qword ptr [7FF9F774DC20]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M03_L52
       mov       rdx,[rsp+40]
       mov       ecx,r15d
       lea       rax,[rsp+20]
       mulx      rcx,r8,rcx
       mov       [rax],r8
       mov       rdx,[rsp+20]
       mov       [rsp+40],rdx
       mov       edx,[rsp+48]
       mov       eax,r15d
       imul      rdx,rax
       add       rcx,rdx
       mov       [rsp+48],rcx
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FF9F77D4F48]
       mov       edx,eax
       lea       rcx,[rsp+50]
       call      qword ptr [7FF9F774DC50]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M03_L42
       jmp       near ptr M03_L49
M03_L47:
       cmp       dword ptr [rsp+48],0
       jl        short M03_L48
       mov       r13d,[rsp+44]
       shr       r13d,1F
       mov       rcx,[rsp+40]
       add       rcx,rcx
       mov       [rsp+40],rcx
       mov       ecx,[rsp+48]
       lea       ecx,[r13+rcx*2]
       mov       [rsp+48],ecx
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+38]
       ja        short M03_L48
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+38]
       jne       near ptr M03_L06
       mov       rcx,[rsp+40]
       cmp       rcx,[rsp+30]
       ja        short M03_L48
       mov       rcx,[rsp+40]
       cmp       rcx,[rsp+30]
       jne       near ptr M03_L06
       test      byte ptr [rsp+50],1
       je        near ptr M03_L06
M03_L48:
       mov       rcx,[rsp+50]
       inc       rcx
       mov       [rsp+50],rcx
       test      rcx,rcx
       jne       near ptr M03_L06
       jmp       short M03_L51
M03_L49:
       mov       r8,[rsp+40]
       or        r8,[rsp+48]
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FF9F77D4F00]
       mov       edi,eax
       jmp       near ptr M03_L06
M03_L50:
       mov       rax,[rsp+50]
       mov       [rbx+8],rax
       mov       eax,[rsp+58]
       mov       [rbx+4],eax
       jmp       near ptr M03_L11
M03_L51:
       mov       ecx,[rsp+58]
       inc       ecx
       mov       [rsp+58],ecx
       test      ecx,ecx
       jne       near ptr M03_L06
       lea       rcx,[rsp+50]
       mov       edx,edi
       mov       r8d,1
       call      qword ptr [7FF9F77D4F00]
       mov       edi,eax
       jmp       near ptr M03_L06
M03_L52:
       mov       ecx,0F405
       mov       rdx,7FF9F7064000
       call      qword ptr [7FF9F712F228]
       mov       rcx,rax
       call      qword ptr [7FF9F77D4DC8]
       mov       rcx,rax
       call      qword ptr [7FF9F77D4DE0]
       int       3
M03_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2146
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,23F920012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F768C4F8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FF9F74840F0]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 140
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F752FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F771E160]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74843D8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F771E058]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M02_L03:
       cmp       ecx,8
       ja        short M02_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEmailAddress()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqu   ymmword ptr [rsp+50],ymm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+70],1
       mov       dword ptr [rsp+74],1
       mov       byte ptr [rsp+70],1
       mov       dword ptr [rsp+74],1
       mov       ecx,5
       mov       edx,19
       call      qword ptr [7FF9F77341C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7734B58]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       byte ptr [rsp+68],1
       mov       dword ptr [rsp+6C],1
       mov       byte ptr [rsp+68],1
       mov       dword ptr [rsp+6C],1
       mov       ecx,5
       mov       edx,0F
       call      qword ptr [7FF9F77341C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7734B58]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       mov       rcx,28065C012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       rbp,[rcx+18]
M00_L00:
       mov       edx,[rbp+8]
       sub       edx,1
       jo        near ptr M00_L12
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77341C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rbp+8]
       jae       near ptr M00_L11
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       mov       r14d,[rsi+8]
       mov       r15d,[rdi+8]
       mov       r13d,r14d
       add       r13d,r15d
       jo        near ptr M00_L12
       add       r13d,[rbp+8]
       jo        near ptr M00_L12
       add       r13d,2
       jo        near ptr M00_L12
       mov       rcx,28065C01370
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L05
M00_L01:
       test      r13d,r13d
       jle       near ptr M00_L06
       mov       edx,r13d
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       [rsp+20],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       r8,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GenerateEmailAddress>b__34_0(System.Span`1<Char>, System.ValueTuple`3<System.String,System.String,System.String>)
       cmp       [r12+18],r8
       jne       near ptr M00_L10
       mov       [rsp+58],r10
       mov       [rsp+60],r13d
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       mov       rcx,[rsp+58]
       mov       r10d,[rsp+60]
       cmp       r8d,r10d
       ja        near ptr M00_L09
       add       r8,r8
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r14d
       add       r8d,1
       jo        near ptr M00_L12
       mov       r13d,r8d
       cmp       r14d,[rsp+60]
       jae       near ptr M00_L11
       mov       r8,[rsp+58]
       mov       ecx,r14d
       mov       word ptr [r8+rcx*2],40
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       mov       ecx,[rsp+60]
       sub       ecx,r13d
       mov       eax,r13d
       mov       r10d,ecx
       add       rax,r10
       mov       r10d,[rsp+60]
       cmp       rax,r10
       ja        near ptr M00_L08
       mov       rax,[rsp+58]
       mov       r10d,r13d
       lea       rax,[rax+r10*2]
       cmp       r8d,ecx
       ja        near ptr M00_L09
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,r13d
       jo        near ptr M00_L12
       mov       r13d,r15d
       mov       r8d,r13d
       mov       r13d,r8d
       add       r13d,1
       jo        near ptr M00_L12
       cmp       r8d,[rsp+60]
       jae       near ptr M00_L11
       mov       rcx,[rsp+58]
       mov       word ptr [rcx+r8*2],2E
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       mov       ecx,[rsp+60]
       sub       ecx,r13d
       mov       eax,r13d
       mov       r10d,ecx
       add       rax,r10
       mov       r10d,[rsp+60]
       cmp       rax,r10
       ja        near ptr M00_L08
       mov       rax,[rsp+58]
       mov       r10d,r13d
       lea       rax,[rax+r10*2]
       cmp       r8d,ecx
       ja        near ptr M00_L09
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       rsi,[rsp+20]
M00_L03:
       mov       [rsp+50],rsi
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
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
M00_L04:
       call      qword ptr [7FF9F7494090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.String, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,28065C01368
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GenerateEmailAddress>b__34_0(System.Span`1<Char>, System.ValueTuple`3<System.String,System.String,System.String>)
       call      qword ptr [7FF9F7116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,28065C01370
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L06:
       test      r13d,r13d
       jne       short M00_L07
       mov       rsi,2C0FA9F0008
       jmp       near ptr M00_L03
M00_L07:
       mov       ecx,28
       call      qword ptr [7FF9F73378E8]
       int       3
M00_L08:
       call      qword ptr [7FF9F7287198]
       int       3
M00_L09:
       call      qword ptr [7FF9F752CD98]
       int       3
M00_L10:
       mov       [rsp+40],r10
       mov       [rsp+48],r13d
       mov       [rsp+28],rsi
       mov       [rsp+30],rdi
       mov       [rsp+38],rbp
       lea       rdx,[rsp+40]
       lea       r8,[rsp+28]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       jmp       near ptr M00_L02
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 895
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F753FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77B47E0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7494378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F773FE28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,2CAC974D2C08
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L13
M02_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M02_L25
       add       edi,1
       jo        near ptr M02_L25
       cmp       r15d,100
       jg        near ptr M02_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M02_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M02_L01:
       push      0
       push      0
       dec       r15
       jne       short M02_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M02_L02:
       test      ebx,ebx
       jl        near ptr M02_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M02_L25
       mov       r13,rax
       test      r13,r13
       je        short M02_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M02_L03:
       push      0
       push      0
       dec       r13
       jne       short M02_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M02_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M02_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F753FB28
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L06
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M02_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M02_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M02_L09
M02_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M02_L25
       cmp       edx,0FFFF
       ja        near ptr M02_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M02_L25
       cmp       ecx,ebx
       jge       short M02_L10
       jmp       short M02_L08
M02_L09:
       mov       r13,[rbp+10]
M02_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M02_L11:
       mov       r8,2CAC974D2C08
       cmp       [rbp+8],r8
       je        short M02_L12
       call      CORINFO_HELP_FAIL_FAST
M02_L12:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M02_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FF9F769FAB0]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FF9F769FAC8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FF9F77B5710]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2C0FA9F2288
       call      qword ptr [7FF9F733DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FF9F7287198]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FF9F773FE28]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28065C01E48
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742EA0]
       mov       [rbp+28],rax
       mov       rcx,28065C00C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9F73E0798]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M02_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M02_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FF9F7524BD0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M02_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M02_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M02_L20
M02_L19:
       call      qword ptr [7FF9F7287198]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FF9F752C738]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M02_L24
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L23:
       cmp       r10d,r8d
       jae       short M02_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M02_L22
       cmp       edx,0FFFF
       ja        short M02_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M02_L22
M02_L24:
       cmp       r10d,r14d
       jl        short M02_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FF9F7111548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28065C01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742EA8]
       mov       rcx,28065C00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F73E07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FF9F77113C8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,28065C01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742EA8]
       mov       rcx,28065C00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F73E07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
```
```assembly
; DotNetTips.Spargine.Tester.RandomData+<>c.<GenerateEmailAddress>b__34_0(System.Span`1<Char>, System.ValueTuple`3<System.String,System.String,System.String>)
; 				var position = 0;
; 				^^^^^^^^^^^^^^^^^
; 				state.username.AsSpan().CopyTo(span);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				position += state.username.Length;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				span[position++] = '@';
; 				^^^^^^^^^^^^^^^^^^^^^^^
; 				state.domain.AsSpan().CopyTo(span[position..]);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				position += state.domain.Length;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				span[position++] = '.';
; 				^^^^^^^^^^^^^^^^^^^^^^^
; 				state.extension.AsSpan().CopyTo(span[position..]);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rdx
       mov       rsi,[r8]
       mov       rdi,[r8+8]
       mov       rbp,[r8+10]
       test      rsi,rsi
       jne       near ptr M03_L03
       xor       edx,edx
       xor       r8d,r8d
M03_L00:
       mov       rcx,[rbx]
       mov       eax,[rbx+8]
       cmp       r8d,eax
       jg        near ptr M03_L07
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       esi,[rsi+8]
       mov       r8d,esi
       add       r8d,1
       jo        near ptr M03_L09
       mov       r14d,r8d
       cmp       esi,[rbx+8]
       jae       near ptr M03_L08
       mov       r8,[rbx]
       mov       ecx,esi
       mov       word ptr [r8+rcx*2],40
       test      rdi,rdi
       jne       near ptr M03_L04
       xor       edx,edx
       xor       r8d,r8d
M03_L01:
       mov       ecx,[rbx+8]
       mov       eax,ecx
       sub       eax,r14d
       mov       r10d,r14d
       mov       r9d,eax
       add       r10,r9
       cmp       r10,rcx
       ja        near ptr M03_L06
       mov       rcx,[rbx]
       mov       r10d,r14d
       lea       rcx,[rcx+r10*2]
       cmp       r8d,eax
       ja        near ptr M03_L07
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,[rdi+8]
       jo        near ptr M03_L09
       mov       r8d,r14d
       mov       r14d,r8d
       add       r14d,1
       jo        near ptr M03_L09
       cmp       r8d,[rbx+8]
       jae       near ptr M03_L08
       mov       rcx,[rbx]
       mov       word ptr [rcx+r8*2],2E
       test      rbp,rbp
       jne       short M03_L05
       xor       edx,edx
       xor       r8d,r8d
M03_L02:
       mov       ecx,[rbx+8]
       mov       eax,ecx
       sub       eax,r14d
       mov       r10d,r14d
       mov       r9d,eax
       add       r10,r9
       cmp       r10,rcx
       ja        short M03_L06
       mov       rcx,[rbx]
       mov       r10d,r14d
       lea       rcx,[rcx+r10*2]
       cmp       r8d,eax
       ja        short M03_L07
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M03_L03:
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       jmp       near ptr M03_L00
M03_L04:
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       jmp       near ptr M03_L01
M03_L05:
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       jmp       short M03_L02
M03_L06:
       call      qword ptr [7FF9F7287198]
       int       3
M03_L07:
       call      qword ptr [7FF9F752CD98]
       int       3
M03_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 355
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M04_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M04_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       jbe       short M04_L04
       cmp       r8,40
       ja        near ptr M04_L08
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
       jmp       short M04_L06
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
       je        short M04_L07
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M04_L02
M04_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L01
M04_L07:
       test      r8,r8
       je        short M04_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L02
M04_L08:
       cmp       r8,800
       ja        short M04_L12
       cmp       r8,100
       jb        short M04_L09
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
M04_L09:
       mov       r9,r8
       shr       r9,6
M04_L10:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M04_L10
       and       r8,3F
       cmp       r8,10
       ja        near ptr M04_L00
       jmp       near ptr M04_L01
M04_L11:
       cmp       rcx,rdx
       jne       short M04_L12
       cmp       [rdx],dl
       jmp       near ptr M04_L02
M04_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 325
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M05_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M05_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M05_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M05_L03:
       cmp       ecx,8
       ja        short M05_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M05_L00]
       add       rdx,r8
       jmp       rdx
M05_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M05_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M05_L01
; Total bytes of code 269
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
       call      qword ptr [7FF9F77B40A8]
       int       3
; Total bytes of code 44
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFirstName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,1C6FD401308
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77541C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FF9F74B4090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 140
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F755FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77D46A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74B4378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F775FCD8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M02_L03:
       cmp       ecx,8
       ja        short M02_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FF9F77341C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       rcx,[rbx+60]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 37
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F753FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77B4690]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7494378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F773FCD8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateKey()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,168
       vzeroupper
       vmovaps   [rsp+150],xmm6
       vmovaps   [rsp+140],xmm7
       vmovaps   [rsp+130],xmm8
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-138],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-70],xmm4
       vmovdqa   xmmword ptr [rbp+rax-60],xmm4
       vmovdqa   xmmword ptr [rbp+rax-50],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp+10],rcx
       lea       rcx,[rbp-170]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-158],rcx
       mov       rcx,rbp
       mov       [rbp-148],rcx
       lea       rcx,[rbp-90]
       mov       rax,7FF9F74509F0
       mov       [rbp-160],rax
       lea       rax,[M00_L01]
       mov       [rbp-150],rax
       lea       rax,[rbp-170]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFA93BB0930
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M00_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-168]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L04
       vmovups   xmm0,[rbp-90]
       vmovups   [rbp-80],xmm0
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFA56DB9D30
       mov       rbx,rax
       lea       rsi,[rbx+0C]
       mov       r8d,[rbx+8]
       cmp       r8d,20
       jl        near ptr M00_L05
       mov       dword ptr [rbp-98],20
       mov       [rbp-0A0],rsi
       vmovups   xmm0,[rbp-80]
       vmovups   xmm1,[7FF9F78232E0]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FF9F78232F0]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vmovaps   [rbp-0F0],xmm3
       vpshufb   xmm1,xmm3,[7FF9F7823300]
       vmovaps   [rbp-0F0],xmm1
       vxorps    xmm1,xmm1,xmm1
       vmovaps   [rbp-100],xmm1
       vxorps    ymm1,ymm1,ymm1
       vmovdqu   ymmword ptr [rbp-130],ymm1
       vmovdqu   xmmword ptr [rbp-110],xmm1
       vmovaps   [rbp-180],xmm0
       lea       r8,[rbp-180]
       lea       rdx,[rbp-0F0]
       lea       rcx,[rbp-130]
       lea       r9,[rbp-100]
       call      qword ptr [7FF9F7127798]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-130]
       vmovaps   xmm6,[rbp-120]
       vmovaps   [rbp-180],xmm0
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FF9F77CCA98]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm7,[rbp-0C0]
       vmovups   xmm8,[rbp-0B0]
       vmovaps   [rbp-180],xmm6
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0E0]
       call      qword ptr [7FF9F77CCA98]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm0,[rbp-0E0]
       vmovups   xmm1,[rbp-0D0]
       vmovups   [rsi],xmm7
       vmovups   [rsi+10],xmm8
       vmovups   [rsi+20],xmm0
       vmovups   [rsi+30],xmm1
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
M00_L03:
       xor       ecx,ecx
       mov       [rbp-0A0],rcx
       mov       [rbp-138],rbx
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+60]
       lea       r8,[rbp-138]
       mov       rdx,7FF9F77A8DC0
       cmp       [rcx],ecx
       call      qword ptr [7FF9F775E190]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vmovaps   xmm6,[rsp+150]
       vmovaps   xmm7,[rsp+140]
       vmovaps   xmm8,[rsp+130]
       add       rsp,168
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
       mov       ecx,eax
       call      qword ptr [7FF9F77C7D08]
       int       3
M00_L05:
       xor       ecx,ecx
       mov       [rbp-98],ecx
       jmp       short M00_L03
; Total bytes of code 717
```
```assembly
; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       vmovups   xmm0,[r8]
       vmovups   [rcx+10],xmm0
       vmovups   xmm0,[r9]
       vmovups   [rcx+20],xmm0
       ret
; Total bytes of code 29
```
```assembly
; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm0,[rdx]
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rcx],xmm1
       vmovups   [rcx+10],xmm0
       mov       rax,rcx
       ret
; Total bytes of code 32
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateLastName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,2867E401310
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77641C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FF9F74C4090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 140
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F756FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77E4738]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74C4378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F776FD80]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M02_L03:
       cmp       ecx,8
       ja        short M02_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GeneratePhoneNumber()
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
       mov       [rbp-40],rax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rdx,rax
       mov       rcx,283DBB809F0
       call      qword ptr [7FF9F705A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L41
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rdx,rax
       mov       rcx,283DBB809F0
       call      qword ptr [7FF9F705A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       rcx,2435CC00198
       mov       rdi,[rcx]
       mov       rcx,2435CC00180
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L45
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       jne       near ptr M00_L11
       mov       rdx,rsi
       mov       r11,7FF9F70609D0
       call      qword ptr [r11]
       mov       r13d,eax
M00_L01:
       mov       r12,[r15+8]
       mov       rcx,[r15+10]
       mov       edx,r13d
       imul      rdx,[r15+28]
       shr       rdx,20
       inc       rdx
       mov       eax,[rcx+8]
       imul      rdx,rax
       shr       rdx,20
       cmp       edx,[rcx+8]
       jae       near ptr M00_L65
       mov       edx,edx
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M00_L54
       test      r12,r12
       je        near ptr M00_L12
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L12
M00_L02:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L46
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       test      r10,r10
       je        near ptr M00_L48
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L47
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FF9F70560A0]; System.Enum.Equals(System.Object)
M00_L03:
       test      eax,eax
       je        near ptr M00_L48
M00_L04:
       mov       rax,[rbp-50]
       mov       rdx,[rax+10]
       mov       [rbp-40],rdx
M00_L05:
       mov       rdx,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FF9F7525050]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L55
       mov       rdi,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rsi],rdi
       je        near ptr M00_L37
       mov       rax,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rax
       jne       near ptr M00_L14
       mov       r14d,[rsi+10]
       mov       r15,[rsi+8]
       cmp       [r15+8],r14d
       jb        near ptr M00_L56
       add       r15,10
M00_L06:
       xor       edi,edi
       cmp       edi,r14d
       jge       short M00_L08
M00_L07:
       mov       rsi,[r15+rdi*8]
       mov       rcx,rbx
       mov       rdx,rsi
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       test      eax,eax
       jne       near ptr M00_L38
       inc       edi
       cmp       edi,r14d
       jl        short M00_L07
M00_L08:
       xor       r15d,r15d
M00_L09:
       test      r15,r15
       je        near ptr M00_L64
       mov       ecx,[r15+0B8]
M00_L10:
       call      qword ptr [7FF9F769FBD0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+60]
       mov       rdx,[rbp-48]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L11:
       mov       rcx,rsi
       mov       rax,[7FF9F7793B48]
       call      qword ptr [rax+18]
       mov       r13d,eax
       jmp       near ptr M00_L01
M00_L12:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L51
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L49
       test      r10,r10
       je        near ptr M00_L50
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L52
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FF9F70560A0]; System.Enum.Equals(System.Object)
M00_L13:
       test      eax,eax
       je        near ptr M00_L53
       jmp       near ptr M00_L04
M00_L14:
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       jne       near ptr M00_L61
       mov       rcx,[rsi+8]
       cmp       [rcx],rdi
       jne       near ptr M00_L57
       mov       r15d,[rcx+8]
       test      r15d,r15d
       je        near ptr M00_L60
M00_L15:
       mov       rsi,[rsi+8]
       cmp       [rsi],rdi
       jne       near ptr M00_L59
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M00_L39
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+8],0FFFFFFFF
       mov       [rdi+0C],r14d
       lea       rcx,[rdi+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M00_L16:
       mov       [rbp-58],rdi
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L24
       mov       rdi,[rbp-58]
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L24
       jmp       short M00_L19
M00_L17:
       xor       eax,eax
M00_L18:
       test      eax,eax
       jne       near ptr M00_L35
M00_L19:
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L28
       mov       [rdi+8],eax
       mov       r10d,[rdi+8]
       cmp       r10d,[rdi+0C]
       jae       near ptr M00_L33
       mov       r14,[rdi+10]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L34
       mov       ecx,r10d
       mov       r15,[r14+rcx*8+10]
       mov       r13,[r15+68]
       mov       rdx,[rbx+8]
       cmp       r13,rdx
       je        near ptr M00_L27
       test      r13,r13
       je        short M00_L17
       test      rdx,rdx
       je        short M00_L17
       mov       ecx,[r13+8]
       cmp       ecx,[rdx+8]
       jne       short M00_L17
       lea       rcx,[r13+0C]
       add       rdx,0C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L20
       call      qword ptr [7FF9F711FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L21
M00_L20:
       mov       rax,[rcx]
       mov       rcx,[rcx+2]
       mov       r8,[rdx]
       xor       r8,rax
       xor       rcx,[rdx+2]
       or        rcx,r8
       sete      al
       movzx     eax,al
M00_L21:
       jmp       near ptr M00_L18
M00_L22:
       xor       eax,eax
M00_L23:
       test      eax,eax
       jne       near ptr M00_L35
M00_L24:
       mov       rdi,[rbp-58]
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L29
       mov       eax,[rdi+8]
       inc       eax
       cmp       eax,[rdi+0C]
       jae       near ptr M00_L30
       mov       [rdi+8],eax
       mov       ecx,[rdi+8]
       cmp       ecx,[rdi+0C]
       jae       near ptr M00_L33
       mov       r14,[rdi+10]
       mov       r10d,[rdi+8]
       cmp       r10d,[r14+8]
       jae       near ptr M00_L34
       mov       ecx,r10d
       mov       r15,[r14+rcx*8+10]
       mov       r13,[r15+68]
       mov       rdx,[rbx+8]
       cmp       r13,rdx
       je        near ptr M00_L32
       test      r13,r13
       je        short M00_L22
       test      rdx,rdx
       je        short M00_L22
       mov       ecx,[r13+8]
       cmp       ecx,[rdx+8]
       jne       short M00_L22
       lea       rcx,[r13+0C]
       add       rdx,0C
       mov       r8d,[r13+8]
       add       r8d,r8d
       cmp       r8,0A
       je        short M00_L25
       call      qword ptr [7FF9F711FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L26
M00_L25:
       mov       rax,rcx
       mov       rcx,rdx
       mov       r11,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rcx]
       xor       r11,rdx
       xor       rax,[rcx+2]
       or        r11,rax
       sete      al
       movzx     eax,al
M00_L26:
       jmp       near ptr M00_L23
M00_L27:
       mov       eax,1
       jmp       near ptr M00_L18
M00_L28:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L62
M00_L29:
       mov       rcx,rdi
       mov       r11,7FF9F70609E8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L31
       jmp       near ptr M00_L62
M00_L30:
       mov       ecx,[rdi+0C]
       mov       [rdi+8],ecx
       jmp       near ptr M00_L62
M00_L31:
       mov       rcx,rdi
       mov       r11,7FF9F70609F0
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       jmp       near ptr M00_L23
M00_L32:
       mov       eax,1
       jmp       near ptr M00_L23
M00_L33:
       mov       ecx,[rdi+8]
       call      qword ptr [7FF9F77C4870]
       int       3
M00_L34:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L35:
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L63
M00_L36:
       jmp       near ptr M00_L09
M00_L37:
       lea       r15,[rsi+10]
       mov       r14d,[rsi+8]
       jmp       near ptr M00_L06
M00_L38:
       mov       r15,rsi
       jmp       near ptr M00_L09
M00_L39:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       test      byte ptr [7FF9F779A268],1
       je        near ptr M00_L58
M00_L40:
       mov       rcx,2435CC00208
       mov       rdi,[rcx]
       jmp       near ptr M00_L16
M00_L41:
       call      qword ptr [7FF9F773D9F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L42
       call      qword ptr [7FF9F77C5FF8]
       mov       rbx,rax
M00_L42:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,283DBB809C0
       call      qword ptr [7FF9F733DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L43:
       call      qword ptr [7FF9F773D9F8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L44
       call      qword ptr [7FF9F77C5FF8]
       mov       rbx,rax
M00_L44:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,283DBB809C0
       call      qword ptr [7FF9F733DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L45:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2435CC00190
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__2_0(System.Enum)
       call      qword ptr [7FF9F7116BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,2435CC00198
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L46:
       mov       [rbp-50],rax
       jmp       short M00_L48
M00_L47:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L03
M00_L48:
       mov       rax,[rbp-50]
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L02
       jmp       short M00_L54
M00_L49:
       mov       rcx,r12
       mov       r8,rsi
       mov       rdx,r10
       mov       r11,7FF9F70609D8
       call      qword ptr [r11]
       jmp       near ptr M00_L13
M00_L50:
       mov       rax,[rbp-50]
M00_L51:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L12
       jmp       short M00_L54
M00_L52:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L13
M00_L53:
       mov       rax,[rbp-50]
       jmp       short M00_L51
M00_L54:
       xor       edx,edx
       mov       [rbp-40],rdx
       mov       rdx,rsi
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       xor       r9d,r9d
       mov       [rsp+28],r9d
       mov       dword ptr [rsp+30],1
       lea       r9,[rbp-40]
       mov       [rsp+38],r9
       mov       [rsp+20],rax
       mov       r9d,r13d
       shl       r9,20
       or        r9,1
       mov       rdx,r15
       mov       r8,rsi
       mov       rcx,r14
       call      qword ptr [7FF9F749C738]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L05
M00_L55:
       mov       ecx,11
       call      qword ptr [7FF9F7337E70]
       int       3
M00_L56:
       call      qword ptr [7FF9F7337A20]
       int       3
M00_L57:
       mov       r11,7FF9F7060A00
       call      qword ptr [r11]
       mov       r15d,eax
       test      r15d,r15d
       je        short M00_L60
       jmp       near ptr M00_L15
M00_L58:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L40
M00_L59:
       mov       rcx,rsi
       mov       r11,7FF9F7060A08
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L16
M00_L60:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2435CC00208
       mov       rdi,[rcx]
       jmp       near ptr M00_L16
M00_L61:
       mov       rcx,rsi
       mov       r11,7FF9F70609E0
       call      qword ptr [r11]
       mov       rdi,rax
       jmp       near ptr M00_L16
M00_L62:
       call      M00_L66
       jmp       near ptr M00_L08
M00_L63:
       mov       rcx,rdi
       mov       r11,7FF9F70609F8
       call      qword ptr [r11]
       jmp       near ptr M00_L36
M00_L64:
       mov       ecx,0A
       jmp       near ptr M00_L10
M00_L65:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L66:
       sub       rsp,48
       cmp       qword ptr [rbp-58],0
       je        short M00_L67
       mov       rdi,[rbp-58]
       mov       rsi,[rdi]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       je        short M00_L67
       mov       rcx,rdi
       mov       r11,7FF9F70609F8
       call      qword ptr [r11]
M00_L67:
       nop
       add       rsp,48
       ret
; Total bytes of code 2118
```
```assembly
; System.RuntimeType.IsEnumDefined(System.Object)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rsi,rdx
M01_L00:
       test      rsi,rsi
       je        near ptr M01_L23
       mov       rcx,[rbx+18]
       test      cl,2
       jne       near ptr M01_L07
       mov       rcx,[rcx+10]
       mov       rax,offset MT_System.Enum
       cmp       rcx,rax
       sete      cl
       movzx     ecx,cl
M01_L01:
       test      ecx,ecx
       je        near ptr M01_L25
       mov       rcx,rsi
       call      qword ptr [7FF9F711C9A8]; System.Object.GetType()
       mov       rdi,rax
       mov       rcx,[rdi+18]
       test      cl,2
       jne       near ptr M01_L08
       mov       rcx,[rcx+10]
       mov       rdx,offset MT_System.Enum
       cmp       rcx,rdx
       sete      cl
       movzx     ecx,cl
M01_L02:
       test      ecx,ecx
       je        short M01_L05
       cmp       rbx,rdi
       jne       near ptr M01_L24
M01_L03:
       mov       rcx,[rdi+18]
       mov       rax,rcx
       test      al,2
       jne       near ptr M01_L09
       mov       rax,[rax+10]
       mov       rdx,offset MT_System.Enum
       cmp       rax,rdx
       sete      al
       movzx     eax,al
M01_L04:
       test      eax,eax
       je        near ptr M01_L25
       call      00007FFA56D75960
       mov       rcx,24346C009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,283DBB70020
       cmp       rdi,rcx
       je        near ptr M01_L26
       mov       rcx,283DBB73120
       cmp       rdi,rcx
       jne       near ptr M01_L27
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FFA56D75960
       mov       rcx,24346C009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       cmp       rbp,rdi
       jne       near ptr M01_L28
       cmp       qword ptr [rdi+10],0
       je        short M01_L10
       mov       rcx,[rdi+10]
       mov       rbp,[rcx]
       test      rbp,rbp
       je        short M01_L10
       mov       rax,rbp
       jmp       short M01_L11
M01_L07:
       xor       ecx,ecx
       jmp       near ptr M01_L01
M01_L08:
       xor       ecx,ecx
       jmp       near ptr M01_L02
M01_L09:
       xor       eax,eax
       jmp       near ptr M01_L04
M01_L10:
       mov       rcx,rdi
       call      qword ptr [7FF9F7117C30]; System.RuntimeType.InitializeCache()
M01_L11:
       mov       ebp,[rax+98]
       test      ebp,ebp
       je        near ptr M01_L29
M01_L12:
       add       ebp,0FFFFFFFC
       cmp       ebp,5
       jne       near ptr M01_L49
       mov       rdx,offset MT_System.Int32
       cmp       [rsi],rdx
       je        short M01_L13
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
M01_L13:
       mov       esi,[rsi+8]
       cmp       qword ptr [rbx+10],0
       je        short M01_L14
       mov       rcx,[rbx+10]
       mov       rdi,[rcx]
       test      rdi,rdi
       jne       short M01_L19
M01_L14:
       mov       rcx,rbx
       call      qword ptr [7FF9F7117C30]; System.RuntimeType.InitializeCache()
M01_L15:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        short M01_L21
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       jne       short M01_L20
       mov       rax,rcx
M01_L16:
       test      rax,rax
       je        short M01_L22
M01_L17:
       mov       rcx,[rax+8]
       cmp       byte ptr [rax+19],0
       je        near ptr M01_L51
       mov       edx,esi
       mov       ecx,[rcx+8]
       cmp       rcx,rdx
       seta      al
       movzx     eax,al
M01_L18:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L19:
       mov       rax,rdi
       jmp       short M01_L15
M01_L20:
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       short M01_L21
       mov       rax,[rcx+28]
       jmp       short M01_L16
M01_L21:
       xor       eax,eax
       jmp       short M01_L16
M01_L22:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FF9F733DF20]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L17
M01_L23:
       mov       ecx,3AD
       mov       rdx,7FF9F7054000
       call      qword ptr [7FF9F73377B0]
       mov       rcx,rax
       call      qword ptr [7FF9F77C4228]
       int       3
M01_L24:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF9F77C4AE0]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FF9F77C53B0]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FF9F77C49C0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9F7494378]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L25:
       call      qword ptr [7FF9F77C5398]
       int       3
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FF9F7737B58]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FF9F7793F28
       call      qword ptr [7FF9F773DA10]
       not       eax
       shr       eax,1F
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L27:
       mov       rcx,283DBB753E0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB73070
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB72ED0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB753B8
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB72E58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB75408
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB72C50
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,283DBB75390
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77C53C8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74961C0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77C53E0]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FF9F77C49C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7494378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L29:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FF9F728F2E8]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L30
       mov       rcx,rdi
       call      qword ptr [7FF9F705A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rdx,rax
       mov       rcx,offset MT_System.RuntimeType
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       rbp,rax
M01_L30:
       mov       rcx,283DBB753B8
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,5
       jmp       near ptr M01_L46
M01_L31:
       mov       rcx,283DBB72ED0
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,6
       jmp       near ptr M01_L46
M01_L32:
       mov       rcx,283DBB753E0
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,7
       jmp       near ptr M01_L46
M01_L33:
       mov       rcx,283DBB73070
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,8
       jmp       near ptr M01_L46
M01_L34:
       mov       rcx,283DBB73120
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,9
       jmp       near ptr M01_L46
M01_L35:
       mov       rcx,283DBB72E58
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0A
       jmp       near ptr M01_L46
M01_L36:
       mov       rcx,283DBB75408
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,0B
       jmp       near ptr M01_L46
M01_L37:
       mov       rcx,283DBB72C50
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,0C
       jmp       near ptr M01_L46
M01_L38:
       mov       rcx,283DBB75368
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,3
       jmp       near ptr M01_L46
M01_L39:
       mov       rcx,283DBB75390
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,4
       jmp       near ptr M01_L46
M01_L40:
       mov       rcx,283DBB75430
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0D
       jmp       short M01_L46
M01_L41:
       mov       rcx,283DBB75458
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,0E
       jmp       short M01_L46
M01_L42:
       mov       rcx,283DBB762E0
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,0F
       jmp       short M01_L46
M01_L43:
       mov       rcx,283DBB72AC8
       cmp       rbp,rcx
       jne       short M01_L44
       mov       ebp,10
       jmp       short M01_L46
M01_L44:
       mov       rcx,283DBB70020
       cmp       rbp,rcx
       jne       short M01_L45
       mov       ebp,12
       jmp       short M01_L46
M01_L45:
       mov       rcx,283DBB80AA8
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M01_L46:
       cmp       qword ptr [rdi+10],0
       je        short M01_L47
       mov       rcx,[rdi+10]
       mov       r14,[rcx]
       test      r14,r14
       je        short M01_L47
       mov       rax,r14
       jmp       short M01_L48
M01_L47:
       mov       rcx,rdi
       call      qword ptr [7FF9F7117C30]; System.RuntimeType.InitializeCache()
M01_L48:
       mov       [rax+98],ebp
       jmp       near ptr M01_L12
M01_L49:
       cmp       ebp,0A
       ja        short M01_L50
       mov       edx,ebp
       lea       rcx,[7FF9F71C67C8]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L50:
       mov       rdx,283DBB73048
       cmp       rdi,rdx
       je        near ptr M01_L58
       jmp       near ptr M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FD8]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FD8]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FC0]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FC0]
       jmp       near ptr M01_L18
M01_L51:
       test      rcx,rcx
       jne       short M01_L52
       xor       eax,eax
       xor       r8d,r8d
       jmp       short M01_L53
M01_L52:
       lea       rax,[rcx+10]
       mov       r8d,[rcx+8]
M01_L53:
       cmp       dword ptr [rcx+8],20
       jle       short M01_L54
       mov       rcx,rax
       mov       edx,r8d
       mov       r8d,esi
       call      qword ptr [7FF9F77C5638]
       jmp       short M01_L55
M01_L54:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FF9F77C5848]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L55:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F773DA70]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FA8]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FA8]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4F90]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4F78]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Char
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4FF0]
       jmp       near ptr M01_L18
M01_L56:
       mov       rdx,283DBB75480
       cmp       rdi,rdx
       je        short M01_L57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F77C53C8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9F74961C0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L57:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4F60]
       jmp       short M01_L59
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FF9F77C4F60]
M01_L59:
       jmp       near ptr M01_L18
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2081
```
```assembly
; System.Enum.Equals(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
M02_L00:
       test      rdx,rdx
       je        short M02_L03
       cmp       rbx,rdx
       je        short M02_L02
       mov       rcx,[rbx]
       cmp       rcx,[rdx]
       jne       short M02_L03
       lea       rsi,[rbx+8]
       lea       rdi,[rdx+8]
       call      00007FFA56D75960
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M02_L03
       lea       rcx,[7FF9F71C8AF0]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M02_L00]
       add       rcx,rdx
       jmp       rcx
       mov       eax,[rsi]
       cmp       eax,[rdi]
       sete      al
       movzx     eax,al
M02_L01:
       movzx     eax,al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       eax,1
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       xor       eax,eax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
       movzx     eax,byte ptr [rsi]
       cmp       al,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M02_L01
       movzx     eax,word ptr [rsi]
       cmp       ax,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M02_L01
       mov       rax,[rsi]
       cmp       rax,[rdi]
       sete      al
       movzx     eax,al
       jmp       short M02_L01
; Total bytes of code 156
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
; 		_countries ??= DeserializeCountries();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return _countries;
; 		^^^^^^^^^^^^^^^^^^
       push      rbp
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+40]
       xor       edx,edx
       mov       [rbp-18],rdx
       lea       rdx,[rbp-18]
       mov       rbx,283DBB7B880
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,24346C01388
       cmp       qword ptr [rsi],0
       je        short M03_L01
M03_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M03_L02
M03_L01:
       call      qword ptr [7FF9F75251E8]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L00
M03_L02:
       mov       rax,rsi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rbp
       ret
       sub       rsp,28
       lea       rdx,[rbp-18]
       mov       rbx,283DBB7B880
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
; 		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryNameDescription, StringComparison.Ordinal));
; 		                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbx
       sub       rsp,20
       mov       rdx,[rdx+68]
       mov       rcx,[rcx+8]
       cmp       rdx,rcx
       je        short M04_L05
       test      rdx,rdx
       je        short M04_L00
       test      rcx,rcx
       je        short M04_L00
       mov       r8d,[rdx+8]
       cmp       r8d,[rcx+8]
       je        short M04_L02
M04_L00:
       xor       eax,eax
M04_L01:
       add       rsp,20
       pop       rbx
       ret
M04_L02:
       lea       rax,[rdx+0C]
       add       rcx,0C
       mov       rbx,rcx
       mov       ecx,[rdx+8]
       add       ecx,ecx
       mov       r8d,ecx
       cmp       r8,0A
       je        short M04_L03
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FF9F711FBB8]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M04_L04
M04_L03:
       mov       rcx,[rax]
       mov       rax,[rax+2]
       mov       rdx,[rbx]
       xor       rcx,rdx
       xor       rax,[rbx+2]
       or        rax,rcx
       sete      al
       movzx     eax,al
M04_L04:
       jmp       short M04_L01
M04_L05:
       mov       eax,1
       jmp       short M04_L01
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       xor       eax,eax
       mov       [rbp+30],rax
       mov       rax,96F9EB4E2C11
       mov       [rbp+8],rax
       mov       ebx,ecx
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       mov       eax,1
       test      ecx,ecx
       cmove     ebx,eax
; 		byte[]? rentedBytes = null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		char[]? rentedChars = null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rbp+10],rcx
; 		var bytes = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc byte[length]
; 			                         
; 			: (rentedBytes = ArrayPool<byte>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       cmp       ebx,100
       jg        near ptr M05_L17
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M05_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M05_L00:
       push      0
       push      0
       dec       rsi
       jne       short M05_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M05_L01:
       test      ebx,ebx
       jl        near ptr M05_L21
       mov       edi,ebx
M05_L02:
       cmp       ebx,100
       jg        near ptr M05_L19
; 		var chars = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc char[length]
; 			                         
; 			: (rentedChars = ArrayPool<char>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       mov       eax,ebx
       mov       ecx,2
       mul       rcx
       jb        near ptr M05_L23
       mov       r14,rax
       test      r14,r14
       je        short M05_L04
       add       r14,0F
       shr       r14,4
       add       rsp,20
M05_L03:
       push      0
       push      0
       dec       r14
       jne       short M05_L03
       sub       rsp,20
       lea       r14,[rsp+20]
M05_L04:
       test      ebx,ebx
       jl        near ptr M05_L21
       mov       r15d,ebx
M05_L05:
       test      edi,edi
       jle       short M05_L06
       mov       rcx,rsi
       mov       [rbp+30],rcx
       mov       edx,edi
       call      qword ptr [7FF9F7524C00]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+30],rcx
M05_L06:
       xor       ecx,ecx
       mov       [rbp+30],rcx
; 			for (var digitIndex = 0; digitIndex < length; digitIndex++)
; 			                         ^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       jle       short M05_L08
       cmp       ebx,r15d
       jg        short M05_L09
       cmp       ebx,edi
       jg        short M05_L09
; 				chars[digitIndex] = (char)('0' + (bytes[digitIndex] % 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M05_L07:
       mov       eax,ecx
       movzx     edx,byte ptr [rsi+rax]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M05_L11
       cmp       edx,0FFFF
       ja        short M05_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M05_L11
       cmp       ecx,ebx
       jl        short M05_L07
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M05_L08:
       mov       [rbp+20],r14
       mov       [rbp+28],r15d
       lea       rcx,[rbp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       jmp       short M05_L12
M05_L09:
       cmp       ecx,r15d
       jae       short M05_L10
       mov       eax,ecx
       cmp       ecx,edi
       jae       short M05_L10
       mov       edx,ecx
       movzx     edx,byte ptr [rsi+rdx]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M05_L11
       cmp       edx,0FFFF
       ja        short M05_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M05_L11
       cmp       ecx,ebx
       jl        short M05_L09
       jmp       short M05_L08
M05_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M05_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			if (rentedBytes is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M05_L12:
       cmp       qword ptr [rbp+18],0
       je        short M05_L14
; 				ArrayPool<byte>.Shared.Return(rentedBytes);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      byte ptr [7FF9F7742A88],1
       je        near ptr M05_L22
M05_L13:
       mov       rcx,24346C01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742CF0]
; 			if (rentedChars is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M05_L14:
       cmp       qword ptr [rbp+10],0
       je        short M05_L15
; 				ArrayPool<char>.Shared.Return(rentedChars);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,24346C00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F73E07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
M05_L15:
       mov       rax,rbx
       mov       r8,96F9EB4E2C11
       cmp       [rbp+8],r8
       je        short M05_L16
       call      CORINFO_HELP_FAIL_FAST
M05_L16:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L17:
       test      byte ptr [7FF9F7742A88],1
       je        short M05_L20
M05_L18:
       mov       rcx,24346C01E48
       mov       rcx,[rcx]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742CE8]
       mov       [rbp+18],rax
       test      rax,rax
       je        short M05_L21
       cmp       [rax+8],ebx
       jb        short M05_L21
       add       rax,10
       mov       rsi,rax
       mov       edi,ebx
       jmp       near ptr M05_L02
M05_L19:
       mov       rcx,24346C00C88
       mov       rcx,[rcx]
       mov       edx,ebx
       call      qword ptr [7FF9F73E0798]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+10],rax
       test      rax,rax
       je        short M05_L21
       cmp       [rax+8],ebx
       jb        short M05_L21
       add       rax,10
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M05_L05
M05_L20:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M05_L18
M05_L21:
       call      qword ptr [7FF9F7287198]
       int       3
M05_L22:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M05_L13
M05_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp+18],0
       je        short M05_L25
       test      byte ptr [7FF9F7742A88],1
       jne       short M05_L24
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7115728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M05_L24:
       mov       rcx,24346C01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742CF0]
M05_L25:
       cmp       qword ptr [rbp+10],0
       je        short M05_L26
       mov       rcx,24346C00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F73E07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
M05_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 804
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M06_L04
       cmp       rcx,rdx
       je        short M06_L03
       cmp       r8,20
       jae       near ptr M06_L09
       cmp       r8,10
       jb        near ptr M06_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M06_L02
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       je        short M06_L01
M06_L00:
       xor       eax,eax
       vzeroupper
       ret
M06_L01:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M06_L12
M06_L02:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M06_L00
M06_L03:
       mov       eax,1
       vzeroupper
       ret
M06_L04:
       cmp       r8,4
       jae       short M06_L07
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M06_L05
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M06_L05:
       test      r8b,1
       je        short M06_L06
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M06_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M06_L08
M06_L07:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M06_L08:
       vzeroupper
       ret
M06_L09:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M06_L11
M06_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M06_L00
       add       rax,20
       cmp       r8,rax
       ja        short M06_L10
M06_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M06_L00
       jmp       near ptr M06_L03
M06_L12:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M06_L00
       jmp       near ptr M06_L01
M06_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M06_L08
; Total bytes of code 335
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__2_0(System.Enum)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       vmovdqu   ymmword ptr [rbp-20],ymm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
; 			var type = key.GetType();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F711C9A8]; System.Object.GetType()
       mov       [rbp-8],rax
; 			if (!type.IsEnum)
; 			^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+70]
       call      qword ptr [rax+30]
       test      eax,eax
       jne       short M07_L00
; 				throw new ArgumentException("Type provided must be an Enum.", nameof(input));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       ecx,624F
       mov       rdx,7FF9F73E5550
       call      qword ptr [7FF9F73377B0]
       mov       [rbp-40],rax
       mov       ecx,2047
       mov       rdx,7FF9F73E5550
       call      qword ptr [7FF9F73377B0]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9F7496268]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M07_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9F773DE48]; System.Enum.GetName(System.Type, System.Object)
       mov       [rbp-10],rax
; 			if (name == null)
; 			^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-10],0
       jne       short M07_L01
; 				return key.ToString();
; 				^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp+18]
       mov       rax,[rbp+18]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-38],rax
       jmp       near ptr M07_L05
; 			var field = type.GetField(name);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M07_L01:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F773DE60]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FF9F773DE78]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
       test      eax,eax
       je        short M07_L02
; 				return name;
; 				^^^^^^^^^^^^
       mov       rax,[rbp-10]
       mov       [rbp-38],rax
       jmp       near ptr M07_L05
; 			var descriptionAttr = field.GetCustomAttribute<DescriptionAttribute>(false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M07_L02:
       mov       rdx,[rbp-18]
       mov       rcx,7FF9F7799BB8
       xor       r8d,r8d
       call      qword ptr [7FF9F7626478]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-20],rax
; 			if (descriptionAttr != null && !string.IsNullOrEmpty(descriptionAttr.Description))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-20],0
       je        short M07_L03
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       rcx,rax
       call      qword ptr [7FF9F733E4C0]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M07_L03
; 				return descriptionAttr.Description;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-20]
       mov       rax,[rbp-20]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+38]
       mov       [rbp-38],rax
       jmp       short M07_L05
; 			var enumMemberAttr = field.GetCustomAttribute<EnumMemberAttribute>(false);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M07_L03:
       mov       rdx,[rbp-18]
       mov       rcx,7FF9F7799C40
       xor       r8d,r8d
       call      qword ptr [7FF9F7626478]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M07_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F773DEA8]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       rcx,rax
       call      qword ptr [7FF9F733E4C0]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M07_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F773DEA8]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       [rbp-38],rax
       jmp       short M07_L05
; 			return name;
; 			^^^^^^^^^^^^
M07_L04:
       mov       rax,[rbp-10]
       mov       [rbp-38],rax
M07_L05:
       mov       rax,[rbp-38]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 458
```
```assembly
; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,r8
       test      rdx,rdx
       je        short M08_L00
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbx+18],rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      qword ptr [7FF9F77C4630]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
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
       mov       [rbp-60],rax
       mov       [rbp-40],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       mov       rdx,r8
       mov       rbx,[rbp+30]
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-60],r11
       mov       r8d,[rbp+2C]
       test      r9d,r9d
       je        short M09_L00
       jmp       short M09_L03
M09_L00:
       cmp       byte ptr [rcx+19],0
       je        short M09_L01
       mov       rcx,rdx
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       short M09_L02
M09_L01:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFA8EE8A738]
       mov       rcx,[rbp-60]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       mov       r8d,eax
M09_L02:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
M09_L03:
       mov       [rbp-44],r8d
       jmp       short M09_L06
M09_L04:
       call      M09_L24
       nop
       mov       eax,[rbp-54]
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
M09_L05:
       call      M09_L24
       nop
M09_L06:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-68],rcx
       mov       rbx,[rbp+10]
       cmp       [rbx],ebx
       mov       rax,[rbp+18]
       mov       r8,[rax+10]
       mov       rax,[rbp+18]
       mov       r10d,[rbp-44]
       imul      r10,[rax+28]
       shr       r10,20
       inc       r10
       mov       r9d,[r8+8]
       mov       r11d,r9d
       imul      r10,r11
       shr       r10,20
       mov       eax,r10d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-48],edx
       cmp       r10d,r9d
       jae       near ptr M09_L23
       mov       ecx,r10d
       lea       rsi,[r8+rcx*8+10]
       xor       edi,edi
       xor       r14d,r14d
       xor       ecx,ecx
       mov       [rbp-50],ecx
       cmp       byte ptr [rbp+40],0
       je        short M09_L07
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+8]
       cmp       [rbp-48],ecx
       jae       near ptr M09_L18
       mov       rcx,[rbp-68]
       mov       edx,[rbp-48]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-50]
       call      qword ptr [7FFA8EE8AB78]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M09_L07:
       mov       rcx,[rbp+18]
       cmp       rcx,[rbx+8]
       jne       near ptr M09_L15
       xor       r15d,r15d
       mov       r13,[rsi]
       test      r13,r13
       je        short M09_L10
M09_L08:
       mov       ecx,[rbp-44]
       cmp       ecx,[r13+20]
       jne       short M09_L09
       mov       rcx,[rbx]
       call      qword ptr [7FFA8EE8A3D8]
       mov       rcx,rax
       call      qword ptr [7FFA8EE8A910]
       mov       rdx,[r13+8]
       mov       rcx,[rbp-60]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       jne       near ptr M09_L12
M09_L09:
       inc       r15d
       mov       r13,[r13+18]
       test      r13,r13
       jne       short M09_L08
M09_L10:
       mov       rcx,[rbx]
       call      qword ptr [7FFA8EE8A430]
       mov       rcx,rax
       call      qword ptr [7FFA8EE8A280]; CORINFO_HELP_NEWFAST
       mov       r13,rax
       mov       r12,[rsi]
       lea       rcx,[r13+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFA8EE8A258]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFA8EE8A258]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r13+18]
       mov       rdx,r12
       call      qword ptr [7FFA8EE8A258]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-44]
       mov       [r13+20],ecx
       mov       rcx,rsi
       mov       rdx,r13
       call      qword ptr [7FFA8EE8A258]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-48],eax
       jae       near ptr M09_L18
       mov       eax,[rbp-48]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M09_L19
       mov       [rcx],eax
       cmp       eax,[rbx+10]
       jle       short M09_L11
       mov       edi,1
M09_L11:
       cmp       r15d,64
       jbe       near ptr M09_L20
       mov       rcx,[rbp-60]
       call      qword ptr [7FFA8EE8AA38]
       test      rax,rax
       je        near ptr M09_L20
       mov       r14d,1
       jmp       near ptr M09_L20
M09_L12:
       cmp       byte ptr [rbp+38],0
       jne       short M09_L13
       mov       rdx,[r13+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FFA8EE8A260]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M09_L14
M09_L13:
       lea       rcx,[r13+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFA8EE8A258]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFA8EE8A260]; CORINFO_HELP_CHECKED_ASSIGN_REF
M09_L14:
       xor       ecx,ecx
       mov       [rbp-54],ecx
       jmp       near ptr M09_L04
M09_L15:
       mov       rcx,[rbx+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       cmp       [rbp-60],rcx
       je        near ptr M09_L05
       mov       [rbp-60],rcx
       cmp       byte ptr [rbx+19],0
       je        short M09_L16
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
       jmp       short M09_L17
M09_L16:
       mov       rcx,[rbx]
       call      qword ptr [7FFA8EE8A738]
       mov       rcx,[rbp-60]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
M09_L17:
       mov       [rbp-44],eax
       jmp       near ptr M09_L05
M09_L18:
       call      qword ptr [7FFA8EE8A250]
       int       3
M09_L19:
       call      qword ptr [7FFA8EE8A248]
       int       3
M09_L20:
       cmp       byte ptr [rbp-50],0
       je        short M09_L21
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+8]
       cmp       [rbp-48],ecx
       jae       short M09_L23
       mov       rcx,[rbp-68]
       mov       eax,[rbp-48]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFA8EE8AB80]; Precode of System.Threading.Monitor.Exit(System.Object)
M09_L21:
       mov       ecx,edi
       or        ecx,r14d
       je        short M09_L22
       mov       rcx,rbx
       mov       rdx,[rbp+18]
       mov       r8d,edi
       mov       r9d,r14d
       call      qword ptr [7FFA8EE8B168]
M09_L22:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFA8EE8A260]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
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
M09_L23:
       call      qword ptr [7FFA8EE8A250]
       int       3
M09_L24:
       sub       rsp,28
       cmp       byte ptr [rbp-50],0
       je        short M09_L25
       mov       rcx,[rbp-68]
       mov       ecx,[rcx+8]
       cmp       [rbp-48],ecx
       jae       short M09_L26
       mov       rcx,[rbp-68]
       mov       eax,[rbp-48]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFA8EE8AB80]; Precode of System.Threading.Monitor.Exit(System.Object)
M09_L25:
       nop
       add       rsp,28
       ret
M09_L26:
       call      qword ptr [7FFA8EE8A250]
       int       3
; Total bytes of code 908
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-18]
       mov       rdx,rax
       test      dl,1
       jne       short M10_L00
       ret
M10_L00:
       jmp       qword ptr [7FF9F7115C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomFileName()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       ecx,0A
       call      qword ptr [7FF9F773D920]; DotNetTips.Spargine.Tester.RandomData.GenerateFileNameWord(Int32)
       mov       rsi,rax
       mov       rcx,offset MT_System.String
       mov       edx,1
       call      00007FFA56DB9D30
       mov       rdi,rax
       mov       word ptr [rdi+0C],2E
       test      rsi,rsi
       je        near ptr M00_L08
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L08
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L09
       mov       r15d,ebp
       mov       edx,r14d
       lea       rdx,[r15+rdx+0F]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L10
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rax,ebp
       lea       rax,[r12+rax*2]
       vmovups   xmm0,[7FF9F71C4E90]
       vmovups   [rax],xmm0
       mov       rcx,74002E00730070
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],6D0065
       mov       word ptr [rax+1C],70
M00_L00:
       mov       rcx,1FE41801340
       mov       rsi,[rcx]
       test      r13,r13
       je        near ptr M00_L11
       cmp       dword ptr [r13+8],0
       je        near ptr M00_L06
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
       lea       rcx,[rsp+40]
       call      qword ptr [7FF9F733D860]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M00_L01
       jmp       near ptr M00_L07
M00_L01:
       add       rsi,0C
       lea       rdi,[r13+0C]
       mov       ebp,[r13+8]
       movzx     ecx,word ptr [rsi+42]
       cmp       ecx,5C
       je        short M00_L04
       cmp       ecx,2F
       je        short M00_L04
       movzx     ecx,word ptr [rdi]
       cmp       ecx,5C
       je        short M00_L03
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L02:
       test      ecx,ecx
       jne       short M00_L04
       mov       rcx,23ED66F7394
       mov       [rsp+40],rsi
       mov       dword ptr [rsp+48],22
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rdi
       mov       [rsp+28],ebp
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FF9F733D890]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       jmp       short M00_L05
M00_L03:
       mov       ecx,1
       jmp       short M00_L02
M00_L04:
       mov       [rsp+40],rsi
       mov       dword ptr [rsp+48],22
       mov       [rsp+30],rdi
       mov       [rsp+38],ebp
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FF9F749D9F8]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r13,rax
M00_L05:
       jmp       short M00_L07
M00_L06:
       mov       r13,rsi
M00_L07:
       mov       [rsp+50],r13
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+50]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
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
M00_L08:
       mov       rcx,rdi
       mov       rdx,23ED67009C0
       call      qword ptr [7FF9F7117840]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       jmp       near ptr M00_L00
M00_L09:
       mov       rcx,rsi
       mov       rdx,23ED67009C0
       call      qword ptr [7FF9F7117840]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       jmp       near ptr M00_L00
M00_L10:
       call      qword ptr [7FF9F77B4360]
       int       3
M00_L11:
       mov       ecx,1C488
       mov       rdx,7FF9F7054000
       call      qword ptr [7FF9F73377B0]
       mov       rcx,rax
       call      qword ptr [7FF9F773FB28]
       int       3
; Total bytes of code 638
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateFileNameWord(Int32)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+18],rax
       mov       rax,79363E1105E0
       mov       [rbp+8],rax
       mov       ebx,ecx
; 		Span<byte> randomBytes = stackalloc byte[length];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M01_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M01_L00:
       push      0
       push      0
       dec       rsi
       jne       short M01_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M01_L01:
       test      ebx,ebx
       jl        near ptr M01_L10
       mov       edi,ebx
; 		RandomNumberGenerator.Fill(randomBytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      edi,edi
       jle       short M01_L02
       mov       rcx,rsi
       mov       [rbp+18],rcx
       mov       edx,edi
       call      qword ptr [7FF9F7524C00]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+18],rcx
M01_L02:
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		var charBuffer = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,1FE41800C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FF9F73E0798]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       rdx,rax
       mov       [rbp+10],rdx
; 			for (var wordIndex = 0; wordIndex < length; wordIndex++)
; 			     ^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       test      edi,edi
       jle       short M01_L04
       test      rdx,rdx
       je        short M01_L05
       cmp       [rdx+8],edi
       jl        short M01_L05
; 				charBuffer[wordIndex] = (char)(DefaultMinCharacterRandomFile + (randomBytes[wordIndex] % range));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L03:
       mov       r8d,ecx
       movzx     eax,byte ptr [rsi+r8]
       mov       r10d,eax
       imul      r10,4EC4EC4F
       shr       r10,23
       imul      r10d,1A
       sub       eax,r10d
       add       eax,41
       jo        short M01_L07
       cmp       eax,0FFFF
       ja        short M01_L07
       mov       [rdx+r8*2+10],ax
       add       ecx,1
       jo        short M01_L07
       cmp       ecx,ebx
       jl        short M01_L03
; 			return new string(charBuffer, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L04:
       mov       rcx,rdx
       mov       r8d,ebx
       xor       edx,edx
       call      System.String.Ctor(Char[], Int32, Int32)
       mov       rbx,rax
       jmp       short M01_L08
M01_L05:
       mov       eax,ecx
       movzx     r8d,byte ptr [rsi+rax]
       mov       eax,r8d
       imul      rax,4EC4EC4F
       shr       rax,23
       imul      eax,1A
       sub       r8d,eax
       add       r8d,41
       jo        short M01_L07
       cmp       r8d,0FFFF
       ja        short M01_L07
       mov       eax,r8d
       cmp       ecx,[rdx+8]
       jae       short M01_L06
       mov       r8d,ecx
       mov       [rdx+r8*2+10],ax
       add       ecx,1
       jo        short M01_L07
       cmp       ecx,edi
       jl        short M01_L05
       jmp       short M01_L04
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M01_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			ArrayPool<char>.Shared.Return(charBuffer);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M01_L08:
       mov       rcx,r14
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F73E07A0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
       mov       rax,rbx
       mov       r8,79363E1105E0
       cmp       [rbp+8],r8
       je        short M01_L09
       call      CORINFO_HELP_FAIL_FAST
M01_L09:
       nop
       lea       rsp,[rbp+20]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M01_L10:
       call      qword ptr [7FF9F7287198]
       int       3
       sub       rsp,28
       mov       rcx,1FE41800C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F73E07A0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
       nop
       add       rsp,28
       ret
; Total bytes of code 419
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M02_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M02_L11
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
       ja        short M02_L06
M02_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M02_L02:
       vzeroupper
       ret
M02_L03:
       cmp       r8,800
       ja        near ptr M02_L12
       cmp       r8,100
       jae       near ptr M02_L10
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
       ja        short M02_L00
       jmp       short M02_L01
M02_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M02_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M02_L01
M02_L07:
       test      r8b,18
       jne       short M02_L08
       test      r8b,4
       jne       short M02_L09
       test      r8,r8
       je        short M02_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M02_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M02_L02
M02_L08:
       mov       rdx,[rdx]
       mov       [rcx],rdx
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       near ptr M02_L02
M02_L09:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M02_L02
M02_L10:
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
       jmp       near ptr M02_L04
M02_L11:
       cmp       rcx,rdx
       jne       short M02_L12
       cmp       [rdx],dl
       jmp       near ptr M02_L02
M02_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 340
```
```assembly
; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       mov       rdx,[rcx]
       mov       ecx,[rcx+8]
       test      ecx,ecx
       jle       short M03_L00
       movzx     eax,word ptr [rdx]
       cmp       eax,5C
       je        short M03_L01
       cmp       eax,2F
       je        short M03_L01
M03_L00:
       cmp       ecx,2
       jl        short M03_L02
       movzx     eax,word ptr [rdx]
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        short M03_L02
       cmp       word ptr [rdx+2],3A
       sete      al
       movzx     eax,al
       ret
M03_L01:
       mov       eax,1
       ret
M03_L02:
       xor       eax,eax
       ret
; Total bytes of code 63
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       rbx,[r8]
       mov       esi,[r8+8]
       mov       rdi,[rdx]
       mov       ebp,[rdx+8]
       mov       r14,[rcx]
       mov       r15d,[rcx+8]
       mov       ecx,r15d
       add       ecx,ebp
       jo        near ptr M04_L02
       add       ecx,esi
       jo        near ptr M04_L02
       test      ecx,ecx
       je        near ptr M04_L00
       movsxd    rcx,ecx
       call      qword ptr [7FFA3C4469D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r13,rax
       lea       r12,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+34],eax
       cmp       r15d,eax
       ja        near ptr M04_L01
       mov       r10d,r15d
       add       r10,r10
       mov       [rsp+28],r10
       mov       r8,r10
       mov       rcx,r12
       mov       rdx,r14
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r14,[rsp+28]
       add       r14,r12
       mov       r12d,[rsp+34]
       sub       r12d,r15d
       cmp       ebp,r12d
       ja        short M04_L01
       mov       r15d,ebp
       add       r15,r15
       mov       r8,r15
       mov       rcx,r14
       mov       rdx,rdi
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+r15]
       sub       r12d,ebp
       cmp       esi,r12d
       ja        short M04_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
M04_L00:
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rax,[rax]
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
M04_L01:
       call      qword ptr [7FFA3C44A280]
       int       3
M04_L02:
       call      qword ptr [7FFA3C433FD0]
       int       3
; Total bytes of code 252
```
```assembly
; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[rdx]
       mov       esi,[rdx+8]
       mov       rdi,[rcx]
       mov       ebp,[rcx+8]
       mov       edx,ebp
       add       edx,esi
       jo        near ptr M05_L02
       test      edx,edx
       je        short M05_L00
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r14,rax
       lea       r15,[r14+0C]
       mov       r13d,[r14+8]
       cmp       ebp,r13d
       ja        short M05_L01
       mov       r12d,ebp
       add       r12,r12
       mov       r8,r12
       mov       rcx,r15
       mov       rdx,rdi
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M05_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r14
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
M05_L00:
       mov       rax,23ED66F0008
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
M05_L01:
       call      qword ptr [7FF9F752CD98]
       int       3
M05_L02:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 184
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
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,23ED66F0008
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
       call      qword ptr [7FF9F77B4360]
       int       3
; Total bytes of code 235
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomLocationData()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rbx,rcx
       mov       rdx,15FC3001318
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L09
       add       rcx,18
       mov       rsi,[rcx]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
M00_L00:
       mov       r14d,[rsi+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L10
       mov       rcx,[rcx+240]
       mov       r15,[rcx+40]
       test      r15,r15
       je        near ptr M00_L10
M00_L01:
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FF9F7724030]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r13d,r14d
       shr       r11,20
       mov       r12d,r11d
       imul      r13,r12
       mov       r8d,r13d
       cmp       r8d,r14d
       jb        near ptr M00_L11
M00_L03:
       shr       r13,20
       xor       r14d,r14d
       xor       r12d,r12d
       cmp       r13d,[rsi+8]
       jae       near ptr M00_L20
       mov       eax,r13d
       mov       rsi,[rsi+rax*8+10]
       cmp       r13d,[rdi+8]
       jae       near ptr M00_L20
       mov       eax,r13d
       mov       rdi,[rdi+rax*8+10]
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L08
       mov       r14d,[rdi+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       short M00_L04
       call      qword ptr [7FF9F7724030]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L04:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r8d,r14d
       shr       r11,20
       mov       r10d,r11d
       imul      r8,r10
       mov       r10d,r8d
       cmp       r10d,r14d
       jb        near ptr M00_L14
M00_L05:
       shr       r8,20
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L20
       mov       eax,r8d
       mov       r14,[rdi+rax*8+10]
       cmp       r13d,[rbp+8]
       jae       near ptr M00_L20
       mov       eax,r13d
       mov       rax,[rbp+rax*8+10]
       cmp       r8d,[rax+8]
       jae       near ptr M00_L20
       mov       ecx,r8d
       mov       rdi,[rax+rcx*8+10]
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L08
       mov       r12d,[rdi+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       short M00_L06
       call      qword ptr [7FF9F7724030]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L06:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r8d,r12d
       shr       r11,20
       mov       r10d,r11d
       imul      r8,r10
       mov       r10d,r8d
       cmp       r10d,r12d
       jb        near ptr M00_L17
M00_L07:
       shr       r8,20
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L20
       mov       edx,r8d
       mov       r12,[rdi+rdx*8+10]
M00_L08:
       mov       [rsp+20],rsi
       mov       [rsp+28],r14
       mov       [rsp+30],r12
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FF9F7784C38
       call      qword ptr [7FF9F772DA88]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       nop
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
M00_L09:
       lea       rdx,[rsp+40]
       call      qword ptr [7FF9F768FD08]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CreateValue()
       mov       rsi,[rsp+40]
       mov       rdi,[rsp+48]
       mov       rbp,[rsp+50]
       jmp       near ptr M00_L00
M00_L10:
       mov       ecx,8
       call      qword ptr [7FF9F772FDC8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L11:
       mov       eax,r14d
       neg       eax
       xor       edx,edx
       div       r14d
       jmp       short M00_L13
M00_L12:
       mov       r8,[rcx+8]
       mov       rax,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rax
       shl       r11,11
       xor       r10,r8
       xor       r9,rax
       lea       r13,[rax+rax*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rax,r10
       xor       r8,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],rax
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       eax,r14d
       shr       r13,20
       mov       r13d,r13d
       imul      r13,rax
       mov       r8d,r13d
M00_L13:
       cmp       r8d,edx
       jb        short M00_L12
       jmp       near ptr M00_L03
M00_L14:
       mov       eax,r14d
       neg       eax
       xor       edx,edx
       div       r14d
       mov       [rsp+3C],edx
       jmp       short M00_L16
M00_L15:
       mov       r8,[rcx+8]
       mov       r10,[rcx+10]
       mov       rax,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,r10
       shl       r11,11
       xor       rax,r8
       xor       r9,r10
       lea       rdx,[r10+r10*4]
       rol       rdx,7
       lea       rdx,[rdx+rdx*8]
       xor       r10,rax
       xor       r8,r9
       xor       rax,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],r10
       mov       [rcx+18],rax
       mov       [rcx+20],r9
       mov       r8d,r14d
       shr       rdx,20
       mov       eax,edx
       imul      r8,rax
       mov       r10d,r8d
       mov       edx,[rsp+3C]
M00_L16:
       cmp       r10d,edx
       jb        short M00_L15
       jmp       near ptr M00_L05
M00_L17:
       mov       eax,r12d
       neg       eax
       xor       edx,edx
       div       r12d
       jmp       short M00_L19
M00_L18:
       mov       r8,[rcx+8]
       mov       r10,[rcx+10]
       mov       rax,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,r10
       shl       r11,11
       xor       rax,r8
       xor       r9,r10
       lea       rbp,[r10+r10*4]
       rol       rbp,7
       lea       rbp,[rbp+rbp*8]
       xor       r10,rax
       xor       r8,r9
       xor       rax,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],r10
       mov       [rcx+18],rax
       mov       [rcx+20],r9
       mov       r8d,r12d
       shr       rbp,20
       mov       eax,ebp
       imul      r8,rax
       mov       r10d,r8d
M00_L19:
       cmp       r10d,edx
       jb        short M00_L18
       jmp       near ptr M00_L07
M00_L20:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1078
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFA3C43E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA3C448738]
       call      qword ptr [7FFA3C435EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CreateValue()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
M03_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-8],rax
       cmp       qword ptr [rbp-8],0
       je        near ptr M03_L03
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F768FD20]; System.LazyHelper.get_State()
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],8
       ja        short M03_L01
       mov       eax,[rbp-0C]
       lea       rcx,[7FF9F7184BE8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L00]
       add       rcx,rdx
       jmp       rcx
M03_L01:
       jmp       short M03_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F768FD38]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF9F768FD50]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FF9F768FD68]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FF9F768FD80]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F768FD98]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       r8d,1
       call      qword ptr [7FF9F768FDB0]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       xor       r8d,r8d
       call      qword ptr [7FF9F768FDB0]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F768FDC8]
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9F768FCD8]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Value()
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 242
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA3C44CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomPersonData()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0B8
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqa   xmmword ptr [rsp+0A0],xmm4
       mov       [rsp+0B0],rax
       mov       [rsp+100],rcx
       mov       rdx,16751401318
       mov       rcx,[rdx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L14
       add       rcx,18
       mov       rsi,[rcx]
       mov       rdi,[rcx+8]
       mov       rbp,[rcx+10]
M00_L00:
       mov       r14d,[rsi+8]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L15
       mov       rcx,[rcx+240]
       mov       r15,[rcx+40]
       test      r15,r15
       je        near ptr M00_L15
M00_L01:
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       short M00_L02
       call      qword ptr [7FF9F7724030]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L02:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r13d,r14d
       shr       r11,20
       mov       r12d,r11d
       imul      r13,r12
       mov       r8d,r13d
       cmp       r8d,r14d
       jb        near ptr M00_L16
M00_L03:
       shr       r13,20
       cmp       r13d,[rsi+8]
       jae       near ptr M00_L29
       mov       eax,r13d
       mov       rsi,[rsi+rax*8+10]
       cmp       r13d,[rdi+8]
       jae       near ptr M00_L29
       mov       eax,r13d
       mov       rdi,[rdi+rax*8+10]
       mov       [rsp+48],rsi
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L08
       mov       r14d,[rdi+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       short M00_L04
       call      qword ptr [7FF9F7724030]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L04:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r8d,r14d
       shr       r11,20
       mov       r10d,r11d
       imul      r8,r10
       mov       r10d,r8d
       cmp       r10d,r14d
       jb        near ptr M00_L19
M00_L05:
       shr       r8,20
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L29
       cmp       r13d,[rbp+8]
       jae       near ptr M00_L29
       mov       eax,r13d
       mov       rax,[rbp+rax*8+10]
       cmp       r8d,[rax+8]
       jae       near ptr M00_L29
       mov       ecx,r8d
       mov       rdi,[rax+rcx*8+10]
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L08
       mov       ebp,[rdi+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       jne       short M00_L06
       call      qword ptr [7FF9F7724030]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L06:
       mov       rax,[rcx+8]
       mov       rdx,[rcx+10]
       mov       r8,[rcx+18]
       mov       r10,[rcx+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rax
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rax,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rcx+8],rax
       mov       [rcx+10],rdx
       mov       [rcx+18],r8
       mov       [rcx+20],r10
       mov       r8d,ebp
       shr       r11,20
       mov       r10d,r11d
       imul      r8,r10
       mov       r10d,r8d
       cmp       r10d,ebp
       jb        near ptr M00_L22
M00_L07:
       shr       r8,20
       cmp       r8d,[rdi+8]
       jae       near ptr M00_L29
M00_L08:
       mov       rcx,16751401308
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L25
       mov       rdi,[rcx+18]
M00_L09:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        near ptr M00_L30
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L29
       mov       ecx,eax
       mov       rdi,[rdi+rcx*8+10]
       mov       [rsp+40],rdi
       mov       rcx,16751401310
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L26
       mov       rbp,[rcx+18]
M00_L10:
       mov       edx,[rbp+8]
       sub       edx,1
       jo        near ptr M00_L30
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rbp+8]
       jae       near ptr M00_L29
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       mov       [rsp+38],rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rsp+50],r14
       mov       rcx,1A7E6360008
       mov       [r14+8],rcx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       lea       rcx,[rsp+68]
       mov       rax,7FFA942D5380
       call      rax
       mov       rbx,[rsp+68]
       mov       rax,16751401B00
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFA570739A0],0
       jne       near ptr M00_L27
M00_L11:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M00_L28
       add       rbx,[rsi+10]
M00_L12:
       mov       [rsp+60],rbx
       mov       rcx,16751401E18
       mov       rsi,[rcx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77A58F0]; System.TimeZoneInfo+CachedData.get_Local()
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8d,2
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77247B0]; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       mov       rbx,rax
       lea       rcx,[rsp+60]
       call      qword ptr [7FF9F76169A0]; System.DateTime.get_Ticks()
       lea       rdx,[rax+rbx]
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       jbe       short M00_L13
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77A4948]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7484378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       lea       rcx,[rsp+0A8]
       mov       r8,rbx
       call      qword ptr [7FF9F77A5908]; System.DateTimeOffset.CreateValidateOffset(System.DateTime, System.TimeSpan)
       mov       dword ptr [rsp+0A0],1
       xor       ecx,ecx
       mov       [rsp+98],rcx
       lea       rcx,[rsp+0A0]
       mov       edx,5A
       call      qword ptr [7FF9F768FBA0]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32)
       imul      edx,eax,16D
       jo        near ptr M00_L30
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+98]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FF9F77A5920]; System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+88]
       mov       r8,[rsp+98]
       call      qword ptr [7FF9F768FBD0]; System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovups   xmm0,[rsp+88]
       mov       r14,[rsp+50]
       vmovups   [r14+38],xmm0
       mov       rsi,[rsp+48]
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9F768FC18]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+38]
       call      qword ptr [7FF9F768FC60]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
       lea       rcx,[r14+18]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+20]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+28]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9F768FC18]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r14+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+58],r14
       mov       rbx,[rsp+100]
       mov       rcx,[rbx+60]
       lea       r8,[rsp+58]
       mov       rdx,7FF9F7783FE8
       cmp       [rcx],ecx
       call      qword ptr [7FF9F772D968]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0B8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L14:
       lea       rdx,[rsp+70]
       call      qword ptr [7FF9F768FD08]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CreateValue()
       mov       rsi,[rsp+70]
       mov       rdi,[rsp+78]
       mov       rbp,[rsp+80]
       jmp       near ptr M00_L00
M00_L15:
       mov       ecx,8
       call      qword ptr [7FF9F772FDE0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r15,rax
       jmp       near ptr M00_L01
M00_L16:
       mov       eax,r14d
       neg       eax
       xor       edx,edx
       div       r14d
       jmp       short M00_L18
M00_L17:
       mov       r8,[rcx+8]
       mov       rax,[rcx+10]
       mov       r10,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,rax
       shl       r11,11
       xor       r10,r8
       xor       r9,rax
       lea       r13,[rax+rax*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       rax,r10
       xor       r8,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],rax
       mov       [rcx+18],r10
       mov       [rcx+20],r9
       mov       eax,r14d
       shr       r13,20
       mov       r13d,r13d
       imul      r13,rax
       mov       r8d,r13d
M00_L18:
       cmp       r8d,edx
       jb        short M00_L17
       jmp       near ptr M00_L03
M00_L19:
       mov       eax,r14d
       neg       eax
       xor       edx,edx
       div       r14d
       jmp       short M00_L21
M00_L20:
       mov       r8,[rcx+8]
       mov       r10,[rcx+10]
       mov       rax,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,r10
       shl       r11,11
       xor       rax,r8
       xor       r9,r10
       lea       r12,[r10+r10*4]
       rol       r12,7
       lea       r12,[r12+r12*8]
       xor       r10,rax
       xor       r8,r9
       xor       rax,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],r10
       mov       [rcx+18],rax
       mov       [rcx+20],r9
       mov       r8d,r14d
       shr       r12,20
       mov       eax,r12d
       imul      r8,rax
       mov       r10d,r8d
M00_L21:
       cmp       r10d,edx
       jb        short M00_L20
       jmp       near ptr M00_L05
M00_L22:
       mov       eax,ebp
       neg       eax
       xor       edx,edx
       div       ebp
       jmp       short M00_L24
M00_L23:
       mov       r8,[rcx+8]
       mov       r10,[rcx+10]
       mov       rax,[rcx+18]
       mov       r9,[rcx+20]
       mov       r11,r10
       shl       r11,11
       xor       rax,r8
       xor       r9,r10
       lea       r14,[r10+r10*4]
       rol       r14,7
       lea       r14,[r14+r14*8]
       xor       r10,rax
       xor       r8,r9
       xor       rax,r11
       rol       r9,2D
       mov       [rcx+8],r8
       mov       [rcx+10],r10
       mov       [rcx+18],rax
       mov       [rcx+20],r9
       mov       r8d,ebp
       shr       r14,20
       mov       eax,r14d
       imul      r8,rax
       mov       r10d,r8d
M00_L24:
       cmp       r10d,edx
       jb        short M00_L23
       jmp       near ptr M00_L07
M00_L25:
       call      qword ptr [7FF9F7484090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L26:
       call      qword ptr [7FF9F7484090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L11
M00_L28:
       call      qword ptr [7FF9F7616B50]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M00_L12
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L30:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1822
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFA3C43E760]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA3C448738]
       call      qword ptr [7FFA3C435EA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M02_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M02_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M02_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F752FB28
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M02_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M02_L00
       add       eax,ebx
M02_L03:
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
M02_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77A4810]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7484378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F772FCC0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.TimeZoneInfo+CachedData.get_Local()
       mov       rax,[rcx+8]
       test      rax,rax
       je        short M03_L00
       ret
M03_L00:
       jmp       qword ptr [7FF9F7724390]; System.TimeZoneInfo+CachedData.CreateLocal()
; Total bytes of code 16
```
```assembly
; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,rcx
       mov       rdi,rdx
       mov       ebp,r8d
       mov       rsi,r9
       mov       rax,rdi
       shr       rax,3E
       mov       r8d,eax
       shr       r8d,1
       andn      eax,r8d,eax
       cmp       eax,2
       je        short M04_L01
       cmp       eax,1
       jne       near ptr M04_L02
       cmp       [rsi],sil
       mov       rax,16751401E10
       cmp       rbx,[rax]
       jne       short M04_L00
       mov       rax,[rbx+40]
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L00:
       lea       r8,[rsp+30]
       lea       r9,[rsp+28]
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF9F77247E0]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L01:
       mov       rcx,rsi
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77247C8]; System.TimeZoneInfo+CachedData.GetCorrespondingKind(System.TimeZoneInfo)
       cmp       eax,2
       je        short M04_L02
       mov       rcx,rsi
       call      qword ptr [7FF9F77A58F0]; System.TimeZoneInfo+CachedData.get_Local()
       mov       rdx,rax
       mov       r8,16751401E18
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,16751401E10
       mov       r8,[r8]
       mov       rcx,rdi
       mov       r9d,ebp
       call      qword ptr [7FF9F77A4930]
       mov       rcx,rax
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      qword ptr [7FF9F77247E0]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M04_L02:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FF9F77A4918]
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 243
```
```assembly
; System.DateTime.get_Ticks()
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rcx]
       ret
; Total bytes of code 14
```
```assembly
; System.DateTimeOffset.CreateValidateOffset(System.DateTime, System.TimeSpan)
       sub       rsp,28
       mov       r10,rdx
       mov       rdx,1CA213D840BAF7D5
       mov       rax,rdx
       imul      r8
       mov       rax,rdx
       shr       rax,3F
       sar       rdx,1A
       add       rax,rdx
       imul      rdx,rax,23C34600
       cmp       r8,rdx
       jne       short M06_L00
       cmp       rax,0FFFFFFFFFFFFFCB8
       jl        short M06_L01
       cmp       rax,348
       jg        short M06_L01
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,r10
       sub       rdx,r8
       mov       r8,2BCA2875F4373FFF
       cmp       rdx,r8
       ja        short M06_L02
       mov       [rcx],eax
       mov       [rcx+8],rdx
       mov       rax,rcx
       add       rsp,28
       ret
M06_L00:
       call      qword ptr [7FF9F77A4960]
       int       3
M06_L01:
       call      qword ptr [7FF9F77A4978]
       int       3
M06_L02:
       call      qword ptr [7FF9F77A4990]
       int       3
; Total bytes of code 131
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32)
; 		max = max.EnsureMinimum(min + 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return RandomNumberGenerator.GetInt32(min, max);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       ecx,[rcx]
       mov       eax,ecx
       add       eax,1
       jo        short M07_L00
       cmp       edx,eax
       cmovl     edx,eax
       add       rsp,28
       jmp       qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
M07_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 34
```
```assembly
; System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       sub       rsp,28
       movsxd    rax,edx
       mov       rdx,141DD76000
       imul      rax,rdx
       movsxd    rdx,r8d
       mov       r8d,0D693A400
       imul      rdx,r8
       add       rax,rdx
       movsxd    rdx,r9d
       imul      rdx,3938700
       add       rax,rdx
       movsxd    rdx,dword ptr [rsp+50]
       imul      rdx,0F4240
       add       rax,rdx
       movsxd    rdx,dword ptr [rsp+58]
       imul      rdx,3E8
       add       rax,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rax,rdx
       jg        short M08_L00
       mov       rdx,0F333333333333334
       cmp       rax,rdx
       jl        short M08_L00
       lea       rax,[rax+rax*4]
       add       rax,rax
       mov       [rcx],rax
       add       rsp,28
       ret
M08_L00:
       call      qword ptr [7FF9F77A4A08]
       int       3
; Total bytes of code 132
```
```assembly
; System.DateTimeOffset.Subtract(System.TimeSpan)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rax,[rcx+8]
       mov       ecx,[rcx]
       movsxd    r10,ecx
       imul      r10,23C34600
       add       rax,r10
       mov       r9,3FFFFFFFFFFFFFFF
       and       r9,rax
       sub       r9,r8
       mov       r8,2BCA2875F4373FFF
       cmp       r9,r8
       ja        short M09_L00
       mov       r8,0C000000000000000
       and       rax,r8
       or        rax,r9
       mov       r8,3FFFFFFFFFFFFFFF
       and       rax,r8
       sub       rax,r10
       mov       r8,2BCA2875F4373FFF
       cmp       rax,r8
       ja        short M09_L01
       mov       [rdx],ecx
       mov       [rdx+8],rax
       mov       rax,rdx
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L00:
       mov       ecx,3AD
       mov       rdx,7FF9F7044000
       call      qword ptr [7FF9F73277B0]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FF9F77A58A8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FF9F732DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M09_L01:
       call      qword ptr [7FF9F77A4990]
       int       3
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+20],xmm4
       xor       eax,eax
       mov       [rbp+30],rax
       mov       rax,6BAF0781D6E3
       mov       [rbp+8],rax
       mov       ebx,ecx
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       mov       eax,1
       test      ecx,ecx
       cmove     ebx,eax
; 		byte[]? rentedBytes = null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		char[]? rentedChars = null;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       [rbp+10],rcx
; 		var bytes = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc byte[length]
; 			                         
; 			: (rentedBytes = ArrayPool<byte>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       cmp       ebx,100
       jg        near ptr M10_L17
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M10_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M10_L00:
       push      0
       push      0
       dec       rsi
       jne       short M10_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M10_L01:
       test      ebx,ebx
       jl        near ptr M10_L21
       mov       edi,ebx
M10_L02:
       cmp       ebx,100
       jg        near ptr M10_L19
; 		var chars = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc char[length]
; 			                         
; 			: (rentedChars = ArrayPool<char>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       mov       eax,ebx
       mov       ecx,2
       mul       rcx
       jb        near ptr M10_L23
       mov       r14,rax
       test      r14,r14
       je        short M10_L04
       add       r14,0F
       shr       r14,4
       add       rsp,20
M10_L03:
       push      0
       push      0
       dec       r14
       jne       short M10_L03
       sub       rsp,20
       lea       r14,[rsp+20]
M10_L04:
       test      ebx,ebx
       jl        near ptr M10_L21
       mov       r15d,ebx
M10_L05:
       test      edi,edi
       jle       short M10_L06
       mov       rcx,rsi
       mov       [rbp+30],rcx
       mov       edx,edi
       call      qword ptr [7FF9F7514C00]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+30],rcx
M10_L06:
       xor       ecx,ecx
       mov       [rbp+30],rcx
; 			for (var digitIndex = 0; digitIndex < length; digitIndex++)
; 			                         ^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       jle       short M10_L08
       cmp       ebx,r15d
       jg        short M10_L09
       cmp       ebx,edi
       jg        short M10_L09
; 				chars[digitIndex] = (char)('0' + (bytes[digitIndex] % 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M10_L07:
       mov       eax,ecx
       movzx     edx,byte ptr [rsi+rax]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M10_L11
       cmp       edx,0FFFF
       ja        short M10_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M10_L11
       cmp       ecx,ebx
       jl        short M10_L07
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M10_L08:
       mov       [rbp+20],r14
       mov       [rbp+28],r15d
       lea       rcx,[rbp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       jmp       short M10_L12
M10_L09:
       cmp       ecx,r15d
       jae       short M10_L10
       mov       eax,ecx
       cmp       ecx,edi
       jae       short M10_L10
       mov       edx,ecx
       movzx     edx,byte ptr [rsi+rdx]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M10_L11
       cmp       edx,0FFFF
       ja        short M10_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M10_L11
       cmp       ecx,ebx
       jl        short M10_L09
       jmp       short M10_L08
M10_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M10_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			if (rentedBytes is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M10_L12:
       cmp       qword ptr [rbp+18],0
       je        short M10_L14
; 				ArrayPool<byte>.Shared.Return(rentedBytes);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      byte ptr [7FF9F77013C8],1
       je        near ptr M10_L22
M10_L13:
       mov       rcx,16751401E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732EA8]
; 			if (rentedChars is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M10_L14:
       cmp       qword ptr [rbp+10],0
       je        short M10_L15
; 				ArrayPool<char>.Shared.Return(rentedChars);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,16751400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
M10_L15:
       mov       rax,rbx
       mov       r8,6BAF0781D6E3
       cmp       [rbp+8],r8
       je        short M10_L16
       call      CORINFO_HELP_FAIL_FAST
M10_L16:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M10_L17:
       test      byte ptr [7FF9F77013C8],1
       je        short M10_L20
M10_L18:
       mov       rcx,16751401E48
       mov       rcx,[rcx]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732EA0]
       mov       [rbp+18],rax
       test      rax,rax
       je        short M10_L21
       cmp       [rax+8],ebx
       jb        short M10_L21
       add       rax,10
       mov       rsi,rax
       mov       edi,ebx
       jmp       near ptr M10_L02
M10_L19:
       mov       rcx,16751400C88
       mov       rcx,[rcx]
       mov       edx,ebx
       call      qword ptr [7FF9F73D0798]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+10],rax
       test      rax,rax
       je        short M10_L21
       cmp       [rax+8],ebx
       jb        short M10_L21
       add       rax,10
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M10_L05
M10_L20:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M10_L18
M10_L21:
       call      qword ptr [7FF9F7277198]
       int       3
M10_L22:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L13
M10_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp+18],0
       je        short M10_L25
       test      byte ptr [7FF9F77013C8],1
       jne       short M10_L24
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M10_L24:
       mov       rcx,16751401E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732EA8]
M10_L25:
       cmp       qword ptr [rbp+10],0
       je        short M10_L26
       mov       rcx,16751400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
M10_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
; 		return $"{firstName.DefaultIfNullOrEmpty("FIRSTNAME")}.{lastName.DefaultIfNullOrEmpty("LASTNAME")}@{GenerateWord(5, 15, 'a', 'z')}.{GenerateDomainExtension()}";
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+20],ymm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,16751400C88
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       edx,100
       call      qword ptr [7FF9F73D0798]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+40],rax
       test      rax,rax
       je        near ptr M11_L19
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M11_L00:
       mov       [rsp+50],rdx
       mov       [rsp+58],r8d
       xor       edx,edx
       mov       [rsp+48],edx
       mov       byte ptr [rsp+4C],0
       test      rbx,rbx
       je        near ptr M11_L20
       cmp       dword ptr [rbx+8],0
       je        near ptr M11_L20
M11_L01:
       cmp       byte ptr [rsp+4C],0
       jne       near ptr M11_L12
       mov       edx,[rsp+48]
       cmp       edx,[rsp+58]
       ja        near ptr M11_L23
       mov       r8,[rsp+50]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rsp+58]
       sub       r8d,edx
       cmp       [rbx+8],r8d
       ja        near ptr M11_L12
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+48]
       add       ecx,[rbx+8]
       mov       [rsp+48],ecx
M11_L02:
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+58]
       ja        near ptr M11_L23
       mov       rdx,[rsp+50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+58]
       sub       eax,ecx
       je        near ptr M11_L13
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+48]
       inc       ecx
       mov       [rsp+48],ecx
M11_L03:
       test      rsi,rsi
       je        near ptr M11_L21
       cmp       dword ptr [rsi+8],0
       je        near ptr M11_L21
M11_L04:
       cmp       byte ptr [rsp+4C],0
       jne       near ptr M11_L14
       mov       edx,[rsp+48]
       cmp       edx,[rsp+58]
       ja        near ptr M11_L23
       mov       r8,[rsp+50]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rsp+58]
       sub       r8d,edx
       cmp       [rsi+8],r8d
       ja        near ptr M11_L14
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+48]
       add       ecx,[rsi+8]
       mov       [rsp+48],ecx
M11_L05:
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+58]
       ja        near ptr M11_L23
       mov       rdx,[rsp+50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+58]
       sub       eax,ecx
       je        near ptr M11_L15
       mov       word ptr [rdx],40
       mov       ecx,[rsp+48]
       inc       ecx
       mov       [rsp+48],ecx
M11_L06:
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ecx,5
       mov       edx,0F
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7724B58]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       cmp       byte ptr [rsp+4C],0
       jne       near ptr M11_L16
       test      rbx,rbx
       je        near ptr M11_L16
       mov       r8d,[rsp+48]
       cmp       r8d,[rsp+58]
       ja        near ptr M11_L23
       mov       rdx,[rsp+50]
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2]
       mov       edx,[rsp+58]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M11_L16
       mov       r8d,[rbx+8]
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+48]
       add       ecx,[rbx+8]
       mov       [rsp+48],ecx
M11_L07:
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+58]
       ja        near ptr M11_L23
       mov       rdx,[rsp+50]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+58]
       sub       eax,ecx
       je        near ptr M11_L17
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+48]
       inc       ecx
       mov       [rsp+48],ecx
M11_L08:
       mov       rcx,167514012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M11_L22
       mov       rbx,[rcx+18]
M11_L09:
       mov       edx,[rbx+8]
       sub       edx,1
       jo        near ptr M11_L25
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rbx+8]
       jae       near ptr M11_L24
       mov       r8d,eax
       mov       rbx,[rbx+r8*8+10]
       cmp       byte ptr [rsp+4C],0
       jne       near ptr M11_L18
       test      rbx,rbx
       je        near ptr M11_L18
       mov       r8d,[rsp+48]
       cmp       r8d,[rsp+58]
       ja        near ptr M11_L23
       mov       rdx,[rsp+50]
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2]
       mov       edx,[rsp+58]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M11_L18
       mov       r8d,[rbx+8]
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+48]
       add       ecx,[rbx+8]
       mov       [rsp+48],ecx
M11_L10:
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+58]
       ja        near ptr M11_L23
       mov       rax,[rsp+50]
       mov       [rsp+20],rax
       mov       [rsp+28],ecx
       lea       rcx,[rsp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rsp+40]
       xor       ecx,ecx
       mov       [rsp+40],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+50],xmm0
       mov       [rsp+48],ecx
       test      rdx,rdx
       je        short M11_L11
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M11_L11:
       mov       rax,rbx
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M11_L12:
       lea       rcx,[rsp+38]
       mov       rdx,rbx
       call      qword ptr [7FF9F77A4348]
       jmp       near ptr M11_L02
M11_L13:
       lea       rcx,[rsp+38]
       mov       rdx,1A7E6360658
       call      qword ptr [7FF9F7727390]
       jmp       near ptr M11_L03
M11_L14:
       lea       rcx,[rsp+38]
       mov       rdx,rsi
       call      qword ptr [7FF9F77A4348]
       jmp       near ptr M11_L05
M11_L15:
       lea       rcx,[rsp+38]
       mov       rdx,1A7E636FDA8
       call      qword ptr [7FF9F7727390]
       jmp       near ptr M11_L06
M11_L16:
       lea       rcx,[rsp+38]
       mov       rdx,rbx
       call      qword ptr [7FF9F77A4348]
       jmp       near ptr M11_L07
M11_L17:
       lea       rcx,[rsp+38]
       mov       rdx,1A7E6360658
       call      qword ptr [7FF9F7727390]
       jmp       near ptr M11_L08
M11_L18:
       lea       rcx,[rsp+38]
       mov       rdx,rbx
       call      qword ptr [7FF9F77A4348]
       jmp       near ptr M11_L10
M11_L19:
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M11_L00
M11_L20:
       mov       rbx,1A7E636FD58
       jmp       near ptr M11_L01
M11_L21:
       mov       rsi,1A7E636FD80
       jmp       near ptr M11_L04
M11_L22:
       call      qword ptr [7FF9F7484090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       near ptr M11_L09
M11_L23:
       call      qword ptr [7FF9F7277198]
       int       3
M11_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1102
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
; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CreateValue()
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
M13_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+8]
       mov       [rbp-8],rax
       cmp       qword ptr [rbp-8],0
       je        near ptr M13_L03
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F768FD20]; System.LazyHelper.get_State()
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],8
       ja        short M13_L01
       mov       eax,[rbp-0C]
       lea       rcx,[7FF9F7184BC8]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M13_L00]
       add       rcx,rdx
       jmp       rcx
M13_L01:
       jmp       short M13_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F768FD38]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF9F768FD50]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FF9F768FD68]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FF9F768FD80]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FF9F768FD98]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       r8d,1
       call      qword ptr [7FF9F768FDB0]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       xor       r8d,r8d
       call      qword ptr [7FF9F768FDB0]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M13_L03
M13_L02:
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F768FDC8]
M13_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FF9F768FCD8]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Value()
       mov       rax,[rbp+18]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 242
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFA3C44CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M14_L01
       cmp       [rax],ecx
       jle       short M14_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M14_L03
M14_L00:
       add       rsp,20
       pop       rbx
       ret
M14_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M14_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M14_L00
M14_L02:
       cmp       [rax+4],edx
       jle       short M14_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M14_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M14_L03
       jmp       short M14_L00
M14_L03:
       mov       ecx,ebx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
; Total bytes of code 130
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M15_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M15_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M15_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M15_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M15_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M15_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M15_L03:
       cmp       ecx,8
       ja        short M15_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M15_L00]
       add       rdx,r8
       jmp       rdx
M15_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M15_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M15_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M15_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M15_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M15_L01
M15_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M15_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M15_L01
; Total bytes of code 269
```
```assembly
; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       lea       rbp,[rsp+80]
       call      qword ptr [7FFA3C434430]
       mov       rax,[rax]
       lea       rcx,[rbp-20]
       call      rax
       mov       rdx,346DC5D63886594B
       mov       rax,rdx
       mul       qword ptr [rbp-20]
       shr       rdx,0B
       imul      rax,rdx,2710
       mov       rbx,[rbp-20]
       sub       rbx,rax
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L04
M16_L00:
       lea       rcx,[rbp-20]
       lea       rdx,[rbp-30]
       call      qword ptr [7FFA3C461570]
       test      eax,eax
       je        near ptr M16_L05
       cmp       word ptr [rbp-24],3C
       jae       near ptr M16_L06
       mov       eax,0B2D05E00
       add       rax,[rbp-20]
       mov       [rbp-38],rax
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       cmp       dword ptr [rax],0
       jne       near ptr M16_L07
M16_L01:
       lea       rcx,[rbp-38]
       lea       rdx,[rbp-48]
       call      qword ptr [7FFA3C461570]
       test      eax,eax
       je        short M16_L05
       movzx     ecx,word ptr [rbp-3C]
       cmp       cx,[rbp-24]
       jne       short M16_L08
       mov       rsi,[rbp-20]
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFA3C447890]
       mov       rbx,rax
M16_L02:
       call      qword ptr [7FFA3C43E5C0]
       mov       rdi,rax
       call      qword ptr [7FFA3C4346B8]
       mov       [rdi+8],rsi
       mov       [rdi+10],rbx
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFA3C433FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
       add       rbx,[rbp-20]
       sub       rbx,rsi
       mov       rax,rbx
M16_L03:
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M16_L04:
       call      qword ptr [7FFA3C434040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L00
M16_L05:
       call      qword ptr [7FFA3C4478B0]
       jmp       short M16_L03
M16_L06:
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFA3C447890]
       jmp       short M16_L03
M16_L07:
       call      qword ptr [7FFA3C434040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L01
M16_L08:
       movups    xmm0,[rbp-30]
       movups    [rbp-58],xmm0
       mov       word ptr [rbp-50],0
       mov       word ptr [rbp-4E],0
       mov       word ptr [rbp-4C],0
       mov       word ptr [rbp-4A],0
       lea       rcx,[rbp-58]
       lea       rdx,[rbp-60]
       call      qword ptr [7FFA3C444F28]
       test      eax,eax
       je        short M16_L05
       mov       rsi,0C87700CB80
       add       rsi,[rbp-60]
       mov       rcx,[rbp-20]
       sub       rcx,rsi
       mov       edx,0B2D05E00
       cmp       rcx,rdx
       jae       short M16_L06
       lea       rcx,[rbp-58]
       xor       edx,edx
       call      qword ptr [7FFA3C447890]
       mov       rbx,0C87700CB80
       add       rbx,rax
       jmp       near ptr M16_L02
; Total bytes of code 402
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRandomPersonName()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+30],rax
       mov       rbx,rcx
       mov       rcx,1E676001308
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L02
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        near ptr M00_L05
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F7734138]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L04
       mov       ecx,eax
       mov       rsi,[rsi+rcx*8+10]
       mov       rcx,1E676001310
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L03
       mov       rdi,[rcx+18]
M00_L01:
       mov       ebp,[rdi+8]
       mov       edx,ebp
       sub       edx,1
       jo        short M00_L05
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F7734138]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,ebp
       jae       short M00_L04
       mov       edx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rsi
       mov       [rsp+30],rdx
       mov       rdx,[rbx+60]
       cmp       [rdx],dl
       lea       rdx,[rsp+28]
       mov       rcx,7FF9F7794000
       call      qword ptr [7FF9F773DA10]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FF9F7494090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FF9F7494090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 245
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F753FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77C4660]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7494378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F773FC78]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       ret
; Total bytes of code 1
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M03_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M03_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M03_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M03_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M03_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M03_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M03_L03:
       cmp       ecx,8
       ja        short M03_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M03_L00]
       add       rdx,r8
       jmp       rdx
M03_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M03_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M03_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M03_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M03_L01
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M03_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FF9F7725D70]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
; 		var sb = _stringBuilderPool.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var segmentCount = Random.Shared.Next(1, 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var segmentIndex = 0; segmentIndex < segmentCount; segmentIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^^
; 				var segmentLength = Random.Shared.Next(1, 26);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append('/');
; 				^^^^^^^^^^^^^^^^^^^
; 				for (var charIndex = 0; charIndex < segmentLength; charIndex++)
; 				     ^^^^^^^^^^^^^^^^^
; 					_ = sb.Append((char)('a' + Random.Shared.Next(26)));
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = sb.Append('/');
; 			^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-38],rax
       mov       rcx,24928801338
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M01_L30
       lea       rcx,[rbx+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M01_L29
       xor       edx,edx
       call      00007FFA56D53270
       cmp       rax,[rbp-38]
       jne       near ptr M01_L30
M01_L00:
       mov       rdx,[rbp-38]
M01_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-40],rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M01_L17
       mov       rcx,[rcx+240]
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        near ptr M01_L17
M01_L02:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L03
       call      qword ptr [7FF9F769C348]; System.Random+ThreadSafeRandom.Create()
M01_L03:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       lea       rsi,[rcx+rcx*8]
       mov       ecx,esi
       cmp       ecx,9
       jb        near ptr M01_L18
M01_L04:
       shr       rsi,20
       inc       esi
       xor       edi,edi
       cmp       edi,esi
       jl        short M01_L08
M01_L05:
       mov       rdx,[rbp-40]
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       cmp       [r8+8],eax
       jbe       near ptr M01_L27
       mov       word ptr [r8+rax*2+10],2F
       inc       ecx
       mov       [rdx+18],ecx
M01_L06:
       mov       rcx,rdx
       call      qword ptr [7FF9F7302100]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       near ptr M01_L28
M01_L07:
       add       edi,1
       jo        near ptr M01_L24
       cmp       edi,esi
       jge       short M01_L05
M01_L08:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L09
       call      qword ptr [7FF9F769C348]; System.Random+ThreadSafeRandom.Create()
M01_L09:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       imul      r14,rcx,19
       mov       ecx,r14d
       cmp       ecx,19
       jb        near ptr M01_L20
M01_L10:
       shr       r14,20
       inc       r14d
       mov       rdx,[rbp-40]
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       near ptr M01_L22
       mov       word ptr [r8+rax*2+10],2F
       inc       ecx
       mov       [rdx+18],ecx
M01_L11:
       xor       r15d,r15d
       cmp       r15d,r14d
       jl        near ptr M01_L16
       jmp       near ptr M01_L07
M01_L12:
       call      qword ptr [7FF9F769C348]; System.Random+ThreadSafeRandom.Create()
       mov       rdx,[rbp-40]
M01_L13:
       mov       rcx,[rax+8]
       mov       r8,[rax+10]
       mov       r10,[rax+18]
       mov       r9,[rax+20]
       mov       r11,r8
       shl       r11,11
       xor       r10,rcx
       xor       r9,r8
       lea       r13,[r8+r8*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r8,r10
       xor       rcx,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rax+8],rcx
       mov       [rax+10],r8
       mov       [rax+18],r10
       mov       [rax+20],r9
       shr       r13,20
       mov       ecx,r13d
       imul      rcx,1A
       mov       r8d,ecx
       cmp       r8d,1A
       jb        near ptr M01_L23
M01_L14:
       shr       rcx,20
       add       ecx,61
       jo        near ptr M01_L24
       cmp       ecx,0FFFF
       ja        near ptr M01_L24
       mov       eax,ecx
       mov       ecx,[rdx+18]
       mov       r8d,ecx
       mov       r10,[rdx+8]
       mov       r9d,[r10+8]
       cmp       r9d,r8d
       jbe       near ptr M01_L26
       mov       [r10+r8*2+10],ax
       inc       ecx
       mov       [rdx+18],ecx
M01_L15:
       add       r15d,1
       jo        near ptr M01_L24
       cmp       r15d,r14d
       jge       near ptr M01_L07
M01_L16:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L13
       jmp       near ptr M01_L12
M01_L17:
       mov       ecx,8
       call      qword ptr [7FF9F772E1A8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rbx,rax
       jmp       near ptr M01_L02
M01_L18:
       cmp       ecx,4
       jae       near ptr M01_L04
M01_L19:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       lea       rsi,[rcx+rcx*8]
       mov       ecx,esi
       cmp       ecx,4
       jb        short M01_L19
       jmp       near ptr M01_L04
M01_L20:
       cmp       ecx,15
       jae       near ptr M01_L10
M01_L21:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       imul      r14,rcx,19
       mov       ecx,r14d
       cmp       ecx,15
       jb        short M01_L21
       jmp       near ptr M01_L10
M01_L22:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FF9F728F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L11
M01_L23:
       cmp       r8d,16
       jb        short M01_L25
       jmp       near ptr M01_L14
M01_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L25:
       mov       rcx,[rax+8]
       mov       r8,[rax+10]
       mov       r10,[rax+18]
       mov       r9,[rax+20]
       mov       r11,r8
       shl       r11,11
       xor       r10,rcx
       xor       r9,r8
       lea       r13,[r8+r8*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r8,r10
       xor       rcx,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rax+8],rcx
       mov       [rax+10],r8
       mov       [rax+18],r10
       mov       [rax+20],r9
       shr       r13,20
       mov       ecx,r13d
       imul      rcx,1A
       mov       r8d,ecx
       jmp       short M01_L23
M01_L26:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FF9F728F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L15
M01_L27:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FF9F728F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L06
M01_L28:
       call      M01_L32
       nop
       mov       rax,[rbp-48]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L29:
       call      qword ptr [7FF9F772E388]
       int       3
M01_L30:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F769DD70]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M01_L31
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M01_L00
M01_L31:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M01_L01
M01_L32:
       sub       rsp,28
       mov       rcx,[rbp-40]
       cmp       dword ptr [rcx+20],0
       jge       short M01_L33
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF9F7054000
       call      qword ptr [7FF9F73377B0]
       mov       rsi,rax
       call      qword ptr [7FF9F772E3D0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F733DA40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L33:
       cmp       qword ptr [rcx+10],0
       jne       short M01_L34
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M01_L41
M01_L34:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M01_L35
       xor       edx,edx
       call      qword ptr [7FF9F772E3E8]
       mov       rcx,[rbp-40]
       jmp       near ptr M01_L41
M01_L35:
       xor       edx,edx
       call      qword ptr [7FF9F772E400]; System.Text.StringBuilder.FindChunkForIndex(Int32)
       mov       rbx,rax
       mov       rcx,[rbp-40]
       cmp       rbx,rcx
       je        near ptr M01_L40
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
       jge       short M01_L38
       cmp       r8d,400
       jge       short M01_L36
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M01_L37
M01_L36:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FF9F7697120]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M01_L37:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF9F7285050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L39
M01_L38:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M01_L39:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rax,[rbp-40]
       mov       [rax+1C],ecx
       mov       rcx,rax
M01_L40:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M01_L41:
       mov       rdx,24928801338
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M01_L43
M01_L42:
       add       rsp,28
       ret
M01_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M01_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M01_L44
       call      qword ptr [7FF9F772E388]
       int       3
M01_L44:
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      00007FFA56D53270
       test      rax,rax
       je        short M01_L42
M01_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M01_L46
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F772E508]
       test      eax,eax
       jne       short M01_L42
       mov       rcx,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9F772E520]
       jmp       short M01_L42
M01_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L42
; Total bytes of code 1713
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrl()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,1
       mov       edx,19
       call      qword ptr [7FF9F77541C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7754B58]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,2525DC012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L08
       mov       rdi,[rcx+18]
M00_L00:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        near ptr M00_L14
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77541C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L13
       mov       edx,eax
       mov       rdi,[rdi+rdx*8+10]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L01
       mov       edx,ebp
       mov       ecx,r14d
       lea       rdx,[rdx+rcx+5]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L12
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       r8,r13
       mov       rdx,2E007700770077
       mov       [r8],rdx
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       lea       rcx,[r15+14]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       ecx,[rbp+4]
       movsxd    rcx,ecx
       lea       rcx,[r13+rcx*2]
       mov       word ptr [rcx],2E
       add       ebp,5
       movsxd    rcx,ebp
       lea       rcx,[r13+rcx*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L01:
       mov       rdx,rsi
       mov       rcx,292F2C209E8
       mov       r8,292F2C10658
       call      qword ptr [7FF9F7137828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       short M00_L03
M00_L02:
       mov       r8,rdi
       mov       rcx,292F2C209E8
       mov       rdx,292F2C10658
       call      qword ptr [7FF9F7137828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
M00_L03:
       test      r15,r15
       je        short M00_L04
       mov       esi,[r15+8]
       test      esi,esi
       je        short M00_L04
       lea       edx,[rsi+8]
       test      edx,edx
       jl        near ptr M00_L12
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       rdi,rax
       cmp       [rdi],dil
       lea       r8,[rdi+0C]
       vmovups   xmm0,[7FF9F71E6B60]
       vmovups   [r8],xmm0
       mov       r8d,esi
       add       r8,r8
       lea       rdx,[r15+0C]
       lea       rcx,[rdi+1C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L04:
       mov       rdi,292F2C209C0
M00_L05:
       call      qword ptr [7FF9F775DA40]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
       mov       rsi,rax
       cmp       dword ptr [rdi+8],0
       je        near ptr M00_L09
       test      rsi,rsi
       je        short M00_L06
       cmp       dword ptr [rsi+8],0
       je        short M00_L06
       mov       ebp,[rdi+8]
       mov       r14d,ebp
       add       r14d,[rsi+8]
       js        near ptr M00_L12
       mov       rcx,7FF9F76E23F8
       call      qword ptr [7FF9F76BE250]; System.Runtime.CompilerServices.TypeHandle.TypeHandleOf[[System.__Canon, System.Private.CoreLib]]()
       mov       rcx,rax
       movsxd    rdx,r14d
       call      00007FFA56DB9D30
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FF9F77D5890]; System.String.CopyStringContent(System.String, Int32, System.String)
       mov       rcx,r14
       mov       edx,ebp
       mov       r8,rsi
       call      qword ptr [7FF9F77D5890]; System.String.CopyStringContent(System.String, Int32, System.String)
       jmp       short M00_L07
M00_L06:
       mov       r14,rdi
M00_L07:
       mov       [rsp+20],r14
       mov       rcx,[rbx+60]
       lea       r8,[rsp+20]
       mov       rdx,7FF9F77B5188
       cmp       [rcx],ecx
       call      qword ptr [7FF9F775DAA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L08:
       call      qword ptr [7FF9F74B4090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L09:
       test      rsi,rsi
       je        short M00_L10
       cmp       dword ptr [rsi+8],0
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        short M00_L11
M00_L10:
       mov       r14,292F2C10008
       jmp       short M00_L07
M00_L11:
       mov       r14,rsi
       jmp       short M00_L07
M00_L12:
       call      qword ptr [7FF9F77D44C8]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 730
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F755FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77D4858]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74B4378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F775FE10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,13C2962F649A
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L13
M02_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M02_L25
       add       edi,1
       jo        near ptr M02_L25
       cmp       r15d,100
       jg        near ptr M02_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M02_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M02_L01:
       push      0
       push      0
       dec       r15
       jne       short M02_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M02_L02:
       test      ebx,ebx
       jl        near ptr M02_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M02_L25
       mov       r13,rax
       test      r13,r13
       je        short M02_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M02_L03:
       push      0
       push      0
       dec       r13
       jne       short M02_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M02_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M02_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F755FB28
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L06
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M02_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M02_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M02_L09
M02_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M02_L25
       cmp       edx,0FFFF
       ja        near ptr M02_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M02_L25
       cmp       ecx,ebx
       jge       short M02_L10
       jmp       short M02_L08
M02_L09:
       mov       r13,[rbp+10]
M02_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M02_L11:
       mov       r8,13C2962F649A
       cmp       [rbp+8],r8
       je        short M02_L12
       call      CORINFO_HELP_FAIL_FAST
M02_L12:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M02_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FF9F76BFAB0]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FF9F76BFAC8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FF9F77D5860]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,292F2C12288
       call      qword ptr [7FF9F735DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FF9F72A7198]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FF9F775FE10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2525DC01E48
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7762EA0]
       mov       [rbp+28],rax
       mov       rcx,2525DC00C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9F7400798]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M02_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M02_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FF9F7544BD0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M02_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M02_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M02_L20
M02_L19:
       call      qword ptr [7FF9F72A7198]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FF9F754C738]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M02_L24
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L23:
       cmp       r10d,r8d
       jae       short M02_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M02_L22
       cmp       edx,0FFFF
       ja        short M02_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M02_L22
M02_L24:
       cmp       r10d,r14d
       jl        short M02_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FF9F7131548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2525DC01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7762EA8]
       mov       rcx,2525DC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F74007A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FF9F77313C8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,2525DC01E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7762EA8]
       mov       rcx,2525DC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F74007A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       jbe       near ptr M03_L06
       cmp       r8,40
       jbe       short M03_L02
       cmp       r8,800
       ja        near ptr M03_L10
       cmp       r8,100
       jae       short M03_L05
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
       jbe       short M03_L03
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L04:
       vzeroupper
       ret
M03_L05:
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
M03_L06:
       test      r8b,18
       je        short M03_L07
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M03_L04
M03_L07:
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
M03_L08:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L04
M03_L09:
       cmp       rcx,rdx
       jne       short M03_L10
       cmp       [rdx],dl
       jmp       short M03_L04
M03_L10:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 316
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M04_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L02
       test      rsi,rsi
       je        near ptr M04_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M04_L01
       test      rdi,rdi
       je        near ptr M04_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M04_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M04_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFA3C4469D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M04_L00:
       mov       rdx,rsi
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L01:
       mov       rdx,rdi
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L02:
       mov       rdx,rdi
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L03:
       call      qword ptr [7FFA3C44A448]
       int       3
; Total bytes of code 336
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
; 		var sb = _stringBuilderPool.Get();
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var segmentCount = Random.Shared.Next(1, 10);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			for (var segmentIndex = 0; segmentIndex < segmentCount; segmentIndex++)
; 			     ^^^^^^^^^^^^^^^^^^^^
; 				var segmentLength = Random.Shared.Next(1, 26);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				_ = sb.Append('/');
; 				^^^^^^^^^^^^^^^^^^^
; 				for (var charIndex = 0; charIndex < segmentLength; charIndex++)
; 				     ^^^^^^^^^^^^^^^^^
; 					_ = sb.Append((char)('a' + Random.Shared.Next(26)));
; 					^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			_ = sb.Append('/');
; 			^^^^^^^^^^^^^^^^^^^
; 			return sb.ToString();
; 			^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			_stringBuilderPool.Return(sb.Clear());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-38],rax
       mov       rcx,2525DC01338
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-38],rcx
       cmp       qword ptr [rbp-38],0
       je        near ptr M05_L30
       lea       rcx,[rbx+20]
       mov       r8,[rbp-38]
       test      rcx,rcx
       je        near ptr M05_L29
       xor       edx,edx
       call      00007FFA56D53270
       cmp       rax,[rbp-38]
       jne       near ptr M05_L30
M05_L00:
       mov       rdx,[rbp-38]
M05_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-40],rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M05_L17
       mov       rcx,[rcx+240]
       mov       rbx,[rcx+40]
       test      rbx,rbx
       je        near ptr M05_L17
M05_L02:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M05_L03
       call      qword ptr [7FF9F7754030]; System.Random+ThreadSafeRandom.Create()
M05_L03:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       lea       rsi,[rcx+rcx*8]
       mov       ecx,esi
       cmp       ecx,9
       jb        near ptr M05_L18
M05_L04:
       shr       rsi,20
       inc       esi
       xor       edi,edi
       cmp       edi,esi
       jl        near ptr M05_L13
M05_L05:
       mov       rdx,[rbp-40]
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       cmp       [r8+8],eax
       jbe       near ptr M05_L27
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],2F
       inc       ecx
       mov       [rdx+18],ecx
M05_L06:
       mov       rcx,rdx
       call      qword ptr [7FF9F7322100]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       near ptr M05_L28
M05_L07:
       call      qword ptr [7FF9F7754030]; System.Random+ThreadSafeRandom.Create()
       mov       rdx,[rbp-40]
M05_L08:
       mov       rcx,[rax+8]
       mov       r8,[rax+10]
       mov       r10,[rax+18]
       mov       r9,[rax+20]
       mov       r11,r8
       shl       r11,11
       xor       r10,rcx
       xor       r9,r8
       lea       r13,[r8+r8*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r8,r10
       xor       rcx,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rax+8],rcx
       mov       [rax+10],r8
       mov       [rax+18],r10
       mov       [rax+20],r9
       shr       r13,20
       mov       ecx,r13d
       imul      rcx,1A
       mov       r8d,ecx
       cmp       r8d,1A
       jb        near ptr M05_L23
M05_L09:
       shr       rcx,20
       add       ecx,61
       jo        near ptr M05_L24
       cmp       ecx,0FFFF
       ja        near ptr M05_L24
       mov       eax,ecx
       mov       ecx,[rdx+18]
       mov       r8d,ecx
       mov       r10,[rdx+8]
       mov       r9d,[r10+8]
       cmp       r9d,r8d
       jbe       near ptr M05_L26
       mov       r8d,r8d
       mov       [r10+r8*2+10],ax
       inc       ecx
       mov       [rdx+18],ecx
M05_L10:
       add       r15d,1
       jo        near ptr M05_L24
       cmp       r15d,r14d
       jge       short M05_L12
M05_L11:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M05_L08
       jmp       near ptr M05_L07
M05_L12:
       add       edi,1
       jo        near ptr M05_L24
       cmp       edi,esi
       jge       near ptr M05_L05
M05_L13:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M05_L14
       call      qword ptr [7FF9F7754030]; System.Random+ThreadSafeRandom.Create()
M05_L14:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       imul      r14,rcx,19
       mov       ecx,r14d
       cmp       ecx,19
       jb        near ptr M05_L20
M05_L15:
       shr       r14,20
       inc       r14d
       mov       rdx,[rbp-40]
       mov       ecx,[rdx+18]
       mov       eax,ecx
       mov       r8,[rdx+8]
       mov       r10d,[r8+8]
       cmp       r10d,eax
       jbe       near ptr M05_L22
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],2F
       inc       ecx
       mov       [rdx+18],ecx
M05_L16:
       xor       r15d,r15d
       cmp       r15d,r14d
       jl        near ptr M05_L11
       jmp       near ptr M05_L12
M05_L17:
       mov       ecx,8
       call      qword ptr [7FF9F775FF30]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       rbx,rax
       jmp       near ptr M05_L02
M05_L18:
       cmp       ecx,4
       jae       near ptr M05_L04
M05_L19:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       lea       rsi,[rcx+rcx*8]
       mov       ecx,esi
       cmp       ecx,4
       jb        short M05_L19
       jmp       near ptr M05_L04
M05_L20:
       cmp       ecx,15
       jae       near ptr M05_L15
M05_L21:
       mov       rcx,[rax+8]
       mov       rdx,[rax+10]
       mov       r8,[rax+18]
       mov       r10,[rax+20]
       mov       r9,rdx
       shl       r9,11
       xor       r8,rcx
       xor       r10,rdx
       lea       r11,[rdx+rdx*4]
       rol       r11,7
       lea       r11,[r11+r11*8]
       xor       rdx,r8
       xor       rcx,r10
       xor       r8,r9
       rol       r10,2D
       mov       [rax+8],rcx
       mov       [rax+10],rdx
       mov       [rax+18],r8
       mov       [rax+20],r10
       shr       r11,20
       mov       ecx,r11d
       imul      r14,rcx,19
       mov       ecx,r14d
       cmp       ecx,15
       jb        short M05_L21
       jmp       near ptr M05_L15
M05_L22:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FF9F72AF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M05_L16
M05_L23:
       cmp       r8d,16
       jb        short M05_L25
       jmp       near ptr M05_L09
M05_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
M05_L25:
       mov       rcx,[rax+8]
       mov       r8,[rax+10]
       mov       r10,[rax+18]
       mov       r9,[rax+20]
       mov       r11,r8
       shl       r11,11
       xor       r10,rcx
       xor       r9,r8
       lea       r13,[r8+r8*4]
       rol       r13,7
       lea       r13,[r13+r13*8]
       xor       r8,r10
       xor       rcx,r9
       xor       r10,r11
       rol       r9,2D
       mov       [rax+8],rcx
       mov       [rax+10],r8
       mov       [rax+18],r10
       mov       [rax+20],r9
       shr       r13,20
       mov       ecx,r13d
       imul      rcx,1A
       mov       r8d,ecx
       jmp       short M05_L23
M05_L26:
       mov       rcx,rdx
       mov       edx,eax
       call      qword ptr [7FF9F72AF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M05_L10
M05_L27:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FF9F72AF3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M05_L06
M05_L28:
       call      M05_L32
       nop
       mov       rax,[rbp-48]
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M05_L29:
       call      qword ptr [7FF9F77D44B0]
       int       3
M05_L30:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7755230]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M05_L31
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M05_L00
M05_L31:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rdx,rax
       jmp       near ptr M05_L01
M05_L32:
       sub       rsp,28
       mov       rcx,[rbp-40]
       cmp       dword ptr [rcx+20],0
       jge       short M05_L33
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF9F7074000
       call      qword ptr [7FF9F73577B0]
       mov       rsi,rax
       call      qword ptr [7FF9F77D4570]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9F735DA40]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L33:
       cmp       qword ptr [rcx+10],0
       jne       short M05_L34
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M05_L41
M05_L34:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M05_L35
       xor       edx,edx
       call      qword ptr [7FF9F77D4870]
       mov       rcx,[rbp-40]
       jmp       near ptr M05_L41
M05_L35:
       xor       edx,edx
       call      qword ptr [7FF9F77D4888]
       mov       rbx,rax
       mov       rcx,[rbp-40]
       cmp       rbx,rcx
       je        near ptr M05_L40
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
       jge       short M05_L38
       cmp       r8d,400
       jge       short M05_L36
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M05_L37
M05_L36:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FF9F76BEE08]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M05_L37:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FF9F72A5050]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M05_L39
M05_L38:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M05_L39:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rax,[rbp-40]
       mov       [rax+1C],ecx
       mov       rcx,rax
M05_L40:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M05_L41:
       mov       rdx,2525DC01338
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M05_L43
M05_L42:
       add       rsp,28
       ret
M05_L43:
       cmp       qword ptr [rbx+20],0
       jne       short M05_L45
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M05_L44
       call      qword ptr [7FF9F77D44B0]
       int       3
M05_L44:
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      00007FFA56D53270
       test      rax,rax
       je        short M05_L42
M05_L45:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M05_L46
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77D4930]
       test      eax,eax
       jne       short M05_L42
       mov       rcx,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9F77D4948]
       jmp       short M05_L42
M05_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M05_L42
; Total bytes of code 1724
```
```assembly
; System.Runtime.CompilerServices.TypeHandle.TypeHandleOf[[System.__Canon, System.Private.CoreLib]]()
       push      rax
       mov       [rsp],rcx
       mov       rax,[rcx+18]
       mov       rax,[rax]
       add       rsp,8
       ret
; Total bytes of code 17
```
```assembly
; System.String.CopyStringContent(System.String, Int32, System.String)
       sub       rsp,28
       cmp       [rcx],cl
       movsxd    rdx,edx
       lea       rcx,[rcx+rdx*2+0C]
       lea       rdx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8,r8
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       ret
; Total bytes of code 37
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
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M09_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M09_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M09_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M09_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M09_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M09_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M09_L03:
       cmp       ecx,8
       ja        short M09_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M09_L00]
       add       rdx,r8
       jmp       rdx
M09_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M09_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M09_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M09_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M09_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M09_L01
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M09_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M09_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlFragment()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       byte ptr [rsp+30],1
       mov       dword ptr [rsp+34],1
       mov       ecx,1
       mov       edx,19
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7724B58]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       test      rsi,rsi
       je        short M00_L00
       mov       edi,[rsi+8]
       test      edi,edi
       je        short M00_L00
       lea       edx,[rdi+1]
       test      edx,edx
       jl        short M00_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       r8,[rbp+0C]
       mov       word ptr [r8],2F
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       lea       rcx,[rbp+0E]
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L00:
       mov       rbp,2351DFD5540
M00_L01:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FF9F77A4348]
       int       3
; Total bytes of code 218
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F752FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77A46A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7484378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F772FCC0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,0AF0C9BAFAF98
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L13
M02_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M02_L25
       add       edi,1
       jo        near ptr M02_L25
       cmp       r15d,100
       jg        near ptr M02_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M02_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M02_L01:
       push      0
       push      0
       dec       r15
       jne       short M02_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M02_L02:
       test      ebx,ebx
       jl        near ptr M02_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M02_L25
       mov       r13,rax
       test      r13,r13
       je        short M02_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M02_L03:
       push      0
       push      0
       dec       r13
       jne       short M02_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M02_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M02_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F752FB28
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L06
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M02_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M02_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M02_L09
M02_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M02_L25
       cmp       edx,0FFFF
       ja        near ptr M02_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M02_L25
       cmp       ecx,ebx
       jge       short M02_L10
       jmp       short M02_L08
M02_L09:
       mov       r13,[rbp+10]
M02_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M02_L11:
       mov       r8,0AF0C9BAFAF98
       cmp       [rbp+8],r8
       je        short M02_L12
       call      CORINFO_HELP_FAIL_FAST
M02_L12:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M02_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FF9F768FAB0]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FF9F768FAC8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FF9F77A55D8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2351DFD2288
       call      qword ptr [7FF9F732DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FF9F7277198]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FF9F772FCC0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F489001E48
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732F70]
       mov       [rbp+28],rax
       mov       rcx,1F489000C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9F73D0798]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M02_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M02_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FF9F7514BD0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M02_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M02_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M02_L20
M02_L19:
       call      qword ptr [7FF9F7277198]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FF9F751C738]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M02_L24
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L23:
       cmp       r10d,r8d
       jae       short M02_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M02_L22
       cmp       edx,0FFFF
       ja        short M02_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M02_L22
M02_L24:
       cmp       r10d,r14d
       jl        short M02_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FF9F7101548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1F489001E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732F78]
       mov       rcx,1F489000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FF9F7701410],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,1F489001E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732F78]
       mov       rcx,1F489000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       ja        short M03_L02
       test      r8b,18
       jne       short M03_L01
       test      r8b,4
       jne       short M03_L00
       test      r8,r8
       je        short M03_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L05
M03_L00:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L05
M03_L01:
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rcx,[rax-8]
       mov       [r10-8],rcx
       jmp       short M03_L05
M03_L02:
       cmp       r8,40
       ja        short M03_L07
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L04
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L05:
       vzeroupper
       ret
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L04
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L03
       jmp       near ptr M03_L04
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L05
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 317
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostName()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,1
       mov       edx,19
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7724B58]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,257220012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L06
       mov       rdi,[rcx+18]
M00_L00:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        near ptr M00_L09
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F77241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L08
       mov       edx,eax
       mov       rdi,[rdi+rdx*8+10]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L01
       mov       edx,ebp
       mov       ecx,r14d
       lea       rdx,[rdx+rcx+5]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L07
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       r8,r13
       mov       rdx,2E007700770077
       mov       [r8],rdx
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       lea       rcx,[r15+14]
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       ecx,[rbp+4]
       movsxd    rcx,ecx
       lea       rcx,[r13+rcx*2]
       mov       word ptr [rcx],2E
       add       ebp,5
       movsxd    rcx,ebp
       lea       rcx,[r13+rcx*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L01:
       mov       rdx,rsi
       mov       rcx,297B6E409E8
       mov       r8,297B6E30658
       call      qword ptr [7FF9F7107828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       short M00_L03
M00_L02:
       mov       r8,rdi
       mov       rcx,297B6E409E8
       mov       rdx,297B6E30658
       call      qword ptr [7FF9F7107828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
M00_L03:
       test      r15,r15
       je        short M00_L04
       mov       esi,[r15+8]
       test      esi,esi
       je        short M00_L04
       lea       edx,[rsi+8]
       test      edx,edx
       jl        near ptr M00_L07
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       rdi,rax
       cmp       [rdi],dil
       lea       r8,[rdi+0C]
       vmovups   xmm0,[7FF9F71B5190]
       vmovups   [r8],xmm0
       mov       r8d,esi
       add       r8,r8
       lea       rdx,[r15+0C]
       lea       rcx,[rdi+1C]
       call      qword ptr [7FF9F7105818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L04:
       mov       rdi,297B6E409C0
M00_L05:
       mov       [rsp+20],rdi
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
M00_L06:
       call      qword ptr [7FF9F7484090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FF9F77A4480]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 581
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F752FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77A48B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F7484378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F772FDC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,0B1E568EECAFE
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L13
M02_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M02_L25
       add       edi,1
       jo        near ptr M02_L25
       cmp       r15d,100
       jg        near ptr M02_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M02_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M02_L01:
       push      0
       push      0
       dec       r15
       jne       short M02_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M02_L02:
       test      ebx,ebx
       jl        near ptr M02_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M02_L25
       mov       r13,rax
       test      r13,r13
       je        short M02_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M02_L03:
       push      0
       push      0
       dec       r13
       jne       short M02_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M02_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M02_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F752FB28
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L06
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M02_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M02_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M02_L09
M02_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M02_L25
       cmp       edx,0FFFF
       ja        near ptr M02_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M02_L25
       cmp       ecx,ebx
       jge       short M02_L10
       jmp       short M02_L08
M02_L09:
       mov       r13,[rbp+10]
M02_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M02_L11:
       mov       r8,0B1E568EECAFE
       cmp       [rbp+8],r8
       je        short M02_L12
       call      CORINFO_HELP_FAIL_FAST
M02_L12:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M02_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FF9F768FAB0]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FF9F768FAC8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FF9F77A56C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,297B6E32288
       call      qword ptr [7FF9F732DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FF9F7277198]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FF9F772FDC8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25722001E48
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732EA0]
       mov       [rbp+28],rax
       mov       rcx,25722000C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9F73D0798]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M02_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M02_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FF9F7514BD0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M02_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M02_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M02_L20
M02_L19:
       call      qword ptr [7FF9F7277198]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FF9F751C738]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M02_L24
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L23:
       cmp       r10d,r8d
       jae       short M02_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M02_L22
       cmp       edx,0FFFF
       ja        short M02_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M02_L22
M02_L24:
       cmp       r10d,r14d
       jl        short M02_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FF9F7101548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,25722001E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732EA8]
       mov       rcx,25722000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FF9F77013C8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7105728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,25722001E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7732EA8]
       mov       rcx,25722000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F73D07A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
```
```assembly
; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rcx
       sub       rax,rdx
       cmp       rax,r8
       jb        near ptr M03_L11
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M03_L11
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       jne       short M03_L02
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L02:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L06
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L09
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L10
M03_L07:
       mov       r9,r8
       shr       r9,6
M03_L08:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L08
       and       r8,3F
       cmp       r8,10
       ja        short M03_L04
       jmp       short M03_L05
M03_L09:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L10:
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
       jmp       short M03_L07
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 318
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M04_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L02
       test      rsi,rsi
       je        near ptr M04_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M04_L01
       test      rdi,rdi
       je        near ptr M04_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M04_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M04_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFA3C4469D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M04_L00:
       mov       rdx,rsi
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L01:
       mov       rdx,rdi
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L02:
       mov       rdx,rdi
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L03:
       call      qword ptr [7FFA3C44A448]
       int       3
; Total bytes of code 336
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M05_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M05_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M05_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M05_L03:
       cmp       ecx,8
       ja        short M05_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M05_L00]
       add       rdx,r8
       jmp       rdx
M05_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M05_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M05_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoProtocol()
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+20],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       byte ptr [rsp+28],1
       mov       dword ptr [rsp+2C],1
       mov       ecx,1
       mov       edx,19
       call      qword ptr [7FF9F76BFCF0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FF9F7754690]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,1C0788012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L04
       mov       rdi,[rcx+18]
M00_L00:
       mov       edx,[rdi+8]
       sub       edx,1
       jo        near ptr M00_L07
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F76BFCF0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L06
       mov       edx,eax
       mov       rdi,[rdi+rdx*8+10]
       test      rsi,rsi
       je        near ptr M00_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L02
       test      rdi,rdi
       je        near ptr M00_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L01
       mov       edx,ebp
       mov       ecx,r14d
       lea       rdx,[rdx+rcx+5]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L05
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       r8,r13
       mov       rdx,2E007700770077
       mov       [r8],rdx
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       lea       rcx,[r15+14]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       ecx,[rbp+4]
       movsxd    rcx,ecx
       lea       rcx,[r13+rcx*2]
       mov       word ptr [rcx],2E
       add       ebp,5
       movsxd    rcx,ebp
       lea       rcx,[r13+rcx*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FF9F7135818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L01:
       mov       rdx,rsi
       mov       rcx,2010D5E09C0
       mov       r8,2010D5D0658
       call      qword ptr [7FF9F7137828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       short M00_L03
M00_L02:
       mov       r8,rdi
       mov       rcx,2010D5E09C0
       mov       rdx,2010D5D0658
       call      qword ptr [7FF9F7137828]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
M00_L03:
       mov       [rsp+20],r15
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
       call      qword ptr [7FF9F74B4090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L05:
       call      qword ptr [7FF9F77E4828]
       int       3
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 484
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F755FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77E4B40]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74B4378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F77E4150]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
; 		length = length.ArgumentInRange(min: 1, defaultValue: 1);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var range = maxCharacter - minCharacter + 1;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		if (length <= stackAllocThreshold)
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<byte> randomBytes = stackalloc byte[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Span<char> chars = stackalloc char[length];
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(randomBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(chars, randomBytes, minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedBytes = ArrayPool<byte>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var rentedChars = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			RandomNumberGenerator.Fill(rentedBytes.AsSpan(0, length));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			FillWordChars(rentedChars.AsSpan(0, length), rentedBytes.AsSpan(0, length), minCharacter, range);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return new string(rentedChars, 0, length);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 	}
; 	^
; 			ArrayPool<byte>.Shared.Return(rentedBytes);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			ArrayPool<char>.Shared.Return(rentedChars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		}
; 		^
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
       lea       rbp,[rsp+20]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+30],ymm4
       vmovdqu   ymmword ptr [rbp+50],ymm4
       vmovdqu   ymmword ptr [rbp+70],ymm4
       vmovdqa   xmmword ptr [rbp+90],xmm4
       xor       eax,eax
       mov       [rbp+0A0],rax
       mov       rax,0BF3BD5425689
       mov       [rbp+8],rax
       mov       ebx,ecx
       mov       esi,edx
       mov       edi,r8d
       lea       rcx,[rbp+50]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       r14,rax
       mov       rcx,rsp
       mov       [rbp+68],rcx
       mov       rcx,rbp
       mov       [rbp+78],rcx
       mov       byte ptr [rbp+0A0],1
       mov       dword ptr [rbp+0A4],1
       test      ebx,ebx
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L13
M02_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M02_L25
       add       edi,1
       jo        near ptr M02_L25
       cmp       r15d,100
       jg        near ptr M02_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M02_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M02_L01:
       push      0
       push      0
       dec       r15
       jne       short M02_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M02_L02:
       test      ebx,ebx
       jl        near ptr M02_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M02_L25
       mov       r13,rax
       test      r13,r13
       je        short M02_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M02_L03:
       push      0
       push      0
       dec       r13
       jne       short M02_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M02_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M02_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F755FB28
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFA91B83670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M02_L06
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M02_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M02_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M02_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M02_L09
M02_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M02_L25
       cmp       edx,0FFFF
       ja        near ptr M02_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M02_L25
       cmp       ecx,ebx
       jge       short M02_L10
       jmp       short M02_L08
M02_L09:
       mov       r13,[rbp+10]
M02_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M02_L11:
       mov       r8,0BF3BD5425689
       cmp       [rbp+8],r8
       je        short M02_L12
       call      CORINFO_HELP_FAIL_FAST
M02_L12:
       nop
       lea       rsp,[rbp+0A8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M02_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M02_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FF9F76BF5E8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FF9F76BF600]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FF9F77E5A70]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2010D5D2288
       call      qword ptr [7FF9F735DA40]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FF9F72A7198]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FF9F77E4150]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C078801E48
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742610]
       mov       [rbp+28],rax
       mov       rcx,1C078800C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FF9F7400798]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M02_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M02_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FF9F7544BD0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M02_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M02_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M02_L20
M02_L19:
       call      qword ptr [7FF9F72A7198]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FF9F754C738]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M02_L24
M02_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M02_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M02_L23:
       cmp       r10d,r8d
       jae       short M02_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M02_L22
       cmp       edx,0FFFF
       ja        short M02_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M02_L22
M02_L24:
       cmp       r10d,r14d
       jl        short M02_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FF9F7131548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C078801E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742618]
       mov       rcx,1C078800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F74007A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FF9F77423B0],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FF9F7135728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,1C078801E48
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FF9F7742618]
       mov       rcx,1C078800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FF9F74007A0]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       ja        short M03_L03
       test      r8b,18
       je        short M03_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       test      r8b,4
       jne       short M03_L02
       test      r8,r8
       je        short M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M03_L00
M03_L02:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M03_L00
M03_L03:
       cmp       r8,40
       ja        short M03_L07
M03_L04:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L05
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       ja        short M03_L06
M03_L05:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L06:
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L05
M03_L07:
       cmp       r8,800
       ja        short M03_L11
       cmp       r8,100
       jb        short M03_L08
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
M03_L08:
       mov       r9,r8
       shr       r9,6
M03_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M03_L04
       jmp       near ptr M03_L05
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71366E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.String.Concat(System.String, System.String, System.String)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,r8
       test      rbx,rbx
       je        near ptr M04_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L02
       test      rsi,rsi
       je        near ptr M04_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M04_L01
       test      rdi,rdi
       je        near ptr M04_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M04_L00
       mov       r13d,ebp
       mov       ecx,r14d
       add       rcx,r13
       mov       eax,r15d
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M04_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFA3C4469D8]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFA3C4488E8]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r12
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
M04_L00:
       mov       rdx,rsi
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L01:
       mov       rdx,rdi
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L02:
       mov       rdx,rdi
       mov       rcx,rsi
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [rax]
M04_L03:
       call      qword ptr [7FFA3C44A448]
       int       3
; Total bytes of code 336
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M05_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M05_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M05_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M05_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M05_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M05_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M05_L03:
       cmp       ecx,8
       ja        short M05_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M05_L00]
       add       rdx,r8
       jmp       rdx
M05_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M05_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M05_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,192558012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M00_L01
       mov       rsi,[rcx+18]
M00_L00:
       mov       edi,[rsi+8]
       mov       edx,edi
       sub       edx,1
       jo        short M00_L03
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FF9F7744180]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+60]
       mov       rdx,[rsp+28]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      qword ptr [7FF9F74A4090]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 140
```
```assembly
; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+0A0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       ebx,ecx
       mov       esi,edx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rdi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
       cmp       ebx,esi
       jge       near ptr M01_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M01_L05
       mov       r14d,esi
       shr       r14d,1
       or        r14d,esi
       mov       edx,r14d
       shr       edx,2
       or        r14d,edx
       mov       edx,r14d
       shr       edx,4
       or        r14d,edx
       mov       edx,r14d
       shr       edx,8
       or        r14d,edx
       mov       edx,r14d
       shr       edx,10
       or        r14d,edx
       xor       edx,edx
       mov       [rbp-3C],edx
M01_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FF9F754FB28
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFA91B83670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFA570739A0],0
       je        short M01_L02
       call      qword ptr [7FFA57061648]; CORINFO_HELP_STOP_FOR_GC
M01_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M01_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M01_L00
       add       eax,ebx
M01_L03:
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
M01_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9F77C4678]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9F74A4378]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FF9F774FC90]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rbx,rcx
M02_L00:
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        short M02_L01
       mov       ecx,[rsi+10]
       cmp       ecx,8
       jne       short M02_L03
       mov       rcx,rbx
       mov       rdx,rsi
       xor       r8d,r8d
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
M02_L01:
       cmp       qword ptr [rbx+8],0
       jne       short M02_L02
       mov       rax,[rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M02_L02:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [rax]
M02_L03:
       cmp       ecx,8
       ja        short M02_L04
       mov       ecx,ecx
       lea       rdx,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       edx,[rdx+rcx*4]
       lea       r8,[M02_L00]
       add       rdx,r8
       jmp       rdx
M02_L04:
       mov       rcx,[rsi+8]
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C44FC50]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C4591A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFA3C436838]
       mov       rcx,rax
       call      qword ptr [7FFA3C43DE88]
       mov       rcx,rax
       call      qword ptr [7FFA3C45EFF0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFA3C4591C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFA3C4591B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.PersonGetAge()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdx,[rbx+48]
       mov       rcx,7FF9F77A4060
       call      qword ptr [7FF9F774D920]; DotNetTips.Spargine.Tester.Extensions.PersonExtensions.get_Age[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Models.Common.IPerson`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rbx+60]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FF9F774DA10]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Tester.Extensions.PersonExtensions.get_Age[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Models.Common.IPerson`2<System.__Canon,System.__Canon>)
; 				return person.BornOn is { } bornOn ? DateTimeOffset.UtcNow - bornOn : TimeSpan.Zero;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       xor       eax,eax
       mov       [rsp+28],rax
       mov       [rsp+48],rcx
       mov       rbx,rdx
       mov       rdx,[rcx+18]
       mov       r11,[rdx+18]
       test      r11,r11
       je        near ptr M01_L04
M01_L00:
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rbx],rdx
       jne       near ptr M01_L05
       add       rbx,40
       movzx     esi,byte ptr [rbx]
       mov       rbx,[rbx+10]
M01_L01:
       test      esi,esi
       je        near ptr M01_L07
       lea       rcx,[rsp+28]
       mov       rax,7FFA942D5380
       call      rax
       mov       rsi,[rsp+28]
       mov       rax,1EFD3001B00
       mov       rdi,[rax]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FFA570739A0],0
       jne       short M01_L06
M01_L02:
       mov       eax,0B2D05E00
       cmp       rsi,rax
       jae       short M01_L08
       add       rsi,[rdi+10]
M01_L03:
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,rsi
       sub       rax,rbx
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L04:
       mov       rdx,7FF9F7793298
       call      qword ptr [7FF9F7347B70]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
       mov       r11,rax
       jmp       near ptr M01_L00
M01_L05:
       lea       rdx,[rsp+30]
       mov       rcx,rbx
       call      qword ptr [r11]
       movzx     esi,byte ptr [rsp+30]
       mov       rbx,[rsp+40]
       jmp       near ptr M01_L01
M01_L06:
       call      CORINFO_HELP_POLL_GC
       jmp       short M01_L02
M01_L07:
       xor       eax,eax
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      qword ptr [7FF9F7636B50]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rsi,rax
       jmp       short M01_L03
; Total bytes of code 243
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.8 (10.0.8, 10.0.826.23019), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.PersonGetFullName()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0D8
       xor       eax,eax
       mov       [rsp+58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+60],ymm4
       vmovdqu   ymmword ptr [rsp+80],ymm4
       vmovdqu   ymmword ptr [rsp+0A0],ymm4
       vmovdqa   xmmword ptr [rsp+0C0],xmm4
       mov       rbx,rcx
       mov       rsi,[rbx+48]
       mov       rcx,10FCA800C88
       mov       rdi,[rcx]
       mov       rbp,rdi
       mov       rcx,10FCA800C90
       mov       r14,[rcx]
       mov       r15,r14
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L09
       mov       rcx,[rcx+240]
       mov       r13,[rcx+18]
       test      r13,r13
       je        near ptr M00_L09
M00_L00:
       mov       rcx,[r13+10]
       test      rcx,rcx
       je        near ptr M00_L11
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L11
       mov       r12,[rcx+50]
       test      r12,r12
       je        near ptr M00_L11
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [r15+9D],0
       jne       near ptr M00_L10
M00_L01:
       mov       [rsp+0B0],r12
       lea       r8,[r12+10]
       mov       edx,[r12+8]
       mov       [rsp+0C0],r8
       mov       [rsp+0C8],edx
       xor       r8d,r8d
       mov       [rsp+0B8],r8d
       mov       byte ptr [rsp+0BC],0
       mov       rbp,[rsi+20]
       cmp       byte ptr [rsp+0BC],0
       jne       near ptr M00_L07
       test      rbp,rbp
       je        near ptr M00_L07
       mov       r8d,[rsp+0B8]
       mov       edx,[rsp+0C8]
       cmp       r8d,edx
       ja        near ptr M00_L25
       mov       rcx,[rsp+0C0]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       sub       edx,r8d
       cmp       [rbp+8],edx
       ja        near ptr M00_L07
       mov       r8d,[rbp+8]
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0B8]
       add       ecx,[rbp+8]
       mov       [rsp+0B8],ecx
M00_L02:
       lea       rcx,[rsp+0A8]
       mov       edx,20
       call      qword ptr [7FF9F7737870]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       rsi,[rsi+30]
       cmp       byte ptr [rsp+0BC],0
       jne       near ptr M00_L08
       test      rsi,rsi
       je        near ptr M00_L08
       mov       r8d,[rsp+0B8]
       mov       edx,[rsp+0C8]
       cmp       r8d,edx
       ja        near ptr M00_L25
       mov       rcx,[rsp+0C0]
       mov       eax,r8d
       lea       rcx,[rcx+rax*2]
       sub       edx,r8d
       cmp       [rsi+8],edx
       ja        near ptr M00_L08
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+0B8]
       add       ecx,[rsi+8]
       mov       [rsp+0B8],ecx
M00_L03:
       mov       ecx,[rsp+0B8]
       cmp       ecx,[rsp+0C8]
       ja        near ptr M00_L25
       mov       rax,[rsp+0C0]
       mov       [rsp+58],rax
       mov       [rsp+60],ecx
       lea       rcx,[rsp+58]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rbp,[rsp+0B0]
       xor       ecx,ecx
       mov       [rsp+0B0],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+0C0],xmm0
       mov       [rsp+0B8],ecx
       test      rbp,rbp
       je        near ptr M00_L06
       mov       ecx,[rbp+8]
       dec       ecx
       or        ecx,0F
       xor       r15d,r15d
       lzcnt     r15d,ecx
       xor       r15d,1F
       add       r15d,0FFFFFFFD
       mov       rax,[r13+10]
       test      rax,rax
       je        near ptr M00_L26
M00_L04:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [rax+8],r15d
       jbe       short M00_L05
       mov       r13d,1
       mov       ecx,10
       shlx      ecx,ecx,r15d
       cmp       [rbp+8],ecx
       jne       near ptr M00_L27
       mov       ecx,r15d
       shl       rcx,4
       lea       rax,[rax+rcx+10]
       mov       [rsp+40],rax
       mov       r8,[rax]
       mov       [rsp+38],r8
       mov       rcx,rax
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       rdx,[rsp+40]
       mov       [rdx+8],ecx
       cmp       qword ptr [rsp+38],0
       jne       near ptr M00_L28
M00_L05:
       cmp       byte ptr [r14+9D],0
       jne       near ptr M00_L36
M00_L06:
       mov       [rsp+68],rsi
       mov       rcx,[rbx+60]
       lea       r8,[rsp+68]
       mov       rdx,7FF9F77957E8
       cmp       [rcx],ecx
       call      qword ptr [7FF9F773DAD0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,0D8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M00_L07:
       lea       rcx,[rsp+0A8]
       mov       rdx,rbp
       call      qword ptr [7FF9F77B4420]
       jmp       near ptr M00_L02
M00_L08:
       lea       rcx,[rsp+0A8]
       mov       rdx,rsi
       call      qword ptr [7FF9F77B4420]
       jmp       near ptr M00_L03
M00_L09:
       mov       ecx,3
       call      qword ptr [7FF9F773FEB8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       mov       r13,rax
       jmp       near ptr M00_L00
M00_L10:
       mov       rcx,r12
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+98],eax
       mov       edx,[r12+8]
       mov       [rsp+94],edx
       mov       rcx,rbp
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rsp+98]
       mov       r8d,[rsp+94]
       mov       rcx,r15
       call      qword ptr [7FF9F77B4540]
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,[rbp+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L23
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L22
       mov       r12,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FF9F7115740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FF9F705B17C],0
       je        short M00_L12
       call      qword ptr [7FF9F77B4558]
       mov       edx,eax
       mov       [rsp+88],edx
       jmp       short M00_L14
M00_L12:
       mov       ecx,9
       call      qword ptr [7FF9F77B4570]
       mov       eax,[rax+10]
       mov       [rsp+84],eax
       mov       ecx,9
       call      qword ptr [7FF9F77B4570]
       mov       edx,[rsp+84]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M00_L13
       call      qword ptr [7FF9F77B4588]
       mov       edx,eax
       mov       [rsp+88],edx
       jmp       short M00_L14
M00_L13:
       sar       edx,10
       mov       [rsp+88],edx
M00_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7115740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+88]
       xor       edx,edx
       div       dword ptr [7FF9F705B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M00_L18
M00_L15:
       cmp       eax,[r12+8]
       jae       near ptr M00_L39
       mov       [rsp+90],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rsp+48],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rsp+50],r10
       mov       rcx,r8
       call      qword ptr [7FF9F762DFF8]; System.Threading.Monitor.Enter(System.Object)
       mov       r8,[rsp+48]
       mov       rcx,[r8+8]
       mov       eax,[r8+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L16
       mov       edx,eax
       mov       r10,[rcx+rdx*8+10]
       mov       [rsp+50],r10
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [r8+10],eax
M00_L16:
       mov       rcx,r8
       call      qword ptr [7FF9F7116820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rsp+50]
       test      rcx,rcx
       jne       short M00_L19
       mov       eax,[rsp+90]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M00_L17
       xor       ecx,ecx
M00_L17:
       mov       edx,[rsp+8C]
       inc       edx
       mov       eax,ecx
M00_L18:
       mov       [rsp+8C],edx
       cmp       [r12+8],edx
       jg        near ptr M00_L15
       jmp       short M00_L20
M00_L19:
       mov       r12,rcx
       jmp       short M00_L21
M00_L20:
       xor       r12d,r12d
M00_L21:
       test      r12,r12
       je        short M00_L22
       cmp       byte ptr [r15+9D],0
       je        near ptr M00_L01
       mov       rcx,r12
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A0],eax
       mov       edx,[r12+8]
       mov       [rsp+9C],edx
       mov       rcx,rbp
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rsp+0A0]
       mov       r8d,[rsp+9C]
       mov       rcx,r15
       call      qword ptr [7FF9F77B4540]
       jmp       near ptr M00_L01
M00_L22:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       cmp       byte ptr [r15+9D],0
       je        near ptr M00_L01
       jmp       short M00_L24
M00_L23:
       mov       ecx,100
       mov       rdx,1505F716F28
       call      qword ptr [7FF9F733DA10]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L22
M00_L24:
       mov       rcx,r12
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+0A4],eax
       mov       rcx,rbp
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rsp+0A4]
       mov       r8d,100
       mov       rcx,r15
       call      qword ptr [7FF9F77B4540]
       mov       rcx,rbp
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbp+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r15
       mov       edx,[rsp+0A4]
       mov       r8d,100
       call      qword ptr [7FF9F77B45A0]
       jmp       near ptr M00_L01
M00_L25:
       call      qword ptr [7FF9F7287198]
       int       3
M00_L26:
       mov       rcx,rdi
       call      qword ptr [7FF9F733CEA0]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M00_L04
M00_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       call      qword ptr [7FF9F77B4648]
       mov       rbp,rax
       mov       ecx,29B
       mov       rdx,7FF9F7054000
       call      qword ptr [7FF9F73377B0]
       mov       r8,rax
       mov       rdx,rbp
       mov       rcx,r14
       call      qword ptr [7FF9F7496268]
       mov       rcx,r14
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       mov       rcx,[rdi+10]
       cmp       r15d,[rcx+8]
       jae       near ptr M00_L39
       mov       edx,r15d
       mov       r8,[rcx+rdx*8+10]
       test      r8,r8
       jne       short M00_L29
       mov       rcx,rdi
       mov       edx,r15d
       call      qword ptr [7FF9F77B4660]
       mov       r8,rax
M00_L29:
       mov       r12,[r8+8]
       call      qword ptr [7FF9F77B5848]
       mov       [rsp+0D4],eax
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FF9F7115740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rsp+0D4]
       xor       edx,edx
       div       dword ptr [7FF9F705B170]
       mov       eax,edx
       xor       r8d,r8d
       jmp       short M00_L32
M00_L30:
       cmp       eax,[r12+8]
       jae       near ptr M00_L39
       mov       [rsp+78],eax
       mov       ecx,eax
       mov       rcx,[r12+rcx*8+10]
       mov       rdx,[rsp+38]
       cmp       [rcx],ecx
       call      qword ptr [7FF9F77B5860]
       test      eax,eax
       jne       short M00_L33
       mov       eax,[rsp+78]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M00_L31
       xor       ecx,ecx
M00_L31:
       mov       r8d,[rsp+74]
       inc       r8d
       mov       eax,ecx
M00_L32:
       mov       [rsp+74],r8d
       cmp       [r12+8],r8d
       jg        short M00_L30
       jmp       short M00_L34
M00_L33:
       mov       r12d,1
       jmp       short M00_L35
M00_L34:
       xor       r12d,r12d
M00_L35:
       jmp       near ptr M00_L05
M00_L36:
       cmp       dword ptr [rbp+8],0
       je        near ptr M00_L06
       mov       rcx,rbp
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+80],eax
       mov       edx,[rbp+8]
       mov       [rsp+7C],edx
       mov       rcx,rdi
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r14
       mov       r8d,[rsp+80]
       mov       r9d,[rsp+7C]
       mov       edx,3
       call      qword ptr [7FF9F77B4678]
       test      r12d,r13d
       jne       near ptr M00_L06
       mov       rcx,rbp
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       ebp,[rbp+8]
       mov       rcx,rdi
       call      qword ptr [7FF9F752D440]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M00_L37
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M00_L38
M00_L37:
       mov       ecx,r15d
       xor       edx,edx
M00_L38:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r14
       mov       edx,r12d
       mov       r8d,ebp
       call      qword ptr [7FF9F77B4690]
       jmp       near ptr M00_L06
M00_L39:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2048
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
       ja        short M01_L01
       test      r8b,18
       je        short M01_L05
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M01_L00:
       vzeroupper
       ret
M01_L01:
       cmp       r8,40
       ja        short M01_L07
M01_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M01_L04
M01_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M01_L00
M01_L04:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M01_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M01_L03
M01_L05:
       test      r8b,4
       je        short M01_L06
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M01_L00
M01_L06:
       test      r8,r8
       je        short M01_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M01_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       short M01_L00
M01_L07:
       cmp       r8,800
       ja        short M01_L11
       cmp       r8,100
       jb        short M01_L08
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
M01_L08:
       mov       r9,r8
       shr       r9,6
M01_L09:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M01_L09
       and       r8,3F
       cmp       r8,10
       ja        near ptr M01_L02
       jmp       near ptr M01_L03
M01_L10:
       cmp       rcx,rdx
       jne       short M01_L11
       cmp       [rdx],dl
       jmp       near ptr M01_L00
M01_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FF9F71166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       short M02_L01
M02_L00:
       movzx     edi,si
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       mov       edx,[rcx+8]
       cmp       eax,edx
       ja        short M02_L03
       mov       rcx,[rcx]
       mov       r8d,eax
       lea       rbp,[rcx+r8*2]
       sub       edx,eax
       je        short M02_L02
       mov       [rbp],di
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9F77B4870]
M02_L02:
       mov       rcx,rbx
       call      qword ptr [7FF9F77B48A0]
       jmp       short M02_L00
M02_L03:
       call      qword ptr [7FF9F7287198]
       int       3
; Total bytes of code 107
```
```assembly
; System.String.Ctor(System.ReadOnlySpan`1<Char>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rbx,[rcx]
       mov       esi,[rcx+8]
       test      esi,esi
       je        short M03_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FFA56DB9D30
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FF9F7115818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rax,1505F710008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
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
       call      qword ptr [7FFA3C44CCF8]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M05_L01
       cmp       [rax],ecx
       jle       short M05_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M05_L03
M05_L00:
       add       rsp,20
       pop       rbx
       ret
M05_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M05_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M05_L00
M05_L02:
       cmp       [rax+4],edx
       jle       short M05_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M05_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M05_L03
       jmp       short M05_L00
M05_L03:
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
       call      qword ptr [7FFA3C44FDA0]
       test      eax,eax
       je        short M06_L00
       add       rsp,20
       pop       rbx
       ret
M06_L00:
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
       jne       short M07_L00
       ret
M07_L00:
       jmp       qword ptr [7FF9F733E190]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M08_L01
       mov       rcx,rbx
       call      qword ptr [7FFA3C44CBB8]
       test      eax,eax
       je        short M08_L00
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M08_L01:
       xor       ecx,ecx
       call      qword ptr [7FFA3C4471F0]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M09_L00
       mov       rcx,rbx
       call      00007FFA56DC2A70
       test      eax,eax
       jne       short M09_L01
       add       rsp,20
       pop       rbx
       ret
M09_L00:
       xor       ecx,ecx
       call      qword ptr [7FF9F773FBE8]
       int       3
M09_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FF9F773FD80]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M10_L00
       add       rsp,28
       ret
M10_L00:
       call      qword ptr [7FFA3C45C8E0]
       int       3
; Total bytes of code 20
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       ecx,1B
       call      qword ptr [7FFA3C441C28]
       mov       rsi,rax
       call      qword ptr [7FFA3C435F40]
       lea       rcx,[rax+10]
       mov       rdx,rsi
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbx+8]
       mov       rdx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFA3C45A868]; Precode of System.Runtime.CompilerServices.ConditionalWeakTable`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].Add(System.__Canon, System.__Canon)
       lea       rax,[rbx+18]
       mov       ecx,1
       xchg      cl,[rax]
       movzx     ecx,cl
       test      ecx,ecx
       je        short M11_L01
M11_L00:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M11_L01:
       call      qword ptr [7FFA3C4350A0]
       mov       rdi,rax
       mov       rbp,[rdi+8]
       test      rbp,rbp
       jne       short M11_L02
       call      qword ptr [7FFA3C43FDF0]
       mov       rbp,rax
       mov       rdx,[rdi]
       mov       rcx,rbp
       call      qword ptr [7FFA3C444970]
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
M11_L02:
       call      qword ptr [7FFA3C43E640]
       mov       rdi,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbp
       call      qword ptr [7FFA3C433FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C44F528]
       test      rax,rax
       je        short M11_L04
M11_L03:
       mov       [rsp+20],rax
       mov       rax,[rsp+20]
       mov       [rdi+18],rax
       jmp       short M11_L00
M11_L04:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFA3C44F530]
       jmp       short M11_L03
; Total bytes of code 211
```

