## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,1A8
       lea       rbp,[rsp+1E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-148]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       [rbp-110],rax
       mov       rcx,rsp
       mov       [rbp-130],rcx
       mov       rcx,rbp
       mov       [rbp-120],rcx
       mov       rcx,1C0BA4012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M00_L51
       mov       rdx,[rcx+18]
M00_L01:
       test      rdx,rdx
       je        near ptr M00_L52
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L59
       mov       rcx,rbx
       mov       r11,7FFBB3E50AC0
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L20
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rbx],rcx
       je        near ptr M00_L14
       mov       rcx,rbx
       mov       r11,7FFBB3E50AC8
       call      qword ptr [r11]
       mov       esi,eax
M00_L02:
       mov       edi,esi
       test      edi,edi
       jl        near ptr M00_L53
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L54
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L54
M00_L03:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L04
       call      qword ptr [7FFBB4554E70]; System.Random+ThreadSafeRandom.Create()
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
       jb        near ptr M00_L55
M00_L05:
       shr       r11,20
       mov       edx,r11d
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rbx],rcx
       je        near ptr M00_L17
       mov       rcx,rbx
       mov       r11,7FFBB3E50AD0
       call      qword ptr [r11]
M00_L06:
       mov       [rbp-150],rax
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-40],rcx
       mov       rcx,1C0BA4012F0
       mov       rbx,[rcx]
       cmp       qword ptr [rbx+8],0
       je        near ptr M00_L13
       mov       rsi,[rbx+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rsi],rcx
       jne       near ptr M00_L72
       mov       rcx,2014F39B860
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
       je        near ptr M00_L70
M00_L07:
       mov       rdi,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rdi],rcx
       jne       near ptr M00_L71
       mov       rcx,rdi
       call      00007FFC13B13FE0
       test      eax,eax
       je        near ptr M00_L21
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
       jae       near ptr M00_L106
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       rbx,[rbx+10]
       xor       r15d,r15d
       dec       r14d
       mov       r13d,[rbx+8]
       cmp       r13d,r14d
       jbe       short M00_L13
M00_L11:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rbx+rcx*8+10]
       cmp       [r12+10],edi
       je        near ptr M00_L22
M00_L12:
       mov       r14d,[r12+14]
       inc       r15d
       mov       r13d,[rbx+8]
       cmp       r13d,r15d
       jb        near ptr M00_L75
       cmp       r13d,r14d
       ja        short M00_L11
M00_L13:
       xor       r12d,r12d
       jmp       near ptr M00_L24
M00_L14:
       mov       rcx,[rbx+8]
       mov       rax,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rcx],rax
       jne       short M00_L16
       call      qword ptr [7FFBB4395060]; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       mov       esi,eax
M00_L15:
       jmp       near ptr M00_L02
M00_L16:
       mov       r11,7FFBB3E50AD8
       call      qword ptr [r11]
       mov       esi,eax
       jmp       short M00_L15
M00_L17:
       mov       rcx,[rbx+8]
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],rax
       jne       short M00_L19
       cmp       [rcx+8],edx
       jbe       near ptr M00_L58
       mov       eax,edx
       mov       rax,[rcx+rax*8+10]
M00_L18:
       jmp       near ptr M00_L06
M00_L19:
       mov       r11,7FFBB3E50AE0
       call      qword ptr [r11]
       jmp       short M00_L18
M00_L20:
       xor       eax,eax
       jmp       near ptr M00_L06
M00_L21:
       mov       rcx,rdi
       call      qword ptr [7FFBB3F0E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L08
M00_L22:
       mov       r14,[r12]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rsi],rcx
       jne       near ptr M00_L74
       test      r14,r14
       je        near ptr M00_L12
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [r14],rcx
       jne       near ptr M00_L73
       mov       rcx,2014F39B860
       cmp       r14,rcx
       sete      r13b
       movzx     r13d,r13b
M00_L23:
       test      r13d,r13d
       je        near ptr M00_L12
       add       r12,8
M00_L24:
       test      r12,r12
       je        near ptr M00_L76
       mov       rbx,[r12]
       mov       [rbp-158],rbx
       mov       rcx,[rbp-150]
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        near ptr M00_L77
M00_L25:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.IList<DotNetTips.Spargine.Tester.Data.Models.State>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L83
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Data.Models.State>
       cmp       [rsi],rcx
       je        near ptr M00_L44
       mov       rcx,rsi
       mov       r11,7FFBB3E50B20
       call      qword ptr [r11]
M00_L26:
       test      eax,eax
       je        near ptr M00_L47
       mov       rcx,rsi
       mov       r11,7FFBB3E50B28
       call      qword ptr [r11]
       mov       ebx,eax
       test      ebx,ebx
       jl        near ptr M00_L78
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L79
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L79
M00_L27:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L28
       call      qword ptr [7FFBB4554E70]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L28:
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
       jb        near ptr M00_L80
M00_L29:
       mov       rdx,r11
       shr       rdx,20
       mov       rcx,rsi
       mov       r11,7FFBB3E50B30
       call      qword ptr [r11]
M00_L30:
       mov       rbx,rax
M00_L31:
       mov       [rbp-170],rbx
       test      rbx,rbx
       je        near ptr M00_L49
       mov       rsi,[rbx+8]
       test      rsi,rsi
       je        near ptr M00_L94
M00_L32:
       test      rsi,rsi
       je        near ptr M00_L49
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.IList<DotNetTips.Spargine.Tester.Data.Models.City>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       je        near ptr M00_L100
       mov       rcx,rdi
       mov       r11,7FFBB3E50B68
       call      qword ptr [r11]
       test      eax,eax
       je        near ptr M00_L48
       mov       rcx,rdi
       mov       r11,7FFBB3E50B70
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jl        near ptr M00_L95
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M00_L96
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M00_L96
M00_L33:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M00_L34
       call      qword ptr [7FFBB4554E70]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M00_L34:
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
       jb        near ptr M00_L97
M00_L35:
       mov       rdx,r11
       shr       rdx,20
       mov       rcx,rdi
       mov       r11,7FFBB3E50B78
       call      qword ptr [r11]
M00_L36:
       mov       rsi,rax
M00_L37:
       mov       [rbp-188],rsi
M00_L38:
       lea       rcx,[rbp-100]
       mov       rax,7FFBB420E158
       mov       [rbp-138],rax
       lea       rax,[M00_L39]
       mov       [rbp-128],rax
       mov       rax,[rbp-110]
       lea       rdx,[rbp-148]
       mov       [rax+8],rdx
       mov       rax,[rbp-110]
       mov       byte ptr [rax+4],0
       mov       rax,7FFC3CED0930
       vzeroupper
       call      rax
M00_L39:
       mov       rcx,[rbp-110]
       mov       byte ptr [rcx+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L40
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L40:
       mov       r8,[rbp-110]
       mov       rcx,[rbp-140]
       mov       [r8+8],rcx
       test      eax,eax
       jne       near ptr M00_L103
       vmovups   xmm0,[rbp-100]
       vmovups   [rbp-0F0],xmm0
       mov       r8,1C0BA400100
       mov       r8,[r8]
       lea       rcx,[rbp-0F0]
       mov       rdx,2014F39FFF8
       call      qword ptr [7FFBB3F07138]; System.Guid.ToString(System.String, System.IFormatProvider)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFBB4554A68]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       mov       ecx,13
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB45559E0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,2014F397C88
       call      qword ptr [7FFBB3F07840]; System.String.Concat(System.String, System.String, System.String)
       mov       rsi,rax
       mov       ecx,19
       call      qword ptr [7FFBB4555B30]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressLineTwo(Int32)
       mov       rdi,rax
       mov       rcx,[rbp-188]
       call      qword ptr [7FFBB4555B48]; DotNetTips.Spargine.Tester.RandomData.GetCityName(DotNetTips.Spargine.Tester.Data.Models.City)
       mov       r14,rax
       mov       rcx,[rbp-150]
       mov       r15,[rcx+68]
       mov       rcx,2014F390008
       test      r15,r15
       cmove     r15,rcx
       mov       ecx,14
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB45559E0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r13,rax
       mov       rcx,[rbp-150]
       mov       ecx,[rcx+0B8]
       call      qword ptr [7FFBB4554A68]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       r12,rax
       mov       rcx,[rbp-150]
       mov       rdx,[rbp-188]
       call      qword ptr [7FFBB4555B90]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Models.Country, DotNetTips.Spargine.Tester.Data.Models.City)
       mov       rcx,[rbp-170]
       test      rcx,rcx
       je        near ptr M00_L50
       mov       rcx,[rcx+20]
M00_L41:
       mov       rdx,2014F390008
       test      rcx,rcx
       cmove     rcx,rdx
       mov       [rsp+20],r14
       mov       [rsp+28],r15
       mov       [rsp+30],r13
       mov       [rsp+38],r12
       mov       [rsp+40],rax
       mov       [rsp+48],rcx
       lea       rcx,[rbp-0E0]
       mov       rdx,rbx
       mov       r8,rsi
       mov       r9,rdi
       call      qword ptr [7FFBB4555BC0]; DotNetTips.Spargine.Tester.RandomData+AddressComponents..ctor(System.String, System.String, System.String, System.String, System.String, System.String, System.String, System.String, System.String)
       vmovdqu   ymm0,ymmword ptr [rbp-0E0]
       vmovdqu   ymmword ptr [rbp-88],ymm0
       vmovdqu   ymm0,ymmword ptr [rbp-0C0]
       vmovdqu   ymmword ptr [rbp-68],ymm0
       mov       rcx,[rbp-0A0]
       mov       [rbp-48],rcx
       mov       rcx,offset DotNetTips.Spargine.Tester.RandomData+<>c.<.cctor>b__109_1(AddressComponents)
       mov       rbx,[rbp-158]
       cmp       [rbx+18],rcx
       jne       near ptr M00_L104
       mov       rcx,[rbx+8]
       lea       rdx,[rbp-88]
       call      qword ptr [7FFBB4356358]; DotNetTips.Spargine.Tester.RandomData+<>c.<.cctor>b__109_1(AddressComponents)
M00_L42:
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L43
       mov       r10,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Address
       cmp       [rcx],r10
       jne       near ptr M00_L105
M00_L43:
       mov       [rbp-108],rcx
       mov       rax,[rbp+10]
       mov       rcx,[rax+90]
       lea       r8,[rbp-108]
       mov       rdx,7FFBB45B7AF8
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455F060]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       vzeroupper
       add       rsp,1A8
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L44:
       mov       rcx,[rsi+8]
       mov       r11,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Data.Models.State>
       cmp       [rcx],r11
       jne       short M00_L46
       mov       eax,[rcx+10]
M00_L45:
       jmp       near ptr M00_L26
M00_L46:
       mov       r11,7FFBB3E50B38
       call      qword ptr [r11]
       jmp       short M00_L45
M00_L47:
       xor       eax,eax
       jmp       near ptr M00_L30
M00_L48:
       xor       eax,eax
       jmp       near ptr M00_L36
M00_L49:
       xor       esi,esi
       mov       [rbp-188],rsi
       jmp       near ptr M00_L38
M00_L50:
       xor       ecx,ecx
       jmp       near ptr M00_L41
M00_L51:
       call      qword ptr [7FFBB42A5038]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       near ptr M00_L01
M00_L52:
       call      qword ptr [7FFBB44CFBD0]
       mov       ecx,65
       mov       rdx,7FFBB431EF38
       call      qword ptr [7FFBB412C030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFBB4201860
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBB431EF38
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45CDD70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB44CF3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L53:
       mov       ecx,21AC
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFBB45C5050]
       int       3
M00_L54:
       mov       ecx,8
       call      qword ptr [7FFBB45CC600]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L55:
       mov       eax,edi
       neg       eax
       xor       edx,edx
       div       edi
       jmp       short M00_L57
M00_L56:
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
M00_L57:
       cmp       r8d,edx
       jb        short M00_L56
       jmp       near ptr M00_L05
M00_L58:
       call      qword ptr [7FFBB44CEA78]
       int       3
M00_L59:
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M00_L68
       mov       rcx,rbx
       mov       r11,7FFBB3E50AE8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L60
       xor       eax,eax
       mov       [rbp-168],rax
       jmp       near ptr M00_L66
M00_L60:
       mov       rcx,1C0BA401DF0
       mov       rcx,[rcx]
       mov       edx,eax
       call      qword ptr [7FFBB454B990]; System.Random+ThreadSafeRandom.Next(Int32)
       mov       esi,eax
       xor       edi,edi
       mov       rcx,rbx
       mov       r11,7FFBB3E50AF0
       call      qword ptr [r11]
       mov       [rbp-160],rax
M00_L61:
       mov       rcx,[rbp-160]
       mov       r11,7FFBB3E50AF8
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L64
       mov       rcx,[rbp-160]
       mov       r11,7FFBB3E50B00
       call      qword ptr [r11]
       cmp       edi,esi
       je        short M00_L62
       add       edi,1
       jo        short M00_L63
       jmp       short M00_L61
M00_L62:
       mov       [rbp-168],rax
       jmp       short M00_L65
M00_L63:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L64:
       mov       rcx,[rbp-160]
       mov       r11,7FFBB3E50B08
       call      qword ptr [r11]
       xor       eax,eax
       jmp       short M00_L67
M00_L65:
       call      M00_L107
       nop
M00_L66:
       mov       rax,[rbp-168]
M00_L67:
       jmp       near ptr M00_L06
M00_L68:
       mov       rcx,7FFBB46F3398
       call      qword ptr [7FFBB42A7A50]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],0
       je        short M00_L69
       mov       rcx,1C0BA401DF0
       mov       rcx,[rcx]
       mov       edx,[rbx+8]
       call      qword ptr [7FFBB454B990]; System.Random+ThreadSafeRandom.Next(Int32)
       cmp       eax,[rbx+8]
       jae       near ptr M00_L106
       mov       ecx,eax
       mov       rax,[rbx+rcx*8+10]
       jmp       near ptr M00_L06
M00_L69:
       xor       eax,eax
       jmp       near ptr M00_L06
M00_L70:
       xor       edi,edi
       jmp       near ptr M00_L09
M00_L71:
       mov       rcx,rdi
       mov       rax,[rdi]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       edi,eax
       jmp       near ptr M00_L09
M00_L72:
       mov       rcx,rsi
       mov       r11,7FFBB3E50B10
       mov       rdx,2014F39B860
       call      qword ptr [r11]
       mov       edi,eax
       jmp       near ptr M00_L10
M00_L73:
       mov       rcx,r14
       mov       rdx,2014F39B860
       mov       rax,[r14]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       mov       r13d,eax
       jmp       near ptr M00_L23
M00_L74:
       mov       rcx,rsi
       mov       rdx,r14
       mov       r11,7FFBB3E50B18
       mov       r8,2014F39B860
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L23
M00_L75:
       call      qword ptr [7FFBB412C2A0]
       int       3
M00_L76:
       call      qword ptr [7FFBB4126670]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2014F39B860
       call      qword ptr [7FFBB3E4A310]; Precode of System.RuntimeType.get_FullName()
       mov       rdi,rax
       mov       ecx,37D
       mov       rdx,7FFBB4200D90
       call      qword ptr [7FFBB412C030]
       mov       [rsp+20],rax
       mov       r9,rdi
       mov       r8,1C0BA401310
       mov       r8,[r8]
       mov       rdx,rbx
       mov       rcx,7FFBB4392180
       call      qword ptr [7FFBB4356040]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB412C048]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L77:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Data.Models.State>
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4554D38]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-150]
       lea       rcx,[rcx+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L25
M00_L78:
       mov       ecx,21AC
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFBB45C5050]
       int       3
M00_L79:
       mov       ecx,8
       call      qword ptr [7FFBB45CC600]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L27
M00_L80:
       mov       eax,ebx
       neg       eax
       xor       edx,edx
       div       ebx
       jmp       short M00_L82
M00_L81:
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
M00_L82:
       cmp       r8d,edx
       jb        short M00_L81
       jmp       near ptr M00_L29
M00_L83:
       mov       rdx,rbx
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Data.Models.State>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L92
       mov       rcx,rsi
       mov       r11,7FFBB3E50B40
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L84
       xor       ecx,ecx
       mov       [rbp-180],rcx
       jmp       near ptr M00_L90
M00_L84:
       mov       rcx,1C0BA401DF0
       mov       rcx,[rcx]
       mov       edx,eax
       call      qword ptr [7FFBB454B990]; System.Random+ThreadSafeRandom.Next(Int32)
       mov       ebx,eax
       xor       edi,edi
       mov       rcx,rsi
       mov       r11,7FFBB3E50B48
       call      qword ptr [r11]
       mov       [rbp-178],rax
M00_L85:
       mov       rcx,[rbp-178]
       mov       r11,7FFBB3E50B50
       call      qword ptr [r11]
       test      eax,eax
       je        short M00_L88
       mov       rcx,[rbp-178]
       mov       r11,7FFBB3E50B58
       call      qword ptr [r11]
       cmp       edi,ebx
       je        short M00_L86
       add       edi,1
       jo        short M00_L87
       jmp       short M00_L85
M00_L86:
       mov       [rbp-180],rax
       jmp       short M00_L89
M00_L87:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L88:
       mov       rcx,[rbp-178]
       mov       r11,7FFBB3E50B60
       call      qword ptr [r11]
       xor       ebx,ebx
       jmp       short M00_L91
M00_L89:
       call      M00_L109
       nop
M00_L90:
       mov       rbx,[rbp-180]
M00_L91:
       jmp       near ptr M00_L31
M00_L92:
       mov       rdx,rbx
       mov       rcx,7FFBB46F3910
       call      qword ptr [7FFBB42A7A50]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        short M00_L93
       mov       rcx,1C0BA401DF0
       mov       rcx,[rcx]
       mov       edx,[rsi+8]
       call      qword ptr [7FFBB454B990]; System.Random+ThreadSafeRandom.Next(Int32)
       cmp       eax,[rsi+8]
       jae       near ptr M00_L106
       mov       ecx,eax
       mov       rbx,[rsi+rcx*8+10]
       jmp       near ptr M00_L31
M00_L93:
       xor       ebx,ebx
       jmp       near ptr M00_L31
M00_L94:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection<DotNetTips.Spargine.Tester.Data.Models.City>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB4554D38]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbx,[rbp-170]
       jmp       near ptr M00_L32
M00_L95:
       mov       ecx,21AC
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFBB45C5050]
       int       3
M00_L96:
       mov       ecx,8
       call      qword ptr [7FFBB45CC600]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L33
M00_L97:
       mov       eax,esi
       neg       eax
       xor       edx,edx
       div       esi
       jmp       short M00_L99
M00_L98:
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
M00_L99:
       cmp       r8d,edx
       jb        short M00_L98
       jmp       near ptr M00_L35
M00_L100:
       mov       rdx,rsi
       mov       rcx,offset MT_System.Collections.Generic.ICollection<DotNetTips.Spargine.Tester.Data.Models.City>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rax,rax
       je        short M00_L101
       mov       rdx,rax
       mov       rcx,7FFBB46F3C68
       call      qword ptr [7FFBB4555C68]
       mov       rsi,rax
       jmp       near ptr M00_L37
M00_L101:
       mov       rdx,rsi
       mov       rcx,7FFBB46F3CF0
       call      qword ptr [7FFBB42A7A50]; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],0
       je        short M00_L102
       mov       rcx,1C0BA401DF0
       mov       rcx,[rcx]
       mov       edx,[rsi+8]
       call      qword ptr [7FFBB454B990]; System.Random+ThreadSafeRandom.Next(Int32)
       cmp       eax,[rsi+8]
       jae       short M00_L106
       mov       edx,eax
       mov       rsi,[rsi+rdx*8+10]
       jmp       near ptr M00_L37
M00_L102:
       xor       esi,esi
       jmp       near ptr M00_L37
M00_L103:
       mov       ecx,eax
       call      qword ptr [7FFBB45CCEE8]
       int       3
M00_L104:
       lea       rdx,[rbp-88]
       mov       rcx,[rbx+8]
       call      qword ptr [rbx+18]
       jmp       near ptr M00_L42
M00_L105:
       mov       rdx,rax
       mov       rcx,r10
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L106:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L107:
       sub       rsp,58
       cmp       qword ptr [rbp-160],0
       je        short M00_L108
       mov       rcx,[rbp-160]
       mov       r11,7FFBB3E50B08
       call      qword ptr [r11]
M00_L108:
       nop
       vzeroupper
       add       rsp,58
       ret
M00_L109:
       sub       rsp,58
       cmp       qword ptr [rbp-178],0
       je        short M00_L110
       mov       rcx,[rbp-178]
       mov       r11,7FFBB3E50B60
       call      qword ptr [r11]
M00_L110:
       nop
       vzeroupper
       add       rsp,58
       ret
; Total bytes of code 4171
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC0D893778]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC0D89D778]
       call      qword ptr [7FFC0D88AEA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 51
```
```assembly
; System.Collections.ObjectModel.ReadOnlyCollection`1[[System.__Canon, System.Private.CoreLib]].get_Count()
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rbx,rcx
       mov       rcx,[rbx]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       r11,[rdx+38]
       test      r11,r11
       je        short M02_L01
M02_L00:
       mov       rcx,[rbx+8]
       cmp       [rcx],ecx
       add       rsp,30
       pop       rbx
       jmp       qword ptr [r11]
M02_L01:
       mov       rdx,7FFBB46D0EF8
       call      qword ptr [7FFBB3F0C5B8]; System.Runtime.CompilerServices.GenericsHelpers.Class(IntPtr, IntPtr)
       mov       r11,rax
       jmp       short M02_L00
; Total bytes of code 67
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
       je        short M03_L03
       mov       rcx,7FFBB45BB97C
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+10]
       mov       rax,7FFBB4059CB0
       mov       [rbp-60],rax
       lea       rax,[M03_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFC13B443B0
       call      rax
M03_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M03_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M03_L01:
       mov       rcx,[rbp-68]
       mov       [rbx+8],rcx
M03_L02:
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
M03_L03:
       mov       rcx,7FFBB45BB978
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       jmp       short M03_L02
; Total bytes of code 195
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       test      rdx,rdx
       je        short M04_L00
       mov       rax,[rdx]
       movzx     r8d,word ptr [rax+0E]
       test      r8,r8
       je        short M04_L05
       mov       r10,[rax+38]
       cmp       r8,4
       jl        short M04_L04
       cmp       [r10],rcx
       jne       short M04_L01
M04_L00:
       mov       rax,rdx
       ret
M04_L01:
       cmp       [r10+8],rcx
       je        short M04_L00
       jmp       short M04_L03
M04_L02:
       cmp       [r10],rcx
       je        short M04_L00
       jmp       short M04_L01
M04_L03:
       cmp       [r10+10],rcx
       je        short M04_L00
       cmp       [r10+18],rcx
       je        short M04_L00
       add       r10,20
       add       r8,0FFFFFFFFFFFFFFFC
       cmp       r8,4
       jge       short M04_L02
       test      r8,r8
       je        short M04_L05
M04_L04:
       cmp       [r10],rcx
       je        short M04_L00
       add       r10,8
       dec       r8
       test      r8,r8
       jg        short M04_L04
M04_L05:
       test      dword ptr [rax],500C0000
       jne       short M04_L06
       xor       edx,edx
       jmp       short M04_L00
M04_L06:
       jmp       qword ptr [7FFBB42AE8B0]; System.Runtime.CompilerServices.CastHelpers.IsInstance_Helper(Void*, System.Object)
; Total bytes of code 118
```
```assembly
; System.Guid.ToString(System.String, System.IFormatProvider)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   xmmword ptr [rsp+28],xmm4
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       rbx,rdx
       test      rbx,rbx
       je        near ptr M05_L04
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M05_L04
       cmp       edi,1
       jne       near ptr M05_L17
       movzx     eax,word ptr [rbx+0C]
       or        eax,20
       cmp       eax,64
       jle       near ptr M05_L13
       cmp       eax,6E
       jne       near ptr M05_L15
       mov       ecx,20
M05_L00:
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rbp,rax
       lea       r14,[rbp+0C]
       mov       r15d,[rbp+8]
       test      rbx,rbx
       jne       near ptr M05_L05
       xor       edx,edx
       xor       r8d,r8d
M05_L01:
       test      r8d,r8d
       je        near ptr M05_L21
       cmp       r8d,1
       jne       near ptr M05_L17
       movzx     eax,word ptr [rdx]
       or        eax,20
       cmp       eax,64
       jle       near ptr M05_L18
       cmp       eax,6E
       jne       near ptr M05_L20
       mov       ebx,20
M05_L02:
       movzx     eax,bl
       cmp       eax,r15d
       jg        near ptr M05_L24
       movzx     eax,bl
       mov       [rsp+40],eax
       sar       ebx,8
       mov       [rsp+38],r14
       mov       rax,r14
       test      bl,bl
       jne       near ptr M05_L25
M05_L03:
       sar       ebx,8
       vmovups   xmm0,[rsi]
       vmovups   xmm1,[7FFBB462DAC0]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFBB462DAD0]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vpshufb   xmm1,xmm3,[7FFBB462DAE0]
       test      ebx,ebx
       jge       short M05_L06
       vpshufb   xmm2,xmm0,[7FFBB462DAF0]
       vpshufb   xmm3,xmm1,[7FFBB462DB00]
       vpshufb   xmm1,xmm1,[7FFBB462DB10]
       vpshufb   xmm0,xmm0,[7FFBB462DB20]
       vpor      xmm0,xmm0,xmm1
       vpor      xmm0,xmm0,[7FFBB462DB30]
       vmovaps   xmm1,xmm3
       jmp       short M05_L07
M05_L04:
       mov       ecx,24
       jmp       near ptr M05_L00
M05_L05:
       lea       rdx,[rbx+0C]
       mov       edi,[rbx+8]
       mov       r8d,edi
       jmp       near ptr M05_L01
M05_L06:
       vxorps    xmm2,xmm2,xmm2
       vmovaps   xmm3,xmm0
       vmovaps   xmm0,xmm2
       vmovaps   xmm2,xmm3
M05_L07:
       vpmovzxbw xmm3,xmm1
       vpsrldq   xmm1,xmm1,8
       vpmovzxbw xmm1,xmm1
       vpmovzxbw xmm4,xmm2
       vpsrldq   xmm2,xmm2,8
       vpmovzxbw xmm2,xmm2
       test      ebx,ebx
       jge       short M05_L12
       vpmovzxbw xmm1,xmm0
       vpsrldq   xmm0,xmm0,8
       vpmovzxbw xmm0,xmm0
       vmovups   [rax],xmm3
       vmovups   [rax+28],xmm4
       vmovups   [rax+38],xmm2
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm0
       add       rax,48
M05_L08:
       test      bl,bl
       jne       near ptr M05_L26
M05_L09:
       xor       eax,eax
       mov       [rsp+38],rax
M05_L10:
       xor       eax,eax
       mov       [rsp+38],rax
M05_L11:
       mov       rax,rbp
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M05_L12:
       vmovups   [rax],xmm3
       vmovups   [rax+10],xmm1
       vmovups   [rax+20],xmm4
       vmovups   [rax+30],xmm2
       add       rax,40
       jmp       short M05_L08
M05_L13:
       cmp       eax,62
       je        short M05_L16
       cmp       eax,64
       je        near ptr M05_L04
M05_L14:
       call      qword ptr [7FFBB45CC960]
       int       3
M05_L15:
       cmp       eax,70
       je        short M05_L16
       cmp       eax,78
       jne       short M05_L14
       mov       ecx,44
       jmp       near ptr M05_L00
M05_L16:
       mov       ecx,26
       jmp       near ptr M05_L00
M05_L17:
       call      qword ptr [7FFBB45CC960]
       int       3
M05_L18:
       cmp       eax,62
       je        short M05_L23
       cmp       eax,64
       je        short M05_L21
M05_L19:
       call      qword ptr [7FFBB45CC960]
       int       3
M05_L20:
       cmp       eax,70
       je        short M05_L22
       cmp       eax,78
       jne       short M05_L19
       mov       [rsp+28],r14
       mov       [rsp+30],r15d
       lea       rdx,[rsp+28]
       lea       r8,[rsp+40]
       mov       rcx,rsi
       call      qword ptr [7FFBB45CC9A8]
       jmp       near ptr M05_L11
M05_L21:
       mov       ebx,80000024
       jmp       near ptr M05_L02
M05_L22:
       mov       ebx,80292826
       jmp       near ptr M05_L02
M05_L23:
       mov       ebx,807D7B26
       jmp       near ptr M05_L02
M05_L24:
       xor       eax,eax
       mov       [rsp+40],eax
       jmp       near ptr M05_L10
M05_L25:
       lea       rax,[r14+2]
       movzx     ecx,bl
       mov       [r14],cx
       jmp       near ptr M05_L03
M05_L26:
       movzx     ecx,bl
       mov       [rax],cx
       jmp       near ptr M05_L09
; Total bytes of code 713
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
       mov       rax,0F569A35605EC
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
       jg        near ptr M06_L17
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M06_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M06_L00:
       push      0
       push      0
       dec       rsi
       jne       short M06_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M06_L01:
       test      ebx,ebx
       jl        near ptr M06_L21
       mov       edi,ebx
M06_L02:
       cmp       ebx,100
       jg        near ptr M06_L19
; 		var chars = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc char[length]
; 			                         
; 			: (rentedChars = ArrayPool<char>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       mov       eax,ebx
       mov       ecx,2
       mul       rcx
       jb        near ptr M06_L23
       mov       r14,rax
       test      r14,r14
       je        short M06_L04
       add       r14,0F
       shr       r14,4
       add       rsp,20
M06_L03:
       push      0
       push      0
       dec       r14
       jne       short M06_L03
       sub       rsp,20
       lea       r14,[rsp+20]
M06_L04:
       test      ebx,ebx
       jl        near ptr M06_L21
       mov       r15d,ebx
M06_L05:
       test      edi,edi
       jle       short M06_L06
       mov       rcx,rsi
       mov       [rbp+30],rcx
       mov       edx,edi
       call      qword ptr [7FFBB4355FB0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+30],rcx
M06_L06:
       xor       ecx,ecx
       mov       [rbp+30],rcx
; 			for (var digitIndex = 0; digitIndex < length; digitIndex++)
; 			                         ^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       jle       short M06_L08
       cmp       ebx,r15d
       jg        short M06_L09
       cmp       ebx,edi
       jg        short M06_L09
; 				chars[digitIndex] = (char)('0' + (bytes[digitIndex] % 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L07:
       mov       eax,ecx
       movzx     edx,byte ptr [rsi+rax]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M06_L11
       cmp       edx,0FFFF
       ja        short M06_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M06_L11
       cmp       ecx,ebx
       jl        short M06_L07
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L08:
       mov       [rbp+20],r14
       mov       [rbp+28],r15d
       lea       rcx,[rbp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       jmp       short M06_L12
M06_L09:
       cmp       ecx,r15d
       jae       short M06_L10
       mov       eax,ecx
       cmp       ecx,edi
       jae       short M06_L10
       mov       edx,ecx
       movzx     edx,byte ptr [rsi+rdx]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M06_L11
       cmp       edx,0FFFF
       ja        short M06_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M06_L11
       cmp       ecx,ebx
       jl        short M06_L09
       jmp       short M06_L08
M06_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			if (rentedBytes is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L12:
       cmp       qword ptr [rbp+18],0
       je        short M06_L14
; 				ArrayPool<byte>.Shared.Return(rentedBytes);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      byte ptr [7FFBB45608F8],1
       je        near ptr M06_L22
M06_L13:
       mov       rcx,1C0BA401E70
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4560BC8]
; 			if (rentedChars is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L14:
       cmp       qword ptr [rbp+10],0
       je        short M06_L15
; 				ArrayPool<char>.Shared.Return(rentedChars);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,1C0BA400C90
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41FBE38]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
M06_L15:
       mov       rax,rbx
       mov       r8,0F569A35605EC
       cmp       [rbp+8],r8
       je        short M06_L16
       call      CORINFO_HELP_FAIL_FAST
M06_L16:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L17:
       test      byte ptr [7FFBB45608F8],1
       je        short M06_L20
M06_L18:
       mov       rcx,1C0BA401E70
       mov       rcx,[rcx]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4560BC0]
       mov       [rbp+18],rax
       test      rax,rax
       je        short M06_L21
       cmp       [rax+8],ebx
       jb        short M06_L21
       add       rax,10
       mov       rsi,rax
       mov       edi,ebx
       jmp       near ptr M06_L02
M06_L19:
       mov       rcx,1C0BA400C90
       mov       rcx,[rcx]
       mov       edx,ebx
       call      qword ptr [7FFBB41FBE30]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+10],rax
       test      rax,rax
       je        short M06_L21
       cmp       [rax+8],ebx
       jb        short M06_L21
       add       rax,10
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M06_L05
M06_L20:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M06_L18
M06_L21:
       call      qword ptr [7FFBB4077198]
       int       3
M06_L22:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M06_L13
M06_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp+18],0
       je        short M06_L25
       test      byte ptr [7FFBB45608F8],1
       jne       short M06_L24
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M06_L24:
       mov       rcx,1C0BA401E70
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4560BC8]
M06_L25:
       cmp       qword ptr [rbp+10],0
       je        short M06_L26
       mov       rcx,1C0BA400C90
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41FBE38]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
M06_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 804
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
       mov       rax,0F569A35605EC
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
       je        near ptr M07_L13
M07_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M07_L25
       add       edi,1
       jo        near ptr M07_L25
       cmp       r15d,100
       jg        near ptr M07_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M07_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M07_L01:
       push      0
       push      0
       dec       r15
       jne       short M07_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M07_L02:
       test      ebx,ebx
       jl        near ptr M07_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M07_L25
       mov       r13,rax
       test      r13,r13
       je        short M07_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M07_L03:
       push      0
       push      0
       dec       r13
       jne       short M07_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M07_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M07_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4390630
       mov       [rbp+60],rax
       lea       rax,[M07_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M07_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M07_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M07_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M07_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M07_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M07_L09
M07_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M07_L25
       cmp       edx,0FFFF
       ja        near ptr M07_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M07_L25
       cmp       ecx,ebx
       jge       short M07_L10
       jmp       short M07_L08
M07_L09:
       mov       r13,[rbp+10]
M07_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M07_L11:
       mov       r8,0F569A35605EC
       cmp       [rbp+8],r8
       je        short M07_L12
       call      CORINFO_HELP_FAIL_FAST
M07_L12:
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
M07_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M07_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FFBB4554948]
       mov       ebx,eax
       jmp       near ptr M07_L00
M07_L14:
       call      qword ptr [7FFBB4554960]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M07_L15
       call      qword ptr [7FFBB45CDD58]
       mov       rbx,rax
M07_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2014F392288
       call      qword ptr [7FFBB412E9E8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M07_L16:
       call      qword ptr [7FFBB4077198]
       int       3
M07_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45CC528]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M07_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C0BA401E70
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4560BC0]
       mov       [rbp+28],rax
       mov       rcx,1C0BA400C90
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41FBE30]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M07_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M07_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FFBB4355F80]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M07_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M07_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M07_L20
M07_L19:
       call      qword ptr [7FFBB4077198]
       int       3
M07_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB435DA58]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M07_L24
M07_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M07_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M07_L23:
       cmp       r10d,r8d
       jae       short M07_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M07_L22
       cmp       edx,0FFFF
       ja        short M07_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M07_L22
M07_L24:
       cmp       r10d,r14d
       jl        short M07_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FFBB3F01548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C0BA401E70
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4560BC8]
       mov       rcx,1C0BA400C90
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41FBE38]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M07_L11
M07_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45608F8],1
       jne       short M07_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M07_L26:
       mov       rcx,1C0BA401E70
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4560BC8]
       mov       rcx,1C0BA400C90
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41FBE38]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1124
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
       je        near ptr M08_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M08_L02
       test      rsi,rsi
       je        near ptr M08_L01
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M08_L01
       test      rdi,rdi
       je        near ptr M08_L00
       mov       r15d,[rdi+8]
       test      r15d,r15d
       je        near ptr M08_L00
       mov       r13d,ebp
       mov       edx,r14d
       add       rdx,r13
       mov       ecx,r15d
       add       rdx,rcx
       cmp       rdx,7FFFFFFF
       jg        near ptr M08_L03
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+20],rax
       mov       rcx,rax
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rbx,[rsp+20]
       lea       rcx,[rbx+r13*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[rbx+rcx*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
M08_L00:
       mov       rcx,rbx
       mov       rdx,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
M08_L01:
       mov       rcx,rbx
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
M08_L02:
       mov       rcx,rsi
       mov       rdx,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
M08_L03:
       call      qword ptr [7FFBB45C4E40]
       int       3
; Total bytes of code 333
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
       jo        near ptr M09_L03
       sub       ecx,1
       jo        near ptr M09_L03
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB45559E0]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       mov       ecx,5
       call      qword ptr [7FFBB4554A68]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rsi,rax
       test      rbx,rbx
       je        near ptr M09_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M09_L01
       test      rsi,rsi
       je        near ptr M09_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M09_L00
       mov       r14d,edi
       mov       edx,ebp
       lea       rdx,[r14+rdx+1]
       cmp       rdx,7FFFFFFF
       jg        near ptr M09_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       r13,[r15+0C]
       mov       rcx,r13
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r13+r14*2]
       mov       word ptr [rcx],20
       inc       edi
       movsxd    rcx,edi
       lea       rcx,[r13+rcx*2]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,rbx
       mov       rdx,2014F397C88
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
M09_L01:
       mov       rdx,rsi
       mov       rcx,2014F397C88
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
M09_L02:
       call      qword ptr [7FFBB45C4E40]
       int       3
M09_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 309
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetCityName(DotNetTips.Spargine.Tester.Data.Models.City)
; 		city?.Name ?? Core.ControlChars.EmptyString;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      rcx,rcx
       je        short M10_L01
       mov       rax,[rcx+18]
M10_L00:
       mov       rcx,2014F390008
       test      rax,rax
       cmove     rax,rcx
       ret
M10_L01:
       xor       eax,eax
       jmp       short M10_L00
; Total bytes of code 31
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
       je        near ptr M11_L35
       mov       rcx,[rbx+88]
       test      rcx,rcx
       je        near ptr M11_L28
       cmp       dword ptr [rcx+8],0
       je        near ptr M11_L28
       mov       rcx,1C0BA401388
       mov       rdi,[rcx]
       mov       rcx,1C0BA401340
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M11_L36
M11_L00:
       mov       r15,rbx
       mov       r13,[r14+8]
       mov       rcx,[r13+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M11_L37
       mov       rcx,r15
       call      00007FFC13B13FE0
       test      eax,eax
       je        near ptr M11_L29
M11_L01:
       mov       r12d,eax
M11_L02:
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
       jae       near ptr M11_L49
       mov       r8d,r8d
       mov       rax,[rcx+r8*8+10]
       test      rax,rax
       je        near ptr M11_L41
       test      r15,r15
       je        near ptr M11_L31
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M11_L31
M11_L03:
       cmp       r12d,[rax+20]
       jne       near ptr M11_L30
       mov       rdx,[rax+8]
       test      rdx,rdx
       je        near ptr M11_L30
       cmp       rdx,rbx
       jne       near ptr M11_L30
M11_L04:
       mov       rdx,[rax+10]
       mov       [rbp-40],rdx
M11_L05:
       mov       rcx,[rbp-40]
       xor       edx,edx
       mov       [rbp-40],rdx
       test      rcx,rcx
       je        near ptr M11_L32
       lea       rdi,[rcx+10]
       mov       r14d,[rcx+8]
M11_L06:
       test      r14d,r14d
       je        near ptr M11_L42
       lea       r15d,[r14-1]
       test      r15d,r15d
       jne       near ptr M11_L33
       xor       r13d,r13d
M11_L07:
       cmp       r13d,r14d
       jae       near ptr M11_L49
       mov       ecx,r13d
       mov       rdi,[rdi+rcx*8]
       mov       rcx,1C0BA401348
       mov       r14,[rcx]
       mov       rcx,[r14+20]
       mov       [rbp-58],rcx
       cmp       qword ptr [rbp-58],0
       je        near ptr M11_L45
       lea       rcx,[r14+20]
       mov       r8,[rbp-58]
       test      rcx,rcx
       je        near ptr M11_L44
       xor       edx,edx
       call      00007FFC13B421C0
       cmp       rax,[rbp-58]
       jne       near ptr M11_L45
M11_L08:
       mov       r14,[rbp-58]
M11_L09:
       xor       ecx,ecx
       mov       [rbp-58],rcx
       mov       edx,[rdi+8]
       test      r14,r14
       je        near ptr M11_L47
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       add       ecx,[r14+1C]
       cmp       ecx,edx
       jl        near ptr M11_L48
M11_L10:
       mov       rcx,[r14+8]
       mov       ecx,[rcx+8]
       mov       [rbp-88],r14
       lea       r14,[rdi+0C]
       mov       r15d,[rdi+8]
       xor       r13d,r13d
       cmp       r13d,r15d
       jge       near ptr M11_L14
M11_L11:
       cmp       r13d,r15d
       jae       near ptr M11_L24
       movzx     edx,word ptr [r14+r13*2]
       cmp       edx,41
       je        near ptr M11_L18
       cmp       edx,4E
       jne       near ptr M11_L17
       mov       ecx,1
       call      qword ptr [7FFBB4554A68]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       test      rax,rax
       je        short M11_L13
       lea       rdx,[rax+0C]
       mov       r8d,[rax+8]
       test      r8d,r8d
       je        short M11_L13
       mov       r12,[rbp-88]
       mov       rcx,[r12+8]
       mov       eax,[r12+18]
       lea       r10d,[rax+r8]
       mov       [rbp-7C],r10d
       cmp       r10d,[rcx+8]
       ja        near ptr M11_L22
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jg        near ptr M11_L21
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       je        near ptr M11_L20
M11_L12:
       mov       r10d,[rbp-7C]
       mov       [r12+18],r10d
M11_L13:
       inc       r13d
       cmp       r13d,r15d
       jl        near ptr M11_L11
M11_L14:
       mov       rdx,[rbx+48]
       mov       r12,[rbp-88]
       mov       r8d,[r12+1C]
       add       r8d,[r12+18]
       mov       rcx,2014F3A001C
       test      rdx,rdx
       jne       near ptr M11_L19
       xor       r9d,r9d
       xor       eax,eax
M11_L15:
       mov       [rbp-68],rcx
       mov       dword ptr [rbp-60],2
       mov       [rbp-78],r9
       mov       [rbp-70],eax
       mov       [rsp+20],r8d
       lea       rdx,[rbp-68]
       lea       r8,[rbp-78]
       mov       rcx,r12
       xor       r9d,r9d
       call      qword ptr [7FFBB4556190]; System.Text.StringBuilder.Replace(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, Int32, Int32)
       test      rsi,rsi
       je        short M11_L16
       mov       edx,[rdi+8]
       mov       ecx,[rdi+8]
       add       rdi,0C
       mov       rcx,rdi
       mov       r8,2014F3A007C
       mov       r9d,4
       call      qword ptr [7FFBB45561A8]; System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       jge       near ptr M11_L26
M11_L16:
       mov       rcx,r12
       call      qword ptr [7FFBB40F2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-90],rax
       jmp       near ptr M11_L27
M11_L17:
       mov       r12,[rbp-88]
       mov       ecx,[r12+18]
       mov       rax,[r12+8]
       mov       r8d,[rax+8]
       cmp       r8d,ecx
       jbe       near ptr M11_L23
       cmp       ecx,r8d
       jae       near ptr M11_L24
       mov       [rax+rcx*2+10],dx
       inc       dword ptr [r12+18]
       jmp       near ptr M11_L13
M11_L18:
       mov       r12,[rbp-88]
       mov       ecx,41
       mov       edx,5A
       call      qword ptr [7FFBB4555008]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M11_L25
       mov       edx,eax
       mov       rcx,r12
       call      qword ptr [7FFBB407F180]; System.Text.StringBuilder.Append(Char)
       jmp       near ptr M11_L13
M11_L19:
       lea       r9,[rdx+0C]
       mov       eax,[rdx+8]
       jmp       near ptr M11_L15
M11_L20:
       movzx     r8d,word ptr [rdx+2]
       mov       [rcx+2],r8w
       jmp       near ptr M11_L12
M11_L21:
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M11_L12
M11_L22:
       mov       rcx,r12
       call      qword ptr [7FFBB407F1E0]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M11_L13
M11_L23:
       mov       rcx,r12
       call      qword ptr [7FFBB407F3A8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M11_L13
M11_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M11_L26:
       mov       r8,[rsi+18]
       mov       ecx,[r12+1C]
       add       ecx,[r12+18]
       mov       [rsp+20],ecx
       mov       rcx,r12
       mov       rdx,2014F3A0070
       xor       r9d,r9d
       call      qword ptr [7FFBB4556178]; System.Text.StringBuilder.Replace(System.String, System.String, Int32, Int32)
       jmp       near ptr M11_L16
M11_L27:
       call      M11_L50
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
M11_L28:
       mov       rax,2014F390008
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
M11_L29:
       mov       rcx,r15
       call      qword ptr [7FFBB3F0E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M11_L01
M11_L30:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M11_L03
       jmp       near ptr M11_L41
M11_L31:
       cmp       r12d,[rax+20]
       jne       near ptr M11_L40
       mov       [rbp-98],rax
       mov       rdx,[rax+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [r15],rcx
       jne       near ptr M11_L38
       test      rdx,rdx
       je        near ptr M11_L39
       cmp       rdx,rbx
       mov       rax,[rbp-98]
       jne       near ptr M11_L40
       jmp       near ptr M11_L04
M11_L32:
       xor       edi,edi
       xor       r14d,r14d
       jmp       near ptr M11_L06
M11_L33:
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
M11_L34:
       lea       rcx,[rbp-44]
       mov       [rbp-50],rcx
       lea       rcx,[rbp-44]
       mov       edx,4
       call      qword ptr [7FFBB4355FB0]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-50],rcx
       mov       ecx,r13d
       and       ecx,[rbp-44]
       cmp       ecx,r15d
       ja        short M11_L34
       mov       r13d,ecx
       jmp       near ptr M11_L07
M11_L35:
       call      qword ptr [7FFBB44CFBD0]
       mov       ecx,15
       mov       rdx,7FFBB4200D90
       call      qword ptr [7FFBB412C030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFBB4201860
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,169
       mov       rdx,7FFBB4200D90
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45CDD70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB44CF3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M11_L36:
       mov       rcx,offset MT_System.Func<DotNetTips.Spargine.Tester.Data.Models.Country, System.String[]>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1C0BA401378
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GeneratePostalCode>b__99_0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      qword ptr [7FFBB3F06BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1C0BA401388
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M11_L00
M11_L37:
       mov       rdx,r15
       mov       r11,7FFBB3E50DB8
       call      qword ptr [r11]
       mov       r12d,eax
       jmp       near ptr M11_L02
M11_L38:
       mov       rcx,r15
       mov       r8,rbx
       mov       r11,7FFBB3E50DC0
       call      qword ptr [r11]
       test      eax,eax
       mov       rax,[rbp-98]
       je        short M11_L40
       jmp       near ptr M11_L04
M11_L39:
       mov       rax,[rbp-98]
M11_L40:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M11_L31
M11_L41:
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
       call      qword ptr [7FFBB42AD6C8]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M11_L05
M11_L42:
       call      qword ptr [7FFBB4556010]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M11_L43
       call      qword ptr [7FFBB45CDD70]
       mov       rbx,rax
M11_L43:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2014F3A0030
       call      qword ptr [7FFBB44CF3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M11_L44:
       call      qword ptr [7FFBB45CC540]
       int       3
M11_L45:
       mov       rcx,[r14+18]
       lea       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45560D0]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M11_L46
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M11_L08
M11_L46:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M11_L09
M11_L47:
       call      qword ptr [7FFBB44CFBD0]
       mov       ecx,0CA8
       mov       rdx,7FFBB431EF38
       call      qword ptr [7FFBB412C030]
       mov       rbx,rax
       mov       ecx,191A
       mov       rdx,7FFBB4201860
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFBB431EF38
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45CDD70]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB44CF3A8]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M11_L48:
       mov       rcx,r14
       call      qword ptr [7FFBB45CCFD8]
       jmp       near ptr M11_L10
M11_L49:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L50:
       sub       rsp,48
       mov       r12,[rbp-88]
       cmp       dword ptr [r12+20],0
       jge       short M11_L51
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       ecx,3AD
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB412C030]
       mov       rbx,rax
       call      qword ptr [7FFBB45CCCC0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,r12
       call      qword ptr [7FFBB412E9E8]
       mov       rcx,r12
       call      CORINFO_HELP_THROW
       int       3
M11_L51:
       cmp       qword ptr [r12+10],0
       jne       short M11_L52
       xor       ecx,ecx
       mov       [r12+18],rcx
       jmp       near ptr M11_L59
M11_L52:
       mov       ecx,[r12+1C]
       add       ecx,[r12+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M11_L53
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFBB45CCE28]
       jmp       near ptr M11_L59
M11_L53:
       mov       rcx,r12
       xor       edx,edx
       call      qword ptr [7FFBB45CCE40]; System.Text.StringBuilder.FindChunkForIndex(Int32)
       mov       rbx,rax
       cmp       rbx,r12
       je        near ptr M11_L58
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
       jge       short M11_L56
       cmp       ecx,400
       jge       short M11_L54
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M11_L55
M11_L54:
       xor       edx,edx
       call      qword ptr [7FFBB44CFCD8]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M11_L55:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFBB3F07048]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[r12+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M11_L57
M11_L56:
       mov       rdx,[rbx+8]
       lea       rcx,[r12+8]
       call      CORINFO_HELP_ASSIGN_REF
M11_L57:
       mov       rdx,[rbx+10]
       lea       rcx,[r12+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [r12+1C],ecx
M11_L58:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [r12+18],ecx
M11_L59:
       mov       rdx,1C0BA401348
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,r12
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M11_L61
M11_L60:
       add       rsp,48
       ret
M11_L61:
       cmp       qword ptr [rbx+20],0
       jne       short M11_L63
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M11_L62
       call      qword ptr [7FFBB45CC540]
       int       3
M11_L62:
       mov       rdx,r12
       xor       r8d,r8d
       call      00007FFC13B421C0
       test      rax,rax
       je        short M11_L60
M11_L63:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M11_L64
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,r12
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45CD1B8]
       test      eax,eax
       jne       short M11_L60
       mov       rcx,rbx
       mov       rdx,r12
       call      qword ptr [7FFBB45CD1D0]
       jmp       short M11_L60
M11_L64:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M11_L60
; Total bytes of code 2515
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
; DotNetTips.Spargine.Tester.RandomData+<>c.<.cctor>b__109_1(AddressComponents)
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
       call      qword ptr [7FFBB4556760]; DotNetTips.Spargine.Tester.Models.RefTypes.Address..ctor()
       mov       rdx,[rbx]
       mov       rcx,rsi
       call      qword ptr [7FFBB4333818]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Id(System.String)
       mov       rdx,[rbx+8]
       mov       rcx,rsi
       call      qword ptr [7FFBB4556790]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Address1(System.String)
       mov       rdx,[rbx+10]
       mov       rcx,rsi
       call      qword ptr [7FFBB45567A8]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Address2(System.String)
       mov       rdx,[rbx+18]
       mov       rcx,rsi
       call      qword ptr [7FFBB45567C0]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_City(System.String)
       mov       rdx,[rbx+20]
       mov       rcx,rsi
       call      qword ptr [7FFBB45567D8]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Country(System.String)
       mov       rdx,[rbx+28]
       mov       rcx,rsi
       call      qword ptr [7FFBB45567F0]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_CountyProvince(System.String)
       mov       rdx,[rbx+30]
       mov       rcx,rsi
       call      qword ptr [7FFBB4556808]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_Phone(System.String)
       mov       rdx,[rbx+38]
       mov       rcx,rsi
       call      qword ptr [7FFBB4556820]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_PostalCode(System.String)
       mov       rdx,[rbx+40]
       mov       rcx,rsi
       call      qword ptr [7FFBB4556838]; DotNetTips.Spargine.Tester.Models.RefTypes.Address.set_State(System.String)
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M15_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M15_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M15_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M15_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M15_L01
M15_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M15_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M15_L01
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
       je        near ptr M16_L01
       mov       edi,[rbx+8]
       test      edi,edi
       je        near ptr M16_L01
       test      rsi,rsi
       je        short M16_L00
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        short M16_L00
       mov       r14d,edi
       lea       edx,[r14+rbp]
       test      edx,edx
       jl        near ptr M16_L04
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r15
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L00:
       mov       rax,rbx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L01:
       test      rsi,rsi
       je        short M16_L02
       mov       ebp,[rsi+8]
       test      ebp,ebp
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M16_L03
M16_L02:
       mov       rax,2014F390008
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L03:
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M16_L04:
       call      qword ptr [7FFBB45C4E40]
       int       3
; Total bytes of code 231
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M17_L01
       cmp       [rax],ecx
       jle       short M17_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M17_L03
M17_L00:
       add       rsp,20
       pop       rbx
       ret
M17_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M17_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M17_L00
M17_L02:
       cmp       [rax+4],edx
       jle       short M17_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M17_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M17_L03
       jmp       short M17_L00
M17_L03:
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
       jl        near ptr M18_L03
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],8
       jle       near ptr M18_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+40]
       test      rax,rax
       je        near ptr M18_L04
M18_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       jne       short M18_L01
       call      qword ptr [7FFBB4554E70]; System.Random+ThreadSafeRandom.Create()
       mov       rcx,rax
M18_L01:
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
       jb        short M18_L05
M18_L02:
       mov       rax,r8
       shr       rax,20
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M18_L03:
       mov       ecx,21AC
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB412C030]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFBB45C5050]
       int       3
M18_L04:
       mov       ecx,8
       call      qword ptr [7FFBB45CC600]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M18_L00
M18_L05:
       mov       eax,ebx
       neg       eax
       xor       edx,edx
       div       ebx
       cmp       r10d,edx
       jae       short M18_L02
M18_L06:
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
       jb        short M18_L06
       jmp       near ptr M18_L02
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
       call      qword ptr [7FFC171C5730]
       cmp       byte ptr [rax],0
       jne       short M19_L00
       mov       rcx,rbx
       call      qword ptr [7FFC171C7868]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFC171C56E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       test      rax,rax
       jne       short M19_L02
M19_L00:
       mov       rcx,rbx
       call      qword ptr [7FFC171C7870]
       mov       rcx,rax
       mov       rdx,rsi
       call      qword ptr [7FFC171C56E8]; Precode of System.Runtime.CompilerServices.CastHelpers.IsInstanceOfAny(Void*, System.Object)
       mov       rdi,rax
       test      rdi,rdi
       jne       short M19_L01
       mov       rcx,rbx
       call      qword ptr [7FFC171C8220]
       mov       rcx,rax
       mov       rdx,rsi
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M19_L01:
       mov       rcx,rbx
       call      qword ptr [7FFC171C8218]
       mov       rcx,rax
       mov       rdx,rdi
       lea       rax,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M19_L02:
       mov       rcx,rax
       lea       r11,[System.Linq.Enumerable.Select[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,System.__Canon>)]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [r11]
; Total bytes of code 168
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+40]
       cmp       dword ptr [rcx+238],2
       jle       short M20_L02
       mov       rcx,[rcx+240]
       mov       rax,[rcx+10]
       test      rax,rax
       je        short M20_L02
M20_L00:
       mov       rax,[rax+10]
       test      rax,rax
       jne       short M20_L01
       mov       rax,1C0BA400110
       mov       rax,[rax]
       test      rax,rax
       jne       short M20_L01
       mov       rax,1C0BA4000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M20_L03
M20_L01:
       add       rsp,28
       ret
M20_L02:
       mov       ecx,2
       call      qword ptr [7FFBB45CC600]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M20_L00
M20_L03:
       add       rsp,28
       jmp       qword ptr [7FFBB4126688]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
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
       call      qword ptr [7FFC0D88BC80]
       mov       rcx,rax
       call      qword ptr [7FFC0D889080]; CORINFO_HELP_NEWFAST
       mov       rsi,rax
       mov       rcx,[rsi]
       call      qword ptr [7FFC0D88C570]
       mov       rcx,rax
       call      qword ptr [7FFC0D8890A0]; Precode of System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rdx,[rax]
       lea       rcx,[rsi+8]
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
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
       je        short M22_L00
       cmp       [rdx],rcx
       jne       short M22_L01
M22_L00:
       mov       rax,rdx
       ret
M22_L01:
       jmp       qword ptr [7FFBB3F0FD20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacterMinMax()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       xor       ecx,ecx
       mov       edx,0FFFF
       call      qword ptr [7FFBB4544E40]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+90]
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
       mov       rax,7FFBB4354D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45BC978]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42850C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45BC2A0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateEnum()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
M00_L00:
       mov       rsi,1C760D90538
       mov       rcx,offset MT_System.DayOfWeek
       call      00007FFC13B51A90
       add       eax,0FFFFFFFD
       cmp       eax,5
       jne       short M00_L01
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L02
       mov       rax,rdi
       jmp       short M00_L03
M00_L01:
       cmp       eax,16
       ja        near ptr M00_L10
       mov       ecx,eax
       lea       rdx,[7FFBB3FB8838]
       mov       edx,[rdx+rcx*4]
       lea       rax,[M00_L00]
       add       rdx,rax
       jmp       rdx
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D5590]
       mov       rdi,[rax+8]
       jmp       short M00_L07
M00_L02:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L03:
       mov       rcx,[rax+80]
       test      rcx,rcx
       je        near ptr M00_L08
       mov       rdx,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       [rcx],rdx
       je        short M00_L04
       mov       rdx,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       [rcx],rdx
       jne       near ptr M00_L08
       mov       rax,[rcx+28]
       jmp       short M00_L05
M00_L04:
       mov       rax,rcx
M00_L05:
       test      rax,rax
       je        near ptr M00_L09
M00_L06:
       mov       rdi,[rax+8]
M00_L07:
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45567C0]; System.Array.get_Length()
       movsxd    rdx,eax
       mov       rcx,offset MT_System.DayOfWeek[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       mov       rcx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45567C0]; System.Array.get_Length()
       mov       r8d,eax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBB3F07048]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       edi,[rsi+8]
       test      edi,edi
       je        near ptr M00_L49
       mov       edx,edi
       xor       ecx,ecx
       call      qword ptr [7FFBB4554678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L51
       mov       ecx,eax
       mov       ecx,[rsi+rcx*4+10]
       mov       [rsp+28],ecx
       mov       rcx,[rbx+90]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455E6A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.DayOfWeek, System.Private.CoreLib]](System.DayOfWeek ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L08:
       xor       eax,eax
       jmp       near ptr M00_L05
M00_L09:
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB412E0D0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       near ptr M00_L06
M00_L10:
       call      qword ptr [7FFBB45D5920]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L11
       mov       rax,rdi
       jmp       short M00_L12
M00_L11:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L12:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L14
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L13
       jmp       short M00_L15
M00_L13:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L14
       mov       rax,[rax+28]
       jmp       short M00_L15
M00_L14:
       xor       eax,eax
M00_L15:
       test      rax,rax
       jne       short M00_L16
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D55D8]
M00_L16:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L17
       mov       rax,rdi
       jmp       short M00_L18
M00_L17:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L18:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L20
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.Byte>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L19
       jmp       short M00_L21
M00_L19:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L20
       mov       rax,[rax+28]
       jmp       short M00_L21
M00_L20:
       xor       eax,eax
M00_L21:
       test      rax,rax
       jne       short M00_L22
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D55D8]
M00_L22:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L23
       mov       rax,rdi
       jmp       short M00_L24
M00_L23:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L24:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L26
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L25
       jmp       short M00_L27
M00_L25:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L26
       mov       rax,[rax+28]
       jmp       short M00_L27
M00_L26:
       xor       eax,eax
M00_L27:
       test      rax,rax
       jne       short M00_L28
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D56B0]
M00_L28:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L29
       mov       rax,rdi
       jmp       short M00_L30
M00_L29:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L30:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L32
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt16>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L31
       jmp       short M00_L33
M00_L31:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L32
       mov       rax,[rax+28]
       jmp       short M00_L33
M00_L32:
       xor       eax,eax
M00_L33:
       test      rax,rax
       jne       short M00_L34
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D56B0]
M00_L34:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L35
       mov       rax,rdi
       jmp       short M00_L36
M00_L35:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L36:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L38
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt32>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L37
       jmp       short M00_L39
M00_L37:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L38
       mov       rax,[rax+28]
       jmp       short M00_L39
M00_L38:
       xor       eax,eax
M00_L39:
       test      rax,rax
       jne       short M00_L40
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB412E0D0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
M00_L40:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,186CA0B1120
       mov       rdi,[rcx]
       test      rdi,rdi
       je        short M00_L41
       mov       rax,rdi
       jmp       short M00_L42
M00_L41:
       mov       rcx,rsi
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
M00_L42:
       mov       rdi,[rax+80]
       test      rdi,rdi
       je        short M00_L44
       mov       rdx,rdi
       mov       rcx,offset MT_System.Enum+EnumInfo<System.UInt64>
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L43
       jmp       short M00_L45
M00_L43:
       mov       rdx,rdi
       mov       rcx,offset MT_System.RuntimeType+CompositeCacheEntry
       call      System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       je        short M00_L44
       mov       rax,[rax+28]
       jmp       short M00_L45
M00_L44:
       xor       eax,eax
M00_L45:
       test      rax,rax
       jne       short M00_L46
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D5758]
M00_L46:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt64>>
       mov       rdx,rsi
       call      qword ptr [7FFBB45D68B0]
       test      rax,rax
       jne       short M00_L47
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D5758]
M00_L47:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UIntPtr>>
       mov       rdx,rsi
       call      qword ptr [7FFBB45D68B0]
       test      rax,rax
       jne       short M00_L48
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D57B8]
M00_L48:
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D53C8]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D5458]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
       mov       rcx,rsi
       xor       edx,edx
       call      qword ptr [7FFBB45D5440]
       mov       rdi,[rax+8]
       jmp       near ptr M00_L07
M00_L49:
       mov       rcx,186CBC00100
       mov       rcx,[rcx]
       mov       rdx,186CBC01300
       mov       rdx,[rdx]
       mov       r8,186CBC01AF0
       mov       r8,[r8]
       call      qword ptr [7FFBB4556790]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L50
       call      qword ptr [7FFBB45D68C8]
       mov       rbx,rax
M00_L50:
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBB4296370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L51:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1366
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
       call      00007FFC13B461E0
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
       mov       rax,7FFBB4041B50
       mov       [rbp-78],rax
       lea       rax,[M01_L03]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC13A1A0F0
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L04
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      00007FFC13B5EA20
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
       call      qword ptr [7FFBB45D7078]; System.RuntimeTypeHandle.GetGCHandle(System.Runtime.InteropServices.GCHandleType)
       mov       rdx,rax
       lea       rcx,[rbx+10]
       xor       eax,eax
       lock cmpxchg [rcx],rdx
       test      rax,rax
       je        near ptr M01_L00
       lea       rcx,[rbp-40]
       call      qword ptr [7FFBB45D5BA8]
       jmp       near ptr M01_L00
M01_L09:
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L10:
       mov       [rbp+10],rbx
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07C90]; System.RuntimeTypeHandle.<GetModule>g__GetModuleWorker|48_0(System.RuntimeType)
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
; System.Array.get_Length()
       sub       rsp,28
       mov       eax,[rcx+8]
       test      eax,eax
       jl        short M02_L00
       add       rsp,28
       ret
M02_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 22
```
```assembly
; System.Array.Copy(System.Array, System.Array, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       ebx,r8d
       test      rcx,rcx
       je        near ptr M03_L18
       test      rdx,rdx
       je        short M03_L00
       mov       r8,[rcx]
       cmp       r8,[rdx]
       je        near ptr M03_L16
M03_L00:
       mov       rax,[rcx]
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       jne       near ptr M03_L12
       xor       esi,esi
M03_L01:
       mov       rdi,rcx
M03_L02:
       test      rdx,rdx
       je        near ptr M03_L19
       mov       rcx,[rdx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M03_L13
       xor       ebp,ebp
M03_L03:
       mov       r14,rdx
M03_L04:
       test      rdi,rdi
       je        near ptr M03_L20
       test      r14,r14
       je        near ptr M03_L21
       mov       r15,[rdi]
       mov       r13,[r14]
       cmp       r15,r13
       je        short M03_L05
       mov       rcx,r15
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       mov       eax,1
       test      ecx,ecx
       cmove     ecx,eax
       mov       rax,r13
       mov       eax,[rax+4]
       add       eax,0FFFFFFE8
       shr       eax,3
       mov       edx,1
       test      eax,eax
       cmove     eax,edx
       cmp       ecx,eax
       jne       near ptr M03_L22
M03_L05:
       test      ebx,ebx
       jl        near ptr M03_L23
       mov       rcx,r15
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M03_L14
       xor       r12d,r12d
M03_L06:
       cmp       esi,r12d
       jl        near ptr M03_L24
       sub       esi,r12d
       js        near ptr M03_L25
       lea       ecx,[rsi+rbx]
       cmp       ecx,[rdi+8]
       ja        near ptr M03_L25
       mov       rcx,r13
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       near ptr M03_L15
       xor       r12d,r12d
M03_L07:
       cmp       ebp,r12d
       jl        near ptr M03_L26
       sub       ebp,r12d
       js        near ptr M03_L27
       lea       ecx,[rbx+rbp]
       cmp       ecx,[r14+8]
       ja        near ptr M03_L27
       cmp       r15,r13
       je        short M03_L08
       mov       rcx,rdi
       mov       rdx,r14
       call      qword ptr [7FFBB4556838]; System.Array.CanAssignArrayType(System.Array, System.Array)
       test      eax,eax
       jne       near ptr M03_L38
M03_L08:
       mov       rcx,r15
       movzx     edx,word ptr [rcx]
       mov       r8d,ebx
       imul      r8,rdx
       add       rdi,8
       mov       eax,[r15+4]
       add       rax,0FFFFFFFFFFFFFFF0
       add       rax,rdi
       mov       r10d,esi
       imul      r10,rdx
       add       r10,rax
       add       r14,8
       mov       eax,[r13+4]
       add       rax,0FFFFFFFFFFFFFFF0
       add       rax,r14
       mov       r9d,ebp
       imul      rdx,r9
       add       rdx,rax
       test      dword ptr [rcx],1000000
       jne       near ptr M03_L28
       mov       rcx,rdx
       mov       rax,r10
       mov       r9,r8
       mov       r11,rcx
       sub       r11,rax
       cmp       r11,r9
       jb        near ptr M03_L36
       mov       r11,rax
       sub       r11,rcx
       cmp       r11,r9
       jb        near ptr M03_L36
       lea       r11,[rax+r9]
       lea       r12,[rcx+r9]
       cmp       r9,10
       jbe       near ptr M03_L30
       cmp       r9,40
       ja        near ptr M03_L33
M03_L09:
       vmovups   xmm0,[rax]
       vmovups   [rcx],xmm0
       cmp       r9,20
       ja        near ptr M03_L29
M03_L10:
       vmovups   xmm0,[r11-10]
       vmovups   [r12-10],xmm0
M03_L11:
       vzeroupper
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
M03_L12:
       cdqe
       mov       esi,[rcx+rax*4+10]
       jmp       near ptr M03_L01
M03_L13:
       movsxd    rcx,ecx
       mov       ebp,[rdx+rcx*4+10]
       jmp       near ptr M03_L03
M03_L14:
       movsxd    rcx,ecx
       mov       r12d,[rdi+rcx*4+10]
       jmp       near ptr M03_L06
M03_L15:
       movsxd    rcx,ecx
       mov       r12d,[r14+rcx*4+10]
       jmp       near ptr M03_L07
M03_L16:
       cmp       dword ptr [r8+4],18
       jne       near ptr M03_L00
       cmp       ebx,[rcx+8]
       ja        near ptr M03_L00
       cmp       ebx,[rdx+8]
       ja        near ptr M03_L00
       mov       eax,ebx
       movzx     r10d,word ptr [r8]
       imul      r10,rax
       add       rcx,10
       mov       rax,rcx
       lea       rcx,[rdx+10]
       test      dword ptr [r8],1000000
       je        short M03_L17
       mov       rdx,rax
       mov       r8,r10
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M03_L17:
       mov       rdx,rax
       mov       r8,r10
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M03_L11
M03_L18:
       xor       edi,edi
       xor       esi,esi
       jmp       near ptr M03_L02
M03_L19:
       xor       r14d,r14d
       xor       ebp,ebp
       jmp       near ptr M03_L04
M03_L20:
       mov       ecx,12D
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       rcx,rax
       call      qword ptr [7FFBB45D48B8]
       int       3
M03_L21:
       mov       ecx,145
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       rcx,rax
       call      qword ptr [7FFBB45D48B8]
       int       3
M03_L22:
       mov       rcx,offset MT_System.RankException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45D5998]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45D59B0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L23:
       mov       ecx,0B3
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       rdx,rax
       mov       ecx,ebx
       call      qword ptr [7FFBB45D4888]
       int       3
M03_L24:
       mov       ecx,167
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       r8,rax
       mov       edx,r12d
       mov       ecx,esi
       call      qword ptr [7FFBB45D5950]
       int       3
M03_L25:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45D59C8]
       mov       rsi,rax
       mov       ecx,12D
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB4296418]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L26:
       mov       ecx,17F
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       r8,rax
       mov       edx,r12d
       mov       ecx,ebp
       call      qword ptr [7FFBB45D5950]
       int       3
M03_L27:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45D59E0]
       mov       rsi,rax
       mov       ecx,145
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB4296418]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L28:
       mov       rcx,rdx
       mov       rdx,r10
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F057A0]; System.Buffer.BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
M03_L29:
       vmovups   xmm0,[rax+10]
       vmovups   [rcx+10],xmm0
       cmp       r9,30
       jbe       near ptr M03_L10
       vmovups   xmm0,[rax+20]
       vmovups   [rcx+20],xmm0
       jmp       near ptr M03_L10
M03_L30:
       test      r8b,18
       je        short M03_L31
       mov       r10,[r10]
       mov       [rdx],r10
       mov       rdx,[r11-8]
       mov       [r12-8],rdx
       jmp       near ptr M03_L11
M03_L31:
       test      r8b,4
       je        short M03_L32
       mov       r8d,[r10]
       mov       [rdx],r8d
       mov       r10d,[r11-4]
       mov       [r12-4],r10d
       jmp       near ptr M03_L11
M03_L32:
       test      r8,r8
       je        near ptr M03_L11
       movzx     r10d,byte ptr [r10]
       mov       [rdx],r10b
       test      r8b,2
       je        near ptr M03_L11
       movsx     rdx,word ptr [r11-2]
       mov       [r12-2],dx
       jmp       near ptr M03_L11
M03_L33:
       cmp       r9,800
       ja        near ptr M03_L37
       cmp       r9,100
       jb        short M03_L34
       mov       rax,rdx
       and       rax,3F
       mov       r9,rax
       neg       r9
       add       r9,40
       vmovdqu   ymm0,ymmword ptr [r10]
       vmovdqu   ymmword ptr [rdx],ymm0
       vmovdqu   ymm0,ymmword ptr [r10+20]
       vmovdqu   ymmword ptr [rdx+20],ymm0
       lea       rax,[r10+r9]
       lea       rcx,[rdx+r9]
       sub       r8,r9
       mov       r9,r8
M03_L34:
       mov       r10,r9
       shr       r10,6
M03_L35:
       vmovdqu   ymm0,ymmword ptr [rax]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rax+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rax,40
       dec       r10
       jne       short M03_L35
       and       r9,3F
       cmp       r9,10
       ja        near ptr M03_L09
       jmp       near ptr M03_L10
M03_L36:
       cmp       rdx,r10
       jne       short M03_L37
       cmp       [r10],r10b
       jmp       near ptr M03_L11
M03_L37:
       cmp       [rdx],dl
       cmp       [r10],r10b
       mov       rcx,rdx
       mov       rdx,r10
       vzeroupper
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       jmp       qword ptr [7FFBB3F066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
M03_L38:
       mov       [rsp+20],ebx
       mov       [rsp+28],eax
       mov       rcx,rdi
       mov       edx,esi
       mov       r8,r14
       mov       r9d,ebp
       call      qword ptr [7FFBB45D5A28]
       jmp       near ptr M03_L11
; Total bytes of code 1410
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
       jge       near ptr M04_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M04_L05
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
M04_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4354D88
       mov       [rbp-70],rax
       lea       rax,[M04_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M04_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M04_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M04_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M04_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M04_L00
       add       eax,ebx
M04_L03:
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
M04_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45D5AE8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4294528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M04_L05:
       mov       eax,ebx
       jmp       short M04_L03
M04_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4A68]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.DayOfWeek, System.Private.CoreLib]](System.DayOfWeek ByRef)
       mov       rcx,rdx
       jmp       qword ptr [7FFBB455E6E8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DayOfWeek, System.Private.CoreLib]](System.DayOfWeek ByRef)
; Total bytes of code 9
```
```assembly
; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      dl,dl
       jne       short M06_L04
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        near ptr M06_L05
       mov       rax,[rcx]
       test      rax,rax
       je        near ptr M06_L05
M06_L00:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M06_L03
       mov       rcx,[rdx]
       mov       rax,offset MT_System.Enum+EnumInfo<System.UInt32>
       cmp       rcx,rax
       je        short M06_L01
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M06_L03
       mov       rax,[rdx+28]
       test      rax,rax
       je        short M06_L03
       jmp       short M06_L02
M06_L01:
       mov       rax,rdx
M06_L02:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L03:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FFBB3F0C510]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       jmp       short M06_L02
M06_L04:
       mov       rcx,rbx
       mov       edx,1
       call      qword ptr [7FFBB412E0E8]; System.Enum+EnumInfo`1[[System.UInt32, System.Private.CoreLib]].Create(System.RuntimeType, Boolean)
       mov       rsi,rax
       cmp       [rbx],bl
       mov       r8,rsi
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.Enum+EnumInfo<System.UInt32>>
       call      qword ptr [7FFBB412E1F0]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].Replace(System.RuntimeType, System.__Canon)
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M06_L05:
       mov       rcx,rbx
       call      qword ptr [7FFBB3F07C48]; System.RuntimeType.InitializeCache()
       jmp       near ptr M06_L00
; Total bytes of code 190
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rdx,rdx
       je        short M07_L00
       cmp       [rdx],rcx
       jne       short M07_L01
M07_L00:
       mov       rax,rdx
       ret
M07_L01:
       mov       rax,[rdx]
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
M07_L02:
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       test      rax,rax
       je        short M07_L03
       mov       rax,[rax+10]
       cmp       rax,rcx
       je        short M07_L00
       jmp       short M07_L02
M07_L03:
       xor       edx,edx
       jmp       short M07_L00
; Total bytes of code 88
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,17BD6801328
       mov       rsi,[rcx]
       cmp       qword ptr [rsi+8],0
       je        near ptr M00_L24
       mov       rdi,[rsi+18]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rdi],rcx
       jne       near ptr M00_L14
       mov       rcx,1BC6B85B8D8
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
       je        near ptr M00_L12
M00_L00:
       mov       rbp,[rcx]
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       jne       near ptr M00_L13
       mov       rcx,rbp
       call      00007FFC13B13FE0
       test      eax,eax
       je        near ptr M00_L09
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
       jae       near ptr M00_L27
       mov       edx,edx
       lea       rcx,[rcx+rdx*4+10]
       mov       r14d,[rcx]
       mov       rsi,[rsi+10]
       xor       r15d,r15d
       dec       r14d
       mov       r13d,[rsi+8]
       cmp       r13d,r14d
       jbe       near ptr M00_L24
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rdi],rcx
       jne       near ptr M00_L11
M00_L04:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rsi+rcx*8+10]
       cmp       [r12+10],ebp
       jne       near ptr M00_L10
       mov       rax,[r12]
       test      rax,rax
       je        near ptr M00_L10
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [rax],rcx
       jne       near ptr M00_L15
       mov       rcx,1BC6B85B8D8
       cmp       rax,rcx
       sete      r8b
       movzx     r8d,r8b
M00_L05:
       test      r8d,r8d
       je        near ptr M00_L10
M00_L06:
       add       r12,8
M00_L07:
       test      r12,r12
       je        near ptr M00_L26
       mov       rax,[r12]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       test      rcx,rcx
       je        short M00_L08
       mov       r8,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Person
       cmp       [rcx],r8
       jne       near ptr M00_L25
M00_L08:
       mov       [rsp+30],rcx
       mov       rbx,[rbx+90]
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
M00_L09:
       mov       rcx,rbp
       call      qword ptr [7FFBB3F0E988]; System.Runtime.CompilerServices.RuntimeHelpers.<GetHashCode>g__GetHashCodeWorker|15_0(System.Object)
       jmp       near ptr M00_L01
M00_L10:
       mov       r14d,[r12+14]
       inc       r15d
       mov       r13d,[rsi+8]
       cmp       r13d,r15d
       jb        near ptr M00_L23
       cmp       r13d,r14d
       jbe       near ptr M00_L24
       jmp       near ptr M00_L04
M00_L11:
       mov       ecx,r14d
       lea       rcx,[rcx+rcx*2]
       lea       r12,[rsi+rcx*8+10]
       cmp       [r12+10],ebp
       jne       near ptr M00_L18
       jmp       short M00_L16
M00_L12:
       xor       ebp,ebp
       jmp       near ptr M00_L02
M00_L13:
       mov       rcx,rbp
       mov       rax,[rbp]
       mov       rax,[rax+40]
       call      qword ptr [rax+18]
       mov       ebp,eax
       jmp       near ptr M00_L02
M00_L14:
       mov       rcx,rdi
       mov       r11,7FFBB3E50D30
       mov       rdx,1BC6B85B8D8
       call      qword ptr [r11]
       mov       ebp,eax
       jmp       near ptr M00_L03
M00_L15:
       mov       rcx,rax
       mov       rdx,1BC6B85B8D8
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       mov       r8d,eax
       jmp       near ptr M00_L05
M00_L16:
       mov       rax,[r12]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Type>
       cmp       [rdi],rcx
       je        short M00_L17
       mov       rcx,rdi
       mov       rdx,rax
       mov       r11,7FFBB3E50D38
       mov       r8,1BC6B85B8D8
       call      qword ptr [r11]
       mov       r8d,eax
       jmp       short M00_L21
M00_L17:
       test      rax,rax
       jne       short M00_L19
M00_L18:
       mov       r14d,[r12+14]
       inc       r15d
       mov       r13d,[rsi+8]
       cmp       r13d,r15d
       jae       short M00_L22
       jmp       short M00_L23
M00_L19:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country
       cmp       [rax],rcx
       je        short M00_L20
       mov       rcx,rax
       mov       rdx,1BC6B85B8D8
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       mov       r8d,eax
       jmp       short M00_L21
M00_L20:
       mov       rcx,1BC6B85B8D8
       cmp       rax,rcx
       sete      r8b
       movzx     r8d,r8b
M00_L21:
       test      r8d,r8d
       jne       near ptr M00_L06
       jmp       short M00_L18
M00_L22:
       cmp       r13d,r14d
       jbe       short M00_L24
       jmp       near ptr M00_L11
M00_L23:
       call      qword ptr [7FFBB4127A08]
       int       3
M00_L24:
       xor       r12d,r12d
       jmp       near ptr M00_L07
M00_L25:
       mov       rdx,rax
       mov       rcx,r8
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M00_L26:
       call      qword ptr [7FFBB4125DE8]; System.Globalization.CultureInfo.get_CurrentCulture()
       mov       rbx,rax
       mov       rcx,offset MT_System.NotSupportedException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,1BC6B85B8D8
       call      qword ptr [7FFBB3E4A310]; Precode of System.RuntimeType.get_FullName()
       mov       rdi,rax
       mov       ecx,53B
       mov       rdx,7FFBB41E4458
       call      qword ptr [7FFBB4127798]
       mov       [rsp+20],rax
       mov       r9,rdi
       mov       r8,17BD6801308
       mov       r8,[r8]
       mov       rdx,rbx
       mov       rcx,7FFBB43568D8
       call      qword ptr [7FFBB4345248]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB41277B0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L27:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 976
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
       je        short M01_L03
       mov       rcx,7FFBB45FADB4
       call      CORINFO_HELP_COUNTPROFILE32
       lea       rcx,[rbp+10]
       mov       rax,7FFBB4059CB0
       mov       [rbp-60],rax
       lea       rax,[M01_L00]
       mov       [rbp-50],rax
       lea       rax,[rbp-70]
       mov       [rbx+8],rax
       mov       byte ptr [rbx+4],0
       mov       rax,7FFC13B443B0
       call      rax
M01_L00:
       mov       byte ptr [rbx+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M01_L01:
       mov       rcx,[rbp-68]
       mov       [rbx+8],rcx
M01_L02:
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
M01_L03:
       mov       rcx,7FFBB45FADB0
       call      CORINFO_HELP_COUNTPROFILE32
       xor       eax,eax
       jmp       short M01_L02
; Total bytes of code 195
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
       jmp       qword ptr [7FFBB3F0FD20]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
; Total bytes of code 20
```
```assembly
; System.Globalization.CultureInfo.get_CurrentCulture()
       sub       rsp,28
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
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
       mov       rax,17BD6800110
       mov       rax,[rax]
       test      rax,rax
       jne       short M03_L01
       mov       rax,17BD68000F0
       mov       rax,[rax]
       test      rax,rax
       je        short M03_L03
M03_L01:
       add       rsp,28
       ret
M03_L02:
       mov       ecx,2
       call      qword ptr [7FFBB45D4BA0]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       short M03_L00
M03_L03:
       add       rsp,28
       jmp       qword ptr [7FFBB4125E00]; System.Globalization.CultureInfo.InitializeUserDefaultCulture()
; Total bytes of code 115
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rsi,[rbx+1A8]
       mov       ecx,0A
       call      qword ptr [7FFBB455E7C0]; DotNetTips.Spargine.Tester.RandomData.GenerateFileNameWord(Int32)
       mov       rdi,rax
       mov       rcx,offset MT_System.String
       mov       edx,1
       call      00007FFC13B952E0
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
       call      00007FFC13B952E0
       mov       r12,rax
       cmp       [r12],r12b
       lea       rax,[r12+0C]
       mov       [rsp+28],rax
       mov       rcx,rax
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rdi,[rsp+28]
       lea       rcx,[rdi+r13*2]
       mov       r8d,r15d
       add       r8,r8
       lea       rdx,[rbp+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r14d,r15d
       movsxd    rax,r14d
       lea       rax,[rdi+rax*2]
       vmovups   xmm0,[7FFBB3FB8220]
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
       call      qword ptr [7FFBB412D908]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
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
       mov       rcx,2A598FF7394
       mov       [rsp+50],rdi
       mov       [rsp+58],esi
       mov       [rsp+40],rcx
       mov       dword ptr [rsp+48],1
       mov       [rsp+30],rbp
       mov       [rsp+38],r12d
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       lea       r8,[rsp+30]
       call      qword ptr [7FFBB412D938]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r12,rax
       jmp       short M00_L03
M00_L02:
       mov       [rsp+50],rdi
       mov       [rsp+58],esi
       mov       [rsp+40],rbp
       mov       [rsp+48],r12d
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+40]
       call      qword ptr [7FFBB429DB90]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r12,rax
M00_L03:
       jmp       short M00_L05
M00_L04:
       mov       r12,rsi
M00_L05:
       mov       [rsp+60],r12
       mov       rbx,[rbx+90]
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
       mov       rdx,2A599000E28
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       jmp       near ptr M00_L00
M00_L07:
       mov       rcx,rdi
       mov       rdx,2A599000E28
       call      qword ptr [7FFBB3F07858]; System.String.Concat(System.String, System.String)
       mov       r12,rax
       jmp       near ptr M00_L00
M00_L08:
       call      qword ptr [7FFBB45D50F8]
       int       3
M00_L09:
       mov       ecx,1C47E
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       rcx,rax
       call      qword ptr [7FFBB45D48A0]
       int       3
M00_L10:
       mov       ecx,1C48A
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB4127798]
       mov       rcx,rax
       call      qword ptr [7FFBB45D48A0]
       int       3
M00_L11:
       mov       ecx,1
       jmp       near ptr M00_L01
; Total bytes of code 710
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
       mov       rax,0BE6553C912E7
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
       call      qword ptr [7FFBB43451B8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+18],rcx
M01_L02:
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		var charBuffer = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,26504000C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFBB41CFB68]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB41CFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
       mov       rax,rbx
       mov       r8,0BE6553C912E7
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
       call      qword ptr [7FFBB4077198]
       int       3
       sub       rsp,28
       mov       rcx,26504000C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFBB3F066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      00007FFC13B952E0
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
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+r15]
       sub       r12d,ebp
       cmp       esi,r12d
       ja        short M04_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A598FF0008
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
       call      qword ptr [7FFBB434D2D8]
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
       call      qword ptr [7FFC0D89B9F0]; Precode of System.String.FastAllocateString(IntPtr)
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
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M05_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0D89F2C0]
       int       3
M05_L02:
       call      qword ptr [7FFC0D888FD0]
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
       call      00007FFC13B952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,2A598FF0008
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
       call      qword ptr [7FFBB45D50F8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateBoolean()
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
       mov       [rbp-3C],eax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-80]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-68],rdx
       mov       rdx,rbp
       mov       [rbp-58],rdx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4354D88
       mov       [rbp-70],rax
       lea       rax,[M00_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-78]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       short M00_L03
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       ecx,[rbp-3C]
       and       ecx,1
       cmp       ecx,1
       ja        short M00_L00
       cmp       ecx,1
       sete      cl
       movzx     ecx,cl
       mov       rbx,[rbp+10]
       mov       rax,[rbx+90]
       mov       [rax+4C],cl
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
M00_L03:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4A50]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 250
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCharacter()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,61
       mov       edx,7A
       call      qword ptr [7FFBB45241C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,0FFFF
       ja        short M00_L00
       mov       rcx,[rbx+90]
       mov       [rcx+48],ax
       add       rsp,20
       pop       rbx
       ret
M00_L00:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 54
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
       mov       rax,7FFBB4344D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45C5350]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4284528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45C4978]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCompanyName()
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
       lea       rbp,[rsp+1A0]
       xor       eax,eax
       mov       [rbp-158],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-150],xmm4
       vmovdqa   xmmword ptr [rbp-140],xmm4
       mov       rax,0FFFFFFFFFFFFFF10
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-148]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-130],rcx
       mov       rcx,rbp
       mov       [rbp-120],rcx
       mov       rcx,offset MT_System.String[]
       mov       [rbp-110],rcx
       lea       rcx,[rbp-110]
       mov       dword ptr [rcx+8],0A
       lea       rdi,[rbp-110]
       mov       rcx,200F2430330
       mov       [rdi+10],rcx
       mov       rcx,200F2430350
       mov       [rdi+18],rcx
       mov       rcx,200F2430370
       mov       [rdi+20],rcx
       mov       rcx,200F2430390
       mov       [rdi+28],rcx
       mov       rcx,200F24303B0
       mov       [rdi+30],rcx
       mov       rcx,200F24303D0
       mov       [rdi+38],rcx
       mov       rcx,200F24303F8
       mov       [rdi+40],rcx
       mov       rcx,200F2430428
       mov       [rdi+48],rcx
       mov       rcx,200F2430450
       mov       [rdi+50],rcx
       mov       rcx,200F2430480
       mov       [rdi+58],rcx
       mov       byte ptr [rbp-68],1
       mov       dword ptr [rbp-64],1
       mov       byte ptr [rbp-68],1
       mov       dword ptr [rbp-64],1
       mov       ecx,5
       mov       edx,0C
       call      qword ptr [7FFBB4554678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4555008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r14,rax
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,1C05D400C88
       mov       r15,[rcx]
       mov       rcx,1C05D400C90
       mov       r13,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L10
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L10
M00_L01:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L12
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L12
       mov       r12,[rcx+50]
       test      r12,r12
       je        near ptr M00_L12
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [r13+9D],0
       jne       near ptr M00_L11
M00_L02:
       mov       [rbp-58],r12
       lea       rcx,[r12+10]
       mov       edx,[r12+8]
       mov       [rbp-48],rcx
       mov       [rbp-40],edx
       xor       ecx,ecx
       mov       [rbp-50],ecx
       mov       byte ptr [rbp-4C],0
       mov       r15d,[r14+8]
       test      r15d,r15d
       je        near ptr M00_L32
       movzx     edx,word ptr [r14+0C]
       cmp       edx,7F
       jg        near ptr M00_L26
       mov       ecx,edx
       lea       r8d,[rcx-61]
       and       edx,5F
       cmp       r8d,19
       cmovbe    ecx,edx
       mov       edx,ecx
M00_L03:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBB4556310]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rdx,[r14+0E]
       dec       r15d
       mov       r8d,[rbp-50]
       mov       ecx,[rbp-40]
       cmp       r8d,ecx
       ja        near ptr M00_L28
       mov       rax,[rbp-48]
       mov       r10d,r8d
       lea       rax,[rax+r10*2]
       sub       ecx,r8d
       cmp       r15d,ecx
       ja        near ptr M00_L27
       mov       r8d,r15d
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rbp-50]
       mov       [rbp-50],r15d
M00_L04:
       mov       ecx,[rbp-50]
       mov       edx,[rbp-40]
       cmp       ecx,edx
       ja        near ptr M00_L28
       mov       rax,[rbp-48]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L29
       mov       word ptr [rax],20
       mov       ecx,[rbp-50]
       inc       ecx
       mov       [rbp-50],ecx
M00_L05:
       xor       edx,edx
       mov       [rbp-90],edx
M00_L06:
       lea       rdx,[rbp-90]
       mov       [rbp-98],rdx
       lea       rdx,[rbp-90]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4354D88
       mov       [rbp-138],rax
       lea       rax,[M00_L07]
       mov       [rbp-128],rax
       lea       rax,[rbp-148]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L07:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L08
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L08:
       mov       rcx,[rbp-140]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L30
       xor       ecx,ecx
       mov       [rbp-98],rcx
       mov       [rbp-98],rcx
       mov       ecx,[rbp-90]
       and       ecx,0F
       cmp       ecx,9
       ja        near ptr M00_L06
       mov       ecx,ecx
       mov       rsi,[rdi+rcx*8+10]
       cmp       byte ptr [rbp-4C],0
       jne       near ptr M00_L31
       test      rsi,rsi
       je        near ptr M00_L31
       lea       rcx,[rbp-48]
       lea       rdx,[rbp-0A8]
       mov       r8d,[rbp-50]
       call      qword ptr [7FFBB434D410]; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32)
       lea       rdx,[rbp-0A8]
       mov       rcx,rsi
       call      qword ptr [7FFBB45D6628]; System.String.TryCopyTo(System.Span`1<Char>)
       test      eax,eax
       je        near ptr M00_L31
       mov       ecx,[rbp-50]
       add       ecx,[rsi+8]
       mov       [rbp-50],ecx
M00_L09:
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBB4124EA0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-0B0],rax
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+90]
       lea       r8,[rbp-0B0]
       mov       rdx,7FFBB45AE940
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455E7C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L10:
       mov       ecx,3
       call      qword ptr [7FFBB45D4C18]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L01
M00_L11:
       mov       rcx,r12
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-78],eax
       mov       edx,[r12+8]
       mov       [rbp-7C],edx
       mov       rcx,r15
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-78]
       mov       r8d,[rbp-7C]
       mov       rcx,r13
       call      qword ptr [7FFBB45D5278]
       jmp       near ptr M00_L02
M00_L12:
       mov       rcx,[r15+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L24
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L23
       mov       r12,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3F05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E4B17C],0
       je        short M00_L13
       call      qword ptr [7FFBB45D5290]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M00_L15
M00_L13:
       mov       ecx,9
       call      qword ptr [7FFBB45D52A8]
       mov       eax,[rax+10]
       mov       [rbp-8C],eax
       mov       ecx,9
       call      qword ptr [7FFBB45D52A8]
       mov       edx,[rbp-8C]
       lea       ecx,[rdx-1]
       mov       [rax+10],ecx
       movzx     eax,dx
       test      eax,eax
       jne       short M00_L14
       call      qword ptr [7FFBB45D52C0]
       mov       edx,eax
       mov       [rbp-88],edx
       jmp       short M00_L15
M00_L14:
       sar       edx,10
       mov       [rbp-88],edx
M00_L15:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3F05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,[rbp-88]
       xor       edx,edx
       div       dword ptr [7FFBB3E4B170]
       mov       eax,edx
       xor       edx,edx
       jmp       near ptr M00_L19
M00_L16:
       cmp       eax,[r12+8]
       jae       near ptr M00_L32
       mov       [rbp-80],eax
       mov       ecx,eax
       mov       r8,[r12+rcx*8+10]
       mov       [rbp-168],r8
       cmp       [r8],r8b
       xor       r10d,r10d
       mov       [rbp-160],r10
       mov       rcx,r8
       call      qword ptr [7FFBB443E538]; System.Threading.Monitor.Enter(System.Object)
       mov       r8,[rbp-168]
       mov       rcx,[r8+8]
       mov       eax,[r8+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L17
       mov       edx,eax
       mov       r10,[rcx+rdx*8+10]
       mov       [rbp-160],r10
       mov       r10d,eax
       xor       r9d,r9d
       mov       [rcx+r10*8+10],r9
       mov       [r8+10],eax
M00_L17:
       mov       rcx,r8
       call      qword ptr [7FFBB3F06820]; System.Threading.Monitor.Exit(System.Object)
       mov       rcx,[rbp-160]
       test      rcx,rcx
       jne       short M00_L20
       mov       eax,[rbp-80]
       inc       eax
       mov       ecx,eax
       cmp       [r12+8],ecx
       jne       short M00_L18
       xor       ecx,ecx
M00_L18:
       mov       edx,[rbp-84]
       inc       edx
       mov       eax,ecx
M00_L19:
       mov       [rbp-84],edx
       cmp       [r12+8],edx
       jg        near ptr M00_L16
       jmp       short M00_L21
M00_L20:
       mov       r12,rcx
       jmp       short M00_L22
M00_L21:
       xor       r12d,r12d
M00_L22:
       test      r12,r12
       je        short M00_L23
       cmp       byte ptr [r13+9D],0
       je        near ptr M00_L02
       mov       rcx,r12
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-70],eax
       mov       edx,[r12+8]
       mov       [rbp-74],edx
       mov       rcx,r15
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,[rbp-70]
       mov       r8d,[rbp-74]
       mov       rcx,r13
       call      qword ptr [7FFBB45D5278]
       jmp       near ptr M00_L02
M00_L23:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r12,rax
       cmp       byte ptr [r13+9D],0
       je        near ptr M00_L02
       jmp       short M00_L25
M00_L24:
       mov       ecx,100
       mov       rdx,200F2426F28
       call      qword ptr [7FFBB412DBC0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L23
M00_L25:
       mov       rcx,r12
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rbp-6C],eax
       mov       rcx,r15
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,[rbp-6C]
       mov       r8d,100
       mov       rcx,r13
       call      qword ptr [7FFBB45D5278]
       mov       rcx,r15
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[r15+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,[rbp-6C]
       mov       r8d,100
       call      qword ptr [7FFBB45D52D8]
       jmp       near ptr M00_L02
M00_L26:
       mov       rcx,1C073400070
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFBB45D5680]
       mov       edx,eax
       jmp       near ptr M00_L03
M00_L27:
       mov       [rbp-158],rdx
       mov       [rbp-150],r15d
       lea       rdx,[rbp-158]
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBB45D56E0]
       jmp       near ptr M00_L04
M00_L28:
       call      qword ptr [7FFBB4077198]
       int       3
M00_L29:
       lea       rcx,[rbp-60]
       mov       rdx,200F2427C88
       call      qword ptr [7FFBB455C1C8]
       jmp       near ptr M00_L05
M00_L30:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4AF8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L31:
       lea       rcx,[rbp-60]
       mov       rdx,rsi
       call      qword ptr [7FFBB45D5170]
       jmp       near ptr M00_L09
M00_L32:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1878
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
       mov       rax,7FFBB4354D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45D5650]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4294528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4AF8]
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
       mov       rax,41DB8502489C
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
       mov       rax,7FFBB4354D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,41DB8502489C
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
       call      qword ptr [7FFBB44BFFA8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB44BFFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45D65F8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,200F2422288
       call      qword ptr [7FFBB412DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB4077198]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4AF8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C05D401E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4545E10]
       mov       [rbp+28],rax
       mov       rcx,1C05D400C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41CFB68]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4345188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB4077198]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB434CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F01548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1C05D401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4545E18]
       mov       rcx,1C05D400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45251E8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,1C05D401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4545E18]
       mov       rcx,1C05D400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
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
       jne       short M03_L01
M03_L00:
       movzx     edi,si
       lea       rcx,[rbx+18]
       mov       eax,[rbx+10]
       mov       edx,[rcx+8]
       cmp       eax,edx
       ja        short M03_L03
       mov       rcx,[rcx]
       mov       r8d,eax
       lea       rbp,[rcx+r8*2]
       sub       edx,eax
       je        short M03_L02
       mov       [rbp],di
       inc       dword ptr [rbx+10]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L01:
       movzx     edx,si
       mov       rcx,rbx
       xor       r8d,r8d
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFBB45D5698]
M03_L02:
       mov       rcx,rbx
       call      qword ptr [7FFBB4556A90]
       jmp       short M03_L00
M03_L03:
       call      qword ptr [7FFBB4077198]
       int       3
; Total bytes of code 107
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
       ja        short M04_L02
       test      r8b,18
       je        short M04_L00
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       short M04_L05
M04_L00:
       test      r8b,4
       jne       short M04_L01
       test      r8,r8
       je        short M04_L05
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        short M04_L05
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       short M04_L05
M04_L01:
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       short M04_L05
M04_L02:
       cmp       r8,40
       ja        short M04_L07
M04_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M04_L06
M04_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M04_L05:
       vzeroupper
       ret
M04_L06:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M04_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M04_L04
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
       ja        near ptr M04_L03
       jmp       near ptr M04_L04
M04_L10:
       cmp       rcx,rdx
       jne       short M04_L11
       cmp       [rdx],dl
       jmp       near ptr M04_L05
M04_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBB3F066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 319
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
       call      qword ptr [7FFBB4077198]
       int       3
; Total bytes of code 46
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
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r10d,1
M06_L00:
       mov       eax,r10d
       add       rsp,28
       ret
; Total bytes of code 50
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
       mov       rcx,1C05D400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB70]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M07_L00:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M07_L01:
       call      qword ptr [7FFBB4077198]
       int       3
; Total bytes of code 122
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
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M09_L01
       cmp       [rax],ecx
       jle       short M09_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M09_L03
M09_L00:
       add       rsp,20
       pop       rbx
       ret
M09_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M09_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M09_L00
M09_L02:
       cmp       [rax+4],edx
       jle       short M09_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M09_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M09_L03
       jmp       short M09_L00
M09_L03:
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
       call      qword ptr [7FFC0D8A4DC8]
       test      eax,eax
       je        short M10_L00
       add       rsp,20
       pop       rbx
       ret
M10_L00:
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
       jne       short M11_L00
       ret
M11_L00:
       jmp       qword ptr [7FFBB412E340]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M12_L01
       mov       rcx,rbx
       call      qword ptr [7FFC0D8A1BD8]
       test      eax,eax
       je        short M12_L00
       add       rsp,20
       pop       rbx
       ret
M12_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M12_L01:
       xor       ecx,ecx
       call      qword ptr [7FFC0D89C210]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M13_L00
       mov       rcx,rbx
       call      00007FFC13B9E040
       test      eax,eax
       jne       short M13_L01
       add       rsp,20
       pop       rbx
       ret
M13_L00:
       xor       ecx,ecx
       call      qword ptr [7FFBB45D4948]
       int       3
M13_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFBB45D4A50]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M14_L00
       add       rsp,28
       ret
M14_L00:
       call      qword ptr [7FFC0D8B1908]
       int       3
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCoordinate()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       rax,0A5AF40CF8546
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0A8]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-90],rdx
       mov       rdx,rbp
       mov       [rbp-80],rdx
       mov       [rbp-0B8],rbx
       lea       rdi,[rbp-50]
       mov       [rbp-0B0],rdi
       mov       [rbp-60],rdi
       mov       rdx,rdi
       xor       ecx,ecx
       mov       r8d,0C
       mov       r9d,2
       mov       rax,7FFBB4354D88
       mov       [rbp-98],rax
       lea       rax,[M00_L00]
       mov       [rbp-88],rax
       lea       rax,[rbp-0A8]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-0A0]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L05
       xor       ecx,ecx
       mov       [rbp-60],rcx
       mov       rcx,23C33F4B838
       mov       rax,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.Coordinate
       mov       eax,[rax]
       and       eax,0C0000
       cmp       eax,40000
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M00_L04
       call      qword ptr [7FFBB3EF7C18]; System.RuntimeType.CreateInstanceOfT()
M00_L02:
       xor       ecx,ecx
       mov       [rbp-68],rcx
       mov       rdi,[rbp-0B0]
       mov       ecx,[rdi]
       mov       [rax+8],ecx
       mov       ecx,[rdi+4]
       mov       [rax+0C],ecx
       mov       ecx,[rdi+8]
       mov       [rax+10],ecx
       mov       [rbp-70],rax
       mov       rbx,[rbp-0B8]
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-70]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+8],rcx
       mov       r8,0A5AF40CF8546
       cmp       [rbp-40],r8
       je        short M00_L03
       call      CORINFO_HELP_FAIL_FAST
M00_L03:
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
M00_L04:
       xor       edx,edx
       mov       [rbp-68],rdx
       lea       rdx,[rbp-68]
       call      qword ptr [7FFBB45BC7E0]
       mov       rax,[rbp-68]
       jmp       near ptr M00_L02
M00_L05:
       mov       ecx,eax
       call      qword ptr [7FFBB45BC318]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 433
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
       je        short M01_L00
       mov       rsi,[rcx]
       test      rsi,rsi
       jne       short M01_L03
M01_L00:
       mov       rcx,rbx
       call      qword ptr [7FFBB3EF7C78]; System.RuntimeType.InitializeCache()
M01_L01:
       mov       rdx,[rax+80]
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,[rdx]
       mov       rax,offset MT_System.RuntimeType+ActivatorCache
       cmp       rcx,rax
       jne       short M01_L04
       mov       rsi,rdx
M01_L02:
       cmp       byte ptr [rsi+28],0
       je        short M01_L06
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
M01_L03:
       mov       rax,rsi
       jmp       short M01_L01
M01_L04:
       mov       rax,offset MT_System.RuntimeType+CompositeCacheEntry
       cmp       rcx,rax
       jne       short M01_L05
       mov       rsi,[rdx+8]
       test      rsi,rsi
       je        short M01_L05
       jmp       short M01_L02
M01_L05:
       mov       rdx,rbx
       mov       rcx,offset MT_System.RuntimeType+IGenericCacheEntry<System.RuntimeType+ActivatorCache>
       call      qword ptr [7FFBB3EFC540]; System.RuntimeType+IGenericCacheEntry`1[[System.__Canon, System.Private.CoreLib]].CreateAndCache(System.RuntimeType)
       mov       rsi,rax
       jmp       short M01_L02
M01_L06:
       mov       rcx,offset MT_System.MissingMethodException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45B6A90]
       mov       rcx,rax
       mov       rdx,rbx
       call      qword ptr [7FFBB44AEBE0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB45B6AA8]
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
       call      qword ptr [7FFBB45B6AD8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 274
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateCurrencyAmount()
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
       mov       dword ptr [rsp+0A8],20000
       mov       [rsp+0AC],ecx
       mov       qword ptr [rsp+0B0],1
       mov       [rsp+98],esi
       mov       [rsp+9C],edi
       mov       [rsp+0A0],rbp
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+98]
       call      qword ptr [7FFBB4515FF8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+0A8]
       vmovups   [rsp+88],xmm0
       mov       edx,[rsp+88]
       test      edx,0FF0000
       je        short M00_L00
       sar       edx,10
       movzx     edx,dl
       lea       rcx,[rsp+88]
       mov       r8d,2
       call      qword ptr [7FFBB4516028]; System.Decimal+DecCalc.InternalRound(DecCalc ByRef, UInt32, System.MidpointRounding)
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
       mov       dword ptr [rsp+78],20000
       xor       ecx,ecx
       mov       [rsp+7C],ecx
       mov       qword ptr [rsp+80],0F4240
       mov       [rsp+68],esi
       mov       [rsp+6C],edi
       mov       [rsp+70],rbp
       lea       rcx,[rsp+78]
       lea       rdx,[rsp+68]
       call      qword ptr [7FFBB4515FF8]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+58],xmm0
       mov       edx,[rsp+58]
       test      edx,0FF0000
       je        short M00_L03
       sar       edx,10
       movzx     edx,dl
       lea       rcx,[rsp+58]
       mov       r8d,2
       call      qword ptr [7FFBB4516028]; System.Decimal+DecCalc.InternalRound(DecCalc ByRef, UInt32, System.MidpointRounding)
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
       call      qword ptr [7FFBB45141B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFBB4516040]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+48]
       vmovups   [rsp+28],xmm0
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBB451E328]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
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
       call      qword ptr [7FFBB45B58F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45B5908]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45B58F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45B5908]
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
; Total bytes of code 689
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
       mov       rdx,7FFC0CC29540
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
       call      qword ptr [7FFBB45B58D8]
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
; System.Decimal+DecCalc.InternalRound(DecCalc ByRef, UInt32, System.MidpointRounding)
       push      rsi
       push      rbx
       push      rax
       mov       eax,edx
       mov       edx,eax
       shl       edx,10
       sub       [rcx],edx
       xor       r10d,r10d
       cmp       eax,9
       jae       short M02_L03
M02_L00:
       mov       r9d,eax
       mov       rax,7FFC0CC236D0
       mov       r9d,[rax+r9*4]
       mov       ebx,[rcx+4]
       test      ebx,ebx
       jne       near ptr M02_L08
       mov       r11,[rcx+8]
       test      r11,r11
       je        near ptr M02_L07
       mov       esi,r9d
       mov       rax,r11
       xor       edx,edx
       div       rsi
       mov       [rcx+8],rax
       imul      eax,esi
       sub       r11d,eax
M02_L01:
       cmp       r8d,2
       jne       near ptr M02_L10
M02_L02:
       add       rsp,8
       pop       rbx
       pop       rsi
       ret
M02_L03:
       add       eax,0FFFFFFF7
       mov       r9d,[rcx+4]
       test      r9d,r9d
       jne       short M02_L04
       mov       r11,[rcx+8]
       mov       r9,44B82FA09B5A53
       mov       rdx,r11
       shr       rdx,9
       mulx      rdx,rdx,r9
       shr       rdx,0B
       mov       [rcx+8],rdx
       imul      edx,3B9ACA00
       sub       r11d,edx
       jmp       near ptr M02_L06
M02_L04:
       lea       r11,[rcx+4]
       mov       edx,r9d
       shr       edx,9
       imul      rdx,44B83
       shr       rdx,27
       imul      ebx,edx,3B9ACA00
       sub       r9d,ebx
       mov       [r11],edx
       mov       r11d,r9d
       mov       edx,[rcx+0C]
       mov       ebx,edx
       or        ebx,r11d
       je        short M02_L05
       mov       r11d,r9d
       shl       r11,20
       mov       [rsp+4],edx
       mov       r9d,edx
       or        r9,r11
       mov       r11,44B82FA09B5A53
       mov       rdx,r9
       shr       rdx,9
       mulx      rdx,rdx,r11
       shr       rdx,0B
       mov       [rcx+0C],edx
       imul      edx,3B9ACA00
       mov       r9d,[rsp+4]
       mov       r11d,r9d
       sub       r11d,edx
M02_L05:
       mov       r9d,[rcx+8]
       mov       edx,r9d
       or        edx,r11d
       je        short M02_L06
       mov       edx,r11d
       shl       rdx,20
       mov       r11d,r9d
       or        rdx,r11
       mov       r11,44B82FA09B5A53
       shr       rdx,9
       mulx      rdx,rdx,r11
       shr       rdx,0B
       mov       [rcx+8],edx
       imul      edx,3B9ACA00
       mov       r11d,r9d
       sub       r11d,edx
M02_L06:
       mov       r9d,3B9ACA00
       test      eax,eax
       je        near ptr M02_L01
       or        r10d,r11d
       cmp       eax,9
       jae       near ptr M02_L03
       jmp       near ptr M02_L00
M02_L07:
       cmp       r8d,2
       jle       near ptr M02_L02
       xor       r11d,r11d
       jmp       near ptr M02_L01
M02_L08:
       lea       r11,[rcx+4]
       mov       eax,ebx
       xor       edx,edx
       div       r9d
       mov       edx,eax
       imul      edx,r9d
       sub       ebx,edx
       mov       [r11],eax
       mov       r11d,ebx
       mov       eax,[rcx+0C]
       mov       edx,eax
       mov       eax,edx
       or        eax,r11d
       je        short M02_L09
       mov       eax,ebx
       shl       rax,20
       mov       [rsp],edx
       mov       r11d,edx
       or        rax,r11
       mov       esi,r9d
       xor       edx,edx
       div       rsi
       mov       [rcx+0C],eax
       imul      eax,r9d
       mov       ebx,[rsp]
       mov       r11d,ebx
       sub       r11d,eax
M02_L09:
       mov       ebx,[rcx+8]
       mov       eax,ebx
       or        eax,r11d
       je        near ptr M02_L01
       mov       eax,r11d
       shl       rax,20
       mov       edx,ebx
       or        rax,rdx
       mov       esi,r9d
       xor       edx,edx
       div       rsi
       mov       [rcx+8],eax
       imul      eax,r9d
       mov       r11d,ebx
       sub       r11d,eax
       jmp       near ptr M02_L01
M02_L10:
       test      r8d,r8d
       jne       short M02_L12
       add       r11d,r11d
       mov       r8d,[rcx+8]
       and       r8d,1
       or        r8d,r10d
       je        short M02_L11
       inc       r11d
M02_L11:
       cmp       r9d,r11d
       jb        short M02_L15
       jmp       near ptr M02_L02
M02_L12:
       cmp       r8d,1
       jne       short M02_L13
       lea       r8d,[r11+r11]
       cmp       r9d,r8d
       jbe       short M02_L15
       jmp       near ptr M02_L02
M02_L13:
       cmp       r8d,3
       jne       short M02_L14
       or        r10d,r11d
       je        near ptr M02_L02
       cmp       dword ptr [rcx],0
       jl        short M02_L15
       jmp       near ptr M02_L02
M02_L14:
       mov       eax,r11d
       or        eax,r10d
       je        near ptr M02_L02
       cmp       dword ptr [rcx],0
       jl        near ptr M02_L02
M02_L15:
       mov       rax,[rcx+8]
       inc       rax
       mov       [rcx+8],rax
       test      rax,rax
       jne       near ptr M02_L02
       add       rcx,4
       inc       dword ptr [rcx]
       jmp       near ptr M02_L02
; Total bytes of code 639
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
       jge       near ptr M03_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L05
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
M03_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4334D88
       mov       [rbp-70],rax
       lea       rax,[M03_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M03_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M03_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M03_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M03_L00
       add       eax,ebx
M03_L03:
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
M03_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45B5A28]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4274528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       eax,ebx
       jmp       short M03_L03
M03_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4F00]
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
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,68
       mov       rbx,rcx
       mov       rsi,rdx
       mov       eax,[rbx]
       sub       eax,[rsi]
       shr       eax,10
       movsx     rdi,al
       xor       ebp,ebp
       mov       eax,[rsi+4]
       or        eax,[rsi+0C]
       jne       near ptr M04_L32
       mov       r14d,[rsi+8]
       test      r14d,r14d
       je        near ptr M04_L13
       mov       rax,[rbx+8]
       mov       [rsp+58],rax
       mov       eax,[rbx+4]
       mov       [rsp+60],eax
       xor       edx,edx
       cmp       dword ptr [rsp+60],0
       jne       near ptr M04_L14
       mov       eax,[rsp+5C]
       cmp       eax,r14d
       jae       near ptr M04_L15
       mov       edx,eax
       xor       eax,eax
       mov       [rsp+5C],eax
M04_L00:
       mov       eax,[rsp+58]
       div       r14d
       mov       [rsp+58],eax
       mov       r10d,edx
M04_L01:
       test      r10d,r10d
       jne       near ptr M04_L08
       test      edi,edi
       jl        near ptr M04_L16
M04_L02:
       test      ebp,ebp
       je        near ptr M04_L50
       mov       eax,[rsp+58]
       mov       rcx,[rsp+5C]
       test      al,al
       je        near ptr M04_L12
M04_L03:
       test      al,0F
       jne       short M04_L04
       cmp       edi,4
       jl        short M04_L04
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
       jne       short M04_L04
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFFC
M04_L04:
       test      al,3
       jne       short M04_L05
       cmp       edi,2
       jl        short M04_L05
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
       jne       short M04_L05
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFFE
M04_L05:
       test      al,1
       jne       short M04_L06
       test      edi,edi
       jle       short M04_L06
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
       jne       short M04_L06
       mov       rcx,r8
       mov       eax,edx
       dec       edi
M04_L06:
       mov       [rbx+8],eax
       mov       [rbx+0C],ecx
       shr       rcx,20
       mov       [rbx+4],ecx
M04_L07:
       mov       eax,[rbx]
       xor       eax,[rsi]
       and       eax,80000000
       mov       ecx,edi
       shl       ecx,10
       or        eax,ecx
       mov       [rbx],eax
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
M04_L08:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M04_L31
       mov       edx,[rsp+60]
       mov       rax,[rsp+58]
       xor       r8d,r8d
       cmp       edx,19999999
       ja        near ptr M04_L20
       mov       r8,1D83EC01E98
       mov       r8,[r8]
       cmp       edi,13
       jg        near ptr M04_L19
       cmp       edx,4
       jae       near ptr M04_L21
M04_L09:
       mov       r15d,9
M04_L10:
       test      r15d,r15d
       je        near ptr M04_L31
M04_L11:
       cmp       r15d,0A
       jae       near ptr M04_L53
       mov       edx,r15d
       mov       rax,7FFC0CC236D0
       mov       r13d,[rax+rdx*4]
       add       edi,r15d
       mov       rdx,[rsp+58]
       mov       eax,r13d
       lea       r8,[rsp+30]
       mulx      rdx,rcx,rax
       mov       [r8],rcx
       mov       r8,[rsp+30]
       mov       [rsp+58],r8
       mov       r8d,[rsp+60]
       imul      r8,rax
       add       rdx,r8
       mov       [rsp+60],edx
       shr       rdx,20
       test      edx,edx
       jne       near ptr M04_L52
       mov       edx,r10d
       imul      rax,rdx
       mov       rdx,rax
       shr       rdx,20
       div       r14d
       mov       r10d,edx
       mov       r8d,eax
       add       r8,[rsp+58]
       mov       [rsp+58],r8
       mov       ecx,eax
       cmp       r8,rcx
       jae       near ptr M04_L01
       mov       r8d,[rsp+60]
       inc       r8d
       mov       [rsp+60],r8d
       test      r8d,r8d
       jne       near ptr M04_L01
       test      edx,edx
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+58]
       mov       edx,edi
       call      qword ptr [7FFBB45B5A88]
       mov       edi,eax
       jmp       near ptr M04_L02
M04_L12:
       cmp       edi,8
       jl        near ptr M04_L03
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
       jne       near ptr M04_L03
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFF8
       test      al,al
       jne       near ptr M04_L03
       jmp       short M04_L12
M04_L13:
       mov       rcx,offset MT_System.DivideByZeroException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB45B5A70]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L14:
       mov       eax,[rsp+60]
       xor       edx,edx
       div       r14d
       mov       [rsp+60],eax
M04_L15:
       mov       eax,[rsp+5C]
       div       r14d
       mov       [rsp+5C],eax
       jmp       near ptr M04_L00
M04_L16:
       mov       edx,edi
       neg       edx
       cmp       edx,9
       jge       short M04_L17
       mov       r15d,edx
       jmp       short M04_L18
M04_L17:
       mov       r15d,9
M04_L18:
       jmp       near ptr M04_L11
M04_L19:
       mov       ecx,edi
       neg       ecx
       add       ecx,1C
       lea       r9d,[rcx-1]
       cmp       r9d,8
       jae       near ptr M04_L53
       lea       r9d,[rcx-1]
       shl       r9,4
       cmp       [r8+r9+10],edx
       jbe       short M04_L22
       mov       r8d,ecx
M04_L20:
       lea       edx,[r8+rdi]
       test      edx,edx
       jge       near ptr M04_L30
       jmp       near ptr M04_L52
M04_L21:
       cmp       edx,4
       jne       short M04_L22
       mov       rcx,4B82FA09B5A52CB9
       cmp       rax,rcx
       jbe       near ptr M04_L09
M04_L22:
       cmp       edx,0A7C5
       jbe       short M04_L24
       cmp       edx,418937
       jbe       short M04_L23
       mov       ecx,2
       cmp       edx,28F5C28
       jbe       short M04_L27
       jmp       short M04_L25
M04_L23:
       mov       ecx,4
       cmp       edx,68DB8
       jbe       short M04_L27
       jmp       short M04_L25
M04_L24:
       cmp       edx,1AD
       jbe       short M04_L26
       mov       ecx,6
       cmp       edx,10C6
       jbe       short M04_L27
M04_L25:
       dec       ecx
       jmp       short M04_L27
M04_L26:
       mov       ecx,8
       cmp       edx,2A
       ja        short M04_L25
M04_L27:
       lea       r9d,[rcx-1]
       shl       r9,4
       cmp       [r8+r9+10],edx
       jne       short M04_L29
       lea       edx,[rcx-1]
       shl       rdx,4
       cmp       [r8+rdx+18],rax
       jae       short M04_L28
       dec       ecx
       mov       r8d,ecx
       jmp       near ptr M04_L20
M04_L28:
       mov       r8d,ecx
       jmp       near ptr M04_L20
M04_L29:
       mov       r8d,ecx
       jmp       near ptr M04_L20
M04_L30:
       mov       r15d,r8d
       jmp       near ptr M04_L10
M04_L31:
       lea       r12d,[r10+r10]
       cmp       r12d,r10d
       jb        near ptr M04_L48
       cmp       r12d,r14d
       jb        near ptr M04_L02
       ja        near ptr M04_L48
       test      byte ptr [rsp+58],1
       je        near ptr M04_L02
       jmp       near ptr M04_L48
M04_L32:
       mov       r12d,[rsi+4]
       test      r12d,r12d
       jne       short M04_L33
       mov       r12d,[rsi+0C]
M04_L33:
       xor       r15d,r15d
       lzcnt     r15d,r12d
       shlx      rax,[rbx+8],r15
       mov       [rsp+48],rax
       mov       eax,[rbx+0C]
       mov       edx,[rbx+4]
       shl       rdx,20
       add       rax,rdx
       mov       edx,r15d
       neg       edx
       add       edx,20
       shrx      rax,rax,rdx
       mov       [rsp+50],rax
       shlx      r12,[rsi+8],r15
       cmp       dword ptr [rsi+4],0
       jne       near ptr M04_L41
       xor       eax,eax
       mov       [rsp+60],eax
       mov       rax,[rsp+48]
       mov       rdx,[rsp+50]
       div       r12
       mov       [rsp+48],rdx
       mov       [rsp+58],rax
M04_L34:
       cmp       qword ptr [rsp+48],0
       jne       short M04_L37
       test      edi,edi
       jge       near ptr M04_L02
       mov       r15d,edi
       neg       r15d
       cmp       r15d,9
       jge       short M04_L35
       mov       ecx,r15d
       jmp       short M04_L36
M04_L35:
       mov       ecx,9
M04_L36:
       mov       r15d,ecx
       jmp       short M04_L38
M04_L37:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M04_L39
       lea       rcx,[rsp+58]
       mov       edx,edi
       call      qword ptr [7FFBB4516058]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r15d,eax
       test      r15d,r15d
       je        short M04_L39
M04_L38:
       cmp       r15d,0A
       jae       near ptr M04_L53
       mov       ecx,r15d
       mov       rdx,7FFC0CC236D0
       mov       r13d,[rdx+rcx*4]
       add       edi,r15d
       lea       rcx,[rsp+58]
       mov       edx,r13d
       call      qword ptr [7FFBB45160E8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L52
       lea       rcx,[rsp+48]
       mov       edx,r13d
       call      qword ptr [7FFBB45B5AA0]
       lea       rcx,[rsp+48]
       mov       rdx,r12
       call      qword ptr [7FFBB45B5AB8]
       mov       edx,eax
       lea       rcx,[rsp+58]
       call      qword ptr [7FFBB4516118]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L34
       jmp       short M04_L40
M04_L39:
       mov       rcx,[rsp+48]
       test      rcx,rcx
       jl        near ptr M04_L48
       add       rcx,rcx
       cmp       rcx,r12
       ja        near ptr M04_L48
       jne       near ptr M04_L02
       test      byte ptr [rsp+58],1
       je        near ptr M04_L02
       jmp       near ptr M04_L48
M04_L40:
       cmp       qword ptr [rsp+48],0
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+58]
       mov       edx,edi
       call      qword ptr [7FFBB45B5A88]
       mov       edi,eax
       jmp       near ptr M04_L02
M04_L41:
       mov       [rsp+38],r12
       mov       ecx,[rsi+0C]
       mov       edx,[rsi+4]
       shl       rdx,20
       add       rcx,rdx
       mov       edx,r15d
       neg       edx
       add       edx,20
       shrx      rcx,rcx,rdx
       mov       [rsp+40],ecx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFBB45B5AD0]
       mov       ecx,eax
       mov       [rsp+58],rcx
       xor       ecx,ecx
       mov       [rsp+60],ecx
M04_L42:
       mov       ecx,[rsp+50]
       or        rcx,[rsp+48]
       jne       short M04_L45
       test      edi,edi
       jge       near ptr M04_L02
       mov       r15d,edi
       neg       r15d
       cmp       r15d,9
       jge       short M04_L43
       mov       ecx,r15d
       jmp       short M04_L44
M04_L43:
       mov       ecx,9
M04_L44:
       jmp       short M04_L46
M04_L45:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M04_L47
       lea       rcx,[rsp+58]
       mov       edx,edi
       call      qword ptr [7FFBB4516058]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       ecx,eax
       test      ecx,ecx
       je        near ptr M04_L47
M04_L46:
       cmp       ecx,0A
       jae       near ptr M04_L53
       mov       edx,ecx
       mov       rax,7FFC0CC236D0
       mov       r13d,[rax+rdx*4]
       add       edi,ecx
       lea       rcx,[rsp+58]
       mov       edx,r13d
       call      qword ptr [7FFBB45160E8]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L52
       mov       rdx,[rsp+48]
       mov       ecx,r13d
       lea       rax,[rsp+28]
       mulx      rcx,r8,rcx
       mov       [rax],r8
       mov       rdx,[rsp+28]
       mov       [rsp+48],rdx
       mov       edx,[rsp+50]
       mov       eax,r13d
       imul      rdx,rax
       add       rcx,rdx
       mov       [rsp+50],rcx
       lea       rcx,[rsp+48]
       lea       rdx,[rsp+38]
       call      qword ptr [7FFBB45B5AD0]
       mov       edx,eax
       lea       rcx,[rsp+58]
       call      qword ptr [7FFBB4516118]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L42
       jmp       near ptr M04_L49
M04_L47:
       cmp       dword ptr [rsp+50],0
       jl        short M04_L48
       mov       r12d,[rsp+4C]
       shr       r12d,1F
       mov       rcx,[rsp+48]
       add       rcx,rcx
       mov       [rsp+48],rcx
       mov       ecx,[rsp+50]
       lea       ecx,[r12+rcx*2]
       mov       [rsp+50],ecx
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+40]
       ja        short M04_L48
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+40]
       jne       near ptr M04_L02
       mov       rcx,[rsp+48]
       cmp       rcx,[rsp+38]
       ja        short M04_L48
       mov       rcx,[rsp+48]
       cmp       rcx,[rsp+38]
       jne       near ptr M04_L02
       test      byte ptr [rsp+58],1
       je        near ptr M04_L02
M04_L48:
       mov       rcx,[rsp+58]
       inc       rcx
       mov       [rsp+58],rcx
       test      rcx,rcx
       jne       near ptr M04_L02
       jmp       short M04_L51
M04_L49:
       mov       r8,[rsp+48]
       or        r8,[rsp+50]
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+58]
       mov       edx,edi
       call      qword ptr [7FFBB45B5A88]
       mov       edi,eax
       jmp       near ptr M04_L02
M04_L50:
       mov       rax,[rsp+58]
       mov       [rbx+8],rax
       mov       eax,[rsp+60]
       mov       [rbx+4],eax
       jmp       near ptr M04_L07
M04_L51:
       mov       ecx,[rsp+60]
       inc       ecx
       mov       [rsp+60],ecx
       test      ecx,ecx
       jne       near ptr M04_L02
       lea       rcx,[rsp+58]
       mov       edx,edi
       mov       r8d,1
       call      qword ptr [7FFBB45B5A88]
       mov       edi,eax
       jmp       near ptr M04_L02
M04_L52:
       mov       ecx,0F405
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rcx,rax
       call      qword ptr [7FFBB45B5950]
       mov       rcx,rax
       call      qword ptr [7FFBB45B5968]
       int       3
M04_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2147
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDateOnly()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-3C],eax
       mov       [rbp-48],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-88]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-70],rdx
       mov       rdx,rbp
       mov       [rbp-60],rdx
       xor       edx,edx
       mov       [rbp-3C],edx
M00_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4364D88
       mov       [rbp-78],rax
       lea       rax,[M00_L01]
       mov       [rbp-68],rax
       lea       rax,[rbp-88]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-80]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       short M00_L03
       xor       ecx,ecx
       mov       [rbp-48],rcx
       mov       [rbp-48],rcx
       movzx     ecx,word ptr [rbp-3C]
       cmp       ecx,8EAC
       ja        near ptr M00_L00
       add       ecx,0B2407
       cmp       ecx,37B9DA
       ja        short M00_L04
       mov       [rbp-50],ecx
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-50]
       call      qword ptr [7FFBB454E310]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateOnly, System.Private.CoreLib]](System.DateOnly ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L03:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4E88]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L04:
       call      qword ptr [7FFBB45D58C0]
       int       3
; Total bytes of code 291
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateOnly, System.Private.CoreLib]](System.DateOnly ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDateTimeOffset()
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-58],rax
       mov       rax,0DD1296EB90FE
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0A0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-88],rdx
       mov       rdx,rbp
       mov       [rbp-78],rdx
       mov       [rbp-0B0],rbx
       lea       rdi,[rbp-48]
       mov       [rbp-0A8],rdi
       mov       [rbp-58],rdi
       mov       rdx,rdi
       xor       ecx,ecx
       mov       r8d,8
       mov       r9d,2
       mov       rax,7FFBB4344D88
       mov       [rbp-90],rax
       lea       rax,[M00_L00]
       mov       [rbp-80],rax
       lea       rax,[rbp-0A0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-98]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L06
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rdi,[rbp-0A8]
       mov       rbx,[rdi]
       test      rbx,rbx
       jge       short M00_L02
       neg       rbx
       js        near ptr M00_L07
M00_L02:
       mov       rdx,491158716E771F75
       mov       rax,rdx
       imul      rbx
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,35
       add       rcx,rdx
       mov       rax,701D78515E2981
       imul      rcx,rax
       sub       rbx,rcx
       mov       rcx,8C1220247E44000
       add       rcx,rbx
       mov       rax,rcx
       mov       rdx,2BCA2875F4373FFF
       cmp       rax,rdx
       ja        short M00_L05
       mov       rax,3FFFFFFFFFFFFFFF
       and       rcx,rax
       mov       rax,2BCA2875F4373FFF
       cmp       rcx,rax
       ja        short M00_L04
       xor       eax,eax
       mov       [rbp-68],eax
       mov       [rbp-60],rcx
       mov       rbx,[rbp-0B0]
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-68]
       call      qword ptr [7FFBB452E370]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       mov       r8,0DD1296EB90FE
       cmp       [rbp-40],r8
       je        short M00_L03
       call      CORINFO_HELP_FAIL_FAST
M00_L03:
       nop
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
M00_L04:
       call      qword ptr [7FFBB45C5890]
       int       3
M00_L05:
       mov       ecx,3AD
       mov       rdx,7FFBB3E34000
       call      qword ptr [7FFBB41177C8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45C6808]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB411DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45C4EE8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L07:
       call      qword ptr [7FFBB45C58F0]
       int       3
; Total bytes of code 537
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.DateTimeOffset, System.Private.CoreLib]](System.DateTimeOffset ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFBB45664C0]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+0A8]
       vmovups   [rsp+88],xmm0
       mov       edx,[rsp+88]
       test      edx,0FF0000
       je        short M00_L00
       sar       edx,10
       movzx     edx,dl
       lea       rcx,[rsp+88]
       mov       r8d,2
       call      qword ptr [7FFBB45664F0]; System.Decimal+DecCalc.InternalRound(DecCalc ByRef, UInt32, System.MidpointRounding)
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
       call      qword ptr [7FFBB45664C0]; System.Decimal+DecCalc.VarDecMul(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+78]
       vmovups   [rsp+58],xmm0
       mov       edx,[rsp+58]
       test      edx,0FF0000
       je        short M00_L03
       sar       edx,10
       movzx     edx,dl
       lea       rcx,[rsp+58]
       mov       r8d,2
       call      qword ptr [7FFBB45664F0]; System.Decimal+DecCalc.InternalRound(DecCalc ByRef, UInt32, System.MidpointRounding)
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
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFBB4566508]; System.Decimal+DecCalc.VarDecDiv(DecCalc ByRef, DecCalc ByRef)
       vmovups   xmm0,[rsp+48]
       vmovups   [rsp+28],xmm0
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBB456E730]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
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
       call      qword ptr [7FFBB45E58D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45E58F0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L08:
       mov       rcx,offset MT_System.OverflowException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45E58D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45E58F0]
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
; Total bytes of code 664
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
       mov       rdx,7FFC0CC29540
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
       call      qword ptr [7FFBB45E58C0]
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
; System.Decimal+DecCalc.InternalRound(DecCalc ByRef, UInt32, System.MidpointRounding)
       push      rbx
       sub       rsp,10
       mov       r10d,edx
       mov       eax,r10d
       shl       eax,10
       sub       [rcx],eax
       xor       r9d,r9d
       cmp       r10d,9
       jb        near ptr M02_L04
M02_L00:
       add       r10d,0FFFFFFF7
       mov       r11d,[rcx+4]
       test      r11d,r11d
       je        near ptr M02_L02
       lea       rax,[rcx+4]
       mov       edx,r11d
       shr       edx,9
       imul      rdx,44B83
       shr       rdx,27
       imul      ebx,edx,3B9ACA00
       sub       r11d,ebx
       mov       [rax],edx
       mov       ebx,r11d
       mov       eax,[rcx+0C]
       mov       edx,eax
       mov       eax,edx
       or        eax,ebx
       je        short M02_L01
       mov       eax,r11d
       shl       rax,20
       mov       [rsp+0C],edx
       mov       r11d,edx
       or        rax,r11
       mov       r11,44B82FA09B5A53
       shr       rax,9
       mul       r11
       shr       rdx,0B
       mov       [rcx+0C],edx
       imul      eax,edx,3B9ACA00
       mov       r11d,[rsp+0C]
       mov       ebx,r11d
       sub       ebx,eax
M02_L01:
       mov       r11d,[rcx+8]
       mov       eax,r11d
       or        eax,ebx
       je        short M02_L03
       mov       eax,ebx
       shl       rax,20
       mov       edx,r11d
       or        rax,rdx
       mov       rdx,44B82FA09B5A53
       shr       rax,9
       mul       rdx
       shr       rdx,0B
       mov       [rcx+8],edx
       imul      eax,edx,3B9ACA00
       mov       ebx,r11d
       sub       ebx,eax
       jmp       short M02_L03
M02_L02:
       mov       rbx,[rcx+8]
       mov       rdx,44B82FA09B5A53
       mov       rax,rbx
       shr       rax,9
       mul       rdx
       shr       rdx,0B
       mov       [rcx+8],rdx
       imul      eax,edx,3B9ACA00
       sub       ebx,eax
M02_L03:
       mov       r11d,3B9ACA00
       test      r10d,r10d
       je        near ptr M02_L08
       or        r9d,ebx
       cmp       r10d,9
       jae       near ptr M02_L00
M02_L04:
       mov       r11d,r10d
       lea       rax,[7FFC0CC236D0]
       mov       r11d,[rax+r11*4]
       mov       r10d,[rcx+4]
       test      r10d,r10d
       je        near ptr M02_L06
       lea       rbx,[rcx+4]
       mov       eax,r10d
       xor       edx,edx
       div       r11d
       mov       edx,eax
       imul      edx,r11d
       sub       r10d,edx
       mov       [rbx],eax
       mov       ebx,r10d
       mov       eax,[rcx+0C]
       mov       edx,eax
       mov       eax,edx
       or        eax,ebx
       je        short M02_L05
       mov       eax,r10d
       shl       rax,20
       mov       [rsp+8],edx
       mov       r10d,edx
       or        rax,r10
       mov       r10d,r11d
       xor       edx,edx
       div       r10
       mov       [rcx+0C],eax
       imul      eax,r11d
       mov       r10d,[rsp+8]
       mov       ebx,r10d
       sub       ebx,eax
M02_L05:
       mov       r10d,[rcx+8]
       mov       eax,r10d
       or        eax,ebx
       je        short M02_L08
       mov       eax,ebx
       shl       rax,20
       mov       edx,r10d
       or        rax,rdx
       mov       ebx,r11d
       xor       edx,edx
       div       rbx
       mov       [rcx+8],eax
       imul      eax,r11d
       mov       ebx,r10d
       sub       ebx,eax
       jmp       short M02_L08
M02_L06:
       mov       rbx,[rcx+8]
       test      rbx,rbx
       je        short M02_L07
       mov       r10d,r11d
       mov       rax,rbx
       xor       edx,edx
       div       r10
       mov       [rcx+8],rax
       mov       edx,r11d
       imul      eax,edx
       sub       ebx,eax
       jmp       short M02_L08
M02_L07:
       cmp       r8d,2
       jle       short M02_L14
       xor       ebx,ebx
M02_L08:
       cmp       r8d,2
       je        short M02_L14
       test      r8d,r8d
       je        short M02_L11
       cmp       r8d,1
       je        short M02_L10
       cmp       r8d,3
       je        short M02_L09
       or        r9d,ebx
       je        short M02_L14
       cmp       dword ptr [rcx],0
       jl        short M02_L14
       jmp       short M02_L13
M02_L09:
       mov       r11d,ebx
       or        r11d,r9d
       je        short M02_L14
       cmp       dword ptr [rcx],0
       jl        short M02_L13
       jmp       short M02_L14
M02_L10:
       lea       r9d,[rbx+rbx]
       cmp       r11d,r9d
       jbe       short M02_L13
       jmp       short M02_L14
M02_L11:
       add       ebx,ebx
       mov       eax,[rcx+8]
       and       eax,1
       or        eax,r9d
       je        short M02_L12
       inc       ebx
M02_L12:
       cmp       r11d,ebx
       jae       short M02_L14
M02_L13:
       mov       rax,[rcx+8]
       inc       rax
       mov       [rcx+8],rax
       test      rax,rax
       jne       short M02_L14
       add       rcx,4
       inc       dword ptr [rcx]
M02_L14:
       add       rsp,10
       pop       rbx
       ret
; Total bytes of code 579
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
       jge       near ptr M03_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M03_L05
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
M03_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M03_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M03_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M03_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M03_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M03_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M03_L00
       add       eax,ebx
M03_L03:
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
M03_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45E5A10]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L05:
       mov       eax,ebx
       jmp       short M03_L03
M03_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4F48]
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
       jne       near ptr M04_L33
       mov       r8d,[rsi+8]
       test      r8d,r8d
       je        near ptr M04_L14
       mov       rax,[rbx+8]
       mov       [rsp+50],rax
       mov       eax,[rbx+4]
       mov       [rsp+58],eax
       xor       edx,edx
       cmp       dword ptr [rsp+58],0
       jne       near ptr M04_L15
       mov       eax,[rsp+54]
       cmp       eax,r8d
       jae       near ptr M04_L16
       mov       edx,eax
       xor       eax,eax
       mov       [rsp+54],eax
M04_L00:
       mov       eax,[rsp+50]
       div       r8d
       mov       [rsp+50],eax
       mov       ecx,edx
M04_L01:
       test      ecx,ecx
       je        near ptr M04_L05
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M04_L32
       mov       edx,[rsp+58]
       mov       rax,[rsp+50]
       xor       r10d,r10d
       cmp       edx,19999999
       ja        near ptr M04_L21
       mov       r10,21052C01E98
       mov       r10,[r10]
       cmp       edi,13
       jg        near ptr M04_L20
       cmp       edx,4
       jae       near ptr M04_L22
M04_L02:
       mov       r14d,9
M04_L03:
       test      r14d,r14d
       je        near ptr M04_L32
M04_L04:
       cmp       r14d,0A
       jae       near ptr M04_L53
       mov       edx,r14d
       mov       rax,7FFC0CC236D0
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
       jne       near ptr M04_L52
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
       jae       near ptr M04_L01
       mov       eax,[rsp+58]
       inc       eax
       mov       [rsp+58],eax
       test      eax,eax
       jne       near ptr M04_L01
       test      edx,edx
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FFBB45E5A70]
       mov       edi,eax
       jmp       short M04_L06
M04_L05:
       test      edi,edi
       jl        near ptr M04_L17
M04_L06:
       test      ebp,ebp
       je        near ptr M04_L13
       mov       eax,[rsp+50]
       mov       rcx,[rsp+54]
       test      al,al
       je        near ptr M04_L12
M04_L07:
       test      al,0F
       jne       short M04_L08
       cmp       edi,4
       jl        short M04_L08
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
       jne       short M04_L08
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFFC
M04_L08:
       test      al,3
       jne       short M04_L09
       cmp       edi,2
       jl        short M04_L09
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
       jne       short M04_L09
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFFE
M04_L09:
       test      al,1
       jne       short M04_L10
       test      edi,edi
       jle       short M04_L10
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
       jne       short M04_L10
       mov       rcx,r8
       mov       eax,edx
       dec       edi
M04_L10:
       mov       [rbx+8],eax
       mov       [rbx+0C],ecx
       shr       rcx,20
       mov       [rbx+4],ecx
M04_L11:
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
M04_L12:
       cmp       edi,8
       jl        near ptr M04_L07
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
       jne       near ptr M04_L07
       mov       rcx,r8
       mov       eax,edx
       add       edi,0FFFFFFF8
       test      al,al
       jne       near ptr M04_L07
       jmp       short M04_L12
M04_L13:
       mov       rax,[rsp+50]
       mov       [rbx+8],rax
       mov       eax,[rsp+58]
       mov       [rbx+4],eax
       jmp       near ptr M04_L11
M04_L14:
       mov       rcx,offset MT_System.DivideByZeroException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB45E5A58]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M04_L15:
       mov       eax,[rsp+58]
       xor       edx,edx
       div       r8d
       mov       [rsp+58],eax
M04_L16:
       mov       eax,[rsp+54]
       div       r8d
       mov       [rsp+54],eax
       jmp       near ptr M04_L00
M04_L17:
       mov       r14d,edi
       neg       r14d
       cmp       r14d,9
       jge       short M04_L18
       mov       edx,r14d
       jmp       short M04_L19
M04_L18:
       mov       edx,9
M04_L19:
       mov       r14d,edx
       jmp       near ptr M04_L04
M04_L20:
       mov       r9d,edi
       neg       r9d
       add       r9d,1C
       lea       r11d,[r9-1]
       cmp       r11d,8
       jae       near ptr M04_L53
       lea       r11d,[r9-1]
       shl       r11,4
       cmp       [r10+r11+10],edx
       jbe       short M04_L23
       mov       r10d,r9d
M04_L21:
       lea       edx,[r10+rdi]
       test      edx,edx
       jge       near ptr M04_L31
       jmp       near ptr M04_L52
M04_L22:
       cmp       edx,4
       jne       short M04_L23
       mov       r9,4B82FA09B5A52CB9
       cmp       rax,r9
       jbe       near ptr M04_L02
M04_L23:
       cmp       edx,0A7C5
       jbe       short M04_L25
       cmp       edx,418937
       jbe       short M04_L24
       mov       r9d,2
       cmp       edx,28F5C28
       jbe       short M04_L28
       jmp       short M04_L26
M04_L24:
       mov       r9d,4
       cmp       edx,68DB8
       jbe       short M04_L28
       jmp       short M04_L26
M04_L25:
       cmp       edx,1AD
       jbe       short M04_L27
       mov       r9d,6
       cmp       edx,10C6
       jbe       short M04_L28
M04_L26:
       dec       r9d
       jmp       short M04_L28
M04_L27:
       mov       r9d,8
       cmp       edx,2A
       ja        short M04_L26
M04_L28:
       lea       r11d,[r9-1]
       shl       r11,4
       cmp       [r10+r11+10],edx
       jne       short M04_L30
       lea       edx,[r9-1]
       shl       rdx,4
       cmp       [r10+rdx+18],rax
       jae       short M04_L29
       dec       r9d
       mov       r10d,r9d
       jmp       near ptr M04_L21
M04_L29:
       mov       r10d,r9d
       jmp       near ptr M04_L21
M04_L30:
       mov       r10d,r9d
       jmp       near ptr M04_L21
M04_L31:
       mov       r14d,r10d
       jmp       near ptr M04_L03
M04_L32:
       lea       r13d,[rcx+rcx]
       cmp       r13d,ecx
       jb        near ptr M04_L49
       cmp       r13d,r8d
       jb        near ptr M04_L06
       ja        near ptr M04_L49
       test      byte ptr [rsp+50],1
       je        near ptr M04_L06
       jmp       near ptr M04_L49
M04_L33:
       mov       r13d,[rsi+4]
       test      r13d,r13d
       jne       short M04_L34
       mov       r13d,[rsi+0C]
M04_L34:
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
       jne       near ptr M04_L42
       xor       eax,eax
       mov       [rsp+58],eax
       mov       rax,[rsp+40]
       mov       rdx,[rsp+48]
       div       r13
       mov       [rsp+40],rdx
       mov       [rsp+50],rax
M04_L35:
       cmp       qword ptr [rsp+40],0
       jne       short M04_L38
       test      edi,edi
       jge       near ptr M04_L06
       mov       r14d,edi
       neg       r14d
       cmp       r14d,9
       jge       short M04_L36
       mov       ecx,r14d
       jmp       short M04_L37
M04_L36:
       mov       ecx,9
M04_L37:
       mov       r14d,ecx
       jmp       short M04_L39
M04_L38:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M04_L40
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FFBB4566520]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       r14d,eax
       test      r14d,r14d
       je        short M04_L40
M04_L39:
       cmp       r14d,0A
       jae       near ptr M04_L53
       mov       ecx,r14d
       mov       rdx,7FFC0CC236D0
       mov       r15d,[rdx+rcx*4]
       add       edi,r14d
       lea       rcx,[rsp+50]
       mov       edx,r15d
       call      qword ptr [7FFBB45665B0]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L52
       lea       rcx,[rsp+40]
       mov       edx,r15d
       call      qword ptr [7FFBB45E5A88]
       lea       rcx,[rsp+40]
       mov       rdx,r13
       call      qword ptr [7FFBB45E5AA0]
       mov       edx,eax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFBB45665E0]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L35
       jmp       short M04_L41
M04_L40:
       mov       rcx,[rsp+40]
       test      rcx,rcx
       jl        near ptr M04_L49
       add       rcx,rcx
       cmp       rcx,r13
       ja        near ptr M04_L49
       jne       near ptr M04_L06
       test      byte ptr [rsp+50],1
       je        near ptr M04_L06
       jmp       near ptr M04_L49
M04_L41:
       cmp       qword ptr [rsp+40],0
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FFBB45E5A70]
       mov       edi,eax
       jmp       near ptr M04_L06
M04_L42:
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
       call      qword ptr [7FFBB45E5AB8]
       mov       ecx,eax
       mov       [rsp+50],rcx
       xor       ecx,ecx
       mov       [rsp+58],ecx
M04_L43:
       mov       ecx,[rsp+48]
       or        rcx,[rsp+40]
       jne       short M04_L46
       test      edi,edi
       jge       near ptr M04_L06
       mov       r14d,edi
       neg       r14d
       cmp       r14d,9
       jge       short M04_L44
       mov       ecx,r14d
       jmp       short M04_L45
M04_L44:
       mov       ecx,9
M04_L45:
       jmp       short M04_L47
M04_L46:
       mov       ebp,1
       cmp       edi,1C
       je        near ptr M04_L48
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FFBB4566520]; System.Decimal+DecCalc.SearchScale(Buf12 ByRef, Int32)
       mov       ecx,eax
       test      ecx,ecx
       je        near ptr M04_L48
M04_L47:
       cmp       ecx,0A
       jae       near ptr M04_L53
       mov       edx,ecx
       mov       rax,7FFC0CC236D0
       mov       r15d,[rax+rdx*4]
       add       edi,ecx
       lea       rcx,[rsp+50]
       mov       edx,r15d
       call      qword ptr [7FFBB45665B0]; System.Decimal+DecCalc.IncreaseScale(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L52
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
       call      qword ptr [7FFBB45E5AB8]
       mov       edx,eax
       lea       rcx,[rsp+50]
       call      qword ptr [7FFBB45665E0]; System.Decimal+DecCalc.Add32To96(Buf12 ByRef, UInt32)
       test      eax,eax
       jne       near ptr M04_L43
       jmp       near ptr M04_L50
M04_L48:
       cmp       dword ptr [rsp+48],0
       jl        short M04_L49
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
       ja        short M04_L49
       mov       ecx,[rsp+48]
       cmp       ecx,[rsp+38]
       jne       near ptr M04_L06
       mov       rcx,[rsp+40]
       cmp       rcx,[rsp+30]
       ja        short M04_L49
       mov       rcx,[rsp+40]
       cmp       rcx,[rsp+30]
       jne       near ptr M04_L06
       test      byte ptr [rsp+50],1
       je        near ptr M04_L06
M04_L49:
       mov       rcx,[rsp+50]
       inc       rcx
       mov       [rsp+50],rcx
       test      rcx,rcx
       jne       near ptr M04_L06
       jmp       short M04_L51
M04_L50:
       mov       r8,[rsp+40]
       or        r8,[rsp+48]
       setne     r8b
       movzx     r8d,r8b
       lea       rcx,[rsp+50]
       mov       edx,edi
       call      qword ptr [7FFBB45E5A70]
       mov       edi,eax
       jmp       near ptr M04_L06
M04_L51:
       mov       ecx,[rsp+58]
       inc       ecx
       mov       [rsp+58],ecx
       test      ecx,ecx
       jne       near ptr M04_L06
       lea       rcx,[rsp+50]
       mov       edx,edi
       mov       r8d,1
       call      qword ptr [7FFBB45E5A70]
       mov       edi,eax
       jmp       near ptr M04_L06
M04_L52:
       mov       ecx,0F405
       mov       rdx,7FFBB3E54000
       call      qword ptr [7FFBB41377C8]
       mov       rcx,rax
       call      qword ptr [7FFBB45E5938]
       mov       rcx,rax
       call      qword ptr [7FFBB45E5950]
       int       3
M04_L53:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2146
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Decimal, System.Private.CoreLib]](System.Decimal ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateDomainExtension()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,260910012F8
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
       call      qword ptr [7FFBB4554678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFBB4294240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 143
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
       mov       rax,7FFBB4354D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45D54B8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4294528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4AE0]
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       byte ptr [rsp+70],1
       mov       dword ptr [rsp+74],1
       mov       byte ptr [rsp+70],1
       mov       dword ptr [rsp+74],1
       mov       ecx,5
       mov       edx,19
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4565008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       byte ptr [rsp+68],1
       mov       dword ptr [rsp+6C],1
       mov       byte ptr [rsp+68],1
       mov       dword ptr [rsp+6C],1
       mov       ecx,5
       mov       edx,0F
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4565008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       mov       rcx,153900012F8
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
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       mov       rcx,15390001378
       mov       r12,[rcx]
       test      r12,r12
       je        near ptr M00_L05
M00_L01:
       test      r13d,r13d
       jle       near ptr M00_L06
       movsxd    rdx,r13d
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       [rsp+30],rax
       cmp       [rax],al
       lea       r10,[rax+0C]
       mov       [rsp+28],r10
       mov       r8,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GenerateEmailAddress>b__40_0(System.Span`1<Char>, System.ValueTuple`3<System.String,System.String,System.String>)
       cmp       [r12+18],r8
       jne       near ptr M00_L10
       lea       rdx,[rsi+0C]
       mov       r8d,r14d
       cmp       r8d,r13d
       ja        near ptr M00_L09
       add       r8,r8
       mov       rcx,r10
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8d,r14d
       add       r8d,1
       jo        near ptr M00_L12
       mov       esi,r8d
       cmp       r14d,r13d
       jae       near ptr M00_L11
       mov       r8d,r14d
       mov       r12,[rsp+28]
       mov       word ptr [r12+r8*2],40
       lea       rdx,[rdi+0C]
       mov       r8d,r15d
       cmp       esi,r13d
       ja        near ptr M00_L08
       mov       ecx,esi
       lea       rcx,[r12+rcx*2]
       mov       eax,r13d
       sub       eax,esi
       cmp       r8d,eax
       ja        near ptr M00_L09
       add       r8,r8
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,esi
       jo        near ptr M00_L12
       mov       esi,r15d
       mov       r8d,esi
       mov       esi,r8d
       add       esi,1
       jo        near ptr M00_L12
       cmp       r8d,r13d
       jae       near ptr M00_L11
       mov       word ptr [r12+r8*2],2E
       lea       rdx,[rbp+0C]
       mov       r8d,[rbp+8]
       cmp       esi,r13d
       ja        near ptr M00_L08
       mov       ecx,esi
       lea       rcx,[r12+rcx*2]
       sub       r13d,esi
       cmp       r8d,r13d
       ja        near ptr M00_L09
       add       r8,r8
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L02:
       mov       rsi,[rsp+30]
M00_L03:
       mov       [rsp+60],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+60]
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
       call      qword ptr [7FFBB42A4240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       jmp       near ptr M00_L00
M00_L05:
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.ValueTuple<System.String, System.String, System.String>>
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rdx,15390001370
       mov       rdx,[rdx]
       mov       rcx,r12
       mov       r8,offset DotNetTips.Spargine.Tester.RandomData+<>c.<GenerateEmailAddress>b__40_0(System.Span`1<Char>, System.ValueTuple`3<System.String,System.String,System.String>)
       call      qword ptr [7FFBB3F16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,15390001378
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L01
M00_L06:
       test      r13d,r13d
       jne       short M00_L07
       mov       rsi,19424F50008
       jmp       near ptr M00_L03
M00_L07:
       mov       ecx,28
       call      qword ptr [7FFBB4137900]
       int       3
M00_L08:
       call      qword ptr [7FFBB40871C8]
       int       3
M00_L09:
       call      qword ptr [7FFBB435D2D8]
       int       3
M00_L10:
       mov       [rsp+50],r10
       mov       [rsp+58],r13d
       mov       [rsp+38],rsi
       mov       [rsp+40],rdi
       mov       [rsp+48],rbp
       lea       rdx,[rsp+50]
       lea       r8,[rsp+38]
       mov       rcx,[r12+8]
       call      qword ptr [r12+18]
       jmp       near ptr M00_L02
M00_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 824
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45E5578]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4BA0]
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
       mov       rax,0D9AC665908
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
       mov       rax,7FFBB4364D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,0D9AC665908
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
       call      qword ptr [7FFBB44CFFA8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB44CFFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45E6478]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,19424F52288
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4BA0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15390001E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E10]
       mov       [rbp+28],rax
       mov       rcx,15390000C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41DFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4355188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB435CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F11548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,15390001E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E18]
       mov       rcx,15390000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45351E8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,15390001E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E18]
       mov       rcx,15390000C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1127
```
```assembly
; DotNetTips.Spargine.Tester.RandomData+<>c.<GenerateEmailAddress>b__40_0(System.Span`1<Char>, System.ValueTuple`3<System.String,System.String,System.String>)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rbx,[r8]
       mov       rsi,[r8+8]
       mov       rdi,[r8+10]
       mov       rbp,[rdx]
       mov       r14d,[rdx+8]
       test      rbx,rbx
       jne       near ptr M03_L03
       xor       edx,edx
       xor       r8d,r8d
M03_L00:
       cmp       r8d,r14d
       jg        near ptr M03_L07
       mov       r8d,r8d
       add       r8,r8
       mov       rcx,rbp
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ebx,[rbx+8]
       mov       r8d,ebx
       add       r8d,1
       jo        near ptr M03_L09
       mov       r15d,r8d
       cmp       ebx,r14d
       jae       near ptr M03_L08
       mov       r8d,ebx
       mov       word ptr [rbp+r8*2],40
       test      rsi,rsi
       jne       near ptr M03_L04
       xor       edx,edx
       xor       r8d,r8d
M03_L01:
       cmp       r15d,r14d
       ja        near ptr M03_L06
       mov       ecx,r15d
       lea       rcx,[rbp+rcx*2]
       mov       eax,r14d
       sub       eax,r15d
       cmp       r8d,eax
       ja        near ptr M03_L07
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       r15d,[rsi+8]
       jo        near ptr M03_L09
       mov       r8d,r15d
       mov       r15d,r8d
       add       r15d,1
       jo        near ptr M03_L09
       cmp       r8d,r14d
       jae       short M03_L08
       mov       word ptr [rbp+r8*2],2E
       test      rdi,rdi
       jne       short M03_L05
       xor       edx,edx
       xor       r8d,r8d
M03_L02:
       cmp       r15d,r14d
       ja        short M03_L06
       mov       ecx,r15d
       lea       rcx,[rbp+rcx*2]
       sub       r14d,r15d
       cmp       r8d,r14d
       ja        short M03_L07
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M03_L03:
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       jmp       near ptr M03_L00
M03_L04:
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       jmp       near ptr M03_L01
M03_L05:
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       jmp       short M03_L02
M03_L06:
       call      qword ptr [7FFBB40871C8]
       int       3
M03_L07:
       call      qword ptr [7FFBB435D2D8]
       int       3
M03_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M03_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 323
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
       jmp       qword ptr [7FFBB3F166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M05_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFBB45E4E10]
       int       3
; Total bytes of code 44
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateFirstName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,1EF51801310
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
       call      qword ptr [7FFBB45141B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFBB4274240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 143
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
       mov       rax,7FFBB4334D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45B58C0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4274528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4F18]
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateGuid()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+0B0]
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-40],rax
       mov       [rbp+10],rcx
       lea       rcx,[rbp-90]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp-78],rcx
       mov       rcx,rbp
       mov       [rbp-68],rcx
       lea       rcx,[rbp-48]
       mov       rax,7FFBB4221FF0
       mov       [rbp-80],rax
       lea       rax,[M00_L00]
       mov       [rbp-70],rax
       lea       rax,[rbp-90]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3CED0930
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-88]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       short M00_L02
       vmovups   xmm0,[rbp-48]
       vmovups   [rbp-58],xmm0
       mov       rbx,[rbp+10]
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-58]
       call      qword ptr [7FFBB454E6B8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Guid, System.Private.CoreLib]](System.Guid ByRef)
       nop
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L02:
       mov       ecx,eax
       call      qword ptr [7FFBB45C5380]
       int       3
; Total bytes of code 220
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.Guid, System.Private.CoreLib]](System.Guid ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateHashString()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       ecx,20
       call      qword ptr [7FFBB42AECD0]; DotNetTips.Spargine.Tester.RandomData.GenerateHashString(Int32)
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
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateHashString(Int32)
; 		length = length.ArgumentInRange(min: 1, max: 128, defaultValue: 32);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		var byteCount = (length + 1) / 2;
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		Span<byte> bytes = stackalloc byte[byteCount];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		RandomNumberGenerator.Fill(bytes);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 		return Convert.ToHexStringLower(bytes)[..length];
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0A8
       vzeroupper
       lea       rbp,[rsp+20]
       xor       eax,eax
       mov       [rbp+18],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       vmovdqu   ymmword ptr [rbp+40],ymm4
       vmovdqu   ymmword ptr [rbp+60],ymm4
       mov       [rbp+80],rax
       mov       rax,0FB4EEE442CE8
       mov       [rbp+8],rax
       mov       ebx,ecx
       lea       rcx,[rbp+28]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rcx,rsp
       mov       [rbp+40],rcx
       mov       rcx,rbp
       mov       [rbp+50],rcx
       mov       byte ptr [rbp+80],1
       mov       dword ptr [rbp+84],20
       xor       ecx,ecx
       cmp       ebx,80
       setle     al
       movzx     eax,al
       test      ebx,ebx
       cmovg     ecx,eax
       test      ecx,ecx
       je        near ptr M01_L14
M01_L00:
       mov       edi,ebx
       add       edi,1
       jo        near ptr M01_L24
       mov       r14d,edi
       shr       r14d,1F
       add       edi,r14d
       sar       edi,1
       mov       edx,edi
       mov       r14,rdx
       test      r14,r14
       je        short M01_L02
       add       r14,0F
       shr       r14,4
       add       rsp,20
M01_L01:
       push      0
       push      0
       dec       r14
       jne       short M01_L01
       sub       rsp,20
       lea       r14,[rsp+20]
M01_L02:
       test      edi,edi
       jl        near ptr M01_L17
       mov       [rbp+10],r14
       test      edi,edi
       jle       short M01_L05
       mov       rdx,r14
       mov       [rbp+78],rdx
       mov       r8d,edi
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4364D88
       mov       [rbp+38],rax
       lea       rax,[M01_L03]
       mov       [rbp+48],rax
       lea       rax,[rbp+28]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L03:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L04
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M01_L04:
       mov       rcx,[rbp+30]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M01_L18
       xor       eax,eax
       mov       [rbp+78],rax
       mov       r14,[rbp+10]
M01_L05:
       xor       ecx,ecx
       mov       [rbp+78],rcx
       test      edi,edi
       je        near ptr M01_L19
       cmp       edi,3FFFFFFF
       jl        short M01_L06
       cmp       edi,3FFFFFFF
       jg        near ptr M01_L20
M01_L06:
       mov       rcx,2DB9F001EA8
       mov       rsi,[rcx]
       lea       r15d,[rdi+rdi]
       mov       [rbp+60],r14
       mov       [rbp+68],edi
       mov       dword ptr [rbp+70],2020
       test      rsi,rsi
       jne       short M01_L07
       mov       rcx,offset MT_System.Buffers.SpanAction<System.Char, System.HexConverter+SpanCasingPair>
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,2DB9F001EA0
       mov       rdx,[rcx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset System.HexConverter+<>c.<ToString>b__7_0(System.Span`1<Char>, SpanCasingPair)
       mov       [rsi+18],rcx
       mov       rcx,2DB9F001EA8
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
M01_L07:
       test      r15d,r15d
       jle       near ptr M01_L12
       mov       edx,r15d
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rdx,[rdi+0C]
       mov       [rbp+18],rdx
       mov       [rbp+20],r15d
       lea       rdx,[rbp+18]
       lea       r8,[rbp+60]
       mov       rcx,[rsi+8]
       call      qword ptr [rsi+18]
M01_L08:
       mov       rcx,rdi
M01_L09:
       mov       r8d,[rcx+8]
       cmp       r8d,ebx
       jb        near ptr M01_L21
       test      ebx,ebx
       je        near ptr M01_L22
       cmp       r8d,ebx
       jne       near ptr M01_L23
       mov       rax,rcx
M01_L10:
       mov       r8,0FB4EEE442CE8
       cmp       [rbp+8],r8
       je        short M01_L11
       call      CORINFO_HELP_FAIL_FAST
M01_L11:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L12:
       test      r15d,r15d
       je        short M01_L13
       mov       ecx,28
       call      qword ptr [7FFBB4137900]
       int       3
M01_L13:
       mov       rdi,31C33F50008
       jmp       short M01_L08
M01_L14:
       movzx     ecx,byte ptr [rbp+80]
       test      cl,cl
       je        short M01_L15
       lea       rcx,[rbp+80]
       call      qword ptr [7FFBB44CFFA8]
       mov       ebx,eax
       jmp       near ptr M01_L00
M01_L15:
       call      qword ptr [7FFBB44CFFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M01_L16
       call      qword ptr [7FFBB45E62E0]
       mov       rbx,rax
M01_L16:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,31C33F52288
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L17:
       call      qword ptr [7FFBB40871C8]
       int       3
M01_L18:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4B10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M01_L19:
       mov       rcx,31C33F50008
       jmp       near ptr M01_L09
M01_L20:
       mov       ecx,11AD
       mov       rdx,7FFBB3E54000
       call      qword ptr [7FFBB41377C8]
       mov       r8,rax
       mov       ecx,edi
       mov       edx,3FFFFFFF
       call      qword ptr [7FFBB45E5470]
       int       3
M01_L21:
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFBB45E5188]
       int       3
M01_L22:
       mov       rax,31C33F50008
       jmp       near ptr M01_L10
M01_L23:
       mov       r8d,ebx
       xor       edx,edx
       call      qword ptr [7FFBB45E62B0]
       jmp       near ptr M01_L10
M01_L24:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 874
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateInteger()
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       ecx,80000000
       mov       edx,7FFFFFFF
       call      qword ptr [7FFBB4574E28]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       rcx,[rbx+90]
       mov       [rcx+38],eax
       add       rsp,20
       pop       rbx
       ret
; Total bytes of code 40
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
       mov       rax,7FFBB4384D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45EC900]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42B50C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45EC228]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 342
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateIPv4Address()
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
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-0D0],ymm4
       vmovdqu   ymmword ptr [rbp-0B0],ymm4
       vmovdqu   ymmword ptr [rbp-90],ymm4
       vmovdqu   ymmword ptr [rbp-70],ymm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       mov       rax,384529E79687
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0C0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0A8],rdx
       mov       rdx,rbp
       mov       [rbp-98],rdx
       mov       [rbp-0E0],rbx
       lea       rdi,[rbp-48]
       mov       [rbp-0D8],rdi
       mov       [rbp-80],rdi
       mov       rdx,rdi
       xor       ecx,ecx
       mov       r8d,4
       mov       r9d,2
       mov       rax,7FFBB4334D88
       mov       [rbp-0B0],rax
       lea       rax,[M00_L00]
       mov       [rbp-0A0],rax
       lea       rax,[rbp-0C0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-0B8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L09
       xor       ecx,ecx
       mov       [rbp-80],rcx
       mov       [rbp-70],rcx
       mov       rcx,1E07A800C88
       mov       rbx,[rcx]
       mov       rcx,1E07A800C90
       mov       rsi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L10
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L10
M00_L02:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L12
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L12
       mov       rdi,[rcx+50]
       test      rdi,rdi
       je        near ptr M00_L12
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L11
M00_L03:
       mov       [rbp-68],rdi
       lea       rdx,[rdi+10]
       mov       ecx,[rdi+8]
       mov       [rbp-58],rdx
       mov       [rbp-50],ecx
       xor       edx,edx
       mov       [rbp-60],edx
       mov       byte ptr [rbp-5C],0
       mov       rdi,[rbp-0D8]
       movzx     edx,byte ptr [rdi]
       lea       rcx,[rbp-70]
       call      qword ptr [7FFBB4516580]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte)
       mov       ecx,[rbp-60]
       mov       edx,[rbp-50]
       cmp       ecx,edx
       ja        near ptr M00_L29
       mov       rax,[rbp-58]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L26
       mov       rbx,2210F990658
       mov       word ptr [rax],2E
       mov       ecx,[rbp-60]
       inc       ecx
       mov       [rbp-60],ecx
M00_L04:
       movzx     edx,byte ptr [rdi+1]
       lea       rcx,[rbp-70]
       call      qword ptr [7FFBB4516580]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte)
       mov       ecx,[rbp-60]
       mov       edx,[rbp-50]
       cmp       ecx,edx
       ja        near ptr M00_L29
       mov       rax,[rbp-58]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L27
       mov       word ptr [rax],2E
       mov       ecx,[rbp-60]
       inc       ecx
       mov       [rbp-60],ecx
M00_L05:
       movzx     edx,byte ptr [rdi+2]
       lea       rcx,[rbp-70]
       call      qword ptr [7FFBB4516580]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte)
       mov       ecx,[rbp-60]
       mov       edx,[rbp-50]
       cmp       ecx,edx
       ja        near ptr M00_L29
       mov       rax,[rbp-58]
       mov       r8d,ecx
       lea       rax,[rax+r8*2]
       sub       edx,ecx
       je        near ptr M00_L28
       mov       word ptr [rax],2E
       mov       ecx,[rbp-60]
       inc       ecx
       mov       [rbp-60],ecx
M00_L06:
       movzx     edx,byte ptr [rdi+3]
       lea       rcx,[rbp-70]
       call      qword ptr [7FFBB4516580]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte)
       mov       ecx,[rbp-60]
       cmp       ecx,[rbp-50]
       ja        near ptr M00_L29
       mov       rax,[rbp-58]
       mov       [rbp-0D0],rax
       mov       [rbp-0C8],ecx
       lea       rcx,[rbp-0D0]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rbp-68]
       xor       ecx,ecx
       mov       [rbp-68],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rbp-58],xmm0
       mov       [rbp-60],ecx
       test      rdx,rdx
       je        short M00_L07
       mov       rcx,1E07A800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBB41AFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M00_L07:
       mov       [rbp-88],rbx
       mov       rbx,[rbp-0E0]
       mov       rbx,[rbx+90]
       mov       rdx,[rbp-88]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rbx+8],rax
       mov       r8,384529E79687
       cmp       [rbp-40],r8
       je        short M00_L08
       call      CORINFO_HELP_FAIL_FAST
M00_L08:
       nop
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
M00_L09:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4F18]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L10:
       mov       ecx,3
       call      qword ptr [7FFBB45B5038]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L02
M00_L11:
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFBB45B5860]
       jmp       near ptr M00_L03
M00_L12:
       mov       rcx,[rbx+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L24
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L23
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E2B17C],0
       je        short M00_L13
       call      qword ptr [7FFBB45B5878]
       mov       r14d,eax
       jmp       short M00_L15
M00_L13:
       mov       ecx,9
       call      qword ptr [7FFBB45B5890]
       mov       r14d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFBB45B5890]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M00_L14
       call      qword ptr [7FFBB45B58A8]
       mov       r14d,eax
       jmp       short M00_L15
M00_L14:
       sar       r14d,10
M00_L15:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFBB3E2B170]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       short M00_L19
M00_L16:
       cmp       r14d,[rdi+8]
       jae       near ptr M00_L30
       mov       ecx,r14d
       mov       r13,[rdi+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFBB441E538]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L17
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M00_L17:
       mov       rcx,r13
       call      qword ptr [7FFBB3EE6820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M00_L20
       inc       r14d
       cmp       [rdi+8],r14d
       jne       short M00_L18
       xor       r14d,r14d
M00_L18:
       inc       r15d
M00_L19:
       cmp       [rdi+8],r15d
       jg        short M00_L16
       jmp       short M00_L21
M00_L20:
       mov       rdi,r12
       jmp       short M00_L22
M00_L21:
       xor       edi,edi
M00_L22:
       test      rdi,rdi
       je        short M00_L23
       cmp       byte ptr [rsi+9D],0
       je        near ptr M00_L03
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFBB45B5860]
       jmp       near ptr M00_L03
M00_L23:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       cmp       byte ptr [rsi+9D],0
       je        near ptr M00_L03
       jmp       short M00_L25
M00_L24:
       mov       ecx,100
       mov       rdx,2210F996F28
       call      qword ptr [7FFBB410DBC0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L23
M00_L25:
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,100
       mov       rcx,rsi
       call      qword ptr [7FFBB45B5860]
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,100
       call      qword ptr [7FFBB45B58C0]
       jmp       near ptr M00_L03
M00_L26:
       lea       rcx,[rbp-70]
       mov       rbx,2210F990658
       mov       rdx,rbx
       call      qword ptr [7FFBB4517CF0]
       jmp       near ptr M00_L04
M00_L27:
       lea       rcx,[rbp-70]
       mov       rdx,rbx
       call      qword ptr [7FFBB4517CF0]
       jmp       near ptr M00_L05
M00_L28:
       lea       rcx,[rbp-70]
       mov       rdx,rbx
       call      qword ptr [7FFBB4517CF0]
       jmp       near ptr M00_L06
M00_L29:
       call      qword ptr [7FFBB40571C8]
       int       3
M00_L30:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1502
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte)
       push      rsi
       push      rbx
       sub       rsp,38
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       esi,edx
       cmp       byte ptr [rbx+14],0
       jne       near ptr M01_L07
M01_L00:
       movzx     ecx,sil
       lea       rax,[rbx+18]
       mov       edx,[rbx+10]
       mov       r8d,[rax+8]
       cmp       edx,r8d
       ja        near ptr M01_L10
       mov       rax,[rax]
       mov       r10d,edx
       lea       rax,[rax+r10*2]
       sub       r8d,edx
       mov       edx,ecx
       or        edx,1
       lzcnt     edx,edx
       xor       edx,1F
       mov       r10d,ecx
       mov       r9,7FFC0CC1C3D8
       add       r10,[r9+rdx*8]
       sar       r10,20
       cmp       r10d,r8d
       jg        near ptr M01_L09
       mov       [rsp+30],r10d
       mov       [rsp+28],rax
       movsxd    rdx,r10d
       lea       rax,[rax+rdx*2]
       cmp       ecx,0A
       jb        near ptr M01_L06
       cmp       ecx,64
       jb        short M01_L02
       mov       rdx,2210F991234
M01_L01:
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
       jae       short M01_L01
M01_L02:
       cmp       ecx,0A
       jb        short M01_L06
       add       rax,0FFFFFFFFFFFFFFFC
       mov       rdx,2210F991234
       shl       ecx,2
       mov       ecx,[rdx+rcx]
       mov       [rax],ecx
M01_L03:
       xor       ecx,ecx
       mov       [rsp+28],rcx
       mov       ecx,1
M01_L04:
       xor       eax,eax
       mov       [rsp+28],rax
       test      ecx,ecx
       je        short M01_L08
       mov       eax,[rsp+30]
       add       [rbx+10],eax
M01_L05:
       add       rsp,38
       pop       rbx
       pop       rsi
       ret
M01_L06:
       add       ecx,30
       mov       [rax-2],cx
       jmp       short M01_L03
M01_L07:
       movzx     edx,sil
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFBB4516598]
       jmp       short M01_L05
M01_L08:
       mov       rcx,rbx
       call      qword ptr [7FFBB45165C8]
       jmp       near ptr M01_L00
M01_L09:
       xor       ecx,ecx
       mov       [rsp+30],ecx
       jmp       short M01_L04
M01_L10:
       call      qword ptr [7FFBB40571C8]
       int       3
; Total bytes of code 314
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
       je        short M02_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L00:
       mov       rax,2210F990008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M03_L05
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M03_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M03_L06
M03_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M03_L07
M03_L01:
       xor       r13d,r13d
       mov       r12d,1
       mov       ecx,[r15+8]
       cmp       ecx,r14d
       jbe       short M03_L03
       mov       r13d,1
       test      sil,sil
       jne       near ptr M03_L08
M03_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M03_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M03_L10
M03_L03:
       mov       rcx,1E07A800C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M03_L25
M03_L04:
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
M03_L05:
       mov       ecx,2
       call      qword ptr [7FFBB410C258]
       int       3
M03_L06:
       mov       ecx,3
       call      qword ptr [7FFBB45B5038]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M03_L00
M03_L07:
       mov       rcx,rdi
       call      qword ptr [7FFBB410CEB8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M03_L01
M03_L08:
       mov       rcx,rbx
       call      qword ptr [7FFBB45B5938]
       jmp       near ptr M03_L02
M03_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFBB45B5950]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFBB4276418]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M03_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M03_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M03_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFBB45B5968]
M03_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E2B17C],0
       je        short M03_L12
       call      qword ptr [7FFBB45B5878]
       mov       esi,eax
       jmp       short M03_L14
M03_L12:
       mov       ecx,9
       call      qword ptr [7FFBB45B5890]
       mov       esi,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFBB45B5890]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M03_L13
       call      qword ptr [7FFBB45B58A8]
       mov       esi,eax
       jmp       short M03_L14
M03_L13:
       sar       esi,10
M03_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFBB3E2B170]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M03_L21
M03_L15:
       cmp       esi,[r12+8]
       jae       near ptr M03_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFBB441E538]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M03_L17
       test      r8d,r8d
       jne       short M03_L18
       xor       edx,edx
       mov       [rax+14],edx
M03_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M03_L17:
       mov       rcx,rax
       call      qword ptr [7FFBB3EE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M03_L19
       jmp       short M03_L22
M03_L18:
       jmp       short M03_L16
M03_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M03_L20
       xor       esi,esi
M03_L20:
       mov       eax,[rsp+40]
       inc       eax
M03_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M03_L15
       jmp       short M03_L23
M03_L22:
       mov       r12d,1
       jmp       short M03_L24
M03_L23:
       xor       r12d,r12d
M03_L24:
       jmp       near ptr M03_L03
M03_L25:
       test      ebp,ebp
       je        near ptr M03_L04
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFBB45B5980]
       test      r12d,r13d
       jne       near ptr M03_L04
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M03_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M03_L27
M03_L26:
       mov       ecx,r14d
       xor       edx,edx
M03_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFBB45B5998]
       jmp       near ptr M03_L04
M03_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 880
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       mov       rcx,rbx
       call      qword ptr [7FFC0D8A4DC8]
       test      eax,eax
       je        short M05_L00
       add       rsp,20
       pop       rbx
       ret
M05_L00:
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
       jne       short M06_L00
       ret
M06_L00:
       jmp       qword ptr [7FFBB410E340]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M07_L01
       mov       rcx,rbx
       call      qword ptr [7FFC0D8A1BD8]
       test      eax,eax
       je        short M07_L00
       add       rsp,20
       pop       rbx
       ret
M07_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M07_L01:
       xor       ecx,ecx
       call      qword ptr [7FFC0D89C210]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M08_L00
       mov       rcx,rbx
       call      00007FFC13B9E040
       test      eax,eax
       jne       short M08_L01
       add       rsp,20
       pop       rbx
       ret
M08_L00:
       xor       ecx,ecx
       call      qword ptr [7FFBB45B4D68]
       int       3
M08_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFBB45B4E70]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M09_L00
       add       rsp,28
       ret
M09_L00:
       call      qword ptr [7FFC0D8B1908]
       int       3
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateIPv6Address()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,108
       vzeroupper
       lea       rbp,[rsp+140]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M00_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M00_L00
       mov       rax,787844A94BF3
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-0E0]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-0C8],rdx
       mov       rdx,rbp
       mov       [rbp-0B8],rdx
       mov       [rbp-110],rbx
       lea       rdi,[rbp-50]
       mov       [rbp-108],rdi
       mov       [rbp-88],rdi
       mov       rdx,rdi
       xor       ecx,ecx
       mov       r8d,10
       mov       r9d,2
       mov       rax,7FFBB4354D88
       mov       [rbp-0D0],rax
       lea       rax,[M00_L01]
       mov       [rbp-0C0],rax
       lea       rax,[rbp-0E0]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-0D8]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L15
       xor       ecx,ecx
       mov       [rbp-88],rcx
       mov       [rbp-78],rcx
       mov       rcx,1AFF7800C88
       mov       rbx,[rcx]
       mov       rcx,1AFF7800C90
       mov       rsi,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L16
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L16
M00_L03:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L18
       mov       rdi,[rcx+50]
       test      rdi,rdi
       je        near ptr M00_L18
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M00_L17
M00_L04:
       mov       [rbp-70],rdi
       lea       rdx,[rdi+10]
       mov       r9d,[rdi+8]
       mov       [rbp-60],rdx
       mov       [rbp-58],r9d
       xor       edx,edx
       mov       [rbp-68],edx
       mov       byte ptr [rbp-64],0
       mov       rdi,[rbp-108]
       movzx     ebx,byte ptr [rdi]
       cmp       byte ptr [rbp-64],0
       jne       near ptr M00_L32
       mov       esi,[rbp-68]
       cmp       esi,[rbp-58]
       ja        near ptr M00_L40
       mov       r14,1F08C7F0630
       lea       r15,[r14+0C]
M00_L05:
       mov       rdx,[rbp-60]
       mov       r9d,esi
       lea       rdx,[rdx+r9*2]
       mov       r9d,[rbp-58]
       sub       r9d,esi
       mov       r8,r15
       mov       rcx,[rbp-78]
       mov       eax,ebx
       mov       [rbp-0F0],r8
       mov       dword ptr [rbp-0E8],2
       mov       [rbp-100],rdx
       mov       [rbp-0F8],r9d
       lea       rdx,[rbp-90]
       mov       [rsp+20],rdx
       lea       rdx,[rbp-0F0]
       lea       r9,[rbp-100]
       mov       r8,rcx
       mov       ecx,eax
       call      qword ptr [7FFBB4556AD8]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       test      eax,eax
       je        near ptr M00_L33
       mov       ecx,[rbp-68]
       add       ecx,[rbp-90]
       mov       [rbp-68],ecx
M00_L06:
       movzx     edx,byte ptr [rdi+1]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L34
       mov       rbx,1F08C7E0640
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L07:
       movzx     edx,byte ptr [rdi+2]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+3]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L35
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L08:
       movzx     edx,byte ptr [rdi+4]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+5]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L36
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L09:
       movzx     edx,byte ptr [rdi+6]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+7]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L37
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L10:
       movzx     edx,byte ptr [rdi+8]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+9]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L38
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L11:
       movzx     edx,byte ptr [rdi+0A]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+0B]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L39
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L12:
       movzx     edx,byte ptr [rdi+0C]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+0D]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       mov       ecx,[rbp-68]
       cmp       ecx,[rbp-58]
       ja        near ptr M00_L40
       mov       rdx,[rbp-60]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rbp-58]
       sub       eax,ecx
       je        near ptr M00_L41
       mov       word ptr [rdx],3A
       mov       ecx,[rbp-68]
       inc       ecx
       mov       [rbp-68],ecx
M00_L13:
       movzx     edx,byte ptr [rdi+0E]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       movzx     edx,byte ptr [rdi+0F]
       lea       rcx,[rbp-78]
       mov       r8,r14
       call      qword ptr [7FFBB4556AC0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
       lea       rcx,[rbp-60]
       lea       rdx,[rbp-0A0]
       mov       r9d,[rbp-68]
       xor       r8d,r8d
       call      qword ptr [7FFBB412F180]; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32, Int32)
       mov       rcx,[rbp-0A0]
       mov       eax,[rbp-98]
       mov       [rbp-0F0],rcx
       mov       [rbp-0E8],eax
       lea       rcx,[rbp-0F0]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBB45D6A48]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.Clear()
       mov       [rbp-0A8],rbx
       mov       rbx,[rbp-110]
       mov       rcx,[rbx+90]
       lea       r8,[rbp-0A8]
       mov       rdx,7FFBB45AE300
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455E6B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       r8,787844A94BF3
       cmp       [rbp-40],r8
       je        short M00_L14
       call      CORINFO_HELP_FAIL_FAST
M00_L14:
       nop
       add       rsp,108
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M00_L15:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4AE0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L16:
       mov       ecx,3
       call      qword ptr [7FFBB45D4C00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L03
M00_L17:
       mov       rcx,rdi
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFBB45D5260]
       jmp       near ptr M00_L04
M00_L18:
       mov       rcx,[rbx+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L30
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L29
       mov       rdi,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3F05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E4B17C],0
       je        short M00_L19
       call      qword ptr [7FFBB45D5278]
       mov       r14d,eax
       jmp       short M00_L21
M00_L19:
       mov       ecx,9
       call      qword ptr [7FFBB45D5290]
       mov       r14d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFBB45D5290]
       lea       ecx,[r14-1]
       mov       [rax+10],ecx
       movzx     eax,r14w
       test      eax,eax
       jne       short M00_L20
       call      qword ptr [7FFBB45D52A8]
       mov       r14d,eax
       jmp       short M00_L21
M00_L20:
       sar       r14d,10
M00_L21:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3F05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r14d
       xor       edx,edx
       div       dword ptr [7FFBB3E4B170]
       mov       r14d,edx
       xor       r15d,r15d
       jmp       short M00_L25
M00_L22:
       cmp       r14d,[rdi+8]
       jae       near ptr M00_L42
       mov       ecx,r14d
       mov       r13,[rdi+rcx*8+10]
       cmp       [r13],r13b
       xor       r12d,r12d
       mov       rcx,r13
       call      qword ptr [7FFBB443E238]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r13+8]
       mov       eax,[r13+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L23
       mov       edx,eax
       mov       r12,[rcx+rdx*8+10]
       mov       edx,eax
       xor       r8d,r8d
       mov       [rcx+rdx*8+10],r8
       mov       [r13+10],eax
M00_L23:
       mov       rcx,r13
       call      qword ptr [7FFBB3F06820]; System.Threading.Monitor.Exit(System.Object)
       test      r12,r12
       jne       short M00_L26
       inc       r14d
       cmp       [rdi+8],r14d
       jne       short M00_L24
       xor       r14d,r14d
M00_L24:
       inc       r15d
M00_L25:
       cmp       [rdi+8],r15d
       jg        short M00_L22
       jmp       short M00_L27
M00_L26:
       mov       rdi,r12
       jmp       short M00_L28
M00_L27:
       xor       edi,edi
M00_L28:
       test      rdi,rdi
       je        short M00_L29
       cmp       byte ptr [rsi+9D],0
       je        near ptr M00_L04
       mov       rcx,rdi
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       r15d,[rdi+8]
       mov       rcx,rbx
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r14d
       mov       r8d,r15d
       mov       rcx,rsi
       call      qword ptr [7FFBB45D5260]
       jmp       near ptr M00_L04
M00_L29:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rdi,rax
       cmp       byte ptr [rsi+9D],0
       je        near ptr M00_L04
       jmp       short M00_L31
M00_L30:
       mov       ecx,100
       mov       rdx,1F08C7E6F28
       call      qword ptr [7FFBB412DBC0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L29
M00_L31:
       mov       rcx,rdi
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r14d,eax
       mov       rcx,rbx
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r14d
       mov       r8d,100
       mov       rcx,rsi
       call      qword ptr [7FFBB45D5260]
       mov       rcx,rbx
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       rcx,[rbx+10]
       mov       edx,1
       mov       r8d,2
       cmp       dword ptr [rcx+8],4
       cmovg     edx,r8d
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,r14d
       mov       r8d,100
       call      qword ptr [7FFBB45D52C0]
       jmp       near ptr M00_L04
M00_L32:
       lea       rcx,[rbp-78]
       mov       edx,ebx
       mov       r14,1F08C7F0630
       mov       r8,r14
       call      qword ptr [7FFBB4556A48]
       jmp       near ptr M00_L06
M00_L33:
       lea       rcx,[rbp-78]
       call      qword ptr [7FFBB4556A78]
       mov       esi,[rbp-68]
       cmp       esi,[rbp-58]
       jbe       near ptr M00_L05
       jmp       short M00_L40
M00_L34:
       lea       rcx,[rbp-78]
       mov       rbx,1F08C7E0640
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L07
M00_L35:
       lea       rcx,[rbp-78]
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L08
M00_L36:
       lea       rcx,[rbp-78]
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L09
M00_L37:
       lea       rcx,[rbp-78]
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L10
M00_L38:
       lea       rcx,[rbp-78]
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L11
M00_L39:
       lea       rcx,[rbp-78]
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L12
M00_L40:
       call      qword ptr [7FFBB40771C8]
       int       3
M00_L41:
       lea       rcx,[rbp-78]
       mov       rdx,rbx
       call      qword ptr [7FFBB455C1B0]
       jmp       near ptr M00_L13
M00_L42:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2159
```
```assembly
; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,0B8
       lea       rbp,[rsp+30]
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp],ymm4
       vmovdqu   ymmword ptr [rbp+20],ymm4
       vmovdqu   ymmword ptr [rbp+40],ymm4
       vmovdqa   xmmword ptr [rbp+60],xmm4
       mov       rax,787844A94BF3
       mov       [rbp+80],rax
       mov       rbx,[rbp+0F0]
       mov       rsi,r9
       mov       rdi,rdx
       mov       r14d,ecx
       mov       r15,[rdi]
       mov       r13d,[rdi+8]
       xor       r12d,r12d
       test      r13d,r13d
       jle       near ptr M01_L18
       movzx     r12d,word ptr [r15]
       mov       eax,r12d
       or        eax,20
       add       eax,0FFFFFF9F
       cmp       eax,19
       ja        near ptr M01_L18
       cmp       r13d,1
       je        near ptr M01_L10
       cmp       r13d,2
       jne       near ptr M01_L11
       movzx     eax,word ptr [r15+2]
       add       eax,0FFFFFFD0
       cmp       eax,0A
       jae       near ptr M01_L12
       mov       r15d,eax
M01_L00:
       mov       r13d,r12d
       and       r12d,0FFDF
       cmp       r12d,47
       je        near ptr M01_L20
       cmp       r12d,44
       je        near ptr M01_L21
M01_L01:
       cmp       r12d,58
       jne       near ptr M01_L23
       mov       rax,[rsi]
       mov       r8d,[rsi+8]
       mov       ecx,1
       test      r15d,r15d
       cmovle    r15d,ecx
       mov       ecx,r14d
       or        rcx,1
       lzcnt     rcx,rcx
       xor       ecx,3F
       sar       ecx,2
       inc       ecx
       cmp       r15d,ecx
       cmovge    ecx,r15d
       cmp       ecx,r8d
       jg        near ptr M01_L09
       mov       [rbx],ecx
       mov       [rbp+28],rax
       movsxd    rcx,ecx
       lea       rax,[rax+rcx*2]
       mov       ecx,r15d
       jmp       short M01_L04
M01_L02:
       lea       r8d,[r13-21]
       movzx     r8d,r8w
M01_L03:
       add       edx,r8d
       mov       [rax],dx
       shr       r14d,4
M01_L04:
       dec       ecx
       js        short M01_L06
M01_L05:
       mov       edx,r14d
       and       edx,0F
       add       rax,0FFFFFFFFFFFFFFFE
       cmp       edx,0A
       jge       short M01_L02
       mov       r8d,30
       jmp       short M01_L03
M01_L06:
       test      r14d,r14d
       jne       short M01_L05
       xor       eax,eax
       mov       [rbp+28],rax
       mov       eax,1
M01_L07:
       mov       r8,787844A94BF3
       cmp       [rbp+80],r8
       je        short M01_L08
       call      CORINFO_HELP_FAIL_FAST
M01_L08:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       xor       eax,eax
       mov       [rbx],eax
       jmp       short M01_L07
M01_L10:
       mov       r15d,0FFFFFFFF
       jmp       near ptr M01_L00
M01_L11:
       cmp       r13d,3
       jne       short M01_L12
       movzx     eax,word ptr [r15+2]
       add       eax,0FFFFFFD0
       movzx     ecx,word ptr [r15+4]
       add       ecx,0FFFFFFD0
       cmp       eax,0A
       jae       short M01_L12
       cmp       ecx,0A
       jae       short M01_L12
       lea       eax,[rax+rax*4]
       lea       r15d,[rcx+rax*2]
       jmp       near ptr M01_L00
M01_L12:
       xor       eax,eax
       mov       ecx,1
       jmp       short M01_L14
M01_L13:
       cmp       eax,5F5E100
       jge       short M01_L15
       lea       edx,[rcx+1]
       mov       ecx,ecx
       movzx     ecx,word ptr [r15+rcx*2]
       lea       eax,[rax+rax*4]
       lea       eax,[rcx+rax*2-30]
       mov       ecx,edx
M01_L14:
       cmp       ecx,r13d
       jae       short M01_L17
       mov       edx,ecx
       movzx     edx,word ptr [r15+rdx*2]
       add       edx,0FFFFFFD0
       cmp       edx,9
       jbe       short M01_L13
       jmp       short M01_L16
M01_L15:
       call      qword ptr [7FFBB45D4F60]
       int       3
M01_L16:
       mov       ecx,ecx
       cmp       word ptr [r15+rcx*2],0
       jne       short M01_L18
M01_L17:
       mov       r15d,eax
       jmp       near ptr M01_L00
M01_L18:
       mov       r15d,0FFFFFFFF
       test      r13d,r13d
       je        short M01_L19
       test      r12d,r12d
       je        short M01_L19
       xor       r12d,r12d
       jmp       near ptr M01_L00
M01_L19:
       mov       r12d,47
       jmp       near ptr M01_L00
M01_L20:
       test      r15d,r15d
       jg        near ptr M01_L01
M01_L21:
       mov       ecx,r14d
       mov       edx,r15d
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [7FFBB45D56B0]
       mov       r8,787844A94BF3
       cmp       [rbp+80],r8
       je        short M01_L22
       call      CORINFO_HELP_FAIL_FAST
M01_L22:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L23:
       cmp       r12d,42
       jne       short M01_L25
       mov       ecx,r14d
       mov       edx,r15d
       mov       r8,rsi
       mov       r9,rbx
       call      qword ptr [7FFBB45D5668]
       mov       r8,787844A94BF3
       cmp       [rbp+80],r8
       je        short M01_L24
       call      CORINFO_HELP_FAIL_FAST
M01_L24:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L25:
       test      r8,r8
       je        short M01_L26
       mov       rcx,r8
       call      qword ptr [7FFBB44B5878]; System.Globalization.NumberFormatInfo.<GetInstance>g__GetProviderNonNull|58_0(System.IFormatProvider)
       mov       r12,rax
       jmp       short M01_L27
M01_L26:
       call      qword ptr [7FFBB4125E00]; System.Globalization.NumberFormatInfo.get_CurrentInfo()
       mov       r12,rax
M01_L27:
       lea       r8,[rbp+70]
       mov       [rbp+10],r8
       mov       dword ptr [rbp+18],0B
       lea       r8,[rbp+10]
       lea       rcx,[rbp+50]
       mov       edx,1
       call      qword ptr [7FFBB45D69B8]
       mov       dword ptr [rbp+50],0A
       mov       byte ptr [rbp+58],0
       lea       rcx,[rbp+50]
       call      qword ptr [7FFBB45D69D0]
       lea       rcx,[rax+0A]
       mov       edx,r14d
       xor       r8d,r8d
       cmp       edx,64
       jb        short M01_L29
M01_L28:
       add       rcx,0FFFFFFFFFFFFFFFE
       add       r8d,0FFFFFFFE
       mov       r10d,edx
       imul      r10,51EB851F
       shr       r10,25
       imul      r9d,r10d,64
       sub       edx,r9d
       add       edx,edx
       mov       r9,7FFC0CC20580
       mov       dx,[r9+rdx]
       mov       [rcx],dx
       cmp       r10d,64
       mov       edx,r10d
       jae       short M01_L28
M01_L29:
       test      edx,edx
       je        short M01_L31
M01_L30:
       dec       r8d
       mov       r10d,0CCCCCCCD
       mov       r9d,edx
       imul      r10,r9
       shr       r10,23
       lea       r9d,[r10+r10*4]
       add       r9d,r9d
       mov       r11d,edx
       sub       r11d,r9d
       mov       edx,r10d
       dec       rcx
       add       r11d,30
       mov       [rcx],r11b
       jmp       short M01_L29
M01_L31:
       test      r8d,r8d
       jg        short M01_L30
       mov       r14,rcx
       add       eax,0A
       sub       eax,ecx
       mov       [rbp+50],eax
       mov       [rbp+24],eax
       mov       [rbp+54],eax
       lea       rcx,[rbp+50]
       call      qword ptr [7FFBB45D69D0]
       jmp       short M01_L33
M01_L32:
       lea       rcx,[rax+1]
       lea       r8,[r14+1]
       movzx     r10d,byte ptr [r14]
       mov       [rax],r10b
       mov       [rbp+24],edx
       mov       rax,rcx
       mov       r14,r8
M01_L33:
       mov       edx,[rbp+24]
       dec       edx
       jns       short M01_L32
       mov       byte ptr [rax],0
       test      [rsp],esp
       sub       rsp,40
       lea       rdx,[rsp+30]
       mov       [rbp],rdx
       mov       dword ptr [rbp+8],20
       lea       rdx,[rbp]
       lea       rcx,[rbp+30]
       call      qword ptr [7FFBB45D69E8]
       test      r13d,r13d
       je        short M01_L34
       mov       [rsp+20],r12
       lea       rcx,[rbp+30]
       lea       rdx,[rbp+50]
       mov       r8d,r13d
       mov       r9d,r15d
       call      qword ptr [7FFBB45D5638]
       jmp       short M01_L35
M01_L34:
       lea       rcx,[rbp+30]
       lea       rdx,[rbp+50]
       mov       r8,rdi
       mov       r9,r12
       call      qword ptr [7FFBB455CB58]; System.Number.NumberToStringFormat[[System.Char, System.Private.CoreLib]](System.Collections.Generic.ValueListBuilder`1<Char> ByRef, NumberBuffer ByRef, System.ReadOnlySpan`1<Char>, System.Globalization.NumberFormatInfo)
M01_L35:
       lea       rcx,[rbp+30]
       mov       rdx,rsi
       mov       r8,rbx
       call      qword ptr [7FFBB45D6A00]
       mov       r15d,eax
       mov       rdx,[rbp+30]
       test      rdx,rdx
       je        short M01_L36
       xor       ecx,ecx
       mov       [rbp+30],rcx
       mov       rcx,1AFF7800C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M01_L36:
       mov       eax,r15d
       mov       r8,787844A94BF3
       cmp       [rbp+80],r8
       je        short M01_L37
       call      CORINFO_HELP_FAIL_FAST
M01_L37:
       nop
       lea       rsp,[rbp+88]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 1169
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Byte, System.Private.CoreLib]](Byte, System.String)
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
       mov       edi,edx
       mov       rsi,r8
       cmp       byte ptr [rbx+14],0
       jne       near ptr M02_L10
M02_L00:
       movzx     ecx,dil
       lea       rdx,[rbx+18]
       mov       r9d,[rbx+10]
       mov       r8d,[rdx+8]
       cmp       r9d,r8d
       ja        near ptr M02_L14
       mov       rdx,[rdx]
       mov       eax,r9d
       lea       rdx,[rdx+rax*2]
       sub       r8d,r9d
       test      rsi,rsi
       jne       near ptr M02_L08
       xor       r9d,r9d
       xor       eax,eax
M02_L01:
       mov       r10,[rbx]
       test      eax,eax
       jne       near ptr M02_L13
       mov       r9d,ecx
       or        r9d,1
       xor       eax,eax
       lzcnt     eax,r9d
       xor       eax,1F
       mov       r9d,ecx
       mov       r10d,eax
       mov       rax,7FFC0CC1C3D8
       add       r9,[rax+r10*8]
       sar       r9,20
       cmp       r9d,r8d
       jg        near ptr M02_L12
       mov       [rsp+50],r9d
       mov       [rsp+48],rdx
       movsxd    r8,r9d
       lea       rdx,[rdx+r8*2]
       cmp       ecx,0A
       jb        near ptr M02_L09
       cmp       ecx,64
       jb        short M02_L03
       mov       r9,1F08C7E1234
M02_L02:
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r8d,ecx
       imul      r8,51EB851F
       shr       r8,25
       imul      eax,r8d,64
       sub       ecx,eax
       mov       rax,r9
       shl       ecx,2
       mov       ecx,[rax+rcx]
       mov       [rdx],ecx
       cmp       r8d,64
       mov       ecx,r8d
       jae       short M02_L02
M02_L03:
       cmp       ecx,0A
       jb        short M02_L09
       add       rdx,0FFFFFFFFFFFFFFFC
       mov       r9,1F08C7E1234
       shl       ecx,2
       mov       r8d,ecx
       mov       r9d,[r9+r8]
       mov       [rdx],r9d
M02_L04:
       xor       edx,edx
       mov       [rsp+48],rdx
       mov       ebp,1
M02_L05:
       xor       edx,edx
       mov       [rsp+48],rdx
M02_L06:
       test      ebp,ebp
       je        short M02_L11
       mov       eax,[rsp+50]
       add       [rbx+10],eax
M02_L07:
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L08:
       lea       r9,[rsi+0C]
       mov       eax,[rsi+8]
       jmp       near ptr M02_L01
M02_L09:
       lea       r9d,[rcx+30]
       mov       [rdx-2],r9w
       jmp       short M02_L04
M02_L10:
       movzx     edx,dil
       mov       rcx,rbx
       mov       r8,rsi
       call      qword ptr [7FFBB4556A48]
       jmp       short M02_L07
M02_L11:
       mov       rcx,rbx
       call      qword ptr [7FFBB4556A78]
       jmp       near ptr M02_L00
M02_L12:
       xor       edx,edx
       mov       [rsp+50],edx
       xor       ebp,ebp
       jmp       short M02_L05
M02_L13:
       mov       [rsp+38],r9
       mov       [rsp+40],eax
       mov       [rsp+28],rdx
       mov       [rsp+30],r8d
       lea       rdx,[rsp+50]
       mov       [rsp+20],rdx
       lea       rdx,[rsp+38]
       lea       r9,[rsp+28]
       mov       r8,r10
       call      qword ptr [7FFBB4556AD8]; System.Number.<TryFormatUInt32>g__TryFormatUInt32Slow|24_0[[System.Char, System.Private.CoreLib]](UInt32, System.ReadOnlySpan`1<Char>, System.IFormatProvider, System.Span`1<Char>, Int32 ByRef)
       mov       ebp,eax
       jmp       near ptr M02_L06
M02_L14:
       call      qword ptr [7FFBB40771C8]
       int       3
; Total bytes of code 439
```
```assembly
; System.Span`1[[System.Char, System.Private.CoreLib]].Slice(Int32, Int32)
       sub       rsp,28
       mov       eax,r8d
       mov       r8d,r9d
       add       r8,rax
       mov       r10d,[rcx+8]
       cmp       r8,r10
       ja        short M03_L00
       mov       rcx,[rcx]
       lea       rax,[rcx+rax*2]
       mov       [rdx],rax
       mov       [rdx+8],r9d
       mov       rax,rdx
       add       rsp,28
       ret
M03_L00:
       call      qword ptr [7FFBB40771C8]
       int       3
; Total bytes of code 51
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
       je        short M04_L00
       mov       edx,esi
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M04_L00:
       mov       rax,1F08C7E0008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.Clear()
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rbx,[rcx+8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       [rcx+18],rax
       mov       [rcx+20],rax
       mov       [rcx+10],eax
       test      rbx,rbx
       je        near ptr M05_L03
       mov       rcx,1AFF7800C88
       mov       rsi,[rcx]
       mov       edi,[rbx+8]
       lea       ecx,[rdi-1]
       or        ecx,0F
       xor       ebp,ebp
       lzcnt     ebp,ecx
       xor       ebp,1F
       add       ebp,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M05_L04
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M05_L04
M05_L00:
       mov       rax,[rax+10]
       test      rax,rax
       je        near ptr M05_L05
M05_L01:
       xor       r14d,r14d
       mov       r15d,1
       mov       ecx,[rax+8]
       cmp       ecx,ebp
       jbe       short M05_L02
       mov       r14d,1
       mov       ecx,10
       shlx      ecx,ecx,ebp
       cmp       edi,ecx
       jne       short M05_L06
       mov       ecx,ebp
       shl       rcx,4
       lea       r13,[rax+rcx+10]
       mov       r12,[r13]
       mov       rcx,r13
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [r13+8],ecx
       test      r12,r12
       jne       near ptr M05_L07
M05_L02:
       mov       rcx,1AFF7800C90
       mov       r13,[rcx]
       cmp       byte ptr [r13+9D],0
       jne       near ptr M05_L22
M05_L03:
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
M05_L04:
       mov       ecx,3
       call      qword ptr [7FFBB45D4C00]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M05_L00
M05_L05:
       mov       rcx,rsi
       call      qword ptr [7FFBB412CEB8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       jmp       near ptr M05_L01
M05_L06:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBB45D5350]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFBB4296418]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M05_L07:
       mov       rcx,[rsi+10]
       cmp       ebp,[rcx+8]
       jae       near ptr M05_L25
       mov       edx,ebp
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M05_L08
       mov       rcx,rsi
       mov       edx,ebp
       call      qword ptr [7FFBB45D5368]
M05_L08:
       mov       r15,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3F05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E4B17C],0
       je        short M05_L09
       call      qword ptr [7FFBB45D5278]
       mov       r13d,eax
       jmp       short M05_L11
M05_L09:
       mov       ecx,9
       call      qword ptr [7FFBB45D5290]
       mov       r13d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFBB45D5290]
       lea       ecx,[r13-1]
       mov       [rax+10],ecx
       movzx     eax,r13w
       test      eax,eax
       jne       short M05_L10
       call      qword ptr [7FFBB45D52A8]
       mov       r13d,eax
       jmp       short M05_L11
M05_L10:
       sar       r13d,10
M05_L11:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3F05740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r13d
       xor       edx,edx
       div       dword ptr [7FFBB3E4B170]
       mov       r13d,edx
       xor       eax,eax
       jmp       near ptr M05_L18
M05_L12:
       cmp       r13d,[r15+8]
       jae       near ptr M05_L25
       mov       ecx,r13d
       mov       rdx,[r15+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFBB443E238]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M05_L14
       test      r8d,r8d
       jne       short M05_L15
       xor       edx,edx
       mov       [rax+14],edx
M05_L13:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M05_L14:
       mov       rcx,rax
       call      qword ptr [7FFBB3F06820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M05_L16
       jmp       short M05_L19
M05_L15:
       jmp       short M05_L13
M05_L16:
       inc       r13d
       cmp       [r15+8],r13d
       jne       short M05_L17
       xor       r13d,r13d
M05_L17:
       mov       eax,[rsp+40]
       inc       eax
M05_L18:
       mov       [rsp+40],eax
       cmp       [r15+8],eax
       jg        near ptr M05_L12
       jmp       short M05_L20
M05_L19:
       mov       r15d,1
       jmp       short M05_L21
M05_L20:
       xor       r15d,r15d
M05_L21:
       jmp       near ptr M05_L02
M05_L22:
       test      edi,edi
       je        near ptr M05_L03
       mov       rcx,rbx
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r12d,eax
       mov       [rsp+44],edi
       mov       rcx,rsi
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,r13
       mov       r8d,r12d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFBB45D5380]
       test      r15d,r14d
       jne       near ptr M05_L03
       mov       rcx,rbx
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rsi
       call      qword ptr [7FFBB434D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r14d,r14d
       jne       short M05_L23
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M05_L24
M05_L23:
       mov       ecx,ebp
       xor       edx,edx
M05_L24:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,r13
       mov       edx,ebx
       mov       r8d,edi
       call      qword ptr [7FFBB45D5398]
       jmp       near ptr M05_L03
M05_L25:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 860
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
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
       mov       ecx,ebx
       and       ecx,0FFFFFF
       mov       edx,ecx
       mov       r8d,ebx
       sar       r8d,18
       jne       short M07_L01
       cmp       [rax],ecx
       jle       short M07_L03
       mov       rax,[rax+8]
       cmp       [rax],al
       add       edx,0FFFFFFFE
       movsxd    rcx,edx
       mov       rax,[rax+rcx*8+10]
       test      rax,rax
       je        short M07_L03
M07_L00:
       add       rsp,20
       pop       rbx
       ret
M07_L01:
       mov       ecx,ebx
       sar       ecx,18
       cmp       ecx,2
       jne       short M07_L02
       movsxd    rcx,edx
       add       rax,rcx
       jmp       short M07_L00
M07_L02:
       cmp       [rax+4],edx
       jle       short M07_L03
       mov       rcx,[rax+10]
       movsxd    rax,edx
       mov       rcx,[rcx+rax*8]
       test      rcx,rcx
       je        short M07_L03
       mov       rax,[rcx]
       test      rax,rax
       je        short M07_L03
       jmp       short M07_L00
M07_L03:
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
       call      qword ptr [7FFC0D8A4DC8]
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
; Total bytes of code 45
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rax,[rcx+20]
       mov       rax,[rax-10]
       mov       rdx,rax
       test      dl,1
       jne       short M09_L00
       ret
M09_L00:
       jmp       qword ptr [7FFBB412E340]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```
```assembly
; System.Threading.Monitor.Enter(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M10_L01
       mov       rcx,rbx
       call      qword ptr [7FFC0D8A1BD8]
       test      eax,eax
       je        short M10_L00
       add       rsp,20
       pop       rbx
       ret
M10_L00:
       mov       rcx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       jmp       qword ptr [rax]
M10_L01:
       xor       ecx,ecx
       call      qword ptr [7FFC0D89C210]
       int       3
; Total bytes of code 59
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M11_L00
       mov       rcx,rbx
       call      00007FFC13B9E040
       test      eax,eax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       xor       ecx,ecx
       call      qword ptr [7FFBB45D4930]
       int       3
M11_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFBB45D4A38]
; Total bytes of code 56
```
```assembly
; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       sub       rsp,28
       test      ecx,ecx
       jl        short M12_L00
       add       rsp,28
       ret
M12_L00:
       call      qword ptr [7FFC0D8B1908]
       int       3
; Total bytes of code 20
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateJsonObject()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp+10],rcx
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],5
       mov       rcx,2398CC01340
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L31
       lea       rcx,[rbx+20]
       mov       r8,[rbp-30]
       test      rcx,rcx
       je        near ptr M00_L30
       xor       edx,edx
       call      00007FFC13B421C0
       cmp       rax,[rbp-30]
       jne       near ptr M00_L31
M00_L00:
       mov       rcx,[rbp-30]
M00_L01:
       xor       edx,edx
       mov       [rbp-30],rdx
       mov       [rbp-40],rcx
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L16
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],7B
       inc       edx
       mov       [rcx+18],edx
M00_L02:
       xor       ebx,ebx
       cmp       ebx,5
       jge       near ptr M00_L14
M00_L03:
       test      ebx,ebx
       jle       short M00_L04
       mov       rdx,[rbp-40]
       mov       esi,[rdx+18]
       mov       ecx,esi
       mov       rax,[rdx+8]
       cmp       [rax+8],ecx
       jbe       near ptr M00_L17
       mov       ecx,ecx
       mov       word ptr [rax+rcx*2+10],2C
       inc       esi
       mov       [rdx+18],esi
M00_L04:
       mov       ecx,5
       mov       edx,0A
       call      qword ptr [7FFBB4534678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4535008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       ecx,5
       mov       edx,0F
       call      qword ptr [7FFBB4534678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4535008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rdi,rax
       mov       rcx,[rbp-40]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L18
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],22
       inc       edx
       mov       [rcx+18],edx
M00_L05:
       test      rsi,rsi
       je        short M00_L07
       lea       rdx,[rsi+0C]
       mov       esi,[rsi+8]
       test      esi,esi
       je        short M00_L07
       mov       r8,[rcx+8]
       mov       r14d,[rcx+18]
       lea       eax,[r14+rsi]
       cmp       eax,[r8+8]
       ja        near ptr M00_L20
       movsxd    rax,r14d
       lea       rax,[r8+rax*2+10]
       cmp       esi,2
       jle       near ptr M00_L19
       mov       r8d,esi
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L06:
       add       esi,r14d
       mov       rcx,[rbp-40]
       mov       [rcx+18],esi
M00_L07:
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L21
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],22
       inc       edx
       mov       [rcx+18],edx
M00_L08:
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L22
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],3A
       inc       edx
       mov       [rcx+18],edx
M00_L09:
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L23
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],22
       inc       edx
       mov       [rcx+18],edx
M00_L10:
       test      rdi,rdi
       je        short M00_L12
       lea       rdx,[rdi+0C]
       mov       esi,[rdi+8]
       test      esi,esi
       je        short M00_L12
       mov       r8,[rcx+8]
       mov       edi,[rcx+18]
       lea       eax,[rdi+rsi]
       cmp       eax,[r8+8]
       ja        near ptr M00_L26
       movsxd    rax,edi
       lea       rax,[r8+rax*2+10]
       cmp       esi,2
       jle       near ptr M00_L24
       mov       r8d,esi
       add       r8,r8
       mov       rcx,rax
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L11:
       add       esi,edi
       mov       rcx,[rbp-40]
       mov       [rcx+18],esi
M00_L12:
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L27
       mov       eax,eax
       mov       word ptr [r8+rax*2+10],22
       inc       edx
       mov       [rcx+18],edx
M00_L13:
       add       ebx,1
       jo        near ptr M00_L25
       cmp       ebx,5
       jl        near ptr M00_L03
M00_L14:
       mov       rcx,[rbp-40]
       mov       esi,[rcx+18]
       mov       edx,esi
       mov       rax,[rcx+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L28
       mov       edx,edx
       mov       word ptr [rax+rdx*2+10],7D
       lea       edx,[rsi+1]
       mov       [rcx+18],edx
M00_L15:
       call      qword ptr [7FFBB40D2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       near ptr M00_L29
M00_L16:
       mov       edx,7B
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L02
M00_L17:
       mov       rcx,rdx
       mov       edx,2C
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L04
M00_L18:
       mov       edx,22
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L05
M00_L19:
       movzx     r8d,word ptr [rdx]
       mov       [rax],r8w
       cmp       esi,2
       jne       near ptr M00_L06
       movzx     edx,word ptr [rdx+2]
       mov       [rax+2],dx
       jmp       near ptr M00_L06
M00_L20:
       mov       rcx,[rbp-40]
       mov       r8d,esi
       call      qword ptr [7FFBB405F210]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L07
M00_L21:
       mov       edx,22
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L08
M00_L22:
       mov       edx,3A
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L09
M00_L23:
       mov       edx,22
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L10
M00_L24:
       movzx     r8d,word ptr [rdx]
       mov       [rax],r8w
       cmp       esi,2
       jne       near ptr M00_L11
       movzx     edx,word ptr [rdx+2]
       mov       [rax+2],dx
       jmp       near ptr M00_L11
M00_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L26:
       mov       rcx,[rbp-40]
       mov       r8d,esi
       call      qword ptr [7FFBB405F210]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L12
M00_L27:
       mov       edx,22
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L13
M00_L28:
       mov       edx,7D
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L15
M00_L29:
       call      M00_L33
       nop
       mov       r10,[rbp-48]
       mov       [rbp-38],r10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-38]
       mov       rdx,7FFBB458ED00
       cmp       [rcx],ecx
       call      qword ptr [7FFBB453E7C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L30:
       call      qword ptr [7FFBB45B4F90]
       int       3
M00_L31:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45356F8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L32
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L00
M00_L32:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L33:
       sub       rsp,28
       mov       rcx,[rbp-40]
       cmp       dword ptr [rcx+20],0
       jge       short M00_L34
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B5230]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L34:
       cmp       qword ptr [rcx+10],0
       jne       short M00_L35
       xor       edx,edx
       mov       [rcx+18],rdx
       jmp       near ptr M00_L42
M00_L35:
       mov       edx,[rcx+1C]
       add       edx,[rcx+18]
       mov       r8d,edx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L36
       xor       edx,edx
       call      qword ptr [7FFBB45B54E8]
       mov       rcx,[rbp-40]
       jmp       near ptr M00_L42
M00_L36:
       xor       edx,edx
       call      qword ptr [7FFBB45B5500]
       mov       rbx,rax
       mov       rcx,[rbp-40]
       cmp       rbx,rcx
       je        near ptr M00_L41
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
       jge       short M00_L39
       cmp       r8d,400
       jge       short M00_L37
       movsxd    rdx,r8d
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L38
M00_L37:
       mov       ecx,r8d
       xor       edx,edx
       call      qword ptr [7FFBB449F348]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L38:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFBB3EE6FA0]; System.Array.Copy(System.Array, System.Array, Int32)
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L40
M00_L39:
       mov       rdx,[rbx+8]
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L40:
       mov       rdx,[rbx+10]
       mov       rcx,[rbp-40]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       rsi,[rbp-40]
       mov       [rsi+1C],ecx
       mov       rcx,rsi
M00_L41:
       mov       r8d,[rbx+1C]
       neg       r8d
       mov       [rcx+18],r8d
M00_L42:
       mov       rdx,2398CC01340
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,rcx
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L44
M00_L43:
       add       rsp,28
       ret
M00_L44:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L46
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L45
       call      qword ptr [7FFBB45B4F90]
       int       3
M00_L45:
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      00007FFC13B421C0
       test      rax,rax
       je        short M00_L43
M00_L46:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L47
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45B55A8]
       test      eax,eax
       jne       short M00_L43
       mov       rcx,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBB45B55C0]
       jmp       short M00_L43
M00_L47:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L43
; Total bytes of code 1590
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
       mov       rax,7FFBB4334D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45B54D0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4274528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4AF8]
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
       mov       rax,9B8D8086E778
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
       mov       rax,7FFBB4334D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,9B8D8086E778
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
       call      qword ptr [7FFBB449FFA8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB449FFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45B58A8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,27A21D42288
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40571C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4AF8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2398CC01E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4525E10]
       mov       [rbp+28],rax
       mov       rcx,2398CC00C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41AFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4325188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40571C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB432CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3EE1548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,2398CC01E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4525E18]
       mov       rcx,2398CC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41AFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45051E8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,2398CC01E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4525E18]
       mov       rcx,2398CC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41AFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       ja        short M03_L01
       test      r8b,18
       je        near ptr M03_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M03_L00:
       vzeroupper
       ret
M03_L01:
       cmp       r8,40
       ja        short M03_L04
M03_L02:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L07
M03_L03:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L04:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       near ptr M03_L10
M03_L05:
       mov       r9,r8
       shr       r9,6
M03_L06:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L06
       and       r8,3F
       cmp       r8,10
       ja        short M03_L02
       jmp       short M03_L03
M03_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L03
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L03
M03_L08:
       test      r8b,4
       je        short M03_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M03_L00
M03_L09:
       test      r8,r8
       je        near ptr M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L00
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M03_L00
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
       jmp       near ptr M03_L05
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBB3EE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 343
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,27A21D40008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rbx,rax
       call      qword ptr [7FFBB45B51A0]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       call      qword ptr [7FFC0D8A37D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC0D888FD8]
       int       3
; Total bytes of code 56
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
       jg        near ptr M06_L05
       cmp       eax,esi
       jl        near ptr M06_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M06_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M06_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M06_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M06_L00:
       cmp       ebp,edx
       ja        near ptr M06_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M06_L08
       cmp       edx,esi
       jl        near ptr M06_L08
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
       jl        near ptr M06_L09
       cmp       eax,400
       jl        short M06_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFBB449F348]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M06_L03
M06_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M06_L03:
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
       je        near ptr M06_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M06_L04:
       cmp       esi,r8d
       ja        near ptr M06_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B52F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L06:
       test      ecx,ecx
       jne       short M06_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M06_L00
M06_L07:
       call      qword ptr [7FFBB40571C8]
       int       3
M06_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B5230]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45B5248]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFBB432D2D8]
       int       3
; Total bytes of code 621
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
       call      qword ptr [7FFC0D8AEA60]
       test      eax,eax
       jne       short M08_L01
       cmp       qword ptr [rdi+10],0
       je        short M08_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M08_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L01:
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
       call      qword ptr [7FFC0D889030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFC0D889038]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFBB45A2344
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFBB45A234C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFBB45A2340
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFBB45A233C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFBB45A2338
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFBB45A2334
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFBB45A2350
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFBB45A2354
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFBB4536820]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFBB45A2330
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFC13B137A0
       cmp       dword ptr [7FFC13E53A90],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
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
       jmp       qword ptr [7FFBB449EC58]
M10_L15:
       mov       rcx,7FFBB45A2348
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rax,7FFBB4221FF0
       mov       [rbp-160],rax
       lea       rax,[M00_L01]
       mov       [rbp-150],rax
       lea       rax,[rbp-170]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3CED0930
       call      rax
M00_L01:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L02:
       mov       rcx,[rbp-168]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L04
       vmovups   xmm0,[rbp-90]
       vmovups   [rbp-80],xmm0
       mov       rcx,offset MT_System.String
       mov       edx,20
       call      00007FFC13B952E0
       mov       rbx,rax
       lea       rsi,[rbx+0C]
       mov       r8d,[rbx+8]
       cmp       r8d,20
       jl        near ptr M00_L05
       mov       dword ptr [rbp-98],20
       mov       [rbp-0A0],rsi
       vmovups   xmm0,[rbp-80]
       vmovups   xmm1,[7FFBB3FA8F60]
       vpsrlq    xmm2,xmm0,4
       vpunpcklbw xmm3,xmm2,xmm0
       vpunpckhbw xmm0,xmm2,xmm0
       vbroadcastss xmm2,dword ptr [7FFBB3FA8F70]
       vpand     xmm3,xmm2,xmm3
       vpshufb   xmm3,xmm1,xmm3
       vpand     xmm0,xmm2,xmm0
       vpshufb   xmm0,xmm1,xmm0
       vmovaps   [rbp-0F0],xmm3
       vpshufb   xmm1,xmm3,[7FFBB3FA8F80]
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
       call      qword ptr [7FFBB3EF77E0]; System.ValueTuple`3[[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib],[System.Runtime.Intrinsics.Vector128`1[[System.Byte, System.Private.CoreLib]], System.Private.CoreLib]]..ctor(System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>, System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovaps   xmm0,[rbp-130]
       vmovaps   xmm6,[rbp-120]
       vmovaps   [rbp-180],xmm0
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0C0]
       call      qword ptr [7FFBB45C68C8]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
       vmovups   xmm7,[rbp-0C0]
       vmovups   xmm8,[rbp-0B0]
       vmovaps   [rbp-180],xmm6
       lea       rdx,[rbp-180]
       lea       rcx,[rbp-0E0]
       call      qword ptr [7FFBB45C68C8]; System.Runtime.Intrinsics.Vector128.Widen(System.Runtime.Intrinsics.Vector128`1<Byte>)
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
       mov       rcx,[rbx+90]
       lea       r8,[rbp-138]
       mov       rdx,7FFBB457D380
       cmp       [rcx],ecx
       call      qword ptr [7FFBB452E1F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBB45C59B0]
       int       3
M00_L05:
       xor       ecx,ecx
       mov       [rbp-98],ecx
       jmp       short M00_L03
; Total bytes of code 720
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateLastName()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,1B609401318
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
       call      qword ptr [7FFBB45441C8]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFBB42A4240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 143
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45E58F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4F30]
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateParagraph()
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
       mov       rbx,rcx
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],5
       mov       byte ptr [rbp-40],1
       mov       dword ptr [rbp-3C],0A
       mov       rcx,1D282801340
       mov       rsi,[rcx]
       mov       rdi,rsi
       mov       rcx,[rdi+20]
       mov       [rbp-48],rcx
       cmp       qword ptr [rbp-48],0
       je        near ptr M00_L46
       lea       rcx,[rdi+20]
       mov       r8,[rbp-48]
       test      rcx,rcx
       je        near ptr M00_L50
       xor       edx,edx
       call      00007FFC13B421C0
       cmp       rax,[rbp-48]
       jne       near ptr M00_L46
M00_L00:
       mov       rcx,[rbp-48]
M00_L01:
       xor       edx,edx
       mov       [rbp-48],rdx
       mov       [rbp-70],rcx
       xor       edi,edi
       cmp       edi,5
       jl        near ptr M00_L08
M00_L02:
       mov       rcx,[rbp-70]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB40D2200]; System.Text.StringBuilder.ToString()
       mov       rdi,rax
       jmp       near ptr M00_L45
M00_L03:
       mov       r15,[r14+18]
       mov       r13,[r15+18]
       mov       r12,[r13+8]
       xor       eax,eax
       mov       [rbp-58],eax
M00_L04:
       mov       eax,[r13+60]
       mov       ecx,eax
       and       ecx,[r13+18]
       mov       r8d,[r12+8]
       cmp       ecx,r8d
       jae       near ptr M00_L44
       mov       r10d,ecx
       shl       r10,4
       lea       r9,[r12+r10+10]
       mov       ecx,[r9+8]
       lea       edx,[rax+1]
       sub       ecx,edx
       jne       near ptr M00_L31
       lea       rcx,[r13+60]
       lea       edx,[rax+1]
       mov       [rbp-5C],eax
       lock cmpxchg [rcx],edx
       mov       r11d,[rbp-5C]
       cmp       eax,r11d
       jne       short M00_L04
       mov       eax,r11d
       mov       rdx,[r12+r10+10]
       mov       [rbp-50],rdx
       cmp       byte ptr [r13+1C],0
       jne       short M00_L05
       xor       edx,edx
       mov       [r12+r10+10],rdx
       add       eax,r8d
       mov       [r9+8],eax
M00_L05:
       add       r14,2C
       lock dec  dword ptr [r14]
       jmp       near ptr M00_L10
M00_L06:
       mov       rcx,[rbp-78]
       xor       edx,edx
       call      qword ptr [7FFBB4535848]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-78]
       call      qword ptr [7FFBB4535860]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       rcx,[rbp-70]
       cmp       [rcx],cl
       test      r14,r14
       je        short M00_L07
       mov       r8d,[r14+8]
       lea       rdx,[r14+0C]
       call      qword ptr [7FFBB405F180]; System.Text.StringBuilder.Append(Char ByRef, Int32)
       mov       rcx,[rbp-70]
M00_L07:
       add       edi,1
       jo        near ptr M00_L43
       cmp       edi,5
       jge       near ptr M00_L02
M00_L08:
       test      edi,edi
       jle       short M00_L09
       mov       rcx,[rbp-70]
       mov       edx,[rcx+18]
       mov       eax,edx
       mov       r8,[rcx+8]
       cmp       [r8+8],eax
       jbe       near ptr M00_L30
       mov       word ptr [r8+rax*2+10],20
       inc       edx
       mov       [rcx+18],edx
M00_L09:
       mov       r14,rsi
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       rcx,[r14+20]
       mov       [rbp-50],rcx
       cmp       qword ptr [rbp-50],0
       je        near ptr M00_L03
       lea       rcx,[r14+20]
       mov       r8,[rbp-50]
       test      rcx,rcx
       je        near ptr M00_L42
       xor       edx,edx
       call      00007FFC13B421C0
       cmp       rax,[rbp-50]
       jne       near ptr M00_L03
M00_L10:
       mov       r14,[rbp-50]
M00_L11:
       xor       ecx,ecx
       mov       [rbp-50],rcx
       mov       [rbp-78],r14
       xor       r14d,r14d
       cmp       r14d,0A
       jge       near ptr M00_L15
M00_L12:
       mov       ecx,3
       mov       edx,0A
       call      qword ptr [7FFBB4534678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4535008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       r15,rax
       test      r14d,r14d
       je        near ptr M00_L17
       mov       rcx,[rbp-78]
       mov       ecx,[rcx+18]
       mov       edx,ecx
       mov       rax,[rbp-78]
       mov       rax,[rax+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L28
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       rdx,[rbp-78]
       mov       [rdx+18],ecx
M00_L13:
       test      r15,r15
       je        short M00_L14
       mov       r8d,[r15+8]
       lea       rdx,[r15+0C]
       mov       rcx,[rbp-78]
       call      qword ptr [7FFBB405F180]; System.Text.StringBuilder.Append(Char ByRef, Int32)
M00_L14:
       add       r14d,1
       jo        near ptr M00_L27
       cmp       r14d,0A
       jl        near ptr M00_L12
M00_L15:
       mov       rcx,[rbp-78]
       mov       ecx,[rcx+18]
       mov       edx,ecx
       mov       rax,[rbp-78]
       mov       rax,[rax+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L29
       cmp       edx,[rax+8]
       jae       near ptr M00_L26
       mov       word ptr [rax+rdx*2+10],2E
       inc       ecx
       mov       rdx,[rbp-78]
       mov       [rdx+18],ecx
M00_L16:
       mov       rcx,[rbp-78]
       call      qword ptr [7FFBB40D2200]; System.Text.StringBuilder.ToString()
       mov       r14,rax
       jmp       near ptr M00_L06
M00_L17:
       cmp       dword ptr [r15+8],0
       jbe       near ptr M00_L26
       movzx     edx,word ptr [r15+0C]
       cmp       edx,7F
       jg        near ptr M00_L23
       mov       eax,edx
       lea       ecx,[rax-61]
       cmp       ecx,19
       jbe       near ptr M00_L21
M00_L18:
       mov       rcx,[rbp-78]
       mov       ecx,[rcx+18]
       mov       edx,ecx
       mov       r8,[rbp-78]
       mov       r8,[r8+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L24
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       rax,[rbp-78]
       mov       [rax+18],ecx
M00_L19:
       mov       r8d,[r15+8]
       lea       rdx,[r15+0E]
       mov       r15d,[r15+8]
       dec       r15d
       je        near ptr M00_L14
       mov       r8,[rbp-78]
       mov       r8,[r8+8]
       mov       rcx,[rbp-78]
       mov       r13d,[rcx+18]
       lea       ecx,[r15+r13]
       cmp       ecx,[r8+8]
       ja        short M00_L25
       movsxd    rcx,r13d
       lea       rcx,[r8+rcx*2+10]
       cmp       r15d,2
       jle       short M00_L22
       movsxd    r8,r15d
       add       r8,r8
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L20:
       add       r15d,r13d
       mov       rcx,[rbp-78]
       mov       [rcx+18],r15d
       jmp       near ptr M00_L14
M00_L21:
       mov       eax,edx
       and       eax,5F
       jmp       near ptr M00_L18
M00_L22:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       r15d,2
       jne       short M00_L20
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L20
M00_L23:
       mov       rcx,1D298800070
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFBB45B5650]
       jmp       near ptr M00_L18
M00_L24:
       mov       rcx,[rbp-78]
       mov       edx,eax
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L19
M00_L25:
       mov       rcx,[rbp-78]
       mov       r8d,r15d
       call      qword ptr [7FFBB405F210]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L14
M00_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L27:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L28:
       mov       rcx,[rbp-78]
       mov       edx,20
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L13
M00_L29:
       mov       rcx,[rbp-78]
       mov       edx,2E
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L16
M00_L30:
       mov       edx,20
       call      qword ptr [7FFBB405F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L09
M00_L31:
       test      ecx,ecx
       jge       near ptr M00_L04
       movzx     ecx,byte ptr [r13+1D]
       mov       edx,[r13+0A0]
       mov       r8d,edx
       sub       r8d,eax
       test      r8d,r8d
       jle       short M00_L33
       test      ecx,ecx
       je        short M00_L32
       mov       rcx,[r13+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       sub       edx,eax
       test      edx,edx
       jle       short M00_L33
M00_L32:
       lea       rcx,[rbp-58]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBB45B56C8]
       jmp       near ptr M00_L04
M00_L33:
       xor       edx,edx
       mov       [rbp-50],rdx
       cmp       qword ptr [r13+10],0
       jne       short M00_L34
       xor       ecx,ecx
       mov       [rbp-50],rcx
       jmp       near ptr M00_L41
M00_L34:
       mov       r13,[r15+18]
       lea       rdx,[rbp-50]
       mov       rcx,r13
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4535710]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L38
       cmp       qword ptr [r13+10],0
       je        short M00_L39
       lea       rdx,[rbp-50]
       mov       rcx,r13
       call      qword ptr [7FFBB4535710]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L38
       mov       rcx,[r15+8]
       mov       [rbp-80],rcx
       xor       ecx,ecx
       mov       [rbp-60],ecx
       cmp       qword ptr [rbp-80],0
       jne       short M00_L35
       xor       ecx,ecx
       call      qword ptr [7FFBB45B49A8]
       int       3
M00_L35:
       mov       rcx,[rbp-80]
       call      00007FFC13B9E120
       test      eax,eax
       jne       short M00_L36
       mov       rcx,[rbp-80]
       call      qword ptr [7FFBB45B4FC0]
M00_L36:
       mov       dword ptr [rbp-60],1
       cmp       r13,[r15+18]
       jne       short M00_L37
       mov       rdx,[r13+10]
       lea       rcx,[r15+18]
       call      CORINFO_HELP_ASSIGN_REF
       nop
M00_L37:
       mov       rcx,[rbp-80]
       call      qword ptr [7FFBB3EE6820]; System.Threading.Monitor.Exit(System.Object)
       jmp       near ptr M00_L34
M00_L38:
       mov       ecx,1
       jmp       short M00_L40
M00_L39:
       xor       ecx,ecx
       mov       [rbp-50],rcx
M00_L40:
       test      ecx,ecx
       jne       near ptr M00_L05
M00_L41:
       mov       rax,[r14+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r14,rax
       jmp       near ptr M00_L11
M00_L42:
       call      qword ptr [7FFBB45B4FF0]
       int       3
M00_L43:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L44:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L45:
       mov       rcx,[rbp-70]
       xor       edx,edx
       call      qword ptr [7FFBB4535848]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFBB4535860]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       mov       [rbp-68],rdi
       mov       rcx,[rbx+90]
       lea       r8,[rbp-68]
       mov       rdx,7FFBB458E6F0
       cmp       [rcx],ecx
       call      qword ptr [7FFBB453E718]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
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
M00_L46:
       mov       r14,[rdi+18]
       mov       r15,[r14+18]
       lea       rdx,[rbp-48]
       mov       rcx,r15
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4535710]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       jne       short M00_L47
       cmp       qword ptr [r15+10],0
       je        short M00_L48
       lea       rdx,[rbp-48]
       mov       rcx,r14
       call      qword ptr [7FFBB45B55A8]
       test      eax,eax
       je        short M00_L49
M00_L47:
       add       rdi,2C
       lock dec  dword ptr [rdi]
       jmp       near ptr M00_L00
M00_L48:
       xor       ecx,ecx
       mov       [rbp-48],rcx
M00_L49:
       mov       rax,[rdi+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rcx,rax
       jmp       near ptr M00_L01
M00_L50:
       call      qword ptr [7FFBB45B4FF0]
       int       3
       sub       rsp,28
       mov       rcx,[rbp-78]
       cmp       [rcx],cl
       mov       rcx,[rbp-78]
       xor       edx,edx
       call      qword ptr [7FFBB4535848]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1D282801340
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-78]
       call      qword ptr [7FFBB4535860]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
       sub       rsp,28
       cmp       dword ptr [rbp-60],0
       je        short M00_L51
       mov       rcx,[rbp-80]
       call      qword ptr [7FFBB3EE6820]; System.Threading.Monitor.Exit(System.Object)
M00_L51:
       nop
       add       rsp,28
       ret
       sub       rsp,28
       mov       rcx,[rbp-70]
       cmp       [rcx],cl
       xor       edx,edx
       call      qword ptr [7FFBB4535848]; System.Text.StringBuilder.set_Length(Int32)
       mov       rcx,1D282801340
       mov       rsi,[rcx]
       mov       rcx,rsi
       mov       rdx,[rbp-70]
       call      qword ptr [7FFBB4535860]; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       nop
       add       rsp,28
       ret
; Total bytes of code 1659
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M01_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rsi,rax
M01_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M01_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M01_L03
       cmp       [rdx+8],r8d
       jb        short M01_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M01_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L02:
       mov       rax,21317960008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M01_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rbx,rax
       call      qword ptr [7FFBB45B5200]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       jl        short M02_L01
       cmp       esi,[rbx+20]
       jg        short M02_L02
       test      esi,esi
       jne       near ptr M02_L03
       cmp       qword ptr [rbx+10],0
       jne       short M02_L03
       xor       ecx,ecx
       mov       [rbx+18],rcx
M02_L00:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L01:
       mov       ecx,3AD
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rdx,rax
       mov       ecx,esi
       call      qword ptr [7FFBB45B4978]
       int       3
M02_L02:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B5338]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L03:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,esi
       sub       r8d,ecx
       test      r8d,r8d
       jle       short M02_L04
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBB45B5560]
       jmp       near ptr M02_L00
M02_L04:
       mov       rcx,rbx
       mov       edx,esi
       call      qword ptr [7FFBB45B5578]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M02_L09
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
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M02_L07
       cmp       ecx,400
       jge       short M02_L05
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       call      qword ptr [7FFBB449F348]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M02_L06:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFBB3EE6FA0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M02_L08
M02_L07:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M02_L09:
       sub       esi,[rdi+1C]
       mov       [rbx+18],esi
       jmp       near ptr M02_L00
; Total bytes of code 399
```
```assembly
; Microsoft.Extensions.ObjectPool.DefaultObjectPool`1[[System.__Canon, System.Private.CoreLib]].ReturnCore(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,[rsi+10]
       mov       rcx,offset Microsoft.Extensions.ObjectPool.StringBuilderPooledObjectPolicy.Return(System.Text.StringBuilder)
       cmp       [rdi+18],rcx
       jne       near ptr M03_L11
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,[rbx+1C]
       mov       rdx,[rdi+8]
       cmp       ecx,[rdx+0C]
       jg        near ptr M03_L12
       cmp       dword ptr [rbx+20],0
       jl        near ptr M03_L03
       cmp       qword ptr [rbx+10],0
       jne       near ptr M03_L04
       xor       ecx,ecx
       mov       [rbx+18],rcx
M03_L00:
       cmp       qword ptr [rsi+20],0
       jne       short M03_L02
       lea       rcx,[rsi+20]
       test      rcx,rcx
       je        near ptr M03_L13
       mov       rdx,rbx
       xor       r8d,r8d
       call      00007FFC13B421C0
       test      rax,rax
       jne       short M03_L02
M03_L01:
       mov       eax,1
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L02:
       lea       rcx,[rsi+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rsi+28]
       jg        near ptr M03_L14
       mov       rsi,[rsi+18]
       mov       rcx,[rsi+10]
       mov       rdx,rbx
       cmp       [rcx],ecx
       call      qword ptr [7FFBB453E700]; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryEnqueue(System.__Canon)
       test      eax,eax
       jne       short M03_L01
       mov       rcx,rsi
       mov       rdx,rbx
       call      qword ptr [7FFBB45B5620]
       jmp       short M03_L01
M03_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B5338]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M03_L04:
       mov       ecx,[rbx+1C]
       add       ecx,[rbx+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M03_L05
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBB45B5560]
       jmp       near ptr M03_L00
M03_L05:
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFBB45B5578]
       mov       rdi,rax
       cmp       rdi,rbx
       je        near ptr M03_L10
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
       sub       ecx,[rdi+1C]
       mov       rdx,[rdi+8]
       cmp       [rdx+8],ecx
       jge       short M03_L08
       cmp       ecx,400
       jge       short M03_L06
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rbp,rax
       jmp       short M03_L07
M03_L06:
       xor       edx,edx
       call      qword ptr [7FFBB449F348]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rbp,rax
M03_L07:
       mov       rcx,[rdi+8]
       mov       r8d,[rdi+18]
       mov       rdx,rbp
       call      qword ptr [7FFBB3EE6FA0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rbx+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M03_L09
M03_L08:
       mov       rdx,[rdi+8]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
M03_L09:
       mov       rdx,[rdi+10]
       lea       rcx,[rbx+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+1C]
       mov       [rbx+1C],ecx
M03_L10:
       mov       ecx,[rdi+1C]
       neg       ecx
       mov       [rbx+18],ecx
       jmp       near ptr M03_L00
M03_L11:
       mov       rdx,rbx
       mov       rcx,[rdi+8]
       call      qword ptr [rdi+18]
       test      eax,eax
       jne       near ptr M03_L00
M03_L12:
       xor       eax,eax
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L13:
       call      qword ptr [7FFBB45B4FF0]
       int       3
M03_L14:
       add       rsi,2C
       lock dec  dword ptr [rsi]
       jmp       short M03_L12
; Total bytes of code 560
```
```assembly
; System.Text.StringBuilder.Append(Char ByRef, Int32)
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       test      r8d,r8d
       je        short M04_L01
       mov       rcx,[rbx+8]
       mov       eax,[rbx+18]
       lea       esi,[rax+r8]
       cmp       esi,[rcx+8]
       ja        short M04_L03
       cdqe
       lea       rcx,[rcx+rax*2+10]
       cmp       r8d,2
       jle       short M04_L02
       mov       r8d,r8d
       add       r8,r8
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L00:
       mov       [rbx+18],esi
M04_L01:
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       movzx     eax,word ptr [rdx]
       mov       [rcx],ax
       cmp       r8d,2
       jne       short M04_L00
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M04_L00
M04_L03:
       mov       rcx,rbx
       add       rsp,28
       pop       rbx
       pop       rsi
       jmp       qword ptr [7FFBB405F210]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
; Total bytes of code 102
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
       jge       near ptr M05_L04
       sub       esi,ebx
       dec       esi
       je        near ptr M05_L05
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
M05_L00:
       lea       rdx,[rbp-3C]
       mov       [rbp-48],rdx
       lea       rdx,[rbp-3C]
       mov       r8d,4
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4334D88
       mov       [rbp-70],rax
       lea       rax,[M05_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M05_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M05_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M05_L02:
       mov       rcx,[rbp-78]
       mov       [rdi+8],rcx
       test      eax,eax
       jne       short M05_L06
       xor       eax,eax
       mov       [rbp-48],rax
       mov       [rbp-48],rax
       mov       eax,r14d
       and       eax,[rbp-3C]
       cmp       eax,esi
       ja        short M05_L00
       add       eax,ebx
M05_L03:
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
M05_L04:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45B5548]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4274528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M05_L05:
       mov       eax,ebx
       jmp       short M05_L03
M05_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4B58]
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
       mov       rax,2ED881105D6F
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
       je        near ptr M06_L13
M06_L00:
       mov       r15d,ebx
       movzx     edi,di
       movzx     esi,si
       sub       edi,esi
       jo        near ptr M06_L25
       add       edi,1
       jo        near ptr M06_L25
       cmp       r15d,100
       jg        near ptr M06_L18
       mov       eax,ebx
       mov       r15,rax
       test      r15,r15
       je        short M06_L02
       add       r15,0F
       shr       r15,4
       add       rsp,20
M06_L01:
       push      0
       push      0
       dec       r15
       jne       short M06_L01
       sub       rsp,20
       lea       r15,[rsp+20]
M06_L02:
       test      ebx,ebx
       jl        near ptr M06_L16
       mov       [rbp+18],r15
       mov       eax,ebx
       mov       r8d,2
       mul       r8
       jb        near ptr M06_L25
       mov       r13,rax
       test      r13,r13
       je        short M06_L04
       add       r13,0F
       shr       r13,4
       add       rsp,20
M06_L03:
       push      0
       push      0
       dec       r13
       jne       short M06_L03
       sub       rsp,20
       lea       r13,[rsp+20]
M06_L04:
       mov       [rbp+10],r13
       test      ebx,ebx
       jle       short M06_L07
       mov       rdx,r15
       mov       [rbp+88],rdx
       mov       r8d,ebx
       xor       ecx,ecx
       mov       r9d,2
       mov       rax,7FFBB4334D88
       mov       [rbp+60],rax
       lea       rax,[M06_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M06_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M06_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M06_L06:
       mov       rcx,[rbp+58]
       mov       [r14+8],rcx
       test      eax,eax
       jne       near ptr M06_L17
       xor       eax,eax
       mov       [rbp+88],rax
       mov       r15,[rbp+18]
M06_L07:
       xor       eax,eax
       mov       [rbp+88],rax
       xor       ecx,ecx
       test      ebx,ebx
       jle       short M06_L09
M06_L08:
       mov       r8d,ecx
       movzx     eax,byte ptr [r15+r8]
       cdq
       idiv      edi
       add       edx,esi
       jo        near ptr M06_L25
       cmp       edx,0FFFF
       ja        near ptr M06_L25
       mov       eax,edx
       mov       r13,[rbp+10]
       mov       [r13+r8*2],ax
       add       ecx,1
       jo        near ptr M06_L25
       cmp       ecx,ebx
       jge       short M06_L10
       jmp       short M06_L08
M06_L09:
       mov       r13,[rbp+10]
M06_L10:
       mov       [rbp+30],r13
       mov       [rbp+38],ebx
       lea       rcx,[rbp+30]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
M06_L11:
       mov       r8,2ED881105D6F
       cmp       [rbp+8],r8
       je        short M06_L12
       call      CORINFO_HELP_FAIL_FAST
M06_L12:
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
M06_L13:
       movzx     ecx,byte ptr [rbp+0A0]
       test      cl,cl
       je        short M06_L14
       lea       rcx,[rbp+0A0]
       call      qword ptr [7FFBB449FFA8]
       mov       ebx,eax
       jmp       near ptr M06_L00
M06_L14:
       call      qword ptr [7FFBB449FFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M06_L15
       call      qword ptr [7FFBB45B5800]
       mov       rbx,rax
M06_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,21317962288
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M06_L16:
       call      qword ptr [7FFBB40571C8]
       int       3
M06_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45B4B58]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M06_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D282801E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4525E10]
       mov       [rbp+28],rax
       mov       rcx,1D282800C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41AFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+20],rax
       cmp       qword ptr [rbp+28],0
       je        short M06_L19
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jb        short M06_L19
       lea       rcx,[r8+10]
       mov       eax,r15d
       mov       [rbp+40],rcx
       mov       [rbp+48],eax
       lea       rcx,[rbp+40]
       call      qword ptr [7FFBB4325188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
       cmp       qword ptr [rbp+20],0
       je        short M06_L19
       mov       rax,[rbp+20]
       cmp       [rax+8],r15d
       jb        short M06_L19
       lea       rbx,[rax+10]
       mov       r14d,r15d
       mov       r8,[rbp+28]
       cmp       [r8+8],r15d
       jae       short M06_L20
M06_L19:
       call      qword ptr [7FFBB40571C8]
       int       3
M06_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB432CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
       mov       rcx,[rbp+90]
       mov       r8d,[rbp+98]
       xor       r10d,r10d
       jmp       short M06_L24
M06_L21:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L22:
       call      CORINFO_HELP_OVERFLOW
       int       3
M06_L23:
       cmp       r10d,r8d
       jae       short M06_L21
       movzx     eax,byte ptr [rcx+r10]
       cdq
       idiv      edi
       add       edx,esi
       jo        short M06_L22
       cmp       edx,0FFFF
       ja        short M06_L22
       mov       [rbx+r10*2],dx
       add       r10d,1
       jo        short M06_L22
M06_L24:
       cmp       r10d,r14d
       jl        short M06_L23
       mov       rcx,[rbp+20]
       mov       r8d,r15d
       xor       edx,edx
       call      00007FFBB3EE1548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D282801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4525E18]
       mov       rcx,1D282800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41AFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M06_L11
M06_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45051E8],1
       jne       short M06_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EE5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M06_L26:
       mov       rcx,1D282801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4525E18]
       mov       rcx,1D282800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41AFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jb        near ptr M07_L10
       mov       rax,rdx
       sub       rax,rcx
       cmp       rax,r8
       jb        near ptr M07_L10
       lea       rax,[rdx+r8]
       lea       r10,[rcx+r8]
       cmp       r8,10
       ja        short M07_L02
       test      r8b,18
       je        short M07_L01
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
M07_L00:
       vzeroupper
       ret
M07_L01:
       test      r8b,4
       je        near ptr M07_L08
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M07_L00
M07_L02:
       cmp       r8,40
       jbe       short M07_L05
       cmp       r8,800
       ja        near ptr M07_L11
       cmp       r8,100
       jae       near ptr M07_L09
M07_L03:
       mov       r9,r8
       shr       r9,6
M07_L04:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M07_L04
       and       r8,3F
       cmp       r8,10
       jbe       short M07_L06
M07_L05:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M07_L07
M07_L06:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       near ptr M07_L00
M07_L07:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M07_L06
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M07_L06
M07_L08:
       test      r8,r8
       je        near ptr M07_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M07_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M07_L00
M07_L09:
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
       jmp       near ptr M07_L03
M07_L10:
       cmp       rcx,rdx
       jne       short M07_L11
       cmp       [rdx],dl
       jmp       near ptr M07_L00
M07_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBB3EE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 341
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
       call      qword ptr [7FFC0D8A37D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
       mov       rax,[rbx+8]
       cmp       dword ptr [rax+8],0
       jbe       short M08_L00
       mov       [rax+10],si
       inc       dword ptr [rbx+18]
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M08_L00:
       call      qword ptr [7FFC0D888FD8]
       int       3
; Total bytes of code 56
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
       jg        near ptr M09_L05
       cmp       eax,esi
       jl        near ptr M09_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M09_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M09_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M09_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M09_L00:
       cmp       ebp,edx
       ja        near ptr M09_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M09_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M09_L08
       cmp       edx,esi
       jl        near ptr M09_L08
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
       jl        near ptr M09_L09
       cmp       eax,400
       jl        short M09_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFBB449F348]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M09_L03
M09_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M09_L03:
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
       je        near ptr M09_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M09_L04:
       cmp       esi,r8d
       ja        near ptr M09_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M09_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B52F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L06:
       test      ecx,ecx
       jne       short M09_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M09_L00
M09_L07:
       call      qword ptr [7FFBB40571C8]
       int       3
M09_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45B5338]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB410DBF0]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45B5350]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M09_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M09_L04
M09_L11:
       call      qword ptr [7FFBB432D2D8]
       int       3
; Total bytes of code 621
```
```assembly
; System.Collections.Concurrent.ConcurrentQueueSegment`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rdi,[rbx+8]
       xor       eax,eax
       mov       [rsp+28],eax
M10_L00:
       mov       ebp,[rbx+60]
       mov       eax,ebp
       and       eax,[rbx+18]
       mov       r14d,[rdi+8]
       cmp       eax,r14d
       jae       near ptr M10_L05
       mov       r15d,eax
       shl       r15,4
       lea       r13,[rdi+r15+10]
       mov       ecx,[r13+8]
       lea       edx,[rbp+1]
       sub       ecx,edx
       jne       short M10_L02
       lea       rcx,[rbx+60]
       mov       eax,ebp
       lock cmpxchg [rcx],edx
       cmp       eax,ebp
       jne       short M10_L00
       mov       rdx,[rdi+r15+10]
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       cmp       byte ptr [rbx+1C],0
       jne       short M10_L01
       xor       eax,eax
       mov       [rdi+r15+10],rax
       add       ebp,r14d
       mov       [r13+8],ebp
M10_L01:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L02:
       test      ecx,ecx
       jge       short M10_L00
       movzx     ecx,byte ptr [rbx+1D]
       mov       edx,[rbx+0A0]
       mov       eax,edx
       sub       eax,ebp
       test      eax,eax
       jle       short M10_L04
       test      ecx,ecx
       je        short M10_L03
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       add       ecx,ecx
       sub       edx,ecx
       sub       edx,ebp
       test      edx,edx
       jle       short M10_L04
M10_L03:
       lea       rcx,[rsp+28]
       mov       edx,0FFFFFFFF
       call      qword ptr [7FFBB45B56C8]
       jmp       near ptr M10_L00
M10_L04:
       xor       eax,eax
       mov       [rsi],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       ret
M10_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 231
```
```assembly
; System.Threading.Monitor.Exit(System.Object)
       push      rbx
       sub       rsp,20
       mov       rbx,rcx
       test      rbx,rbx
       je        short M11_L00
       mov       rcx,rbx
       call      00007FFC13B9E040
       test      eax,eax
       jne       short M11_L01
       add       rsp,20
       pop       rbx
       ret
M11_L00:
       xor       ecx,ecx
       call      qword ptr [7FFBB45B49A8]
       int       3
M11_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFBB45B4AB0]
; Total bytes of code 56
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,218B8320E58
       call      qword ptr [7FFBB3E5A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L35
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       dword ptr [rax+8],0EB
       mov       rdx,rax
       mov       rcx,218B8320E58
       call      qword ptr [7FFBB3E5A5D0]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       je        near ptr M00_L37
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       dword ptr [rsi+8],0EB
       mov       rcx,1D8394001B8
       mov       rdi,[rcx]
       mov       rcx,1D8394001A0
       mov       r14,[rcx]
       test      rdi,rdi
       je        near ptr M00_L39
M00_L00:
       mov       r15,[r14+8]
       mov       rcx,[r15+8]
       cmp       byte ptr [r14+19],0
       je        near ptr M00_L40
       mov       rcx,rsi
       mov       rax,[7FFBB45C8708]
       call      qword ptr [rax+18]
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
       jae       near ptr M00_L60
       mov       edx,edx
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       je        near ptr M00_L49
       test      r12,r12
       je        near ptr M00_L32
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L32
M00_L02:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L41
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       test      r10,r10
       je        near ptr M00_L43
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L42
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFBB3E560A0]; System.Enum.Equals(System.Object)
M00_L03:
       test      eax,eax
       je        near ptr M00_L43
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
       call      qword ptr [7FFBB4355608]; DotNetTips.Spargine.Tester.Data.CountryRepository.GetCountries()
       mov       rsi,rax
       test      rsi,rsi
       je        near ptr M00_L50
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rsi],rcx
       je        near ptr M00_L27
       mov       rcx,offset MT_System.Collections.Generic.List<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       je        near ptr M00_L26
       mov       rcx,offset MT_System.Collections.ObjectModel.ReadOnlyCollection<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       [rsi],rcx
       jne       near ptr M00_L56
       mov       rcx,[rsi+8]
       mov       r11,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rcx],r11
       jne       near ptr M00_L52
       mov       edi,[rcx+8]
       test      edi,edi
       je        near ptr M00_L55
M00_L06:
       mov       rsi,[rsi+8]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.Models.Country[]
       cmp       [rsi],rcx
       jne       near ptr M00_L54
       mov       edi,[rsi+8]
       test      edi,edi
       jne       near ptr M00_L34
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       test      byte ptr [7FFBB45CEE30],1
       je        near ptr M00_L53
M00_L07:
       mov       rcx,1D839400228
       mov       r14,[rcx]
M00_L08:
       mov       [rbp-58],r14
       cmp       qword ptr [rbp-58],0
       je        near ptr M00_L14
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L14
       jmp       short M00_L11
M00_L09:
       xor       eax,eax
M00_L10:
       test      eax,eax
       jne       near ptr M00_L23
M00_L11:
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L16
       mov       [r14+8],eax
       mov       r10d,[r14+8]
       cmp       r10d,[r14+0C]
       jae       near ptr M00_L21
       mov       rdi,[r14+10]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L22
       mov       r8d,r10d
       mov       r15,[rdi+r8*8+10]
       mov       r13,[r15+68]
       mov       rdx,[rbx+8]
       cmp       r13,rdx
       je        near ptr M00_L15
       test      r13,r13
       je        short M00_L09
       test      rdx,rdx
       je        short M00_L09
       mov       r8d,[r13+8]
       cmp       r8d,[rdx+8]
       jne       short M00_L09
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFBB3F1FC00]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L10
M00_L12:
       xor       eax,eax
M00_L13:
       test      eax,eax
       jne       near ptr M00_L23
M00_L14:
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L17
       mov       eax,[r14+8]
       inc       eax
       cmp       eax,[r14+0C]
       jae       near ptr M00_L18
       mov       [r14+8],eax
       mov       r8d,[r14+8]
       cmp       r8d,[r14+0C]
       jae       near ptr M00_L21
       mov       rdi,[r14+10]
       mov       r10d,[r14+8]
       cmp       r10d,[rdi+8]
       jae       near ptr M00_L22
       mov       r8d,r10d
       mov       r15,[rdi+r8*8+10]
       mov       r13,[r15+68]
       mov       rdx,[rbx+8]
       cmp       r13,rdx
       je        near ptr M00_L20
       test      r13,r13
       je        short M00_L12
       test      rdx,rdx
       je        short M00_L12
       mov       r8d,[r13+8]
       cmp       r8d,[rdx+8]
       jne       near ptr M00_L12
       lea       rcx,[r13+0C]
       mov       r8d,[r13+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFBB3F1FC00]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M00_L13
M00_L15:
       mov       eax,1
       jmp       near ptr M00_L10
M00_L16:
       mov       r8d,[r14+0C]
       mov       [r14+8],r8d
       jmp       near ptr M00_L57
M00_L17:
       mov       rcx,r14
       mov       r11,7FFBB3E609F8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M00_L19
       jmp       near ptr M00_L57
M00_L18:
       mov       ecx,[r14+0C]
       mov       [r14+8],ecx
       jmp       near ptr M00_L57
M00_L19:
       mov       rcx,r14
       mov       r11,7FFBB3E60A00
       call      qword ptr [r11]
       mov       r15,rax
       mov       rcx,rbx
       mov       rdx,r15
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       jmp       near ptr M00_L13
M00_L20:
       mov       eax,1
       jmp       near ptr M00_L13
M00_L21:
       mov       ecx,[r14+8]
       call      qword ptr [7FFBB45E5B30]
       int       3
M00_L22:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L23:
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       jne       near ptr M00_L58
M00_L24:
       test      r15,r15
       je        near ptr M00_L59
       mov       ecx,[r15+0B8]
M00_L25:
       call      qword ptr [7FFBB45644F8]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp+10]
       mov       rbx,[rcx+90]
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
M00_L26:
       mov       r15d,[rsi+10]
       mov       r14,[rsi+8]
       cmp       [r14+8],r15d
       jb        near ptr M00_L51
       add       r14,10
       jmp       short M00_L28
M00_L27:
       lea       r14,[rsi+10]
       mov       r15d,[rsi+8]
M00_L28:
       xor       esi,esi
       cmp       esi,r15d
       jge       short M00_L30
M00_L29:
       mov       rdi,[r14+rsi*8]
       mov       rcx,rbx
       mov       rdx,rdi
       mov       rax,offset DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
       call      rax
       test      eax,eax
       jne       short M00_L31
       inc       esi
       cmp       esi,r15d
       jl        short M00_L29
M00_L30:
       xor       r15d,r15d
       jmp       near ptr M00_L24
M00_L31:
       mov       r15,rdi
       jmp       near ptr M00_L24
M00_L32:
       cmp       r13d,[rax+20]
       jne       near ptr M00_L46
       mov       [rbp-50],rax
       mov       r10,[rax+8]
       mov       rcx,offset MT_System.Collections.Generic.ObjectEqualityComparer<System.Enum>
       cmp       [r12],rcx
       jne       near ptr M00_L44
       test      r10,r10
       je        near ptr M00_L45
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Data.CountryName
       cmp       [r10],rcx
       jne       near ptr M00_L47
       mov       rcx,r10
       mov       rdx,rsi
       call      qword ptr [7FFBB3E560A0]; System.Enum.Equals(System.Object)
M00_L33:
       test      eax,eax
       je        near ptr M00_L48
       jmp       near ptr M00_L04
M00_L34:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [r14+8],0FFFFFFFF
       mov       [r14+0C],edi
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L08
M00_L35:
       call      qword ptr [7FFBB456ECB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L36
       call      qword ptr [7FFBB45E7660]
       mov       rbx,rax
M00_L36:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,218B8320E28
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L37:
       call      qword ptr [7FFBB456ECB8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M00_L38
       call      qword ptr [7FFBB45E7660]
       mov       rbx,rax
M00_L38:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,218B8320E28
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M00_L39:
       mov       rcx,offset MT_System.Func<System.Enum, System.String>
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1D8394001B0
       mov       rdx,[rdx]
       mov       rcx,rdi
       mov       r8,offset DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
       call      qword ptr [7FFBB3F16BB0]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rcx,1D8394001B8
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       near ptr M00_L00
M00_L40:
       mov       rdx,rsi
       mov       r11,7FFBB3E609E0
       call      qword ptr [r11]
       mov       r13d,eax
       jmp       near ptr M00_L01
M00_L41:
       mov       [rbp-50],rax
       jmp       short M00_L43
M00_L42:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L03
M00_L43:
       mov       rax,[rbp-50]
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L02
       jmp       short M00_L49
M00_L44:
       mov       rcx,r12
       mov       r8,rsi
       mov       rdx,r10
       mov       r11,7FFBB3E609E8
       call      qword ptr [r11]
       jmp       near ptr M00_L33
M00_L45:
       mov       rax,[rbp-50]
M00_L46:
       mov       rax,[rax+18]
       test      rax,rax
       jne       near ptr M00_L32
       jmp       short M00_L49
M00_L47:
       mov       rcx,r10
       mov       rdx,rsi
       mov       r8,[r10]
       mov       r8,[r8+40]
       call      qword ptr [r8+10]
       jmp       near ptr M00_L33
M00_L48:
       mov       rax,[rbp-50]
       jmp       short M00_L46
M00_L49:
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
       call      qword ptr [7FFBB42AC8D0]; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       jmp       near ptr M00_L05
M00_L50:
       mov       ecx,11
       call      qword ptr [7FFBB4137E88]
       int       3
M00_L51:
       call      qword ptr [7FFBB4137A38]
       int       3
M00_L52:
       mov       r11,7FFBB3E60A10
       call      qword ptr [r11]
       mov       edi,eax
       test      edi,edi
       je        short M00_L55
       jmp       near ptr M00_L06
M00_L53:
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M00_L07
M00_L54:
       mov       rcx,rsi
       mov       r11,7FFBB3E60A18
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L08
M00_L55:
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1D839400228
       mov       r14,[rcx]
       jmp       near ptr M00_L08
M00_L56:
       mov       rcx,rsi
       mov       r11,7FFBB3E609F0
       call      qword ptr [r11]
       mov       r14,rax
       jmp       near ptr M00_L08
M00_L57:
       call      M00_L61
       jmp       near ptr M00_L30
M00_L58:
       mov       rcx,r14
       mov       r11,7FFBB3E60A08
       call      qword ptr [r11]
       jmp       near ptr M00_L24
M00_L59:
       mov       ecx,0A
       jmp       near ptr M00_L25
M00_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L61:
       sub       rsp,48
       cmp       qword ptr [rbp-58],0
       je        short M00_L62
       mov       r14,[rbp-58]
       mov       rsi,[r14]
       mov       rcx,offset MT_System.SZGenericArrayEnumerator<DotNetTips.Spargine.Tester.Data.Models.Country>
       cmp       rsi,rcx
       je        short M00_L62
       mov       rcx,r14
       mov       r11,7FFBB3E60A08
       call      qword ptr [r11]
M00_L62:
       nop
       add       rsp,48
       ret
; Total bytes of code 2071
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
       call      qword ptr [7FFBB3F1C9F0]; System.Object.GetType()
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
       call      00007FFC13B51A90
       mov       rcx,1D8234009D8
       mov       rbp,[rcx]
       cmp       eax,1A
       jae       near ptr M01_L60
       mov       ecx,eax
       mov       rcx,[rbp+rcx*8+10]
       mov       rdi,rcx
M01_L05:
       mov       rcx,218B8310020
       cmp       rdi,rcx
       je        near ptr M01_L26
       mov       rcx,218B8313120
       cmp       rdi,rcx
       jne       near ptr M01_L27
M01_L06:
       mov       rcx,[rbx+18]
       call      00007FFC13B51A90
       mov       rcx,1D8234009D8
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
       call      qword ptr [7FFBB3F17C78]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFBB3F17C78]; System.RuntimeType.InitializeCache()
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
       call      qword ptr [7FFBB413E0D0]; System.Enum.<GetEnumInfo>g__InitializeEnumInfo|5_0[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, Boolean)
       jmp       short M01_L17
M01_L23:
       mov       ecx,3AD
       mov       rdx,7FFBB3E54000
       call      qword ptr [7FFBB41377C8]
       mov       rcx,rax
       call      qword ptr [7FFBB45E54E8]
       int       3
M01_L24:
       mov       rcx,rdi
       mov       rdx,rbx
       call      qword ptr [7FFBB45E5DA0]
       test      eax,eax
       jne       near ptr M01_L03
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFBB45E6808]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFBB45E5CB0]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M01_L25:
       call      qword ptr [7FFBB45E67F0]
       int       3
M01_L26:
       mov       rcx,rbx
       call      qword ptr [7FFBB456CDE0]; System.Enum.GetNamesNoCopy(System.RuntimeType)
       mov       rbx,rax
       mov       rdx,rsi
       mov       rcx,offset MT_System.String
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,7FFBB45C8AE8
       call      qword ptr [7FFBB456ECD0]
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
       mov       rcx,218B83153E0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B8313070
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B8312ED0
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B83153B8
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B8312E58
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B8315408
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B8312C50
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,218B8315390
       cmp       rdi,rcx
       je        near ptr M01_L06
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45E6820]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A6370]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L28:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45E6838]
       mov       rcx,rax
       mov       rdx,rdi
       mov       r8,rbp
       call      qword ptr [7FFBB45E5CB0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L29:
       mov       rbp,rdi
       mov       rcx,rbp
       call      qword ptr [7FFBB408F318]; System.RuntimeType.get_IsActualEnum()
       test      eax,eax
       je        short M01_L30
       mov       rcx,rdi
       call      qword ptr [7FFBB3E5A588]; Precode of System.RuntimeType.GetEnumUnderlyingType()
       mov       rbp,rax
       test      rbp,rbp
       je        short M01_L30
       mov       rcx,offset MT_System.RuntimeType
       cmp       [rbp],rcx
       je        short M01_L30
       mov       rdx,rax
       call      System.Runtime.CompilerServices.CastHelpers.ChkCastClass(Void*, System.Object)
       int       3
M01_L30:
       mov       rcx,218B83153B8
       cmp       rbp,rcx
       jne       short M01_L31
       mov       ebp,5
       jmp       near ptr M01_L46
M01_L31:
       mov       rcx,218B8312ED0
       cmp       rbp,rcx
       jne       short M01_L32
       mov       ebp,6
       jmp       near ptr M01_L46
M01_L32:
       mov       rcx,218B83153E0
       cmp       rbp,rcx
       jne       short M01_L33
       mov       ebp,7
       jmp       near ptr M01_L46
M01_L33:
       mov       rcx,218B8313070
       cmp       rbp,rcx
       jne       short M01_L34
       mov       ebp,8
       jmp       near ptr M01_L46
M01_L34:
       mov       rcx,218B8313120
       cmp       rbp,rcx
       jne       short M01_L35
       mov       ebp,9
       jmp       near ptr M01_L46
M01_L35:
       mov       rcx,218B8312E58
       cmp       rbp,rcx
       jne       short M01_L36
       mov       ebp,0A
       jmp       near ptr M01_L46
M01_L36:
       mov       rcx,218B8315408
       cmp       rbp,rcx
       jne       short M01_L37
       mov       ebp,0B
       jmp       near ptr M01_L46
M01_L37:
       mov       rcx,218B8312C50
       cmp       rbp,rcx
       jne       short M01_L38
       mov       ebp,0C
       jmp       near ptr M01_L46
M01_L38:
       mov       rcx,218B8315368
       cmp       rbp,rcx
       jne       short M01_L39
       mov       ebp,3
       jmp       near ptr M01_L46
M01_L39:
       mov       rcx,218B8315390
       cmp       rbp,rcx
       jne       short M01_L40
       mov       ebp,4
       jmp       near ptr M01_L46
M01_L40:
       mov       rcx,218B8315430
       cmp       rbp,rcx
       jne       short M01_L41
       mov       ebp,0D
       jmp       short M01_L46
M01_L41:
       mov       rcx,218B8315458
       cmp       rbp,rcx
       jne       short M01_L42
       mov       ebp,0E
       jmp       short M01_L46
M01_L42:
       mov       rcx,218B83162E0
       cmp       rbp,rcx
       jne       short M01_L43
       mov       ebp,0F
       jmp       short M01_L46
M01_L43:
       mov       rcx,218B8312AC8
       cmp       rbp,rcx
       jne       short M01_L44
       mov       ebp,10
       jmp       short M01_L46
M01_L44:
       mov       rcx,218B8310020
       cmp       rbp,rcx
       jne       short M01_L45
       mov       ebp,12
       jmp       short M01_L46
M01_L45:
       mov       rcx,218B8320F10
       mov       eax,1
       mov       edx,2
       cmp       rbp,rcx
       cmove     eax,edx
       mov       ebp,eax
M01_L46:
       mov       rcx,[rdi+10]
       test      rcx,rcx
       je        short M01_L47
       mov       r14,[rcx]
       test      r14,r14
       je        short M01_L47
       mov       rax,r14
       jmp       short M01_L48
M01_L47:
       mov       rcx,rdi
       call      qword ptr [7FFBB3F17C78]; System.RuntimeType.InitializeCache()
M01_L48:
       mov       [rax+98],ebp
       jmp       near ptr M01_L12
M01_L49:
       cmp       ebp,0A
       ja        short M01_L50
       mov       edx,ebp
       lea       rcx,[7FFBB4641E00]
       mov       ecx,[rcx+rdx*4]
       lea       rax,[M01_L00]
       add       rcx,rax
       jmp       rcx
M01_L50:
       mov       rdx,218B8313048
       cmp       rdi,rdx
       je        near ptr M01_L58
       jmp       near ptr M01_L56
       mov       rdx,rsi
       mov       rcx,offset MT_System.SByte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6430]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Byte
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,byte ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6430]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6418]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt16
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6418]
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
       call      qword ptr [7FFBB45E6A90]
       jmp       short M01_L55
M01_L54:
       mov       rcx,rax
       mov       edx,esi
       call      qword ptr [7FFBB45E6CA0]; System.SpanHelpers.NonPackedIndexOfValueType[[System.Int32, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int32, System.Private.CoreLib]], System.Private.CoreLib]](Int32 ByRef, Int32, Int32)
M01_L55:
       not       eax
       shr       eax,1F
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt32
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       edx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB456ED30]; System.Enum.IsDefinedPrimitive[[System.UInt32, System.Private.CoreLib]](System.RuntimeType, UInt32)
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Int64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6400]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.UInt64
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6400]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Single
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovss    xmm1,dword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E63E8]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Double
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       vmovsd    xmm1,qword ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E63D0]
       jmp       near ptr M01_L18
       mov       rdx,rsi
       mov       rcx,offset MT_System.Char
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       movzx     edx,word ptr [rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E6448]
       jmp       near ptr M01_L18
M01_L56:
       mov       rdx,218B8315480
       cmp       rdi,rdx
       je        short M01_L57
       mov       rcx,offset MT_System.InvalidOperationException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45E6820]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBB42A6370]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L57:
       mov       rdx,rsi
       mov       rcx,offset MT_System.UIntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E63B8]
       jmp       short M01_L59
M01_L58:
       mov       rdx,rsi
       mov       rcx,offset MT_System.IntPtr
       call      System.Runtime.CompilerServices.CastHelpers.Unbox(System.Runtime.CompilerServices.MethodTable*, System.Object)
       mov       rdx,[rax]
       mov       rcx,rbx
       call      qword ptr [7FFBB45E63B8]
M01_L59:
       jmp       near ptr M01_L18
M01_L60:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 2091
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
       call      00007FFC13B51A90
       add       eax,0FFFFFFFE
       cmp       eax,17
       ja        short M02_L03
       lea       rcx,[7FFBB4644090]
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
       mov       rbx,218B831B950
       mov       rcx,rbx
       call      System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
       mov       rsi,1D823401390
       cmp       qword ptr [rsi],0
       je        short M03_L01
M03_L00:
       mov       rsi,[rsi]
       lea       rdx,[rbp-18]
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       jmp       short M03_L02
M03_L01:
       call      qword ptr [7FFBB43557B8]; DotNetTips.Spargine.Tester.Data.CountryRepository.DeserializeCountries()
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
       mov       rbx,218B831B950
       mov       rcx,rbx
       call      System.Threading.Monitor.ExitIfLockTaken(System.Object, Boolean ByRef)
       nop
       add       rsp,28
       ret
; Total bytes of code 135
```
```assembly
; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       r8,8
       jb        short M04_L04
       cmp       rcx,rdx
       je        short M04_L03
       cmp       r8,20
       jae       near ptr M04_L09
       cmp       r8,10
       jb        near ptr M04_L13
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFF0
       je        short M04_L02
       vmovups   xmm0,[rcx]
       vpcmpeqb  xmm0,xmm0,[rdx]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       je        short M04_L01
M04_L00:
       xor       eax,eax
       vzeroupper
       ret
M04_L01:
       add       rax,10
       cmp       r8,rax
       ja        near ptr M04_L12
M04_L02:
       vmovups   xmm0,[rcx+r8]
       vpcmpeqb  xmm0,xmm0,[rdx+r8]
       vpmovmskb ecx,xmm0
       cmp       ecx,0FFFF
       jne       short M04_L00
M04_L03:
       mov       eax,1
       vzeroupper
       ret
M04_L04:
       cmp       r8,4
       jae       short M04_L07
       xor       eax,eax
       mov       r10,r8
       and       r10,2
       je        short M04_L05
       movzx     eax,word ptr [rcx]
       movzx     r9d,word ptr [rdx]
       sub       eax,r9d
M04_L05:
       test      r8b,1
       je        short M04_L06
       movzx     r8d,byte ptr [rcx+r10]
       movzx     ecx,byte ptr [rdx+r10]
       sub       r8d,ecx
       or        eax,r8d
M04_L06:
       test      eax,eax
       sete      al
       movzx     eax,al
       jmp       short M04_L08
M04_L07:
       lea       rax,[r8-4]
       mov       r8d,[rcx]
       sub       r8d,[rdx]
       mov       ecx,[rcx+rax]
       sub       ecx,[rdx+rax]
       or        ecx,r8d
       sete      al
       movzx     eax,al
M04_L08:
       vzeroupper
       ret
M04_L09:
       xor       eax,eax
       add       r8,0FFFFFFFFFFFFFFE0
       je        short M04_L11
M04_L10:
       vmovups   ymm0,[rcx+rax]
       vpcmpeqb  ymm0,ymm0,[rdx+rax]
       vpmovmskb r10d,ymm0
       cmp       r10d,0FFFFFFFF
       jne       near ptr M04_L00
       add       rax,20
       cmp       r8,rax
       ja        short M04_L10
M04_L11:
       vmovups   ymm0,[rcx+r8]
       vpcmpeqb  ymm0,ymm0,[rdx+r8]
       vpmovmskb eax,ymm0
       cmp       eax,0FFFFFFFF
       jne       near ptr M04_L00
       jmp       near ptr M04_L03
M04_L12:
       vmovups   xmm0,[rcx+rax]
       vpcmpeqb  xmm0,xmm0,[rdx+rax]
       vpmovmskb r10d,xmm0
       cmp       r10d,0FFFF
       jne       near ptr M04_L00
       jmp       near ptr M04_L01
M04_L13:
       add       r8,0FFFFFFFFFFFFFFF8
       mov       rax,[rcx]
       sub       rax,[rdx]
       mov       rcx,[rcx+r8]
       sub       rcx,[rdx+r8]
       or        rax,rcx
       sete      al
       movzx     eax,al
       jmp       near ptr M04_L08
; Total bytes of code 335
```
```assembly
; DotNetTips.Spargine.Tester.Data.CountryRepository+<>c__DisplayClass3_0.<GetCountry>b__0(DotNetTips.Spargine.Tester.Data.Models.Country)
; 		return GetCountries().FirstOrDefault(p => string.Equals(p.Name, countryNameDescription, StringComparison.Ordinal));
; 		                                          ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       r8,[rdx+68]
       mov       rdx,[rcx+8]
       cmp       r8,rdx
       je        short M05_L03
       test      r8,r8
       je        short M05_L00
       test      rdx,rdx
       je        short M05_L00
       mov       ecx,[r8+8]
       cmp       ecx,[rdx+8]
       je        short M05_L02
M05_L00:
       xor       eax,eax
M05_L01:
       add       rsp,28
       ret
M05_L02:
       lea       rcx,[r8+0C]
       mov       r8d,[r8+8]
       add       r8d,r8d
       add       rdx,0C
       call      qword ptr [7FFBB3F1FC00]; System.SpanHelpers.SequenceEqual(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M05_L01
M05_L03:
       mov       eax,1
       jmp       short M05_L01
; Total bytes of code 73
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
       mov       rax,748A7CDBA05C
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
       jg        near ptr M06_L17
       mov       ecx,ebx
       mov       rsi,rcx
       test      rsi,rsi
       je        short M06_L01
       add       rsi,0F
       shr       rsi,4
       add       rsp,20
M06_L00:
       push      0
       push      0
       dec       rsi
       jne       short M06_L00
       sub       rsp,20
       lea       rsi,[rsp+20]
M06_L01:
       test      ebx,ebx
       jl        near ptr M06_L21
       mov       edi,ebx
M06_L02:
       cmp       ebx,100
       jg        near ptr M06_L19
; 		var chars = length <= stackAllocThreshold
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			? stackalloc char[length]
; 			                         
; 			: (rentedChars = ArrayPool<char>.Shared.Rent(length)).AsSpan(0, length);
; 			                                                                        
       mov       eax,ebx
       mov       ecx,2
       mul       rcx
       jb        near ptr M06_L23
       mov       r14,rax
       test      r14,r14
       je        short M06_L04
       add       r14,0F
       shr       r14,4
       add       rsp,20
M06_L03:
       push      0
       push      0
       dec       r14
       jne       short M06_L03
       sub       rsp,20
       lea       r14,[rsp+20]
M06_L04:
       test      ebx,ebx
       jl        near ptr M06_L21
       mov       r15d,ebx
M06_L05:
       test      edi,edi
       jle       short M06_L06
       mov       rcx,rsi
       mov       [rbp+30],rcx
       mov       edx,edi
       call      qword ptr [7FFBB43551B8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+30],rcx
M06_L06:
       xor       ecx,ecx
       mov       [rbp+30],rcx
; 			for (var digitIndex = 0; digitIndex < length; digitIndex++)
; 			                         ^^^^^^^^^^^^^^^^^^^
       test      ebx,ebx
       jle       short M06_L08
       cmp       ebx,r15d
       jg        short M06_L09
       cmp       ebx,edi
       jg        short M06_L09
; 				chars[digitIndex] = (char)('0' + (bytes[digitIndex] % 10));
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L07:
       mov       eax,ecx
       movzx     edx,byte ptr [rsi+rax]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M06_L11
       cmp       edx,0FFFF
       ja        short M06_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M06_L11
       cmp       ecx,ebx
       jl        short M06_L07
; 			return new string(chars);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L08:
       mov       [rbp+20],r14
       mov       [rbp+28],r15d
       lea       rcx,[rbp+20]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       jmp       short M06_L12
M06_L09:
       cmp       ecx,r15d
       jae       short M06_L10
       mov       eax,ecx
       cmp       ecx,edi
       jae       short M06_L10
       mov       edx,ecx
       movzx     edx,byte ptr [rsi+rdx]
       mov       r8d,0CCCCCCCD
       mov       r10d,edx
       imul      r8,r10
       shr       r8,23
       imul      r8d,0A
       sub       edx,r8d
       add       edx,30
       jo        short M06_L11
       cmp       edx,0FFFF
       ja        short M06_L11
       mov       [r14+rax*2],dx
       add       ecx,1
       jo        short M06_L11
       cmp       ecx,ebx
       jl        short M06_L09
       jmp       short M06_L08
M06_L10:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M06_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
; 			if (rentedBytes is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L12:
       cmp       qword ptr [rbp+18],0
       je        short M06_L14
; 				ArrayPool<byte>.Shared.Return(rentedBytes);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       test      byte ptr [7FFBB453EB88],1
       je        near ptr M06_L22
M06_L13:
       mov       rcx,1D823401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455FA20]
; 			if (rentedChars is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M06_L14:
       cmp       qword ptr [rbp+10],0
       je        short M06_L15
; 				ArrayPool<char>.Shared.Return(rentedChars);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,1D823400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
M06_L15:
       mov       rax,rbx
       mov       r8,748A7CDBA05C
       cmp       [rbp+8],r8
       je        short M06_L16
       call      CORINFO_HELP_FAIL_FAST
M06_L16:
       nop
       lea       rsp,[rbp+38]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M06_L17:
       test      byte ptr [7FFBB453EB88],1
       je        short M06_L20
M06_L18:
       mov       rcx,1D823401E50
       mov       rcx,[rcx]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455FA18]
       mov       [rbp+18],rax
       test      rax,rax
       je        short M06_L21
       cmp       [rax+8],ebx
       jb        short M06_L21
       add       rax,10
       mov       rsi,rax
       mov       edi,ebx
       jmp       near ptr M06_L02
M06_L19:
       mov       rcx,1D823400C88
       mov       rcx,[rcx]
       mov       edx,ebx
       call      qword ptr [7FFBB41DFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rbp+10],rax
       test      rax,rax
       je        short M06_L21
       cmp       [rax+8],ebx
       jb        short M06_L21
       add       rax,10
       mov       r14,rax
       mov       r15d,ebx
       jmp       near ptr M06_L05
M06_L20:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M06_L18
M06_L21:
       call      qword ptr [7FFBB40871C8]
       int       3
M06_L22:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M06_L13
M06_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp+18],0
       je        short M06_L25
       test      byte ptr [7FFBB453EB88],1
       jne       short M06_L24
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M06_L24:
       mov       rcx,1D823401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455FA20]
M06_L25:
       cmp       qword ptr [rbp+10],0
       je        short M06_L26
       mov       rcx,1D823400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 		}
; 		^
M06_L26:
       nop
       add       rsp,28
       ret
; Total bytes of code 804
```
```assembly
; DotNetTips.Spargine.Core.EnumHelper+<>c.<GetDescription>b__3_0(System.Enum)
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
       call      qword ptr [7FFBB3F1C9F0]; System.Object.GetType()
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
       mov       ecx,6B19
       mov       rdx,7FFBB41F4F28
       call      qword ptr [7FFBB41377C8]
       mov       [rbp-40],rax
       mov       ecx,2047
       mov       rdx,7FFBB41F4F28
       call      qword ptr [7FFBB41377C8]
       mov       [rbp-48],rax
       mov       rdx,[rbp-40]
       mov       r8,[rbp-48]
       mov       rcx,[rbp-30]
       call      qword ptr [7FFBB42A6418]
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_THROW
       int       3
; 			var name = Enum.GetName(type, key);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M07_L00:
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFBB456F0D8]; System.Enum.GetName(System.Type, System.Object)
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
       call      qword ptr [7FFBB456F0F0]; System.Type.GetField(System.String)
       mov       [rbp-18],rax
; 			if (field == null)
; 			^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-18]
       xor       edx,edx
       call      qword ptr [7FFBB456F108]; System.Reflection.FieldInfo.op_Equality(System.Reflection.FieldInfo, System.Reflection.FieldInfo)
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
       mov       rcx,7FFBB45CE780
       xor       r8d,r8d
       call      qword ptr [7FFBB44469B8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
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
       call      qword ptr [7FFBB413E670]; System.String.IsNullOrEmpty(System.String)
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
       mov       rcx,7FFBB45CE808
       xor       r8d,r8d
       call      qword ptr [7FFBB44469B8]; System.Reflection.CustomAttributeExtensions.GetCustomAttribute[[System.__Canon, System.Private.CoreLib]](System.Reflection.MemberInfo, Boolean)
       mov       [rbp-28],rax
; 			if (enumMemberAttr != null && !string.IsNullOrEmpty(enumMemberAttr.Value))
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       cmp       qword ptr [rbp-28],0
       je        short M07_L04
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB456F138]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
       mov       rcx,rax
       call      qword ptr [7FFBB413E670]; System.String.IsNullOrEmpty(System.String)
       test      eax,eax
       jne       short M07_L04
; 				return enumMemberAttr.Value;
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB456F138]; System.Runtime.Serialization.EnumMemberAttribute.get_Value()
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
       call      qword ptr [7FFBB45E5908]
       int       3
; Total bytes of code 44
```
```assembly
; System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].TryAddInternal(Tables<System.__Canon,System.__Canon>, System.__Canon, System.Nullable`1<Int32>, System.__Canon, Boolean, Boolean, System.__Canon ByRef)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       mov       [rbp-38],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       movzx     r9d,r9b
       mov       r11,[rbp+18]
       mov       r11,[r11+8]
       mov       [rbp-58],r11
       mov       eax,[rbp+2C]
       test      r9d,r9d
       je        near ptr M09_L20
M09_L00:
       mov       [rbp-3C],eax
M09_L01:
       mov       rax,[rbp+18]
       mov       rcx,[rax+18]
       mov       [rbp-60],rcx
       mov       r8,[rbp+10]
       cmp       [r8],r8d
       mov       rax,[rbp+18]
       mov       r10,[rax+10]
       mov       rax,[rbp+18]
       mov       r9d,[rbp-3C]
       imul      r9,[rax+28]
       shr       r9,20
       inc       r9
       mov       r11d,[r10+8]
       mov       ebx,r11d
       imul      r9,rbx
       shr       r9,20
       mov       eax,r9d
       xor       edx,edx
       div       dword ptr [rcx+8]
       mov       [rbp-40],edx
       cmp       r9d,r11d
       jae       near ptr M09_L27
       mov       ecx,r9d
       lea       rbx,[r10+rcx*8+10]
       xor       esi,esi
       xor       edi,edi
       xor       ecx,ecx
       mov       [rbp-48],ecx
       cmp       byte ptr [rbp+40],0
       je        short M09_L02
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M09_L13
       mov       rcx,[rbp-60]
       mov       edx,[rbp-40]
       mov       rcx,[rcx+rdx*8+10]
       lea       rdx,[rbp-48]
       call      qword ptr [7FFC1E071D58]; Precode of System.Threading.Monitor.Enter(System.Object, Boolean ByRef)
M09_L02:
       mov       rcx,[rbp+18]
       mov       r8,[rbp+10]
       cmp       rcx,[r8+8]
       jne       near ptr M09_L05
       xor       r14d,r14d
       mov       r15,[rbx]
       test      r15,r15
       jne       near ptr M09_L08
M09_L03:
       mov       rcx,[r8]
       call      qword ptr [7FFC1E071558]
       mov       rcx,rax
       call      qword ptr [7FFC1E071288]; CORINFO_HELP_NEWFAST
       mov       r15,rax
       mov       r13,[rbx]
       lea       rcx,[r15+8]
       mov       rdx,[rbp+20]
       call      qword ptr [7FFC1E071260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC1E071260]; CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r15+18]
       mov       rdx,r13
       call      qword ptr [7FFC1E071260]; CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbp-3C]
       mov       [r15+20],ecx
       mov       rcx,rbx
       mov       rdx,r15
       call      qword ptr [7FFC1E071260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+20]
       mov       eax,[rcx+8]
       cmp       [rbp-40],eax
       jae       near ptr M09_L13
       mov       eax,[rbp-40]
       lea       rcx,[rcx+rax*4+10]
       mov       eax,[rcx]
       add       eax,1
       jo        near ptr M09_L14
       mov       [rcx],eax
       mov       r8,[rbp+10]
       cmp       eax,[r8+10]
       jg        near ptr M09_L15
M09_L04:
       cmp       r14d,64
       jbe       near ptr M09_L17
       jmp       near ptr M09_L16
M09_L05:
       mov       rcx,[r8+8]
       mov       [rbp+18],rcx
       mov       rcx,[rbp-58]
       mov       r11,[rbp+18]
       cmp       rcx,[r11+8]
       je        near ptr M09_L23
       mov       rcx,[rbp+18]
       mov       rcx,[rcx+8]
       mov       [rbp-58],rcx
       cmp       byte ptr [r8+19],0
       jne       short M09_L06
       mov       r8,[rbp+10]
       mov       rcx,[r8]
       call      qword ptr [7FFC1E0718E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M09_L07
M09_L06:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M09_L07:
       mov       [rbp-3C],eax
       mov       r8,[rbp+10]
       jmp       near ptr M09_L23
M09_L08:
       mov       ecx,[rbp-3C]
       cmp       ecx,[r15+20]
       jne       short M09_L09
       mov       rcx,[r8]
       call      qword ptr [7FFC1E071500]
       mov       rcx,rax
       call      qword ptr [7FFC1E071AE8]
       mov       rdx,[r15+8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       r8,[rbp+20]
       call      qword ptr [rax]
       test      eax,eax
       mov       r8,[rbp+10]
       jne       short M09_L10
M09_L09:
       inc       r14d
       mov       r15,[r15+18]
       test      r15,r15
       jne       short M09_L08
       jmp       near ptr M09_L03
M09_L10:
       cmp       byte ptr [rbp+38],0
       je        short M09_L11
       lea       rcx,[r15+10]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC1E071260]; CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC1E071268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       jmp       short M09_L12
M09_L11:
       mov       rdx,[r15+10]
       mov       rcx,[rbp+48]
       call      qword ptr [7FFC1E071268]; CORINFO_HELP_CHECKED_ASSIGN_REF
M09_L12:
       xor       ecx,ecx
       mov       [rbp-4C],ecx
       jmp       near ptr M09_L24
M09_L13:
       call      qword ptr [7FFC1E071258]
       int       3
M09_L14:
       call      qword ptr [7FFC1E071250]
       int       3
M09_L15:
       mov       esi,1
       jmp       near ptr M09_L04
M09_L16:
       mov       rcx,[rbp-58]
       call      qword ptr [7FFC1E071C10]
       mov       ecx,1
       test      rax,rax
       cmovne    edi,ecx
M09_L17:
       mov       r8,[rbp+10]
       cmp       byte ptr [rbp-48],0
       je        short M09_L18
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       near ptr M09_L27
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFC1E071D60]; Precode of System.Threading.Monitor.Exit(System.Object)
       mov       r8,[rbp+10]
M09_L18:
       mov       ecx,esi
       or        ecx,edi
       jne       short M09_L25
M09_L19:
       mov       rcx,[rbp+48]
       mov       rdx,[rbp+30]
       call      qword ptr [7FFC1E071268]; CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       eax,1
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L20:
       cmp       byte ptr [rcx+19],0
       jne       short M09_L21
       mov       rcx,[rbp+10]
       mov       rcx,[rcx]
       call      qword ptr [7FFC1E0718E8]
       mov       rcx,[rbp-58]
       mov       r11,rax
       mov       rdx,[rbp+20]
       call      qword ptr [rax]
       jmp       short M09_L22
M09_L21:
       mov       rcx,[rbp+20]
       lea       r11,[System.Collections.Concurrent.ConcurrentDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]].GetOrAdd[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Func`3<System.__Canon,System.__Canon,System.__Canon>, System.__Canon)]
       cmp       [rcx],ecx
       call      qword ptr [r11]
M09_L22:
       mov       rcx,[rbp+10]
       jmp       near ptr M09_L00
M09_L23:
       call      M09_L28
       jmp       near ptr M09_L01
M09_L24:
       call      M09_L28
       jmp       short M09_L26
M09_L25:
       mov       rcx,r8
       mov       rdx,[rbp+18]
       mov       r8d,esi
       mov       r9d,edi
       call      qword ptr [7FFC1E072430]
       jmp       near ptr M09_L19
M09_L26:
       mov       eax,[rbp-4C]
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M09_L27:
       call      qword ptr [7FFC1E071258]
       int       3
M09_L28:
       sub       rsp,28
       cmp       byte ptr [rbp-48],0
       je        short M09_L29
       mov       rcx,[rbp-60]
       mov       ecx,[rcx+8]
       cmp       [rbp-40],ecx
       jae       short M09_L30
       mov       rcx,[rbp-60]
       mov       eax,[rbp-40]
       mov       rcx,[rcx+rax*8+10]
       call      qword ptr [7FFC1E071D60]; Precode of System.Threading.Monitor.Exit(System.Object)
M09_L29:
       nop
       add       rsp,28
       ret
M09_L30:
       call      qword ptr [7FFC1E071258]
       int       3
; Total bytes of code 950
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
       jmp       qword ptr [7FFBB3F15C38]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
; Total bytes of code 23
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFBB456E7D8]; DotNetTips.Spargine.Tester.RandomData.GenerateFileNameWord(Int32)
       mov       rsi,rax
       mov       rcx,offset MT_System.String
       mov       edx,1
       call      00007FFC13B952E0
       mov       rdi,rax
       mov       word ptr [rdi+0C],2E
       test      rsi,rsi
       je        near ptr M00_L07
       mov       ebp,[rsi+8]
       test      ebp,ebp
       je        near ptr M00_L07
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M00_L08
       mov       r15d,ebp
       mov       edx,r14d
       lea       rdx,[r15+rdx+0F]
       cmp       rdx,7FFFFFFF
       jg        near ptr M00_L09
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rax,ebp
       lea       rax,[r12+rax*2]
       vmovups   xmm0,[7FFBB3FC9160]
       vmovups   [rax],xmm0
       mov       rcx,74002E00730070
       mov       [rax+10],rcx
       mov       dword ptr [rax+18],6D0065
       mov       word ptr [rax+1C],70
M00_L00:
       mov       rcx,21BDF401348
       mov       rsi,[rcx]
       test      r13,r13
       je        near ptr M00_L10
       cmp       dword ptr [r13+8],0
       je        near ptr M00_L05
       lea       rcx,[r13+0C]
       mov       eax,[r13+8]
       mov       [rsp+40],rcx
       mov       [rsp+48],eax
       lea       rcx,[rsp+40]
       call      qword ptr [7FFBB413D908]; System.IO.Path.IsPathRooted(System.ReadOnlySpan`1<Char>)
       test      eax,eax
       je        short M00_L01
       jmp       near ptr M00_L06
M00_L01:
       add       rsi,0C
       lea       rdi,[r13+0C]
       mov       ebp,[r13+8]
       movzx     ecx,word ptr [rsi+42]
       cmp       ecx,5C
       je        short M00_L03
       cmp       ecx,2F
       je        short M00_L03
       movzx     ecx,word ptr [rdi]
       cmp       ecx,5C
       je        near ptr M00_L11
       cmp       ecx,2F
       sete      cl
       movzx     ecx,cl
M00_L02:
       test      ecx,ecx
       jne       short M00_L03
       mov       rcx,25C74327394
       mov       [rsp+40],rsi
       mov       dword ptr [rsp+48],22
       mov       [rsp+30],rcx
       mov       dword ptr [rsp+38],1
       mov       [rsp+20],rdi
       mov       [rsp+28],ebp
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       lea       r8,[rsp+20]
       call      qword ptr [7FFBB413D938]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r13,rax
       jmp       short M00_L04
M00_L03:
       mov       [rsp+40],rsi
       mov       dword ptr [rsp+48],22
       mov       [rsp+30],rdi
       mov       [rsp+38],ebp
       lea       rcx,[rsp+40]
       lea       rdx,[rsp+30]
       call      qword ptr [7FFBB42ADB90]; System.String.Concat(System.ReadOnlySpan`1<Char>, System.ReadOnlySpan`1<Char>)
       mov       r13,rax
M00_L04:
       jmp       short M00_L06
M00_L05:
       mov       r13,rsi
M00_L06:
       mov       [rsp+50],r13
       mov       rbx,[rbx+90]
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
M00_L07:
       mov       rcx,rdi
       mov       rdx,25C74330E28
       call      qword ptr [7FFBB3F17888]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       jmp       near ptr M00_L00
M00_L08:
       mov       rcx,rsi
       mov       rdx,25C74330E28
       call      qword ptr [7FFBB3F17888]; System.String.Concat(System.String, System.String)
       mov       r13,rax
       jmp       near ptr M00_L00
M00_L09:
       call      qword ptr [7FFBB45E51E8]
       int       3
M00_L10:
       mov       ecx,1C48A
       mov       rdx,7FFBB3E54000
       call      qword ptr [7FFBB41377C8]
       mov       rcx,rax
       call      qword ptr [7FFBB45E4990]
       int       3
M00_L11:
       mov       ecx,1
       jmp       near ptr M00_L02
; Total bytes of code 648
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
       mov       rax,47C9EC066132
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
       call      qword ptr [7FFBB43551B8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
       xor       ecx,ecx
       mov       [rbp+18],rcx
M01_L02:
       xor       ecx,ecx
       mov       [rbp+18],rcx
; 		var charBuffer = ArrayPool<char>.Shared.Rent(length);
; 		^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,21BDF400C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       edx,edi
       call      qword ptr [7FFBB41DFB48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB41DFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
       mov       rax,rbx
       mov       r8,47C9EC066132
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
       call      qword ptr [7FFBB40871C8]
       int       3
       sub       rsp,28
       mov       rcx,21BDF400C88
       mov       r14,[rcx]
       mov       rcx,r14
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFBB3F166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0D89B9F0]; Precode of System.String.FastAllocateString(IntPtr)
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
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r14+r15]
       sub       r12d,ebp
       cmp       esi,r12d
       ja        short M04_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0D89F2C0]
       int       3
M04_L02:
       call      qword ptr [7FFC0D888FD0]
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
       call      00007FFC13B952E0
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
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r15+r12]
       sub       r13d,ebp
       cmp       esi,r13d
       ja        short M05_L01
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25C74320008
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
       call      qword ptr [7FFBB435D2D8]
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
       call      00007FFC13B952E0
       mov       r15,rax
       cmp       [r15],r15b
       lea       rcx,[r15+0C]
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,r14d
       lea       rcx,[r15+rcx*2+0C]
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rax,25C74320008
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
       call      qword ptr [7FFBB45E51E8]
       int       3
; Total bytes of code 235
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,20A3D401320
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
       mov       rcx,[rcx+40]
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
       call      qword ptr [7FFBB4544CA8]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFBB4544CA8]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFBB4544CA8]; System.Random+ThreadSafeRandom.Create()
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
       mov       rdx,[rbx+90]
       cmp       [rdx],dl
       lea       rdx,[rsp+20]
       mov       rcx,7FFBB45A3A68
       call      qword ptr [7FFBB454EEE0]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`3<System.__Canon,System.__Canon,System.__Canon> ByRef)
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
       call      qword ptr [7FFBB4544990]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CreateValue()
       mov       rsi,[rsp+40]
       mov       rdi,[rsp+48]
       mov       rbp,[rsp+50]
       jmp       near ptr M00_L00
M00_L10:
       mov       ecx,8
       call      qword ptr [7FFBB45BC360]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
; Total bytes of code 1081
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC0D893778]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC0D89D778]
       call      qword ptr [7FFC0D88AEA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
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
       call      qword ptr [7FFBB45449A8]; System.LazyHelper.get_State()
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],8
       ja        short M03_L01
       mov       eax,[rbp-0C]
       lea       rcx,[7FFBB3F7A218]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M03_L00]
       add       rcx,rdx
       jmp       rcx
M03_L01:
       jmp       short M03_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB45449C0]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBB45449D8]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FFBB45449F0]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FFBB4544A08]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB4544A20]
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       r8d,1
       call      qword ptr [7FFBB4544A38]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M03_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       xor       r8d,r8d
       call      qword ptr [7FFBB4544A38]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M03_L03
M03_L02:
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4544A50]
M03_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFBB4544960]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Value()
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
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rdx,1FB05401320
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
       call      qword ptr [7FFBB4524018]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFBB4524018]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFBB4524018]; System.Random+ThreadSafeRandom.Create()
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
       mov       rcx,1FB05401310
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
       call      qword ptr [7FFBB45241B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rdi+8]
       jae       near ptr M00_L29
       mov       ecx,eax
       mov       rdi,[rdi+rcx*8+10]
       mov       [rsp+40],rdi
       mov       rcx,1FB05401318
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
       call      qword ptr [7FFBB45241B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rbp+8]
       jae       near ptr M00_L29
       mov       ecx,eax
       mov       rbp,[rbp+rcx*8+10]
       mov       [rsp+38],rbp
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.PersonData
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       [rsp+50],r14
       mov       rcx,23B9A210008
       mov       [r14+8],rcx
       mov       [r14+18],rcx
       mov       [r14+20],rcx
       mov       [r14+28],rcx
       mov       [r14+30],rcx
       lea       rcx,[rsp+68]
       mov       rax,7FFC3C2B5390
       call      rax
       mov       rbx,[rsp+68]
       mov       rax,1FB05401B08
       mov       rsi,[rax]
       sub       rbx,[rsi+8]
       cmp       dword ptr [7FFC13E53A90],0
       jne       near ptr M00_L27
M00_L11:
       mov       eax,0B2D05E00
       cmp       rbx,rax
       jae       near ptr M00_L28
       add       rbx,[rsi+10]
M00_L12:
       mov       [rsp+60],rbx
       mov       rcx,1FB05401E20
       mov       rsi,[rcx]
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45C6CA0]; System.TimeZoneInfo+CachedData.get_Local()
       mov       rcx,rax
       mov       rdx,rbx
       mov       r9,rsi
       mov       r8d,2
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4524798]; System.TimeZoneInfo.GetUtcOffset(System.DateTime, System.TimeZoneInfoOptions, CachedData)
       mov       rbx,rax
       lea       rcx,[rsp+60]
       call      qword ptr [7FFBB4426EE0]; System.DateTime.get_Ticks()
       lea       rdx,[rax+rbx]
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       jbe       short M00_L13
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBB45C5D40]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4284528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M00_L13:
       lea       rcx,[rsp+0A8]
       mov       r8,rbx
       call      qword ptr [7FFBB45C6CB8]; System.DateTimeOffset.CreateValidateOffset(System.DateTime, System.TimeSpan)
       mov       dword ptr [rsp+0A0],1
       xor       ecx,ecx
       mov       [rsp+98],rcx
       lea       rcx,[rsp+0A0]
       mov       edx,5A
       call      qword ptr [7FFBB44AFB88]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32 ByRef, Int32)
       imul      edx,eax,16D
       jo        near ptr M00_L30
       xor       ecx,ecx
       mov       [rsp+20],ecx
       mov       [rsp+28],ecx
       lea       rcx,[rsp+98]
       xor       r8d,r8d
       xor       r9d,r9d
       call      qword ptr [7FFBB45C6CD0]; System.TimeSpan..ctor(Int32, Int32, Int32, Int32, Int32)
       lea       rcx,[rsp+0A8]
       lea       rdx,[rsp+88]
       mov       r8,[rsp+98]
       call      qword ptr [7FFBB44AFBB8]; System.DateTimeOffset.Subtract(System.TimeSpan)
       vmovups   xmm0,[rsp+88]
       mov       r14,[rsp+50]
       vmovups   [r14+38],xmm0
       mov       rsi,[rsp+48]
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFBB44AFC00]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsp+40]
       mov       rdx,[rsp+38]
       call      qword ptr [7FFBB44AFC48]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddressWithName(System.String, System.String)
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
       call      qword ptr [7FFBB44AFC00]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       lea       rcx,[r14+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rsp+58],r14
       mov       rbx,[rsp+100]
       mov       rcx,[rbx+90]
       lea       r8,[rsp+58]
       mov       rdx,7FFBB457D5A0
       cmp       [rcx],ecx
       call      qword ptr [7FFBB452E250]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBB44AFCF0]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].CreateValue()
       mov       rsi,[rsp+70]
       mov       rdi,[rsp+78]
       mov       rbp,[rsp+80]
       jmp       near ptr M00_L00
M00_L15:
       mov       ecx,8
       call      qword ptr [7FFBB45C5080]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFBB4284240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L09
M00_L26:
       call      qword ptr [7FFBB4284240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbp,rax
       jmp       near ptr M00_L10
M00_L27:
       call      CORINFO_HELP_POLL_GC
       jmp       near ptr M00_L11
M00_L28:
       call      qword ptr [7FFBB4427090]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rbx,rax
       jmp       near ptr M00_L12
M00_L29:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L30:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1825
```
```assembly
; System.Random+ThreadSafeRandom.Create()
       push      rbx
       sub       rsp,20
       call      qword ptr [7FFC0D893778]
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFC0D89D778]
       call      qword ptr [7FFC0D88AEA8]
       lea       rcx,[rax+10]
       mov       rdx,rbx
       call      qword ptr [7FFC0D888FE8]; CORINFO_HELP_ASSIGN_REF
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
       mov       rax,7FFBB4344D88
       mov       [rbp-70],rax
       lea       rax,[M02_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45C5C08]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4284528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M02_L05:
       mov       eax,ebx
       jmp       short M02_L03
M02_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45C4F60]
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
       jmp       qword ptr [7FFBB4524378]; System.TimeZoneInfo+CachedData.CreateLocal()
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
       mov       rax,1FB05401E18
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
       call      qword ptr [7FFBB45247C8]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
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
       call      qword ptr [7FFBB45247B0]; System.TimeZoneInfo+CachedData.GetCorrespondingKind(System.TimeZoneInfo)
       cmp       eax,2
       je        short M04_L02
       mov       rcx,rsi
       call      qword ptr [7FFBB45C6CA0]; System.TimeZoneInfo+CachedData.get_Local()
       mov       rdx,rax
       mov       r8,1FB05401E20
       mov       r8,[r8]
       mov       [rsp+20],r8
       mov       r8,1FB05401E18
       mov       r8,[r8]
       mov       rcx,rdi
       mov       r9d,ebp
       call      qword ptr [7FFBB45C5D28]
       mov       rcx,rax
       lea       r8,[rsp+40]
       lea       r9,[rsp+38]
       mov       rdx,rbx
       call      qword ptr [7FFBB45247C8]; System.TimeZoneInfo.GetUtcOffsetFromUtc(System.DateTime, System.TimeZoneInfo, Boolean ByRef, Boolean ByRef)
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
       call      qword ptr [7FFBB45C5D10]
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
       call      qword ptr [7FFBB45C5D58]
       int       3
M06_L01:
       call      qword ptr [7FFBB45C5D70]
       int       3
M06_L02:
       call      qword ptr [7FFBB45C5D88]
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
       jmp       qword ptr [7FFBB45241B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      qword ptr [7FFBB45C5E00]
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
       mov       rdx,7FFBB3E34000
       call      qword ptr [7FFBB41177C8]
       mov       rbx,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      qword ptr [7FFBB45C6C58]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB411DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M09_L01:
       call      qword ptr [7FFBB45C5D88]
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
       mov       rax,4E657E468CB4
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
       call      qword ptr [7FFBB43351B8]; System.Security.Cryptography.RandomNumberGeneratorImplementation.GetBytes(Byte*, Int32)
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
       test      byte ptr [7FFBB4534D30],1
       je        near ptr M10_L22
M10_L13:
       mov       rcx,1FB05401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4534F98]
; 			if (rentedChars is not null)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^
M10_L14:
       cmp       qword ptr [rbp+10],0
       je        short M10_L15
; 				ArrayPool<char>.Shared.Return(rentedChars);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rcx,1FB05400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41BFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
; 	}
; 	^
M10_L15:
       mov       rax,rbx
       mov       r8,4E657E468CB4
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
       test      byte ptr [7FFBB4534D30],1
       je        short M10_L20
M10_L18:
       mov       rcx,1FB05401E50
       mov       rcx,[rcx]
       mov       edx,ebx
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4534F90]
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
       mov       rcx,1FB05400C88
       mov       rcx,[rcx]
       mov       edx,ebx
       call      qword ptr [7FFBB41BFB48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB3EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       short M10_L18
M10_L21:
       call      qword ptr [7FFBB40671C8]
       int       3
M10_L22:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       jmp       near ptr M10_L13
M10_L23:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       cmp       qword ptr [rbp+18],0
       je        short M10_L25
       test      byte ptr [7FFBB4534D30],1
       jne       short M10_L24
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3EF5728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M10_L24:
       mov       rcx,1FB05401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4534F98]
M10_L25:
       cmp       qword ptr [rbp+10],0
       je        short M10_L26
       mov       rcx,1FB05400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+10]
       xor       r8d,r8d
       call      qword ptr [7FFBB41BFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       push      rsi
       push      rbx
       sub       rsp,68
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+30],ymm4
       vmovdqa   xmmword ptr [rsp+50],xmm4
       mov       [rsp+60],rax
       mov       rbx,rcx
       mov       rsi,rdx
       mov       rcx,1FB05400C88
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFBB41BFB48]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+48],rax
       test      rax,rax
       je        near ptr M11_L12
       lea       rdx,[rax+10]
       mov       r8d,[rax+8]
M11_L00:
       mov       [rsp+58],rdx
       mov       [rsp+60],r8d
       xor       edx,edx
       mov       [rsp+50],edx
       mov       byte ptr [rsp+54],0
       test      rbx,rbx
       je        near ptr M11_L13
       cmp       dword ptr [rbx+8],0
       je        near ptr M11_L13
M11_L01:
       cmp       byte ptr [rsp+54],0
       jne       near ptr M11_L14
       mov       edx,[rsp+50]
       cmp       edx,[rsp+60]
       ja        near ptr M11_L23
       mov       r8,[rsp+58]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rsp+60]
       sub       r8d,edx
       cmp       [rbx+8],r8d
       ja        near ptr M11_L14
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      qword ptr [7FFBB3EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+50]
       add       ecx,[rbx+8]
       mov       [rsp+50],ecx
M11_L02:
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M11_L23
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        near ptr M11_L15
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
M11_L03:
       test      rsi,rsi
       je        near ptr M11_L16
       cmp       dword ptr [rsi+8],0
       je        near ptr M11_L16
M11_L04:
       cmp       byte ptr [rsp+54],0
       jne       near ptr M11_L17
       mov       edx,[rsp+50]
       cmp       edx,[rsp+60]
       ja        near ptr M11_L23
       mov       r8,[rsp+58]
       mov       ecx,edx
       lea       rcx,[r8+rcx*2]
       mov       r8d,[rsp+60]
       sub       r8d,edx
       cmp       [rsi+8],r8d
       ja        near ptr M11_L17
       lea       rdx,[rsi+0C]
       mov       r8d,[rsi+8]
       add       r8,r8
       call      qword ptr [7FFBB3EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+50]
       add       ecx,[rsi+8]
       mov       [rsp+50],ecx
M11_L05:
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M11_L23
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        near ptr M11_L18
       mov       word ptr [rdx],40
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
M11_L06:
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       mov       byte ptr [rsp+38],1
       mov       dword ptr [rsp+3C],1
       mov       ecx,5
       mov       edx,0F
       call      qword ptr [7FFBB45241B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4524B40]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rbx,rax
       cmp       byte ptr [rsp+54],0
       jne       near ptr M11_L19
       test      rbx,rbx
       je        near ptr M11_L19
       mov       r8d,[rsp+50]
       cmp       r8d,[rsp+60]
       ja        near ptr M11_L23
       mov       rdx,[rsp+58]
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2]
       mov       edx,[rsp+60]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M11_L19
       mov       r8d,[rbx+8]
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+50]
       add       ecx,[rbx+8]
       mov       [rsp+50],ecx
M11_L07:
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M11_L23
       mov       rdx,[rsp+58]
       mov       eax,ecx
       lea       rdx,[rdx+rax*2]
       mov       eax,[rsp+60]
       sub       eax,ecx
       je        near ptr M11_L20
       mov       word ptr [rdx],2E
       mov       ecx,[rsp+50]
       inc       ecx
       mov       [rsp+50],ecx
M11_L08:
       mov       rcx,1FB054012F8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       near ptr M11_L21
       mov       rbx,[rcx+18]
M11_L09:
       mov       edx,[rbx+8]
       sub       edx,1
       jo        near ptr M11_L25
       mov       ecx,1
       test      edx,edx
       cmovle    edx,ecx
       xor       ecx,ecx
       call      qword ptr [7FFBB45241B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,[rbx+8]
       jae       near ptr M11_L24
       mov       r8d,eax
       mov       rbx,[rbx+r8*8+10]
       cmp       byte ptr [rsp+54],0
       jne       near ptr M11_L22
       test      rbx,rbx
       je        near ptr M11_L22
       mov       r8d,[rsp+50]
       cmp       r8d,[rsp+60]
       ja        near ptr M11_L23
       mov       rdx,[rsp+58]
       mov       ecx,r8d
       lea       rcx,[rdx+rcx*2]
       mov       edx,[rsp+60]
       sub       edx,r8d
       cmp       [rbx+8],edx
       ja        near ptr M11_L22
       mov       r8d,[rbx+8]
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFBB3EF5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsp+50]
       add       ecx,[rbx+8]
       mov       [rsp+50],ecx
M11_L10:
       mov       ecx,[rsp+50]
       cmp       ecx,[rsp+60]
       ja        near ptr M11_L23
       mov       rax,[rsp+58]
       mov       [rsp+28],rax
       mov       [rsp+30],ecx
       lea       rcx,[rsp+28]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rbx,rax
       mov       rdx,[rsp+48]
       xor       ecx,ecx
       mov       [rsp+48],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+58],xmm0
       mov       [rsp+50],ecx
       test      rdx,rdx
       je        short M11_L11
       mov       rcx,1FB05400C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBB41BFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M11_L11:
       mov       rax,rbx
       add       rsp,68
       pop       rbx
       pop       rsi
       ret
M11_L12:
       xor       edx,edx
       xor       r8d,r8d
       jmp       near ptr M11_L00
M11_L13:
       mov       rbx,23B9A21FE78
       jmp       near ptr M11_L01
M11_L14:
       lea       rcx,[rsp+40]
       mov       rdx,rbx
       call      qword ptr [7FFBB45C5608]
       jmp       near ptr M11_L02
M11_L15:
       lea       rcx,[rsp+40]
       mov       rdx,23B9A210658
       call      qword ptr [7FFBB4527D38]
       jmp       near ptr M11_L03
M11_L16:
       mov       rsi,23B9A21FEA0
       jmp       near ptr M11_L04
M11_L17:
       lea       rcx,[rsp+40]
       mov       rdx,rsi
       call      qword ptr [7FFBB45C5608]
       jmp       near ptr M11_L05
M11_L18:
       lea       rcx,[rsp+40]
       mov       rdx,23B9A21FEC8
       call      qword ptr [7FFBB4527D38]
       jmp       near ptr M11_L06
M11_L19:
       lea       rcx,[rsp+40]
       mov       rdx,rbx
       call      qword ptr [7FFBB45C5608]
       jmp       near ptr M11_L07
M11_L20:
       lea       rcx,[rsp+40]
       mov       rdx,23B9A210658
       call      qword ptr [7FFBB4527D38]
       jmp       near ptr M11_L08
M11_L21:
       call      qword ptr [7FFBB4284240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rbx,rax
       jmp       near ptr M11_L09
M11_L22:
       lea       rcx,[rsp+40]
       mov       rdx,rbx
       call      qword ptr [7FFBB45C5608]
       jmp       near ptr M11_L10
M11_L23:
       call      qword ptr [7FFBB40671C8]
       int       3
M11_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M11_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 1119
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
       call      qword ptr [7FFBB44AFD08]; System.LazyHelper.get_State()
       mov       [rbp-0C],eax
       cmp       dword ptr [rbp-0C],8
       ja        short M13_L01
       mov       eax,[rbp-0C]
       lea       rcx,[7FFBB3F73E58]
       mov       ecx,[rcx+rax*4]
       lea       rdx,[M13_L00]
       add       rcx,rdx
       jmp       rcx
M13_L01:
       jmp       short M13_L02
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB44AFD20]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FFBB44AFD38]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FFBB44AFD50]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       call      qword ptr [7FFBB44AFD68]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       call      qword ptr [7FFBB44AFD80]
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       mov       r8d,1
       call      qword ptr [7FFBB44AFD98]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M13_L03
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-8]
       xor       r8d,r8d
       call      qword ptr [7FFBB44AFD98]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       short M13_L03
M13_L02:
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB44AFDB0]
M13_L03:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       call      qword ptr [7FFBB44AFCC0]; System.Lazy`1[[System.ValueTuple`3[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]].get_Value()
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
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M15_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M15_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M15_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M15_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M15_L01
M15_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M15_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D889430]
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
       call      qword ptr [7FFC0D8B6590]
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
       call      qword ptr [7FFC0D8B6590]
       test      eax,eax
       je        short M16_L05
       movzx     ecx,word ptr [rbp-3C]
       cmp       cx,[rbp-24]
       jne       short M16_L08
       mov       rsi,[rbp-20]
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFC0D89C8B8]
       mov       rbx,rax
M16_L02:
       call      qword ptr [7FFC0D8935D8]
       mov       rdi,rax
       call      qword ptr [7FFC0D8896B8]
       mov       [rdi+8],rsi
       mov       [rdi+10],rbx
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFC0D888FF0]; CORINFO_HELP_CHECKED_ASSIGN_REF
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
       call      qword ptr [7FFC0D889040]; CORINFO_HELP_POLL_GC
       jmp       near ptr M16_L00
M16_L05:
       call      qword ptr [7FFC0D89C8D8]
       jmp       short M16_L03
M16_L06:
       lea       rcx,[rbp-30]
       mov       rdx,rbx
       call      qword ptr [7FFC0D89C8B8]
       jmp       short M16_L03
M16_L07:
       call      qword ptr [7FFC0D889040]; CORINFO_HELP_POLL_GC
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
       call      qword ptr [7FFC0D899F40]
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
       call      qword ptr [7FFC0D89C8B8]
       mov       rbx,0C87700CB80
       add       rbx,rax
       jmp       near ptr M16_L02
; Total bytes of code 402
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       mov       rcx,16F5FC01310
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
       call      qword ptr [7FFBB44AC978]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       near ptr M00_L04
       mov       ecx,eax
       mov       rsi,[rsi+rcx*8+10]
       mov       rcx,16F5FC01318
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
       call      qword ptr [7FFBB44AC978]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,ebp
       jae       short M00_L04
       mov       edx,eax
       mov       rdx,[rdi+rdx*8+10]
       mov       [rsp+28],rsi
       mov       [rsp+30],rdx
       mov       rdx,[rbx+90]
       cmp       [rdx],dl
       lea       rdx,[rsp+28]
       mov       rcx,7FFBB4558BB0
       call      qword ptr [7FFBB4526AA8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.ValueTuple`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.ValueTuple`2<System.__Canon,System.__Canon> ByRef)
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L02:
       call      qword ptr [7FFBB4284240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       near ptr M00_L00
M00_L03:
       call      qword ptr [7FFBB4284240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       short M00_L01
M00_L04:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L05:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 248
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
       mov       rax,7FFBB4344D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB452EEC8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4284528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB452EDC0]
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M03_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M03_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M03_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M03_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M03_L01
M03_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M03_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M03_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateRelativeUrl()
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       call      qword ptr [7FFBB455E718]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       rcx,2C72F801340
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
       call      00007FFC13B421C0
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
       call      qword ptr [7FFBB45544F8]; System.Random+ThreadSafeRandom.Create()
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
       jl        near ptr M01_L13
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
       call      qword ptr [7FFBB40F2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       near ptr M01_L28
M01_L07:
       call      qword ptr [7FFBB45544F8]; System.Random+ThreadSafeRandom.Create()
       mov       rdx,[rbp-40]
M01_L08:
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
M01_L09:
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
M01_L10:
       add       r15d,1
       jo        near ptr M01_L24
       cmp       r15d,r14d
       jge       short M01_L12
M01_L11:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       near ptr M01_L08
       jmp       near ptr M01_L07
M01_L12:
       add       edi,1
       jo        near ptr M01_L24
       cmp       edi,esi
       jge       near ptr M01_L05
M01_L13:
       mov       rax,[rbx+10]
       test      rax,rax
       jne       short M01_L14
       call      qword ptr [7FFBB45544F8]; System.Random+ThreadSafeRandom.Create()
M01_L14:
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
M01_L15:
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
M01_L16:
       xor       r15d,r15d
       cmp       r15d,r14d
       jl        near ptr M01_L11
       jmp       near ptr M01_L12
M01_L17:
       mov       ecx,8
       call      qword ptr [7FFBB45D5140]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       jae       near ptr M01_L15
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
       jmp       near ptr M01_L15
M01_L22:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L16
M01_L23:
       cmp       r8d,16
       jb        short M01_L25
       jmp       near ptr M01_L09
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
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M01_L10
M01_L27:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFBB45D53E0]
       int       3
M01_L30:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555710]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45D5878]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB412DBF0]
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
       call      qword ptr [7FFBB45D5AE8]
       mov       rcx,[rbp-40]
       jmp       near ptr M01_L41
M01_L35:
       xor       edx,edx
       call      qword ptr [7FFBB45D5B00]
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
       call      qword ptr [7FFBB44BF360]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M01_L37:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFBB3F06FA0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,2C72F801340
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
       call      qword ptr [7FFBB45D53E0]
       int       3
M01_L44:
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      00007FFC13B421C0
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
       call      qword ptr [7FFBB45D5BA8]
       test      eax,eax
       jne       short M01_L42
       mov       rcx,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBB45D5BC0]
       jmp       short M01_L42
M01_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M01_L42
; Total bytes of code 1717
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateSentence()
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rbp-40],ymm4
       mov       [rbp+10],rcx
       mov       byte ptr [rbp-28],1
       mov       dword ptr [rbp-24],0A
       mov       rcx,1887DC01340
       mov       rbx,[rcx]
       mov       rcx,[rbx+20]
       mov       [rbp-30],rcx
       cmp       qword ptr [rbp-30],0
       je        near ptr M00_L25
       lea       rcx,[rbx+20]
       mov       r8,[rbp-30]
       test      rcx,rcx
       je        near ptr M00_L24
       xor       edx,edx
       call      00007FFC13B421C0
       cmp       rax,[rbp-30]
       jne       near ptr M00_L25
M00_L00:
       mov       rbx,[rbp-30]
M00_L01:
       xor       ecx,ecx
       mov       [rbp-30],rcx
       mov       [rbp-40],rbx
       xor       ebx,ebx
       cmp       ebx,0A
       jge       near ptr M00_L06
M00_L02:
       mov       ecx,3
       mov       edx,0A
       call      qword ptr [7FFBB4554E40]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4555818]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       test      ebx,ebx
       je        near ptr M00_L09
       mov       rdi,[rbp-40]
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       rax,[rdi+8]
       mov       r8d,[rax+8]
       cmp       r8d,edx
       jbe       near ptr M00_L20
       mov       word ptr [rax+rdx*2+10],20
       inc       ecx
       mov       [rdi+18],ecx
M00_L03:
       test      rsi,rsi
       je        short M00_L05
       lea       rdx,[rsi+0C]
       mov       esi,[rsi+8]
       test      esi,esi
       je        short M00_L05
       mov       r8,[rdi+8]
       mov       r14d,[rdi+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[r8+8]
       ja        near ptr M00_L21
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M00_L08
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L04:
       add       esi,r14d
       mov       [rdi+18],esi
M00_L05:
       add       ebx,1
       jo        near ptr M00_L19
       cmp       ebx,0A
       jl        near ptr M00_L02
M00_L06:
       mov       rdi,[rbp-40]
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       rax,[rdi+8]
       cmp       [rax+8],edx
       jbe       near ptr M00_L22
       mov       word ptr [rax+rdx*2+10],2E
       inc       ecx
       mov       [rdi+18],ecx
M00_L07:
       mov       rcx,rdi
       call      qword ptr [7FFBB40F2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       near ptr M00_L23
M00_L08:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M00_L04
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L04
M00_L09:
       cmp       dword ptr [rsi+8],0
       jbe       near ptr M00_L18
       movzx     edx,word ptr [rsi+0C]
       cmp       edx,7F
       jg        near ptr M00_L15
       mov       eax,edx
       lea       ecx,[rax-61]
       cmp       ecx,19
       jbe       near ptr M00_L14
M00_L10:
       mov       rdi,[rbp-40]
       mov       ecx,[rdi+18]
       mov       edx,ecx
       mov       r8,[rdi+8]
       cmp       [r8+8],edx
       jbe       near ptr M00_L16
       mov       [r8+rdx*2+10],ax
       inc       ecx
       mov       [rdi+18],ecx
M00_L11:
       mov       r8d,[rsi+8]
       lea       rdx,[rsi+0E]
       mov       esi,[rsi+8]
       dec       esi
       je        near ptr M00_L05
       mov       r8,[rdi+8]
       mov       r14d,[rdi+18]
       lea       ecx,[r14+rsi]
       cmp       ecx,[r8+8]
       ja        short M00_L17
       movsxd    rcx,r14d
       lea       rcx,[r8+rcx*2+10]
       cmp       esi,2
       jle       short M00_L13
       movsxd    r8,esi
       add       r8,r8
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M00_L12:
       add       esi,r14d
       mov       [rdi+18],esi
       jmp       near ptr M00_L05
M00_L13:
       movzx     r8d,word ptr [rdx]
       mov       [rcx],r8w
       cmp       esi,2
       jne       short M00_L12
       movzx     edx,word ptr [rdx+2]
       mov       [rcx+2],dx
       jmp       short M00_L12
M00_L14:
       mov       eax,edx
       and       eax,5F
       jmp       near ptr M00_L10
M00_L15:
       mov       rcx,18893C00088
       mov       rcx,[rcx]
       mov       r8d,1
       call      qword ptr [7FFBB45CCA98]
       jmp       near ptr M00_L10
M00_L16:
       mov       rcx,rdi
       mov       edx,eax
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L11
M00_L17:
       mov       rcx,rdi
       mov       r8d,esi
       call      qword ptr [7FFBB407F210]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L18:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L19:
       call      CORINFO_HELP_OVERFLOW
       int       3
M00_L20:
       mov       rcx,rdi
       mov       edx,20
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L03
M00_L21:
       mov       rcx,rdi
       mov       r8d,esi
       call      qword ptr [7FFBB407F210]; System.Text.StringBuilder.AppendWithExpansion(Char ByRef, Int32)
       jmp       near ptr M00_L05
M00_L22:
       mov       rcx,rdi
       mov       edx,2E
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       jmp       near ptr M00_L07
M00_L23:
       call      M00_L27
       nop
       mov       r10,[rbp-48]
       mov       [rbp-38],r10
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+90]
       lea       r8,[rbp-38]
       mov       rdx,7FFBB45B3968
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455EF58]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M00_L24:
       call      qword ptr [7FFBB45CC348]
       int       3
M00_L25:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-30]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45562C8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
       test      eax,eax
       je        short M00_L26
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       near ptr M00_L00
M00_L26:
       mov       rax,[rbx+8]
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       rbx,rax
       jmp       near ptr M00_L01
M00_L27:
       sub       rsp,28
       mov       rdi,[rbp-40]
       cmp       dword ptr [rdi+20],0
       jge       short M00_L28
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       rbx,rax
       call      qword ptr [7FFBB45CC828]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFBB412E790]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
M00_L28:
       cmp       qword ptr [rdi+10],0
       jne       short M00_L29
       xor       ecx,ecx
       mov       [rdi+18],rcx
       jmp       near ptr M00_L36
M00_L29:
       mov       ecx,[rdi+1C]
       add       ecx,[rdi+18]
       mov       r8d,ecx
       neg       r8d
       test      r8d,r8d
       jle       short M00_L30
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFBB45CCA20]
       jmp       near ptr M00_L36
M00_L30:
       mov       rcx,rdi
       xor       edx,edx
       call      qword ptr [7FFBB45CCA38]
       mov       rbx,rax
       cmp       rbx,rdi
       je        near ptr M00_L35
       mov       rax,[rdi+8]
       mov       ecx,[rax+8]
       add       ecx,[rdi+1C]
       mov       eax,[rdi+1C]
       add       eax,[rdi+18]
       lea       edx,[rax+rax*2]
       add       edx,edx
       mov       r8d,66666667
       mov       eax,r8d
       imul      edx
       mov       eax,edx
       shr       eax,1F
       sar       edx,1
       add       edx,eax
       mov       rax,[rdi+8]
       mov       eax,[rax+8]
       cmp       edx,eax
       cmovl     edx,eax
       cmp       ecx,edx
       cmovg     ecx,edx
       sub       ecx,[rbx+1C]
       mov       rdx,[rbx+8]
       cmp       [rdx+8],ecx
       jge       short M00_L33
       cmp       ecx,400
       jge       short M00_L31
       movsxd    rdx,ecx
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       rsi,rax
       jmp       short M00_L32
M00_L31:
       xor       edx,edx
       call      qword ptr [7FFBB44BFB10]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M00_L32:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFBB3F06FA0]; System.Array.Copy(System.Array, System.Array, Int32)
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M00_L34
M00_L33:
       mov       rdx,[rbx+8]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
M00_L34:
       mov       rdx,[rbx+10]
       lea       rcx,[rdi+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rbx+1C]
       mov       [rdi+1C],ecx
M00_L35:
       mov       ecx,[rbx+1C]
       neg       ecx
       mov       [rdi+18],ecx
M00_L36:
       mov       rdx,1887DC01340
       mov       rbx,[rdx]
       mov       rax,[rbx+10]
       mov       rdx,rdi
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M00_L38
M00_L37:
       add       rsp,28
       ret
M00_L38:
       cmp       qword ptr [rbx+20],0
       jne       short M00_L40
       lea       rcx,[rbx+20]
       test      rcx,rcx
       jne       short M00_L39
       call      qword ptr [7FFBB45CC348]
       int       3
M00_L39:
       mov       rdx,rdi
       xor       r8d,r8d
       call      00007FFC13B421C0
       test      rax,rax
       je        short M00_L37
M00_L40:
       lea       rcx,[rbx+2C]
       mov       edx,1
       lock xadd [rcx],edx
       inc       edx
       cmp       edx,[rbx+28]
       jg        short M00_L41
       mov       rbx,[rbx+18]
       mov       rcx,[rbx+10]
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFBB45CCB10]
       test      eax,eax
       jne       short M00_L37
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFBB45CCB28]
       jmp       short M00_L37
M00_L41:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M00_L37
; Total bytes of code 1290
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45CCA08]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42950C8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45CC330]
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
       mov       rax,0CF11C8A933F6
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
       mov       rax,7FFBB4364D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,0CF11C8A933F6
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
       call      qword ptr [7FFBB4554780]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB4554798]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45CD6C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,1C912B12288
       call      qword ptr [7FFBB412E790]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40771C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45CC330]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1887DC01E68
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB454B350]
       mov       [rbp+28],rax
       mov       rcx,1887DC00C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41CFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4345D28]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40771C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB434D818]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F01548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1887DC01E68
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB454B358]
       mov       rcx,1887DC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB454B088],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,1887DC01E68
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB454B358]
       mov       rcx,1887DC00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       nop
       add       rsp,28
       ret
; Total bytes of code 1124
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
       ja        short M03_L02
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
       je        near ptr M03_L09
       mov       r8d,[rdx]
       mov       [rcx],r8d
       mov       edx,[rax-4]
       mov       [r10-4],edx
       jmp       short M03_L00
M03_L02:
       cmp       r8,40
       ja        short M03_L05
M03_L03:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       ja        short M03_L08
M03_L04:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
       jmp       short M03_L00
M03_L05:
       cmp       r8,800
       ja        near ptr M03_L12
       cmp       r8,100
       jae       short M03_L10
M03_L06:
       mov       r9,r8
       shr       r9,6
M03_L07:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L07
       and       r8,3F
       cmp       r8,10
       ja        short M03_L03
       jmp       short M03_L04
M03_L08:
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L04
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
       jmp       short M03_L04
M03_L09:
       test      r8,r8
       je        near ptr M03_L00
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L00
       movsx     r8,word ptr [rax-2]
       mov       [r10-2],r8w
       jmp       near ptr M03_L00
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
       jmp       near ptr M03_L06
M03_L11:
       cmp       rcx,rdx
       jne       short M03_L12
       cmp       [rdx],dl
       jmp       near ptr M03_L00
M03_L12:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBB3F066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 336
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbx,rcx
       mov       edx,[rbx+1C]
       add       edx,[rbx+18]
       je        short M04_L02
       movsxd    rdx,edx
       mov       rcx,offset MT_System.String
       call      00007FFC13B952E0
       mov       rsi,rax
M04_L00:
       mov       r8d,[rbx+18]
       test      r8d,r8d
       jle       short M04_L01
       mov       rdx,[rbx+8]
       mov       ecx,[rbx+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rsi+8]
       ja        short M04_L03
       cmp       [rdx+8],r8d
       jb        short M04_L03
       movsxd    rcx,ecx
       lea       rcx,[rsi+rcx*2+0C]
       movsxd    r8,r8d
       add       r8,r8
       add       rdx,10
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M04_L01:
       mov       rbx,[rbx+10]
       test      rbx,rbx
       jne       short M04_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L02:
       mov       rax,1C912B10008
       add       rsp,28
       pop       rbx
       pop       rsi
       ret
M04_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,19655
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       rbx,rax
       call      qword ptr [7FFBB45CC768]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rsi
       call      qword ptr [7FFBB412E790]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 201
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
       call      qword ptr [7FFC0D8A37D8]; Precode of System.Text.StringBuilder.ExpandByABlock(Int32)
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
       call      qword ptr [7FFC0D888FD8]
       int       3
; Total bytes of code 56
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
       jg        near ptr M06_L05
       cmp       eax,esi
       jl        near ptr M06_L05
       mov       rax,[rbx+8]
       mov       ebp,[rax+8]
       sub       ebp,ecx
       test      ebp,ebp
       jle       short M06_L01
       mov       rax,[rbx+8]
       test      rax,rax
       je        near ptr M06_L06
       mov       edx,[rax+8]
       cmp       edx,ecx
       jb        near ptr M06_L07
       mov       r8d,ecx
       lea       rax,[rax+r8*2+10]
       sub       edx,ecx
M06_L00:
       cmp       ebp,edx
       ja        near ptr M06_L11
       mov       r8d,ebp
       add       r8,r8
       mov       rcx,rax
       mov       rdx,rdi
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,[rbx+8]
       mov       ecx,[rcx+8]
       mov       [rbx+18],ecx
M06_L01:
       sub       esi,ebp
       mov       ecx,[rbx+1C]
       lea       edx,[rsi+rcx]
       mov       eax,[rbx+18]
       add       edx,eax
       cmp       edx,[rbx+20]
       jg        near ptr M06_L08
       cmp       edx,esi
       jl        near ptr M06_L08
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
       jl        near ptr M06_L09
       cmp       eax,400
       jl        short M06_L02
       mov       ecx,eax
       xor       edx,edx
       call      qword ptr [7FFBB44BFB10]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       r14,rax
       jmp       short M06_L03
M06_L02:
       movsxd    rdx,eax
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
M06_L03:
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
       je        near ptr M06_L10
       lea       rcx,[r8+10]
       mov       r8d,[r8+8]
M06_L04:
       cmp       esi,r8d
       ja        near ptr M06_L11
       mov       r8d,esi
       add       r8,r8
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       [rbx+18],esi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M06_L05:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,19685
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45CC7E0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB412E790]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L06:
       test      ecx,ecx
       jne       short M06_L07
       xor       eax,eax
       xor       edx,edx
       jmp       near ptr M06_L00
M06_L07:
       call      qword ptr [7FFBB40771C8]
       int       3
M06_L08:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       ecx,1969B
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45CC828]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB412E790]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L09:
       mov       rcx,offset MT_System.OutOfMemoryException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB45CC840]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M06_L10:
       xor       ecx,ecx
       xor       r8d,r8d
       jmp       near ptr M06_L04
M06_L11:
       call      qword ptr [7FFBB434DE78]
       int       3
; Total bytes of code 621
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
       call      qword ptr [7FFC0D8AEA60]
       test      eax,eax
       jne       short M08_L01
       cmp       qword ptr [rdi+10],0
       je        short M08_L00
       mov       rcx,rsi
       mov       rdx,rbx
       lea       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [rax]
M08_L00:
       xor       eax,eax
       mov       [rbx],rax
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M08_L01:
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
       call      qword ptr [7FFC0D889030]; CORINFO_HELP_JIT_PINVOKE_BEGIN
       mov       rax,[System.Collections.Generic.CollectionExtensions.AsReadOnly[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)]
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0A4]
       mov       r8d,[rbp-0A8]
       mov       r9,[rbp-0B8]
       call      qword ptr [rax]
       lea       rcx,[rbp-0A0]
       call      qword ptr [7FFC0D889038]; CORINFO_HELP_JIT_PINVOKE_END
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
       jne       short M10_L01
       xor       ebp,ebp
       xor       r14d,r14d
M10_L00:
       test      rbx,rbx
       jne       near ptr M10_L09
       xor       ebx,ebx
       xor       r15d,r15d
       jmp       near ptr M10_L10
M10_L01:
       test      rbx,rbx
       jne       short M10_L04
       mov       rcx,7FFBB45B732C
       call      CORINFO_HELP_COUNTPROFILE32
M10_L02:
       mov       rcx,7FFBB45B7334
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rsi]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L08
       xor       r14d,r14d
M10_L03:
       mov       rbp,rsi
       jmp       short M10_L00
M10_L04:
       mov       r15,[rsi]
       cmp       r15,[rbx]
       je        short M10_L05
       mov       rcx,7FFBB45B7328
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L05:
       cmp       dword ptr [r15+4],18
       je        short M10_L06
       mov       rcx,7FFBB45B7324
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L06:
       cmp       edi,[rsi+8]
       jbe       short M10_L07
       mov       rcx,7FFBB45B7320
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       short M10_L02
M10_L07:
       cmp       edi,[rbx+8]
       jbe       near ptr M10_L13
       mov       rcx,7FFBB45B731C
       call      CORINFO_HELP_COUNTPROFILE32
       jmp       near ptr M10_L02
M10_L08:
       movsxd    rcx,ecx
       mov       r14d,[rsi+rcx*4+10]
       jmp       short M10_L03
M10_L09:
       mov       rcx,7FFBB45B7338
       call      CORINFO_HELP_COUNTPROFILE32
       mov       rcx,[rbx]
       mov       ecx,[rcx+4]
       add       ecx,0FFFFFFE8
       shr       ecx,3
       jne       short M10_L12
       xor       r15d,r15d
M10_L10:
       mov       rcx,7FFBB45B733C
       call      CORINFO_HELP_COUNTPROFILE32
       mov       [rsp+20],edi
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       rcx,rbp
       mov       edx,r14d
       mov       r8,rbx
       mov       r9d,r15d
       call      qword ptr [7FFBB4557048]; System.Array.CopyImpl(System.Array, Int32, System.Array, Int32, Int32, Boolean)
M10_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M10_L12:
       movsxd    rcx,ecx
       mov       r15d,[rbx+rcx*4+10]
       jmp       short M10_L10
M10_L13:
       mov       edi,edi
       movzx     ebp,word ptr [r15]
       imul      rdi,rbp
       add       rsi,10
       add       rbx,10
       test      dword ptr [r15],1000000
       je        short M10_L15
       mov       rcx,7FFBB45B7318
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,4000
       ja        short M10_L14
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      00007FFC13B137A0
       cmp       dword ptr [7FFC13E53A90],0
       je        short M10_L11
       call      CORINFO_HELP_POLL_GC
       jmp       short M10_L11
M10_L14:
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
       jmp       qword ptr [7FFBB44BF450]
M10_L15:
       mov       rcx,7FFBB45B7330
       call      CORINFO_HELP_COUNTPROFILE32
       cmp       rdi,19
       jne       short M10_L16
       vmovdqu   xmm0,xmmword ptr [rsi]
       vmovdqu   xmm1,xmmword ptr [rsi+9]
       vmovdqu   xmmword ptr [rbx],xmm0
       vmovdqu   xmmword ptr [rbx+9],xmm1
       jmp       near ptr M10_L11
M10_L16:
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8,rdi
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M10_L11
; Total bytes of code 488
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTimeOnly()
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,0FB8F9BCD3402
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-80],rdx
       mov       rdx,rbp
       mov       [rbp-70],rdx
       mov       [rbp-0A8],rbx
       lea       rdi,[rbp-48]
       mov       [rbp-0A0],rdi
       mov       [rbp-58],rdi
       mov       rdx,rdi
       xor       ecx,ecx
       mov       r8d,8
       mov       r9d,2
       mov       rax,7FFBB4344D88
       mov       [rbp-88],rax
       lea       rax,[M00_L00]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L04
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rdi,[rbp-0A0]
       mov       rbx,[rdi]
       test      rbx,rbx
       jge       short M00_L02
       neg       rbx
       js        near ptr M00_L05
M00_L02:
       mov       rdx,0A2E3FF1DE20581E3
       mov       rax,rdx
       imul      rbx
       add       rdx,rbx
       mov       rax,rdx
       shr       rax,3F
       sar       rdx,27
       add       rax,rdx
       mov       rdx,0C92A69C000
       imul      rax,rdx
       sub       rbx,rax
       mov       rdx,0A2E3FF1DE20581E3
       mov       rax,rdx
       imul      rbx
       add       rdx,rbx
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,27
       add       rdx,rcx
       mov       rcx,0C92A69C000
       imul      rdx,rcx
       sub       rbx,rdx
       add       rcx,rbx
       mov       rdx,0A2E3FF1DE20581E3
       mulx      rax,rax,rcx
       shr       rax,27
       mov       rdx,0C92A69C000
       imul      rax,rdx
       sub       rcx,rax
       mov       [rbp-60],rcx
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBB454E820]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeOnly, System.Private.CoreLib]](System.TimeOnly ByRef)
       mov       r8,0FB8F9BCD3402
       cmp       [rbp-40],r8
       je        short M00_L03
       call      CORINFO_HELP_FAIL_FAST
M00_L03:
       nop
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
M00_L04:
       mov       ecx,eax
       call      qword ptr [7FFBB45C4AB0]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFBB45C53F8]
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeOnly, System.Private.CoreLib]](System.TimeOnly ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateTimeSpan()
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
       xor       eax,eax
       mov       [rbp-48],rax
       mov       rax,430FBACAF91B
       mov       [rbp-40],rax
       mov       rbx,rcx
       lea       rcx,[rbp-98]
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rdx,rsp
       mov       [rbp-80],rdx
       mov       rdx,rbp
       mov       [rbp-70],rdx
       mov       [rbp-0A8],rbx
       lea       rdi,[rbp-48]
       mov       [rbp-0A0],rdi
       mov       [rbp-58],rdi
       mov       rdx,rdi
       xor       ecx,ecx
       mov       r8d,8
       mov       r9d,2
       mov       rax,7FFBB4354D88
       mov       [rbp-88],rax
       lea       rax,[M00_L00]
       mov       [rbp-78],rax
       lea       rax,[rbp-98]
       mov       [rsi+8],rax
       mov       byte ptr [rsi+4],0
       mov       rax,7FFC3B843670
       call      rax
M00_L00:
       mov       byte ptr [rsi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M00_L01
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
M00_L01:
       mov       rcx,[rbp-90]
       mov       [rsi+8],rcx
       test      eax,eax
       jne       near ptr M00_L04
       xor       eax,eax
       mov       [rbp-58],rax
       mov       rdi,[rbp-0A0]
       mov       rbx,[rdi]
       test      rbx,rbx
       jge       short M00_L02
       neg       rbx
       js        near ptr M00_L05
M00_L02:
       mov       rdx,391F8F7898343B17
       mov       rax,rdx
       imul      rbx
       mov       rcx,rdx
       shr       rcx,3F
       sar       rdx,2E
       add       rcx,rdx
       mov       rax,11ED178C6C001
       imul      rcx,rax
       sub       rbx,rcx
       mov       [rbp-60],rbx
       mov       rbx,[rbp-0A8]
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rbp-60]
       call      qword ptr [7FFBB454EFB8]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       mov       r8,430FBACAF91B
       cmp       [rbp-40],r8
       je        short M00_L03
       call      CORINFO_HELP_FAIL_FAST
M00_L03:
       nop
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
M00_L04:
       mov       ecx,eax
       call      qword ptr [7FFBB45BC2E8]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M00_L05:
       call      qword ptr [7FFBB45BC960]
       int       3
; Total bytes of code 387
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFBB4554678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4555008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,28A858012F8
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
       call      qword ptr [7FFBB4554678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      00007FFC13B952E0
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
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L01:
       mov       rdx,rsi
       mov       rcx,2CB1A7B0E50
       mov       r8,2CB1A7A0658
       call      qword ptr [7FFBB3F07870]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       short M00_L03
M00_L02:
       mov       r8,rdi
       mov       rcx,2CB1A7B0E50
       mov       rdx,2CB1A7A0658
       call      qword ptr [7FFBB3F07870]; System.String.Concat(System.String, System.String, System.String)
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
       call      00007FFC13B952E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       r8,[rdi+0C]
       vmovups   xmm0,[7FFBB3FB9440]
       vmovups   [r8],xmm0
       mov       r8d,esi
       add       r8,r8
       lea       rdx,[r15+0C]
       lea       rcx,[rdi+1C]
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L04:
       mov       rdi,2CB1A7B0E28
M00_L05:
       call      qword ptr [7FFBB455E7D8]; DotNetTips.Spargine.Tester.RandomData.GenerateRelativeUrl()
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
       mov       rcx,7FFBB44D5D10
       call      qword ptr [7FFBB44BE7C0]; System.Runtime.CompilerServices.TypeHandle.TypeHandleOf[[System.__Canon, System.Private.CoreLib]]()
       mov       rcx,rax
       movsxd    rdx,r14d
       call      00007FFC13B952E0
       mov       r14,rax
       mov       rcx,r14
       mov       r8,rdi
       xor       edx,edx
       call      qword ptr [7FFBB45D64D8]; System.String.CopyStringContent(System.String, Int32, System.String)
       mov       rcx,r14
       mov       edx,ebp
       mov       r8,rsi
       call      qword ptr [7FFBB45D64D8]; System.String.CopyStringContent(System.String, Int32, System.String)
       jmp       short M00_L07
M00_L06:
       mov       r14,rdi
M00_L07:
       mov       [rsp+20],r14
       mov       rcx,[rbx+90]
       lea       r8,[rsp+20]
       mov       rdx,7FFBB45AF098
       cmp       [rcx],ecx
       call      qword ptr [7FFBB455E838]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBB4294240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
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
       mov       r14,2CB1A7A0008
       jmp       short M00_L07
M00_L11:
       mov       r14,rsi
       jmp       short M00_L07
M00_L12:
       call      qword ptr [7FFBB45D5230]
       int       3
M00_L13:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L14:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 733
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
       mov       rax,7FFBB4354D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45D55D8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB4294528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4B88]
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
       mov       rax,0E72E4D5620E2
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
       mov       rax,7FFBB4354D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,0E72E4D5620E2
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
       call      qword ptr [7FFBB44BFFA8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB44BFFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45D64A8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2CB1A7A2288
       call      qword ptr [7FFBB412DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40771C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45D4B88]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28A85801E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4545E10]
       mov       [rbp+28],rax
       mov       rcx,28A85800C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41CFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4345188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40771C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB434CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F01548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,28A85801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4545E18]
       mov       rcx,28A85800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45251E8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F05728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,28A85801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4545E18]
       mov       rcx,28A85800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41CFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jbe       near ptr M03_L07
       cmp       r8,40
       ja        short M03_L03
M03_L00:
       vmovups   xmm0,[rdx]
       vmovups   [rcx],xmm0
       cmp       r8,20
       jbe       short M03_L01
       vmovups   xmm0,[rdx+10]
       vmovups   [rcx+10],xmm0
       cmp       r8,30
       jbe       short M03_L01
       vmovups   xmm0,[rdx+20]
       vmovups   [rcx+20],xmm0
M03_L01:
       vmovups   xmm0,[rax-10]
       vmovups   [r10-10],xmm0
M03_L02:
       vzeroupper
       ret
M03_L03:
       cmp       r8,800
       ja        near ptr M03_L11
       cmp       r8,100
       jae       short M03_L06
M03_L04:
       mov       r9,r8
       shr       r9,6
M03_L05:
       vmovdqu   ymm0,ymmword ptr [rdx]
       vmovdqu   ymmword ptr [rcx],ymm0
       vmovdqu   ymm0,ymmword ptr [rdx+20]
       vmovdqu   ymmword ptr [rcx+20],ymm0
       add       rcx,40
       add       rdx,40
       dec       r9
       jne       short M03_L05
       and       r8,3F
       cmp       r8,10
       ja        short M03_L00
       jmp       short M03_L01
M03_L06:
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
       jmp       short M03_L04
M03_L07:
       test      r8b,18
       je        short M03_L08
       mov       r8,[rdx]
       mov       [rcx],r8
       mov       rdx,[rax-8]
       mov       [r10-8],rdx
       jmp       near ptr M03_L02
M03_L08:
       test      r8b,4
       jne       short M03_L09
       test      r8,r8
       je        near ptr M03_L02
       movzx     edx,byte ptr [rdx]
       mov       [rcx],dl
       test      r8b,2
       je        near ptr M03_L02
       movsx     rcx,word ptr [rax-2]
       mov       [r10-2],cx
       jmp       near ptr M03_L02
M03_L09:
       mov       edx,[rdx]
       mov       [rcx],edx
       mov       ecx,[rax-4]
       mov       [r10-4],ecx
       jmp       near ptr M03_L02
M03_L10:
       cmp       rcx,rdx
       jne       short M03_L11
       cmp       [rdx],dl
       jmp       near ptr M03_L02
M03_L11:
       cmp       [rcx],cl
       cmp       [rdx],dl
       vzeroupper
       jmp       qword ptr [7FFBB3F066E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 335
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
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L02
       test      rdi,rdi
       je        near ptr M04_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M04_L01
       test      rsi,rsi
       je        near ptr M04_L00
       cmp       dword ptr [rsi+8],0
       je        near ptr M04_L00
       mov       r15d,ebp
       mov       ecx,r14d
       add       rcx,r15
       mov       eax,[rsi+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M04_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFC0D89B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
M04_L01:
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
M04_L02:
       mov       rdx,rsi
       mov       rcx,rdi
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
       call      qword ptr [7FFC0D89F488]
       int       3
; Total bytes of code 323
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
       mov       rcx,28A85801340
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
       call      00007FFC13B421C0
       cmp       rax,[rbp-38]
       jne       near ptr M05_L30
M05_L00:
       mov       rdx,[rbp-38]
M05_L01:
       xor       ecx,ecx
       mov       [rbp-38],rcx
       mov       [rbp-40],rdx
       mov       rcx,gs:[58]
       mov       rcx,[rcx+30]
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
       call      qword ptr [7FFBB45544E0]; System.Random+ThreadSafeRandom.Create()
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
       mov       word ptr [r8+rax*2+10],2F
       inc       ecx
       mov       [rdx+18],ecx
M05_L06:
       mov       rcx,rdx
       call      qword ptr [7FFBB40F2200]; System.Text.StringBuilder.ToString()
       mov       [rbp-48],rax
       jmp       near ptr M05_L28
M05_L07:
       call      qword ptr [7FFBB45544E0]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFBB45544E0]; System.Random+ThreadSafeRandom.Create()
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
       call      qword ptr [7FFBB45D4CA8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
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
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
       mov       rdx,[rbp-40]
       jmp       near ptr M05_L10
M05_L27:
       mov       rcx,rdx
       mov       edx,2F
       call      qword ptr [7FFBB407F3D8]; System.Text.StringBuilder.AppendWithExpansion(Char)
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
       call      qword ptr [7FFBB45D5218]
       int       3
M05_L30:
       mov       rcx,[rbx+18]
       lea       rdx,[rbp-38]
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555AB8]; System.Collections.Concurrent.ConcurrentQueue`1[[System.__Canon, System.Private.CoreLib]].TryDequeue(System.__Canon ByRef)
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
       mov       rdx,7FFBB3E44000
       call      qword ptr [7FFBB41277C8]
       mov       rsi,rax
       call      qword ptr [7FFBB45D52D8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBB412DBF0]
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
       call      qword ptr [7FFBB45D55F0]
       mov       rcx,[rbp-40]
       jmp       near ptr M05_L41
M05_L35:
       xor       edx,edx
       call      qword ptr [7FFBB45D5608]
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
       call      qword ptr [7FFBB44BF348]; System.GC.<AllocateUninitializedArray>g__AllocateNewArrayWorker|77_0[[System.Char, System.Private.CoreLib]](Int32, Boolean)
       mov       rsi,rax
M05_L37:
       mov       rcx,[rbx+8]
       mov       r8d,[rbx+18]
       mov       rdx,rsi
       call      qword ptr [7FFBB3F06FA0]; System.Array.Copy(System.Array, System.Array, Int32)
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
       mov       rdx,28A85801340
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
       call      qword ptr [7FFBB45D5218]
       int       3
M05_L44:
       mov       rdx,[rbp-40]
       xor       r8d,r8d
       call      00007FFC13B421C0
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
       call      qword ptr [7FFBB45D56B0]
       test      eax,eax
       jne       short M05_L42
       mov       rcx,rbx
       mov       rdx,[rbp-40]
       call      qword ptr [7FFBB45D56C8]
       jmp       short M05_L42
M05_L46:
       add       rbx,2C
       lock dec  dword ptr [rbx]
       jmp       short M05_L42
; Total bytes of code 1717
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
       call      qword ptr [7FFBB3F05818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M09_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M09_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M09_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M09_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M09_L01
M09_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M09_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M09_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4565008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
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
       call      00007FFC13B952E0
       mov       rbp,rax
       cmp       [rbp],bpl
       lea       r8,[rbp+0C]
       mov       word ptr [r8],2F
       mov       r8d,edi
       add       r8,r8
       lea       rdx,[rsi+0C]
       lea       rcx,[rbp+0E]
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L01
M00_L00:
       mov       rbp,22FAEB95540
M00_L01:
       mov       [rsp+28],rbp
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFBB45E51B8]
       int       3
; Total bytes of code 221
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45E54E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4B10]
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
       mov       rax,7B906A4830EE
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
       mov       rax,7FFBB4364D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,7B906A4830EE
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
       call      qword ptr [7FFBB44CFFA8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB44CFFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45E6400]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,22FAEB92288
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4B10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EF19C01E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E10]
       mov       [rbp+28],rax
       mov       rcx,1EF19C00C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41DFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4355188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB435CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F11548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1EF19C01E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E18]
       mov       rcx,1EF19C00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45351E8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,1EF19C01E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E18]
       mov       rcx,1EF19C00C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFBB3F166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
; Total bytes of code 317
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFBB45441B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4544B40]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,224924012F8
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
       call      qword ptr [7FFBB45441B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      00007FFC13B952E0
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
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L01:
       mov       rdx,rsi
       mov       rcx,26527350E50
       mov       r8,26527340658
       call      qword ptr [7FFBB3F17870]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       short M00_L03
M00_L02:
       mov       r8,rdi
       mov       rcx,26527350E50
       mov       rdx,26527340658
       call      qword ptr [7FFBB3F17870]; System.String.Concat(System.String, System.String, System.String)
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
       call      00007FFC13B952E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       r8,[rdi+0C]
       vmovups   xmm0,[7FFBB3FC6DF0]
       vmovups   [r8],xmm0
       mov       r8d,esi
       add       r8,r8
       lea       rdx,[r15+0C]
       lea       rcx,[rdi+1C]
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L05
M00_L04:
       mov       rdi,26527350E28
M00_L05:
       mov       [rsp+20],rdi
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
M00_L06:
       call      qword ptr [7FFBB42A4240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L07:
       call      qword ptr [7FFBB45E55D8]
       int       3
M00_L08:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45E5938]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4F60]
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
       mov       rax,15EF09143972
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
       mov       rax,7FFBB4364D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,15EF09143972
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
       call      qword ptr [7FFBB44CFAE0]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB44CFAF8]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45E6718]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,26527342288
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4F60]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22492401E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4554F90]
       mov       [rbp+28],rax
       mov       rcx,22492400C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41DFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4355188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB435CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F11548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,22492401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4554F98]
       mov       rcx,22492400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB4554D30],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,22492401E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4554F98]
       mov       rcx,22492400C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFBB3F166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L02
       test      rdi,rdi
       je        near ptr M04_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M04_L01
       test      rsi,rsi
       je        near ptr M04_L00
       cmp       dword ptr [rsi+8],0
       je        near ptr M04_L00
       mov       r15d,ebp
       mov       ecx,r14d
       add       rcx,r15
       mov       eax,[rsi+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M04_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFC0D89B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
M04_L01:
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
M04_L02:
       mov       rdx,rsi
       mov       rcx,rdi
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
       call      qword ptr [7FFC0D89F488]
       int       3
; Total bytes of code 323
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M05_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M05_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       mov       ecx,eax
       mov       edx,61
       mov       r8d,7A
       call      qword ptr [7FFBB4565008]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32, Char, Char)
       mov       rsi,rax
       mov       rcx,1E5B58012F8
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
       call      qword ptr [7FFBB4564678]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
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
       call      00007FFC13B952E0
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
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       call      qword ptr [7FFBB3F15818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M00_L03
M00_L01:
       mov       rdx,rsi
       mov       rcx,2264A720E28
       mov       r8,2264A710658
       call      qword ptr [7FFBB3F17870]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
       jmp       short M00_L03
M00_L02:
       mov       r8,rdi
       mov       rcx,2264A720E28
       mov       rdx,2264A710658
       call      qword ptr [7FFBB3F17870]; System.String.Concat(System.String, System.String, System.String)
       mov       r15,rax
M00_L03:
       mov       [rsp+20],r15
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
       call      qword ptr [7FFBB42A4240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdi,rax
       jmp       near ptr M00_L00
M00_L05:
       call      qword ptr [7FFBB45E51A0]
       int       3
M00_L06:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L07:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 487
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45E54E8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4B10]
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
       mov       rax,0B7504074451A
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
       mov       rax,7FFBB4364D88
       mov       [rbp+60],rax
       lea       rax,[M02_L05]
       mov       [rbp+70],rax
       lea       rax,[rbp+50]
       mov       [r14+8],rax
       mov       byte ptr [r14+4],0
       mov       rax,7FFC3B843670
       call      rax
M02_L05:
       mov       byte ptr [r14+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M02_L06
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       mov       r8,0B7504074451A
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
       call      qword ptr [7FFBB44CFFA8]
       mov       ebx,eax
       jmp       near ptr M02_L00
M02_L14:
       call      qword ptr [7FFBB44CFFC0]
       mov       rbx,rax
       test      rbx,rbx
       jne       short M02_L15
       call      qword ptr [7FFBB45E62C8]
       mov       rbx,rax
M02_L15:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       r8,rbx
       mov       rdx,2264A712288
       call      qword ptr [7FFBB413DBF0]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M02_L16:
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L17:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4B10]
       mov       rcx,rax
       call      CORINFO_HELP_THROW
       int       3
M02_L18:
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E5B5801E50
       mov       rcx,[rcx]
       mov       edx,r15d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E10]
       mov       [rbp+28],rax
       mov       rcx,1E5B5800C88
       mov       rcx,[rcx]
       mov       edx,r15d
       call      qword ptr [7FFBB41DFB48]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
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
       call      qword ptr [7FFBB4355188]; System.Security.Cryptography.RandomNumberGeneratorImplementation.FillSpan(System.Span`1<Byte>)
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
       call      qword ptr [7FFBB40871C8]
       int       3
M02_L20:
       lea       rdx,[r8+10]
       mov       ecx,r15d
       mov       [rbp+40],rdx
       mov       [rbp+48],ecx
       lea       rdx,[rbp+40]
       lea       rcx,[rbp+90]
       call      qword ptr [7FFBB435CC78]; System.Span`1[[System.Byte, System.Private.CoreLib]].op_Implicit(System.Span`1<Byte>)
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
       call      00007FFBB3F11548
       mov       rbx,rax
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       rcx,1E5B5801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E18]
       mov       rcx,1E5B5800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       mov       rax,rbx
       jmp       near ptr M02_L11
M02_L25:
       call      CORINFO_HELP_OVERFLOW
       int       3
       sub       rsp,28
       vzeroupper
       test      byte ptr [7FFBB45351E8],1
       jne       short M02_L26
       mov       rcx,offset MT_System.Buffers.ArrayPool<System.Byte>
       call      qword ptr [7FFBB3F15728]; System.Runtime.CompilerServices.StaticsHelpers.GetGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
M02_L26:
       mov       rcx,1E5B5801E50
       mov       rcx,[rcx]
       mov       rdx,[rbp+28]
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFBB4555E18]
       mov       rcx,1E5B5800C88
       mov       rcx,[rcx]
       mov       rdx,[rbp+20]
       xor       r8d,r8d
       call      qword ptr [7FFBB41DFB50]; Precode of System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
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
       jmp       qword ptr [7FFBB3F166E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rdi,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M04_L02
       mov       ebp,[rbx+8]
       test      ebp,ebp
       je        near ptr M04_L02
       test      rdi,rdi
       je        near ptr M04_L01
       mov       r14d,[rdi+8]
       test      r14d,r14d
       je        near ptr M04_L01
       test      rsi,rsi
       je        near ptr M04_L00
       cmp       dword ptr [rsi+8],0
       je        near ptr M04_L00
       mov       r15d,ebp
       mov       ecx,r14d
       add       rcx,r15
       mov       eax,[rsi+8]
       add       rcx,rax
       cmp       rcx,7FFFFFFF
       jg        near ptr M04_L03
       movsxd    rcx,ecx
       call      qword ptr [7FFC0D89B9F0]; Precode of System.String.FastAllocateString(IntPtr)
       mov       r13,rax
       cmp       [r13],r13b
       lea       r12,[r13+0C]
       mov       rcx,r12
       mov       r8d,ebp
       add       r8,r8
       lea       rdx,[rbx+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       lea       rcx,[r12+r15*2]
       mov       r8d,r14d
       add       r8,r8
       lea       rdx,[rdi+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       ebp,r14d
       movsxd    rcx,ebp
       lea       rcx,[r12+rcx*2]
       mov       r8d,[rsi+8]
       add       r8,r8
       lea       rdx,[rsi+0C]
       call      qword ptr [7FFC0D89D928]; Precode of System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,r13
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
M04_L01:
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
M04_L02:
       mov       rdx,rsi
       mov       rcx,rdi
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
       call      qword ptr [7FFC0D89F488]
       int       3
; Total bytes of code 323
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M05_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M05_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M05_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M05_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M05_L01
M05_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M05_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M05_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.GenerateUrlHostNameNoSubDomain()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rbx,rcx
       mov       rcx,18145C012F8
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
       call      qword ptr [7FFBB45441B0]; System.Security.Cryptography.RandomNumberGenerator.GetInt32(Int32, Int32)
       cmp       eax,edi
       jae       short M00_L02
       mov       ecx,eax
       mov       rcx,[rsi+rcx*8+10]
       mov       [rsp+28],rcx
       mov       rbx,[rbx+90]
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
       call      qword ptr [7FFBB42A4240]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rsi,rax
       jmp       short M00_L00
M00_L02:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
M00_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 143
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
       mov       rax,7FFBB4364D88
       mov       [rbp-70],rax
       lea       rax,[M01_L01]
       mov       [rbp-60],rax
       lea       rax,[rbp-80]
       mov       [rdi+8],rax
       mov       byte ptr [rdi+4],0
       mov       rax,7FFC3B843670
       call      rax
M01_L01:
       mov       byte ptr [rdi+4],1
       cmp       dword ptr [7FFC13E53A90],0
       je        short M01_L02
       call      qword ptr [7FFC13E42648]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFBB45E58F0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBB42A4528]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       eax,ebx
       jmp       short M01_L03
M01_L06:
       mov       ecx,eax
       call      qword ptr [7FFBB45E4F48]
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
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
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
       call      qword ptr [7FFC0D8A4C78]
       int       3
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1A0]
       jmp       short M02_L01
       mov       rcx,rbx
       xor       edx,edx
       call      qword ptr [7FFC0D8AE1A8]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ViaFactory(System.Threading.LazyThreadSafetyMode)
       jmp       short M02_L01
       mov       rcx,[rbx]
       call      qword ptr [7FFC0D88B838]
       mov       rcx,rax
       call      qword ptr [7FFC0D892EA0]
       mov       rcx,rax
       call      qword ptr [7FFC0D8B4008]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
       mov       rax,[rbx+10]
       test      rax,rax
       je        short M02_L05
       mov       rcx,[rax+8]
       call      qword ptr [rax+18]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1B8]
       jmp       near ptr M02_L01
M02_L05:
       mov       rcx,rbx
       call      qword ptr [7FFC0D8AE1C8]
       jmp       near ptr M02_L01
       mov       rcx,rbx
       mov       rdx,rsi
       mov       r8d,1
       call      qword ptr [7FFC0D8AE1B0]; Precode of System.Lazy`1[[System.__Canon, System.Private.CoreLib]].ExecutionAndPublication(System.LazyHelper, Boolean)
       jmp       near ptr M02_L01
; Total bytes of code 269
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataBenchmark.PersonGetAge()
       push      rbx
       sub       rsp,30
       mov       rbx,rcx
       mov       rdx,[rbx+50]
       mov       rcx,7FFBB45AE820
       call      qword ptr [7FFBB455E7C0]; DotNetTips.Spargine.Tester.Extensions.PersonExtensions.get_Age[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](DotNetTips.Spargine.Tester.Models.Common.IPerson`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rbx+90]
       cmp       [rcx],cl
       lea       rcx,[rsp+28]
       call      qword ptr [7FFBB455E898]; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       nop
       add       rsp,30
       pop       rbx
       ret
; Total bytes of code 60
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
       mov       rax,7FFC3C2B5390
       call      rax
       mov       rsi,[rsp+28]
       mov       rax,1A6D1401B08
       mov       rdi,[rax]
       sub       rsi,[rdi+8]
       cmp       dword ptr [7FFC13E53A90],0
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
       mov       rdx,7FFBB4594B50
       call      qword ptr [7FFBB4127B88]; System.Runtime.CompilerServices.GenericsHelpers.Method(IntPtr, IntPtr)
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
       call      qword ptr [7FFBB4437090]; System.DateTime.UpdateLeapSecondCacheAndReturnUtcNow()
       mov       rsi,rax
       jmp       short M01_L03
; Total bytes of code 243
```
```assembly
; BenchmarkDotNet.Engines.DeadCodeEliminationHelper.KeepAliveWithoutBoxingReadonly[[System.TimeSpan, System.Private.CoreLib]](System.TimeSpan ByRef)
       ret
; Total bytes of code 1
```

## .NET 10.0.12 (10.0.12, 10.0.1226.42308), X64 RyuJIT x86-64-v3 (Job: Job-PSYKRA(EvaluateOverhead=True, Runtime=.NET 10.0, Server=True))

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
       sub       rsp,78
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqu   ymmword ptr [rsp+40],ymm4
       vmovdqa   xmmword ptr [rsp+60],xmm4
       mov       [rsp+70],rax
       mov       rbx,rcx
       mov       rsi,[rbx+50]
       mov       rcx,2B5E1C00C88
       mov       rdi,[rcx]
       mov       rcx,2B5E1C00C90
       mov       rbp,[rcx]
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M00_L05
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M00_L05
M00_L00:
       mov       rcx,[rax+10]
       test      rcx,rcx
       je        near ptr M00_L07
       mov       eax,[rcx+8]
       cmp       eax,4
       jle       near ptr M00_L07
       mov       r14,[rcx+50]
       test      r14,r14
       je        near ptr M00_L07
       xor       eax,eax
       mov       [rcx+50],rax
       cmp       byte ptr [rbp+9D],0
       jne       near ptr M00_L06
M00_L01:
       mov       [rsp+58],r14
       lea       r8,[r14+10]
       mov       edx,[r14+8]
       mov       [rsp+68],r8
       mov       [rsp+70],edx
       xor       r8d,r8d
       mov       [rsp+60],r8d
       mov       byte ptr [rsp+64],0
       mov       rdx,[rsi+20]
       cmp       byte ptr [rsp+64],0
       jne       near ptr M00_L21
       test      rdx,rdx
       je        near ptr M00_L21
       mov       r8d,[rsp+60]
       mov       ecx,[rsp+70]
       cmp       r8d,ecx
       ja        near ptr M00_L23
       mov       rax,[rsp+68]
       mov       r10d,r8d
       lea       rax,[rax+r10*2]
       sub       ecx,r8d
       mov       edi,[rdx+8]
       cmp       edi,ecx
       ja        near ptr M00_L21
       mov       r8d,edi
       add       r8,r8
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+60]
       mov       [rsp+60],edi
M00_L02:
       lea       rcx,[rsp+50]
       mov       edx,20
       call      qword ptr [7FFBB4515E30]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       mov       rdx,[rsi+30]
       cmp       byte ptr [rsp+64],0
       jne       near ptr M00_L22
       test      rdx,rdx
       je        near ptr M00_L22
       mov       r8d,[rsp+60]
       mov       ecx,[rsp+70]
       cmp       r8d,ecx
       ja        near ptr M00_L23
       mov       rax,[rsp+68]
       mov       r10d,r8d
       lea       rax,[rax+r10*2]
       sub       ecx,r8d
       mov       esi,[rdx+8]
       cmp       esi,ecx
       ja        near ptr M00_L22
       mov       r8d,esi
       add       r8,r8
       add       rdx,0C
       mov       rcx,rax
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       esi,[rsp+60]
       mov       [rsp+60],esi
M00_L03:
       mov       ecx,[rsp+60]
       cmp       ecx,[rsp+70]
       ja        near ptr M00_L23
       mov       rax,[rsp+68]
       mov       [rsp+38],rax
       mov       [rsp+40],ecx
       lea       rcx,[rsp+38]
       call      System.String.Ctor(System.ReadOnlySpan`1<Char>)
       mov       rsi,rax
       mov       rdx,[rsp+58]
       xor       ecx,ecx
       mov       [rsp+58],rcx
       vxorps    xmm0,xmm0,xmm0
       vmovdqu   xmmword ptr [rsp+68],xmm0
       mov       [rsp+60],ecx
       test      rdx,rdx
       je        short M00_L04
       mov       rcx,2B5E1C00C88
       mov       rcx,[rcx]
       xor       r8d,r8d
       call      qword ptr [7FFBB41AFB50]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
M00_L04:
       mov       [rsp+48],rsi
       mov       rbx,[rbx+90]
       mov       rdx,[rsp+48]
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
M00_L05:
       mov       ecx,3
       call      qword ptr [7FFBB45B50F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M00_L00
M00_L06:
       mov       rcx,r14
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FFBB45B5758]
       jmp       near ptr M00_L01
M00_L07:
       mov       rcx,[rdi+10]
       cmp       dword ptr [rcx+8],4
       jle       near ptr M00_L19
       mov       rcx,[rcx+30]
       test      rcx,rcx
       je        near ptr M00_L18
       mov       r14,[rcx+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E2B17C],0
       je        short M00_L08
       call      qword ptr [7FFBB45B5770]
       mov       r15d,eax
       jmp       short M00_L10
M00_L08:
       mov       ecx,9
       call      qword ptr [7FFBB45B5788]
       mov       r15d,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFBB45B5788]
       lea       ecx,[r15-1]
       mov       [rax+10],ecx
       movzx     eax,r15w
       test      eax,eax
       jne       short M00_L09
       call      qword ptr [7FFBB45B57A0]
       mov       r15d,eax
       jmp       short M00_L10
M00_L09:
       sar       r15d,10
M00_L10:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,r15d
       xor       edx,edx
       div       dword ptr [7FFBB3E2B170]
       mov       r15d,edx
       xor       r13d,r13d
       jmp       short M00_L14
M00_L11:
       cmp       r15d,[r14+8]
       jae       near ptr M00_L24
       mov       ecx,r15d
       mov       r12,[r14+rcx*8+10]
       cmp       [r12],r12b
       xor       eax,eax
       mov       [rsp+30],rax
       mov       rcx,r12
       call      qword ptr [7FFBB441E520]; System.Threading.Monitor.Enter(System.Object)
       mov       rcx,[r12+8]
       mov       eax,[r12+10]
       dec       eax
       cmp       [rcx+8],eax
       jbe       short M00_L12
       mov       edx,eax
       mov       rdx,[rcx+rdx*8+10]
       mov       [rsp+30],rdx
       mov       r8d,eax
       xor       r10d,r10d
       mov       [rcx+r8*8+10],r10
       mov       [r12+10],eax
M00_L12:
       mov       rcx,r12
       call      qword ptr [7FFBB3EE6820]; System.Threading.Monitor.Exit(System.Object)
       mov       r12,[rsp+30]
       test      r12,r12
       jne       short M00_L15
       inc       r15d
       cmp       [r14+8],r15d
       jne       short M00_L13
       xor       r15d,r15d
M00_L13:
       inc       r13d
M00_L14:
       cmp       [r14+8],r13d
       jg        short M00_L11
       jmp       short M00_L16
M00_L15:
       mov       r14,r12
       jmp       short M00_L17
M00_L16:
       xor       r14d,r14d
M00_L17:
       test      r14,r14
       je        short M00_L18
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L01
       mov       rcx,r14
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       r13d,[r14+8]
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],4
       mov       edx,r15d
       mov       r8d,r13d
       mov       rcx,rbp
       call      qword ptr [7FFBB45B5758]
       jmp       near ptr M00_L01
M00_L18:
       mov       edx,100
       mov       rcx,offset MT_System.Char[]
       call      CORINFO_HELP_NEWARR_1_VC
       mov       r14,rax
       cmp       byte ptr [rbp+9D],0
       je        near ptr M00_L01
       jmp       short M00_L20
M00_L19:
       mov       ecx,100
       mov       rdx,2F676AC6F28
       call      qword ptr [7FFBB410DBC0]; System.ArgumentOutOfRangeException.ThrowIfNegative[[System.Int32, System.Private.CoreLib]](Int32, System.String)
       jmp       short M00_L18
M00_L20:
       mov       rcx,r14
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       edx,r15d
       mov       r8d,100
       mov       rcx,rbp
       call      qword ptr [7FFBB45B5758]
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
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
       call      qword ptr [7FFBB45B57B8]
       jmp       near ptr M00_L01
M00_L21:
       lea       rcx,[rsp+50]
       call      qword ptr [7FFBB45B5650]
       jmp       near ptr M00_L02
M00_L22:
       lea       rcx,[rsp+50]
       call      qword ptr [7FFBB45B5650]
       jmp       near ptr M00_L03
M00_L23:
       call      qword ptr [7FFBB40571C8]
       int       3
M00_L24:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1227
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
       jmp       qword ptr [7FFBB3EE66E8]; System.Buffer.MemmoveInternal(Byte ByRef, Byte ByRef, UIntPtr)
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
       jmp       qword ptr [7FFBB45B5AB8]
M02_L02:
       mov       rcx,rbx
       call      qword ptr [7FFBB45165B0]
       jmp       short M02_L00
M02_L03:
       call      qword ptr [7FFBB40571C8]
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
       call      00007FFC13B952E0
       mov       rdi,rax
       cmp       [rdi],dil
       lea       rcx,[rdi+0C]
       mov       r8d,esi
       add       r8,r8
       mov       rdx,rbx
       call      qword ptr [7FFBB3EE5818]; System.SpanHelpers.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rax,rdi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M03_L00:
       mov       rax,2F676AC0008
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 88
```
```assembly
; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].Return(Char[], Boolean)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       test      rbx,rbx
       je        near ptr M04_L05
       mov       ebp,[rbx+8]
       lea       ecx,[rbp-1]
       or        ecx,0F
       xor       r14d,r14d
       lzcnt     r14d,ecx
       xor       r14d,1F
       add       r14d,0FFFFFFFD
       mov       rcx,gs:[58]
       mov       rcx,[rcx+38]
       cmp       dword ptr [rcx+238],3
       jle       near ptr M04_L06
       mov       rcx,[rcx+240]
       mov       rax,[rcx+18]
       test      rax,rax
       je        near ptr M04_L06
M04_L00:
       mov       r15,[rax+10]
       test      r15,r15
       je        near ptr M04_L07
M04_L01:
       xor       r13d,r13d
       mov       r12d,1
       cmp       [r15+8],r14d
       jbe       short M04_L03
       mov       r13d,1
       test      sil,sil
       jne       near ptr M04_L08
M04_L02:
       mov       ecx,10
       shlx      ecx,ecx,r14d
       cmp       ebp,ecx
       jne       near ptr M04_L09
       mov       ecx,r14d
       shl       rcx,4
       lea       rsi,[r15+rcx+10]
       mov       r15,[rsi]
       mov       rcx,rsi
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],ecx
       test      r15,r15
       jne       near ptr M04_L10
M04_L03:
       mov       rcx,2B5E1C00C90
       mov       rsi,[rcx]
       cmp       byte ptr [rsi+9D],0
       jne       near ptr M04_L25
M04_L04:
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
M04_L05:
       mov       ecx,2
       call      qword ptr [7FFBB410C258]
       int       3
M04_L06:
       mov       ecx,3
       call      qword ptr [7FFBB45B50F8]; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       jmp       near ptr M04_L00
M04_L07:
       mov       rcx,rdi
       call      qword ptr [7FFBB410CEB8]; System.Buffers.SharedArrayPool`1[[System.Char, System.Private.CoreLib]].InitializeTlsBucketsAndTrimming()
       mov       r15,rax
       jmp       near ptr M04_L01
M04_L08:
       mov       rcx,rbx
       call      qword ptr [7FFBB45B5830]
       jmp       near ptr M04_L02
M04_L09:
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       call      qword ptr [7FFBB45B5848]
       mov       rbx,rax
       mov       ecx,29B
       mov       rdx,7FFBB3E24000
       call      qword ptr [7FFBB41077C8]
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rbp
       call      qword ptr [7FFBB4276418]
       mov       rcx,rbp
       call      CORINFO_HELP_THROW
       int       3
M04_L10:
       mov       rcx,[rdi+10]
       cmp       r14d,[rcx+8]
       jae       near ptr M04_L28
       mov       edx,r14d
       mov       rax,[rcx+rdx*8+10]
       test      rax,rax
       jne       short M04_L11
       mov       rcx,rdi
       mov       edx,r14d
       call      qword ptr [7FFBB45B5860]
M04_L11:
       mov       r12,[rax+8]
       mov       rcx,offset MT_System.Threading.ProcessorIdCache
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       cmp       byte ptr [7FFBB3E2B17C],0
       je        short M04_L12
       call      qword ptr [7FFBB45B5770]
       mov       esi,eax
       jmp       short M04_L14
M04_L12:
       mov       ecx,9
       call      qword ptr [7FFBB45B5788]
       mov       esi,[rax+10]
       mov       ecx,9
       call      qword ptr [7FFBB45B5788]
       lea       ecx,[rsi-1]
       mov       [rax+10],ecx
       movzx     eax,si
       test      eax,eax
       jne       short M04_L13
       call      qword ptr [7FFBB45B57A0]
       mov       esi,eax
       jmp       short M04_L14
M04_L13:
       sar       esi,10
M04_L14:
       mov       rcx,offset MT_System.Buffers.SharedArrayPoolStatics
       call      qword ptr [7FFBB3EE5740]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBase(System.Runtime.CompilerServices.MethodTable*)
       mov       eax,esi
       xor       edx,edx
       div       dword ptr [7FFBB3E2B170]
       mov       esi,edx
       xor       eax,eax
       jmp       near ptr M04_L21
M04_L15:
       cmp       esi,[r12+8]
       jae       near ptr M04_L28
       mov       ecx,esi
       mov       rdx,[r12+rcx*8+10]
       mov       [rsp+30],rdx
       cmp       [rdx],dl
       xor       r8d,r8d
       mov       [rsp+3C],r8d
       mov       rcx,rdx
       call      qword ptr [7FFBB441E520]; System.Threading.Monitor.Enter(System.Object)
       mov       rax,[rsp+30]
       mov       rcx,[rax+8]
       mov       r8d,[rax+10]
       mov       [rsp+38],r8d
       cmp       [rcx+8],r8d
       jbe       short M04_L17
       test      r8d,r8d
       jne       short M04_L18
       xor       edx,edx
       mov       [rax+14],edx
M04_L16:
       mov       edx,r8d
       lea       rcx,[rcx+rdx*8+10]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rsp+38]
       inc       ecx
       mov       rax,[rsp+30]
       mov       [rax+10],ecx
       mov       dword ptr [rsp+3C],1
M04_L17:
       mov       rcx,rax
       call      qword ptr [7FFBB3EE6820]; System.Threading.Monitor.Exit(System.Object)
       cmp       dword ptr [rsp+3C],0
       je        short M04_L19
       jmp       short M04_L22
M04_L18:
       jmp       short M04_L16
M04_L19:
       inc       esi
       cmp       [r12+8],esi
       jne       short M04_L20
       xor       esi,esi
M04_L20:
       mov       eax,[rsp+40]
       inc       eax
M04_L21:
       mov       [rsp+40],eax
       cmp       [r12+8],eax
       jg        near ptr M04_L15
       jmp       short M04_L23
M04_L22:
       mov       r12d,1
       jmp       short M04_L24
M04_L23:
       xor       r12d,r12d
M04_L24:
       jmp       near ptr M04_L03
M04_L25:
       test      ebp,ebp
       je        near ptr M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r15d,eax
       mov       [rsp+44],ebp
       cmp       [rdi],dil
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       [rsp+20],eax
       mov       rcx,rsi
       mov       r8d,r15d
       mov       r9d,[rsp+44]
       mov       edx,3
       call      qword ptr [7FFBB45B5878]
       test      r12d,r13d
       jne       near ptr M04_L04
       mov       rcx,rbx
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       ebx,eax
       mov       rcx,rdi
       call      qword ptr [7FFBB432D980]; System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(System.Object)
       mov       r9d,eax
       test      r13d,r13d
       jne       short M04_L26
       mov       ecx,0FFFFFFFF
       mov       edx,1
       jmp       short M04_L27
M04_L26:
       mov       ecx,r14d
       xor       edx,edx
M04_L27:
       mov       [rsp+20],ecx
       mov       [rsp+28],edx
       mov       rcx,rsi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFBB45B5890]
       jmp       near ptr M04_L04
M04_L28:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 877
```
```assembly
; System.Runtime.CompilerServices.StaticsHelpers.GetOptimizedGCThreadStaticBase(Int32)
       push      rbx
       sub       rsp,20
       mov       ebx,ecx
       call      qword ptr [7FFC0D8A1D18]; Precode of System.Threading.Thread.GetThreadStaticsBase()
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
       call      qword ptr [7FFC0D8A4DC8]
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
       jmp       qword ptr [7FFBB410E340]; System.Runtime.CompilerServices.StaticsHelpers.GetNonGCStaticBaseSlow(System.Runtime.CompilerServices.MethodTable*)
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
       call      qword ptr [7FFC0D8A1BD8]
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
       call      qword ptr [7FFC0D89C210]
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
       call      00007FFC13B9E040
       test      eax,eax
       jne       short M09_L01
       add       rsp,20
       pop       rbx
       ret
M09_L00:
       xor       ecx,ecx
       call      qword ptr [7FFBB45B4E28]
       int       3
M09_L01:
       mov       ecx,eax
       mov       rdx,rbx
       add       rsp,20
       pop       rbx
       jmp       qword ptr [7FFBB45B4F30]
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
       call      qword ptr [7FFC0D8B1908]
       int       3
; Total bytes of code 20
```

